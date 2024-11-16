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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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


        bool zeroRecords = false;

        void iszeroRecords()
        {

            Form1 f2 = new Form1();

            try
            {
                OleDbConnection conforZero = f2.con;

                OleDbCommand cmdforZero = new OleDbCommand("SELECT COUNT(*) FROM Customers", conforZero);
                conforZero.Open();
                if (Convert.ToInt32(cmdforZero.ExecuteScalar().ToString()) == 0)
                {
                    zeroRecords = true;
                    CustID.Text = "1";
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
            CustomerGrid.ClearSelection();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Customers where 1=0 order by cust_id", con);
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
            iszeroRecords();
        }

        private void custEXIT_Click(object sender, EventArgs e)
        {

            CurrD.loadform(CurrD.home);
            CurrD.iscustomers = false;
           
            CustName.Text = "";
            CustID.Text = "";
            CustContact.Text = "";
            CustAddress.Text = "";
            CustEmail.Text = "";
            SearchCustomerName.Text = "";
            this.Hide();
        }


        bool checkValid()
        {
            if (CustContact.Text.Length != 10)
            {

                return true;
            }
            else if (!CustEmail.Text.ToLower().EndsWith("@gmail.com"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void custADD_Click(object sender, EventArgs e)
        {

            if (checkValid() == false)
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
                iszeroRecords();
            }
            else
            {
                MessageBox.Show("Invalid Contact Or Email ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void custUPDATE_Click(object sender, EventArgs e)
        {
            if (checkValid() == false)
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

                    MessageBox.Show(ex + "Value Mismatch or Record already present", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
                fill();
                SearchCustomerName.Text = "";
                iszeroRecords();
            }
            else
            {
                MessageBox.Show("Invalid Contact Or Email ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            iszeroRecords();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            CustName.Text = "";
            CustID.Text = "";
            CustContact.Text = "";
            CustAddress.Text = "";
            CustEmail.Text = "";
            SearchCustomerName.Text = "";
        }

        private void CustName_TextChanged(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            if (zeroRecords == false)
            {
                if (CustID.Text == "")
                {
                    try
                    {
                        OleDbConnection conforID = f1.con;

                        OleDbCommand cmdforID = new OleDbCommand("SELECT TOP 1  cust_id FROM Customers ORDER BY cust_id DESC", conforID);
                        conforID.Open();
                        CustID.Text = (Convert.ToInt32(cmdforID.ExecuteScalar().ToString()) + 1).ToString();
                        conforID.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something Went Wrong , TRY AGAIN");
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
