using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSystem
{
    public partial class FormEvent : Form
    {
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

            for (int i = 0; i < 50; i++)
            {
                //--- read 78 bytes
                //--- pickup time : hh:mm:ss
                //--- change to hex string
                strDate = "2023.06.01 12:24:36";
                ListViewItem item = new ListViewItem(strDate);
                listView1.Items.Add(item);

                item.SubItems.Add("Temp Critical");
                item.SubItems.Add(i.ToString() + " 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
