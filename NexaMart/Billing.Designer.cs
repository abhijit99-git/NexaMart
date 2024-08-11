namespace NexaMart
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.clickbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickbtn
            // 
            this.clickbtn.BackColor = System.Drawing.Color.Transparent;
            this.clickbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clickbtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.clickbtn.FlatAppearance.BorderSize = 2;
            this.clickbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.clickbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clickbtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickbtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.clickbtn.Location = new System.Drawing.Point(640, 438);
            this.clickbtn.Name = "clickbtn";
            this.clickbtn.Size = new System.Drawing.Size(170, 69);
            this.clickbtn.TabIndex = 6;
            this.clickbtn.Text = "Manage";
            this.clickbtn.UseVisualStyleBackColor = false;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 723);
            this.Controls.Add(this.clickbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickbtn;
    }
}