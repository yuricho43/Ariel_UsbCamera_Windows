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
    public partial class FormSetData : Form
    {
        SupportEtc support = new SupportEtc();
        FileStream gFs = null;
        BinaryReader gBr = null;


        public FormSetData()
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
            if (gBr == null)
                return;         // first assign logfile

            //--- Read Data : yyyymmdd_log.bin
            int iNum = int.Parse(textLen.Text);
            if (iNum <= 0)
                return;

            byte[] readData;
            string strDate;
            string strData;
            int year = dtDate.Value.Year;
            int month = dtDate.Value.Month;
            int day = dtDate.Value.Day;

            for (int i = 0; i < iNum; i++)
            {
                //--- read 78 bytes
                //--- pickup time : hh:mm:ss
                //--- change to hex string
                readData = gBr.ReadBytes(78);
                if (readData.Length < 78)
                    break;

                //--- pickup time : hh:mm:ss
                //--- change to hex string
                strDate = year.ToString() + "." + readData[0].ToString("00") + "." + readData[1].ToString("00") + " "
                    + readData[2].ToString("00") + ":" + readData[3].ToString("00") + ":" + readData[4].ToString("00");
                strData = support.ConvertHexArrayToString2(readData, 6, 72);
                ListViewItem item = new ListViewItem(strDate);
                listView1.Items.Add(item);
                item.SubItems.Add(strData);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //--- get filename
            int year = dtDate.Value.Year;
            int month = dtDate.Value.Month;
            int day = dtDate.Value.Day;

            string filename = year.ToString("0000") + month.ToString("00") + day.ToString("00") + "_log.bin";

            //--- open file
            if (gBr != null)
                gBr.Close();
            if (gFs != null) 
                gFs.Close();

            gBr = null;
            gFs = null;

            if (!File.Exists(filename))
            {
                MessageBox.Show("There is no log file", filename);
                return; // show message of non-exist
            }

            gFs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            gBr = new BinaryReader(gFs);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
