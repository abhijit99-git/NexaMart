namespace NexaMart
{
    partial class SearchBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BillNameSearch = new System.Windows.Forms.TextBox();
            this.dashMinimize = new System.Windows.Forms.PictureBox();
            this.closeDash = new System.Windows.Forms.PictureBox();
            this.viewbillclick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BillNameSearch);
            this.panel1.Controls.Add(this.dashMinimize);
            this.panel1.Controls.Add(this.closeDash);
            this.panel1.Controls.Add(this.viewbillclick);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 451);
            this.panel1.TabIndex = 0;
            // 
            // BillNameSearch
            // 
            this.BillNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(156)))), ((int)(((byte)(174)))));
            this.BillNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillNameSearch.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNameSearch.ForeColor = System.Drawing.Color.Honeydew;
            this.BillNameSearch.Location = new System.Drawing.Point(274, 192);
            this.BillNameSearch.Name = "BillNameSearch";
            this.BillNameSearch.Size = new System.Drawing.Size(258, 20);
            this.BillNameSearch.TabIndex = 28;
            // 
            // dashMinimize
            // 
            this.dashMinimize.BackColor = System.Drawing.Color.Transparent;
            this.dashMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashMinimize.Image = global::NexaMart.Properties.Resources.minimize_sign1;
            this.dashMinimize.Location = new System.Drawing.Point(728, 3);
            this.dashMinimize.Name = "dashMinimize";
            this.dashMinimize.Size = new System.Drawing.Size(27, 23);
            this.dashMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dashMinimize.TabIndex = 27;
            this.dashMinimize.TabStop = false;
            this.dashMinimize.Click += new System.EventHandler(this.dashMinimize_Click);
            // 
            // closeDash
            // 
            this.closeDash.BackColor = System.Drawing.Color.Transparent;
            this.closeDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeDash.Image = global::NexaMart.Properties.Resources.cancel;
            this.closeDash.Location = new System.Drawing.Point(761, 3);
            this.closeDash.Name = "closeDash";
            this.closeDash.Size = new System.Drawing.Size(27, 23);
            this.closeDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeDash.TabIndex = 26;
            this.closeDash.TabStop = false;
            this.closeDash.Click += new System.EventHandler(this.closeDash_Click);
            // 
            // viewbillclick
            // 
            this.viewbillclick.BackColor = System.Drawing.Color.Transparent;
            this.viewbillclick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.viewbillclick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewbillclick.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.viewbillclick.FlatAppearance.BorderSize = 2;
            this.viewbillclick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.viewbillclick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.viewbillclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewbillclick.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbillclick.ForeColor = System.Drawing.Color.Honeydew;
            this.viewbillclick.Location = new System.Drawing.Point(337, 239);
            this.viewbillclick.Name = "viewbillclick";
            this.viewbillclick.Size = new System.Drawing.Size(102, 42);
            this.viewbillclick.TabIndex = 24;
            this.viewbillclick.Text = "VIEW";
            this.viewbillclick.UseVisualStyleBackColor = false;
            this.viewbillclick.Click += new System.EventHandler(this.viewbillclick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(319, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Search Bill Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(257, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // SearchBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBill";
            this.Load += new System.EventHandler(this.SearchBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox dashMinimize;
        private System.Windows.Forms.PictureBox closeDash;
        private System.Windows.Forms.Button viewbillclick;
        private System.Windows.Forms.TextBox BillNameSearch;
    }
}