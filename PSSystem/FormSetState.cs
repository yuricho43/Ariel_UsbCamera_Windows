using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PSSystem
{
    public partial class FormSetState : Form
    {
        public int gAutoEnqStarted = 0;
        public int gCurMode = 0;    // 0~4
        public byte[] gCmd = { (byte)0xa1, (byte)0xa2, (byte)0xa3, (byte)0xa4, (byte)0xc0 };
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Globals.gCurrentIndex != (int)FORM_INDEX.NO_FORM_MAIN)
                Globals.ChangeForm((int)FORM_INDEX.NO_FORM_MAIN);
        }

        /*      STX     Index   온도     센서    사운드  자이로 CS    ETX       (39 bytes)
            1번	0x02	0xb1	16byte	16byte	2byte	1byte Ex-Or	0x03
            2번	0x02	0xb2	16byte	16byte	2byte	1byte Ex-Or	0x03
            3번	0x02	0xb3	16byte	16byte	2byte	1byte Ex-Or	0x03
            4번	0x02	0xb4	16byte	16byte	2byte	1byte Ex-Or	0x03

        	    STX	    index	Header	Data1	Data1	Data1	CS	    ETX   (8bytes)
          릴레이	0x02	0xc1	0x01	1byte	1byte	1byte	Ex-Or	0x03
        */
        public void ParseSensorData(byte[] data, int len)
        {
            // temp, sensor : 16개 data
            // sound : 2개 data
            // xiro  : 1개 data

            //--- Gathering Data
            if (data[1] == (byte) 0xb1)     // ch1
            {
                for (int i = 0; i < 16; i++)
                {
                    Globals.gTempValue[0, i] = data[i + 2];             // 온도
                    Globals.gSensorValue[0, i] = data[i + 2 + 16];      // 센서
                }
                Globals.gSoundValue[0, 0] = data[34];
                Globals.gSoundValue[0, 1] = data[35];
                Globals.gXiroValue[0] = data[36];
                Display_Sensor_Data(0);
            }
            else if (data[1] == (byte)0xb2)
            {
                for (int i = 0; i < 16; i++)
                {
                    Globals.gTempValue[1, i] = data[i + 2];
                    Globals.gSensorValue[1, i] = data[i + 2 + 16];      // 센서
                }
                Globals.gSoundValue[1, 0] = data[34];
                Globals.gSoundValue[1, 1] = data[35];
                Globals.gXiroValue[1] = data[36];
                Display_Sensor_Data(1);
            }
            else if (data[1] == (byte)0xb3)
            {
                for (int i = 0; i < 16; i++)
                {
                    Globals.gTempValue[2, i] = data[i + 2];
                    Globals.gSensorValue[2, i] = data[i + 2 + 16];      // 센서
                }
                Globals.gSoundValue[2, 0] = data[34];
                Globals.gSoundValue[2, 1] = data[35];
                Globals.gXiroValue[2] = data[36];
                Display_Sensor_Data(2);
            }
            else if (data[1] == (byte)0xb4)
            {
                for (int i = 0; i < 16; i++)
                {
                    Globals.gTempValue[3, i] = data[i + 2];
                    Globals.gSensorValue[3, i] = data[i + 2 + 16];      // 센서
                }
                Globals.gSoundValue[3, 0] = data[34];
                Globals.gSoundValue[3, 1] = data[35];
                Globals.gXiroValue[3] = data[36];
                Display_Sensor_Data(3);
            }
            else if (data[1] == (byte)0xc1)
            {
                for (int i = 0; i < 3; i++)
                {
                    Globals.gRelayValue[i] = data[i+3];
                }
                Display_Sensor_Data(4);
            }
        }

        // iCh 0~3, 4   : CH1~Ch4, Relay, all
        public void Display_Sensor_Data(int iCh)
        {
            if (iCh >= 0 && iCh <=3)       //  Dispaly 온도, 센서, 사운드, 자이로
            {
                listView1.Invoke((MethodInvoker)delegate ()
                {
                    // 온도
                    ListViewItem item = listView1.Items[iCh];
                    for (int i = 1; i <= 16; i++)
                    {
                        item.SubItems[i].Text = Globals.gTempValue[iCh, i - 1].ToString();
                    }
                });

                // 센서
                listView2.Invoke((MethodInvoker)delegate ()
                {
                    ListViewItem item = listView2.Items[iCh];
                    for (int i = 1; i <= 16; i++)
                    {
                        item.SubItems[i].Text = Globals.gSensorValue[iCh, i - 1].ToString();
                    }
                });

                // 사운드
                listView3.Invoke((MethodInvoker)delegate ()
                {
                    ListViewItem item = listView3.Items[iCh];
                    for (int i = 1; i <= 2; i++)
                    {
                        item.SubItems[i].Text = Globals.gSoundValue[iCh, i - 1].ToString();
                    }
                });

                // 자이로
                listView4.Invoke((MethodInvoker)delegate ()
                {
                    ListViewItem item = listView4.Items[iCh];
                    for (int i = 1; i <= 1; i++)
                    {
                        item.SubItems[i].Text = Globals.gXiroValue[iCh].ToString();
                    }
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte bCmd = Convert.ToByte(textBox1.Text, 16);

                  GSerial.Send_Equiry_Data(bCmd);
        }
  private void btnAuto_Click(object sender, EventArgs e)
        {
            if (gAutoEnqStarted == 0) 
            {
                gAutoEnqStarted = 1;
                btnAuto.Text = "자동Enq 중지";
                timer1.Enabled = true;
            }
            else
            {
                gAutoEnqStarted = 0;
                btnAuto.Text = "자동Enq 시작";
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GSerial.Send_Equiry_Data(gCmd[gCurMode++ % 5]);
        }
    }
}
