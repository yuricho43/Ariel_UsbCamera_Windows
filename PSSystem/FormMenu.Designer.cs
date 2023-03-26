using System.Windows.Forms;
using System.Drawing;

namespace PSSystem
{
    partial class FormMenu
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
            this.btnName = new System.Windows.Forms.Button();
            this.btnWarning = new System.Windows.Forms.Button();
            this.btnCritical = new System.Windows.Forms.Button();
            this.btnSensor = new System.Windows.Forms.Button();
            this.btnRelay = new System.Windows.Forms.Button();
            this.btnWifi = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnName.Location = new System.Drawing.Point(156, 21);
            this.btnName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(168, 30);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "1.배전반이름 설정";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnWarning
            // 
            this.btnWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarning.Location = new System.Drawing.Point(156, 66);
            this.btnWarning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(168, 30);
            this.btnWarning.TabIndex = 1;
            this.btnWarning.Text = "2. 1차 경보 설정";
            this.btnWarning.UseVisualStyleBackColor = true;
            this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // btnCritical
            // 
            this.btnCritical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCritical.Location = new System.Drawing.Point(156, 109);
            this.btnCritical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCritical.Name = "btnCritical";
            this.btnCritical.Size = new System.Drawing.Size(168, 30);
            this.btnCritical.TabIndex = 2;
            this.btnCritical.Text = "3. 2차 사고 설정";
            this.btnCritical.UseVisualStyleBackColor = true;
            this.btnCritical.Click += new System.EventHandler(this.btnCritical_Click);
            // 
            // btnSensor
            // 
            this.btnSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSensor.Location = new System.Drawing.Point(156, 155);
            this.btnSensor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSensor.Name = "btnSensor";
            this.btnSensor.Size = new System.Drawing.Size(168, 30);
            this.btnSensor.TabIndex = 3;
            this.btnSensor.Text = "4. 센서 확장 수 설정";
            this.btnSensor.UseVisualStyleBackColor = true;
            this.btnSensor.Click += new System.EventHandler(this.btnSensor_Click);
            // 
            // btnRelay
            // 
            this.btnRelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelay.Location = new System.Drawing.Point(156, 201);
            this.btnRelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelay.Name = "btnRelay";
            this.btnRelay.Size = new System.Drawing.Size(168, 30);
            this.btnRelay.TabIndex = 4;
            this.btnRelay.Text = "5. 릴레이 접점 테스트";
            this.btnRelay.UseVisualStyleBackColor = true;
            this.btnRelay.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnWifi
            // 
            this.btnWifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWifi.Location = new System.Drawing.Point(458, 155);
            this.btnWifi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWifi.Name = "btnWifi";
            this.btnWifi.Size = new System.Drawing.Size(168, 30);
            this.btnWifi.TabIndex = 8;
            this.btnWifi.Text = "9. WIFI ID, PS 설정";
            this.btnWifi.UseVisualStyleBackColor = true;
            this.btnWifi.Click += new System.EventHandler(this.btnWifi_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.Location = new System.Drawing.Point(458, 109);
            this.btnVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(168, 30);
            this.btnVideo.TabIndex = 7;
            this.btnVideo.Text = "8. 영상 검색";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnData
            // 
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Location = new System.Drawing.Point(458, 66);
            this.btnData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(168, 30);
            this.btnData.TabIndex = 6;
            this.btnData.Text = "7. 저장 데이타 검색";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnState
            // 
            this.btnState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnState.Location = new System.Drawing.Point(458, 21);
            this.btnState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(168, 30);
            this.btnState.TabIndex = 5;
            this.btnState.Text = "6. 상태 검색";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(725, 359);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(63, 45);
            this.btnHome.TabIndex = 16;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Location = new System.Drawing.Point(458, 201);
            this.btnEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(168, 30);
            this.btnEvent.TabIndex = 17;
            this.btnEvent.Text = "10. 이벤트보기";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnWifi);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.btnRelay);
            this.Controls.Add(this.btnSensor);
            this.Controls.Add(this.btnCritical);
            this.Controls.Add(this.btnWarning);
            this.Controls.Add(this.btnName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnName;
        private Button btnWarning;
        private Button btnCritical;
        private Button btnSensor;
        private Button btnRelay;
        private Button btnWifi;
        private Button btnVideo;
        private Button btnData;
        private Button btnState;
        private Button btnHome;
        private Button btnEvent;
    }
}