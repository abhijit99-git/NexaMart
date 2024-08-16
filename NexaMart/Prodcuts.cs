using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace NexaMart
{
    public partial class Prodcuts : Form
    {
        Form1 f = new Form1();
        Dashboard CurrD;

        OleDbConnection con;
        public Prodcuts()
        {
            InitializeComponent();
        }

        public void SetDashInProduct(Dashboard d)
        {
            CurrD = d;
        }


        void fill()
        {
            ProductGrid.ClearSelection();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Products order by product_id", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ProductGrid.DataSource = dt;
            con.Close();
            ProductGrid.Columns[0].HeaderText = "ID";
            ProductGrid.Columns[1].HeaderText = "Product Name";
            ProductGrid.Columns[2].HeaderText = "Price";
            ProductGrid.Columns[3].HeaderText = "Category";

        }



        private void ProdCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ProdCategory_DropDownClosed(object sender, EventArgs e)
        {
            ProdID.Focus();
        }

        private void Prodcuts_Load(object sender, EventArgs e)
        {
            con = f.con;
            fill();


            //Loading Categories 
            ProdCategory.Items.Clear();
   
            OleDbDataAdapter daCAT = new OleDbDataAdapter("Select *from Categories order by cate_id", con);
            DataTable dtCAT = new DataTable();

            try
            {
                daCAT.Fill(dtCAT);

                for (int i = 0; i < dtCAT.Rows.Count; i++)
                {
                    ProdCategory.Items.Add(dtCAT.Rows[i]["cate_name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // end loading section
        }

        private void prodADD_Click(object sender, EventArgs e)
        {
        
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("Insert into Products values(" + Convert.ToInt32(ProdID.Text) + ", '" + ProdNAME.Text + "'," + Convert.ToInt32(ProdPRICE.Text) + ",'"+ProdCategory.Text+"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd = new OleDbCommand("Insert into Inventory values(" + Convert.ToInt32(ProdID.Text) + ", '" + ProdNAME.Text + "'," + Convert.ToInt32(StockProd.Text) + ",'"+SelectStatus.Text+"')",con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record already present or value mismatch", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                ProdID.Text = "";
                ProdNAME.Text = "";
                ProdPRICE.Text = "";
                ProdCategory.Text = "Select Category";
                SelectStatus.Text = "Select Status";
                StockProd.Text = "";
            }
            fill();
        }

        private void prodUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"update Products set product_name='{ProdNAME.Text}',p_price={Convert.ToInt32(ProdPRICE.Text)},Category_name='{ProdCategory.Text}' where product_id={Convert.ToInt32(ProdID.Text)}", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Record already present or value mismatch", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();
            }
            fill();
        }

        private void prodDELETE_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                OleDbCommand cmd = new OleDbCommand("Delete from Inventory where pro_id=" + Convert.ToInt32(ProdID.Text) + "", con);
                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("Delete from Products where product_id=" + Convert.ToInt32(ProdID.Text) + "", con);
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

        private void prodEXIT_Click(object sender, EventArgs e)
        {
            CurrD.loadform(CurrD.home);
            CurrD.isorders = false;
            ProdID.Text = "";
            ProdNAME.Text = "";
            ProdPRICE.Text = "";
            ProdCategory.Text = "Select Category";
            SelectStatus.Text = "Select Status";
            StockProd.Text = "";
            this.Hide();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            ProdID.Focus();
        }

        private void ProductGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ProductGrid.Rows[e.RowIndex];

                ProdID.Text = row.Cells["product_id"].Value.ToString();
                ProdNAME.Text = row.Cells["product_name"].Value.ToString();

                ProdPRICE.Text = row.Cells["p_price"].Value.ToString();
                StockProd.Text = "";
                ProdCategory.Text = row.Cells["Category_name"].Value.ToString();

                SelectStatus.Text = "Select Status";
            }
        }
    }
}
