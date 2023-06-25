using OpenCvSharp;
using System;
using System.Drawing;
using System.Threading;
using System.Web.ModelBinding;
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
            string strMessage = "TEST MESSAGE";
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
                
                if (chkLineDeco.Checked)
                    Draw4x4Lines(ix);

                DisplayTextData(ix, chkTempDeco.Checked, chkSensorDeco.Checked);

                if (CameraMode == 0)
                    ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Globals.gFrame[ix]), ix);
                else
                    ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Globals.gFrame[ix]), -1);
            }
            Globals.gVideoList[ix].Release();
            Globals.gFrame[ix].Release();

            Globals.gVideoList[ix] = null;
        }

        private void DisplayTextData(int ix, bool bTemp, bool bSensor)
        {
            int width = Globals.gFrame[ix].Width;
            int height = Globals.gFrame[ix].Height;
            int xpos = 0;
            int ypos = 0;
            short isValue = 0;

            if (bTemp)
            {
                for (int i = 0; i < 16; i++)
                {
                    xpos = (i % 4) * width / 4 + 10;
                    ypos = (i / 4) * height / 4 + 40;
                    isValue = Globals.GetShortValueFrom2bytes(Globals.gTempValue[ix, 2 * i], Globals.gTempValue[ix, 2 * i + 1]);
                    Cv2.PutText(Globals.gFrame[ix], isValue.ToString(), new OpenCvSharp.Point(xpos, ypos), HersheyFonts.HersheyComplex, 1.5, Scalar.Red, 1);
                }
            }

            if (bSensor)
            {
                for (int i = 0; i < 16; i++)
                {
                    xpos = (i % 4) * width / 4 + 10;
                    ypos = (i / 4) * height / 4 + 80;
                    isValue = Globals.GetShortValueFrom2bytes(Globals.gSensorValue[ix, 2 * i], Globals.gSensorValue[ix, 2 * i + 1]);
                    Cv2.PutText(Globals.gFrame[ix], isValue.ToString(), new OpenCvSharp.Point(xpos, ypos), HersheyFonts.HersheyComplex, 1.5, Scalar.Yellow, 1);
                }
            }
        }


        private void Draw4x4Lines(int ix)
        {
            int width = Globals.gFrame[ix].Width/ 4;
            int height = Globals.gFrame[ix].Height/ 4;

            for (int i = 0; i < 5; i++)
            {
                if (i < 4) {
                    Cv2.Line(Globals.gFrame[ix], width * i, 0, width * i, height * 4, Scalar.White, 1, LineTypes.AntiAlias);
                    Cv2.Line(Globals.gFrame[ix], 0, height * i, width * 4, height * i, Scalar.White, 1, LineTypes.AntiAlias);
                }
                else
                {
                    Cv2.Line(Globals.gFrame[ix], width * i-1, 0, width * i-1, height * 4, Scalar.White, 1, LineTypes.AntiAlias);
                    Cv2.Line(Globals.gFrame[ix], 0, height * i-1, width * 4, height * i-1, Scalar.White, 1, LineTypes.AntiAlias);
                }
            }
        }
        /***********************************************************************************************************
            Cv2.Line(draw, 10, 10, 630, 10, Scalar.Red, 10, LineTypes.AntiAlias);
            Cv2.Line(draw, new Point(10, 30), new Point(630, 30), Scalar.Orange, 10, LineTypes.AntiAlias);

            Cv2.Circle(draw, 30, 70, 20, Scalar.Yellow, 10, LineTypes.AntiAlias);
            Cv2.Circle(draw, new Point(90, 70), 25, Scalar.Green, -1, LineTypes.AntiAlias);

            Cv2.Rectangle(draw, new Rect(130, 50, 40, 40), Scalar.Blue, 10, LineTypes.AntiAlias);
            Cv2.Rectangle(draw, new Point(185, 45), new Point(235, 95), Scalar.Navy, -1, LineTypes.AntiAlias);

            Cv2.Ellipse(draw, new RotatedRect(new Point2f(290,70),new Size2f(75,45),0), Scalar.BlueViolet, 10, LineTypes.AntiAlias);
            Cv2.Ellipse(draw, new Point(10, 150), new Size(50, 50), -90, 0, 100, Scalar.Tomato, -1, LineTypes.AntiAlias);

            Cv2.PutText(draw, "DrawingTest", new Point(10, 250), HersheyFonts.HersheyComplex, 2, Scalar.White, 5, LineTypes.AntiAlias);

            Cv2.ImShow("Drawing", draw);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        **************************************************************************************************/
        private void StartCamera(int index)
        {
            if (index >= Globals.gNumCam)
                return;

            Globals.gThread[index] = new Thread(new ParameterizedThreadStart(CameraCallback0));
            Globals.gThread[index].Start(index);
            CameraButton[index].BackColor = Color.Lime;
        }

        private void StopCamera(int index)
        {
            CameraButton[index].BackColor = Color.Gray;
            if (Globals.gIsAlive[index] == 0)
                return;
            Globals.gIsAlive[index] = 0;
            Globals.gThread[index].Join();
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
            if (Globals.gNumCam <= 0)       // avoid zero divide
                return;

            lock (Globals.gLockCamera)
            {
                CurrentCam = (CurrentCam + 1) % Globals.gNumCam;
                StopCamera((CurrentCam + Globals.gNumCam - 1) % Globals.gNumCam);
                StartCamera(CurrentCam);
                btnNext.Text = Globals.gDevices[CurrentCam];
            }
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
                grpDeco.Visible = false;
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
                grpDeco.Visible = true;
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
