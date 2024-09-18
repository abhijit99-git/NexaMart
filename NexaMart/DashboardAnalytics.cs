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
    public partial class DashboardAnalytics : Form
    {
        public DashboardAnalytics()
        {
            InitializeComponent();

            Form1 formini = new Form1();
            OleDbConnection conini = formini.con;
            OleDbDataAdapter dapp = new OleDbDataAdapter("Select *from Inventory", conini);
            DataTable dtt = new DataTable();

            try
            {
                dapp.Fill(dtt);

                for (int i = 0; i < dtt.Rows.Count; i++)
                {
                    string name = dtt.Rows[i]["pro_name"].ToString();
                    string stock = dtt.Rows[i]["stock"].ToString();
                    chart1.Series["Stock"].Points.AddXY(name,stock);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        
          
        }

        void OrderAmtFill()
        {
            
            Form1 formOrd = new Form1();
            OleDbConnection conOrd =  formOrd.con;
            OleDbCommand cmd= new OleDbCommand("Select Count(*) from Orders",conOrd);
            try
            {
                conOrd.Open();
                if (cmd.ExecuteScalar().ToString() == "")
                {
                    OrderAmtText.Text = "0";
                }
                else
                {
                    OrderAmtText.Text = cmd.ExecuteScalar().ToString();
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conOrd.Close();
        }

        void ProdFill()
        {

            Form1 formProd = new Form1();
            OleDbConnection conProd = formProd.con;
            OleDbCommand cmd = new OleDbCommand("Select Count(*) from Products", conProd);
            try
            {
                conProd.Open();
                if (cmd.ExecuteScalar().ToString() == "")
                {
                    ProductAmtText.Text = "0";
                }
                else
                {
                    ProductAmtText.Text = cmd.ExecuteScalar().ToString();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conProd.Close();
        }


        void fillTotal()
        {
            Form1 formtot = new Form1();
            OleDbConnection contot = formtot.con;
            OleDbCommand cmd = new OleDbCommand("Select sum(total_amt) from Orders", contot);
            try
            {
                contot.Open();
                if (cmd.ExecuteScalar().ToString() == "")
                {
                   TotalEarnText.Text = "₹ 0.00";
                }
                else
                {
                    TotalEarnText.Text = "₹ " + cmd.ExecuteScalar().ToString();
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            contot.Close();
        }

        void filltoday()
        {
            Form1 formtod = new Form1();
            OleDbConnection contod = formtod.con;
            OleDbCommand cmd = new OleDbCommand($"Select sum(total_amt) from Orders where status='PAID' and order_date='{DateTime.Now.ToString("d-M-yyyy")}'", contod);
            try
            {
                contod.Open();
                if (cmd.ExecuteScalar().ToString() == "")
                {
                    TodaysEarnText.Text = "₹ 0.00";
                }
                else
                {
                    TodaysEarnText.Text = "₹ " + cmd.ExecuteScalar().ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            contod.Close();
        }
    
        private void DashboardAnalytics_Load(object sender, EventArgs e)
        {
            OrderAmtFill();
            ProdFill();
            fillTotal();
            filltoday();
        }
    }
}
