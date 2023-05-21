using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Markup;

namespace PSSystem
{
    enum CH_INDEX
    {
        CH_ONE = 0xb1,
        CH_TWO = 0xb2,
        CH_THREE = 0xb3,
        CH_FOUR = 0xb4,
        CH_RELAY = 0xc1
    };

    public partial class FormSetState : Form
    {
        public int gAutoEnqStarted = 0;
        public int gCurMode = 0;    // 0~4
        public byte[] gCmd = { (byte)0xa1, (byte)0xa2, (byte)0xa3, (byte)0xa4, (byte)0xc0 };
        public byte[] bPrevEventType  = { (byte)0, (byte)0, (byte)0, (byte)0 } ;

        public FormSetState()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label2.Left = (Globals.PANEL_WIDTH - label2.Width) / 2;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Globals.gCurrentIndex != (int)FORM_INDEX.NO_FORM_MAIN)
                Globals.ChangeForm((int)FORM_INDEX.NO_FORM_MAIN);
        }

        /* ix    0         1      2      34      66     68    70    71
         *      STX     Index   온도     센서    사운드  자이로 CS    ETX   (39 bytes ==> 2 + 32 + 32 + 2 + 2 + 2 = 72)
          센서	0x02	0xb1~b4	32byte	32byte	2byte	2byte Ex-Or	0x03
         
           ix    0         1      2      3                    6       7
        	    STX	    index	Header	Data1	Data1	Data1 CS	ETX   (8bytes)
          릴레이	0x02	0xc1	0x01	1byte	1byte	1byte Ex-Or	0x03
        */
        public void ParseSensorData(byte[] data, int len)
        {
            // temp, sensor : 32bytes data
            // sound : 2byte data
            // xiro  : 2byte data

            //--- Gathering Data
            if (data[1] >= (byte) 0xb1 && data[1] <= (byte) 0xb4)
            {
                int iCh = (int)(data[1] - (byte)0xb1);

                for (int i = 0; i < 32; i++)
                {
                    Globals.gTempValue[iCh, i] = data[i + 2];             // 온도
                    Globals.gSensorValue[iCh, i] = data[i + 2 + 32];      // 센서
                }
                Globals.gSoundValue[iCh, 0] = data[66];
                Globals.gSoundValue[iCh, 1] = data[67];
                Globals.gXiroValue[iCh, 0] = data[68];
                Globals.gXiroValue[iCh, 1] = data[69];
                Display_Sensor_Data(iCh);
            } else if (data[1] == (byte)CH_INDEX.CH_RELAY)
            {
                for (int i = 0; i < 3; i++)
                {
                    Globals.gRelayValue[i] = data[i+3];
                }
                Display_Sensor_Data(4);
            } else
            {
                return;
            }

            Check_Event_And_Data_Logging(data, data[1], len);
        }

        // iCh 0~3, 4   : CH1~Ch4, Relay, all
        public void Display_Sensor_Data(int iCh)
        {
            if (iCh >= 0 && iCh <=3)       //  Display 온도, 센서, 사운드, 자이로
            {
                ushort uValue = 0;
                short sValue = 0;

                listView1.Invoke((MethodInvoker)delegate ()
                {
                    // 온도
                    ListViewItem item = listView1.Items[iCh];
                    for (int i = 0; i < 16; i++)
                    {
                        sValue = Globals.GetShortValueFrom2bytes(Globals.gTempValue[iCh, 2*i], Globals.gTempValue[iCh, 2*i+1]);
                        item.SubItems[i+1].Text = sValue.ToString("X4");
                    }
                });

                // 센서
                listView2.Invoke((MethodInvoker)delegate ()
                {
                    ListViewItem item = listView2.Items[iCh];
                    for (int i = 0; i < 16; i++)
                    {
                        uValue = (ushort)((ushort)(Globals.gSensorValue[iCh, 2 * i] * 256) + Globals.gSensorValue[iCh, 2 * i + 1]);
                        item.SubItems[i+1].Text = uValue.ToString("X4");
                    }
                });

                // 사운드
                listView3.Invoke((MethodInvoker)delegate ()
                {
                    ListViewItem item = listView3.Items[iCh];
                    uValue = (ushort)((ushort)(Globals.gSoundValue[iCh, 0] * 256) + Globals.gSoundValue[iCh, 1]);
                    item.SubItems[1].Text = uValue.ToString("X4"); ;
                });

                // 자이로
                listView4.Invoke((MethodInvoker)delegate ()
                {
                    ListViewItem item = listView4.Items[iCh];
                    uValue = (ushort)((ushort)(Globals.gXiroValue[iCh, 0] * 256) + Globals.gXiroValue[iCh, 1]);
                    item.SubItems[1].Text = uValue.ToString("X4"); ;
                });
            } else if (iCh == 4)    // Relay
            {
                // Relay
                listView5.Invoke((MethodInvoker)delegate ()
                {
                    for (int i = 0; i < 3; i++)
                    {
                        ListViewItem item = listView5.Items[i];
                        item.SubItems[1].Text = Globals.gRelayValue[i].ToString();
                    }
                });
            }
        }

        private void Start_Stop_Sending_AutoEnquiry(bool bStart)
        {
            if (bStart)
            {
                gAutoEnqStarted = 1;
                timer1.Enabled = true;
            }
            else
            {
                gAutoEnqStarted = 0;
                timer1.Enabled = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte bCmd = Convert.ToByte(textBox1.Text, 16);

                  GSerial.Send_Equiry_Data(bCmd);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (gAutoEnqStarted == 0) 
            {
                Start_Stop_Sending_AutoEnquiry(true);
                btnAuto.Text = "자동Enq 중지";
            }
            else
            {
                Start_Stop_Sending_AutoEnquiry(false);
                btnAuto.Text = "자동Enq 시작";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GSerial.Send_Equiry_Data(gCmd[gCurMode++ % 5]);
        }


        // bCh = b1~b4, c1
        void Check_Event_And_Data_Logging(byte[] data, byte bCh, int len)
        {
            byte[] bLog   = new byte[75];   // HMS+Data(72bytes)        = 75bytes
            byte[] bEvent = new byte[78];   // MDHMS+type+Data(72bytes) = 78bytes
            byte bType = (byte)0;
            int iValue = 0;

            //------------------------------------------------------------------
            // Check Event (Warning, Critical)
            if (bCh == (byte)CH_INDEX.CH_RELAY)
                return;

            // check each temperature (gWarningThreshold/gCriticalThreshold[0])  // data[2~33]
            // check each sensors     (gWarningThreshold/gCriticalThreshold[1])  // data[34~65]
            // check each sounds      (gWarningThreshold/gCriticalThreshold[2])  // data[66~67]
            // check      xiro        ((gWarningThreshold/gCriticalThreshold[3]) // data[68~69]

            // bType : critical or warning. two bit for each value
            //     (xiro, sound, sensor, temp)
            //  bit 76    54     32      10
            //     0xC0   0x30   0x0C    0x03
            //=== Temp
            bType &= 0xFC;
            for (int i = 0; i < 16; i++)
            {
                iValue = (int)((ushort)(data[2+2*i] * 256) + data[2+2*i+1]);
                if (iValue > Globals.gWarningThreshold[0])
                    if (iValue > Globals.gCriticalThreshold[0])
                    {
                        bType |=  0x02;
                        break;
                    }
                    else
                        bType |= 0x01;
            }

            //=== Sensor
            bType &= 0xF3;
            for (int i = 0; i < 16; i++)
            {
                iValue = (int)((ushort)(data[34 + 2 * i] * 256) + data[34 + 2 * i + 1]);
                if (iValue > Globals.gWarningThreshold[1])
                    if (iValue > Globals.gCriticalThreshold[1])
                    {
                        bType |= 0x08;
                        break;
                    }
                    else
                        bType |= 0x04;
            }

            //=== Sound
            iValue = (int)((ushort)(data[66] * 256) + data[67]);
            bType &= 0xCF;
            if (iValue > Globals.gWarningThreshold[2])
            {
                if (iValue > Globals.gCriticalThreshold[2])
                {
                    bType |= 0x10;
                }
                else
                    bType |= 0x20;
            }

            //=== Xiro
            iValue = (int)((ushort)(data[68] * 256) + data[69]);
            bType &= 0x3F;
            if (iValue > Globals.gWarningThreshold[3])
            {
                if (iValue > Globals.gCriticalThreshold[3])
                {
                    bType |= 0x40;
                }
                else
                    bType |= 0x80;
            }


            //------------------------------------------------------------------
            // Logging Event
            // MDHMS type data : 상위 4bit : sensor (C해제 W해제 CR WR)
            //                   하위 4bit : temperature
            //--- 이전의 Warning/Critical/Normal 값을 기억하고 있다가, 변경되면 Event 기록
            DateTime curDate = DateTime.Now;
            int ix = (int) (bCh - (byte)0xb1);
            if (ix < 0 || ix > 3)
                return;

            if (bPrevEventType[ix] != bType)
            {
                {
                    string strEventFile = DateTime.Now.ToString("yyyy") + "_event.bin";
                    bEvent[0] = (byte)curDate.Month;
                    bEvent[1] = (byte)curDate.Day;
                    bEvent[2] = (byte)curDate.Hour;
                    bEvent[3] = (byte)curDate.Minute;
                    bEvent[4] = (byte)curDate.Second;
                    bEvent[5] = bType;
                    Buffer.BlockCopy(data, 0, bEvent, 6, len);
                    using (BinaryWriter ew = new BinaryWriter(File.Open(strEventFile, FileMode.Append)))
                    {
                        ew.Write(bEvent);
                    }
                }
                bPrevEventType[ix] = bType;
            }

            //------------------------------------------------------------------
            // Logging Data (all are 75 bytes including relay
            // FileName: Log_YYYYMMDD.bin
            // HMS+ DATA
            string strLogFile = DateTime.Now.ToString("yyyyMMdd") + "_log.bin";
            bLog[0] = (byte)curDate.Hour;
            bLog[1] = (byte)curDate.Minute;
            bLog[2] = (byte)curDate.Second;
            Buffer.BlockCopy(data, 0, bLog, 3, len);

            using (BinaryWriter bw = new BinaryWriter(File.Open(strLogFile, FileMode.Append)))
            {
                bw.Write(bLog);
            }
        }

    }
}
