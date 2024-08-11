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
    public partial class HomeForm : Form
    {

        Dashboard CurrD;
        public HomeForm()
        {
            InitializeComponent();
        }

        public HomeForm(Dashboard d)
        {
            InitializeComponent();
            CurrD = d;
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            CurrD.isemployees = true;
            CurrD.issuupliers = false;
            CurrD.isorders = false;
            CurrD.iscustomers = false;
            CurrD.isproduct = false;
            CurrD.isbilling = false;
            CurrD.loadform(CurrD.emp);
            this.Hide();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            CurrD.isemployees = false;
            CurrD.issuupliers = false;
            CurrD.isorders = true;
            CurrD.iscustomers = false;
            CurrD.isproduct = false;
            CurrD.isbilling = false;
            CurrD.loadform(CurrD.order);
            this.Hide();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            CurrD.isemployees = false;
            CurrD.issuupliers = false;
            CurrD.isorders = false;
            CurrD.iscustomers = false;
            CurrD.isproduct = true;
            CurrD.isbilling = false;
            CurrD.loadform(CurrD.prod);
            this.Hide();
        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {
            CurrD.isemployees = false;
            CurrD.issuupliers = true;
            CurrD.isorders = false;
            CurrD.iscustomers = false;
            CurrD.isproduct = false;
            CurrD.isbilling = false;
            CurrD.loadform(CurrD.sup);
            this.Hide();
        }

        private void BillingBtn_Click(object sender, EventArgs e)
        {
            CurrD.isemployees = false;
            CurrD.issuupliers = false;
            CurrD.isorders = false;
            CurrD.iscustomers = false;
            CurrD.isproduct = false;
            CurrD.isbilling = true;
            CurrD.loadform(CurrD.bill);
            this.Hide();
        }

        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            CurrD.isemployees = false;
            CurrD.issuupliers = false;
            CurrD.isorders = false;
            CurrD.iscustomers = true;
            CurrD.isproduct = false;
            CurrD.isbilling = false;
            CurrD.loadform(CurrD.cust);
            this.Hide();
        }
    }
}
