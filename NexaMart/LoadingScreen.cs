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
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadLevel.Width += 3;
            if (LoadLevel.Width >= 1098)
            {
                timer1.Stop();
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }
    }
}
