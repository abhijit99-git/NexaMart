namespace NexaMart
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.signupClick = new System.Windows.Forms.PictureBox();
            this.signupPass = new System.Windows.Forms.TextBox();
            this.signupUser = new System.Windows.Forms.TextBox();
            this.SignPass = new System.Windows.Forms.Label();
            this.signUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.signupClick)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signupClick
            // 
            this.signupClick.BackColor = System.Drawing.Color.Transparent;
            this.signupClick.BackgroundImage = global::NexaMart.Properties.Resources.signbutton;
            this.signupClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signupClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signupClick.Location = new System.Drawing.Point(3, 3);
            this.signupClick.Name = "signupClick";
            this.signupClick.Size = new System.Drawing.Size(275, 104);
            this.signupClick.TabIndex = 7;
            this.signupClick.TabStop = false;
            this.signupClick.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // signupPass
            // 
            this.signupPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupPass.BackColor = System.Drawing.Color.White;
            this.signupPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupPass.Location = new System.Drawing.Point(1001, 322);
            this.signupPass.Name = "signupPass";
            this.signupPass.PasswordChar = '*';
            this.signupPass.Size = new System.Drawing.Size(263, 24);
            this.signupPass.TabIndex = 6;
            this.signupPass.TextChanged += new System.EventHandler(this.signupPass_TextChanged);
            // 
            // signupUser
            // 
            this.signupUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupUser.BackColor = System.Drawing.Color.White;
            this.signupUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupUser.Location = new System.Drawing.Point(1001, 274);
            this.signupUser.Name = "signupUser";
            this.signupUser.Size = new System.Drawing.Size(263, 24);
            this.signupUser.TabIndex = 5;
            // 
            // SignPass
            // 
            this.SignPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignPass.AutoSize = true;
            this.SignPass.BackColor = System.Drawing.Color.Transparent;
            this.SignPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignPass.Location = new System.Drawing.Point(898, 322);
            this.SignPass.Name = "SignPass";
            this.SignPass.Size = new System.Drawing.Size(78, 20);
            this.SignPass.TabIndex = 4;
            this.SignPass.Text = "Password";
            // 
            // signUser
            // 
            this.signUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUser.AutoSize = true;
            this.signUser.BackColor = System.Drawing.Color.Transparent;
            this.signUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUser.Location = new System.Drawing.Point(894, 276);
            this.signUser.Name = "signUser";
            this.signUser.Size = new System.Drawing.Size(82, 20);
            this.signUser.TabIndex = 3;
            this.signUser.Text = "Username";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.signupClick, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(949, 427);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 110);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::NexaMart.Properties.Resources.minimize_sign;
            this.pictureBox3.Location = new System.Drawing.Point(1317, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::NexaMart.Properties.Resources.ui;
            this.pictureBox1.Location = new System.Drawing.Point(1358, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NexaMart.Properties.Resources.Signup5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1390, 787);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.signupPass);
            this.Controls.Add(this.signupUser);
            this.Controls.Add(this.signUser);
            this.Controls.Add(this.SignPass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1390, 785);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signupClick)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SignPass;
        private System.Windows.Forms.TextBox signupPass;
        private System.Windows.Forms.TextBox signupUser;
        private System.Windows.Forms.PictureBox signupClick;
        private System.Windows.Forms.Label signUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}