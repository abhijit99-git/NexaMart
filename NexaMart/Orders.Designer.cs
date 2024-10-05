namespace NexaMart
{
    partial class Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchCustomerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ordEXIT = new System.Windows.Forms.Button();
            this.ordDelete = new System.Windows.Forms.Button();
            this.ordUPDATE = new System.Windows.Forms.Button();
            this.ordADD = new System.Windows.Forms.Button();
            this.orderTot = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.categorySelect = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.StatusSelect = new System.Windows.Forms.ComboBox();
            this.ProductSelect = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.DateTimePicker();
            this.orderQTY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.orderCustID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OrdID = new System.Windows.Forms.TextBox();
            this.LineColored = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameProfile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderGrid
            // 
            this.OrderGrid.AllowUserToResizeColumns = false;
            this.OrderGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(223)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(194)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.OrderGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.OrderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.OrderGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(194)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.OrderGrid.ColumnHeadersHeight = 40;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(194)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.OrderGrid.EnableHeadersVisualStyles = false;
            this.OrderGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.OrderGrid.Location = new System.Drawing.Point(457, 13);
            this.OrderGrid.MultiSelect = false;
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.ReadOnly = true;
            this.OrderGrid.RowHeadersVisible = false;
            this.OrderGrid.RowHeadersWidth = 51;
            this.OrderGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrderGrid.RowTemplate.Height = 40;
            this.OrderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGrid.Size = new System.Drawing.Size(685, 728);
            this.OrderGrid.TabIndex = 14;
            this.OrderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGrid_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.SearchCustomerID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ordEXIT);
            this.panel2.Controls.Add(this.ordDelete);
            this.panel2.Controls.Add(this.ordUPDATE);
            this.panel2.Controls.Add(this.ordADD);
            this.panel2.Controls.Add(this.orderTot);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(10, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 265);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(390, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // SearchCustomerID
            // 
            this.SearchCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchCustomerID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchCustomerID.Location = new System.Drawing.Point(126, 18);
            this.SearchCustomerID.Name = "SearchCustomerID";
            this.SearchCustomerID.Size = new System.Drawing.Size(258, 27);
            this.SearchCustomerID.TabIndex = 46;
            this.SearchCustomerID.TextChanged += new System.EventHandler(this.SearchCustomerID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.label3.Location = new System.Drawing.Point(122, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "_________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(11, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "CUSTOMER ID";
            // 
            // ordEXIT
            // 
            this.ordEXIT.BackColor = System.Drawing.Color.Transparent;
            this.ordEXIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ordEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordEXIT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.ordEXIT.FlatAppearance.BorderSize = 2;
            this.ordEXIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.ordEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordEXIT.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordEXIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(126)))), ((int)(((byte)(139)))));
            this.ordEXIT.Location = new System.Drawing.Point(14, 205);
            this.ordEXIT.Name = "ordEXIT";
            this.ordEXIT.Size = new System.Drawing.Size(406, 41);
            this.ordEXIT.TabIndex = 9;
            this.ordEXIT.Text = "EXIT";
            this.ordEXIT.UseVisualStyleBackColor = false;
            this.ordEXIT.Click += new System.EventHandler(this.ordEXIT_Click);
            // 
            // ordDelete
            // 
            this.ordDelete.BackColor = System.Drawing.Color.Transparent;
            this.ordDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ordDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.ordDelete.FlatAppearance.BorderSize = 2;
            this.ordDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.ordDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordDelete.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(126)))), ((int)(((byte)(139)))));
            this.ordDelete.Location = new System.Drawing.Point(320, 134);
            this.ordDelete.Name = "ordDelete";
            this.ordDelete.Size = new System.Drawing.Size(100, 46);
            this.ordDelete.TabIndex = 7;
            this.ordDelete.Text = "DELETE";
            this.ordDelete.UseVisualStyleBackColor = false;
            this.ordDelete.Visible = false;
            this.ordDelete.Click += new System.EventHandler(this.ordDelete_Click);
            // 
            // ordUPDATE
            // 
            this.ordUPDATE.BackColor = System.Drawing.Color.Transparent;
            this.ordUPDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ordUPDATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordUPDATE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.ordUPDATE.FlatAppearance.BorderSize = 2;
            this.ordUPDATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.ordUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordUPDATE.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordUPDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(126)))), ((int)(((byte)(139)))));
            this.ordUPDATE.Location = new System.Drawing.Point(250, 134);
            this.ordUPDATE.Name = "ordUPDATE";
            this.ordUPDATE.Size = new System.Drawing.Size(105, 46);
            this.ordUPDATE.TabIndex = 6;
            this.ordUPDATE.Text = "UPDATE";
            this.ordUPDATE.UseVisualStyleBackColor = false;
            this.ordUPDATE.Click += new System.EventHandler(this.ordUPDATE_Click);
            // 
            // ordADD
            // 
            this.ordADD.BackColor = System.Drawing.Color.Transparent;
            this.ordADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ordADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordADD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.ordADD.FlatAppearance.BorderSize = 2;
            this.ordADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.ordADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordADD.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordADD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(126)))), ((int)(((byte)(139)))));
            this.ordADD.Location = new System.Drawing.Point(62, 134);
            this.ordADD.Name = "ordADD";
            this.ordADD.Size = new System.Drawing.Size(107, 46);
            this.ordADD.TabIndex = 5;
            this.ordADD.Text = "ADD";
            this.ordADD.UseVisualStyleBackColor = false;
            this.ordADD.Click += new System.EventHandler(this.ordADD_Click);
            // 
            // orderTot
            // 
            this.orderTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderTot.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderTot.Location = new System.Drawing.Point(126, 81);
            this.orderTot.Name = "orderTot";
            this.orderTot.ReadOnly = true;
            this.orderTot.Size = new System.Drawing.Size(258, 27);
            this.orderTot.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(64, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Total";
            // 
            // categorySelect
            // 
            this.categorySelect.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(173)))), ((int)(((byte)(236)))));
            this.categorySelect.FormattingEnabled = true;
            this.categorySelect.Location = new System.Drawing.Point(43, 122);
            this.categorySelect.Name = "categorySelect";
            this.categorySelect.Size = new System.Drawing.Size(349, 28);
            this.categorySelect.TabIndex = 8;
            this.categorySelect.Text = "Select Category";
            this.categorySelect.SelectedIndexChanged += new System.EventHandler(this.categorySelect_SelectedIndexChanged);
            this.categorySelect.DropDownClosed += new System.EventHandler(this.empRole_DropDownClosed);
            this.categorySelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empRole_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.StatusSelect);
            this.panel1.Controls.Add(this.ProductSelect);
            this.panel1.Controls.Add(this.categorySelect);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.OrderDate);
            this.panel1.Controls.Add(this.orderQTY);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.orderCustID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.OrdID);
            this.panel1.Controls.Add(this.LineColored);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.usernameProfile);
            this.panel1.Location = new System.Drawing.Point(10, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 382);
            this.panel1.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(368, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "RESET";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // StatusSelect
            // 
            this.StatusSelect.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(173)))), ((int)(((byte)(236)))));
            this.StatusSelect.FormattingEnabled = true;
            this.StatusSelect.Items.AddRange(new object[] {
            "PAID",
            "PENDING"});
            this.StatusSelect.Location = new System.Drawing.Point(147, 311);
            this.StatusSelect.Name = "StatusSelect";
            this.StatusSelect.Size = new System.Drawing.Size(245, 28);
            this.StatusSelect.TabIndex = 33;
            this.StatusSelect.Text = "Select Status";
            this.StatusSelect.SelectedIndexChanged += new System.EventHandler(this.StatusSelect_SelectedIndexChanged);
            this.StatusSelect.DropDownClosed += new System.EventHandler(this.StatusSelect_DropDownClosed);
            this.StatusSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StatusSelect_KeyPress);
            // 
            // ProductSelect
            // 
            this.ProductSelect.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(173)))), ((int)(((byte)(236)))));
            this.ProductSelect.FormattingEnabled = true;
            this.ProductSelect.Location = new System.Drawing.Point(43, 172);
            this.ProductSelect.Name = "ProductSelect";
            this.ProductSelect.Size = new System.Drawing.Size(349, 28);
            this.ProductSelect.TabIndex = 32;
            this.ProductSelect.Text = "Select Product";
            this.ProductSelect.SelectedIndexChanged += new System.EventHandler(this.ProductSelect_SelectedIndexChanged);
            this.ProductSelect.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
            this.ProductSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(39, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Status";
            // 
            // OrderDate
            // 
            this.OrderDate.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDate.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.OrderDate.Location = new System.Drawing.Point(147, 227);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(237, 22);
            this.OrderDate.TabIndex = 25;
            // 
            // orderQTY
            // 
            this.orderQTY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderQTY.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderQTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderQTY.Location = new System.Drawing.Point(147, 267);
            this.orderQTY.Name = "orderQTY";
            this.orderQTY.Size = new System.Drawing.Size(258, 20);
            this.orderQTY.TabIndex = 24;
            this.orderQTY.TextChanged += new System.EventHandler(this.orderQTY_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(143, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "________________________________________";
            // 
            // orderCustID
            // 
            this.orderCustID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderCustID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCustID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderCustID.Location = new System.Drawing.Point(147, 72);
            this.orderCustID.Name = "orderCustID";
            this.orderCustID.Size = new System.Drawing.Size(258, 20);
            this.orderCustID.TabIndex = 18;
            this.orderCustID.TextChanged += new System.EventHandler(this.orderCustID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(143, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "________________________________________";
            // 
            // OrdID
            // 
            this.OrdID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OrdID.Location = new System.Drawing.Point(147, 20);
            this.OrdID.Name = "OrdID";
            this.OrdID.ReadOnly = true;
            this.OrdID.Size = new System.Drawing.Size(258, 20);
            this.OrdID.TabIndex = 16;
            // 
            // LineColored
            // 
            this.LineColored.AutoSize = true;
            this.LineColored.BackColor = System.Drawing.Color.Transparent;
            this.LineColored.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineColored.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LineColored.Location = new System.Drawing.Point(143, 29);
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
            this.label5.Location = new System.Drawing.Point(39, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "QTY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(39, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Order Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer ID";
            // 
            // usernameProfile
            // 
            this.usernameProfile.AutoSize = true;
            this.usernameProfile.BackColor = System.Drawing.Color.Transparent;
            this.usernameProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameProfile.Location = new System.Drawing.Point(39, 20);
            this.usernameProfile.Name = "usernameProfile";
            this.usernameProfile.Size = new System.Drawing.Size(24, 20);
            this.usernameProfile.TabIndex = 5;
            this.usernameProfile.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "MANAGE ORDERS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 755);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OrderGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ordEXIT;
        private System.Windows.Forms.Button ordDelete;
        private System.Windows.Forms.Button ordUPDATE;
        private System.Windows.Forms.Button ordADD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker OrderDate;
        private System.Windows.Forms.TextBox orderQTY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox orderCustID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OrdID;
        private System.Windows.Forms.Label LineColored;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductSelect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox orderTot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox StatusSelect;
        public System.Windows.Forms.ComboBox categorySelect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}