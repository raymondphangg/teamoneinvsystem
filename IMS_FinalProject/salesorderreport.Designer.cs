
namespace IMS_FinalProject
{
    partial class salesorderreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salesorderreport));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.enddatetxt = new System.Windows.Forms.DateTimePicker();
            this.startdatetxt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // printbtn
            // 
            this.printbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.printbtn.Location = new System.Drawing.Point(997, 425);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(93, 47);
            this.printbtn.TabIndex = 44;
            this.printbtn.Text = "Print";
            this.printbtn.UseVisualStyleBackColor = false;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 45;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(320, 456);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(73, 27);
            this.Searchbtn.TabIndex = 61;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // enddatetxt
            // 
            this.enddatetxt.CustomFormat = "yyyy-MM-dd";
            this.enddatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddatetxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.enddatetxt.Location = new System.Drawing.Point(113, 461);
            this.enddatetxt.Name = "enddatetxt";
            this.enddatetxt.Size = new System.Drawing.Size(184, 22);
            this.enddatetxt.TabIndex = 60;
            // 
            // startdatetxt
            // 
            this.startdatetxt.CustomFormat = "yyyy-MM-dd";
            this.startdatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdatetxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startdatetxt.Location = new System.Drawing.Point(113, 433);
            this.startdatetxt.Name = "startdatetxt";
            this.startdatetxt.Size = new System.Drawing.Size(184, 22);
            this.startdatetxt.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "end date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "start date";
            // 
            // salesorderreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 583);
            this.ControlBox = false;
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.enddatetxt);
            this.Controls.Add(this.startdatetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "salesorderreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "salesorderreport";
            this.Load += new System.EventHandler(this.salesorderreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.DateTimePicker enddatetxt;
        private System.Windows.Forms.DateTimePicker startdatetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}