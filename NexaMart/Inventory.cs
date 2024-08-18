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
    public partial class Inventory : Form
    {

        Form1 f = new Form1();
        OleDbConnection con;
        Dashboard CurrD;
        public Inventory()
        {
            InitializeComponent();
        }

        void fill()
        {
            InventoryGrid.ClearSelection();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Inventory order by pro_id", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            InventoryGrid.DataSource = dt;
            con.Close();
            InventoryGrid.Columns[0].HeaderText = "ID";
            InventoryGrid.Columns[1].HeaderText = "Product Name";
            InventoryGrid.Columns[2].HeaderText = "Stock";
            InventoryGrid.Columns[3].HeaderText = "Status";

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            con = f.con;
            fill();
        }

        private void SelectStatus_DropDownClosed(object sender, EventArgs e)
        {
            stock.Focus();
        }

        private void SelectStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;   
        }

        private void ResetInv_Click(object sender, EventArgs e)
        {
            stock.Text = "";
            SelectStatus.Text = "Select Status";
        }

        private void inventoryUPDATE_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"Update Inventory set stock='{stock.Text}',status='{SelectStatus.Text}' where pro_id={Convert.ToInt32(prodid)}", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                prodid = "";
                stock.Text = "";
                SelectStatus.Text = "Select Status";
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

        string prodid = "";

        private void InventoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.InventoryGrid.Rows[e.RowIndex];

                stock.Text = row.Cells["stock"].Value.ToString();
                SelectStatus.Text = row.Cells["status"].Value.ToString();
                prodid = row.Cells["pro_id"].Value.ToString();
            }
        }
    }
}
