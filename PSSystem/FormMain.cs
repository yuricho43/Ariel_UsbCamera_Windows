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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            label1.BackColor = Color.Transparent;
            label1.Left = (Globals.PANEL_WIDTH - label1.Width) / 2;
            label2.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            lblArc.BackColor = Color.Transparent;
            lblVib.BackColor = Color.Transparent;
            lblSound.BackColor = Color.Transparent;
            lblTemp.BackColor = Color.Transparent;
        }
    }
}
