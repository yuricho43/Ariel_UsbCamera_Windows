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
            textPhoneNumber.Text = Globals.gWifi[2];
            textSNSString.Text = Globals.gWifi[3];

            //--- Warnings
            textSensorWarn.Text = Globals.gWarningThreshold[0].ToString();
            textFireWarn.Text = Globals.gWarningThreshold[1].ToString();
            textXiroWarn.Text = Globals.gWarningThreshold[2].ToString();
            textSoundWarn.Text = Globals.gWarningThreshold[3].ToString();
            textTempWarn.Text = Globals.gWarningThreshold[4].ToString();

            //--- Criticals
            textSensorCrit.Text = Globals.gCriticalThreshold[0].ToString();
            textFireCrit.Text = Globals.gCriticalThreshold[1].ToString();
            textXiroCrit.Text = Globals.gCriticalThreshold[2].ToString();
            textSoundCrit.Text = Globals.gCriticalThreshold[3].ToString();
            textTempCrit.Text = Globals.gCriticalThreshold[4].ToString();

            //--- Others
            textPeriod.Text = Globals.gOtherConfig[1].ToString();
            checkLogging.Checked =  Globals.gOtherConfig[2] == 0 ? false : true;

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
            Globals.gWifi[2] = textPhoneNumber.Text;
            Globals.gWifi[3] = textSNSString.Text;

            //--- Warnings
            Globals.gWarningThreshold[0] = int.Parse(textTempWarn.Text);
            Globals.gWarningThreshold[1] = int.Parse(textSensorWarn.Text);
            Globals.gWarningThreshold[2] = int.Parse(textSoundWarn.Text);
            Globals.gWarningThreshold[3] = int.Parse(textXiroWarn.Text);
            Globals.gWarningThreshold[4] = int.Parse(textFireWarn.Text);

            //--- Criticals
            Globals.gCriticalThreshold[0] = int.Parse(textTempCrit.Text);
            Globals.gCriticalThreshold[1] = int.Parse(textSensorCrit.Text);
            Globals.gCriticalThreshold[2] = int.Parse(textSoundCrit.Text);
            Globals.gCriticalThreshold[3] = int.Parse(textXiroCrit.Text);
            Globals.gCriticalThreshold[4] = int.Parse(textFireCrit.Text);

            //--- Others
            Globals.gOtherConfig[1] = int.Parse(textPeriod.Text);
            if (Globals.gOtherConfig[1] < 200)
                Globals.gOtherConfig[1] = 200;
            if (Globals.gOtherConfig[1] > 2000)
                Globals.gOtherConfig[1] = 2000;
            textPeriod.Text = Globals.gOtherConfig[1].ToString();
            Globals.gOtherConfig[2] = checkLogging.Checked ? 1 : 0;

            Globals.Write_Configuration();

            ((FormMain)Globals.gFormList[(int)FORM_INDEX.NO_FORM_MAIN]).ShowMainChannel();
        }
    }
}
