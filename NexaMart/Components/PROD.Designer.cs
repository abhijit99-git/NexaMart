namespace NexaMart.Components
{
    partial class PROD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StockAMT = new System.Windows.Forms.Label();
            this.ProductIMG = new System.Windows.Forms.PictureBox();
            this.StockTitle = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // StockAMT
            // 
            this.StockAMT.AutoSize = true;
            this.StockAMT.BackColor = System.Drawing.Color.Transparent;
            this.StockAMT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockAMT.ForeColor = System.Drawing.Color.ForestGreen;
            this.StockAMT.Location = new System.Drawing.Point(91, 129);
            this.StockAMT.Name = "StockAMT";
            this.StockAMT.Size = new System.Drawing.Size(74, 23);
            this.StockAMT.TabIndex = 9;
            this.StockAMT.Text = "STOCK :";
            // 
            // ProductIMG
            // 
            this.ProductIMG.BackColor = System.Drawing.Color.Transparent;
            this.ProductIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductIMG.Location = new System.Drawing.Point(15, 9);
            this.ProductIMG.Name = "ProductIMG";
            this.ProductIMG.Size = new System.Drawing.Size(138, 117);
            this.ProductIMG.TabIndex = 8;
            this.ProductIMG.TabStop = false;
            // 
            // StockTitle
            // 
            this.StockTitle.AutoSize = true;
            this.StockTitle.BackColor = System.Drawing.Color.Transparent;
            this.StockTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.StockTitle.Location = new System.Drawing.Point(11, 129);
            this.StockTitle.Name = "StockTitle";
            this.StockTitle.Size = new System.Drawing.Size(74, 23);
            this.StockTitle.TabIndex = 7;
            this.StockTitle.Text = "STOCK :";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.ForestGreen;
            this.Price.Location = new System.Drawing.Point(216, 114);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(81, 38);
            this.Price.TabIndex = 6;
            this.Price.Text = "Price";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(216, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(75, 38);
            this.Title.TabIndex = 5;
            this.Title.Text = "Title";
            // 
            // PROD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StockAMT);
            this.Controls.Add(this.ProductIMG);
            this.Controls.Add(this.StockTitle);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Title);
            this.Name = "PROD";
            this.Size = new System.Drawing.Size(349, 172);
            ((System.ComponentModel.ISupportInitialize)(this.ProductIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StockAMT;
        private System.Windows.Forms.PictureBox ProductIMG;
        private System.Windows.Forms.Label StockTitle;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Title;
    }
}
