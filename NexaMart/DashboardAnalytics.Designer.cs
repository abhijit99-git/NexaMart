namespace NexaMart
{
    partial class DashboardAnalytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAnalytics));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderAmtText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductAmtText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TotalEarnText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TodaysEarnText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1124, 188);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(96)))), ((int)(((byte)(252)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.OrderAmtText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 156);
            this.panel1.TabIndex = 0;
            // 
            // OrderAmtText
            // 
            this.OrderAmtText.AutoSize = true;
            this.OrderAmtText.BackColor = System.Drawing.Color.Transparent;
            this.OrderAmtText.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderAmtText.ForeColor = System.Drawing.Color.White;
            this.OrderAmtText.Location = new System.Drawing.Point(3, 105);
            this.OrderAmtText.Name = "OrderAmtText";
            this.OrderAmtText.Size = new System.Drawing.Size(33, 37);
            this.OrderAmtText.TabIndex = 13;
            this.OrderAmtText.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(193)))), ((int)(((byte)(116)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.ProductAmtText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(282, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 156);
            this.panel2.TabIndex = 1;
            // 
            // ProductAmtText
            // 
            this.ProductAmtText.AutoSize = true;
            this.ProductAmtText.BackColor = System.Drawing.Color.Transparent;
            this.ProductAmtText.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAmtText.ForeColor = System.Drawing.Color.White;
            this.ProductAmtText.Location = new System.Drawing.Point(3, 105);
            this.ProductAmtText.Name = "ProductAmtText";
            this.ProductAmtText.Size = new System.Drawing.Size(33, 37);
            this.ProductAmtText.TabIndex = 14;
            this.ProductAmtText.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Products";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(103)))), ((int)(((byte)(123)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.TotalEarnText);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(561, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 156);
            this.panel3.TabIndex = 2;
            // 
            // TotalEarnText
            // 
            this.TotalEarnText.AutoSize = true;
            this.TotalEarnText.BackColor = System.Drawing.Color.Transparent;
            this.TotalEarnText.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalEarnText.ForeColor = System.Drawing.Color.White;
            this.TotalEarnText.Location = new System.Drawing.Point(12, 105);
            this.TotalEarnText.Name = "TotalEarnText";
            this.TotalEarnText.Size = new System.Drawing.Size(77, 37);
            this.TotalEarnText.TabIndex = 14;
            this.TotalEarnText.Text = "₹ 0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Income";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(141)))), ((int)(((byte)(243)))));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.TodaysEarnText);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(840, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 156);
            this.panel4.TabIndex = 3;
            // 
            // TodaysEarnText
            // 
            this.TodaysEarnText.AutoSize = true;
            this.TodaysEarnText.BackColor = System.Drawing.Color.Transparent;
            this.TodaysEarnText.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodaysEarnText.ForeColor = System.Drawing.Color.White;
            this.TodaysEarnText.Location = new System.Drawing.Point(3, 105);
            this.TodaysEarnText.Name = "TodaysEarnText";
            this.TodaysEarnText.Size = new System.Drawing.Size(77, 37);
            this.TodaysEarnText.TabIndex = 14;
            this.TodaysEarnText.Text = "₹ 0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Today Income";
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 275);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Stock";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1110, 435);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // DashboardAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 755);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardAnalytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardAnalytics";
            this.Load += new System.EventHandler(this.DashboardAnalytics_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OrderAmtText;
        private System.Windows.Forms.Label ProductAmtText;
        private System.Windows.Forms.Label TotalEarnText;
        private System.Windows.Forms.Label TodaysEarnText;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}