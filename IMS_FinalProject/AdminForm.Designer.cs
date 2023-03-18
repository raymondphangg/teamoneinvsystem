
namespace IMS_FinalProject
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.adminidTxt = new System.Windows.Forms.TextBox();
            this.AdminNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Phonenumtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AdminGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Delbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rolecombo = new System.Windows.Forms.ComboBox();
            this.role = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdminGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin ID";
            // 
            // adminidTxt
            // 
            this.adminidTxt.Location = new System.Drawing.Point(29, 43);
            this.adminidTxt.Name = "adminidTxt";
            this.adminidTxt.Size = new System.Drawing.Size(253, 22);
            this.adminidTxt.TabIndex = 1;
            // 
            // AdminNametxt
            // 
            this.AdminNametxt.Location = new System.Drawing.Point(29, 100);
            this.AdminNametxt.Name = "AdminNametxt";
            this.AdminNametxt.Size = new System.Drawing.Size(253, 22);
            this.AdminNametxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name";
            // 
            // Phonenumtxt
            // 
            this.Phonenumtxt.Location = new System.Drawing.Point(29, 149);
            this.Phonenumtxt.Name = "Phonenumtxt";
            this.Phonenumtxt.Size = new System.Drawing.Size(253, 22);
            this.Phonenumtxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(29, 205);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(253, 22);
            this.passtxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(26, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Addbtn.Location = new System.Drawing.Point(9, 452);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(100, 50);
            this.Addbtn.TabIndex = 8;
            this.Addbtn.Text = "Add New";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(12, 626);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "Dashboard";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdminGV
            // 
            this.AdminGV.AllowUserToResizeColumns = false;
            this.AdminGV.AllowUserToResizeRows = false;
            this.AdminGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.AdminGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminGV.Location = new System.Drawing.Point(359, 79);
            this.AdminGV.Name = "AdminGV";
            this.AdminGV.RowHeadersWidth = 51;
            this.AdminGV.RowTemplate.Height = 24;
            this.AdminGV.Size = new System.Drawing.Size(731, 517);
            this.AdminGV.TabIndex = 13;
            this.AdminGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminGV_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(115, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delbtn
            // 
            this.Delbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Delbtn.Location = new System.Drawing.Point(219, 452);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(96, 50);
            this.Delbtn.TabIndex = 15;
            this.Delbtn.Text = "Delete";
            this.Delbtn.UseVisualStyleBackColor = false;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Location = new System.Drawing.Point(1014, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 31);
            this.button3.TabIndex = 18;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rolecombo
            // 
            this.rolecombo.FormattingEnabled = true;
            this.rolecombo.Items.AddRange(new object[] {
            "Manager",
            "Administrator Staff"});
            this.rolecombo.Location = new System.Drawing.Point(29, 325);
            this.rolecombo.Name = "rolecombo";
            this.rolecombo.Size = new System.Drawing.Size(253, 24);
            this.rolecombo.TabIndex = 6;
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.role.Location = new System.Drawing.Point(26, 305);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(37, 17);
            this.role.TabIndex = 10;
            this.role.Text = "Role";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(29, 261);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(253, 22);
            this.emailtxt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(26, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "email";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Addbtn);
            this.panel2.Controls.Add(this.adminidTxt);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Delbtn);
            this.panel2.Controls.Add(this.rolecombo);
            this.panel2.Controls.Add(this.AdminNametxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.role);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.emailtxt);
            this.panel2.Controls.Add(this.Phonenumtxt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.passtxt);
            this.panel2.Location = new System.Drawing.Point(33, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 517);
            this.panel2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 46);
            this.label5.TabIndex = 12;
            this.label5.Text = "Manage Admins";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(755, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 22);
            this.textBox1.TabIndex = 19;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1102, 673);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AdminGV);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Manager";
            this.Load += new System.EventHandler(this.AdminForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.AdminGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminidTxt;
        private System.Windows.Forms.TextBox AdminNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Phonenumtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView AdminGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.ComboBox rolecombo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}