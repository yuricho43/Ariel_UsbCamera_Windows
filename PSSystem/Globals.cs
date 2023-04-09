using GitHub.secile.Video;
using OpenCvSharp;
using System;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSystem
{

    public static class Globals
    {
        //--- housekeeping variables
        public const int MAX_COUNT = 13;
        public const int MAX_CAMERA = 4;
        public static int gCurrentIndex = 0;
        public static int gCurrentCam = 0;
        public static Form1  gMainForm;
        public static Form[] gFormList = new Form[MAX_COUNT];
        public static Mat[] gFrame = new Mat[MAX_COUNT];
        public static VideoCapture[] gVideoList = new VideoCapture[MAX_CAMERA];
        public static Thread[] gThread = new Thread[MAX_CAMERA];
        public static int[] gIsAlive = new int[MAX_CAMERA];
        public static string[] gDevices = UsbCamera.FindDevices();
        public static int gNumCam = 0;

        //--- configuration
        public static string[] gCamName = new string[MAX_CAMERA];
        public static int[] gWarningThreshold = new int[5];
        public static int[] gCriticalThreshold = new int[5];
        public static int gNumSensor;
        public static string[] gWifi = new string[3];   // SSID, PASS
        public static string gComPort;

        public static void ChangeForm(int index)
        {
            Globals.gFormList[index].Show();
            Globals.gFormList[Globals.gCurrentIndex].Hide();
            Globals.gCurrentIndex = index;
        }

        public static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static void SetSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void Write_Configuration()
        {
            //camname, waringins, criticals, numsensors, wifi
            string strNames = String.Join(",", gCamName);
            string strWarning = String.Join(",", gWarningThreshold);
            string strCritical = String.Join(",", gCriticalThreshold);
            string strWifi = String.Join(",", gWifi);

            SetSetting("ChannelName", strNames);
            SetSetting("WarningThreshold", strWarning);
            SetSetting("CriticalThreshold", strCritical);
            SetSetting("NumberOfSensor", gNumSensor.ToString());
            SetSetting("WifiValue", strWifi);
            SetSetting("ComPort", gComPort);
        }
    }
}
