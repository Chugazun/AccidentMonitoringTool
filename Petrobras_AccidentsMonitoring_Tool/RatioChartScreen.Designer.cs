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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalPerType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statChart)).BeginInit();
            this.SuspendLayout();
            // 
            // statChart
            // 
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Angle = 90;
            chartArea3.Name = "ChartArea1";
            this.statChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.statChart.Legends.Add(legend3);
            this.statChart.Location = new System.Drawing.Point(12, 12);
            this.statChart.Name = "statChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.statChart.Series.Add(series3);
            this.statChart.Size = new System.Drawing.Size(430, 425);
            this.statChart.TabIndex = 1;
            this.statChart.Text = "Gráfico";
            this.statChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.statChart_MouseClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(16, 17);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total: ";
            this.lblTotal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblTotal_MouseClick);
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
            this.lblTotalPerType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblTotal_MouseClick);
            // 
            // RatioChartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 449);
            this.Controls.Add(this.lblTotalPerType);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.statChart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RatioChartScreen";
            this.Text = "Gráfico";
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