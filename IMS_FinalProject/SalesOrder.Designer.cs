
namespace IMS_FinalProject
{
    partial class SalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesOrder));
            this.subtotaltxt = new System.Windows.Forms.TextBox();
            this.Qtytxt = new System.Windows.Forms.TextBox();
            this.searchprobtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.customernametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salesorderidtxt = new System.Windows.Forms.TextBox();
            this.So_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.customeridtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.searcbox = new System.Windows.Forms.TextBox();
            this.CustomerGV = new System.Windows.Forms.DataGridView();
            this.insertproductbtn = new System.Windows.Forms.Button();
            this.searchsupplier = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.grandtotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.productidtxt = new System.Windows.Forms.TextBox();
            this.closepbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemtotal = new System.Windows.Forms.TextBox();
            this.findPObtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.salesdetailGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesdetailGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subtotaltxt
            // 
            this.subtotaltxt.Location = new System.Drawing.Point(126, 107);
            this.subtotaltxt.Name = "subtotaltxt";
            this.subtotaltxt.ReadOnly = true;
            this.subtotaltxt.Size = new System.Drawing.Size(205, 22);
            this.subtotaltxt.TabIndex = 45;
            // 
            // Qtytxt
            // 
            this.Qtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qtytxt.Location = new System.Drawing.Point(126, 79);
            this.Qtytxt.Name = "Qtytxt";
            this.Qtytxt.Size = new System.Drawing.Size(205, 22);
            this.Qtytxt.TabIndex = 37;
            this.Qtytxt.Leave += new System.EventHandler(this.Qtytxt_Leave_1);
            // 
            // searchprobtn
            // 
            this.searchprobtn.Location = new System.Drawing.Point(862, 281);
            this.searchprobtn.Name = "searchprobtn";
            this.searchprobtn.Size = new System.Drawing.Size(81, 28);
            this.searchprobtn.TabIndex = 47;
            this.searchprobtn.Text = "searchP";
            this.searchprobtn.UseVisualStyleBackColor = true;
            this.searchprobtn.Click += new System.EventHandler(this.searchprobtn_Click);
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
            // customernametxt
            // 
            this.customernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customernametxt.Location = new System.Drawing.Point(135, 78);
            this.customernametxt.Name = "customernametxt";
            this.customernametxt.Size = new System.Drawing.Size(216, 22);
            this.customernametxt.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Customer Name";
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
            this.label1.Text = "SO ID";
            // 
            // salesorderidtxt
            // 
            this.salesorderidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesorderidtxt.Location = new System.Drawing.Point(135, 22);
            this.salesorderidtxt.Name = "salesorderidtxt";
            this.salesorderidtxt.Size = new System.Drawing.Size(148, 22);
            this.salesorderidtxt.TabIndex = 42;
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
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Customer Id";
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
            // customeridtxt
            // 
            this.customeridtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customeridtxt.Location = new System.Drawing.Point(135, 50);
            this.customeridtxt.Name = "customeridtxt";
            this.customeridtxt.Size = new System.Drawing.Size(216, 22);
            this.customeridtxt.TabIndex = 45;
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
            this.ProductGV.Location = new System.Drawing.Point(675, 9);
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.RowHeadersWidth = 51;
            this.ProductGV.RowTemplate.Height = 24;
            this.ProductGV.Size = new System.Drawing.Size(415, 269);
            this.ProductGV.TabIndex = 45;
            this.ProductGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGV_CellClick_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(675, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 36);
            this.button3.TabIndex = 51;
            this.button3.Text = "Product Reference";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(675, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 36);
            this.button5.TabIndex = 50;
            this.button5.Text = "Customer Reference";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // searcbox
            // 
            this.searcbox.Location = new System.Drawing.Point(675, 284);
            this.searcbox.Name = "searcbox";
            this.searcbox.Size = new System.Drawing.Size(181, 22);
            this.searcbox.TabIndex = 46;
            // 
            // CustomerGV
            // 
            this.CustomerGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.CustomerGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGV.Location = new System.Drawing.Point(675, 9);
            this.CustomerGV.Name = "CustomerGV";
            this.CustomerGV.RowHeadersWidth = 51;
            this.CustomerGV.RowTemplate.Height = 24;
            this.CustomerGV.Size = new System.Drawing.Size(415, 269);
            this.CustomerGV.TabIndex = 49;
            this.CustomerGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGV_CellClick);
            // 
            // insertproductbtn
            // 
            this.insertproductbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.insertproductbtn.Location = new System.Drawing.Point(378, 81);
            this.insertproductbtn.Name = "insertproductbtn";
            this.insertproductbtn.Size = new System.Drawing.Size(93, 49);
            this.insertproductbtn.TabIndex = 29;
            this.insertproductbtn.Text = "Insert";
            this.insertproductbtn.UseVisualStyleBackColor = false;
            this.insertproductbtn.Click += new System.EventHandler(this.insertproductbtn_Click);
            // 
            // searchsupplier
            // 
            this.searchsupplier.Location = new System.Drawing.Point(862, 281);
            this.searchsupplier.Name = "searchsupplier";
            this.searchsupplier.Size = new System.Drawing.Size(75, 28);
            this.searchsupplier.TabIndex = 52;
            this.searchsupplier.Text = "searchC";
            this.searchsupplier.UseVisualStyleBackColor = true;
            this.searchsupplier.Click += new System.EventHandler(this.searchsupplier_Click);
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
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Window;
            this.button12.Location = new System.Drawing.Point(12, 618);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(112, 45);
            this.button12.TabIndex = 40;
            this.button12.Text = "Exit";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
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
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click_1);
            // 
            // grandtotal
            // 
            this.grandtotal.Location = new System.Drawing.Point(458, 78);
            this.grandtotal.Name = "grandtotal";
            this.grandtotal.ReadOnly = true;
            this.grandtotal.Size = new System.Drawing.Size(184, 22);
            this.grandtotal.TabIndex = 58;
            this.grandtotal.Click += new System.EventHandler(this.grandtotal_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subtotaltxt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.insertproductbtn);
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
            this.pricetxt.Leave += new System.EventHandler(this.pricetxt_Leave_1);
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
            // closepbtn
            // 
            this.closepbtn.Location = new System.Drawing.Point(995, 279);
            this.closepbtn.Name = "closepbtn";
            this.closepbtn.Size = new System.Drawing.Size(95, 33);
            this.closepbtn.TabIndex = 48;
            this.closepbtn.Text = "Close";
            this.closepbtn.UseVisualStyleBackColor = true;
            this.closepbtn.Click += new System.EventHandler(this.closepbtn_Click_1);
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
            this.panel2.Controls.Add(this.customernametxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.salesorderidtxt);
            this.panel2.Controls.Add(this.So_date);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.customeridtxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 305);
            this.panel2.TabIndex = 44;
            // 
            // itemtotal
            // 
            this.itemtotal.Location = new System.Drawing.Point(459, 50);
            this.itemtotal.Name = "itemtotal";
            this.itemtotal.ReadOnly = true;
            this.itemtotal.Size = new System.Drawing.Size(184, 22);
            this.itemtotal.TabIndex = 46;
            this.itemtotal.Click += new System.EventHandler(this.itemtotal_Click_1);
            this.itemtotal.Leave += new System.EventHandler(this.itemtotal_Leave);
            // 
            // findPObtn
            // 
            this.findPObtn.Location = new System.Drawing.Point(289, 22);
            this.findPObtn.Name = "findPObtn";
            this.findPObtn.Size = new System.Drawing.Size(62, 23);
            this.findPObtn.TabIndex = 56;
            this.findPObtn.Text = "Find";
            this.findPObtn.UseVisualStyleBackColor = true;
            this.findPObtn.Click += new System.EventHandler(this.findPObtn_Click_1);
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
            // salesdetailGV
            // 
            this.salesdetailGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.salesdetailGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesdetailGV.Location = new System.Drawing.Point(12, 320);
            this.salesdetailGV.Name = "salesdetailGV";
            this.salesdetailGV.RowHeadersWidth = 51;
            this.salesdetailGV.RowTemplate.Height = 24;
            this.salesdetailGV.Size = new System.Drawing.Size(1078, 213);
            this.salesdetailGV.TabIndex = 43;
            this.salesdetailGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesdetailGV_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Location = new System.Drawing.Point(12, 539);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 73);
            this.panel1.TabIndex = 42;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(974, 503);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(88, 30);
            this.button13.TabIndex = 41;
            this.button13.Text = "Print";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 673);
            this.ControlBox = false;
            this.Controls.Add(this.searchprobtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.searcbox);
            this.Controls.Add(this.searchsupplier);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.closepbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.salesdetailGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.ProductGV);
            this.Controls.Add(this.CustomerGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SalesOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Order";
            this.Load += new System.EventHandler(this.SalesOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesdetailGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subtotaltxt;
        private System.Windows.Forms.TextBox Qtytxt;
        private System.Windows.Forms.Button searchprobtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox customernametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salesorderidtxt;
        private System.Windows.Forms.DateTimePicker So_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox customeridtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProductGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox searcbox;
        private System.Windows.Forms.DataGridView CustomerGV;
        private System.Windows.Forms.Button insertproductbtn;
        private System.Windows.Forms.Button searchsupplier;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox grandtotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox productidtxt;
        private System.Windows.Forms.Button closepbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox itemtotal;
        private System.Windows.Forms.Button findPObtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView salesdetailGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button13;
    }
}