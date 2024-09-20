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
    public partial class Suppliers : Form
    {
        Form1 f = new Form1();
        OleDbConnection con;
        Dashboard CurrD;
        public Suppliers()
        {
            InitializeComponent();
        }

        public void SetDashInSupplier(Dashboard d)
        {
            CurrD = d;
        }

        void fill()
        {
            SupplierGrid.ClearSelection();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from SUPPLIERS order by supp_id", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SupplierGrid.DataSource = dt;
            con.Close();
            SupplierGrid.Columns[0].HeaderText = "ID";
            SupplierGrid.Columns[1].HeaderText = "Name";
            SupplierGrid.Columns[2].HeaderText = "Address";
            SupplierGrid.Columns[3].HeaderText = "City";
            SupplierGrid.Columns[4].HeaderText = "Country";
            SupplierGrid.Columns[5].HeaderText = "Contact";

        }

        private void supEXIT_Click(object sender, EventArgs e)
        {
            CurrD.loadform(CurrD.home);
            CurrD.issuupliers = false;
           
            SupName.Text = "";
            SupID.Text = "";
            SupCity.Text = "";
            SupContact.Text = "";
            SupCountry.Text = "";
            SupAddress.Text = "";
            SearchCustomerName.Text = "";
            this.Hide();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            con=f.con;
            fill();
        }


        bool checkValid()
        {
            if (SupContact.Text.Length != 10)
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        private void supADD_Click(object sender, EventArgs e)
        {
            if (checkValid() == false)
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand($"Insert into SUPPLIERS values({Convert.ToInt32(SupID.Text)},'{SupName.Text}','{SupAddress.Text}','{SupCity.Text}','{SupCountry.Text}','{SupContact.Text}')", con);
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
                SearchCustomerName.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid Contact", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supUPDATE_Click(object sender, EventArgs e)
        {
            if (checkValid() == false)
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand($"Update SUPPLIERS set supp_name='{SupName.Text}',supp_address='{SupAddress.Text}',supp_city='{SupCity.Text}',supp_country='{SupCountry.Text}',supp_phone='{SupContact.Text}' where supp_id={Convert.ToInt32(SupID.Text)}", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Invalid Contact", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"Delete from SUPPLIERS where supp_id={Convert.ToInt32(SupID.Text)}", con);
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

        private void SupplierGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.SupplierGrid.Rows[e.RowIndex];

                SupID.Text = row.Cells["supp_id"].Value.ToString();
                SupName.Text = row.Cells["supp_name"].Value.ToString();
                SupAddress.Text = row.Cells["supp_address"].Value.ToString();
                SupCity.Text = row.Cells["supp_city"].Value.ToString();
                SupCountry.Text = row.Cells["supp_country"].Value.ToString();
                SupContact.Text = row.Cells["supp_phone"].Value.ToString();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            SupName.Text = "";
            SupID.Text = "";
            SupCity.Text = "";
            SupContact.Text = "";
            SupCountry.Text = "";
            SupAddress.Text = "";
            SearchCustomerName.Text = "";
        }

        private void SupName_TextChanged(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            if (SupID.Text == "")
            {
                try
                {
                    OleDbConnection conforID = f1.con;

                    OleDbCommand cmdforID = new OleDbCommand("SELECT TOP 1  supp_id FROM SUPPLIERS ORDER BY supp_id DESC", conforID);
                    conforID.Open();
                    SupID.Text = (Convert.ToInt32(cmdforID.ExecuteScalar().ToString()) + 1).ToString();
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
                OleDbDataAdapter daS = new OleDbDataAdapter($"Select *from SUPPLIERS where supp_name='{SearchCustomerName.Text}'", con);
                DataTable dtS = new DataTable();
                daS.Fill(dtS);
                SupplierGrid.DataSource = dtS;
                con.Close();
                SupplierGrid.Columns[0].HeaderText = "ID";
                SupplierGrid.Columns[1].HeaderText = "Name";
                SupplierGrid.Columns[2].HeaderText = "Address";
                SupplierGrid.Columns[3].HeaderText = "City";
                SupplierGrid.Columns[4].HeaderText = "Country";
                SupplierGrid.Columns[5].HeaderText = "Contact";
            }
        }
    }
}
