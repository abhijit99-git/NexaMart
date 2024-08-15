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

namespace NexaMart 
{
    public partial class Orders : Form
    {

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
            DataTable dt = new DataTable();
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
            ProductSelect.Text = "Select Product";
            if (categorySelect.SelectedItem == "Fruits")
            {
                ProductSelect.Items.Add("Mango");
                ProductSelect.Items.Add("Apple");
                ProductSelect.Items.Add("Pineapple");
                ProductSelect.Items.Add("Grapes");
            }
            else
            {
                ProductSelect.Items.Clear();
            }
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
        }
    }
}
