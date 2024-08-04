namespace NexaMart.Components
{
    partial class ProductTemplate
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
            this.Title = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.StockTitle = new System.Windows.Forms.Label();
            this.ProductIMG = new System.Windows.Forms.PictureBox();
            this.StockAMT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(206, 15);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(75, 38);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.ForestGreen;
            this.Price.Location = new System.Drawing.Point(200, 120);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(81, 38);
            this.Price.TabIndex = 1;
            this.Price.Text = "Price";
            // 
            // StockTitle
            // 
            this.StockTitle.AutoSize = true;
            this.StockTitle.BackColor = System.Drawing.Color.Transparent;
            this.StockTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.StockTitle.Location = new System.Drawing.Point(14, 135);
            this.StockTitle.Name = "StockTitle";
            this.StockTitle.Size = new System.Drawing.Size(74, 23);
            this.StockTitle.TabIndex = 2;
            this.StockTitle.Text = "STOCK :";
            // 
            // ProductIMG
            // 
            this.ProductIMG.BackColor = System.Drawing.Color.Transparent;
            this.ProductIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductIMG.Location = new System.Drawing.Point(18, 15);
            this.ProductIMG.Name = "ProductIMG";
            this.ProductIMG.Size = new System.Drawing.Size(138, 117);
            this.ProductIMG.TabIndex = 3;
            this.ProductIMG.TabStop = false;
            // 
            // StockAMT
            // 
            this.StockAMT.AutoSize = true;
            this.StockAMT.BackColor = System.Drawing.Color.Transparent;
            this.StockAMT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockAMT.ForeColor = System.Drawing.Color.ForestGreen;
            this.StockAMT.Location = new System.Drawing.Point(94, 135);
            this.StockAMT.Name = "StockAMT";
            this.StockAMT.Size = new System.Drawing.Size(74, 23);
            this.StockAMT.TabIndex = 4;
            this.StockAMT.Text = "STOCK :";
            // 
            // ProductTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StockAMT);
            this.Controls.Add(this.ProductIMG);
            this.Controls.Add(this.StockTitle);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Title);
            this.Name = "ProductTemplate";
            this.Size = new System.Drawing.Size(343, 179);
            ((System.ComponentModel.ISupportInitialize)(this.ProductIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label StockTitle;
        private System.Windows.Forms.PictureBox ProductIMG;
        private System.Windows.Forms.Label StockAMT;
    }
}
