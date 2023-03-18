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
    public partial class salesorderreport : Form
    {
        public salesorderreport()
        {
            InitializeComponent();
        }

        Connection Koneksi = new Connection();

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        private void salesorderreport_Load(object sender, EventArgs e)
        {
            salesordershow();
        }

        void salesordershow()
        {
            try
            {
                SqlConnection Conn = Koneksi.GetConnection();
                Conn.Open();
                cmd = new SqlCommand("SELECT SalesOrder_id, date, total_item, total_sales, customerid, full_name FROM SALES_ORDER, CUSTOMER WHERE customerid = customer_id", Conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "SALES_ORDER");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "SALES_ORDER";
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Refresh();
            }
            catch(Exception G)
            {
                MessageBox.Show(G.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardmenu = new DashboardForm();
            dashboardmenu.Show();
            this.Hide();
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
            cmd = new SqlCommand("SELECT * FROM SALES_ORDER WHERE date BETWEEN '" + startdatetxt.Text + "' AND '" + enddatetxt.Text + "'", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "SALES_ORDER");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SALES_ORDER";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Refresh();
        }
    }
}
