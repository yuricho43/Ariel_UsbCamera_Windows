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
            this.btnName.BackColor = System.Drawing.Color.Blue;
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnName.ForeColor = System.Drawing.Color.White;
            this.btnName.Location = new System.Drawing.Point(156, 45);
            this.btnName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(199, 40);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "1. 이름, 기준, WIFI 설정";
            this.btnName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnWarning
            // 
            this.btnWarning.BackColor = System.Drawing.Color.Blue;
            this.btnWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarning.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWarning.ForeColor = System.Drawing.Color.White;
            this.btnWarning.Location = new System.Drawing.Point(156, 102);
            this.btnWarning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(199, 40);
            this.btnWarning.TabIndex = 1;
            this.btnWarning.Text = "2. 포트설정";
            this.btnWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWarning.UseVisualStyleBackColor = false;
            this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // btnCritical
            // 
            this.btnCritical.BackColor = System.Drawing.Color.Blue;
            this.btnCritical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCritical.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCritical.ForeColor = System.Drawing.Color.White;
            this.btnCritical.Location = new System.Drawing.Point(156, 273);
            this.btnCritical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCritical.Name = "btnCritical";
            this.btnCritical.Size = new System.Drawing.Size(199, 40);
            this.btnCritical.TabIndex = 2;
            this.btnCritical.Text = "(사용안함-사고설정)";
            this.btnCritical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCritical.UseVisualStyleBackColor = false;
            this.btnCritical.Visible = false;
            this.btnCritical.Click += new System.EventHandler(this.btnCritical_Click);
            // 
            // btnSensor
            // 
            this.btnSensor.BackColor = System.Drawing.Color.Blue;
            this.btnSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSensor.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSensor.ForeColor = System.Drawing.Color.White;
            this.btnSensor.Location = new System.Drawing.Point(458, 273);
            this.btnSensor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSensor.Name = "btnSensor";
            this.btnSensor.Size = new System.Drawing.Size(199, 40);
            this.btnSensor.TabIndex = 3;
            this.btnSensor.Text = "(사용안함-센서)";
            this.btnSensor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSensor.UseVisualStyleBackColor = false;
            this.btnSensor.Visible = false;
            this.btnSensor.Click += new System.EventHandler(this.btnSensor_Click);
            // 
            // btnRelay
            // 
            this.btnRelay.BackColor = System.Drawing.Color.Blue;
            this.btnRelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelay.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRelay.ForeColor = System.Drawing.Color.White;
            this.btnRelay.Location = new System.Drawing.Point(156, 159);
            this.btnRelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelay.Name = "btnRelay";
            this.btnRelay.Size = new System.Drawing.Size(199, 40);
            this.btnRelay.TabIndex = 4;
            this.btnRelay.Text = "3. 릴레이 접점 테스트";
            this.btnRelay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelay.UseVisualStyleBackColor = false;
            this.btnRelay.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnWifi
            // 
            this.btnWifi.BackColor = System.Drawing.Color.Blue;
            this.btnWifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWifi.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWifi.ForeColor = System.Drawing.Color.White;
            this.btnWifi.Location = new System.Drawing.Point(458, 216);
            this.btnWifi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWifi.Name = "btnWifi";
            this.btnWifi.Size = new System.Drawing.Size(199, 40);
            this.btnWifi.TabIndex = 8;
            this.btnWifi.Text = "(사용안함-DEBUG)";
            this.btnWifi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWifi.UseVisualStyleBackColor = false;
            this.btnWifi.Visible = false;
            this.btnWifi.Click += new System.EventHandler(this.btnWifi_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.BackColor = System.Drawing.Color.Blue;
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnVideo.ForeColor = System.Drawing.Color.White;
            this.btnVideo.Location = new System.Drawing.Point(156, 216);
            this.btnVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(199, 40);
            this.btnVideo.TabIndex = 7;
            this.btnVideo.Text = "4. 영상 검색";
            this.btnVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVideo.UseVisualStyleBackColor = false;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.Blue;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnData.ForeColor = System.Drawing.Color.White;
            this.btnData.Location = new System.Drawing.Point(458, 102);
            this.btnData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(199, 40);
            this.btnData.TabIndex = 6;
            this.btnData.Text = "6. 저장 데이타 검색";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.Blue;
            this.btnState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnState.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnState.ForeColor = System.Drawing.Color.White;
            this.btnState.Location = new System.Drawing.Point(458, 45);
            this.btnState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(199, 40);
            this.btnState.TabIndex = 5;
            this.btnState.Text = "5. 상태 검색";
            this.btnState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnState.UseVisualStyleBackColor = false;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
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
            this.btnEvent.BackColor = System.Drawing.Color.Blue;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEvent.ForeColor = System.Drawing.Color.White;
            this.btnEvent.Location = new System.Drawing.Point(458, 159);
            this.btnEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(199, 40);
            this.btnEvent.TabIndex = 17;
            this.btnEvent.Text = "7. 이벤트보기";
            this.btnEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvent.UseVisualStyleBackColor = false;
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