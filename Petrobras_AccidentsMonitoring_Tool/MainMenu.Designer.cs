namespace Petrobras_AccidentsMonitoring_Tool
{
    partial class MainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValue_2 = new System.Windows.Forms.TextBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.panDataMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblValue_2 = new System.Windows.Forms.Label();
            this.lblValue_1 = new System.Windows.Forms.Label();
            this.txtTotalValue = new System.Windows.Forms.TextBox();
            this.txtValue_1 = new System.Windows.Forms.TextBox();
            this.panDataMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValue_2
            // 
            this.txtValue_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValue_2.Location = new System.Drawing.Point(82, 110);
            this.txtValue_2.Name = "txtValue_2";
            this.txtValue_2.Size = new System.Drawing.Size(100, 20);
            this.txtValue_2.TabIndex = 0;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(18, 66);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(58, 13);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "Valor Total";
            // 
            // panDataMenu
            // 
            this.panDataMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panDataMenu.AutoSize = true;
            this.panDataMenu.Controls.Add(this.button1);
            this.panDataMenu.Controls.Add(this.lblValue_2);
            this.panDataMenu.Controls.Add(this.lblValue_1);
            this.panDataMenu.Controls.Add(this.txtTotalValue);
            this.panDataMenu.Controls.Add(this.lblTotalValue);
            this.panDataMenu.Controls.Add(this.txtValue_1);
            this.panDataMenu.Controls.Add(this.txtValue_2);
            this.panDataMenu.Location = new System.Drawing.Point(43, 73);
            this.panDataMenu.Name = "panDataMenu";
            this.panDataMenu.Size = new System.Drawing.Size(198, 186);
            this.panDataMenu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(53, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gerar Gráfico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblValue_2
            // 
            this.lblValue_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValue_2.AutoSize = true;
            this.lblValue_2.Location = new System.Drawing.Point(18, 114);
            this.lblValue_2.Name = "lblValue_2";
            this.lblValue_2.Size = new System.Drawing.Size(43, 13);
            this.lblValue_2.TabIndex = 1;
            this.lblValue_2.Text = "Value 2";
            // 
            // lblValue_1
            // 
            this.lblValue_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValue_1.AutoSize = true;
            this.lblValue_1.Location = new System.Drawing.Point(18, 90);
            this.lblValue_1.Name = "lblValue_1";
            this.lblValue_1.Size = new System.Drawing.Size(43, 13);
            this.lblValue_1.TabIndex = 1;
            this.lblValue_1.Text = "Value 1";
            // 
            // txtTotalValue
            // 
            this.txtTotalValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalValue.Location = new System.Drawing.Point(82, 62);
            this.txtTotalValue.Name = "txtTotalValue";
            this.txtTotalValue.Size = new System.Drawing.Size(100, 20);
            this.txtTotalValue.TabIndex = 0;
            // 
            // txtValue_1
            // 
            this.txtValue_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValue_1.Location = new System.Drawing.Point(82, 86);
            this.txtValue_1.Name = "txtValue_1";
            this.txtValue_1.Size = new System.Drawing.Size(100, 20);
            this.txtValue_1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 333);
            this.Controls.Add(this.panDataMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainMenu";
            this.Text = "Menu Principal";
            this.panDataMenu.ResumeLayout(false);
            this.panDataMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue_2;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel panDataMenu;
        private System.Windows.Forms.Label lblValue_2;
        private System.Windows.Forms.Label lblValue_1;
        private System.Windows.Forms.TextBox txtTotalValue;
        private System.Windows.Forms.TextBox txtValue_1;
        private System.Windows.Forms.Button button1;
    }
}

