using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;

namespace PSSystem
{

    
    public partial class FormMain : Form
    {
        Label[,] lState = new Label[4, 5];
        public FormMain()
        {
            InitializeComponent();

            label1.BackColor = Color.Transparent;
            label1.Left = (Globals.PANEL_WIDTH - label1.Width) / 2;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            lblArc.BackColor = Color.Transparent;
            lblFire.BackColor = Color.Transparent;
            lblVib.BackColor = Color.Transparent;
            lblSound.BackColor = Color.Transparent;
            lblTemp.BackColor = Color.Transparent;
            grp1.BackColor = Color.Transparent;
            grp2.BackColor = Color.Transparent;
            grp3.BackColor = Color.Transparent;
            grp4.BackColor = Color.Transparent;

            //--- Assign Label
            lState[0, 0] = lblArc;
            lState[0, 1] = lblFire;
            lState[0, 2] = lblVib;
            lState[0, 3] = lblSound;
            lState[0, 4] = lblTemp;

            lState[1, 0] = lblArc2;
            lState[1, 1] = lblFire2;
            lState[1, 2] = lblVib2;
            lState[1, 3] = lblSound2;
            lState[1, 4] = lblTemp2;

            lState[2, 0] = lblArc3;
            lState[2, 1] = lblFire3;
            lState[2, 2] = lblVib3;
            lState[2, 3] = lblSound3;
            lState[2, 4] = lblTemp3;

            lState[3, 0] = lblArc4;
            lState[3, 1] = lblFire4;
            lState[3, 2] = lblVib4;
            lState[3, 3] = lblSound4;
            lState[3, 4] = lblTemp4;


        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            ShowMainChannel();
        }

        public void ShowMainChannel()
        {
            if (Globals.gNumSensor == 1)
            {
                grp1.Visible = true;
                grp2.Visible = false;
                grp3.Visible = false;
                grp4.Visible = false;
            }
            else if (Globals.gNumSensor == 2)
            {
                grp1.Visible = true;
                grp2.Visible = true;
                grp3.Visible = false;
                grp4.Visible = false;
            }
            else if (Globals.gNumSensor == 3)
            {
                grp1.Visible = true;
                grp2.Visible = true;
                grp3.Visible = true;
                grp4.Visible = false;
            }
            else
            {
                grp1.Visible = true;
                grp2.Visible = true;
                grp3.Visible = true;
                grp4.Visible = true;
            }
        }

        //--- Show Event Status
        //    data: from STX to ETX
        //    1) check channel # : data [1] : 
        //    2) display normal, warn, critical for arc, fire, sound, vibration, temp with value & color     
        // iEvent Type : critical or warning. two bit for each value
        //     (arc,  fire, vib, sound,     temp)
        //  bit  98     76    54     32      10
        //     0x300   0xC0  0x30   0x0C    0x03
        // ix = 0~3
        public void NotifyEvent(int iEventType, int ix)
        {
            Color txtColor = Color.White;
            string txtValue;
            int iValue;
            int six = 0;    // type
            int [] iComp1 = { 0x200, 0x80, 0x20, 0x08, 0x02 };
            int [] iComp2 = { 0x100, 0x40, 0x10, 0x04, 0x01 };

            int RelayN = 0;     // 사고. 특정 channel의 arc/fire/temp 사고 인경우
            int Relay9 = 0;     // 경고. any channel의 arc/fire/temp 사고인 경우
            int Relay10 = 0;    // 사고. any channel의 arc/fire/temp 사고인 경우

            //--- check arc(0)/fire(1)/xiro(2)/sound(3)/temp(4)
            for (int i = 0; i < 5; i++)
            {

                if ((iEventType & iComp1[i]) == iComp1[i])
                {
                    txtColor = Color.Red;
                    txtValue = "사고";// + " (" + Globals.gAvgValue[ix, i].ToString() + ")";

                    if (i == 0 || i == 1 || i == 4)     // Arc. Relay 1~4: 각 채널의 Arc 또는 
                    {
                        RelayN = 1;
                        Relay10 = 1;
                    }
                }
                else if ((iEventType & iComp2[i]) == iComp2[i])
                {
                    txtColor = Color.Orange;
                    txtValue = "위험";// + " (" + Globals.gAvgValue[ix, i].ToString() + ")";
                    if (i == 0 || i == 1 || i == 4)     // Arc. Relay 1~4: 각 채널의 Arc 또는 
                    {
                        Relay9 = 1;
                    }
                }
                else
                {
                    txtColor = Color.White;
                    txtValue = "정상";// + " (" + Globals.gAvgValue[ix, i].ToString() + ")";
                }

                if (lState[ix, i].InvokeRequired)
                {
                    lState[ix, i].Invoke(new MethodInvoker(delegate { lState[ix, i].ForeColor = txtColor; }));
                    lState[ix, i].Invoke(new MethodInvoker(delegate { lState[ix, i].Text = txtValue; }));
                }
                else
                {
                    lState[ix, i].ForeColor = txtColor;
                    lState[ix, i].Text = txtValue;
                }
            }

            if (RelayN == 1)    // any one of arc, fire, temp is crictical ==> Relay X On
            {
                GSerial.Send_Enquiry_Relay((byte)0xc1, (byte)(ix + 1));
            }
            if (Relay9 == 1)    // any one of arc, fire, temp is warning ==> Relay 9 On
            {
                GSerial.Send_Enquiry_Relay((byte)0xc1, (byte)(9));
            }
            if (Relay10 == 1)    // any one of arc, fire, temp is crictical ==> Relay 10 On
            {
                GSerial.Send_Enquiry_Relay((byte)0xc1, (byte)(10));
            }
        }
    }
}
