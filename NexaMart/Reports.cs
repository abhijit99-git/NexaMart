using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexaMart
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void empReport_Click(object sender, EventArgs e)
        {
            ReportsMultiple rp= new ReportsMultiple("Employee");
            rp.Show();
        }

        private void orderReport_Click(object sender, EventArgs e)
        {

            ReportsMultiple rp = new ReportsMultiple("Order");
            rp.Show();
        }

        private void productReport_Click(object sender, EventArgs e)
        {

            ReportsMultiple rp = new ReportsMultiple("Product");
            rp.Show();
        }

        private void supplierReport_Click(object sender, EventArgs e)
        {

            ReportsMultiple rp = new ReportsMultiple("Supplier");
            rp.Show();
        }

        private void customerReport_Click(object sender, EventArgs e)
        {

            ReportsMultiple rp = new ReportsMultiple("Customer");
            rp.Show();
        }
    }
}
