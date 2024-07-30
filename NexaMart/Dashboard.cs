﻿using System;
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
        Form1 f = new Form1();
        public string Adminname { get; set; }
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


        /*
        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (BarExpand)
            {
                sidebar.Width -= 10;
                StraigthLine.Visible = false;
                
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
             
                        FIllDashPanel.Location = new Point(70, 23);
                        loadform(new HomeForm());
                        ans = true;
                    
            
                    BarExpand = false;
                    SidebarTimer.Stop();
                }

            }
            else
            {
                sidebar.Width += 10;
                StraigthLine.Visible = true;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    
                        FIllDashPanel.Location = new Point(104, 23);
                        loadform(new HomeForm());
                        ans = false;
                    
                    BarExpand = true;
                    SidebarTimer.Stop();
                }

            }

        }
        */
        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            int leftGap = 10; 
            int rightGap = 20; 

            if (BarExpand)
            {
                sidebar.Width -= 10;
                StraigthLine.Visible = false;

                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebar.Width = sidebar.MinimumSize.Width;
                    FIllDashPanel.Location = new Point(sidebar.Width + leftGap, FIllDashPanel.Location.Y);
                    FIllDashPanel.Width = this.Width - sidebar.Width - leftGap;
                    loadform(new HomeForm());
                    BarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                StraigthLine.Visible = true;

                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebar.Width = sidebar.MaximumSize.Width;
                    FIllDashPanel.Location = new Point(sidebar.Width + leftGap, FIllDashPanel.Location.Y);
                    FIllDashPanel.Width = this.Width - sidebar.Width - leftGap - rightGap;
                    loadform(new HomeForm());
                    BarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }




        bool ans = false;
        private void dashMenu_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
     
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            AdminName.Text = Adminname;
            loadform(new HomeForm());



        }

        public void minimizefromHomeform()
        {
            
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


        // mouse event end  

        void selectpanel(String panel)
        {
            if (panel == "Home")
            {
                HomePanel.BackColor = Color.FromArgb(203, 219, 249);
                CategoryPanel.BackColor = Color.AliceBlue;
                ProfilePanel.BackColor = Color.AliceBlue;
                AboutPanel.BackColor = Color.AliceBlue;
            }
            else if (panel == "Category")
            {
                CategoryPanel.BackColor = Color.FromArgb(203, 219, 249);
                HomePanel.BackColor = Color.AliceBlue;
                ProfilePanel.BackColor = Color.AliceBlue;
                AboutPanel.BackColor = Color.AliceBlue;

            }
            else if (panel == "Profile")
            {
                ProfilePanel.BackColor = Color.FromArgb(203, 219, 249);
                CategoryPanel.BackColor = Color.AliceBlue;
                HomePanel.BackColor = Color.AliceBlue;
                AboutPanel.BackColor = Color.AliceBlue;
            }
            else if (panel == "about")
            {
                AboutPanel.BackColor = Color.FromArgb(203, 219, 249);
                CategoryPanel.BackColor = Color.AliceBlue;
                ProfilePanel.BackColor = Color.AliceBlue;
                HomePanel.BackColor = Color.AliceBlue;
            }
        }
        private void HomePanel_MouseClick(object sender, MouseEventArgs e)
        {
            selectpanel("Home");
            loadform(new HomeForm());
        }

        private void CategoryPanel_MouseClick(object sender, MouseEventArgs e)
        {
            selectpanel("Category");
        }

        private void ProfilePanel_MouseClick(object sender, MouseEventArgs e)
        {
            selectpanel("Profile");
        }

        private void AboutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            selectpanel("about");
        }

        private void HomeText_Click(object sender, EventArgs e)
        {
            selectpanel("Home");
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            selectpanel("Category");
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            selectpanel("Profile");
        }

        private void Aboutus_Click(object sender, EventArgs e)
        {
            selectpanel("about");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            selectpanel("Home");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectpanel("Category");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selectpanel("Profile");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selectpanel("about");
        }

        //end selction panel


        // Fill dashboard forms

        public void loadform(object Form)
        {
        
                if (this.FIllDashPanel.Controls.Count > 0)
                this.FIllDashPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.FIllDashPanel.Controls.Add(f);
            this.FIllDashPanel.Tag = f;
            f.Show();
        }

    

        private void closeDash_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
