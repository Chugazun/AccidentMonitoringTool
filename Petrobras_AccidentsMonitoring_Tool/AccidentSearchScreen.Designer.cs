namespace Petrobras_AccidentsMonitoring_Tool
{
    partial class AccidentSearchScreen
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
            this.listResults = new System.Windows.Forms.ListView();
            this.colCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTest = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listResults
            // 
            this.listResults.AutoArrange = false;
            this.listResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCompany,
            this.colSector,
            this.colEmployee});
            this.listResults.FullRowSelect = true;
            this.listResults.GridLines = true;
            this.listResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listResults.LabelWrap = false;
            this.listResults.Location = new System.Drawing.Point(131, 312);
            this.listResults.Name = "listResults";
            this.listResults.OwnerDraw = true;
            this.listResults.ShowGroups = false;
            this.listResults.Size = new System.Drawing.Size(539, 131);
            this.listResults.TabIndex = 0;
            this.listResults.TabStop = false;
            this.listResults.UseCompatibleStateImageBehavior = false;
            this.listResults.View = System.Windows.Forms.View.Details;
            this.listResults.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            this.listResults.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listResults.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView1_DrawSubItem);
            // 
            // colCompany
            // 
            this.colCompany.Text = "Empresa";
            // 
            // colSector
            // 
            this.colSector.Text = "Setor";
            // 
            // colEmployee
            // 
            this.colEmployee.Text = "Funcionário";
            this.colEmployee.Width = 72;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(363, 147);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(128, 296);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(66, 13);
            this.lblResults.TabIndex = 2;
            this.lblResults.Text = "Resultados: ";
            // 
            // AccidentSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.listResults);
            this.Name = "AccidentSearchScreen";
            this.Text = "Buscar Acidentes";
            this.Load += new System.EventHandler(this.AccidentSearchScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listResults;
        private System.Windows.Forms.ColumnHeader colCompany;
        private System.Windows.Forms.ColumnHeader colSector;
        private System.Windows.Forms.ColumnHeader colEmployee;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblResults;
    }
}