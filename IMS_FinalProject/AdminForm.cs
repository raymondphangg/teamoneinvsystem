using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IMS_FinalProject
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        //DATABASE CONNECTION

        Connection Koneksi = new Connection();

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        void InitialCondition()
        {
            adminidTxt.Text = "";
            AdminNametxt.Text = "";
            Phonenumtxt.Text = "";
            emailtxt.Text = "";
            passtxt.Text = "";
            rolecombo.Text = "";
            passtxt.MaxLength = 8;
            showdata();
        }

        void showdata()
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT admin_id, full_name, phone_number, email, role, password FROM ADMIN", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ADMIN");
            AdminGV.DataSource = ds;
            AdminGV.DataMember = "ADMIN";
            AdminGV.AllowUserToAddRows = false;
            AdminGV.ReadOnly = true;
            AdminGV.Refresh();
        }

        private void AdminForm_Load_1(object sender, EventArgs e)
        {
            InitialCondition();
        }

        //TO CHOOSE DATA

        private void AdminGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.AdminGV.Rows[e.RowIndex];
                adminidTxt.Text = row.Cells["Admin_id"].Value.ToString();
                AdminNametxt.Text = row.Cells["full_name"].Value.ToString();
                Phonenumtxt.Text = row.Cells["phone_number"].Value.ToString();
                passtxt.Text = row.Cells["password"].Value.ToString();
                emailtxt.Text = row.Cells["email"].Value.ToString();
                rolecombo.Text = row.Cells["role"].Value.ToString();
            }
            catch
            {

            }
        }

        //SEARCH FUNCTION
        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the search value");
            }
            else
            {
                SqlConnection Conn = Koneksi.GetConnection();
                Conn.Open();
                cmd = new SqlCommand(" SELECT * FROM ADMIN WHERE full_name='" + textBox1.Text + "'  ", Conn);
                cmd.ExecuteNonQuery();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    adminidTxt.Text = rd[0].ToString();
                    AdminNametxt.Text = rd[1].ToString();
                    Phonenumtxt.Text = rd[2].ToString();
                    passtxt.Text = rd[3].ToString();
                    emailtxt.Text = rd[4].ToString();
                    rolecombo.Text = rd[5].ToString();
                }
                else
                {
                    MessageBox.Show("No result");
                }
            }
        }


        //ADD DATA COMMAND
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (adminidTxt.Text == "" || AdminNametxt.Text == "" || passtxt.Text == "" || Phonenumtxt.Text == "")
            {
                MessageBox.Show("Make sure all required data is filled");
            }
            else
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand("INSERT INTO ADMIN VALUES ('" + adminidTxt.Text + "','" + AdminNametxt.Text + "','" + Phonenumtxt.Text + "','" + passtxt.Text + "','" + emailtxt.Text + "','" + rolecombo.Text + "')", Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Succesfully Added");
                    InitialCondition();
                }
                catch
                {

                }
            }
        }

        //UPDATE DATA COMMAND
        private void button1_Click(object sender, EventArgs e)
        {
            if (adminidTxt.Text.Trim() == "" || AdminNametxt.Text.Trim() == "" || passtxt.Text.Trim() == "")
            {
                MessageBox.Show("Make sure all required data is filled");
            }
            else
            {
                SqlConnection Conn = Koneksi.GetConnection();
                Conn.Open();
                cmd = new SqlCommand(" UPDATE ADMIN set full_name= '" + AdminNametxt.Text + "', phone_number= '" + Phonenumtxt.Text + "', password= '" + passtxt.Text + "', email= '" + emailtxt.Text + "', role= '" + rolecombo.Text + "' where Admin_id='" + adminidTxt.Text + "'", Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Succesfully Updated");
                InitialCondition();

            }
        }

        // DELETE DATA COMMAND
        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (adminidTxt.Text.Trim() == "" || AdminNametxt.Text.Trim() == "" || passtxt.Text.Trim() == "")
            {
                MessageBox.Show("Make sure all required data is filled");
            }
            else
            {
                if (MessageBox.Show("Do you want to Delete this row data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand(" DELETE ADMIN WHERE Admin_id= '" + adminidTxt.Text + "'", Conn);
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

        //BACK TO DASHBOARD SCRIPT
        private void button4_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardmenu = new DashboardForm();
            dashboardmenu.Show();
            this.Hide();
        }
    }
}
 
