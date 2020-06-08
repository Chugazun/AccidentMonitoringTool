namespace Petrobras_AccidentsMonitoring_Tool
{
    partial class DaysMonitoringScreen
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
            this.listAccidents = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listAccidents
            // 
            this.listAccidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAccidents.FormattingEnabled = true;
            this.listAccidents.ItemHeight = 15;
            this.listAccidents.Location = new System.Drawing.Point(27, 58);
            this.listAccidents.Name = "listAccidents";
            this.listAccidents.Size = new System.Drawing.Size(309, 139);
            this.listAccidents.TabIndex = 0;
            this.listAccidents.SelectedIndexChanged += new System.EventHandler(this.listAccidents_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(364, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Dias sem acidentes";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DaysMonitoringScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 255);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listAccidents);
            this.Name = "DaysMonitoringScreen";
            this.Text = "Monitoramento";
            this.Load += new System.EventHandler(this.DaysMonitoringScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listAccidents;
        private System.Windows.Forms.Label lblTitle;
    }
}