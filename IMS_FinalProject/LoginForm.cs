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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passtxt.PasswordChar = '*';
            passtxt.MaxLength = 8;
        }


        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        Connection Konn = new Connection();

        public void LoginBtn_Click(object sender, EventArgs e)
        {

            if (usertxt.Text.Trim() == "" || passtxt.Text.Trim() == "")
            {
                MessageBox.Show("Please fill your username and password");
            }
            else
            {
                SqlDataReader reader = null;
                SqlConnection Conn = Konn.GetConnection();

                Conn.Open();
                cmd = new SqlCommand("SELECT * FROM ADMIN WHERE Admin_id='" + usertxt.Text + "' AND password='" + passtxt.Text + "'", Conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if(reader[5].ToString()=="Administrator Staff")
                    {
                        Connection.type = "A";
                    }
                    else if (reader[5].ToString() == "Manager")
                    {
                        Connection.type = "B";
                    }

                    DashboardForm tampilandash = new DashboardForm();
                    tampilandash.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password Incorrect");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}