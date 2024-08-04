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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
   
           
        }

        private void Managebtn_MouseHover(object sender, EventArgs e)
        {
            //Managebtn.BackColor = Color.FromArgb(136, 164, 41);
            //Managebtn.ForeColor = Color.White;
        }

        private void Managebtn_MouseLeave(object sender, EventArgs e)
        {
            //Managebtn.BackColor = Color.Transparent;
            //Managebtn.ForeColor = Color.FromArgb(136, 164, 41);
        }
    }
}
