namespace Petrobras_AccidentsMonitoring_Tool
{
    partial class AccidentsMonitoringMenu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panDataMenuPeriod = new System.Windows.Forms.Panel();
            this.comboFinalYear = new System.Windows.Forms.ComboBox();
            this.comboInitialYear = new System.Windows.Forms.ComboBox();
            this.lblValue_2 = new System.Windows.Forms.Label();
            this.lblValue_1 = new System.Windows.Forms.Label();
            this.lblNoResults = new System.Windows.Forms.Label();
            this.radioPeriod = new System.Windows.Forms.RadioButton();
            this.radioYear = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.panDataMenuYear = new System.Windows.Forms.Panel();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panDataMenuAll = new System.Windows.Forms.Panel();
            this.txtFinalYearAll = new System.Windows.Forms.TextBox();
            this.txtInitialYearAll = new System.Windows.Forms.TextBox();
            this.lblValue_2_All = new System.Windows.Forms.Label();
            this.lblValue_1_All = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panDataMenuPeriod.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panDataMenuYear.SuspendLayout();
            this.panDataMenuAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(74, 121);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Escolha o Período";
            // 
            // panDataMenuPeriod
            // 
            this.panDataMenuPeriod.AutoSize = true;
            this.panDataMenuPeriod.Controls.Add(this.comboFinalYear);
            this.panDataMenuPeriod.Controls.Add(this.comboInitialYear);
            this.panDataMenuPeriod.Controls.Add(this.lblValue_2);
            this.panDataMenuPeriod.Controls.Add(this.lblValue_1);
            this.panDataMenuPeriod.Location = new System.Drawing.Point(42, 145);
            this.panDataMenuPeriod.Name = "panDataMenuPeriod";
            this.panDataMenuPeriod.Size = new System.Drawing.Size(200, 102);
            this.panDataMenuPeriod.TabIndex = 2;
            // 
            // comboFinalYear
            // 
            this.comboFinalYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFinalYear.FormattingEnabled = true;
            this.comboFinalYear.Location = new System.Drawing.Point(46, 61);
            this.comboFinalYear.Name = "comboFinalYear";
            this.comboFinalYear.Size = new System.Drawing.Size(121, 21);
            this.comboFinalYear.TabIndex = 4;
            this.comboFinalYear.SelectedIndexChanged += new System.EventHandler(this.comboFinalYear_SelectedIndexChanged);
            // 
            // comboInitialYear
            // 
            this.comboInitialYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInitialYear.FormattingEnabled = true;
            this.comboInitialYear.Location = new System.Drawing.Point(46, 30);
            this.comboInitialYear.Name = "comboInitialYear";
            this.comboInitialYear.Size = new System.Drawing.Size(121, 21);
            this.comboInitialYear.TabIndex = 4;
            this.comboInitialYear.SelectedIndexChanged += new System.EventHandler(this.comboInitialYear_SelectedIndexChanged);
            // 
            // lblValue_2
            // 
            this.lblValue_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValue_2.AutoSize = true;
            this.lblValue_2.Location = new System.Drawing.Point(19, 65);
            this.lblValue_2.Name = "lblValue_2";
            this.lblValue_2.Size = new System.Drawing.Size(26, 13);
            this.lblValue_2.TabIndex = 1;
            this.lblValue_2.Text = "Até:";
            // 
            // lblValue_1
            // 
            this.lblValue_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValue_1.AutoSize = true;
            this.lblValue_1.Location = new System.Drawing.Point(19, 34);
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
            this.lblNoResults.Location = new System.Drawing.Point(31, 296);
            this.lblNoResults.Name = "lblNoResults";
            this.lblNoResults.Size = new System.Drawing.Size(222, 16);
            this.lblNoResults.TabIndex = 3;
            this.lblNoResults.Text = "Nenhum Resultado Encontrado";
            this.lblNoResults.Visible = false;
            // 
            // radioPeriod
            // 
            this.radioPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioPeriod.AutoSize = true;
            this.radioPeriod.Location = new System.Drawing.Point(8, 17);
            this.radioPeriod.Name = "radioPeriod";
            this.radioPeriod.Size = new System.Drawing.Size(82, 17);
            this.radioPeriod.TabIndex = 5;
            this.radioPeriod.Text = "Por Período";
            this.radioPeriod.UseVisualStyleBackColor = true;
            this.radioPeriod.CheckedChanged += new System.EventHandler(this.radioPeriod_CheckedChanged);
            // 
            // radioYear
            // 
            this.radioYear.AutoSize = true;
            this.radioYear.Location = new System.Drawing.Point(99, 17);
            this.radioYear.Name = "radioYear";
            this.radioYear.Size = new System.Drawing.Size(63, 17);
            this.radioYear.TabIndex = 6;
            this.radioYear.Text = "Por Ano";
            this.radioYear.UseVisualStyleBackColor = true;
            this.radioYear.CheckedChanged += new System.EventHandler(this.radioYear_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAll);
            this.groupBox1.Controls.Add(this.radioYear);
            this.groupBox1.Controls.Add(this.radioPeriod);
            this.groupBox1.Location = new System.Drawing.Point(6, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 44);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(168, 17);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(100, 17);
            this.radioAll.TabIndex = 6;
            this.radioAll.Text = "Todo o Período";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.CheckedChanged += new System.EventHandler(this.radioAll_CheckedChanged);
            // 
            // panDataMenuYear
            // 
            this.panDataMenuYear.AutoSize = true;
            this.panDataMenuYear.Controls.Add(this.comboYear);
            this.panDataMenuYear.Controls.Add(this.lblYear);
            this.panDataMenuYear.Location = new System.Drawing.Point(42, 153);
            this.panDataMenuYear.Name = "panDataMenuYear";
            this.panDataMenuYear.Size = new System.Drawing.Size(200, 82);
            this.panDataMenuYear.TabIndex = 2;
            this.panDataMenuYear.Visible = false;
            // 
            // comboYear
            // 
            this.comboYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(52, 31);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(121, 21);
            this.comboYear.TabIndex = 4;
            this.comboYear.SelectedIndexChanged += new System.EventHandler(this.comboInitialYear_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(22, 35);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Ano:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Gerar Gráfico";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panDataMenuAll
            // 
            this.panDataMenuAll.AutoSize = true;
            this.panDataMenuAll.Controls.Add(this.txtFinalYearAll);
            this.panDataMenuAll.Controls.Add(this.txtInitialYearAll);
            this.panDataMenuAll.Controls.Add(this.lblValue_2_All);
            this.panDataMenuAll.Controls.Add(this.lblValue_1_All);
            this.panDataMenuAll.Location = new System.Drawing.Point(42, 146);
            this.panDataMenuAll.Name = "panDataMenuAll";
            this.panDataMenuAll.Size = new System.Drawing.Size(200, 99);
            this.panDataMenuAll.TabIndex = 2;
            this.panDataMenuAll.Visible = false;
            // 
            // txtFinalYearAll
            // 
            this.txtFinalYearAll.BackColor = System.Drawing.Color.White;
            this.txtFinalYearAll.Enabled = false;
            this.txtFinalYearAll.Location = new System.Drawing.Point(61, 56);
            this.txtFinalYearAll.Name = "txtFinalYearAll";
            this.txtFinalYearAll.ReadOnly = true;
            this.txtFinalYearAll.Size = new System.Drawing.Size(100, 20);
            this.txtFinalYearAll.TabIndex = 2;
            // 
            // txtInitialYearAll
            // 
            this.txtInitialYearAll.BackColor = System.Drawing.Color.White;
            this.txtInitialYearAll.Enabled = false;
            this.txtInitialYearAll.Location = new System.Drawing.Point(61, 25);
            this.txtInitialYearAll.Name = "txtInitialYearAll";
            this.txtInitialYearAll.ReadOnly = true;
            this.txtInitialYearAll.Size = new System.Drawing.Size(100, 20);
            this.txtInitialYearAll.TabIndex = 2;
            // 
            // lblValue_2_All
            // 
            this.lblValue_2_All.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValue_2_All.AutoSize = true;
            this.lblValue_2_All.Location = new System.Drawing.Point(31, 60);
            this.lblValue_2_All.Name = "lblValue_2_All";
            this.lblValue_2_All.Size = new System.Drawing.Size(26, 13);
            this.lblValue_2_All.TabIndex = 1;
            this.lblValue_2_All.Text = "Até:";
            // 
            // lblValue_1_All
            // 
            this.lblValue_1_All.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValue_1_All.AutoSize = true;
            this.lblValue_1_All.Location = new System.Drawing.Point(31, 29);
            this.lblValue_1_All.Name = "lblValue_1_All";
            this.lblValue_1_All.Size = new System.Drawing.Size(24, 13);
            this.lblValue_1_All.TabIndex = 1;
            this.lblValue_1_All.Text = "De:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AccidentsMonitoringMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 333);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panDataMenuPeriod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNoResults);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panDataMenuYear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panDataMenuAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AccidentsMonitoringMenu";
            this.Text = "Monitoramento de Acidentes";
            this.Load += new System.EventHandler(this.AccidentsMonitoringMenu_Load);
            this.panDataMenuPeriod.ResumeLayout(false);
            this.panDataMenuPeriod.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panDataMenuYear.ResumeLayout(false);
            this.panDataMenuYear.PerformLayout();
            this.panDataMenuAll.ResumeLayout(false);
            this.panDataMenuAll.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panDataMenuPeriod;
        private System.Windows.Forms.Label lblValue_2;
        private System.Windows.Forms.Label lblValue_1;
        private System.Windows.Forms.Label lblNoResults;
        private System.Windows.Forms.ComboBox comboInitialYear;
        private System.Windows.Forms.ComboBox comboFinalYear;
        private System.Windows.Forms.RadioButton radioYear;
        private System.Windows.Forms.RadioButton radioPeriod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.Panel panDataMenuYear;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Panel panDataMenuAll;
        private System.Windows.Forms.TextBox txtFinalYearAll;
        private System.Windows.Forms.TextBox txtInitialYearAll;
        private System.Windows.Forms.Label lblValue_2_All;
        private System.Windows.Forms.Label lblValue_1_All;
        private System.Windows.Forms.Button btnBack;
    }
}

