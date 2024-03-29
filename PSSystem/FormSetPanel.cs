﻿using NativeWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PSSystem
{
    public partial class FormSetPanel : Form
    {
        
	    private WlanClient wlanClient = new WlanClient();
        List<string> wSSIDs = new List<string>();
        private string GetSSIDString(Wlan.WlanAvailableNetwork wlanAvailableNetwork)
        {
            Wlan.Dot11Ssid dot11Ssid = wlanAvailableNetwork.dot11Ssid;
            return Encoding.ASCII.GetString(dot11Ssid.SSID, 0, (int)dot11Ssid.SSIDLength);
        }

        void GetIds()
        {
            if (this.wlanClient.Interfaces.Count() <= 0)
                return;

            Wlan.WlanAvailableNetwork[] wlanAvailableNetworkArray;

            try
            {
                wlanAvailableNetworkArray = this.wlanClient.Interfaces[0].GetAvailableNetworkList(0);
            }
            catch (Exception ex)
            {
                return;
            }

            int count = wlanAvailableNetworkArray.Length;

            wSSIDs.Clear();
            for (int i = 0; i < count; i++)
            {
                Wlan.WlanAvailableNetwork wlanAvailableNetwork = wlanAvailableNetworkArray[i];
                string ssidString = GetSSIDString(wlanAvailableNetwork);
                if (ssidString.Length > 0)
                    wSSIDs.Add(ssidString);
            }

            wSSIDs = wSSIDs.Distinct().ToList();
        }

        public FormSetPanel()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label1.Left = (Globals.PANEL_WIDTH - label1.Width) / 2;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;
            groupBox4.BackColor = Color.Transparent;
            GetIds();
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
            cmbWifiName.Items.Clear();
            for (int i = 0; i < wSSIDs.Count; i++)
                cmbWifiName.Items.Add(wSSIDs[i]);
            cmbWifiName.Text = Globals.gWifi[0];
            textWifiPass.Text = Globals.gWifi[1];
            textPhoneNumber.Text = Globals.gWifi[2];
            textSNSString.Text = Globals.gWifi[3];

            //--- Warnings
            textFireWarn.Text = Globals.gWarningThreshold[0].ToString();        // 화재
            textSensorWarn.Text = Globals.gWarningThreshold[1].ToString();
            textXiroWarn.Text = Globals.gWarningThreshold[2].ToString();
            textSoundWarn.Text = Globals.gWarningThreshold[3].ToString();
            textTempWarn.Text = Globals.gWarningThreshold[4].ToString();        // 온도

            //--- Criticals
            textFireCrit.Text = Globals.gCriticalThreshold[0].ToString();       // 화재
            textSensorCrit.Text = Globals.gCriticalThreshold[1].ToString();
            textXiroCrit.Text = Globals.gCriticalThreshold[2].ToString();
            textSoundCrit.Text = Globals.gCriticalThreshold[3].ToString();
            textTempCrit.Text = Globals.gCriticalThreshold[4].ToString();       // 온도

            //--- Others
            textPeriod.Text = Globals.gOtherConfig[1].ToString();
            checkLogging.Checked =  Globals.gOtherConfig[2] == 0 ? false : true;

            // System.Diagnostics.Process.Start("osk.exe");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.gCamName[0] = textCam1.Text;
            Globals.gCamName[1] = textCam2.Text;
            Globals.gCamName[2] = textCam3.Text;
            Globals.gCamName[3] = textCam4.Text;

            //--- Sensor수, Wifi
            Globals.gNumSensor = int.Parse(textSensor.Text);
            Globals.gWifi[0] = cmbWifiName.Text;
            Globals.gWifi[1] = textWifiPass.Text;
            Globals.gWifi[2] = textPhoneNumber.Text;
            Globals.gWifi[3] = textSNSString.Text;

            //--- Warnings
            Globals.gWarningThreshold[0] = int.Parse(textFireWarn.Text);        // 화재
            Globals.gWarningThreshold[1] = int.Parse(textSensorWarn.Text);
            Globals.gWarningThreshold[2] = int.Parse(textXiroWarn.Text);
            Globals.gWarningThreshold[3] = int.Parse(textSoundWarn.Text);
            Globals.gWarningThreshold[4] = int.Parse(textTempWarn.Text);        // 온도

            //--- Criticals
            Globals.gCriticalThreshold[0] = int.Parse(textFireCrit.Text);       // 화재
            Globals.gCriticalThreshold[1] = int.Parse(textSensorCrit.Text);
            Globals.gCriticalThreshold[2] = int.Parse(textXiroCrit.Text);
            Globals.gCriticalThreshold[3] = int.Parse(textSoundCrit.Text);
            Globals.gCriticalThreshold[4] = int.Parse(textTempCrit.Text);       // 온도

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

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
            GetIds();
        }

        private void btnWifiSend_Click(object sender, EventArgs e)
        {
            // Wifi 전송
            /*  참고 변수들
            Globals.gWifi[0] = wifi 이름;
            Globals.gWifi[1] = wifi password;
            Globals.gWifi[2] = 전화번호
            Globals.gWifi[3] = SNM문자열
            */
        }
    }
}
