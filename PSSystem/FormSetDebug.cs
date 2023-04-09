using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PSSystem
{
    public partial class FormSetDebug : Form
    {
        public FormSetDebug()
        {
            InitializeComponent();
        }

        public void Display_Binary_Data(byte[] data, int len)
        {
            byte[] byteArray = new byte[len];
            Buffer.BlockCopy(data, 0, byteArray, 0, len);

            string strResult = System.BitConverter.ToString(byteArray);
            strResult = strResult.Replace("-", " ");
            listBox1.Invoke((MethodInvoker)delegate ()
            {
                if (listBox1.Items.Count > 20)
                {
                    listBox1.Items.RemoveAt(0);
                }
                listBox1.Items.Add(strResult);
            });

        }
        private void btnEnq_Click(object sender, EventArgs e)
        {
            byte bCmd = Convert.ToByte(textCommand.Text, 16);
            GSerial.Send_Equiry_Data(bCmd);
        }
    }

}
