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
    public partial class ProductsForm : Form
    {
        Connection Koneksi = new Connection();

        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataSet ds;
        private SqlDataReader rd; 

        void InitialCondition()
        {
            productid.Text = "";
            pronametxt.Text = "";
            proqtytxt.Text = "";
            pricetxt.Text = "";
            desctxt.Text = "";
            showdata();
        }
        
        void showdata()
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT * FROM PRODUCT", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "PRODUCT");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "PRODUCT";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[4].Width = 125;
            this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Refresh();
        }
        

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            InitialCondition();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (productid.Text == "" || pronametxt.Text == "" || proqtytxt.Text == "" || pricetxt.Text == "" || desctxt.Text == "")
            {
                MessageBox.Show("Make sure all required data is filled");
            }
            else
            {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand("INSERT INTO PRODUCT  VALUES ('" + productid.Text + "','" + proqtytxt.Text + "','" + pronametxt.Text + "','" + pricetxt.Text + "','" + desctxt.Text + "')", Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Succesfully Added");
                    InitialCondition();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (productid.Text.Trim() == "" || pronametxt.Text.Trim() == "" || proqtytxt.Text.Trim() == "" || pricetxt.Text.Trim() == "" || desctxt.Text.Trim() == "")
            {
                MessageBox.Show("Make sure all required data is filled");
            }
            else
            {
                SqlConnection Conn = Koneksi.GetConnection();
                Conn.Open();
                cmd = new SqlCommand("UPDATE PRODUCT set product_id = '"+productid.Text+"', product_qty = '" + proqtytxt.Text + "', product_name = '" + pronametxt.Text + "', price = '" + pricetxt.Text + "', description='" + desctxt.Text +"' where Product_id = '"+ productid.Text + "'", Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Successfully Updated");
                InitialCondition();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (productid.Text == "" || pronametxt.Text == "" || proqtytxt.Text == "" || pricetxt.Text == "" || desctxt.Text == "")
            {
                MessageBox.Show("Make sure all required data is filled");
            }
            else
            {
                if (MessageBox.Show("Do you want to Delete this row data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand("DELETE PRODUCT WHERE Product_id= '" + productid.Text + "'", Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Succesfully Deleted");
                    InitialCondition();
                }
                else
                {
                    MessageBox.Show("Action Canceled.", "Info", MessageBoxButtons.OK);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                productid.Text = row.Cells["Product_id"].Value.ToString();
                proqtytxt.Text = row.Cells["product_qty"].Value.ToString();
                pronametxt.Text = row.Cells["product_name"].Value.ToString();
                pricetxt.Text = row.Cells["price"].Value.ToString();
                desctxt.Text = row.Cells["description"].Value.ToString();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardmenu = new DashboardForm();
            dashboardmenu.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Searchbox_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "")
            {
                MessageBox.Show("Please enter search value");
            }
            else
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand(" SELECT * FROM PRODUCT WHERE product_id like '%" + searchbox.Text + "%' or product_name like '%" + searchbox.Text + "%' or price like '%" + searchbox.Text + "%' ", Conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "PRODUCT");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "PRODUCT";
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.Refresh();
                }
                catch (Exception)
                {

                }

            }
        }
    }
}
