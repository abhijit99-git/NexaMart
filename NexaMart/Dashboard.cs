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


        //  Object declaration section 
       public HomeForm home;
        Form1 f = new Form1();

        public Employees emp = new Employees();
        public Billing bill= new Billing();
        public Suppliers sup= new Suppliers();
        public Orders order= new Orders();
        public Customers cust= new Customers();
        public Prodcuts prod = new Prodcuts();

        public bool manageCatBtn=false;

        //section end

        public  string Adminname { get; set; }
        public  string Adminpass { get; set; }

        ProfileForm pf;

        bool BarExpand;
        public Dashboard()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            emp.setDash(this);
            order.SetDashInOrder(this);
            prod.SetDashInProduct(this);
            sup.SetDashInSupplier(this);
            cust.SetDashInCustomer(this);
            bill.SetDashInBilling(this);
            


        }

        public void sethome(HomeForm h)
        {
            home = h;
        }
       
        //MoveForm
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
        //EndMoveForm

     

        private Form activeForm = null;

        public bool employeeduty = false;
        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
     
            int leftGap = 10; 
            int rightGap = 20; 

            if (BarExpand)
            {
                sidebar.Width -= 20;
                StraigthLine.Visible = false;

                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebar.Width = sidebar.MinimumSize.Width;
                    FIllDashPanel.Location = new Point(sidebar.Width + leftGap, FIllDashPanel.Location.Y);
                    FIllDashPanel.Width = this.Width - sidebar.Width - leftGap;

                    if (homepanelclicked == true)
                    {
                        loadHomeOption();
                        if (employeeduty)
                        {
                            loadform(new EmployeesDuty(this));
                        }
                    }
                    else if (categoripanelclicked == true)
                    {
                        if (manageCatBtn == true)
                        {
                            loadform(new ManageCategory(this));
                        }
                        else
                        {
                            loadform(new CategoriesForm(this));
                        }
                    }
                    else if (profilepanelclicked == true)
                    {
                        loadform(pf);
                    }
                    else if (aboutpanelclicked == true)
                    {
                        loadform(new AboutForm());
                    }
                    else if (inventorypanelclicked == true)
                    {
                        loadform(new Inventory());
                    }
                    else if (Dashboardpanelclicked == true)
                    {
                        loadform(new DashboardAnalytics());
                    }
                    else if (Deliverypanelclicked == true)
                    {
                        loadform(new Delivery());
                    }
                    else if (Reportspanelclicked == true)
                    {
                        loadform(new Reports());
                    }

                    BarExpand = false;
                    FIllDashPanel.Padding = new Padding(80, 0, 0, 0);
                    SidebarTimer.Stop();

                }
                
               
            }
            else
            {
                sidebar.Width += 20;
                StraigthLine.Visible = true;

                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebar.Width = sidebar.MaximumSize.Width;
                    FIllDashPanel.Location = new Point(sidebar.Width + leftGap, FIllDashPanel.Location.Y);
                    FIllDashPanel.Width = this.Width - sidebar.Width - leftGap - rightGap;
                    if (homepanelclicked == true)
                    {
                        loadHomeOption();
                       
                        if (employeeduty)
                        {
                            loadform(new EmployeesDuty(this));
                        }
                    }
                    else if (categoripanelclicked == true)
                    {
                        if (manageCatBtn == true)
                        {
                            loadform(new ManageCategory(this));
                        }
                        else
                        {
                            loadform(new CategoriesForm(this));
                        }
                    }
                    else if (profilepanelclicked == true)
                    {
                        loadform(pf);
                    }
                    else if (aboutpanelclicked == true)
                    {
                        loadform(new AboutForm());
                    }
                    else if (inventorypanelclicked == true)
                    {
                        loadform(new Inventory());
                    }
                    else if (Dashboardpanelclicked == true)
                    {
                        loadform(new DashboardAnalytics());
                    }
                    else if (Deliverypanelclicked == true)
                    {
                        loadform(new Delivery());
                    }
                    else if (Reportspanelclicked == true)
                    {
                        loadform(new Reports());
                    }

                    BarExpand = true;
                    FIllDashPanel.Padding = new Padding(0, 0, 0, 0);
                    SidebarTimer.Stop();
                }
            }

            if (activeForm != null)
            {
                AdjustFormLayout();
            }
        }


     

        private void AdjustFormLayout()
        {
           
            if (activeForm != null)
            {
                activeForm.Refresh(); 
            }
        }

        public void loadform(object formObject)
        {
            Form newForm = formObject as Form;
            if (newForm == null) return;

           
            if (activeForm != null && activeForm.GetType() == newForm.GetType())
            {
                return;
            }

           
            if (activeForm != null)
            {
                activeForm.Hide();
            }

            activeForm = newForm;
            activeForm.TopLevel = false;
            activeForm.Dock = DockStyle.Fill;
            this.FIllDashPanel.Controls.Add(activeForm);
            this.FIllDashPanel.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
        }

        // Checking true and false function for loading Home Options
       public bool isemployees=false;
       public bool issuupliers=false;
       public bool isbilling=false;
       public bool iscustomers = false;
       public bool isproduct = false;
       public bool isorders = false;
        public void loadHomeOption()
        {
            if (isemployees == true)
            {
                loadform(emp);
            }
            else if (issuupliers == true)
            {
                loadform(sup);
            }
            else if (isorders == true)
            {
                loadform(order);
            }
            else if (iscustomers == true)
            {
                loadform(cust);
            }
            else if (isproduct == true)
            {
                loadform(prod);
            }
            else if (isbilling == true)
            {
                loadform(bill);
            }
            else
            {
                loadform(home);
            }
        } 
            
        // end load home home options 


        private void dashMenu_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
     
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            pf = new ProfileForm(Adminname, Adminpass);
            AdminName.Text = Adminname;
            selectpanel("Home");
            loadform(home);



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
           
            label4.ForeColor = Color.FromArgb(224, 224,244);
        }

        private void Aboutus_MouseHover(object sender, EventArgs e)
        {
            Aboutus.ForeColor = Color.SeaGreen;
        }

        private void Aboutus_MouseLeave(object sender, EventArgs e)
        {
            if (aboutpanelclicked != true)
            {
                Aboutus.ForeColor = Color.FromArgb(224, 224, 244);
            }
            

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
            if (categoripanelclicked != true)
            {
                Categories.ForeColor = Color.FromArgb(224, 224, 244);
            }
           
        }

        private void HomeText_MouseHover(object sender, EventArgs e)
        {
            HomeText.ForeColor = Color.SeaGreen;
        }

        private void HomeText_MouseLeave(object sender, EventArgs e)
        {
            if (homepanelclicked != true)
            {
                HomeText.ForeColor = Color.FromArgb(224, 224, 244);
            }
           
        }

        private void Profile_MouseLeave(object sender, EventArgs e)
        {
            if (profilepanelclicked != true)
            {
                Profile.ForeColor = Color.FromArgb(224, 224, 244);
            }
            
        }


        // mouse event end  
        bool homepanelclicked = false;
        bool categoripanelclicked = false;
        bool profilepanelclicked = false;
        bool aboutpanelclicked = false;
        bool inventorypanelclicked = false;
        bool Dashboardpanelclicked = false;
        bool Deliverypanelclicked = false;
        bool Reportspanelclicked = false;
        void selectpanel(String panel)
        {
            if (panel == "Home")
            {
                HomePanel.BackColor = Color.FromArgb(206, 237, 200);
                CategoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                ProfilePanel.BackColor = Color.FromArgb(34, 45, 51);
                AboutPanel.BackColor = Color.FromArgb(34, 45, 51);
                InventoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                DashboardPanel.BackColor = Color.FromArgb(34, 45, 51);
                reportPanel.BackColor = Color.FromArgb(34, 45, 51);
                deliveryPanel.BackColor = Color.FromArgb(34, 45, 51);
                HomeText.ForeColor = Color.SeaGreen;
                Categories.ForeColor= Color.FromArgb(224, 224, 244);
                Aboutus.ForeColor= Color.FromArgb(224, 224, 244);
                Profile.ForeColor= Color.FromArgb(224, 224, 244);
                Inventory.ForeColor = Color.FromArgb(224, 224, 244);
                Dashboardlabel.ForeColor = Color.FromArgb(224, 224, 244);
                deliverytext.ForeColor = Color.FromArgb(224, 224, 244);
                reportxt.ForeColor = Color.FromArgb(224, 224, 244);

                homepanelclicked = true;
                categoripanelclicked = false;
                profilepanelclicked = false;
                aboutpanelclicked = false;
                inventorypanelclicked = false;
                Dashboardpanelclicked = false;
                Deliverypanelclicked = false;
                Reportspanelclicked = false;

            }
            else if (panel == "Category")
            {
                CategoryPanel.BackColor = Color.FromArgb(206, 237, 200);
                HomePanel.BackColor = Color.FromArgb(34, 45, 51);
                ProfilePanel.BackColor = Color.FromArgb(34, 45, 51);
                AboutPanel.BackColor = Color.FromArgb(34, 45, 51);
                InventoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                DashboardPanel.BackColor = Color.FromArgb(34, 45, 51);
                reportPanel.BackColor = Color.FromArgb(34, 45, 51);
                deliveryPanel.BackColor = Color.FromArgb(34, 45, 51);
                Categories.ForeColor = Color.SeaGreen;
                HomeText.ForeColor = Color.FromArgb(224, 224, 244);
                Aboutus.ForeColor = Color.FromArgb(224, 224, 244);
                Profile.ForeColor = Color.FromArgb(224, 224, 244);
                Inventory.ForeColor = Color.FromArgb(224, 224, 244);
                Dashboardlabel.ForeColor = Color.FromArgb(224, 224, 244);
                deliverytext.ForeColor = Color.FromArgb(224, 224, 244);
                reportxt.ForeColor = Color.FromArgb(224, 224, 244);

                homepanelclicked = false;
                categoripanelclicked = true;
                profilepanelclicked = false;
                aboutpanelclicked = false;
                inventorypanelclicked = false;
                Dashboardpanelclicked = false;
                Deliverypanelclicked = false;
                Reportspanelclicked = false;

            }
            else if (panel == "Profile")
            {
                ProfilePanel.BackColor = Color.FromArgb(206, 237, 200);
                CategoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                HomePanel.BackColor = Color.FromArgb(34, 45, 51);
                AboutPanel.BackColor = Color.FromArgb(34, 45, 51);
                InventoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                DashboardPanel.BackColor = Color.FromArgb(34, 45, 51);
                reportPanel.BackColor = Color.FromArgb(34, 45, 51);
                deliveryPanel.BackColor = Color.FromArgb(34, 45, 51);
                Profile.ForeColor = Color.SeaGreen;
                Categories.ForeColor = Color.FromArgb(224, 224, 244);
                Aboutus.ForeColor = Color.FromArgb(224, 224, 244);
                HomeText.ForeColor = Color.FromArgb(224, 224, 244);
                Inventory.ForeColor = Color.FromArgb(224, 224, 244);
                Dashboardlabel.ForeColor = Color.FromArgb(224, 224, 244);
                deliverytext.ForeColor = Color.FromArgb(224, 224, 244);
                reportxt.ForeColor = Color.FromArgb(224, 224, 244);

                homepanelclicked = false;
                categoripanelclicked = false;
                profilepanelclicked = true;
                aboutpanelclicked = false;
                inventorypanelclicked = false;
                Dashboardpanelclicked = false;
                Deliverypanelclicked = false;
                Reportspanelclicked = false;
            }
            else if (panel == "about")
            {
                AboutPanel.BackColor = Color.FromArgb(206, 237, 200);
                CategoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                ProfilePanel.BackColor = Color.FromArgb(34, 45, 51);
                HomePanel.BackColor = Color.FromArgb(34, 45, 51);
                InventoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                DashboardPanel.BackColor = Color.FromArgb(34, 45, 51);
                reportPanel.BackColor = Color.FromArgb(34, 45, 51);
                deliveryPanel.BackColor = Color.FromArgb(34, 45, 51);
                Aboutus.ForeColor = Color.SeaGreen;
                Categories.ForeColor = Color.FromArgb(224, 224, 244);
                HomeText.ForeColor = Color.FromArgb(224, 224, 244);
                Profile.ForeColor = Color.FromArgb(224, 224, 244);
                Inventory.ForeColor = Color.FromArgb(224, 224, 244);
                Dashboardlabel.ForeColor = Color.FromArgb(224, 224, 244);
                deliverytext.ForeColor = Color.FromArgb(224, 224, 244);
                reportxt.ForeColor = Color.FromArgb(224, 224, 244);

                homepanelclicked = false;
                categoripanelclicked = false;
                profilepanelclicked = false;
                aboutpanelclicked = true;
                inventorypanelclicked = false;
                Dashboardpanelclicked = false;
                Deliverypanelclicked = false;
                Reportspanelclicked = false;

            }
            else if (panel == "inventory")
            {
                InventoryPanel.BackColor = Color.FromArgb(206, 237, 200);
                CategoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                ProfilePanel.BackColor = Color.FromArgb(34, 45, 51);
                HomePanel.BackColor = Color.FromArgb(34, 45, 51);
                AboutPanel.BackColor = Color.FromArgb(34, 45, 51);
                DashboardPanel.BackColor = Color.FromArgb(34, 45, 51);
                reportPanel.BackColor = Color.FromArgb(34, 45, 51);
                deliveryPanel.BackColor = Color.FromArgb(34, 45, 51);
                Inventory.ForeColor = Color.SeaGreen;
                Categories.ForeColor = Color.FromArgb(224, 224, 244);
                HomeText.ForeColor = Color.FromArgb(224, 224, 244);
                Profile.ForeColor = Color.FromArgb(224, 224, 244);
                Aboutus.ForeColor = Color.FromArgb(224, 224, 244);
                Dashboardlabel.ForeColor = Color.FromArgb(224, 224, 244);
                deliverytext.ForeColor = Color.FromArgb(224, 224, 244);
                reportxt.ForeColor = Color.FromArgb(224, 224, 244);

                homepanelclicked = false;
                categoripanelclicked = false;
                profilepanelclicked = false;
                aboutpanelclicked = false;
                inventorypanelclicked = true;
                Dashboardpanelclicked = false;
                Deliverypanelclicked = false;
                Reportspanelclicked = false;

            }
            else if (panel == "dashboard")
            {
                DashboardPanel.BackColor = Color.FromArgb(206, 237, 200);
                CategoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                ProfilePanel.BackColor = Color.FromArgb(34, 45, 51);
                HomePanel.BackColor = Color.FromArgb(34, 45, 51);
                AboutPanel.BackColor = Color.FromArgb(34, 45, 51);
                InventoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                reportPanel.BackColor = Color.FromArgb(34, 45, 51);
                deliveryPanel.BackColor = Color.FromArgb(34, 45, 51);
                Dashboardlabel.ForeColor = Color.SeaGreen;
                Categories.ForeColor = Color.FromArgb(224, 224, 244);
                HomeText.ForeColor = Color.FromArgb(224, 224, 244);
                Profile.ForeColor = Color.FromArgb(224, 224, 244);
                Inventory.ForeColor = Color.FromArgb(224, 224, 244);
                Aboutus.ForeColor = Color.FromArgb(224, 224, 244);
                deliverytext.ForeColor = Color.FromArgb(224, 224, 244);
                reportxt.ForeColor = Color.FromArgb(224, 224, 244);

                homepanelclicked = false;
                categoripanelclicked = false;
                profilepanelclicked = false;
                aboutpanelclicked = false;
                inventorypanelclicked = false;
                Dashboardpanelclicked = true;
                Deliverypanelclicked = false;
                Reportspanelclicked = false;

            }
            else if (panel == "delivery")
            {
                deliveryPanel.BackColor = Color.FromArgb(206, 237, 200);
                CategoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                ProfilePanel.BackColor = Color.FromArgb(34, 45, 51);
                HomePanel.BackColor = Color.FromArgb(34, 45, 51);
                AboutPanel.BackColor = Color.FromArgb(34, 45, 51);
                InventoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                reportPanel.BackColor = Color.FromArgb(34, 45, 51);
                DashboardPanel.BackColor = Color.FromArgb(34, 45, 51);
                deliverytext.ForeColor = Color.SeaGreen;
                Categories.ForeColor = Color.FromArgb(224, 224, 244);
                HomeText.ForeColor = Color.FromArgb(224, 224, 244);
                Profile.ForeColor = Color.FromArgb(224, 224, 244);
                Inventory.ForeColor = Color.FromArgb(224, 224, 244);
                Aboutus.ForeColor = Color.FromArgb(224, 224, 244);
                reportxt.ForeColor = Color.FromArgb(224, 224, 244);
                Dashboardlabel.ForeColor = Color.FromArgb(224, 224, 244);

                homepanelclicked = false;
                categoripanelclicked = false;
                profilepanelclicked = false;
                aboutpanelclicked = false;
                inventorypanelclicked = false;
                Dashboardpanelclicked = false;
                Deliverypanelclicked = true;
                Reportspanelclicked = false;

            }
            else if (panel == "reports")
            {
                reportPanel.BackColor = Color.FromArgb(206, 237, 200);
                CategoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                ProfilePanel.BackColor = Color.FromArgb(34, 45, 51);
                HomePanel.BackColor = Color.FromArgb(34, 45, 51);
                AboutPanel.BackColor = Color.FromArgb(34, 45, 51);
                InventoryPanel.BackColor = Color.FromArgb(34, 45, 51);
                DashboardPanel.BackColor = Color.FromArgb(34, 45, 51);
                deliveryPanel.BackColor = Color.FromArgb(34, 45, 51);
                reportxt.ForeColor = Color.SeaGreen;
                Categories.ForeColor = Color.FromArgb(224, 224, 244);
                HomeText.ForeColor = Color.FromArgb(224, 224, 244);
                Profile.ForeColor = Color.FromArgb(224, 224, 244);
                Inventory.ForeColor = Color.FromArgb(224, 224, 244);
                Aboutus.ForeColor = Color.FromArgb(224, 224, 244);
                deliverytext.ForeColor = Color.FromArgb(224, 224, 244);
                Dashboardlabel.ForeColor = Color.FromArgb(224, 224, 244);

                homepanelclicked = false;
                categoripanelclicked = false;
                profilepanelclicked = false;
                aboutpanelclicked = false;
                inventorypanelclicked = false;
                Dashboardpanelclicked = false;
                Deliverypanelclicked = false;
                Reportspanelclicked = true;

            }
        }
        private void HomePanel_MouseClick(object sender, MouseEventArgs e)
        {

            loadHomeOption();

            selectpanel("Home");
            //loadform(home);
            
        }

        private void CategoryPanel_MouseClick(object sender, MouseEventArgs e)
        {
            selectpanel("Category");
            loadform(new CategoriesForm(this));
        }

        private void ProfilePanel_MouseClick(object sender, MouseEventArgs e)
        {
            selectpanel("Profile");
            loadform(pf);
        }

        private void AboutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            selectpanel("about");
            loadform(new AboutForm());
        }

        private void HomeText_Click(object sender, EventArgs e)
        {
            selectpanel("Home");
            loadHomeOption();
 
            //loadform(home);
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            selectpanel("Category");
            loadform(new CategoriesForm(this));
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            selectpanel("Profile");
            loadform(pf);
        }

        private void Aboutus_Click(object sender, EventArgs e)
        {
            selectpanel("about");
            loadform(new AboutForm());
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            selectpanel("Home");
            loadHomeOption();

            //loadform(home);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectpanel("Category");
            loadform(new CategoriesForm(this));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selectpanel("Profile");
            loadform(pf);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selectpanel("about");
            loadform(new AboutForm());
        }

        //end selction panel

        private void closeDash_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FIllDashPanel_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Inventory_MouseHover(object sender, EventArgs e)
        {
            Inventory.ForeColor = Color.SeaGreen;
        }

        private void Inventory_MouseLeave(object sender, EventArgs e)
        {
            if (inventorypanelclicked != true)
            {
                Inventory.ForeColor = Color.FromArgb(224, 224, 244);
            }
        }

        private void Dashboardlabel_MouseHover(object sender, EventArgs e)
        {
            Dashboardlabel.ForeColor = Color.SeaGreen;
        }

        private void Dashboardlabel_MouseLeave(object sender, EventArgs e)
        {
            if (Dashboardpanelclicked != true)
            {
                Dashboardlabel.ForeColor = Color.FromArgb(224, 224, 244);
            }
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            selectpanel("inventory");
            loadform(new Inventory());
        }

        private void Dashboardlabel_Click(object sender, EventArgs e)
        {
            selectpanel("dashboard");
            loadform(new DashboardAnalytics());
        }


        private void pictureBox11_Click(object sender, EventArgs e)
        {
            selectpanel("inventory");
            loadform(new Inventory());
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            selectpanel("dashboard");
            loadform(new DashboardAnalytics());
        }

        private void InventoryPanel_MouseClick(object sender, MouseEventArgs e)
        {
            selectpanel("inventory");
            loadform(new Inventory());
        }

        private void DashboardPanel_MouseClick(object sender, MouseEventArgs e)
        {
            selectpanel("dashboard");
            loadform(new DashboardAnalytics());
        }

        private void deliverytext_Click(object sender, EventArgs e)
        {
            selectpanel("delivery");
            loadform(new Delivery());
        }

        private void deliveryPanel_Click(object sender, EventArgs e)
        {
            selectpanel("delivery");
            loadform(new Delivery());
        }

        private void deliveryIcon_Click(object sender, EventArgs e)
        {
            selectpanel("delivery");
            loadform(new Delivery());
        }

        private void reportxt_Click(object sender, EventArgs e)
        {
            selectpanel("reports");
            loadform(new Reports());
        }

        private void reportPanel_Click(object sender, EventArgs e)
        {
            selectpanel("reports");
            loadform(new Reports());
        }

        private void reporticon_Click(object sender, EventArgs e)
        {
            selectpanel("reports");
            loadform(new Reports());
        }

        private void deliverytext_MouseHover(object sender, EventArgs e)
        {
            deliverytext.ForeColor = Color.SeaGreen;
        }

        private void deliverytext_MouseLeave(object sender, EventArgs e)
        {
            if (Deliverypanelclicked != true)
            {
                deliverytext.ForeColor = Color.FromArgb(224, 224, 244);
            }
        }

        private void reportxt_MouseHover(object sender, EventArgs e)
        {
            reportxt.ForeColor = Color.SeaGreen;
        }

        private void reportxt_MouseLeave(object sender, EventArgs e)
        {
            if (Reportspanelclicked != true)
            {
                reportxt.ForeColor = Color.FromArgb(224, 224, 244);
            }
        }
    }
}
