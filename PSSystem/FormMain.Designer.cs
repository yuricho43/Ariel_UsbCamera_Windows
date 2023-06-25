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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grp4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
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
            this.label5.Text = "음파 : ";
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
            this.grp2.Controls.Add(this.label7);
            this.grp2.Controls.Add(this.label8);
            this.grp2.Controls.Add(this.label9);
            this.grp2.Controls.Add(this.label10);
            this.grp2.Controls.Add(this.label11);
            this.grp2.ForeColor = System.Drawing.Color.White;
            this.grp2.Location = new System.Drawing.Point(333, 57);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(131, 295);
            this.grp2.TabIndex = 31;
            this.grp2.TabStop = false;
            this.grp2.Text = "CH 2";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(7, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "정상 (56) ";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(7, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 31);
            this.label8.TabIndex = 33;
            this.label8.Text = "위험 (88)";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(7, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 31);
            this.label9.TabIndex = 32;
            this.label9.Text = "경고 (78)";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(7, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 31);
            this.label10.TabIndex = 31;
            this.label10.Text = "정상 (45)";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(7, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 31);
            this.label11.TabIndex = 30;
            this.label11.Text = "정상 (44)";
            // 
            // grp4
            // 
            this.grp4.Controls.Add(this.label12);
            this.grp4.Controls.Add(this.label13);
            this.grp4.Controls.Add(this.label14);
            this.grp4.Controls.Add(this.label15);
            this.grp4.Controls.Add(this.label16);
            this.grp4.ForeColor = System.Drawing.Color.White;
            this.grp4.Location = new System.Drawing.Point(619, 57);
            this.grp4.Name = "grp4";
            this.grp4.Size = new System.Drawing.Size(131, 295);
            this.grp4.TabIndex = 33;
            this.grp4.TabStop = false;
            this.grp4.Text = "CH 4";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(7, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 31);
            this.label12.TabIndex = 34;
            this.label12.Text = "정상 (56) ";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(7, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 31);
            this.label13.TabIndex = 33;
            this.label13.Text = "위험 (88)";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(7, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 31);
            this.label14.TabIndex = 32;
            this.label14.Text = "경고 (78)";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(7, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 31);
            this.label15.TabIndex = 31;
            this.label15.Text = "정상 (45)";
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(7, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 31);
            this.label16.TabIndex = 30;
            this.label16.Text = "정상 (44)";
            // 
            // grp3
            // 
            this.grp3.Controls.Add(this.label17);
            this.grp3.Controls.Add(this.label18);
            this.grp3.Controls.Add(this.label19);
            this.grp3.Controls.Add(this.label20);
            this.grp3.Controls.Add(this.label21);
            this.grp3.ForeColor = System.Drawing.Color.White;
            this.grp3.Location = new System.Drawing.Point(476, 57);
            this.grp3.Name = "grp3";
            this.grp3.Size = new System.Drawing.Size(131, 295);
            this.grp3.TabIndex = 32;
            this.grp3.TabStop = false;
            this.grp3.Text = "CH 3";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(7, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 31);
            this.label17.TabIndex = 34;
            this.label17.Text = "정상 (56) ";
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(7, 252);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 31);
            this.label18.TabIndex = 33;
            this.label18.Text = "위험 (88)";
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(7, 197);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 31);
            this.label19.TabIndex = 32;
            this.label19.Text = "경고 (78)";
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(7, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 31);
            this.label20.TabIndex = 31;
            this.label20.Text = "정상 (45)";
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(7, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(118, 31);
            this.label21.TabIndex = 30;
            this.label21.Text = "정상 (44)";
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
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private GroupBox grp4;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private GroupBox grp3;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
    }
}