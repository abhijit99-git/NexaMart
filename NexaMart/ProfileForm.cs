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
    
    public partial class ProfileForm : Form
    {

        public static string ReceiptNameText = "";
        public ProfileForm()
        {
            InitializeComponent();
            ReceiptName.Text = ReceiptNameText;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReceiptName_TextChanged(object sender, EventArgs e)
        {
            ReceiptNameText = ReceiptName.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
