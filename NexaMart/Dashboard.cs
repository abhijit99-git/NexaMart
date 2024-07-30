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
   
    public partial class Dashboard : Form
    {
        Form1 f= new Form1 ();
        bool BarExpand;
        public Dashboard()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }


        private void closeDash_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (BarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    BarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    BarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void dashMenu_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SidebarTimer.Start();
   
        }

        private void LogoutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            f.Show();
            this.Close();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            f.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Close();
        }

        // mouse hover and leave 
        private void label4_MouseHover(object sender, EventArgs e)
        {
                label4.ForeColor = Color.SeaGreen;
       
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void Aboutus_MouseHover(object sender, EventArgs e)
        {
            Aboutus.ForeColor = Color.SeaGreen;
        }

        private void Aboutus_MouseLeave(object sender, EventArgs e)
        {
            Aboutus.ForeColor = Color.Black;
            
        }

        private void Profile_MouseHover(object sender, EventArgs e)
        {
            Profile.ForeColor = Color.SeaGreen;
        }

        private void Categories_MouseHover(object sender, EventArgs e)
        {
            Categories.ForeColor = Color.SeaGreen;
        }

        private void Categories_MouseLeave(object sender, EventArgs e)
        {
            Categories.ForeColor = Color.Black;
        }

        private void HomeText_MouseHover(object sender, EventArgs e)
        {
            HomeText.ForeColor = Color.SeaGreen;
        }

        private void HomeText_MouseLeave(object sender, EventArgs e)
        {
            HomeText.ForeColor = Color.Black;
        }

        private void Profile_MouseLeave(object sender, EventArgs e)
        {
            Profile.ForeColor = Color.Black;
        }

        //
    }
}
