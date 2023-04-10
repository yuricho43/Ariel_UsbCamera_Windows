using OpenCvSharp;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PSSystem
{
    public partial class FormSetVideo : Form
    {
        Button[] CameraButton = new Button[4];
        int CurrentCam = -1;
        int CameraMode = 1;     // 0: 4 Cam, 1: 1Cam

        public FormSetVideo()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            //label1.Left = (Globals.PANEL_WIDTH - label1.Width) / 2;

            CameraButton[0] = btnCam1;
            CameraButton[1] = btnCam2;
            CameraButton[2] = btnCam3;
            CameraButton[3] = btnCam4;

            ChangeCameraMode(CameraMode);
        }

        private void ShowImage(Bitmap image, int pictureIndex)
        {
            if (pictureIndex == 0)
            {
                pictureBox1.Image = image;
            }
            else if (pictureIndex == 1)
            {
                pictureBox2.Image = image;
            }
            else if (pictureIndex == 2)
            {
                pictureBox3.Image = image;
            }
            else if (pictureIndex == 3)
            {
                pictureBox4.Image = image;
            }
            else
            {
                pictureBox5.Image = image;
            }
        }

        private void CameraCallback0(object param)
        {
            int ix = (int)param;
            Globals.gFrame[ix] = new Mat();
            Globals.gVideoList[ix] = new VideoCapture(ix, VideoCaptureAPIs.DSHOW);

            if (!Globals.gVideoList[ix].IsOpened())
            {
                MessageBox.Show("카메라를 열 수 없습니다. 연결 확인해 주세요");
                return;
            }

            Globals.gIsAlive[ix] = 1;
            while (Globals.gIsAlive[ix] == 1)
            {
                Globals.gVideoList[ix].Read(Globals.gFrame[ix]);
                if (CameraMode == 0)
                    ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Globals.gFrame[ix]), ix);
                else
                    ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Globals.gFrame[ix]), -1);
            }
            Globals.gVideoList[ix].Release();
            Globals.gFrame[ix].Release();

            Globals.gVideoList[ix] = null;
        }

        private void StartCamera(int index)
        {
            Globals.gThread[index] = new Thread(new ParameterizedThreadStart(CameraCallback0));
            Globals.gThread[index].Start(index);
            CameraButton[index].Text = "Stop";
        }

        private void StopCamera(int index)
        {
            if (Globals.gIsAlive[index] == 0)
                return;
            Globals.gIsAlive[index] = 0;
            Globals.gThread[index].Join();
            CameraButton[index].Text = Globals.gDevices[index];
        }

        private void btnCam1_Click(object sender, EventArgs e)
        {
            if (Globals.gVideoList[0] != null)
            {
                StopCamera(0);
                return;
            }

            StartCamera(0);
        }

        private void btnCam2_Click(object sender, EventArgs e)
        {
            if (Globals.gVideoList[1] != null)
            {
                StopCamera(1);
                return;
            }

            StartCamera(1);
        }

        private void btnCam3_Click(object sender, EventArgs e)
        {
            if (Globals.gVideoList[2] != null)
            {
                StopCamera(2);
                return;
            }

            StartCamera(2);
        }

        private void btnCam4_Click(object sender, EventArgs e)
        {
            if (Globals.gVideoList[3] != null)
            {
                StopCamera(3);
                return;
            }

            StartCamera(3);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Globals.gCurrentIndex != (int)FORM_INDEX.NO_FORM_MAIN)
                Globals.ChangeForm((int)FORM_INDEX.NO_FORM_MAIN);
        }

        private void FormSetVideo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close_Video();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentCam = (CurrentCam + 1) % Globals.gNumCam;
            StopCamera((CurrentCam + Globals.gNumCam - 1) % Globals.gNumCam);
            StartCamera(CurrentCam);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CameraMode = (CameraMode + 1) % 2;
            ChangeCameraMode(CameraMode);
        }

        private void ChangeCameraMode(int mode)
        {
            if (mode == 0)
            {
                for (int i = 0; i < Globals.MAX_CAMERA; i++)
                {
                    CameraButton[i].Visible = true;
                }
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                btnNext.Visible = false;
            }
            else
            {
                for (int i = 0; i < Globals.MAX_CAMERA; i++)
                {
                    CameraButton[i].Visible = false;
                }
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                btnNext.Visible = true;
            }
        }

        private void FormSetVideo_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < Globals.gNumCam; i++)
            {
                CameraButton[i].Text = Globals.gDevices[i];
            }
        }

        public void Close_Video()
        {
            for (int i = 0; i < Globals.MAX_CAMERA; i++)
                StopCamera(i);
        }
    }
}
