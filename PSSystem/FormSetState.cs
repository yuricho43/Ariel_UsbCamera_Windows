using OpenCvSharp.Flann;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
//using System.Web.UI.WebControls;
using System.Windows.Forms;

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
        public int[] iPrevEventType  = { 0, 0, 0, 0, 0} ;
        public NeoQueue gQueueEvent = new NeoQueue(2048);
        public NeoQueue gQueueLog = new NeoQueue(2048);

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

            //--- Create Logging Thread
            //    - Check Queue and Save 
            gQueueEvent.Initialize();
            gQueueLog.Initialize();

            Thread t1 = new Thread(new ThreadStart(LogAndEventWrite));
            t1.Start();
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
                listView1.Invoke((MethodInvoker)delegate ()
                {
                    // 온도
                    ListViewItem item = listView1.Items[iCh];
                    for (int i = 0; i < 16; i++)
                    {
                        Globals.gTemp16[iCh, i] = Globals.GetShortValueFrom2bytes(Globals.gTempValue[iCh, 2*i], Globals.gTempValue[iCh, 2*i+1]);
                        item.SubItems[i+1].Text = Globals.gTemp16[iCh, i].ToString();
                    }
                });

                // 센서
                listView2.Invoke((MethodInvoker)delegate ()
                {
                    ListViewItem item = listView2.Items[iCh];
                    for (int i = 0; i < 16; i++)
                    {
                        Globals.gSensor16[iCh, i] = Globals.GetShortValueFrom2bytes(Globals.gSensorValue[iCh, 2 * i], Globals.gSensorValue[iCh, 2 * i + 1]);
                        item.SubItems[i+1].Text = Globals.gSensor16[iCh, i].ToString();
                    }
                });

                // 사운드
                listView3.Invoke((MethodInvoker)delegate ()
                {
                    ListViewItem item = listView3.Items[iCh];
                    Globals.gSound16[iCh] = Globals.GetShortValueFrom2bytes(Globals.gSoundValue[iCh, 0], Globals.gSoundValue[iCh, 1]);
                    item.SubItems[1].Text = Globals.gSound16[iCh].ToString(); ;
                });

                // 자이로
                listView4.Invoke((MethodInvoker)delegate ()
                {
                    ListViewItem item = listView4.Items[iCh];
                    Globals.gXiro16[iCh] = Globals.GetShortValueFrom2bytes(Globals.gXiroValue[iCh, 0], Globals.gXiroValue[iCh, 1]);
                    item.SubItems[1].Text = Globals.gXiro16[iCh].ToString(); ;
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
                timer1.Interval = Globals.gOtherConfig[1];
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
            GSerial.Send_Equiry_Data(bCmd, 0x00);
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
            GSerial.Send_Equiry_Data(gCmd[gCurMode++ % 5], 0);
        }


        // bCh = b1~b4, c1  (ix=1)
        // data : from STX to ETX
        // Globlas.gXXXX16[]에는 이미 값이 들어가 있다.
        void Check_Event_And_Data_Logging(byte[] data, byte bCh, int len)
        {
            byte[] bLog   = new byte[79];   // HMSMS+type(2)+Data(72bytes) = 79bytes
            byte[] bEvent = new byte[79];   // MDHMS+type(2)+Data(72bytes) = 79bytes
            int iType = 0;
            int IDataSize = 79;
            // int iValue = 0;

            //------------------------------------------------------------------
            // Check Event (Warning, Critical)
            if (bCh == (byte)CH_INDEX.CH_RELAY)
                return;

            DateTime curDate = DateTime.Now;
            int ix = (int)(bCh - (byte)0xb1);
            if (ix < 0 || ix > 3)
                return;

            // check each temperature (gWarningThreshold/gCriticalThreshold[4])  // data[2~33]
            // check each sensors/fire (gWarningThreshold/gCriticalThreshold[0/1])  // data[34~65]
            // check each sounds      (gWarningThreshold/gCriticalThreshold[3])  // data[66~67]
            // check      xiro        ((gWarningThreshold/gCriticalThreshold[2]) // data[68~69]

            // iType : critical or warning. two bit for each value
            //     (arc,  fire, vib, sound,     temp)
            //  bit  98     76    54     32      10
            //     0x300   0xC0  0x30   0x0C    0x03

            //=== Sensor (Fire & Arc)
            //    Fire1 Arc1 Fire2 Arc2 ... Fire8 Arc8
            iType &= 0x03F;
            Globals.gAvgValue[ix, 0] = 0;  // Arc
            Globals.gAvgValue[ix, 1] = 0;  // Fire
            for (int i = 0; i < 16; i++)
            {
                // iValue = (int)((ushort)(data[34 + 2 * i] * 256) + data[34 + 2 * i + 1]);

                if ( (i % 2) == 0)  // Fire
                {
                    Globals.gAvgValue[ix, 1] += Globals.gSensor16[ix, i];
                    if (Globals.gSensor16[ix, i] > Globals.gWarningThreshold[1])
                        if (Globals.gSensor16[ix, i] > Globals.gCriticalThreshold[1])
                        {
                            iType |= 0x80;
                            break;
                        }
                        else
                            iType |= 0x40;
                }
                else                // Arc
                {
                    Globals.gAvgValue[ix, 0] += Globals.gSensor16[ix, i];

                    if (Globals.gSensor16[ix, i] > Globals.gWarningThreshold[0])
                        if (Globals.gSensor16[ix, i] > Globals.gCriticalThreshold[0])
                        {
                            iType |= 0x200;
                            break;
                        }
                        else
                            iType |= 0x100;
                }
            }
            Globals.gAvgValue[ix, 0] = Globals.gAvgValue[ix, 0] / 8;
            Globals.gAvgValue[ix, 1] = Globals.gAvgValue[ix, 1] / 8;

            //=== Xiro(Vib)
            // iValue = (int)((ushort)(data[68] * 256) + data[69]);
            Globals.gAvgValue[ix, 2] = Globals.gXiro16[ix];
            iType &= 0xFCF;
            if (Globals.gXiro16[ix] > Globals.gWarningThreshold[2])
            {
                if (Globals.gXiro16[ix] > Globals.gCriticalThreshold[2])
                {
                    iType |= 0x20;
                }
                else
                    iType |= 0x10;
            }

            //=== Sound
            // iValue = (int)((ushort)(data[66] * 256) + data[67]);
            Globals.gAvgValue[ix, 3] = Globals.gSound16[ix];
            iType &= 0xFF3;
            if (Globals.gSound16[ix] > Globals.gWarningThreshold[3])
            {
                if (Globals.gSound16[ix] > Globals.gCriticalThreshold[3])
                {
                    iType |= 0x08;
                }
                else
                    iType |= 0x04;
            }

            //=== Temp
            iType &= 0xFFC;
            Globals.gAvgValue[ix, 4] = 0;
            for (int i = 0; i < 16; i++)
            {
                // iValue = (int)((ushort)(data[2 + 2 * i] * 256) + data[2 + 2 * i + 1]);
                Globals.gAvgValue[ix, 4] += Globals.gTemp16[ix,i];
                if (Globals.gTemp16[ix, i] > Globals.gWarningThreshold[4])
                    if (Globals.gTemp16[ix, i] > Globals.gCriticalThreshold[4])
                    {
                        iType |= 0x02;
                        break;
                    }
                    else
                        iType |= 0x01;
            }
            Globals.gAvgValue[ix, 4] = Globals.gAvgValue[ix, 4] / 16;

            //------------------------------------------------------------------
            // Logging Event
            // MDHMS type data : 상위 4bit : sensor (C해제 W해제 CR WR)
            //                   하위 4bit : temperature
            //--- 이전의 Warning/Critical/Normal 값을 기억하고 있다가, 변경되면 Event 기록

            bEvent[0] = (byte)curDate.Month;
            bEvent[1] = (byte)curDate.Day;
            bEvent[2] = (byte)curDate.Hour;
            bEvent[3] = (byte)curDate.Minute;
            bEvent[4] = (byte)curDate.Second;
            bEvent[5] = (byte)((iType & 0xFF00) >> 8);                  // On Log, no meaning
            bEvent[6] = (byte)(iType & 0xFF);               
            Buffer.BlockCopy(data, 0, bEvent, 7, len);      // total length = 7 + data

            //--- 이벤트가 발생했거나 클리어 되었으면, 메인 화면으로 변경정보를 보낸다.
            //    1) 데이타도 같이 보내서 평균값계산하게 하고, 오류난 곳 위치도 파악하게 한다.
            if (iPrevEventType[ix] != iType)
            {
                if (gQueueEvent.GetFreeSize() < (IDataSize))
                    gQueueEvent.FlushData( (UInt32)IDataSize);

                gQueueEvent.PutData(bEvent, (UInt32)IDataSize);
                iPrevEventType[ix] = iType;

                // Call Main Panel Function
                ((FormMain) Globals.gFormList[(int)FORM_INDEX.NO_FORM_MAIN]).NotifyEvent(iType, ix);

                if (iType != 0) // go to main
                {
                    if (Globals.gCurrentIndex != (int)FORM_INDEX.NO_FORM_MAIN)
                    {

                        Globals.gFormList[(int)FORM_INDEX.NO_FORM_MAIN].Invoke((MethodInvoker)delegate ()
                        {
                            Globals.gFormList[(int)FORM_INDEX.NO_FORM_MAIN].Show();
                        });

                        Globals.gFormList[Globals.gCurrentIndex].Invoke((MethodInvoker)delegate ()
                        {
                            Globals.gFormList[Globals.gCurrentIndex].Hide();
                        });

                        Globals.gCurrentIndex = (int)FORM_INDEX.NO_FORM_MAIN;
                    }
                }
            } else
            {
                ((FormMain)Globals.gFormList[(int)FORM_INDEX.NO_FORM_MAIN]).NotifyEvent(iType, ix);
            }

            //------------------------------------------------------------------
            // Logging Data (all are 75 bytes including relay
            // FileName: Log_YYYYMMDD.bin
            // HMS+ DATA

            if (Globals.gOtherConfig[2] != 0)
            {
                if (gQueueLog.GetFreeSize() < (IDataSize))
                    gQueueLog.FlushData((UInt32)IDataSize);

                gQueueLog.PutData(bEvent, (UInt32)IDataSize);
            }
        }

        void LogAndEventWrite()
        {
            byte[] bTemp = new byte[2048];
            int iiSize = 0;

            while (true) 
            {
                // write Event
                iiSize = (int) gQueueEvent.GetFillSize();
                if (iiSize > 0)
                {
                    string strLogFile = DateTime.Now.ToString("yyyyMM") + "_events.bin";
                    gQueueEvent.GetData(bTemp, (uint) iiSize);
                    lock (Globals.gLockEvent)
                    {
                        using (BinaryWriter bw = new BinaryWriter(File.Open(strLogFile, FileMode.Append)))
                        {
                            bw.Write(bTemp, 0, iiSize);
                        }
                    }
                }
                iiSize = (int)gQueueEvent.GetFillSize();

                if (Globals.gOtherConfig[2] != 0)       // Log Enabled
                {
                    // write Data
                    iiSize = (int)gQueueLog.GetFillSize();
                    if (iiSize > 0)
                    {
                        string strLogFile = DateTime.Now.ToString("yyyyMMdd") + "_log.bin";
                        gQueueLog.GetData(bTemp, (uint)iiSize);
                        lock(Globals.gLockLog)
                        {
                            using (BinaryWriter bw = new BinaryWriter(File.Open(strLogFile, FileMode.Append)))
                            {
                                bw.Write(bTemp, 0, iiSize);
                            }
                        }
                    }
                }

                Thread.Sleep(10);
            }
        }

        private void timerGotoMain_Tick(object sender, EventArgs e)
        {
            //timerGotoMain.Enabled = false;
            Globals.ChangeForm((int)FORM_INDEX.NO_FORM_MAIN);
        }
    }
}
