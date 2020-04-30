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
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.panDataMenu = new System.Windows.Forms.Panel();
            this.comboFinalYear = new System.Windows.Forms.ComboBox();
            this.comboInitialYear = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblValue_2 = new System.Windows.Forms.Label();
            this.lblValue_1 = new System.Windows.Forms.Label();
            this.lblNoResults = new System.Windows.Forms.Label();
            this.panDataMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(31, 23);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(136, 16);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "Escolha o Período";
            // 
            // panDataMenu
            // 
            this.panDataMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panDataMenu.AutoSize = true;
            this.panDataMenu.Controls.Add(this.comboFinalYear);
            this.panDataMenu.Controls.Add(this.comboInitialYear);
            this.panDataMenu.Controls.Add(this.button1);
            this.panDataMenu.Controls.Add(this.lblValue_2);
            this.panDataMenu.Controls.Add(this.lblValue_1);
            this.panDataMenu.Controls.Add(this.lblTotalValue);
            this.panDataMenu.Location = new System.Drawing.Point(43, 73);
            this.panDataMenu.Name = "panDataMenu";
            this.panDataMenu.Size = new System.Drawing.Size(198, 186);
            this.panDataMenu.TabIndex = 2;
            // 
            // comboFinalYear
            // 
            this.comboFinalYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFinalYear.FormattingEnabled = true;
            this.comboFinalYear.Location = new System.Drawing.Point(46, 104);
            this.comboFinalYear.Name = "comboFinalYear";
            this.comboFinalYear.Size = new System.Drawing.Size(121, 21);
            this.comboFinalYear.TabIndex = 4;
            this.comboFinalYear.SelectedIndexChanged += new System.EventHandler(this.comboFinalYear_SelectedIndexChanged);
            // 
            // comboInitialYear
            // 
            this.comboInitialYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInitialYear.FormattingEnabled = true;
            this.comboInitialYear.Location = new System.Drawing.Point(46, 73);
            this.comboInitialYear.Name = "comboInitialYear";
            this.comboInitialYear.Size = new System.Drawing.Size(121, 21);
            this.comboInitialYear.TabIndex = 4;
            this.comboInitialYear.SelectedIndexChanged += new System.EventHandler(this.comboInitialYear_SelectedIndexChanged);
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
            this.lblValue_2.Location = new System.Drawing.Point(18, 107);
            this.lblValue_2.Name = "lblValue_2";
            this.lblValue_2.Size = new System.Drawing.Size(26, 13);
            this.lblValue_2.TabIndex = 1;
            this.lblValue_2.Text = "Até:";
            // 
            // lblValue_1
            // 
            this.lblValue_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValue_1.AutoSize = true;
            this.lblValue_1.Location = new System.Drawing.Point(18, 76);
            this.lblValue_1.Name = "lblValue_1";
            this.lblValue_1.Size = new System.Drawing.Size(24, 13);
            this.lblValue_1.TabIndex = 1;
            this.lblValue_1.Text = "De:";
            // 
            // lblNoResults
            // 
            this.lblNoResults.AutoSize = true;
            this.lblNoResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResults.ForeColor = System.Drawing.Color.Red;
            this.lblNoResults.Location = new System.Drawing.Point(31, 276);
            this.lblNoResults.Name = "lblNoResults";
            this.lblNoResults.Size = new System.Drawing.Size(222, 16);
            this.lblNoResults.TabIndex = 3;
            this.lblNoResults.Text = "Nenhum Resultado Encontrado";
            this.lblNoResults.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 333);
            this.Controls.Add(this.lblNoResults);
            this.Controls.Add(this.panDataMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panDataMenu.ResumeLayout(false);
            this.panDataMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel panDataMenu;
        private System.Windows.Forms.Label lblValue_2;
        private System.Windows.Forms.Label lblValue_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNoResults;
        private System.Windows.Forms.ComboBox comboInitialYear;
        private System.Windows.Forms.ComboBox comboFinalYear;
    }
}

