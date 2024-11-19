using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Data.Common;
using static System.Net.WebRequestMethods;

namespace NexaMart 
{
    public partial class Orders : Form
    {
        int ProductPrice = 0;
        DataTable dt = new DataTable();
        Dashboard CurrD;

        Form1 formcon= new Form1();
        OleDbConnection con;
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C# programs\VS PROGRAMS\\NexaMart\NexaMart\NexaMartDB.accdb");
        public Orders()
        {
            InitializeComponent();
        }

        public void SetDashInOrder(Dashboard d)
        {
            CurrD = d;
        }


        bool zeroRecords = false;

        void iszeroRecords()
        {

            Form1 f2 = new Form1();

            try
            {
                OleDbConnection conforZero = f2.con;

                OleDbCommand cmdforZero = new OleDbCommand("SELECT COUNT(*) FROM Orders", conforZero);
                conforZero.Open();
                if (Convert.ToInt32(cmdforZero.ExecuteScalar().ToString()) == 0)
                {
                    zeroRecords = true;
                    OrdID.Text = "1";
                }
                else
                {
                    zeroRecords = false;

                }

                conforZero.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong , TRY AGAIN");
            }
        }


        void fill()
        {
            OrderGrid.ClearSelection();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Orders where 1=0 order by order_id", con);
            DataTable dtt= new DataTable();
            da.Fill(dtt);
            OrderGrid.DataSource = dtt;
            con.Close();
            OrderGrid.Columns[0].HeaderText = "ID";
            OrderGrid.Columns[1].HeaderText = "CustomerID";
            OrderGrid.Columns[2].HeaderText = "Product Name";
            OrderGrid.Columns[3].HeaderText = "Date";
            OrderGrid.Columns[4].HeaderText = "QTY";
            OrderGrid.Columns[5].HeaderText = "Total";
            OrderGrid.Columns[6].HeaderText = "Status";
        }




        private void empRole_DropDownClosed(object sender, EventArgs e)
        {
            OrdID.Focus();
        }

        private void empRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            OrdID.Focus();
        }

        private void ordEXIT_Click(object sender, EventArgs e)
        {
            CurrD.loadform(CurrD.home);
            CurrD.isorders = false;
           
            orderCustID.Text = "";
            OrderDate.Text = "";
            OrdID.Text = "";
            orderQTY.Text = "";
            orderTot.Text = "";
            categorySelect.Text = "Select Category";
            ProductSelect.Text = "Select Product";
            ProductSelect.Items.Clear();
            SearchCustomerID.Text = "";
            fill();
            this.Hide();
        }

        private void categorySelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Loading Products 
            ProductSelect.Items.Clear();
            ProductSelect.Text = "Select Product";
            orderQTY.Text = "";
            orderTot.Text = "";
            ProductPrice = 0;
            Form1 formPro = new Form1();
            OleDbConnection conPro = formPro.con;
            OleDbDataAdapter daP = new OleDbDataAdapter($"Select *from Products where Category_name='{categorySelect.SelectedItem.ToString()}'", conPro);
            DataTable dtP = new DataTable();

            try
            {
                daP.Fill(dtP);

                for (int i = 0; i < dtP.Rows.Count; i++)
                {
                    ProductSelect.Items.Add(dtP.Rows[i]["product_name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // end loading section


        }

        private void StatusSelect_DropDownClosed(object sender, EventArgs e)
        {
            OrdID.Focus();
        }

        private void StatusSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            con = formcon.con;
            fill();
            int cnt = OrderGrid.Rows.Count - 1;
           
            //Loading Categories 
            categorySelect.Items.Clear();  
             Form1 form1= new Form1();
            OleDbConnection conCat = form1.con;
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Categories order by cate_id", conCat);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);

                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    categorySelect.Items.Add(dt.Rows[i]["cate_name"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // end loading section
        }



        private void orderQTY_TextChanged(object sender, EventArgs e)
        {
   
            if (ProductSelect.Text=="Select Product")
            {
                orderTot.Text = "";
                MessageBox.Show("Please Select Product Or Enter Correct Quantity","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {


                try
                {
               
                    Form1 formQty = new Form1();
                    OleDbConnection conQty = formQty.con;
                    OleDbDataAdapter daQ = new OleDbDataAdapter($"Select *from Products where Category_name='{categorySelect.SelectedItem.ToString()}'", conQty);
                    DataTable dtQ = new DataTable();
                    daQ.Fill(dtQ);

             

                    if (ProductSelect.SelectedIndex >=0)
                    {
                        ProductPrice =Convert.ToInt32(dtQ.Rows[ProductSelect.SelectedIndex]["p_price"]);

                        if (orderQTY.Text == "")
                        {
                            orderTot.Text = (ProductPrice * Convert.ToInt32(1)).ToString();
                        }
                        else
                        {
                            orderTot.Text = (ProductPrice * Convert.ToInt32(orderQTY.Text)).ToString();
                        }
                    }
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Enter Correct Quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    orderTot.Text = "";
                }
            }
        }

        private void ProductSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderTot.Text = "";
            orderQTY.Text = "";
        }

        private void ordADD_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = formcon.con;
            //OleDbDataAdapter daInv = new OleDbDataAdapter("select stock from Inventory ", cn);
            int flag = 1;
            try
            {
                Convert.ToInt32(orderCustID.Text);
                flag = 0;
            }
            catch(Exception exx)
            {
                MessageBox.Show("Insert Correct Customer ID", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            if (flag == 0)
            {
                cn.Open();

                OleDbCommand cm = new OleDbCommand($"select *from Inventory where pro_name='{ProductSelect.Text}' and stock>={Convert.ToInt32(orderQTY.Text)}", cn);

                OleDbDataReader read = cm.ExecuteReader();
                if (read.HasRows)
                {
                    cn.Close();
                    OleDbConnection conInsert = formcon.con;

                    try
                    {
                        conInsert.Open();
                        OleDbCommand cmd = new OleDbCommand("Insert into Orders values(" + Convert.ToInt32(OrdID.Text) + ", " + Convert.ToInt32(orderCustID.Text) + ", '" + ProductSelect.Text + "', '" + OrderDate.Value.ToString("d-M-yyyy") + "'," + Convert.ToInt32(orderQTY.Text) + "," + Convert.ToInt32(orderTot.Text) + ",'" + StatusSelect.Text + "')", conInsert);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        //stock updation
                        cmd = new OleDbCommand($"Update Inventory set stock=(stock-{Convert.ToInt32(orderQTY.Text)}) where pro_name='{ProductSelect.Text}'", conInsert);
                        cmd.ExecuteNonQuery();

                        //
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Record already present or value mismatch", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conInsert.Close();
                        OrdID.Text = "";
                        orderCustID.Text = "";
                        OrderDate.Text = "";
                        orderQTY.Text = "";
                        orderTot.Text = "";
                        categorySelect.Text = "Select Category";
                        ProductSelect.Text = "Select Product";
                        ProductSelect.Items.Clear();
                    }
                    fill();
                    SearchCustomerID.Clear();
                }
                else
                {
                    MessageBox.Show("INSUFFICENT STOCK", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cn.Close();
                }
            }

            iszeroRecords();
        }

        private void ordUPDATE_Click(object sender, EventArgs e)
        {

            OleDbConnection conInsert = formcon.con;

            int flag = 1;
            try
            {
                Convert.ToInt32(orderCustID.Text);
                flag = 0;
            }
            catch (Exception exx)
            {
                MessageBox.Show("Insert Correct Customer ID", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            if (flag == 0)
            {
                try
                {
                    conInsert.Open();

                    OleDbCommand cmd = new OleDbCommand("Update Orders set custmer_id= " + Convert.ToInt32(orderCustID.Text) + ", order_date='" + OrderDate.Value.ToString("d-M-yyyy") + "', status='" + StatusSelect.Text + "' where order_id=" + Convert.ToInt32(OrdID.Text) + " ", conInsert);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record Not Present", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conInsert.Close();
                }
                fill();
                SearchCustomerID.Clear();
            }
            iszeroRecords();
        }

        private void ordDelete_Click(object sender, EventArgs e)
        {
            OleDbConnection con= formcon.con;
            int flag = 1;
            try
            {
                Convert.ToInt32(orderCustID.Text);
                flag = 0;
            }
            catch (Exception exx)
            {
                MessageBox.Show("Insert Correct Customer ID", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            if (flag == 0)
            {
                try
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand("Delete from Orders where order_id=" + Convert.ToInt32(OrdID.Text) + "", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record Not Present", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
                fill();
            }
            iszeroRecords();
        }

        private void OrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.OrderGrid.Rows[e.RowIndex];

                OrdID.Text = row.Cells["order_id"].Value.ToString();
                orderCustID.Text = row.Cells["custmer_id"].Value.ToString();
               
                ProductSelect.Text = row.Cells["p_name"].Value.ToString();
 
                OrderDate.Text = row.Cells["order_date"].Value.ToString();
 
                StatusSelect.Text = row.Cells["status"].Value.ToString();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
           
            orderCustID.Text = "";
            OrderDate.Text = "";
            orderQTY.Text = "";
            orderTot.Text = "";
            categorySelect.Text = "Select Category";
            ProductSelect.Text = "Select Product";
            OrdID.Text = "";
            ProductSelect.Items.Clear();
            SearchCustomerID.Text = "";
        }

        private void orderCustID_TextChanged(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            if (zeroRecords == false)
            {
                if (OrdID.Text == "")
                {
                    try
                    {
                        OleDbConnection conforID = f1.con;

                        OleDbCommand cmdforID = new OleDbCommand("SELECT TOP 1  order_id FROM Orders ORDER BY order_id DESC", conforID);
                        conforID.Open();
                        OrdID.Text = (Convert.ToInt32(cmdforID.ExecuteScalar().ToString()) + 1).ToString();
                        conforID.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something Went Wrong , TRY AGAIN");
                    }
                }
            }
        }

        private void SearchCustomerID_TextChanged(object sender, EventArgs e)
        {

            if (SearchCustomerID.Text == "")
            {
                fill();
            }
            else
            {
                OleDbDataAdapter daS = new OleDbDataAdapter($"Select *from Orders where custmer_id='{SearchCustomerID.Text}' order by order_id", con);
                DataTable dtS = new DataTable();
                daS.Fill(dtS);
                OrderGrid.DataSource = dtS;
                con.Close();
                OrderGrid.Columns[0].HeaderText = "ID";
                OrderGrid.Columns[1].HeaderText = "CustomerID";
                OrderGrid.Columns[2].HeaderText = "Product Name";
                OrderGrid.Columns[3].HeaderText = "Date";
                OrderGrid.Columns[4].HeaderText = "QTY";
                OrderGrid.Columns[5].HeaderText = "Total";
                OrderGrid.Columns[6].HeaderText = "Status";
            }
          
        }

        private void StatusSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
