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
            //--- Read Data : yyyymmdd_log.bin
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
                strEvent = GetEventString(readData[5]);
                strData = support.ConvertHexArrayToString2(readData, 6, 72);
                ListViewItem item = new ListViewItem(strDate);
                listView1.Items.Add(item);
                item.SubItems.Add(strEvent);
                item.SubItems.Add(strData);

                if (iCount++ > 30)
                    break;
            }
            br.Close();
            fs.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private string GetEventString(byte bEvent)
        {
            // TEMP/SENSOR/SOUND/XIRO NORMAL/WARNING/CRITICAL
            // "TW SC SN XN"
            string strReturn = "TW SC SN XN";
            return strReturn;
        }
    }
}
