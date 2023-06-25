using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSystem
{
    enum FORM_INDEX
    {
        NO_FORM_NONE = 0,
        NO_FORM_LOGO = 0,           // Initial
        NO_FORM_MAIN = 1,           // 상시화면
        NO_FORM_MENU = 2,           // 설정화면
        NO_FORM_SET_PANEL,          // 배전반, 위험값, 사고값, WIFI, Sensor 수
        NO_FORM_SET_SERIAL,         // 시리얼 포트
        NO_FORM_SET_CRITICAL,       // NOT USED --> SET_PANEL에서 처리
        NO_FORM_SET_NUMSENSOR = 6,  // NOT USED --> SET_PANEL에서 처리
        NO_FORM_SET_RELAY,          // 릴레이테스트
        NO_FORM_SET_STATE = 8,      // 상태감시
        NO_FORM_SET_DATA,           // 데이타검색
        NO_FORM_SET_VIDEO = 10,     // 비디오 하면
        NO_FORM_SET_DEBUG,          // 디버깅 화면
        NO_FORM_EVENT,              // EVENT 발생
        NO_FORM_FORMTOP_BASE = 13,
        NO_FORM_FORMTOP_1,
        NO_FORM_FORMTOP_2,
        NO_FORM_FORMBOTTOM_BASE = 16,
        NO_FORM_FORMBOTTOM_1,
        NO_FORM_FORMBOTTOM_2
    };
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Read_Configuration();

            Globals.gCurrentIndex = 0;
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_LOGO] = new FormLogo();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_MAIN] = new FormMain();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_MENU] = new FormMenu();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_PANEL] = new FormSetPanel();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_SERIAL] = new FormSetSerial();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_CRITICAL] = new FormSetCritical();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_NUMSENSOR] = new FormSetNumSensor();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_RELAY] = new FormSetRelay();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_STATE] = new FormSetState();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_DATA] = new FormSetData();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_VIDEO] = new FormSetVideo();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_DEBUG] = new FormSetDebug();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_EVENT] = new FormEvent();
            Globals.gMainForm = this;

            Globals.gNumCam = Globals.gDevices.Length;

            for (int i = 0; i < Globals.MAX_COUNT; i++)
            {
                if (i != 11) // 11 ==> Debug Window
                {
                    Globals.gFormList[i].TopLevel = false;
                    Globals.gFormList[i].Size = new System.Drawing.Size(800, 416);
                    Globals.gFormList[i].BackgroundImage = Properties.Resources.back1;
                    panelMiddle.Controls.Add(Globals.gFormList[i]);
                }
            }
            Globals.gFormList[0].Show();
            panel1.BackgroundImage = Properties.Resources.back;
            lblModelName.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            lblDate.BackColor = Color.Transparent;

            // For Debug Message
            if (Globals.gOtherConfig[0] == 1)
                Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_DEBUG].Show();

            Size = new Size(800, 480);
        }

        private void Read_Configuration()
        {
            // read configuration : 
            string strNames = Globals.GetSetting("ChannelName");
            string strWarning = Globals.GetSetting("WarningThreshold");
            string strCritical = Globals.GetSetting("CriticalThreshold");
            string strNumSensor = Globals.GetSetting("NumberOfSensor");
            string strWifi = Globals.GetSetting("WifiValue");
            string strCom = Globals.GetSetting("COMPort");
            string strOther = Globals.GetSetting("OtherConfig");
            
            if (strNames == null)
                strNames = "ID001,ID002,ID003,ID004";
            Globals.gCamName = strNames.Split(',').ToArray<string>();

            if (strWarning == null)
                strWarning = "59, 59, 110, 90, 59";  //온도, 센서, 소음, 진동, 화재
            Globals.gWarningThreshold = strWarning.Split(',').Select(x => int.Parse(x)).ToArray();

            if (strCritical == null)
                strCritical = "95, 95, 120, 100, 95";
            Globals.gCriticalThreshold = strCritical.Split(',').Select(x => int.Parse(x)).ToArray();

            if (strNumSensor == null)
                strNumSensor = "4";
            Globals.gNumSensor = int.Parse(strNumSensor);

            if (strWifi == null)
                strWifi = "WIFI-SSD,WIFI-PASS, 01022221111, 알람발생";
            Globals.gWifi = strWifi.Split(',').ToArray<string>();

            if (strCom == null)
                strCom = "COM3";
            Globals.gComPort = strCom;

            if (strOther == null)
                strOther = "0,200,1,0";
            Globals.gOtherConfig = strOther.Split(',').Select(x => int.Parse(x)).ToArray();
            if (Globals.gOtherConfig[1] < 200)
                Globals.gOtherConfig[1] = 200;
            if (Globals.gOtherConfig[1] > 2000)
                Globals.gOtherConfig[1] = 2000;

        }

        static public void ShowControls()
        {
            Globals.gMainForm.ShowTopMenu();
        }

        public void ShowTopMenu()
        {
            lblModelName.Visible = true;
            lblDate.Visible = true;
            label1.Visible = true;
            btnMenu.Visible = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (Globals.gCurrentIndex != (int)FORM_INDEX.NO_FORM_MENU)
                Globals.ChangeForm((int)FORM_INDEX.NO_FORM_MENU);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            // display Time
            if (lblDate.Visible)
            {
                lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.Write_Configuration();
            ((FormSetVideo)Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_VIDEO]).Close_Video();
        }

        public void Process_Received__Data(byte [] dataSensor, int len)
        {
            // Display Log Data
            if (Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_DEBUG].Visible)
                ((FormSetDebug) Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_DEBUG]).Display_Binary_Data(dataSensor, len);

            //--- Parse and Save to Global variables.
            ((FormSetState)Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_STATE]).ParseSensorData(dataSensor, len);
            //--- Display at State Form.
            //--- Log Data
            //--- Check Event, Warning, Critical and Save Event.
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globals.Write_Configuration();
            ((FormSetVideo)Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_VIDEO]).Close_Video();
        }
    }
}
