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
        }

        void OrderAmtFill()
        {
            
            Form1 formOrd = new Form1();
            OleDbConnection conOrd =  formOrd.con;
            OleDbCommand cmd= new OleDbCommand("Select Count(*) from Orders",conOrd);
            try
            {
                conOrd.Open();
               OrderAmtText.Text= cmd.ExecuteScalar().ToString();
                
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
                ProductAmtText.Text = cmd.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conProd.Close();
        }

    
        private void DashboardAnalytics_Load(object sender, EventArgs e)
        {
            OrderAmtFill();
            ProdFill();
          
        }
    }
}
