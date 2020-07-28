namespace Petrobras_AccidentsMonitoring_Tool
{
    partial class MainMenu
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
            System.Windows.Forms.ComboBox comboBox1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.lblCurrentTag = new System.Windows.Forms.Label();
            this.btnDays = new System.Windows.Forms.Button();
            this.btnAccidents = new System.Windows.Forms.Button();
            this.panAccidents = new System.Windows.Forms.Panel();
            this.panDataMenuPeriod = new System.Windows.Forms.Panel();
            this.comboFinalYear = new System.Windows.Forms.ComboBox();
            this.comboInitialYear = new System.Windows.Forms.ComboBox();
            this.lblValue_2 = new System.Windows.Forms.Label();
            this.lblValue_1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioYear = new System.Windows.Forms.RadioButton();
            this.radioPeriod = new System.Windows.Forms.RadioButton();
            this.lblNoResults = new System.Windows.Forms.Label();
            this.btnCreateChart = new System.Windows.Forms.Button();
            this.panDataMenuYear = new System.Windows.Forms.Panel();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panDataMenuAll = new System.Windows.Forms.Panel();
            this.txtFinalYearAll = new System.Windows.Forms.TextBox();
            this.txtInitialYearAll = new System.Windows.Forms.TextBox();
            this.lblValue_2_All = new System.Windows.Forms.Label();
            this.lblValue_1_All = new System.Windows.Forms.Label();
            this.lblToolName = new System.Windows.Forms.Label();
            this.panDaysMain = new System.Windows.Forms.Panel();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSector_1 = new System.Windows.Forms.Label();
            this.comboSector_1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panDaysTotal = new System.Windows.Forms.Panel();
            this.panAddition = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdditionScreen = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panAccidents.SuspendLayout();
            this.panDataMenuPeriod.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panDataMenuYear.SuspendLayout();
            this.panDataMenuAll.SuspendLayout();
            this.panDaysMain.SuspendLayout();
            this.panDaysTotal.SuspendLayout();
            this.panAddition.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(81, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 21);
            comboBox1.TabIndex = 1;
            comboBox1.Tag = "";
            comboBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddition);
            this.groupBox1.Controls.Add(this.lblCurrentTag);
            this.groupBox1.Controls.Add(this.btnDays);
            this.groupBox1.Controls.Add(this.btnAccidents);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(-7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 554);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddition.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAddition.FlatAppearance.BorderSize = 0;
            this.btnAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddition.Location = new System.Drawing.Point(6, 12);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(157, 41);
            this.btnAddition.TabIndex = 0;
            this.btnAddition.Text = "Gerenciar Ocorrências";
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // lblCurrentTag
            // 
            this.lblCurrentTag.AutoSize = true;
            this.lblCurrentTag.Location = new System.Drawing.Point(19, 364);
            this.lblCurrentTag.Name = "lblCurrentTag";
            this.lblCurrentTag.Size = new System.Drawing.Size(116, 13);
            this.lblCurrentTag.TabIndex = 7;
            this.lblCurrentTag.Text = "Current Tag (DEBUG): ";
            this.lblCurrentTag.Visible = false;
            // 
            // btnDays
            // 
            this.btnDays.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDays.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDays.FlatAppearance.BorderSize = 0;
            this.btnDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDays.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDays.Location = new System.Drawing.Point(6, 106);
            this.btnDays.Name = "btnDays";
            this.btnDays.Size = new System.Drawing.Size(157, 41);
            this.btnDays.TabIndex = 0;
            this.btnDays.Text = "Monitoramento de Dias";
            this.btnDays.UseVisualStyleBackColor = false;
            this.btnDays.Click += new System.EventHandler(this.btnDays_Click);
            // 
            // btnAccidents
            // 
            this.btnAccidents.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAccidents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccidents.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAccidents.FlatAppearance.BorderSize = 0;
            this.btnAccidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccidents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAccidents.Location = new System.Drawing.Point(6, 59);
            this.btnAccidents.Name = "btnAccidents";
            this.btnAccidents.Size = new System.Drawing.Size(157, 41);
            this.btnAccidents.TabIndex = 0;
            this.btnAccidents.Text = "Monitoramento de Acidentes";
            this.btnAccidents.UseVisualStyleBackColor = false;
            this.btnAccidents.Click += new System.EventHandler(this.btnAccidents_Click);
            // 
            // panAccidents
            // 
            this.panAccidents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panAccidents.Controls.Add(this.panDataMenuPeriod);
            this.panAccidents.Controls.Add(this.groupBox2);
            this.panAccidents.Controls.Add(this.lblNoResults);
            this.panAccidents.Controls.Add(this.btnCreateChart);
            this.panAccidents.Controls.Add(this.panDataMenuYear);
            this.panAccidents.Controls.Add(this.lblTitle);
            this.panAccidents.Controls.Add(this.panDataMenuAll);
            this.panAccidents.Location = new System.Drawing.Point(171, 0);
            this.panAccidents.Name = "panAccidents";
            this.panAccidents.Size = new System.Drawing.Size(35, 53);
            this.panAccidents.TabIndex = 2;
            this.panAccidents.Visible = false;
            // 
            // panDataMenuPeriod
            // 
            this.panDataMenuPeriod.AutoSize = true;
            this.panDataMenuPeriod.Controls.Add(this.comboFinalYear);
            this.panDataMenuPeriod.Controls.Add(this.comboInitialYear);
            this.panDataMenuPeriod.Controls.Add(this.lblValue_2);
            this.panDataMenuPeriod.Controls.Add(this.lblValue_1);
            this.panDataMenuPeriod.Location = new System.Drawing.Point(39, 100);
            this.panDataMenuPeriod.Name = "panDataMenuPeriod";
            this.panDataMenuPeriod.Size = new System.Drawing.Size(200, 102);
            this.panDataMenuPeriod.TabIndex = 6;
            // 
            // comboFinalYear
            // 
            this.comboFinalYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFinalYear.FormattingEnabled = true;
            this.comboFinalYear.Location = new System.Drawing.Point(46, 61);
            this.comboFinalYear.Name = "comboFinalYear";
            this.comboFinalYear.Size = new System.Drawing.Size(121, 21);
            this.comboFinalYear.TabIndex = 4;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioAll);
            this.groupBox2.Controls.Add(this.radioYear);
            this.groupBox2.Controls.Add(this.radioPeriod);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 44);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
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
            // lblNoResults
            // 
            this.lblNoResults.AutoSize = true;
            this.lblNoResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResults.ForeColor = System.Drawing.Color.Red;
            this.lblNoResults.Location = new System.Drawing.Point(28, 251);
            this.lblNoResults.Name = "lblNoResults";
            this.lblNoResults.Size = new System.Drawing.Size(222, 16);
            this.lblNoResults.TabIndex = 9;
            this.lblNoResults.Text = "Nenhum Resultado Encontrado";
            this.lblNoResults.Visible = false;
            // 
            // btnCreateChart
            // 
            this.btnCreateChart.Location = new System.Drawing.Point(93, 217);
            this.btnCreateChart.Name = "btnCreateChart";
            this.btnCreateChart.Size = new System.Drawing.Size(92, 25);
            this.btnCreateChart.TabIndex = 10;
            this.btnCreateChart.Text = "Gerar Gráfico";
            this.btnCreateChart.UseVisualStyleBackColor = true;
            this.btnCreateChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // panDataMenuYear
            // 
            this.panDataMenuYear.AutoSize = true;
            this.panDataMenuYear.Controls.Add(this.comboYear);
            this.panDataMenuYear.Controls.Add(this.lblYear);
            this.panDataMenuYear.Location = new System.Drawing.Point(39, 108);
            this.panDataMenuYear.Name = "panDataMenuYear";
            this.panDataMenuYear.Size = new System.Drawing.Size(200, 82);
            this.panDataMenuYear.TabIndex = 7;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(71, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 16);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Escolha o Período";
            // 
            // panDataMenuAll
            // 
            this.panDataMenuAll.AutoSize = true;
            this.panDataMenuAll.Controls.Add(this.txtFinalYearAll);
            this.panDataMenuAll.Controls.Add(this.txtInitialYearAll);
            this.panDataMenuAll.Controls.Add(this.lblValue_2_All);
            this.panDataMenuAll.Controls.Add(this.lblValue_1_All);
            this.panDataMenuAll.Location = new System.Drawing.Point(39, 101);
            this.panDataMenuAll.Name = "panDataMenuAll";
            this.panDataMenuAll.Size = new System.Drawing.Size(200, 99);
            this.panDataMenuAll.TabIndex = 8;
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
            // lblToolName
            // 
            this.lblToolName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblToolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolName.Location = new System.Drawing.Point(249, 23);
            this.lblToolName.Name = "lblToolName";
            this.lblToolName.Size = new System.Drawing.Size(241, 29);
            this.lblToolName.TabIndex = 5;
            this.lblToolName.Text = "Adicionar novo Acidente";
            this.lblToolName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panDaysMain
            // 
            this.panDaysMain.AutoScroll = true;
            this.panDaysMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDaysMain.Controls.Add(this.comboType);
            this.panDaysMain.Controls.Add(this.btnRemove);
            this.panDaysMain.Controls.Add(this.btnAdd);
            this.panDaysMain.Controls.Add(this.label2);
            this.panDaysMain.Controls.Add(this.lblType);
            this.panDaysMain.Controls.Add(this.lblSector_1);
            this.panDaysMain.Controls.Add(comboBox1);
            this.panDaysMain.Controls.Add(this.comboSector_1);
            this.panDaysMain.Controls.Add(this.label1);
            this.panDaysMain.Location = new System.Drawing.Point(15, 10);
            this.panDaysMain.Name = "panDaysMain";
            this.panDaysMain.Size = new System.Drawing.Size(280, 288);
            this.panDaysMain.TabIndex = 6;
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(81, 47);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(50, 21);
            this.comboType.TabIndex = 4;
            this.comboType.Tag = "test";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(245, 102);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(30, 30);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(210, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Tag = "";
            this.label2.Text = "Setor 10:";
            this.label2.Visible = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(35, 49);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 2;
            this.lblType.Tag = "";
            this.lblType.Text = "Tipo:";
            // 
            // lblSector_1
            // 
            this.lblSector_1.AutoSize = true;
            this.lblSector_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSector_1.Location = new System.Drawing.Point(21, 79);
            this.lblSector_1.Name = "lblSector_1";
            this.lblSector_1.Size = new System.Drawing.Size(53, 16);
            this.lblSector_1.TabIndex = 2;
            this.lblSector_1.Tag = "";
            this.lblSector_1.Text = "Setor 1:";
            // 
            // comboSector_1
            // 
            this.comboSector_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSector_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSector_1.FormattingEnabled = true;
            this.comboSector_1.Location = new System.Drawing.Point(81, 77);
            this.comboSector_1.Name = "comboSector_1";
            this.comboSector_1.Size = new System.Drawing.Size(121, 21);
            this.comboSector_1.TabIndex = 1;
            this.comboSector_1.Tag = "sector";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione um ou mais Setores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(118, 304);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Consultar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panDaysTotal
            // 
            this.panDaysTotal.Controls.Add(this.panDaysMain);
            this.panDaysTotal.Controls.Add(this.btnSearch);
            this.panDaysTotal.Location = new System.Drawing.Point(514, 12);
            this.panDaysTotal.Name = "panDaysTotal";
            this.panDaysTotal.Size = new System.Drawing.Size(28, 33);
            this.panDaysTotal.TabIndex = 9;
            this.panDaysTotal.Visible = false;
            // 
            // panAddition
            // 
            this.panAddition.Controls.Add(this.btnEdit);
            this.panAddition.Controls.Add(this.btnAdditionScreen);
            this.panAddition.Location = new System.Drawing.Point(229, 63);
            this.panAddition.Name = "panAddition";
            this.panAddition.Size = new System.Drawing.Size(278, 270);
            this.panAddition.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(142, 136);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 29);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnAdditionScreen
            // 
            this.btnAdditionScreen.Location = new System.Drawing.Point(61, 137);
            this.btnAdditionScreen.Name = "btnAdditionScreen";
            this.btnAdditionScreen.Size = new System.Drawing.Size(75, 28);
            this.btnAdditionScreen.TabIndex = 0;
            this.btnAdditionScreen.Text = "Adicionar";
            this.btnAdditionScreen.UseVisualStyleBackColor = true;
            this.btnAdditionScreen.Click += new System.EventHandler(this.btnAdditionScreen_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 391);
            this.Controls.Add(this.panAddition);
            this.Controls.Add(this.panAccidents);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblToolName);
            this.Controls.Add(this.panDaysTotal);
            this.Name = "MainMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Test_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panAccidents.ResumeLayout(false);
            this.panAccidents.PerformLayout();
            this.panDataMenuPeriod.ResumeLayout(false);
            this.panDataMenuPeriod.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panDataMenuYear.ResumeLayout(false);
            this.panDataMenuYear.PerformLayout();
            this.panDataMenuAll.ResumeLayout(false);
            this.panDataMenuAll.PerformLayout();
            this.panDaysMain.ResumeLayout(false);
            this.panDaysMain.PerformLayout();
            this.panDaysTotal.ResumeLayout(false);
            this.panAddition.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDays;
        private System.Windows.Forms.Button btnAccidents;
        private System.Windows.Forms.Panel panAccidents;
        private System.Windows.Forms.Panel panDataMenuPeriod;
        private System.Windows.Forms.ComboBox comboFinalYear;
        private System.Windows.Forms.ComboBox comboInitialYear;
        private System.Windows.Forms.Label lblValue_2;
        private System.Windows.Forms.Label lblValue_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioYear;
        private System.Windows.Forms.RadioButton radioPeriod;
        private System.Windows.Forms.Label lblNoResults;
        private System.Windows.Forms.Button btnCreateChart;
        private System.Windows.Forms.Panel panDataMenuYear;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panDataMenuAll;
        private System.Windows.Forms.TextBox txtFinalYearAll;
        private System.Windows.Forms.TextBox txtInitialYearAll;
        private System.Windows.Forms.Label lblValue_2_All;
        private System.Windows.Forms.Label lblValue_1_All;
        private System.Windows.Forms.Label lblToolName;
        private System.Windows.Forms.Panel panDaysMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSector_1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSector_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentTag;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Panel panDaysTotal;
        private System.Windows.Forms.Panel panAddition;
        private System.Windows.Forms.Button btnAdditionScreen;
        private System.Windows.Forms.Button btnEdit;
    }
}