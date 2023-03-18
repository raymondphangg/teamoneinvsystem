
namespace IMS_FinalProject
{
    partial class PurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrder));
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updatebtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.purchasedetailGV = new System.Windows.Forms.DataGridView();
            this.closepbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grandtotal = new System.Windows.Forms.TextBox();
            this.itemtotal = new System.Windows.Forms.TextBox();
            this.findPObtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subtotaltxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Qtytxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.productidtxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.suppliernametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseorderidtxt = new System.Windows.Forms.TextBox();
            this.So_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.supplieridtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductGV = new System.Windows.Forms.DataGridView();
            this.SupplierGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.searcbox = new System.Windows.Forms.TextBox();
            this.searchprobtn = new System.Windows.Forms.Button();
            this.searchsupplier = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedetailGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Window;
            this.button12.Location = new System.Drawing.Point(12, 621);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(112, 45);
            this.button12.TabIndex = 25;
            this.button12.Text = "Exit";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(974, 506);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(88, 30);
            this.button13.TabIndex = 26;
            this.button13.Text = "Print";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Location = new System.Drawing.Point(12, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 73);
            this.panel1.TabIndex = 28;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.updatebtn.Location = new System.Drawing.Point(137, 12);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(122, 50);
            this.updatebtn.TabIndex = 45;
            this.updatebtn.Text = "Update Order";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(265, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 50);
            this.button4.TabIndex = 44;
            this.button4.Text = "Delete Order";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(831, 12);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(39, 17);
            this.time.TabIndex = 43;
            this.time.Text = "Time";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(831, 45);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(36, 17);
            this.date.TabIndex = 42;
            this.date.Text = "date";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addbtn.Location = new System.Drawing.Point(9, 12);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(122, 50);
            this.addbtn.TabIndex = 40;
            this.addbtn.Text = "New Order";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(477, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 50);
            this.button1.TabIndex = 44;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // purchasedetailGV
            // 
            this.purchasedetailGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.purchasedetailGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasedetailGV.Location = new System.Drawing.Point(12, 323);
            this.purchasedetailGV.Name = "purchasedetailGV";
            this.purchasedetailGV.RowHeadersWidth = 51;
            this.purchasedetailGV.RowTemplate.Height = 24;
            this.purchasedetailGV.Size = new System.Drawing.Size(1078, 213);
            this.purchasedetailGV.TabIndex = 29;
            this.purchasedetailGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchasedetailGV_CellClick);
            // 
            // closepbtn
            // 
            this.closepbtn.Location = new System.Drawing.Point(995, 282);
            this.closepbtn.Name = "closepbtn";
            this.closepbtn.Size = new System.Drawing.Size(95, 33);
            this.closepbtn.TabIndex = 35;
            this.closepbtn.Text = "Close";
            this.closepbtn.UseVisualStyleBackColor = true;
            this.closepbtn.Click += new System.EventHandler(this.closepbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.grandtotal);
            this.panel2.Controls.Add(this.itemtotal);
            this.panel2.Controls.Add(this.findPObtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.suppliernametxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.purchaseorderidtxt);
            this.panel2.Controls.Add(this.So_date);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.supplieridtxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 305);
            this.panel2.TabIndex = 30;
            // 
            // grandtotal
            // 
            this.grandtotal.Location = new System.Drawing.Point(458, 78);
            this.grandtotal.Name = "grandtotal";
            this.grandtotal.ReadOnly = true;
            this.grandtotal.Size = new System.Drawing.Size(184, 22);
            this.grandtotal.TabIndex = 58;
            this.grandtotal.Click += new System.EventHandler(this.grandtotal_Click);
            // 
            // itemtotal
            // 
            this.itemtotal.Location = new System.Drawing.Point(459, 50);
            this.itemtotal.Name = "itemtotal";
            this.itemtotal.ReadOnly = true;
            this.itemtotal.Size = new System.Drawing.Size(184, 22);
            this.itemtotal.TabIndex = 46;
            this.itemtotal.Click += new System.EventHandler(this.itemtotal_Click);
            // 
            // findPObtn
            // 
            this.findPObtn.Location = new System.Drawing.Point(275, 22);
            this.findPObtn.Name = "findPObtn";
            this.findPObtn.Size = new System.Drawing.Size(65, 23);
            this.findPObtn.TabIndex = 56;
            this.findPObtn.Text = "Find";
            this.findPObtn.UseVisualStyleBackColor = true;
            this.findPObtn.Click += new System.EventHandler(this.findPObtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Grand Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subtotaltxt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Qtytxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pricetxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.productidtxt);
            this.groupBox1.Location = new System.Drawing.Point(9, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 144);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product information";
            // 
            // subtotaltxt
            // 
            this.subtotaltxt.Location = new System.Drawing.Point(126, 107);
            this.subtotaltxt.Name = "subtotaltxt";
            this.subtotaltxt.ReadOnly = true;
            this.subtotaltxt.Size = new System.Drawing.Size(205, 22);
            this.subtotaltxt.TabIndex = 45;
            this.subtotaltxt.Click += new System.EventHandler(this.subtotaltxt_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(378, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 49);
            this.button2.TabIndex = 29;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Qtytxt
            // 
            this.Qtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qtytxt.Location = new System.Drawing.Point(126, 79);
            this.Qtytxt.Name = "Qtytxt";
            this.Qtytxt.Size = new System.Drawing.Size(205, 22);
            this.Qtytxt.TabIndex = 37;
            this.Qtytxt.Leave += new System.EventHandler(this.Qtytxt_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(11, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(11, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Subtotal";
            // 
            // pricetxt
            // 
            this.pricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(126, 51);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(205, 22);
            this.pricetxt.TabIndex = 35;
            this.pricetxt.Leave += new System.EventHandler(this.pricetxt_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(11, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Qty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(11, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Product Id";
            // 
            // productidtxt
            // 
            this.productidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productidtxt.Location = new System.Drawing.Point(126, 23);
            this.productidtxt.Name = "productidtxt";
            this.productidtxt.Size = new System.Drawing.Size(205, 22);
            this.productidtxt.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(357, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 57;
            this.label12.Text = "Total Item";
            // 
            // suppliernametxt
            // 
            this.suppliernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliernametxt.Location = new System.Drawing.Point(135, 78);
            this.suppliernametxt.Name = "suppliernametxt";
            this.suppliernametxt.Size = new System.Drawing.Size(205, 22);
            this.suppliernametxt.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Supplier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "PO ID";
            // 
            // purchaseorderidtxt
            // 
            this.purchaseorderidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseorderidtxt.Location = new System.Drawing.Point(135, 22);
            this.purchaseorderidtxt.Name = "purchaseorderidtxt";
            this.purchaseorderidtxt.Size = new System.Drawing.Size(134, 22);
            this.purchaseorderidtxt.TabIndex = 42;
            // 
            // So_date
            // 
            this.So_date.CustomFormat = "yyyy-MM-dd";
            this.So_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.So_date.Location = new System.Drawing.Point(459, 22);
            this.So_date.Name = "So_date";
            this.So_date.Size = new System.Drawing.Size(184, 22);
            this.So_date.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Supplier Id";
            // 
            // supplieridtxt
            // 
            this.supplieridtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplieridtxt.Location = new System.Drawing.Point(135, 50);
            this.supplieridtxt.Name = "supplieridtxt";
            this.supplieridtxt.Size = new System.Drawing.Size(205, 22);
            this.supplieridtxt.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(357, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Date";
            // 
            // ProductGV
            // 
            this.ProductGV.AllowUserToAddRows = false;
            this.ProductGV.AllowUserToDeleteRows = false;
            this.ProductGV.AllowUserToResizeColumns = false;
            this.ProductGV.AllowUserToResizeRows = false;
            this.ProductGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProductGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGV.Location = new System.Drawing.Point(675, 12);
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.RowHeadersWidth = 51;
            this.ProductGV.RowTemplate.Height = 24;
            this.ProductGV.Size = new System.Drawing.Size(415, 269);
            this.ProductGV.TabIndex = 31;
            this.ProductGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGV_CellClick);
            // 
            // SupplierGV
            // 
            this.SupplierGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.SupplierGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierGV.Location = new System.Drawing.Point(675, 12);
            this.SupplierGV.Name = "SupplierGV";
            this.SupplierGV.RowHeadersWidth = 51;
            this.SupplierGV.RowTemplate.Height = 24;
            this.SupplierGV.Size = new System.Drawing.Size(415, 269);
            this.SupplierGV.TabIndex = 36;
            this.SupplierGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierGV_CellClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(675, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 36);
            this.button3.TabIndex = 38;
            this.button3.Text = "Product Reference";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(675, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 36);
            this.button5.TabIndex = 37;
            this.button5.Text = "Supplier Reference";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // searcbox
            // 
            this.searcbox.Location = new System.Drawing.Point(675, 287);
            this.searcbox.Name = "searcbox";
            this.searcbox.Size = new System.Drawing.Size(181, 22);
            this.searcbox.TabIndex = 32;
            // 
            // searchprobtn
            // 
            this.searchprobtn.Location = new System.Drawing.Point(862, 284);
            this.searchprobtn.Name = "searchprobtn";
            this.searchprobtn.Size = new System.Drawing.Size(75, 28);
            this.searchprobtn.TabIndex = 33;
            this.searchprobtn.Text = "search";
            this.searchprobtn.UseVisualStyleBackColor = true;
            this.searchprobtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchsupplier
            // 
            this.searchsupplier.Location = new System.Drawing.Point(862, 284);
            this.searchsupplier.Name = "searchsupplier";
            this.searchsupplier.Size = new System.Drawing.Size(75, 28);
            this.searchsupplier.TabIndex = 39;
            this.searchsupplier.Text = "search";
            this.searchsupplier.UseVisualStyleBackColor = true;
            this.searchsupplier.Click += new System.EventHandler(this.searchsupplier_Click);
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 673);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.closepbtn);
            this.Controls.Add(this.searcbox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SupplierGV);
            this.Controls.Add(this.purchasedetailGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.searchprobtn);
            this.Controls.Add(this.searchsupplier);
            this.Controls.Add(this.ProductGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrder";
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedetailGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView purchasedetailGV;
        private System.Windows.Forms.Button closepbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Qtytxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox productidtxt;
        private System.Windows.Forms.TextBox suppliernametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox purchaseorderidtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox supplieridtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DataGridView ProductGV;
        private System.Windows.Forms.DataGridView SupplierGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button findPObtn;
        private System.Windows.Forms.TextBox searcbox;
        private System.Windows.Forms.Button searchprobtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker So_date;
        private System.Windows.Forms.Button searchsupplier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox grandtotal;
        private System.Windows.Forms.TextBox itemtotal;
        private System.Windows.Forms.TextBox subtotaltxt;
        private System.Windows.Forms.Button updatebtn;
    }
}