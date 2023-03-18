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
    public partial class SalesOrder : Form
    {
        public SalesOrder()
        {
            InitializeComponent();
        }


        private void SalesOrder_Load(object sender, EventArgs e)
        {
            InitialCondition();
        }

        //DATABASE CONNECTION

        Connection Koneksi = new Connection();

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        void InitialCondition()
        {
            customeridtxt.Text = "";
            customernametxt.Text = "";
            productidtxt.Text = "";
            Qtytxt.Text = "";
            pricetxt.Text = "";
            salesorderidtxt.Text = "";
            subtotaltxt.Text = "0";
            grandtotal.Text = "0";
            itemtotal.Text = "0";
            CustomerGV.Hide();
            ProductGV.Hide();
            searcbox.Hide();
            searchprobtn.Hide();
            closepbtn.Hide();
            searchsupplier.Hide();
            button3.Show();
            button5.Show();

            showcustomer();
            showproduct();
            showsalesorderdetail();
        }

        // ---------------------------- SALES FUNCTION -------------------------------- //

        void showsalesorderdetail()
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT productid, product_name, sales_price, salesQty, subtotal FROM SALES_ORDER_DETAIL, PRODUCT WHERE SalesOrder_id ='" + salesorderidtxt.Text + "' AND productid = product_id", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "SALES_ORDER_DETAIL");
            salesdetailGV.DataSource = ds;
            salesdetailGV.DataMember = "SALES_ORDER_DETAIL";
            salesdetailGV.AllowUserToAddRows = false;
            salesdetailGV.ReadOnly = true;
            this.salesdetailGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            salesdetailGV.Refresh();
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }

        void showproduct()
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT product_id, product_name, price FROM PRODUCT", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "PRODUCT");
            ProductGV.DataSource = ds;
            ProductGV.DataMember = "PRODUCT";
            ProductGV.AllowUserToAddRows = false;
            ProductGV.ReadOnly = true;
            ProductGV.Refresh();
        }

        void showcustomer()
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT customer_id, full_name FROM CUSTOMER", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "CUSTOMER");
            CustomerGV.DataSource = ds;
            CustomerGV.DataMember = "CUSTOMER";
            CustomerGV.AllowUserToAddRows = false;
            CustomerGV.ReadOnly = true;
            this.CustomerGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerGV.Refresh();
        }

        void salesorderdata()
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT SalesOrder_id, date, total_item, total_sales, customerid, full_name FROM SALES_ORDER, CUSTOMER where SalesOrder_id= '" + salesorderidtxt.Text + "' AND customer_id = customerid", Conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                addbtn.Enabled = false;
                salesorderidtxt.Text = rd.GetValue(0).ToString();
                customeridtxt.Text = rd.GetValue(4).ToString();
                customernametxt.Text = rd.GetValue(5).ToString();
            }
            else
            {
                addbtn.Enabled = true;
            }

            showsalesorderdetail();
        }

        void grantotalfunction()
        {
            grandtotal.Text = "0";
            for (int i = 0; i < salesdetailGV.Rows.Count; i++)
            {
                grandtotal.Text = Convert.ToString(double.Parse(grandtotal.Text) + double.Parse(salesdetailGV.Rows[i].Cells[4].Value.ToString()));
            }
        }

        void itemtotalfunction()
        {
            itemtotal.Text = "0";
            for (int i = 0; i < salesdetailGV.Rows.Count; i++)
            {
                itemtotal.Text = Convert.ToString(double.Parse(itemtotal.Text) + double.Parse(salesdetailGV.Rows[i].Cells[3].Value.ToString()));
            }
        }

        void subtotalfunction()
        {
            try
            {
                int productprice = Int32.Parse(pricetxt.Text);
                int productqty = Int32.Parse(Qtytxt.Text);

                int totalprice;

                totalprice = productprice * productqty;
                subtotaltxt.Text = totalprice.ToString();
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
        }

        //------------------- END OF SALES FUNCTION ------------------------ // 

        // ------------------------------- DATAGRIDVIEW CELL CLICK ------------------------- //

        private void CustomerGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.CustomerGV.Rows[e.RowIndex];
                customeridtxt.Text = row.Cells["customer_id"].Value.ToString();
                customernametxt.Text = row.Cells["full_name"].Value.ToString();
            }
            catch
            {

            }
        }

        private void salesdetailGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.salesdetailGV.Rows[e.RowIndex];
                productidtxt.Text = row.Cells["productid"].Value.ToString();
                pricetxt.Text = row.Cells["sales_price"].Value.ToString();
                Qtytxt.Text = row.Cells["salesQty"].Value.ToString();
                subtotaltxt.Text = row.Cells["subtotal"].Value.ToString();
            }
            catch
            {

            }
        }

        private void ProductGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.ProductGV.Rows[e.RowIndex];
                productidtxt.Text = row.Cells["Product_id"].Value.ToString();
                pricetxt.Text = row.Cells["price"].Value.ToString();
            }
            catch
            {

            }
        }

        // ---------------------------- END OF DATAGRIDVIEW CELL CLICK ------------------------- //

        // -------------------------------- SALES ORDER DETAIL CRUD ---------------------- //

        // -------------------------- ADD QUERY (DETAIL) -----------------------------------//
        private void insertproductbtn_Click(object sender, EventArgs e)
        {
            if (salesorderidtxt.Text == "" || productidtxt.Text == "" || productidtxt.Text == "" || Qtytxt.Text == "" || subtotaltxt.Text == "")
            {
                MessageBox.Show("Please fill up all the required data");
            }
            else
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand("UPDATE PRODUCT SET product_qty = product_qty - salesQty FROM SALES_ORDER_DETAIL WHERE PRODUCT.product_id ='" + productidtxt.Text + "';" +
                        "INSERT INTO SALES_ORDER_DETAIL VALUES ('" + salesorderidtxt.Text + "','" + productidtxt.Text + "','" + pricetxt.Text + "','" + Qtytxt.Text + "','" + subtotaltxt.Text + "')", Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Succesfully Added");

                    //REFRESH
                    Show();
                    productidtxt.Text = "";
                    Qtytxt.Text = "";
                    pricetxt.Text = "";
                    subtotaltxt.Text = "";

                    grantotalfunction();
                    itemtotalfunction();
                    showsalesorderdetail();
                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }

            }
        }

        // ----------------------------- END OF ADD QUERY (DETAIL) ---------------------------- //

        // ------------------------------- DELETE QUERY (DETAIL) --------------------------------- ///



        // ---------------------------------- END OF DELETE QUERY (DETAIL) -------------------------------- //

        //SALES ORDER CRUD

        // --------------------------------- ADD QUERY ------------------------------------------ //

        private void addbtn_Click_1(object sender, EventArgs e)
        {
            if (salesorderidtxt.Text == "")
            {
                MessageBox.Show("Make sure you have choosed the SalesOrder_id");
            }
            else
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand("INSERT INTO SALES_ORDER VALUES ('" + salesorderidtxt.Text + "','" + So_date.Text + "','" + itemtotal.Text + "','" + grandtotal.Text + "','" + customeridtxt.Text + "')", Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Saved");
                    InitialCondition();
                    grantotalfunction();
                    itemtotalfunction();
                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }

            }
        }

        //UPDATE QUERY
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (salesorderidtxt.Text == "")
            {
                MessageBox.Show("Make sure you have chosen the Sales_id");
            }
            else
            {
                if (MessageBox.Show("Do you want to update this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection Conn = Koneksi.GetConnection();
                        Conn.Open();
                        cmd = new SqlCommand("UPDATE SALES_ORDER SET  date = '" + date.Text + "', total_item= '" + itemtotal.Text + "', customerid ='" + customeridtxt.Text + "' WHERE SalesOrder_id= '" + productidtxt.Text + "'", Conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order Saved");
                        InitialCondition();
                    }
                    catch (Exception G)
                    {
                        MessageBox.Show(G.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Action Canceled");
                }
            }
        }

        //DELETE QUERY
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmation. this action cannot be undone", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand("DELETE SALES_ORDER_DETAIL WHERE salesorder_id = '" + salesorderidtxt.Text + "'" +
                        "DELETE SALES_ORDER WHERE salesorder_id= '" + salesorderidtxt.Text + "'", Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Succesfully Deleted");

                    InitialCondition();
                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }

            }
            else
            {
                MessageBox.Show("Action canceled");
            }
        }

        // REFERENCE TAB BUTTON
        private void button3_Click(object sender, EventArgs e) //PRODUCT
        {

        }

        //SALES ORDER SEARCH

        private void findPObtn_Click_1(object sender, EventArgs e)
        {
            if (salesorderidtxt.Text == "")
            {
                MessageBox.Show("Please input the Salesorder_id");
            }
            else
            {
                try
                {
                    showsalesorderdetail();
                    salesorderdata();
                    grantotalfunction();
                    itemtotalfunction();
                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }

            }
        }

        private void purchaseorderidtxt_Click(object sender, EventArgs e)
        {
            showsalesorderdetail();
            salesorderdata();
        }

        //PRODUCT REFERENCE SEARCH

        private void button3_Click_1(object sender, EventArgs e)
        {
            ProductGV.Show();
            searcbox.Show();

            //BUTTON
            searchprobtn.Show();
            searchsupplier.Hide();

            CustomerGV.Hide();
            closepbtn.Show();

            button5.Hide();
            button3.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            CustomerGV.Show();
            searcbox.Show();

            //BUTTON
            searchprobtn.Hide();
            searchsupplier.Show();

            closepbtn.Show();
            ProductGV.Hide();

            button5.Hide();
            button3.Hide();
        }

        private void itemtotal_Click_1(object sender, EventArgs e)
        {
            itemtotalfunction();
        }

        private void grandtotal_Click_1(object sender, EventArgs e)
        {
            grantotalfunction();
        }

        private void subtotaltxt_Click(object sender, EventArgs e)
        {
            subtotalfunction();
        }

        private void Qtytxt_Leave_1(object sender, EventArgs e)
        {
            subtotalfunction();
        }

        private void pricetxt_Leave_1(object sender, EventArgs e)
        {
            subtotalfunction();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            DashboardForm dashboardmenu = new DashboardForm();
            dashboardmenu.Show();
            this.Hide();
        }



        private void closepbtn_Click_1(object sender, EventArgs e)
        {
            ProductGV.Hide();
            closepbtn.Hide();
            CustomerGV.Hide();
            searcbox.Hide();
            searchsupplier.Hide();
            searchprobtn.Hide();
            button5.Show();
            button3.Show();
            searcbox.Text = "";
        }


        private void searchsupplier_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conn = Koneksi.GetConnection();
                Conn.Open();
                cmd = new SqlCommand("SELECT customer_id, full_name FROM CUSTOMER WHERE customer_id like '%" + searcbox.Text + "%' or full_name like '%" + searcbox.Text + "%'", Conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "CUSTOMER");
                CustomerGV.DataSource = ds;
                CustomerGV.DataMember = "CUSTOMER";
                CustomerGV.AllowUserToAddRows = false;
                CustomerGV.ReadOnly = true;
                this.CustomerGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                CustomerGV.Refresh();
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }

        }

        private void searchprobtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conn = Koneksi.GetConnection();
                Conn.Open();
                cmd = new SqlCommand("SELECT product_id, product_name, price FROM PRODUCT WHERE product_id like '%" + searcbox.Text + "%' or product_name like '%" + searcbox.Text + "%'", Conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "PRODUCT");
                ProductGV.DataSource = ds;
                ProductGV.DataMember = "PRODUCT";
                ProductGV.AllowUserToAddRows = false;
                ProductGV.ReadOnly = true;
                ProductGV.Refresh();
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }

        }

        private void itemtotal_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (salesorderidtxt.Text == "")
            {
                MessageBox.Show("No product Selected");
            }
            else
            {
                if (MessageBox.Show("Do you want to Delete this row data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection Conn = Koneksi.GetConnection();
                        Conn.Open();
                        cmd = new SqlCommand("UPDATE PRODUCT SET product_qty = product_qty + purchaseQty FROM PURCHASE_ORDER_DETAIL WHERE PRODUCT.product_id ='" + productidtxt.Text + "';" +
                            "DELETE SALES_ORDER_DETAIL WHERE productid= '" + productidtxt.Text + "'", Conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Succesfully Deleted");

                        //REFRESH
                        showsalesorderdetail();
                        productidtxt.Text = "";
                        Qtytxt.Text = "";
                        pricetxt.Text = "";
                        subtotaltxt.Text = "";
                        grantotalfunction();
                        itemtotalfunction();
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
            if (salesorderidtxt.Text == "")
            {
                MessageBox.Show("No SALES order Selected");
            }
            else
            {
                if (MessageBox.Show("Do you want to Delete this row data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection Conn = Koneksi.GetConnection();
                        Conn.Open();
                        cmd = new SqlCommand(
                            "DELETE SALES_ORDER WHERE salesorder_id= '" + salesorderidtxt.Text + "'", Conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Succesfully Deleted");

                        //REFRESH
                        showsalesorderdetail();
                        productidtxt.Text = "";
                        Qtytxt.Text = "";
                        pricetxt.Text = "";
                        subtotaltxt.Text = "";
                        grantotalfunction();
                        itemtotalfunction();
                        showsalesorderdetail();
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
    }
}