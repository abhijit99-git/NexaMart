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
    public partial class Delivery : Form
    {
        Form1 fcon = new Form1();
        OleDbConnection con;
        public Delivery()
        {
            InitializeComponent();
            
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            con = fcon.con;
        }
    }
}
