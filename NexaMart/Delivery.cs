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
using System.Windows.Forms.VisualStyles;

namespace NexaMart
{
    public partial class Delivery : Form
    {
        Form1 fcon = new Form1();
        OleDbConnection con;
        public Delivery()
        {
            InitializeComponent();
            
        }


        void fill()
        {
            DeliveryGrid.ClearSelection();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Deliveries order by ID", con);
            DataTable dtt = new DataTable();
            da.Fill(dtt);
            DeliveryGrid.DataSource = dtt;
            con.Close();
            DeliveryGrid.Columns[0].HeaderText = "ID";
            DeliveryGrid.Columns[1].HeaderText = "Name";
            DeliveryGrid.Columns[2].HeaderText = "Contact";
            DeliveryGrid.Columns[3].HeaderText = "Email";
            DeliveryGrid.Columns[4].HeaderText = "Address";
            DeliveryGrid.Columns[5].HeaderText = "Status";
            DeliveryGrid.Columns[6].HeaderText = "OrderID";
        
        }


        bool zeroRecords = false;
        int DeliveryID = 1;
        void iszeroRecords()
        {

            Form1 f2 = new Form1();

            try
            {
                OleDbConnection conforZero = f2.con;

                OleDbCommand cmdforZero = new OleDbCommand("SELECT COUNT(*) FROM Deliveries", conforZero);
                conforZero.Open();
                if (Convert.ToInt32(cmdforZero.ExecuteScalar().ToString()) == 0)
                {
                    zeroRecords = true;
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
        private void Delivery_Load(object sender, EventArgs e)
        {
            con = fcon.con;
            fill();

            iszeroRecords();
        }

        private void StatusSelect_DropDownClosed(object sender, EventArgs e)
        {
            CustID.Focus();
        }

        private void StatusSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CustID_TextChanged(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();


            if (CustID.Text != "")
            {

                if (zeroRecords == false)
                {
                    try
                    {
                        OleDbConnection conforID = f1.con;

                        OleDbCommand cmdforID = new OleDbCommand("SELECT TOP 1  ID FROM Deliveries ORDER BY ID DESC", conforID);
                        conforID.Open();
                        DeliveryID = (Convert.ToInt32(cmdforID.ExecuteScalar().ToString()) + 1);

                        conforID.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something Went Wrong , TRY AGAIN");
                    }
                }



                try
                {
                    OleDbConnection conforFetch = f1.con;

                    OleDbCommand cmdforName = new OleDbCommand($"select cust_name from Customers where cust_id={Convert.ToInt32(CustID.Text)}", conforFetch);
                    OleDbCommand cmdforEmail = new OleDbCommand($"select cust_email from Customers where cust_id={Convert.ToInt32(CustID.Text)}", conforFetch);
                    OleDbCommand cmdforCon = new OleDbCommand($"select cust_number from Customers where cust_id={Convert.ToInt32(CustID.Text)}", conforFetch);
                    conforFetch.Open();
                    CustName.Text = (cmdforName.ExecuteScalar().ToString());
                    CustEmail.Text = (cmdforEmail.ExecuteScalar().ToString());
                    CustContact.Text = (cmdforCon.ExecuteScalar().ToString());
                    conforFetch.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong , TRY AGAIN");
                }
            }
        }

        private void DeliveryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DeliveryGrid.Rows[e.RowIndex];

                DeliveryID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                CustID.Text = "";
                CustName.Text = row.Cells["Cname"].Value.ToString();

                CustContact.Text = row.Cells["Ccontact"].Value.ToString();
                CustEmail.Text = row.Cells["Cemail"].Value.ToString();

                DeliveryAddress.Text = row.Cells["Caddress"].Value.ToString();

                StatusSelect.Text = row.Cells["Status"].Value.ToString();
                OrdIDtxt.Text = row.Cells["OrdID"].Value.ToString();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
            CustName.Text = "";
            CustContact.Text = "";
            CustID.Text = "";
            CustEmail.Text = "";
            DeliveryAddress.Text = "";
            StatusSelect.Text = "Select Status";
            SearchCustomerName.Text = "";
            OrdIDtxt.Text = "";
        
        }


       
        private void SearchCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (SearchCustomerName.Text == "")
            {
                fill();
            }
            else
            {
                con.Open();
                OleDbDataAdapter daS = new OleDbDataAdapter($"Select *from Deliveries where Cname='{SearchCustomerName.Text}' order by ID", con);
                DataTable dtS = new DataTable();
                daS.Fill(dtS);
                DeliveryGrid.DataSource = dtS;
                con.Close();
                DeliveryGrid.Columns[0].HeaderText = "ID";
                DeliveryGrid.Columns[1].HeaderText = "Name";
                DeliveryGrid.Columns[2].HeaderText = "Contact";
                DeliveryGrid.Columns[3].HeaderText = "Email";
                DeliveryGrid.Columns[4].HeaderText = "Address";
                DeliveryGrid.Columns[5].HeaderText = "Status";
                DeliveryGrid.Columns[6].HeaderText = "OrderID";
            }
        }

        private void DeliADD_Click(object sender, EventArgs e)
        {

            try
            {
               
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"Insert into Deliveries values({DeliveryID},'{CustName.Text}','{CustContact.Text}','{CustEmail.Text}','{DeliveryAddress.Text}','{StatusSelect.Text}',{OrdIDtxt.Text})", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            iszeroRecords();
        }

        private void DeliUPDATE_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"Update Deliveries set Cname='{CustName.Text}',Ccontact='{CustEmail.Text}',Cemail='{CustContact.Text}',Caddress='{DeliveryAddress.Text}',Status='{StatusSelect.Text}',OrdID={OrdIDtxt.Text} where ID={DeliveryID}", con);
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
            iszeroRecords();
        }

        private void DeliEXIT_Click(object sender, EventArgs e)
        {

        }
    }
}
