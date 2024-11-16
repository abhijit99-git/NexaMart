namespace NexaMart
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchCustomerName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.empHireDate = new System.Windows.Forms.DateTimePicker();
            this.empSalary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.empContact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.TextBox();
            this.LineColored = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameProfile = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmpExit = new System.Windows.Forms.Button();
            this.empRole = new System.Windows.Forms.ComboBox();
            this.empDelete = new System.Windows.Forms.Button();
            this.empUpdate = new System.Windows.Forms.Button();
            this.EmployeesGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // empAdd
            // 
            this.empAdd.BackColor = System.Drawing.Color.Transparent;
            this.empAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.empAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(156)))), ((int)(((byte)(113)))));
            this.empAdd.FlatAppearance.BorderSize = 2;
            this.empAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(156)))), ((int)(((byte)(113)))));
            this.empAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empAdd.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.empAdd.Location = new System.Drawing.Point(12, 98);
            this.empAdd.Name = "empAdd";
            this.empAdd.Size = new System.Drawing.Size(182, 46);
            this.empAdd.TabIndex = 5;
            this.empAdd.Text = "ADD";
            this.empAdd.UseVisualStyleBackColor = false;
            this.empAdd.Click += new System.EventHandler(this.empAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "MANAGE EMPLOYEES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.SearchCustomerName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.empHireDate);
            this.panel1.Controls.Add(this.empSalary);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.empContact);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.empName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.empID);
            this.panel1.Controls.Add(this.LineColored);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.usernameProfile);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 382);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(372, 301);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // SearchCustomerName
            // 
            this.SearchCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchCustomerName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchCustomerName.Location = new System.Drawing.Point(108, 301);
            this.SearchCustomerName.Name = "SearchCustomerName";
            this.SearchCustomerName.Size = new System.Drawing.Size(258, 27);
            this.SearchCustomerName.TabIndex = 50;
            this.SearchCustomerName.TextChanged += new System.EventHandler(this.SearchCustomerName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.label10.Location = new System.Drawing.Point(104, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "_________________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(45, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "NAME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(368, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "RESET";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // empHireDate
            // 
            this.empHireDate.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empHireDate.Location = new System.Drawing.Point(139, 207);
            this.empHireDate.Name = "empHireDate";
            this.empHireDate.Size = new System.Drawing.Size(237, 22);
            this.empHireDate.TabIndex = 25;
            // 
            // empSalary
            // 
            this.empSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empSalary.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empSalary.Location = new System.Drawing.Point(139, 257);
            this.empSalary.Name = "empSalary";
            this.empSalary.Size = new System.Drawing.Size(258, 20);
            this.empSalary.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.label9.Location = new System.Drawing.Point(135, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "________________________________________";
            // 
            // empContact
            // 
            this.empContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empContact.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empContact.Location = new System.Drawing.Point(139, 157);
            this.empContact.Name = "empContact";
            this.empContact.Size = new System.Drawing.Size(258, 20);
            this.empContact.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(135, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "________________________________________";
            // 
            // empName
            // 
            this.empName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empName.Location = new System.Drawing.Point(139, 102);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(258, 20);
            this.empName.TabIndex = 18;
            this.empName.TextChanged += new System.EventHandler(this.empName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(135, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "________________________________________";
            // 
            // empID
            // 
            this.empID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empID.Location = new System.Drawing.Point(139, 50);
            this.empID.Name = "empID";
            this.empID.ReadOnly = true;
            this.empID.Size = new System.Drawing.Size(258, 20);
            this.empID.TabIndex = 16;
            // 
            // LineColored
            // 
            this.LineColored.AutoSize = true;
            this.LineColored.BackColor = System.Drawing.Color.Transparent;
            this.LineColored.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineColored.ForeColor = System.Drawing.Color.SeaGreen;
            this.LineColored.Location = new System.Drawing.Point(135, 59);
            this.LineColored.Name = "LineColored";
            this.LineColored.Size = new System.Drawing.Size(249, 20);
            this.LineColored.TabIndex = 11;
            this.LineColored.Text = "________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(45, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(45, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hire Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(45, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(45, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // usernameProfile
            // 
            this.usernameProfile.AutoSize = true;
            this.usernameProfile.BackColor = System.Drawing.Color.Transparent;
            this.usernameProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameProfile.Location = new System.Drawing.Point(45, 50);
            this.usernameProfile.Name = "usernameProfile";
            this.usernameProfile.Size = new System.Drawing.Size(24, 20);
            this.usernameProfile.TabIndex = 5;
            this.usernameProfile.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.EmpExit);
            this.panel2.Controls.Add(this.empRole);
            this.panel2.Controls.Add(this.empDelete);
            this.panel2.Controls.Add(this.empUpdate);
            this.panel2.Controls.Add(this.empAdd);
            this.panel2.Location = new System.Drawing.Point(12, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 227);
            this.panel2.TabIndex = 8;
            // 
            // EmpExit
            // 
            this.EmpExit.BackColor = System.Drawing.Color.Transparent;
            this.EmpExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EmpExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(156)))), ((int)(((byte)(113)))));
            this.EmpExit.FlatAppearance.BorderSize = 2;
            this.EmpExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(156)))), ((int)(((byte)(113)))));
            this.EmpExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpExit.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpExit.ForeColor = System.Drawing.Color.DarkGreen;
            this.EmpExit.Location = new System.Drawing.Point(12, 169);
            this.EmpExit.Name = "EmpExit";
            this.EmpExit.Size = new System.Drawing.Size(406, 41);
            this.EmpExit.TabIndex = 9;
            this.EmpExit.Text = "EXIT";
            this.EmpExit.UseVisualStyleBackColor = false;
            this.EmpExit.Click += new System.EventHandler(this.EmpExit_Click);
            // 
            // empRole
            // 
            this.empRole.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRole.ForeColor = System.Drawing.Color.SeaGreen;
            this.empRole.FormattingEnabled = true;
            this.empRole.Items.AddRange(new object[] {
            "Cashier",
            "Cleaning Staff",
            "Inventory Staff",
            "Customer Service Staff"});
            this.empRole.Location = new System.Drawing.Point(72, 35);
            this.empRole.Name = "empRole";
            this.empRole.Size = new System.Drawing.Size(292, 31);
            this.empRole.TabIndex = 8;
            this.empRole.Text = "Select Role";
            this.empRole.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
            this.empRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // empDelete
            // 
            this.empDelete.BackColor = System.Drawing.Color.Transparent;
            this.empDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.empDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empDelete.Enabled = false;
            this.empDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(156)))), ((int)(((byte)(113)))));
            this.empDelete.FlatAppearance.BorderSize = 2;
            this.empDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(156)))), ((int)(((byte)(113)))));
            this.empDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empDelete.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empDelete.ForeColor = System.Drawing.Color.DarkGreen;
            this.empDelete.Location = new System.Drawing.Point(165, 98);
            this.empDelete.Name = "empDelete";
            this.empDelete.Size = new System.Drawing.Size(100, 46);
            this.empDelete.TabIndex = 7;
            this.empDelete.Text = "DELETE";
            this.empDelete.UseVisualStyleBackColor = false;
            this.empDelete.Visible = false;
            this.empDelete.Click += new System.EventHandler(this.empDelete_Click);
            // 
            // empUpdate
            // 
            this.empUpdate.BackColor = System.Drawing.Color.Transparent;
            this.empUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.empUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(156)))), ((int)(((byte)(113)))));
            this.empUpdate.FlatAppearance.BorderSize = 2;
            this.empUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(156)))), ((int)(((byte)(113)))));
            this.empUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empUpdate.ForeColor = System.Drawing.Color.DarkGreen;
            this.empUpdate.Location = new System.Drawing.Point(237, 98);
            this.empUpdate.Name = "empUpdate";
            this.empUpdate.Size = new System.Drawing.Size(181, 46);
            this.empUpdate.TabIndex = 6;
            this.empUpdate.Text = "UPDATE";
            this.empUpdate.UseVisualStyleBackColor = false;
            this.empUpdate.Click += new System.EventHandler(this.empUpdate_Click);
            // 
            // EmployeesGrid
            // 
            this.EmployeesGrid.AllowUserToResizeColumns = false;
            this.EmployeesGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(190)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.EmployeesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(222)))), ((int)(((byte)(190)))));
            this.EmployeesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EmployeesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeesGrid.ColumnHeadersHeight = 40;
            this.EmployeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeesGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(222)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(190)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeesGrid.EnableHeadersVisualStyles = false;
            this.EmployeesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(222)))), ((int)(((byte)(190)))));
            this.EmployeesGrid.Location = new System.Drawing.Point(454, 15);
            this.EmployeesGrid.MultiSelect = false;
            this.EmployeesGrid.Name = "EmployeesGrid";
            this.EmployeesGrid.ReadOnly = true;
            this.EmployeesGrid.RowHeadersVisible = false;
            this.EmployeesGrid.RowHeadersWidth = 51;
            this.EmployeesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EmployeesGrid.RowTemplate.Height = 40;
            this.EmployeesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesGrid.Size = new System.Drawing.Size(685, 728);
            this.EmployeesGrid.TabIndex = 9;
            this.EmployeesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesGrid_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 755);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EmployeesGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button empAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox empRole;
        private System.Windows.Forms.Button empDelete;
        private System.Windows.Forms.Button empUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameProfile;
        private System.Windows.Forms.TextBox empID;
        private System.Windows.Forms.Label LineColored;
        private System.Windows.Forms.TextBox empSalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox empContact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker empHireDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EmpExit;
        public System.Windows.Forms.DataGridView EmployeesGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchCustomerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}