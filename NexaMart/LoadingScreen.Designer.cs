namespace NexaMart
{
    partial class LoadingScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.LoadBack = new System.Windows.Forms.Panel();
            this.LoadLevel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LoadBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadBack
            // 
            this.LoadBack.BackColor = System.Drawing.Color.White;
            this.LoadBack.Controls.Add(this.LoadLevel);
            this.LoadBack.Location = new System.Drawing.Point(0, 560);
            this.LoadBack.Name = "LoadBack";
            this.LoadBack.Size = new System.Drawing.Size(1101, 13);
            this.LoadBack.TabIndex = 0;
            // 
            // LoadLevel
            // 
            this.LoadLevel.BackColor = System.Drawing.Color.White;
            this.LoadLevel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadLevel.BackgroundImage")));
            this.LoadLevel.Location = new System.Drawing.Point(0, 0);
            this.LoadLevel.Name = "LoadLevel";
            this.LoadLevel.Size = new System.Drawing.Size(55, 21);
            this.LoadLevel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 572);
            this.Controls.Add(this.LoadBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.LoadBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoadBack;
        private System.Windows.Forms.Panel LoadLevel;
        private System.Windows.Forms.Timer timer1;
    }
}