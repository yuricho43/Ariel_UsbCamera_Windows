using System.Windows.Forms;
using System.Drawing;
namespace PSSystem
{
    partial class FormMain
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.lblFire = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblSound = new System.Windows.Forms.Label();
            this.lblVib = new System.Windows.Forms.Label();
            this.lblArc = new System.Windows.Forms.Label();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.lblFire2 = new System.Windows.Forms.Label();
            this.lblTemp2 = new System.Windows.Forms.Label();
            this.lblSound2 = new System.Windows.Forms.Label();
            this.lblVib2 = new System.Windows.Forms.Label();
            this.lblArc2 = new System.Windows.Forms.Label();
            this.grp4 = new System.Windows.Forms.GroupBox();
            this.lblFire4 = new System.Windows.Forms.Label();
            this.lblTemp4 = new System.Windows.Forms.Label();
            this.lblSound4 = new System.Windows.Forms.Label();
            this.lblVib4 = new System.Windows.Forms.Label();
            this.lblArc4 = new System.Windows.Forms.Label();
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.lblFire3 = new System.Windows.Forms.Label();
            this.lblTemp3 = new System.Windows.Forms.Label();
            this.lblSound3 = new System.Windows.Forms.Label();
            this.lblVib3 = new System.Windows.Forms.Label();
            this.lblArc3 = new System.Windows.Forms.Label();
            this.grp1.SuspendLayout();
            this.grp2.SuspendLayout();
            this.grp4.SuspendLayout();
            this.grp3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(257, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 43);
            this.label1.TabIndex = 17;
            this.label1.Text = "동작상태 보기";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(65, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 45);
            this.label4.TabIndex = 20;
            this.label4.Text = "진동 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(65, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 45);
            this.label2.TabIndex = 18;
            this.label2.Text = "아크 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(65, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 45);
            this.label5.TabIndex = 21;
            this.label5.Text = "소음 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(65, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 45);
            this.label6.TabIndex = 22;
            this.label6.Text = "온도 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(65, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 45);
            this.label3.TabIndex = 28;
            this.label3.Text = "화재 :";
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.lblFire);
            this.grp1.Controls.Add(this.lblTemp);
            this.grp1.Controls.Add(this.lblSound);
            this.grp1.Controls.Add(this.lblVib);
            this.grp1.Controls.Add(this.lblArc);
            this.grp1.ForeColor = System.Drawing.Color.White;
            this.grp1.Location = new System.Drawing.Point(190, 57);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(131, 295);
            this.grp1.TabIndex = 30;
            this.grp1.TabStop = false;
            this.grp1.Text = "CH 1";
            // 
            // lblFire
            // 
            this.lblFire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFire.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFire.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFire.Location = new System.Drawing.Point(7, 87);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(118, 31);
            this.lblFire.TabIndex = 34;
            this.lblFire.Text = "정상 (56) ";
            // 
            // lblTemp
            // 
            this.lblTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTemp.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTemp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTemp.Location = new System.Drawing.Point(7, 252);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(118, 31);
            this.lblTemp.TabIndex = 33;
            this.lblTemp.Text = "위험 (88)";
            // 
            // lblSound
            // 
            this.lblSound.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSound.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSound.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSound.Location = new System.Drawing.Point(7, 197);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(118, 31);
            this.lblSound.TabIndex = 32;
            this.lblSound.Text = "경고 (78)";
            // 
            // lblVib
            // 
            this.lblVib.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVib.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblVib.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVib.Location = new System.Drawing.Point(7, 142);
            this.lblVib.Name = "lblVib";
            this.lblVib.Size = new System.Drawing.Size(118, 31);
            this.lblVib.TabIndex = 31;
            this.lblVib.Text = "정상 (45)";
            // 
            // lblArc
            // 
            this.lblArc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArc.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblArc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArc.Location = new System.Drawing.Point(7, 32);
            this.lblArc.Name = "lblArc";
            this.lblArc.Size = new System.Drawing.Size(118, 31);
            this.lblArc.TabIndex = 30;
            this.lblArc.Text = "정상 (44)";
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.lblFire2);
            this.grp2.Controls.Add(this.lblTemp2);
            this.grp2.Controls.Add(this.lblSound2);
            this.grp2.Controls.Add(this.lblVib2);
            this.grp2.Controls.Add(this.lblArc2);
            this.grp2.ForeColor = System.Drawing.Color.White;
            this.grp2.Location = new System.Drawing.Point(333, 57);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(131, 295);
            this.grp2.TabIndex = 31;
            this.grp2.TabStop = false;
            this.grp2.Text = "CH 2";
            // 
            // lblFire2
            // 
            this.lblFire2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFire2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFire2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFire2.Location = new System.Drawing.Point(7, 87);
            this.lblFire2.Name = "lblFire2";
            this.lblFire2.Size = new System.Drawing.Size(118, 31);
            this.lblFire2.TabIndex = 34;
            this.lblFire2.Text = "정상 (56) ";
            // 
            // lblTemp2
            // 
            this.lblTemp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTemp2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTemp2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTemp2.Location = new System.Drawing.Point(7, 252);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(118, 31);
            this.lblTemp2.TabIndex = 33;
            this.lblTemp2.Text = "위험 (88)";
            // 
            // lblSound2
            // 
            this.lblSound2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSound2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSound2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSound2.Location = new System.Drawing.Point(7, 197);
            this.lblSound2.Name = "lblSound2";
            this.lblSound2.Size = new System.Drawing.Size(118, 31);
            this.lblSound2.TabIndex = 32;
            this.lblSound2.Text = "경고 (78)";
            // 
            // lblVib2
            // 
            this.lblVib2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVib2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblVib2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVib2.Location = new System.Drawing.Point(7, 142);
            this.lblVib2.Name = "lblVib2";
            this.lblVib2.Size = new System.Drawing.Size(118, 31);
            this.lblVib2.TabIndex = 31;
            this.lblVib2.Text = "정상 (45)";
            // 
            // lblArc2
            // 
            this.lblArc2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArc2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblArc2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArc2.Location = new System.Drawing.Point(7, 32);
            this.lblArc2.Name = "lblArc2";
            this.lblArc2.Size = new System.Drawing.Size(118, 31);
            this.lblArc2.TabIndex = 30;
            this.lblArc2.Text = "정상 (44)";
            // 
            // grp4
            // 
            this.grp4.Controls.Add(this.lblFire4);
            this.grp4.Controls.Add(this.lblTemp4);
            this.grp4.Controls.Add(this.lblSound4);
            this.grp4.Controls.Add(this.lblVib4);
            this.grp4.Controls.Add(this.lblArc4);
            this.grp4.ForeColor = System.Drawing.Color.White;
            this.grp4.Location = new System.Drawing.Point(619, 57);
            this.grp4.Name = "grp4";
            this.grp4.Size = new System.Drawing.Size(131, 295);
            this.grp4.TabIndex = 33;
            this.grp4.TabStop = false;
            this.grp4.Text = "CH 4";
            // 
            // lblFire4
            // 
            this.lblFire4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFire4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFire4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFire4.Location = new System.Drawing.Point(7, 87);
            this.lblFire4.Name = "lblFire4";
            this.lblFire4.Size = new System.Drawing.Size(118, 31);
            this.lblFire4.TabIndex = 34;
            this.lblFire4.Text = "정상 (56) ";
            // 
            // lblTemp4
            // 
            this.lblTemp4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTemp4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTemp4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTemp4.Location = new System.Drawing.Point(7, 252);
            this.lblTemp4.Name = "lblTemp4";
            this.lblTemp4.Size = new System.Drawing.Size(118, 31);
            this.lblTemp4.TabIndex = 33;
            this.lblTemp4.Text = "위험 (88)";
            // 
            // lblSound4
            // 
            this.lblSound4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSound4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSound4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSound4.Location = new System.Drawing.Point(7, 197);
            this.lblSound4.Name = "lblSound4";
            this.lblSound4.Size = new System.Drawing.Size(118, 31);
            this.lblSound4.TabIndex = 32;
            this.lblSound4.Text = "경고 (78)";
            // 
            // lblVib4
            // 
            this.lblVib4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVib4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblVib4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVib4.Location = new System.Drawing.Point(7, 142);
            this.lblVib4.Name = "lblVib4";
            this.lblVib4.Size = new System.Drawing.Size(118, 31);
            this.lblVib4.TabIndex = 31;
            this.lblVib4.Text = "정상 (45)";
            // 
            // lblArc4
            // 
            this.lblArc4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArc4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblArc4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArc4.Location = new System.Drawing.Point(7, 32);
            this.lblArc4.Name = "lblArc4";
            this.lblArc4.Size = new System.Drawing.Size(118, 31);
            this.lblArc4.TabIndex = 30;
            this.lblArc4.Text = "정상 (44)";
            // 
            // grp3
            // 
            this.grp3.Controls.Add(this.lblFire3);
            this.grp3.Controls.Add(this.lblTemp3);
            this.grp3.Controls.Add(this.lblSound3);
            this.grp3.Controls.Add(this.lblVib3);
            this.grp3.Controls.Add(this.lblArc3);
            this.grp3.ForeColor = System.Drawing.Color.White;
            this.grp3.Location = new System.Drawing.Point(476, 57);
            this.grp3.Name = "grp3";
            this.grp3.Size = new System.Drawing.Size(131, 295);
            this.grp3.TabIndex = 32;
            this.grp3.TabStop = false;
            this.grp3.Text = "CH 3";
            // 
            // lblFire3
            // 
            this.lblFire3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFire3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFire3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFire3.Location = new System.Drawing.Point(7, 87);
            this.lblFire3.Name = "lblFire3";
            this.lblFire3.Size = new System.Drawing.Size(118, 31);
            this.lblFire3.TabIndex = 34;
            this.lblFire3.Text = "정상 (56) ";
            // 
            // lblTemp3
            // 
            this.lblTemp3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTemp3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTemp3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTemp3.Location = new System.Drawing.Point(7, 252);
            this.lblTemp3.Name = "lblTemp3";
            this.lblTemp3.Size = new System.Drawing.Size(118, 31);
            this.lblTemp3.TabIndex = 33;
            this.lblTemp3.Text = "위험 (88)";
            // 
            // lblSound3
            // 
            this.lblSound3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSound3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSound3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSound3.Location = new System.Drawing.Point(7, 197);
            this.lblSound3.Name = "lblSound3";
            this.lblSound3.Size = new System.Drawing.Size(118, 31);
            this.lblSound3.TabIndex = 32;
            this.lblSound3.Text = "경고 (78)";
            // 
            // lblVib3
            // 
            this.lblVib3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVib3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblVib3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVib3.Location = new System.Drawing.Point(7, 142);
            this.lblVib3.Name = "lblVib3";
            this.lblVib3.Size = new System.Drawing.Size(118, 31);
            this.lblVib3.TabIndex = 31;
            this.lblVib3.Text = "정상 (45)";
            // 
            // lblArc3
            // 
            this.lblArc3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArc3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblArc3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArc3.Location = new System.Drawing.Point(7, 32);
            this.lblArc3.Name = "lblArc3";
            this.lblArc3.Size = new System.Drawing.Size(118, 31);
            this.lblArc3.TabIndex = 30;
            this.lblArc3.Text = "정상 (44)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.grp4);
            this.Controls.Add(this.grp3);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.Enter += new System.EventHandler(this.FormMain_Enter);
            this.grp1.ResumeLayout(false);
            this.grp2.ResumeLayout(false);
            this.grp4.ResumeLayout(false);
            this.grp3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label3;
        private GroupBox grp1;
        private Label lblFire;
        private Label lblTemp;
        private Label lblSound;
        private Label lblVib;
        private Label lblArc;
        private GroupBox grp2;
        private Label lblFire2;
        private Label lblTemp2;
        private Label lblSound2;
        private Label lblVib2;
        private Label lblArc2;
        private GroupBox grp4;
        private Label lblFire4;
        private Label lblTemp4;
        private Label lblSound4;
        private Label lblVib4;
        private Label lblArc4;
        private GroupBox grp3;
        private Label lblFire3;
        private Label lblTemp3;
        private Label lblSound3;
        private Label lblVib3;
        private Label lblArc3;
    }
}