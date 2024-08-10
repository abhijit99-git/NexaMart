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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/abhijit99-git");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("https://www.instagram.com/abhijit_99?utm_source=ig_web_button_share_sheet&igsh=ZDNlZDc0MzIxNw==");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/abhijit-tikone-684942241/");
        }

        private void GithubShiv_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/shivprasad9890");
        }

        private void InstagramShiv_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/shivprasad.suryawanshi967/?utm_source=ig_web_button_share_sheet");
        }

        private void LinkedinShiv_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/shivprasad-suryawanshi-2045092a9/");
        }
    }
}
