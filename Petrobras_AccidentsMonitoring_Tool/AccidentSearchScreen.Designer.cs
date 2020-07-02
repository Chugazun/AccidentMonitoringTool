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
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInjury = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInjury = new System.Windows.Forms.Label();
            this.txtInjury = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupDate = new System.Windows.Forms.GroupBox();
            this.radioExactDate = new System.Windows.Forms.RadioButton();
            this.radioYear = new System.Windows.Forms.RadioButton();
            this.radioInterval = new System.Windows.Forms.RadioButton();
            this.panInterval = new System.Windows.Forms.Panel();
            this.dateBoxInterval_Final = new System.Windows.Forms.DateTimePicker();
            this.dateboxInterval_Initial = new System.Windows.Forms.DateTimePicker();
            this.lblInterval_FinalDate = new System.Windows.Forms.Label();
            this.lblInterval_InitialDate = new System.Windows.Forms.Label();
            this.panYear = new System.Windows.Forms.Panel();
            this.dateBoxYear = new System.Windows.Forms.DateTimePicker();
            this.lblYear = new System.Windows.Forms.Label();
            this.panExactDate = new System.Windows.Forms.Panel();
            this.dateBoxExact = new System.Windows.Forms.DateTimePicker();
            this.lblExactDate = new System.Windows.Forms.Label();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.groupType = new System.Windows.Forms.GroupBox();
            this.panClass = new System.Windows.Forms.Panel();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.groupDate.SuspendLayout();
            this.panInterval.SuspendLayout();
            this.panYear.SuspendLayout();
            this.panExactDate.SuspendLayout();
            this.groupType.SuspendLayout();
            this.panClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // listResults
            // 
            this.listResults.AutoArrange = false;
            this.listResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCompany,
            this.colSector,
            this.colEmployee,
            this.colDate,
            this.colClass,
            this.colInjury});
            this.listResults.FullRowSelect = true;
            this.listResults.GridLines = true;
            this.listResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listResults.HideSelection = false;
            this.listResults.LabelWrap = false;
            this.listResults.Location = new System.Drawing.Point(23, 312);
            this.listResults.Name = "listResults";
            this.listResults.OwnerDraw = true;
            this.listResults.ShowGroups = false;
            this.listResults.Size = new System.Drawing.Size(748, 131);
            this.listResults.TabIndex = 0;
            this.listResults.TabStop = false;
            this.listResults.UseCompatibleStateImageBehavior = false;
            this.listResults.View = System.Windows.Forms.View.Details;
            this.listResults.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            this.listResults.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listResults.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView1_DrawSubItem);
            this.listResults.Click += new System.EventHandler(this.listResults_ItemClick);
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
            // colDate
            // 
            this.colDate.Text = "Data";
            // 
            // colClass
            // 
            this.colClass.Text = "Classe";
            // 
            // colInjury
            // 
            this.colInjury.Text = "Tipo de Lesão";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(322, 283);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(20, 296);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(66, 13);
            this.lblResults.TabIndex = 2;
            this.lblResults.Text = "Resultados: ";
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCompany.Location = new System.Drawing.Point(100, 60);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(218, 22);
            this.txtCompany.TabIndex = 1;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(25, 63);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(74, 16);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "Empresa:";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSector.Location = new System.Drawing.Point(322, 63);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(49, 16);
            this.lblSector.TabIndex = 3;
            this.lblSector.Text = "Setor:";
            // 
            // txtSector
            // 
            this.txtSector.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSector.Location = new System.Drawing.Point(372, 60);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(128, 22);
            this.txtSector.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(506, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nome:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(560, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 22);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Buscar Acidentes";
            // 
            // lblInjury
            // 
            this.lblInjury.AutoSize = true;
            this.lblInjury.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInjury.Location = new System.Drawing.Point(44, 97);
            this.lblInjury.Name = "lblInjury";
            this.lblInjury.Size = new System.Drawing.Size(55, 16);
            this.lblInjury.TabIndex = 3;
            this.lblInjury.Text = "Lesão:";
            // 
            // txtInjury
            // 
            this.txtInjury.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInjury.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInjury.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInjury.Location = new System.Drawing.Point(100, 94);
            this.txtInjury.Name = "txtInjury";
            this.txtInjury.Size = new System.Drawing.Size(218, 22);
            this.txtInjury.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Data:";
            // 
            // groupDate
            // 
            this.groupDate.Controls.Add(this.radioExactDate);
            this.groupDate.Controls.Add(this.radioYear);
            this.groupDate.Controls.Add(this.radioInterval);
            this.groupDate.Controls.Add(this.lblDate);
            this.groupDate.Controls.Add(this.panInterval);
            this.groupDate.Controls.Add(this.panYear);
            this.groupDate.Controls.Add(this.panExactDate);
            this.groupDate.Location = new System.Drawing.Point(47, 132);
            this.groupDate.Name = "groupDate";
            this.groupDate.Size = new System.Drawing.Size(301, 111);
            this.groupDate.TabIndex = 5;
            this.groupDate.TabStop = false;
            // 
            // radioExactDate
            // 
            this.radioExactDate.AutoSize = true;
            this.radioExactDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioExactDate.Location = new System.Drawing.Point(176, 12);
            this.radioExactDate.Name = "radioExactDate";
            this.radioExactDate.Size = new System.Drawing.Size(121, 20);
            this.radioExactDate.TabIndex = 10;
            this.radioExactDate.Text = "Data Específica";
            this.radioExactDate.UseVisualStyleBackColor = true;
            this.radioExactDate.CheckedChanged += new System.EventHandler(this.radioExactDate_CheckedChanged);
            // 
            // radioYear
            // 
            this.radioYear.AutoSize = true;
            this.radioYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioYear.Location = new System.Drawing.Point(126, 12);
            this.radioYear.Name = "radioYear";
            this.radioYear.Size = new System.Drawing.Size(50, 20);
            this.radioYear.TabIndex = 10;
            this.radioYear.Text = "Ano";
            this.radioYear.UseVisualStyleBackColor = true;
            this.radioYear.CheckedChanged += new System.EventHandler(this.radioYear_CheckedChanged);
            // 
            // radioInterval
            // 
            this.radioInterval.AutoSize = true;
            this.radioInterval.Checked = true;
            this.radioInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioInterval.Location = new System.Drawing.Point(52, 12);
            this.radioInterval.Name = "radioInterval";
            this.radioInterval.Size = new System.Drawing.Size(77, 20);
            this.radioInterval.TabIndex = 10;
            this.radioInterval.TabStop = true;
            this.radioInterval.Text = "Intervalo";
            this.radioInterval.UseVisualStyleBackColor = true;
            this.radioInterval.CheckedChanged += new System.EventHandler(this.radioInterval_CheckedChanged);
            // 
            // panInterval
            // 
            this.panInterval.Controls.Add(this.dateBoxInterval_Final);
            this.panInterval.Controls.Add(this.dateboxInterval_Initial);
            this.panInterval.Controls.Add(this.lblInterval_FinalDate);
            this.panInterval.Controls.Add(this.lblInterval_InitialDate);
            this.panInterval.Location = new System.Drawing.Point(19, 35);
            this.panInterval.Name = "panInterval";
            this.panInterval.Size = new System.Drawing.Size(262, 68);
            this.panInterval.TabIndex = 6;
            // 
            // dateBoxInterval_Final
            // 
            this.dateBoxInterval_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBoxInterval_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBoxInterval_Final.Location = new System.Drawing.Point(128, 38);
            this.dateBoxInterval_Final.Name = "dateBoxInterval_Final";
            this.dateBoxInterval_Final.Size = new System.Drawing.Size(86, 22);
            this.dateBoxInterval_Final.TabIndex = 6;
            this.dateBoxInterval_Final.TabStop = false;
            // 
            // dateboxInterval_Initial
            // 
            this.dateboxInterval_Initial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateboxInterval_Initial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateboxInterval_Initial.Location = new System.Drawing.Point(128, 9);
            this.dateboxInterval_Initial.Name = "dateboxInterval_Initial";
            this.dateboxInterval_Initial.Size = new System.Drawing.Size(86, 22);
            this.dateboxInterval_Initial.TabIndex = 5;
            this.dateboxInterval_Initial.TabStop = false;
            this.dateboxInterval_Initial.Value = new System.DateTime(2014, 1, 1, 13, 7, 0, 0);
            // 
            // lblInterval_FinalDate
            // 
            this.lblInterval_FinalDate.AutoSize = true;
            this.lblInterval_FinalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval_FinalDate.Location = new System.Drawing.Point(54, 41);
            this.lblInterval_FinalDate.Name = "lblInterval_FinalDate";
            this.lblInterval_FinalDate.Size = new System.Drawing.Size(72, 16);
            this.lblInterval_FinalDate.TabIndex = 3;
            this.lblInterval_FinalDate.Text = "Data Final:";
            // 
            // lblInterval_InitialDate
            // 
            this.lblInterval_InitialDate.AutoSize = true;
            this.lblInterval_InitialDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval_InitialDate.Location = new System.Drawing.Point(49, 12);
            this.lblInterval_InitialDate.Name = "lblInterval_InitialDate";
            this.lblInterval_InitialDate.Size = new System.Drawing.Size(77, 16);
            this.lblInterval_InitialDate.TabIndex = 3;
            this.lblInterval_InitialDate.Text = "Data Inicial:";
            // 
            // panYear
            // 
            this.panYear.Controls.Add(this.dateBoxYear);
            this.panYear.Controls.Add(this.lblYear);
            this.panYear.Location = new System.Drawing.Point(19, 35);
            this.panYear.Name = "panYear";
            this.panYear.Size = new System.Drawing.Size(262, 68);
            this.panYear.TabIndex = 6;
            // 
            // dateBoxYear
            // 
            this.dateBoxYear.CustomFormat = "yyyy";
            this.dateBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBoxYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBoxYear.Location = new System.Drawing.Point(107, 23);
            this.dateBoxYear.Name = "dateBoxYear";
            this.dateBoxYear.ShowUpDown = true;
            this.dateBoxYear.Size = new System.Drawing.Size(86, 22);
            this.dateBoxYear.TabIndex = 5;
            this.dateBoxYear.TabStop = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(70, 26);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(35, 16);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Ano:";
            // 
            // panExactDate
            // 
            this.panExactDate.Controls.Add(this.dateBoxExact);
            this.panExactDate.Controls.Add(this.lblExactDate);
            this.panExactDate.Location = new System.Drawing.Point(19, 35);
            this.panExactDate.Name = "panExactDate";
            this.panExactDate.Size = new System.Drawing.Size(262, 68);
            this.panExactDate.TabIndex = 6;
            // 
            // dateBoxExact
            // 
            this.dateBoxExact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBoxExact.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBoxExact.Location = new System.Drawing.Point(109, 23);
            this.dateBoxExact.Name = "dateBoxExact";
            this.dateBoxExact.Size = new System.Drawing.Size(86, 22);
            this.dateBoxExact.TabIndex = 5;
            this.dateBoxExact.TabStop = false;
            // 
            // lblExactDate
            // 
            this.lblExactDate.AutoSize = true;
            this.lblExactDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExactDate.Location = new System.Drawing.Point(67, 26);
            this.lblExactDate.Name = "lblExactDate";
            this.lblExactDate.Size = new System.Drawing.Size(40, 16);
            this.lblExactDate.TabIndex = 3;
            this.lblExactDate.Text = "Data:";
            // 
            // btnClearResults
            // 
            this.btnClearResults.Location = new System.Drawing.Point(403, 283);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(75, 23);
            this.btnClearResults.TabIndex = 7;
            this.btnClearResults.Text = "Limpar";
            this.btnClearResults.UseVisualStyleBackColor = true;
            this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // groupType
            // 
            this.groupType.Controls.Add(this.panClass);
            this.groupType.Controls.Add(this.comboType);
            this.groupType.Controls.Add(this.lblType);
            this.groupType.Location = new System.Drawing.Point(471, 132);
            this.groupType.Name = "groupType";
            this.groupType.Size = new System.Drawing.Size(300, 51);
            this.groupType.TabIndex = 6;
            this.groupType.TabStop = false;
            // 
            // panClass
            // 
            this.panClass.Controls.Add(this.comboClass);
            this.panClass.Controls.Add(this.lblClass);
            this.panClass.Location = new System.Drawing.Point(178, 12);
            this.panClass.Name = "panClass";
            this.panClass.Size = new System.Drawing.Size(107, 31);
            this.panClass.TabIndex = 5;
            // 
            // comboClass
            // 
            this.comboClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Items.AddRange(new object[] {
            "",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboClass.Location = new System.Drawing.Point(64, 4);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(34, 24);
            this.comboClass.TabIndex = 4;
            this.comboClass.TabStop = false;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(3, 7);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(60, 16);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "Classe:";
            // 
            // comboType
            // 
            this.comboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Típico",
            "Trajeto",
            "Equiparado",
            "Todos"});
            this.comboType.Location = new System.Drawing.Point(51, 16);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(121, 24);
            this.comboType.TabIndex = 5;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(6, 19);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 16);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Tipo:";
            // 
            // AccidentSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.groupType);
            this.Controls.Add(this.groupDate);
            this.Controls.Add(this.txtSector);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtInjury);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInjury);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnClearResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.listResults);
            this.Name = "AccidentSearchScreen";
            this.Text = "Buscar Acidentes";
            this.Load += new System.EventHandler(this.AccidentSearchScreen_Load);
            this.groupDate.ResumeLayout(false);
            this.groupDate.PerformLayout();
            this.panInterval.ResumeLayout(false);
            this.panInterval.PerformLayout();
            this.panYear.ResumeLayout(false);
            this.panYear.PerformLayout();
            this.panExactDate.ResumeLayout(false);
            this.panExactDate.PerformLayout();
            this.groupType.ResumeLayout(false);
            this.groupType.PerformLayout();
            this.panClass.ResumeLayout(false);
            this.panClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listResults;
        private System.Windows.Forms.ColumnHeader colCompany;
        private System.Windows.Forms.ColumnHeader colSector;
        private System.Windows.Forms.ColumnHeader colEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colClass;
        private System.Windows.Forms.ColumnHeader colInjury;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInjury;
        private System.Windows.Forms.TextBox txtInjury;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupDate;
        private System.Windows.Forms.Panel panInterval;
        private System.Windows.Forms.DateTimePicker dateBoxInterval_Final;
        private System.Windows.Forms.DateTimePicker dateboxInterval_Initial;
        private System.Windows.Forms.Label lblInterval_FinalDate;
        private System.Windows.Forms.Label lblInterval_InitialDate;
        private System.Windows.Forms.RadioButton radioExactDate;
        private System.Windows.Forms.RadioButton radioYear;
        private System.Windows.Forms.RadioButton radioInterval;
        private System.Windows.Forms.Panel panExactDate;
        private System.Windows.Forms.DateTimePicker dateBoxExact;
        private System.Windows.Forms.Label lblExactDate;
        private System.Windows.Forms.Panel panYear;
        private System.Windows.Forms.DateTimePicker dateBoxYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnClearResults;
        private System.Windows.Forms.GroupBox groupType;
        private System.Windows.Forms.Panel panClass;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label lblType;
    }
}