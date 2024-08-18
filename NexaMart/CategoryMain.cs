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
            CatID.Text = "";
            CatName.Text = "";
            CatDescription.Text = "";
            StatusSelect.Text = "Select Status";
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

        private void CatUPDATE_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"Update Categories set cate_name='{CatName.Text}',description='{CatDescription.Text}',status='{StatusSelect.Text}' where cate_id={Convert.ToInt32(CatID.Text)}", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
