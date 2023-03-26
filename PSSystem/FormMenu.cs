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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }


        private void btnName_Click(object sender, EventArgs e)
        {
            Globals.ChangeForm((int)FORM_INDEX.NO_FORM_SET_PANEL);

        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            Globals.ChangeForm((int)FORM_INDEX.NO_FORM_SET_WARNING);

        }

        private void btnCritical_Click(object sender, EventArgs e)
        {
            Globals.ChangeForm((int)FORM_INDEX.NO_FORM_SET_CRITICAL);

        }

        private void btnSensor_Click(object sender, EventArgs e)
        {
            Globals.ChangeForm((int)FORM_INDEX.NO_FORM_SET_NUMSENSOR);

        }

        private void btnRelay_Click(object sender, EventArgs e)
        {
            Globals.ChangeForm((int)FORM_INDEX.NO_FORM_SET_RELAY);

        }

        private void btnState_Click(object sender, EventArgs e)
        {
            Globals.ChangeForm((int)FORM_INDEX.NO_FORM_SET_STATE);

        }

        private void btnData_Click(object sender, EventArgs e)
        {
            Globals.ChangeForm((int)FORM_INDEX.NO_FORM_SET_DATA);
        }
        private void btnVideo_Click(object sender, EventArgs e)
        {
            // Goto Video 화면 
            if (Globals.gCurrentIndex != (int)FORM_INDEX.NO_FORM_SET_VIDEO)
                Globals.ChangeForm((int)FORM_INDEX.NO_FORM_SET_VIDEO);
        }

        private void btnWifi_Click(object sender, EventArgs e)
        {
            Globals.ChangeForm((int)FORM_INDEX.NO_FORM_SET_WIFI);
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            Globals.ChangeForm((int)FORM_INDEX.NO_FORM_EVENT);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Globals.gCurrentIndex != (int)FORM_INDEX.NO_FORM_MAIN)
                Globals.ChangeForm((int)FORM_INDEX.NO_FORM_MAIN);
        }
    }
}
