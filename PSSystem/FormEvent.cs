using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSystem
{
    public partial class FormEvent : Form
    {
        SupportEtc support = new SupportEtc();

        public FormEvent()
        {
            InitializeComponent();
            label2.BackColor = Color.Transparent;
            label2.Left = (Globals.PANEL_WIDTH - label2.Width) / 2;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Globals.gCurrentIndex != (int)FORM_INDEX.NO_FORM_MAIN)
                Globals.ChangeForm((int)FORM_INDEX.NO_FORM_MAIN);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            //--- Read Data : yyyymmdd_event.bin
            string strDate;
            string strEvent;
            string strData;

            int year = dtDate.Value.Year;
            int month = dtDate.Value.Month;
            int day = dtDate.Value.Day;
            string filename = year.ToString("0000") + month.ToString("00") + "_events.bin";
            if (!File.Exists(filename))
            {
                MessageBox.Show("There is no event file", "No Event");
                return; // show message of non-exist
            }

            
            lock(Globals.gLockEvent)
            {

                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] readData;

                int iCount = 0;

                while (true)
                {
                    //--- read 79 bytes // month, day, hour, min, sec, event type(2) + 72 bytes
                    readData = br.ReadBytes(79);
                    if (readData.Length < 79)
                        break;

                    //--- pickup time : hh:mm:ss
                    //--- change to hex string
                    strDate = year.ToString() + "." + readData[0].ToString("00") + "." + readData[1].ToString("00") + " "
                        + readData[2].ToString("00") + ":" + readData[3].ToString("00") + ":" + readData[4].ToString("00");
                    strEvent = GetEventString(readData[5], readData[6]);
                    strData = support.ConvertHexArrayToString2(readData, 6, 72);
                    ListViewItem item = new ListViewItem(strDate);
                    listView1.Items.Add(item);
                    item.SubItems.Add(strEvent);
                    item.SubItems.Add(strData);

                    if (iCount++ > 2000)
                        break;
                }
                br.Close();
                fs.Close();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        //     (arc,  fire, vib, sound,     temp)
        //  bit  98     76    54     32      10
        //     0x300   0xC0  0x30   0x0C    0x03
        private string GetEventString(byte bEventH, byte bEventL)
        {
            // ARC/FIRE/VIBE/SOUND/TEMP NORMAL/WARNING/CRITICAL
            // "TW SC SN XN"
            string strReturn = "";
            byte bData;

            //------ ARC
            bData = (byte)(bEventH & 0x03);
            if (bData == 0x00)
                strReturn += "AN ";
            else if (bData == 0x01)
                strReturn += "AW ";
            else
                strReturn += "AC ";

            //------ FIRE
            bData = (byte)((bEventL & 0xC0) >> 6);
            if (bData == 0x00)
                strReturn += "FN ";
            else if (bData == 0x01)
                strReturn += "FW ";
            else
                strReturn += "FC ";

            //------ VIB
            bData = (byte)((bEventL & 0x30) >> 4);
            if (bData == 0x00)
                strReturn += "VN ";
            else if (bData == 0x01)
                strReturn += "VW ";
            else
                strReturn += "VC ";

            //------ SOUND
            bData = (byte)((bEventL & 0x0C) >> 2);
            if (bData == 0x00)
                strReturn += "SN ";
            else if (bData == 0x01)
                strReturn += "SW ";
            else
                strReturn += "SC ";

            //------ TEMP
            bData = (byte)(bEventL & 0x03);
            if (bData == 0x00)
                strReturn += "TN ";
            else if (bData == 0x01)
                strReturn += "TW ";
            else
                strReturn += "TC ";

            return strReturn;
        }
    }
}
