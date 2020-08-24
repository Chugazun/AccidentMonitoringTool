namespace Petrobras_AccidentsMonitoring_Tool
{
    partial class StatsSelector
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
            this.chkBoxStats = new System.Windows.Forms.CheckedListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGenerateChart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkBoxStats
            // 
            this.chkBoxStats.BackColor = System.Drawing.SystemColors.Control;
            this.chkBoxStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkBoxStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxStats.FormattingEnabled = true;
            this.chkBoxStats.Items.AddRange(new object[] {
            "Setores",
            "Anos",
            "Meses",
            "Dias da Semana",
            "Horas",
            "Tipos de Lesão",
            "Locais",
            "Partes do Corpo",
            "Classificação",
            "Classes"});
            this.chkBoxStats.Location = new System.Drawing.Point(48, 65);
            this.chkBoxStats.Name = "chkBoxStats";
            this.chkBoxStats.Size = new System.Drawing.Size(145, 204);
            this.chkBoxStats.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGenerateChart
            // 
            this.btnGenerateChart.Location = new System.Drawing.Point(66, 296);
            this.btnGenerateChart.Name = "btnGenerateChart";
            this.btnGenerateChart.Size = new System.Drawing.Size(108, 28);
            this.btnGenerateChart.TabIndex = 2;
            this.btnGenerateChart.Text = "Gerar Gráfico(s)";
            this.btnGenerateChart.UseVisualStyleBackColor = true;
            this.btnGenerateChart.Click += new System.EventHandler(this.btnGenerateChart_Click);
            // 
            // StatsSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 351);
            this.Controls.Add(this.btnGenerateChart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chkBoxStats);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatsSelector";
            this.Text = "Selecione os Dados";
            this.Load += new System.EventHandler(this.StatsSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkBoxStats;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGenerateChart;
    }
}