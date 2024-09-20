using NexaMart.Components;
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

namespace NexaMart
{
    public partial class ManageCategory : Form
    {


        Form1 f = new Form1();
        OleDbConnection con;
        Dashboard CurrD;

        public ManageCategory()
        {
            InitializeComponent();
        }

        public ManageCategory(Dashboard d)
        {
            InitializeComponent();
            CurrD = d;
        }



        void catupdatefill()
        {
            //Loading Categories 
            CurrD.order.categorySelect.Items.Clear();
            CurrD.prod.ProdCategory.Items.Clear();
            Form1 form1 = new Form1();
            OleDbConnection conCat = form1.con;
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Categories order by cate_id", conCat);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CurrD.order.categorySelect.Items.Add(dt.Rows[i]["cate_name"].ToString());
                    CurrD.prod.ProdCategory.Items.Add(dt.Rows[i]["cate_name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // end loading section
        }
        void fill()
        {
            CategoryGrid.ClearSelection();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Categories order by cate_id", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CategoryGrid.DataSource = dt;
            con.Close();
            CategoryGrid.Columns[0].HeaderText = "ID";
            CategoryGrid.Columns[1].HeaderText = "Name";
            CategoryGrid.Columns[2].HeaderText = "Description";
            CategoryGrid.Columns[3].HeaderText = "Status";

        }



        private void StatusSelect_DropDownClosed(object sender, EventArgs e)
        {
            CatID.Focus();
        }

        private void StatusSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CatEXIT_Click(object sender, EventArgs e)
        {
            CurrD.loadform(new CategoriesForm(CurrD));
           
            CatName.Text = "";
            CatID.Text = "";
            CatDescription.Text = "";
            StatusSelect.Text = "Select Status";
            SearchCustomerName.Text = "";
            CurrD.manageCatBtn = false;

             this.Close();
        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            con = f.con;
            fill();
        }

        private void CatADD_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"Insert into Categories values({Convert.ToInt32(CatID.Text)},'{CatName.Text}','{CatDescription.Text}','{StatusSelect.Text}')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                catupdatefill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Value Mismatch or Record already present", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            fill();
            SearchCustomerName.Text = "";
        }

        private void CatUPDATE_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"Update Categories set cate_name='{CatName.Text}',description='{CatDescription.Text}',status='{StatusSelect.Text}' where cate_id={Convert.ToInt32(CatID.Text)}", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                catupdatefill();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + "Value Mismatch or Record already present", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            fill();
        }

        private void CatDELETE_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"Delete from Categories where cate_id={Convert.ToInt32(CatID.Text)}", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                catupdatefill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Value Mismatch or Record already present", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            fill();
        }

        private void CategoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.CategoryGrid.Rows[e.RowIndex];

                CatID.Text = row.Cells["cate_id"].Value.ToString();
                CatName.Text = row.Cells["cate_name"].Value.ToString();
                CatDescription.Text = row.Cells["description"].Value.ToString();
                StatusSelect.Text = row.Cells["status"].Value.ToString();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
           
            CatName.Text = "";
            CatDescription.Text = "";
            StatusSelect.Text = "Select Status";
            CatID.Text = "";
            SearchCustomerName.Text = "";
        }

        private void CatName_TextChanged(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            if (CatID.Text == "")
            {
                try
                {
                    OleDbConnection conforID = f1.con;

                    OleDbCommand cmdforID = new OleDbCommand("SELECT TOP 1  cate_id FROM Categories ORDER BY cate_id DESC", conforID);
                    conforID.Open();
                    CatID.Text = (Convert.ToInt32(cmdforID.ExecuteScalar().ToString()) + 1).ToString();
                    conforID.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong , TRY AGAIN");
                }
            }
        }

        private void SearchCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (SearchCustomerName.Text == "")
            {
                fill();
            }
            else
            {
                OleDbDataAdapter daS = new OleDbDataAdapter($"Select *from Categories where cate_name='{SearchCustomerName.Text}'", con);
                DataTable dtS = new DataTable();
                daS.Fill(dtS);
                CategoryGrid.DataSource = dtS;
                con.Close();
                CategoryGrid.Columns[0].HeaderText = "ID";
                CategoryGrid.Columns[1].HeaderText = "Name";
                CategoryGrid.Columns[2].HeaderText = "Description";
                CategoryGrid.Columns[3].HeaderText = "Status";
            }
        }
    }
}
