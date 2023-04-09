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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblSound = new System.Windows.Forms.Label();
            this.lblVib = new System.Windows.Forms.Label();
            this.lblFire = new System.Windows.Forms.Label();
            this.lblArc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(268, 9);
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
            this.label4.Location = new System.Drawing.Point(132, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 45);
            this.label4.TabIndex = 20;
            this.label4.Text = "진동: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(132, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 45);
            this.label3.TabIndex = 19;
            this.label3.Text = "화재 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(132, 70);
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
            this.label5.Location = new System.Drawing.Point(132, 214);
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
            this.label6.Location = new System.Drawing.Point(132, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 45);
            this.label6.TabIndex = 22;
            this.label6.Text = "온도 : ";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.lblTemp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTemp.Location = new System.Drawing.Point(304, 262);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(90, 45);
            this.lblTemp.TabIndex = 27;
            this.lblTemp.Text = "25도";
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.lblSound.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSound.Location = new System.Drawing.Point(304, 214);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(148, 45);
            this.lblSound.TabIndex = 26;
            this.lblSound.Text = "이상없음";
            // 
            // lblVib
            // 
            this.lblVib.AutoSize = true;
            this.lblVib.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.lblVib.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVib.Location = new System.Drawing.Point(304, 166);
            this.lblVib.Name = "lblVib";
            this.lblVib.Size = new System.Drawing.Size(148, 45);
            this.lblVib.TabIndex = 25;
            this.lblVib.Text = "이상없음";
            // 
            // lblFire
            // 
            this.lblFire.AutoSize = true;
            this.lblFire.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.lblFire.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFire.Location = new System.Drawing.Point(304, 118);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(148, 45);
            this.lblFire.TabIndex = 24;
            this.lblFire.Text = "이상없음";
            // 
            // lblArc
            // 
            this.lblArc.AutoSize = true;
            this.lblArc.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.lblArc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArc.Location = new System.Drawing.Point(304, 70);
            this.lblArc.Name = "lblArc";
            this.lblArc.Size = new System.Drawing.Size(148, 45);
            this.lblArc.TabIndex = 23;
            this.lblArc.Text = "이상없음";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.lblVib);
            this.Controls.Add(this.lblFire);
            this.Controls.Add(this.lblArc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label lblTemp;
        private Label lblSound;
        private Label lblVib;
        private Label lblFire;
        private Label lblArc;
    }
}