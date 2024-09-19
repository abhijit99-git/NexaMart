using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NexaMart
{
    public partial class Customers : Form
    {

        Form1 f = new Form1();
        OleDbConnection con;
        Dashboard CurrD;
        public Customers()
        {
            InitializeComponent();
        }

        public void SetDashInCustomer(Dashboard d)
        {
            CurrD = d;
        }

        void fill()
        {
            CustomerGrid.ClearSelection();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Customers order by cust_id", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CustomerGrid.DataSource = dt;
            con.Close();
            CustomerGrid.Columns[0].HeaderText = "ID";
            CustomerGrid.Columns[1].HeaderText = "Name";
            CustomerGrid.Columns[2].HeaderText = "Email";
            CustomerGrid.Columns[3].HeaderText = "Contact";
            CustomerGrid.Columns[4].HeaderText = "Address";

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            con = f.con;
            fill();
        }

        private void custEXIT_Click(object sender, EventArgs e)
        {

            CurrD.loadform(CurrD.home);
            CurrD.iscustomers = false;
            CustID.Text = "";
            CustName.Text = "";
            CustContact.Text = "";
            CustAddress.Text = "";
            CustEmail.Text = "";
            this.Hide();
        }

        private void custADD_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"Insert into Customers values({Convert.ToInt32(CustID.Text)},'{CustName.Text}','{CustEmail.Text}','{CustContact.Text}','{CustAddress.Text}')", con);
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

        private void custUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"Update Customers set cust_name='{CustName.Text}',cust_email='{CustEmail.Text}',cust_number='{CustContact.Text}',cust_add='{CustAddress.Text}' where cust_id={Convert.ToInt32(CustID.Text)}", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
              
                MessageBox.Show(ex+"Value Mismatch or Record already present", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            fill();
        }

        private void custDELETE_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"Delete from Customers where cust_id={Convert.ToInt32(CustID.Text)}", con);
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

        private void CustomerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.CustomerGrid.Rows[e.RowIndex];

                CustID.Text = row.Cells["cust_id"].Value.ToString();
                CustName.Text = row.Cells["cust_name"].Value.ToString();
                CustContact.Text = row.Cells["cust_number"].Value.ToString();
                CustAddress.Text = row.Cells["cust_add"].Value.ToString();
                CustEmail.Text = row.Cells["cust_email"].Value.ToString();
            }
        }

        private void SearchCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (SearchCustomerName.Text == "")
            {
                fill();
            }
            else
            {
                OleDbDataAdapter daS = new OleDbDataAdapter($"Select *from Customers where cust_name='{SearchCustomerName.Text}' order by cust_id", con);
                DataTable dtS = new DataTable();
                daS.Fill(dtS);
                CustomerGrid.DataSource = dtS;
                con.Close();
                CustomerGrid.Columns[0].HeaderText = "ID";
                CustomerGrid.Columns[1].HeaderText = "Name";
                CustomerGrid.Columns[2].HeaderText = "Email";
                CustomerGrid.Columns[3].HeaderText = "Contact";
                CustomerGrid.Columns[4].HeaderText = "Address";
            }
            
        }
    }
}
