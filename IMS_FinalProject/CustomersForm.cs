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
    public partial class CustomersForm : Form
    {
        Connection Koneksi = new Connection();
        
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        
        void showdata()
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT * FROM CUSTOMER", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "CUSTOMER");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CUSTOMER";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Refresh();
        }
        

        void InitialCondition()
        {
            custid.Text = "";
            custname.Text = "";
            custphonenum.Text = "";
            custaddress.Text = "";
            email.Text = "";
            showdata();
        }

        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            InitialCondition();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                custid.Text = row.Cells["Customer_id"].Value.ToString();
                custname.Text = row.Cells["full_name"].Value.ToString();
                custaddress.Text = row.Cells["address"].Value.ToString();
                custphonenum.Text = row.Cells["phone_number"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
            }
            catch
            {

            }
        }

        //ADD DATA

        private void button1_Click(object sender, EventArgs e)
        {
            if (custid.Text.Trim() == "" || custname.Text.Trim() == "" || custaddress.Text.Trim() == "" || custphonenum.Text.Trim() == "")
            {
                MessageBox.Show("Make sure all required data is filled");
            }
            else
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand("INSERT INTO CUSTOMER  VALUES ('" + custid.Text + "','" + custname.Text + "','" + custphonenum.Text + "','" + custaddress.Text + "','" + email.Text + "')", Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Succesfully Added");
                    InitialCondition();
                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }

            }
        }
        
        //UPDATE DATA

        private void button2_Click(object sender, EventArgs e)
        {
            if (custid.Text.Trim() == "" || custname.Text.Trim() == "" || custaddress.Text.Trim() == "" || custphonenum.Text.Trim() == "")
            {
                MessageBox.Show("Make sure all required data is filled");
            }
            else
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand(" UPDATE CUSTOMER set full_name= '" + custname.Text + "', phone_number= '" + custphonenum.Text + "', address= '" + custaddress.Text + "' where Customer_id='" + custid.Text + "'", Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Succesfully Updated");
                    InitialCondition();
                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (custid.Text.Trim() == "" || custname.Text.Trim() == "" || custaddress.Text.Trim() == "" || custphonenum.Text.Trim() == "")
            {
                MessageBox.Show("Make sure all required data is filled");
            }
            else
            {
                if (MessageBox.Show("Do you want to Delete this row data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection Conn = Koneksi.GetConnection();
                        Conn.Open();
                        cmd = new SqlCommand(" DELETE CUSTOMER WHERE Customer_id= '" + custid.Text + "'", Conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Succesfully Deleted");
                        InitialCondition();
                    }
                    catch (Exception G)
                    {
                        MessageBox.Show(G.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Action Canceled.", "Info", MessageBoxButtons.OK);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardmenu = new DashboardForm();
            dashboardmenu.Show();
            this.Hide();
        }

        // SEARCH FUNCTION

        private void button7_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "")
            {
                MessageBox.Show("Please enter Customer Name");
            }
            else
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand(" SELECT * FROM CUSTOMER WHERE full_name like '%" + searchbox.Text + "%' or customer_id like '%" + searchbox.Text + "%' or phone_number like '%" + searchbox.Text + "%' or address like'%" + searchbox.Text + "%' or email like '%" + searchbox.Text + "%' ", Conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "CUSTOMER");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "CUSTOMER";
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.Refresh();
                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }
            }
        }

        //PRINT DATA

        private void printbutton_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer List";
            printer.SubTitle = string.Format("Customers", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = true;
            printer.PorportionalColumns = true;
            printer.Footer = "List of Customers";
            printer.FooterSpacing = 20;
            printer.PrintPreviewDataGridView(dataGridView1);
        }
    }
}
