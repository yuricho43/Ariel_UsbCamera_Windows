﻿using System;
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
    public partial class FormSetRelay : Form
    {
        public FormSetRelay()
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



        private void btnTest_Click(object sender, EventArgs e)
        {
            ushort uRelay = 0;

            for (int i = 0; i < 11; i++)
            {
                if (checkList1.GetItemChecked(i))
                {
                    uRelay |= (ushort)(1 << i);
                }
            }
            GSerial.Send_Enquiry_Relay((byte)(uRelay >> 8), (byte)(uRelay & 0xFF));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
                checkList1.SetItemChecked(i, false);

        }
    }
}
