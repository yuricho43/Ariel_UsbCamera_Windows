using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PSSystem
{
    public partial class FormSetPanel : Form
    {
        public FormSetPanel()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;
            groupBox4.BackColor = Color.Transparent;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Globals.gCurrentIndex != (int)FORM_INDEX.NO_FORM_MAIN)
                Globals.ChangeForm((int)FORM_INDEX.NO_FORM_MAIN);
        }

        private void FormSetPanel_Shown(object sender, EventArgs e)
        {
            // Display Value

            //--- Camera 이름
            textCam1.Text = Globals.gCamName[0];
            textCam2.Text = Globals.gCamName[1];
            textCam3.Text = Globals.gCamName[2];
            textCam4.Text = Globals.gCamName[3];

            //--- Sensor수, Wifi
            textSensor.Text = Globals.gNumSensor.ToString();
            textWifiName.Text = Globals.gWifi[0];
            textWifiPass.Text = Globals.gWifi[1];

            //--- Warnings
            textArcWarn.Text = Globals.gWarningThreshold[0].ToString();
            textFireWarn.Text = Globals.gWarningThreshold[1].ToString();
            textTempWarn.Text = Globals.gWarningThreshold[2].ToString();

            //--- Criticals
            textArcCrit.Text = Globals.gCriticalThreshold[0].ToString();
            textFireCrit.Text = Globals.gCriticalThreshold[1].ToString();
            textTempCrit.Text = Globals.gCriticalThreshold[2].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.gCamName[0] = textCam1.Text;
            Globals.gCamName[1] = textCam2.Text;
            Globals.gCamName[2] = textCam3.Text;
            Globals.gCamName[3] = textCam4.Text;

            //--- Sensor수, Wifi
            Globals.gNumSensor = int.Parse(textSensor.Text);
            Globals.gWifi[0] = textWifiName.Text;
            Globals.gWifi[1] = textWifiPass.Text;

            //--- Warnings
            Globals.gWarningThreshold[0] = int.Parse(textArcWarn.Text);
            Globals.gWarningThreshold[1] = int.Parse(textFireWarn.Text);
            Globals.gWarningThreshold[2] = int.Parse(textTempWarn.Text);

            //--- Criticals
            Globals.gCriticalThreshold[0] = int.Parse(textArcCrit.Text);
            Globals.gCriticalThreshold[1] = int.Parse(textFireCrit.Text);
            Globals.gCriticalThreshold[2] = int.Parse(textTempCrit.Text);

            Globals.Write_Configuration();
        }
    }
}
