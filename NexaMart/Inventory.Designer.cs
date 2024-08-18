namespace NexaMart
{
    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.InventoryGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inventoryUPDATE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prodStock = new System.Windows.Forms.Label();
            this.SelectStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ResetInv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryGrid
            // 
            this.InventoryGrid.AllowUserToResizeColumns = false;
            this.InventoryGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(159)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(120)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.InventoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.InventoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(199)))), ((int)(((byte)(218)))));
            this.InventoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InventoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.InventoryGrid.ColumnHeadersHeight = 40;
            this.InventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.InventoryGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(199)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(120)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.InventoryGrid.EnableHeadersVisualStyles = false;
            this.InventoryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(199)))), ((int)(((byte)(218)))));
            this.InventoryGrid.Location = new System.Drawing.Point(12, 82);
            this.InventoryGrid.MultiSelect = false;
            this.InventoryGrid.Name = "InventoryGrid";
            this.InventoryGrid.ReadOnly = true;
            this.InventoryGrid.RowHeadersVisible = false;
            this.InventoryGrid.RowHeadersWidth = 51;
            this.InventoryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InventoryGrid.RowTemplate.Height = 40;
            this.InventoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryGrid.Size = new System.Drawing.Size(1127, 380);
            this.InventoryGrid.TabIndex = 34;
            this.InventoryGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryGrid_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ResetInv);
            this.panel2.Controls.Add(this.SelectStatus);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.stock);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.prodStock);
            this.panel2.Controls.Add(this.inventoryUPDATE);
            this.panel2.Location = new System.Drawing.Point(12, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 251);
            this.panel2.TabIndex = 33;
            // 
            // inventoryUPDATE
            // 
            this.inventoryUPDATE.BackColor = System.Drawing.Color.Transparent;
            this.inventoryUPDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.inventoryUPDATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryUPDATE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(159)))), ((int)(((byte)(193)))));
            this.inventoryUPDATE.FlatAppearance.BorderSize = 2;
            this.inventoryUPDATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(159)))), ((int)(((byte)(193)))));
            this.inventoryUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryUPDATE.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryUPDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            this.inventoryUPDATE.Location = new System.Drawing.Point(182, 148);
            this.inventoryUPDATE.Name = "inventoryUPDATE";
            this.inventoryUPDATE.Size = new System.Drawing.Size(381, 46);
            this.inventoryUPDATE.TabIndex = 6;
            this.inventoryUPDATE.Text = "UPDATE";
            this.inventoryUPDATE.UseVisualStyleBackColor = false;
            this.inventoryUPDATE.Click += new System.EventHandler(this.inventoryUPDATE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 27);
            this.label1.TabIndex = 31;
            this.label1.Text = "MANAGE INVENTORY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // stock
            // 
            this.stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stock.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stock.Location = new System.Drawing.Point(283, 63);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(258, 20);
            this.stock.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(120)))), ((int)(((byte)(167)))));
            this.label5.Location = new System.Drawing.Point(279, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "__________________________________________";
            // 
            // prodStock
            // 
            this.prodStock.AutoSize = true;
            this.prodStock.BackColor = System.Drawing.Color.Transparent;
            this.prodStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodStock.Location = new System.Drawing.Point(178, 65);
            this.prodStock.Name = "prodStock";
            this.prodStock.Size = new System.Drawing.Size(46, 20);
            this.prodStock.TabIndex = 25;
            this.prodStock.Text = "Stock";
            // 
            // SelectStatus
            // 
            this.SelectStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(120)))), ((int)(((byte)(167)))));
            this.SelectStatus.FormattingEnabled = true;
            this.SelectStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.SelectStatus.Location = new System.Drawing.Point(727, 65);
            this.SelectStatus.Name = "SelectStatus";
            this.SelectStatus.Size = new System.Drawing.Size(245, 28);
            this.SelectStatus.TabIndex = 29;
            this.SelectStatus.Text = "Select Status";
            this.SelectStatus.DropDownClosed += new System.EventHandler(this.SelectStatus_DropDownClosed);
            this.SelectStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectStatus_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(628, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Status";
            // 
            // ResetInv
            // 
            this.ResetInv.BackColor = System.Drawing.Color.Transparent;
            this.ResetInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ResetInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetInv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(159)))), ((int)(((byte)(193)))));
            this.ResetInv.FlatAppearance.BorderSize = 2;
            this.ResetInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(159)))), ((int)(((byte)(193)))));
            this.ResetInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetInv.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetInv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            this.ResetInv.Location = new System.Drawing.Point(591, 148);
            this.ResetInv.Name = "ResetInv";
            this.ResetInv.Size = new System.Drawing.Size(381, 46);
            this.ResetInv.TabIndex = 30;
            this.ResetInv.Text = "RESET";
            this.ResetInv.UseVisualStyleBackColor = false;
            this.ResetInv.Click += new System.EventHandler(this.ResetInv_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 755);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InventoryGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView InventoryGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button inventoryUPDATE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label prodStock;
        private System.Windows.Forms.ComboBox SelectStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ResetInv;
    }
}