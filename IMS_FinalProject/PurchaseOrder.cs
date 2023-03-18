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
    public partial class PurchaseOrder : Form
    {
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
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
            supplieridtxt.Text = "";
            suppliernametxt.Text = "";
            productidtxt.Text = "";
            Qtytxt.Text = "";
            pricetxt.Text = "";
            purchaseorderidtxt.Text = "";
            subtotaltxt.Text = "0";
            grandtotal.Text = "0";
            itemtotal.Text= "0";
            SupplierGV.Hide();
            ProductGV.Hide();
            searcbox.Hide();
            searchprobtn.Hide();
            closepbtn.Hide();
            searchsupplier.Hide();
            button3.Show();
            button5.Show();

            showsupplier();
            showproduct();
            showpurchaseorderdetail();
        }

        // ------------- FUNCTION -------------------

        void showpurchaseorderdetail()
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT  productid, product_name, purchase_price, purchaseQty, subtotal FROM PURCHASE_ORDER_DETAIL, PRODUCT WHERE PurchaseOrder_id ='" + purchaseorderidtxt.Text + "' AND productid = product_id", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "PURCHASE_ORDER_DETAIL");
            purchasedetailGV.DataSource = ds;
            purchasedetailGV.DataMember = "PURCHASE_ORDER_DETAIL";
            purchasedetailGV.AllowUserToAddRows = false;
            purchasedetailGV.ReadOnly = true;
            this.purchasedetailGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            purchasedetailGV.Refresh();
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

        void showsupplier()
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT supplier_id, supplier_name FROM SUPPLIER", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "SUPPLIER");
            SupplierGV.DataSource = ds;
            SupplierGV.DataMember = "SUPPLIER";
            SupplierGV.AllowUserToAddRows = false;
            SupplierGV.ReadOnly = true;
            this.SupplierGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SupplierGV.Refresh();
        }

        void getpurchaseorderdata()
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT PurchaseOrder_id, date, total_item, total_purchase, supplierid, supplier_name FROM PURCHASE_ORDER, SUPPLIER where PurchaseOrder_id= '"+purchaseorderidtxt.Text+ "' AND supplier_id = supplierid", Conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if(rd.Read())
            {
                addbtn.Enabled = false;
                purchaseorderidtxt.Text = rd.GetValue(0).ToString();
                supplieridtxt.Text = rd.GetValue(4).ToString();
                suppliernametxt.Text = rd.GetValue(5).ToString();
            }
            else
            {
                addbtn.Enabled = true;
            }
        }

        void grantotalfunction()
        {
            grandtotal.Text = "0";
            for (int i = 0; i < purchasedetailGV.Rows.Count; i++)
            {
                grandtotal.Text = Convert.ToString(double.Parse(grandtotal.Text) + double.Parse(purchasedetailGV.Rows[i].Cells[4].Value.ToString()));
            }
        }

        void itemtotalfunction()
        {
            itemtotal.Text = "0";
            for (int i = 0; i < purchasedetailGV.Rows.Count; i++)
            {
                itemtotal.Text = Convert.ToString(double.Parse(itemtotal.Text) + double.Parse(purchasedetailGV.Rows[i].Cells[3].Value.ToString()));
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

        // ------------------ END OF FUNCTION ------------------------------

        // --------------------- DATAGRIDVIEW CELL CLICK ------------------------

        private void SupplierGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.SupplierGV.Rows[e.RowIndex];
                supplieridtxt.Text = row.Cells["supplier_id"].Value.ToString();
                suppliernametxt.Text = row.Cells["supplier_name"].Value.ToString();
            }
            catch
            {

            }
        }

        private void ProductGV_CellClick(object sender, DataGridViewCellEventArgs e)
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


        private void purchasedetailGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.purchasedetailGV.Rows[e.RowIndex];
                productidtxt.Text = row.Cells["productid"].Value.ToString();
                pricetxt.Text = row.Cells["purchase_price"].Value.ToString();
                Qtytxt.Text = row.Cells["purchaseQty"].Value.ToString();
                subtotaltxt.Text = row.Cells["subtotal"].Value.ToString();
            }
            catch
            {

            }
        }

        // ----------- END OF DATAGRIDVIEW CELL CLICK ---------------------

        ///PURCHASE ORDER DETAIL CRUD

        // --------------- ADD QUERY (DETAIL) --------------

        private void button2_Click(object sender, EventArgs e) 
        {
            if (purchaseorderidtxt.Text == "" || productidtxt.Text == "" || productidtxt.Text == "" || Qtytxt.Text == "" || subtotaltxt.Text == "")
            {
                MessageBox.Show("Please fill up all the required data");
            }
            else
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand("UPDATE PRODUCT SET product_qty = product_qty + purchaseqty FROM PURCHASE_ORDER_DETAIL WHERE PRODUCT.product_id ='" + productidtxt.Text + "';" +
                        "INSERT INTO PURCHASE_ORDER_DETAIL VALUES ('" + purchaseorderidtxt.Text + "','" + productidtxt.Text + "','" + pricetxt.Text + "','" + Qtytxt.Text + "','" + subtotaltxt.Text + "')", Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Succesfully Added");

                    //REFRESH
                    showpurchaseorderdetail();
                    productidtxt.Text = "";
                    Qtytxt.Text = "";
                    pricetxt.Text = "";
                    subtotaltxt.Text = "";

                    grantotalfunction();
                    itemtotalfunction();
                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }
               
            }
        }

        // ---------------- END OF ADD QUERY (DETAIL) -------------------

        // ----------------- DELETE QUERY (DETAIL) --------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            if (purchaseorderidtxt.Text == "" || productidtxt.Text == "" || productidtxt.Text == "" || Qtytxt.Text == "" || subtotaltxt.Text == "")
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
                        cmd = new SqlCommand("UPDATE PRODUCT SET product_qty = product_qty - purchaseQty FROM PURCHASE_ORDER_DETAIL WHERE PRODUCT.product_id ='" + productidtxt.Text + "';" +
                            "DELETE PURCHASE_ORDER_DETAIL WHERE productid= '" + productidtxt.Text + "'", Conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Succesfully Deleted");

                        //REFRESH
                        showpurchaseorderdetail();
                        productidtxt.Text = "";
                        Qtytxt.Text = "";
                        pricetxt.Text = "";
                        subtotaltxt.Text = "";
                        grantotalfunction();
                        itemtotalfunction();
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

        // ---------------------- END OF DELETE QUERY DETAIL ------------------------

        //PURCHASE ORDER CRUD

        // --------------------- ADD QUERY ----------------------------------
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (purchaseorderidtxt.Text == "")
            {
                MessageBox.Show("Make sure you have choosed the Purchase_id");
            }
            else
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand("INSERT INTO PURCHASE_ORDER VALUES ('" + purchaseorderidtxt.Text + "','" + So_date.Text + "','" + itemtotal.Text + "','" + grandtotal.Text + "','" + supplieridtxt.Text + "')", Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Saved");
                    InitialCondition();
                }
                catch(Exception G)
                {
                    MessageBox.Show(G.ToString());
                }

            }
        }

        // -------------------- END OF ADD QUERY -------------------------

        // ------------------------------- UPDATE PURCHASE_ORDER QUERY ------------------------------
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (purchaseorderidtxt.Text == "")
            {
                MessageBox.Show("Make sure you have chosen the Purchase_id");
            }
            else
            {
                if (MessageBox.Show("Do you want to update this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection Conn = Koneksi.GetConnection();
                        Conn.Open();
                        cmd = new SqlCommand("UPDATE PURCHASE_ORDER SET  date = '" + date.Text + "', total_item= '" + itemtotal.Text + "', supplierid ='" + supplieridtxt.Text + "' WHERE PurchaseOrder_id= '" + productidtxt.Text + "'", Conn);
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

        // ------------------ END OF UPDATE QUERY ------------------------

        // --------------------------- DELETE PURCHASE_ORDER QUERY --------------------------
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmation. this action cannot be undone", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection Conn = Koneksi.GetConnection();
                    Conn.Open();
                    cmd = new SqlCommand("DELETE PURCHASE_ORDER_DETAIL WHERE Purchaseorder_id = '"+ purchaseorderidtxt.Text + "'" +
                        "DELETE PURCHASE_ORDER WHERE purchaseorder_id= '" + purchaseorderidtxt.Text + "'", Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Succesfully Deleted");

                    InitialCondition();
                }
                catch(Exception G)
                {
                    MessageBox.Show(G.ToString());
                }

            }
            else
            {
                MessageBox.Show("Action canceled");  
            }
        }
        // ----------------------- END OF DELETE QUERY ---------------------

        // -------------------------- REFERENCE TAB BUTTON ---------------------------
        private void button5_Click(object sender, EventArgs e) //SUPPLIER
        {
            SupplierGV.Show();
            searcbox.Show();
            
            //BUTTON
            searchprobtn.Hide();
            searchsupplier.Show();

            closepbtn.Show();
            ProductGV.Hide();
            
            button5.Hide();
            button3.Hide();
        }

        private void button3_Click(object sender, EventArgs e) //PRODUCT
        {
            ProductGV.Show();
            searcbox.Show();

            //BUTTON
            searchprobtn.Show();
            searchsupplier.Hide();

            SupplierGV.Hide();
            closepbtn.Show();
            
            button5.Hide();
            button3.Hide();
        }

        private void closepbtn_Click(object sender, EventArgs e)
        {
            ProductGV.Hide();
            closepbtn.Hide();
            SupplierGV.Hide();
            searcbox.Hide();
            searchsupplier.Hide();
            searchprobtn.Hide();
            button5.Show();
            button3.Show();
            searcbox.Text = "";
        }
        // -------------------------- END OF REFERENCE TAB BUTTON ---------------------------

        // -------------------------- PURCHASE ORDER SEARCH ----------------------------------

        private void findPObtn_Click(object sender, EventArgs e)
        {
            if(purchaseorderidtxt.Text == "")
            {
                MessageBox.Show("Please input the purchaseorder_id");
            }
            else
            {
                try
                {
                    showpurchaseorderdetail();
                    getpurchaseorderdata();
                    grantotalfunction();
                    itemtotalfunction();
                }
                catch(Exception G)
                {
                    MessageBox.Show(G.ToString());
                }

            }
        }

        // --------------------------------- END OF PURCHASE ORDER SEARCH -------------

        // ------------------------------------------ PRODUCT REFERENCE SEARCH -----------------------------

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT product_id, product_name, price FROM PRODUCT WHERE product_id like '%"+searcbox.Text+"%' or product_name like '%"+searcbox.Text+"%'", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "PRODUCT");
            ProductGV.DataSource = ds;
            ProductGV.DataMember = "PRODUCT";
            ProductGV.AllowUserToAddRows = false;
            ProductGV.ReadOnly = true;
            ProductGV.Refresh();
        }

        // ----------------------------- END OF PRODUCT REFERENCE SEARCH ---------------------------------------

        // ---------------------------------- SUPPLIER REFERENCE SEARCH -----------------------------------------

        private void searchsupplier_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = Koneksi.GetConnection();
            Conn.Open();
            cmd = new SqlCommand("SELECT supplier_id, supplier_name FROM SUPPLIER WHERE supplier_id like '%"+searcbox.Text+"%' or supplier_name like '%"+searcbox.Text+"%'", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "SUPPLIER");
            SupplierGV.DataSource = ds;
            SupplierGV.DataMember = "SUPPLIER";
            SupplierGV.AllowUserToAddRows = false;
            SupplierGV.ReadOnly = true;
            this.SupplierGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SupplierGV.Refresh();
        }

        // ---------------------------------- END OF SUPPLIER REFERENCE SEARCH ----------------------------------------

        // ------------------------------ TOTAL FUNCTION -------------------------

        private void itemtotal_Click(object sender, EventArgs e)
        {
            itemtotalfunction();
        }

        private void grandtotal_Click(object sender, EventArgs e)
        {
            grantotalfunction();
        }

        private void subtotaltxt_Click(object sender, EventArgs e)
        {
            subtotalfunction();
        }

        private void Qtytxt_Leave(object sender, EventArgs e)
        {
            subtotalfunction();
        }

        private void pricetxt_Leave(object sender, EventArgs e)
        {
            subtotalfunction();
        }

        // ---------------------------- END OF TOTAL FUNCTION -------------------------------

        // ------------------------- BACK TO DASHBOARD SCRIPT ------------------------------
        private void button12_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardmenu = new DashboardForm();
            dashboardmenu.Show();
            this.Hide();
        }
        // ---------------------------- END OF BACK TO DASHBOARD SCRIPT ----------------------
    }
}
