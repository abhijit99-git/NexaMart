using NexaMart.Components;
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
    public partial class Suppliers : Form
    {

        Dashboard CurrD;
        public Suppliers()
        {
            InitializeComponent();
        }

        public void SetDashInSupplier(Dashboard d)
        {
            CurrD = d;
        }

        private void supEXIT_Click(object sender, EventArgs e)
        {
            CurrD.loadform(CurrD.home);
            CurrD.isorders = false;
            SupID.Text = "";
            SupName.Text = "";
            SupCity.Text = "";
            SupContact.Text = "";
            SupCountry.Text = "";
            SupAddress.Text = "";
            this.Hide();
        }
    }
}
