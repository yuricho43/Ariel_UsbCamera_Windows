using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PSSystem
{
    public partial class FormSetNumSensor : Form
    {
        Chart[] gChart = new Chart[4];
        double x = 0.0;
        
        public FormSetNumSensor()
        {
            InitializeComponent();

            gChart[0] = chart1;
            gChart[1] = chart2;
            gChart[2] = chart3;
            gChart[3] = chart4;
            label1.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Globals.gCurrentIndex != (int)FORM_INDEX.NO_FORM_MAIN)
                Globals.ChangeForm((int)FORM_INDEX.NO_FORM_MAIN);
        }

        //--- chIx = 0~3
        public void AddPoint(int chIx)
        {

            for (int i = 0; i < 5; i++)
            {
                gChart[chIx].Invoke((MethodInvoker)delegate ()
                {
                    gChart[chIx].Series[i].Points.AddXY(x, (double)Globals.gAvgValue[chIx, i]);

                    if (gChart[chIx].Series[i].Points.Count > 30)
                        gChart[chIx].Series[i].Points.RemoveAt(0);

                    gChart[chIx].ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
                    gChart[chIx].ChartAreas[0].AxisX.Maximum = x;
                });
            }

            x += 1;
        }
    }
}
