namespace Petrobras_AccidentsMonitoring_Tool
{
    partial class RatioChartScreen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalPerType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statChart)).BeginInit();
            this.SuspendLayout();
            // 
            // statChart
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 90;
            chartArea1.Name = "ChartArea1";
            this.statChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statChart.Legends.Add(legend1);
            this.statChart.Location = new System.Drawing.Point(12, 35);
            this.statChart.Name = "statChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.statChart.Series.Add(series1);
            this.statChart.Size = new System.Drawing.Size(773, 442);
            this.statChart.TabIndex = 1;
            this.statChart.Text = "Gráfico";
            this.statChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.statChart_MouseClick);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblTotal.Size = new System.Drawing.Size(773, 34);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total: ";
            // 
            // lblTotalPerType
            // 
            this.lblTotalPerType.AutoSize = true;
            this.lblTotalPerType.BackColor = System.Drawing.Color.White;
            this.lblTotalPerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPerType.Location = new System.Drawing.Point(17, 30);
            this.lblTotalPerType.Name = "lblTotalPerType";
            this.lblTotalPerType.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPerType.TabIndex = 2;
            this.lblTotalPerType.Visible = false;
            // 
            // RatioChartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 489);
            this.Controls.Add(this.lblTotalPerType);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.statChart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RatioChartScreen";
            this.Text = "Gráfico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RatioChartScreen_FormClosed);
            this.Load += new System.EventHandler(this.RatioChartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart statChart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalPerType;
    }
}