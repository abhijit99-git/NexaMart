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
        Dashboard CurrD;
        
        public CategoriesForm()
        {
            InitializeComponent();
        }
        public CategoriesForm(Dashboard d)
        {
            InitializeComponent();
            CurrD = d;
        }

        public void setdashcategory(Dashboard d)
        {
            CurrD = d;
        }

        private void Managebtn_Click(object sender, EventArgs e)
        {
            try
            {
                CurrD.loadform(new ManageCategory(CurrD));
                CurrD.manageCatBtn = true;
            }
            catch(Exception ex)
            {
                CurrD.loadform(new CategoriesForm(CurrD));
                CurrD.loadform(new ManageCategory(CurrD));
            }
        }
    }
}
