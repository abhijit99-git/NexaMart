using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexaMart
{
    public partial class Billing : Form
    {

        Form1 f = new Form1();
        OleDbConnection con;
        Dashboard CurrD;

        public Billing()
        {
            InitializeComponent();
        }


        public void SetDashInBilling(Dashboard d)
        {
            CurrD = d;
        }

        void fill()
        {
            BillingOrderGrid.ClearSelection();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Orders order by order_id", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            BillingOrderGrid.DataSource = dt;
            con.Close();
            BillingOrderGrid.Columns[0].HeaderText = "ID";
            BillingOrderGrid.Columns[1].HeaderText = "CustmerID";
            BillingOrderGrid.Columns[2].HeaderText = "Product Name";
            BillingOrderGrid.Columns[3].HeaderText = "Date";
            BillingOrderGrid.Columns[4].HeaderText = "QTY";
            BillingOrderGrid.Columns[5].HeaderText = "Total";
            BillingOrderGrid.Columns[6].HeaderText = "Status";

        }

        void fillBill()
        {
            BillingSelectPrint.ClearSelection();
            con.Open();
            OleDbDataAdapter daa = new OleDbDataAdapter("Select *from Billing order by order_id", con);
            DataTable dtt = new DataTable();
            daa.Fill(dtt);
            BillingSelectPrint.DataSource = dtt;
            con.Close();
            BillingSelectPrint.Columns[0].HeaderText = "ID";
            BillingSelectPrint.Columns[1].HeaderText = "CustmerID";
            BillingSelectPrint.Columns[2].HeaderText = "Product Name";
            BillingSelectPrint.Columns[3].HeaderText = "Date";
            BillingSelectPrint.Columns[4].HeaderText = "QTY";
            BillingSelectPrint.Columns[5].HeaderText = "Total";

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            con = f.con;
            fill();

            con.Open();
            OleDbCommand cmd = new OleDbCommand("Delete from Billing", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fillBill();
        }

        private void BillEXIT_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Delete from Billing", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fillBill();

            CurrD.loadform(CurrD.home);
            CurrD.isbilling = false;
            SearchCustomerID.Text = "";
            this.Hide();
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
                BillingOrderGrid.DataSource = dtS;
                con.Close();
                BillingOrderGrid.Columns[0].HeaderText = "ID";
                BillingOrderGrid.Columns[1].HeaderText = "CustomerID";
                BillingOrderGrid.Columns[2].HeaderText = "Product Name";
                BillingOrderGrid.Columns[3].HeaderText = "Date";
                BillingOrderGrid.Columns[4].HeaderText = "QTY";
                BillingOrderGrid.Columns[5].HeaderText = "Total";
                BillingOrderGrid.Columns[6].HeaderText = "Status";
            }
            fillBill();
        }

        private void BillADD_Click(object sender, EventArgs e)
        {

            //Random rnd = new Random();

            //MessageBox.Show(rnd.Next(100000, 999999).ToString());
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand($"Insert into Billing values({OID},'{CustID}','{Pname}','{ODATE}',{Quantity},{Amt})", con);
                cmd.ExecuteNonQuery();
                con.Close();
                fillBill();
                OID = "";
                CustID = "";
                 Pname = "";
                 ODATE = "";
                Quantity = "";
                Amt = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Record already present or value mismatch", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        String OID = "";
        String CustID = "";
        String Pname = "";
        String ODATE = "";
        String Quantity = "";
        String Amt = "";
        private void BillingOrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.BillingOrderGrid.Rows[e.RowIndex];

                OID = row.Cells["order_id"].Value.ToString();
                CustID = row.Cells["custmer_id"].Value.ToString();
                Pname = row.Cells["p_name"].Value.ToString();
                ODATE = row.Cells["order_date"].Value.ToString();
                Quantity = row.Cells["qty"].Value.ToString();
                Amt = row.Cells["total_amt"].Value.ToString();
            }
        }

        private void RemoveRecord_Click(object sender, EventArgs e)
        {
            if (deleteid == 0)
            {
                MessageBox.Show("Please Select Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand($"Delete from Billing where order_id={deleteid}", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    fillBill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Select Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    deleteid = 0;
                }
            }
        }

        int deleteid=0;
        private void BillingSelectPrint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.BillingSelectPrint.Rows[e.RowIndex];

                deleteid =Convert.ToInt32(row.Cells["order_id"].Value.ToString());
            }
        }
    }
}
