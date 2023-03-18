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

namespace IMS_FinalProject
{
    public partial class DashboardForm : Form
    {

        public DashboardForm()
        {
            InitializeComponent();
        }

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        Connection Konn = new Connection();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if(Connection.type == "A")
            {
                adm_btn.Enabled = false;
            }
            else if(Connection.type == "B")
            {
                adm_btn.Enabled = true;
            }

            STLabel3.Text = "Date : " + DateTime.Now.ToLongDateString();
            STLabel4.Text = "Time : " + DateTime.Now.ToLongTimeString();
        }

        private void product_btn_Click(object sender, EventArgs e)
        {
            ProductsForm Productmenu = new ProductsForm();
            Productmenu.Show();
            this.Hide();
        }

        private void cust_btn_Click(object sender, EventArgs e)
        {
            CustomersForm CustMenu = new CustomersForm();
            CustMenu.Show();
            this.Hide();
        }

        private void adm_btn_Click(object sender, EventArgs e)
        {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 loginpage = new Form1();
            loginpage.Show();
            this.Hide();
        }

        private void SO_btn_Click(object sender, EventArgs e)
        {
            SalesOrder Salesorderform = new SalesOrder();
            Salesorderform.Show();
            this.Hide();
        }

        private void PO_btn_Click(object sender, EventArgs e)
        {
            PurchaseOrder Purchaseorderform = new PurchaseOrder();
            Purchaseorderform.Show();
            this.Hide();
        }

        private void supplier_btn_Click(object sender, EventArgs e)
        {
            Supplier Supplierform = new Supplier();
            Supplierform.Show();
            this.Hide();
        }

        private void salesordereport_Click(object sender, EventArgs e)
        {
            salesorderreport salesreport = new salesorderreport();
            salesreport.Show();
            this.Hide();
        }

        private void purchasereport_Click(object sender, EventArgs e)
        {
            purchaseorderreport purchasereport = new purchaseorderreport();
            purchasereport.Show();
            this.Hide();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
