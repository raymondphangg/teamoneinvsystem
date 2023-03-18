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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        Connection Koneksi = new Connection();

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        void InitialCondition()
        {
            supplieridtxt.Text = "";
            suppliernametxt.Text = "";
            supphonenum.Text = "";
            addresstxt.Text = "";
            emailtxt.Text = "";
            faxtxt.Text = "";
            showdata();
        }

        void showdata()
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT * FROM SUPPLIER", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "SUPPLIER");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SUPPLIER";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardmenu = new DashboardForm();
            dashboardmenu.Show();
            this.Hide();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            InitialCondition();
        }


        // ADD BUTTTON

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (supplieridtxt.Text == "" || suppliernametxt.Text == "" || addresstxt.Text == "" || supphonenum.Text == "")
            {
                MessageBox.Show("Make sure all required data is filled");
            }
            else
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand("INSERT INTO SUPPLIER  VALUES ('" + supplieridtxt.Text + "','" + suppliernametxt.Text + "','" + addresstxt.Text + "','" + supphonenum.Text + "','" + emailtxt.Text + "','" + faxtxt.Text + "')", Conn);
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


        // UPDATE BUTTON

        private void button2_Click(object sender, EventArgs e)
        {
            if (supplieridtxt.Text.Trim() == "" || suppliernametxt.Text.Trim() == "" || addresstxt.Text.Trim() == "" || supphonenum.Text.Trim() == "")
            {
                MessageBox.Show("Make sure all required data is filled");
            }
            else
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand(" UPDATE SUPPLIER set supplier_name= '" + suppliernametxt.Text + "', address= '" + addresstxt.Text + "', phone_number= '" + supphonenum.Text + "' where supplier_id='" + supplieridtxt.Text + "'", Conn);
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

        // DELETE BUTTON

        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (supplieridtxt.Text.Trim() == "" || suppliernametxt.Text.Trim() == "" || addresstxt.Text.Trim() == "" || supphonenum.Text.Trim() == "")
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
                        cmd = new SqlCommand(" DELETE SUPPLIER WHERE supplier_id= '" + supplieridtxt.Text + "'", Conn);
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

        // CHOOSE DATA

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                supplieridtxt.Text = row.Cells["supplier_id"].Value.ToString();
                suppliernametxt.Text = row.Cells["supplier_name"].Value.ToString();
                addresstxt.Text = row.Cells["address"].Value.ToString();
                supphonenum.Text = row.Cells["phone_number"].Value.ToString();
                emailtxt.Text = row.Cells["email"].Value.ToString();
                faxtxt.Text = row.Cells["fax"].Value.ToString();
            }
            catch
            {

            }
        }

        //BACK TO DASHBOARD BUTTON

        private void button7_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }

        //PRINT DATA

        private void printbtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Supplier List";
            printer.SubTitle = string.Format("Supplier", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = true;
            printer.PorportionalColumns = true;
            printer.Footer = "List of Suppliers";
            printer.FooterSpacing = 20;
            printer.PrintPreviewDataGridView(dataGridView1);
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "")
            {
                MessageBox.Show("Please enter search Value");
            }
            else
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand(" SELECT * FROM SUPPLIER WHERE supplier_id like '%" + searchbox.Text + "%' or supplier_name like '%" + searchbox.Text + "%' ", Conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "SUPPLIER");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "SUPPLIER";
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
    }
}

