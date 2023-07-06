using System.Windows.Forms;
using System.Drawing;
namespace PSSystem
{
    partial class FormSetData
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
            this.btnHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.textLen = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(725, 359);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(63, 45);
            this.btnHome.TabIndex = 23;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(239, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 43);
            this.label2.TabIndex = 22;
            this.label2.Text = "저장 데이타 검색";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDate,
            this.columnText});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(686, 347);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnDate
            // 
            this.columnDate.Text = "시간";
            this.columnDate.Width = 140;
            // 
            // columnText
            // 
            this.columnText.Text = "데이타";
            this.columnText.Width = 500;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(538, 28);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(160, 23);
            this.dtDate.TabIndex = 25;
            // 
            // textLen
            // 
            this.textLen.ForeColor = System.Drawing.Color.Black;
            this.textLen.Location = new System.Drawing.Point(707, 133);
            this.textLen.Name = "textLen";
            this.textLen.Size = new System.Drawing.Size(32, 23);
            this.textLen.TabIndex = 28;
            this.textLen.Text = "50";
            // 
            // btnGet
            // 
            this.btnGet.ForeColor = System.Drawing.Color.Black;
            this.btnGet.Location = new System.Drawing.Point(707, 104);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 29;
            this.btnGet.Text = "가져오기";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(705, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "날짜선택";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(707, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormSetData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.textLen);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSetData";
            this.Text = "FormC1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHome;
        private Label label2;
        private ListView listView1;
        private ColumnHeader columnDate;
        private ColumnHeader columnText;
        private DateTimePicker dtDate;
        private TextBox textLen;
        private Button btnGet;
        private Button btnSearch;
        private Button btnClear;
    }
}