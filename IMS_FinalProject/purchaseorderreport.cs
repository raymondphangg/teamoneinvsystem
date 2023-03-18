using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace IMS_FinalProject
{
    public partial class purchaseorderreport : Form
    {
        public purchaseorderreport()
        {
            InitializeComponent();
        }

        Connection Koneksi = new Connection();

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        void purchaseordershow()
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT PurchaseOrder_id, date, total_item, total_purchase, supplierid, supplier_name FROM PURCHASE_ORDER, SUPPLIER WHERE supplierid = supplier_id", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "PURCHASE_ORDER");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "PURCHASE_ORDER";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardmenu = new DashboardForm();
            dashboardmenu.Show();
            this.Hide();
        }

        private void purchaseorderreport_Load(object sender, EventArgs e)
        {
            purchaseordershow();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Product List";
            printer.SubTitle = string.Format("Products", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = true;
            printer.PorportionalColumns = true;
            printer.Footer = "List of Products";
            printer.FooterSpacing = 20;
            printer.PrintPreviewDataGridView(dataGridView1);
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT * FROM PURCHASE_ORDER WHERE date BETWEEN '" + startdatetxt.Text + "' AND '" + enddatetxt.Text + "'", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "PURCHASE_ORDER");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "PURCHASE_ORDER";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Refresh();
        }

        private void enddatetxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startdatetxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
