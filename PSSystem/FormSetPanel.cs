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
            label1.Left = (Globals.PANEL_WIDTH - label1.Width) / 2;
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
            textTempWarn.Text = Globals.gWarningThreshold[0].ToString();
            textSensorWarn.Text = Globals.gWarningThreshold[1].ToString();
            textSoundWarn.Text = Globals.gWarningThreshold[2].ToString();
            textXiroWarn.Text = Globals.gWarningThreshold[3].ToString();

            //--- Criticals
            textTempCrit.Text = Globals.gCriticalThreshold[0].ToString();
            textSensorCrit.Text = Globals.gCriticalThreshold[1].ToString();
            textSoundCrit.Text = Globals.gCriticalThreshold[2].ToString();
            textXiroCrit.Text = Globals.gCriticalThreshold[3].ToString();
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
            Globals.gWarningThreshold[0] = int.Parse(textTempWarn.Text);
            Globals.gWarningThreshold[1] = int.Parse(textSensorWarn.Text);
            Globals.gWarningThreshold[2] = int.Parse(textSoundWarn.Text);
            Globals.gWarningThreshold[3] = int.Parse(textXiroWarn.Text);

            //--- Criticals
            Globals.gCriticalThreshold[0] = int.Parse(textTempCrit.Text);
            Globals.gCriticalThreshold[1] = int.Parse(textSensorCrit.Text);
            Globals.gCriticalThreshold[2] = int.Parse(textSoundCrit.Text);
            Globals.gCriticalThreshold[3] = int.Parse(textXiroCrit.Text);

            Globals.Write_Configuration();
        }
    }
}
