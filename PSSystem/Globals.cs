﻿using GitHub.secile.Video;
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
        public const int MAX_COUNT = 13;                        // MENU 최대 개수
        public const int MAX_CAMERA = 4;                        // 카메라 최대 개수
        public const int PANEL_WIDTH = 800;                     // 화면 폭
        public const int PANEL_HEIGHT = 480;                    // 화면 높이
        public static int gCurrentIndex = 0;                    // 현재 표시되는 화면 인덱스
        public static int gCurrentCam = 0;                      // 현재 선택된 카메라 인덱스
        public static Form1  gMainForm;                         // Main Form control
        public static Form[] gFormList = new Form[MAX_COUNT];   // 메뉴에 해당되는 화면들
        public static Mat[] gFrame = new Mat[MAX_CAMERA];       // Video Frame
        public static VideoCapture[] gVideoList = new VideoCapture[MAX_CAMERA]; // OpenCV VideoCapture 장치
        public static Thread[] gThread = new Thread[MAX_CAMERA];    // Video 처리를 위한 Thread
        public static int[] gIsAlive = new int[MAX_CAMERA];         // Camera 동작 상태
        public static string[] gDevices = UsbCamera.FindDevices();  // 검색된 카메라 장치
        public static int gNumCam = 0;                              // 검색된 카메라 장치 수
        public static object gLockCamera = new object();   // Semaphore
        public static object gLockEvent = new object();   // Semaphore
        public static object gLockLog = new object();   // Semaphore

        //--- received state value from board
        public static byte[,] gTempValue   = new byte[MAX_CAMERA, 32];
        public static byte[,] gSensorValue = new byte[MAX_CAMERA, 32];      // Arc + Fire
        public static byte[,] gSoundValue = new byte[MAX_CAMERA,2];
        public static byte[,] gXiroValue  = new byte[MAX_CAMERA,2];
        public static byte[] gRelayValue   = new byte[3];
        public static short[,] gTemp16 = new short[MAX_CAMERA, 16];
        public static short[,] gSensor16 = new short[MAX_CAMERA, 16];      // Arc + Fire
        public static short[] gSound16 = new short[MAX_CAMERA];
        public static short[] gXiro16 = new short[MAX_CAMERA];

        //--- configuration (환경 설정파일)
        public static string[] gCamName = new string[MAX_CAMERA];   // 카메라 이름
        public static int[,] gAvgValue = new int[MAX_CAMERA, 5];    // 평균값 (화재(0), 아크(1), 진동(2), 소음(3), 온도(4)
        public static int[] gWarningThreshold = new int[5];         // 위험 경계치 (화재(0), 아크(1), 진동(2), 소음(3), 온도(4)
        public static int[] gCriticalThreshold = new int[5];        // 사고 경계치 (화재(0), 아크(1), 진동(2), 소음(3), 온도(4)
        public static int gNumSensor;                               // 센서 수 ?
        public static string[] gWifi = new string[4];               // SSID, PASS, Phone#, SNS
        public static string gComPort;                              // 통신 포트 (COM2, COM3, ...)
        public static int[] gOtherConfig = new int[4];              // Reserved. [0] = DebugWindowShow, 1: enquiry period, 2:data logging

        public static int gGoMain = 1;
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
            string strOther = String.Join(",", gOtherConfig);

            SetSetting("ChannelName", strNames);
            SetSetting("WarningThreshold", strWarning);
            SetSetting("CriticalThreshold", strCritical);
            SetSetting("NumberOfSensor", gNumSensor.ToString());
            SetSetting("WifiValue", strWifi);
            SetSetting("ComPort", gComPort);
            SetSetting("OtherConfig", strOther);
        }

        public static short GetShortValueFrom2bytes(byte b1, byte b2)
        {
            short sValue = 0;
            sValue = (short)((ushort)(b1 * 256) + b2);
            return sValue;
        }
    }
}
