using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Data.Common;

namespace NexaMart 
{
    public partial class Orders : Form
    {

        DataTable dt = new DataTable();
        Dashboard CurrD;

        Form1 formcon= new Form1();
        OleDbConnection con;
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C# programs\VS PROGRAMS\\NexaMart\NexaMart\NexaMartDB.accdb");
        public Orders()
        {
            InitializeComponent();
        }

        public void SetDashInOrder(Dashboard d)
        {
            CurrD = d;
        }

        void fill()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Orders order by order_id", con);
            
            da.Fill(dt);
            OrderGrid.DataSource = dt;
            con.Close();
            OrderGrid.Columns[0].HeaderText = "ID";
            OrderGrid.Columns[1].HeaderText = "CustmerID";
            OrderGrid.Columns[2].HeaderText = "Product Name";
            OrderGrid.Columns[3].HeaderText = "Date";
            OrderGrid.Columns[4].HeaderText = "QTY";
            OrderGrid.Columns[5].HeaderText = "Total";
            OrderGrid.Columns[6].HeaderText = "Status";

        }




        private void empRole_DropDownClosed(object sender, EventArgs e)
        {
            OrdID.Focus();
        }

        private void empRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            OrdID.Focus();
        }

        private void ordEXIT_Click(object sender, EventArgs e)
        {
            CurrD.loadform(CurrD.home);
            CurrD.isorders = false;
            OrdID.Text = "";
            orderCustID.Text = "";
            OrderDate.Text = "";
            orderQTY.Text = "";
            orderTot.Text = "";
            categorySelect.Text = "Select Category";
            ProductSelect.Text = "Select Product";
            ProductSelect.Items.Clear();

            this.Hide();
        }

        private void categorySelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Loading Products 
            ProductSelect.Items.Clear();
            ProductSelect.Text = "Select Product";
            Form1 formPro = new Form1();
            OleDbConnection conPro = formPro.con;
            OleDbDataAdapter daP = new OleDbDataAdapter($"Select *from Products where Category_name='{categorySelect.SelectedItem.ToString()}'", conPro);
            DataTable dtP = new DataTable();

            try
            {
                daP.Fill(dtP);

                for (int i = 0; i < dtP.Rows.Count; i++)
                {
                    ProductSelect.Items.Add(dtP.Rows[i]["product_name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // end loading section


            //ProductSelect.Text = "Select Product";
            //if (categorySelect.SelectedItem == "Fruits")
            //{
            //    ProductSelect.Items.Add("Mango");
            //    ProductSelect.Items.Add("Apple");
            //    ProductSelect.Items.Add("Pineapple");
            //    ProductSelect.Items.Add("Grapes");
            //}
            //else
            //{
            //    ProductSelect.Items.Clear();
            //}
        }

        private void StatusSelect_DropDownClosed(object sender, EventArgs e)
        {
            OrdID.Focus();
        }

        private void StatusSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            con = formcon.con;
            fill();
            int cnt = OrderGrid.Rows.Count - 1;
           
            //Loading Categories 
            categorySelect.Items.Clear();  
             Form1 form1= new Form1();
            OleDbConnection conCat = form1.con;
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Categories order by cate_id", conCat);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);

                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    categorySelect.Items.Add(dt.Rows[i]["cate_name"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // end loading section
        }
    }
}
