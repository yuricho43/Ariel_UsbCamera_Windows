using System.Windows.Forms;
using System.Drawing;
namespace PSSystem
{
    partial class FormSetPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textCam4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCam3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCam2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCam1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textSNSString = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textWifiPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textWifiName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textSensor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textFireCrit = new System.Windows.Forms.TextBox();
            this.textXiroCrit = new System.Windows.Forms.TextBox();
            this.textSoundCrit = new System.Windows.Forms.TextBox();
            this.textSensorCrit = new System.Windows.Forms.TextBox();
            this.textTempCrit = new System.Windows.Forms.TextBox();
            this.textFireWarn = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textXiroWarn = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textSoundWarn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textSensorWarn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textTempWarn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkLogging = new System.Windows.Forms.CheckBox();
            this.textPeriod = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(250, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 43);
            this.label1.TabIndex = 15;
            this.label1.Text = "설정하기(배전반)";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(725, 359);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(63, 45);
            this.btnHome.TabIndex = 17;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textCam4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textCam3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textCam2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textCam1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 145);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "배전반 이름";
            // 
            // textCam4
            // 
            this.textCam4.Location = new System.Drawing.Point(84, 110);
            this.textCam4.Name = "textCam4";
            this.textCam4.Size = new System.Drawing.Size(216, 25);
            this.textCam4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "4번 : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textCam3
            // 
            this.textCam3.Location = new System.Drawing.Point(84, 82);
            this.textCam3.Name = "textCam3";
            this.textCam3.Size = new System.Drawing.Size(216, 25);
            this.textCam3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "3번 : ";
            // 
            // textCam2
            // 
            this.textCam2.Location = new System.Drawing.Point(84, 54);
            this.textCam2.Name = "textCam2";
            this.textCam2.Size = new System.Drawing.Size(216, 25);
            this.textCam2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "2번 : ";
            // 
            // textCam1
            // 
            this.textCam1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textCam1.Location = new System.Drawing.Point(84, 26);
            this.textCam1.Name = "textCam1";
            this.textCam1.Size = new System.Drawing.Size(216, 25);
            this.textCam1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "1번 : ";
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(725, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 45);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "저장하기";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textSNSString);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textPhoneNumber);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textWifiPass);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textWifiName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textSensor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(393, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 145);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "센서수, Wifi";
            // 
            // textSNSString
            // 
            this.textSNSString.Location = new System.Drawing.Point(125, 110);
            this.textSNSString.Name = "textSNSString";
            this.textSNSString.Size = new System.Drawing.Size(196, 25);
            this.textSNSString.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = "문자열:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(125, 82);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(196, 25);
            this.textPhoneNumber.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "전화번호 : ";
            // 
            // textWifiPass
            // 
            this.textWifiPass.Location = new System.Drawing.Point(125, 54);
            this.textWifiPass.Name = "textWifiPass";
            this.textWifiPass.Size = new System.Drawing.Size(196, 25);
            this.textWifiPass.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Wifi 암호: ";
            // 
            // textWifiName
            // 
            this.textWifiName.Location = new System.Drawing.Point(219, 26);
            this.textWifiName.Name = "textWifiName";
            this.textWifiName.Size = new System.Drawing.Size(102, 25);
            this.textWifiName.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Wifi 이름: ";
            // 
            // textSensor
            // 
            this.textSensor.Location = new System.Drawing.Point(84, 26);
            this.textSensor.Name = "textSensor";
            this.textSensor.Size = new System.Drawing.Size(42, 25);
            this.textSensor.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "센서 수: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.textFireCrit);
            this.groupBox3.Controls.Add(this.textXiroCrit);
            this.groupBox3.Controls.Add(this.textSoundCrit);
            this.groupBox3.Controls.Add(this.textSensorCrit);
            this.groupBox3.Controls.Add(this.textTempCrit);
            this.groupBox3.Controls.Add(this.textFireWarn);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.textXiroWarn);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textSoundWarn);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textSensorWarn);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textTempWarn);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(24, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 163);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(231, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 17);
            this.label22.TabIndex = 24;
            this.label22.Text = "사고값";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(112, 2);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 17);
            this.label21.TabIndex = 23;
            this.label21.Text = "경고값";
            // 
            // textFireCrit
            // 
            this.textFireCrit.Location = new System.Drawing.Point(207, 49);
            this.textFireCrit.Name = "textFireCrit";
            this.textFireCrit.Size = new System.Drawing.Size(92, 25);
            this.textFireCrit.TabIndex = 14;
            // 
            // textXiroCrit
            // 
            this.textXiroCrit.Location = new System.Drawing.Point(207, 76);
            this.textXiroCrit.Name = "textXiroCrit";
            this.textXiroCrit.Size = new System.Drawing.Size(92, 25);
            this.textXiroCrit.TabIndex = 13;
            // 
            // textSoundCrit
            // 
            this.textSoundCrit.Location = new System.Drawing.Point(207, 103);
            this.textSoundCrit.Name = "textSoundCrit";
            this.textSoundCrit.Size = new System.Drawing.Size(92, 25);
            this.textSoundCrit.TabIndex = 12;
            // 
            // textSensorCrit
            // 
            this.textSensorCrit.Location = new System.Drawing.Point(207, 22);
            this.textSensorCrit.Name = "textSensorCrit";
            this.textSensorCrit.Size = new System.Drawing.Size(92, 25);
            this.textSensorCrit.TabIndex = 11;
            // 
            // textTempCrit
            // 
            this.textTempCrit.Location = new System.Drawing.Point(207, 130);
            this.textTempCrit.Name = "textTempCrit";
            this.textTempCrit.Size = new System.Drawing.Size(92, 25);
            this.textTempCrit.TabIndex = 10;
            // 
            // textFireWarn
            // 
            this.textFireWarn.Location = new System.Drawing.Point(85, 49);
            this.textFireWarn.Name = "textFireWarn";
            this.textFireWarn.Size = new System.Drawing.Size(95, 25);
            this.textFireWarn.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "화재 :";
            // 
            // textXiroWarn
            // 
            this.textXiroWarn.Location = new System.Drawing.Point(85, 76);
            this.textXiroWarn.Name = "textXiroWarn";
            this.textXiroWarn.Size = new System.Drawing.Size(95, 25);
            this.textXiroWarn.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "진동 :";
            // 
            // textSoundWarn
            // 
            this.textSoundWarn.Location = new System.Drawing.Point(85, 103);
            this.textSoundWarn.Name = "textSoundWarn";
            this.textSoundWarn.Size = new System.Drawing.Size(95, 25);
            this.textSoundWarn.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "소음 :";
            // 
            // textSensorWarn
            // 
            this.textSensorWarn.Location = new System.Drawing.Point(85, 22);
            this.textSensorWarn.Name = "textSensorWarn";
            this.textSensorWarn.Size = new System.Drawing.Size(95, 25);
            this.textSensorWarn.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "아크 :";
            // 
            // textTempWarn
            // 
            this.textTempWarn.Location = new System.Drawing.Point(85, 130);
            this.textTempWarn.Name = "textTempWarn";
            this.textTempWarn.Size = new System.Drawing.Size(95, 25);
            this.textTempWarn.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "온도 :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkLogging);
            this.groupBox4.Controls.Add(this.textPeriod);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(393, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 163);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "기타 설정";
            // 
            // checkLogging
            // 
            this.checkLogging.AutoSize = true;
            this.checkLogging.Location = new System.Drawing.Point(28, 55);
            this.checkLogging.Name = "checkLogging";
            this.checkLogging.Size = new System.Drawing.Size(97, 21);
            this.checkLogging.TabIndex = 13;
            this.checkLogging.Text = "데이타 로깅";
            this.checkLogging.UseVisualStyleBackColor = true;
            // 
            // textPeriod
            // 
            this.textPeriod.Location = new System.Drawing.Point(228, 17);
            this.textPeriod.Name = "textPeriod";
            this.textPeriod.Size = new System.Drawing.Size(92, 25);
            this.textPeriod.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "데이타 요청 주기 (200~2000) :";
            // 
            // FormSetPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetPanel";
            this.RightToLeftLayout = true;
            this.Text = "FormSetPanel";
            this.Shown += new System.EventHandler(this.FormSetPanel_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnHome;
        private GroupBox groupBox1;
        private TextBox textCam4;
        private Label label4;
        private TextBox textCam3;
        private Label label5;
        private TextBox textCam2;
        private Label label3;
        private TextBox textCam1;
        private Label label2;
        private Button btnSave;
        private GroupBox groupBox2;
        private TextBox textWifiPass;
        private Label label7;
        private TextBox textWifiName;
        private Label label8;
        private TextBox textSensor;
        private Label label9;
        private GroupBox groupBox3;
        private TextBox textSoundWarn;
        private Label label6;
        private TextBox textSensorWarn;
        private Label label10;
        private TextBox textTempWarn;
        private Label label11;
        private GroupBox groupBox4;
        private Label label13;
        private TextBox textXiroWarn;
        private Label label15;
        private TextBox textSNSString;
        private Label label18;
        private TextBox textPhoneNumber;
        private Label label17;
        private TextBox textFireWarn;
        private Label label19;
        private Label label22;
        private Label label21;
        private TextBox textFireCrit;
        private TextBox textXiroCrit;
        private TextBox textSoundCrit;
        private TextBox textSensorCrit;
        private TextBox textTempCrit;
        private CheckBox checkLogging;
        private TextBox textPeriod;
    }
}