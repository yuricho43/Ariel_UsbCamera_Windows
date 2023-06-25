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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            label1.BackColor = Color.Transparent;
            label1.Left = (Globals.PANEL_WIDTH - label1.Width) / 2;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            lblArc.BackColor = Color.Transparent;
            lblFire.BackColor = Color.Transparent;
            lblVib.BackColor = Color.Transparent;
            lblSound.BackColor = Color.Transparent;
            lblTemp.BackColor = Color.Transparent;
            grp1.BackColor = Color.Transparent;
            grp2.BackColor = Color.Transparent;
            grp3.BackColor = Color.Transparent;
            grp4.BackColor = Color.Transparent;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            ShowMainChannel();
        }

        public void ShowMainChannel()
        {
            if (Globals.gNumSensor == 1)
            {
                grp1.Visible = true;
                grp2.Visible = false;
                grp3.Visible = false;
                grp4.Visible = false;
            }
            else if (Globals.gNumSensor == 2)
            {
                grp1.Visible = true;
                grp2.Visible = true;
                grp3.Visible = false;
                grp4.Visible = false;
            }
            else if (Globals.gNumSensor == 3)
            {
                grp1.Visible = true;
                grp2.Visible = true;
                grp3.Visible = true;
                grp4.Visible = false;
            }
            else
            {
                grp1.Visible = true;
                grp2.Visible = true;
                grp3.Visible = true;
                grp4.Visible = true;
            }
        }

        private void FormMain_Enter(object sender, EventArgs e)
        {
        }
    }
}
