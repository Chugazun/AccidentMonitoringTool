namespace Petrobras_AccidentsMonitoring_Tool
{
    partial class AccidentManagementScreen
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
            this.lblAccidentInfo = new System.Windows.Forms.Label();
            this.groupAccidentInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.hourBox = new System.Windows.Forms.DateTimePicker();
            this.txtWeekDay = new System.Windows.Forms.TextBox();
            this.dateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.lblBodyPart = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblWeekDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtBodyPart = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtInjuryType = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblInjuryType = new System.Windows.Forms.Label();
            this.panGrade = new System.Windows.Forms.Panel();
            this.lblGrade = new System.Windows.Forms.Label();
            this.comboGrade = new System.Windows.Forms.ComboBox();
            this.panClass = new System.Windows.Forms.Panel();
            this.lblClass = new System.Windows.Forms.Label();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.lblGenInfo = new System.Windows.Forms.Label();
            this.groupGenInfo = new System.Windows.Forms.GroupBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.txtJobRole = new System.Windows.Forms.TextBox();
            this.lblJobRole = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupAdditionalInfo = new System.Windows.Forms.GroupBox();
            this.txtRTA = new System.Windows.Forms.TextBox();
            this.txtCAT = new System.Windows.Forms.TextBox();
            this.lblCAT = new System.Windows.Forms.Label();
            this.lblRTA = new System.Windows.Forms.Label();
            this.lblAdditionalInfo = new System.Windows.Forms.Label();
            this.lblOptional = new System.Windows.Forms.Label();
            this.groupAccidentInfo.SuspendLayout();
            this.panGrade.SuspendLayout();
            this.panClass.SuspendLayout();
            this.groupGenInfo.SuspendLayout();
            this.groupAdditionalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccidentInfo
            // 
            this.lblAccidentInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccidentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccidentInfo.Location = new System.Drawing.Point(6, 167);
            this.lblAccidentInfo.Name = "lblAccidentInfo";
            this.lblAccidentInfo.Size = new System.Drawing.Size(200, 18);
            this.lblAccidentInfo.TabIndex = 4;
            this.lblAccidentInfo.Text = "Informações do Acidente";
            this.lblAccidentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupAccidentInfo
            // 
            this.groupAccidentInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupAccidentInfo.Controls.Add(this.label1);
            this.groupAccidentInfo.Controls.Add(this.comboType);
            this.groupAccidentInfo.Controls.Add(this.hourBox);
            this.groupAccidentInfo.Controls.Add(this.txtWeekDay);
            this.groupAccidentInfo.Controls.Add(this.dateTimeBox);
            this.groupAccidentInfo.Controls.Add(this.lblBodyPart);
            this.groupAccidentInfo.Controls.Add(this.lblPlace);
            this.groupAccidentInfo.Controls.Add(this.lblWeekDay);
            this.groupAccidentInfo.Controls.Add(this.lblDate);
            this.groupAccidentInfo.Controls.Add(this.txtBodyPart);
            this.groupAccidentInfo.Controls.Add(this.txtPlace);
            this.groupAccidentInfo.Controls.Add(this.lblTime);
            this.groupAccidentInfo.Controls.Add(this.txtDescription);
            this.groupAccidentInfo.Controls.Add(this.txtInjuryType);
            this.groupAccidentInfo.Controls.Add(this.lblDescription);
            this.groupAccidentInfo.Controls.Add(this.lblInjuryType);
            this.groupAccidentInfo.Controls.Add(this.panGrade);
            this.groupAccidentInfo.Controls.Add(this.panClass);
            this.groupAccidentInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupAccidentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAccidentInfo.Location = new System.Drawing.Point(12, 181);
            this.groupAccidentInfo.Margin = new System.Windows.Forms.Padding(0);
            this.groupAccidentInfo.Name = "groupAccidentInfo";
            this.groupAccidentInfo.Size = new System.Drawing.Size(936, 403);
            this.groupAccidentInfo.TabIndex = 2;
            this.groupAccidentInfo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // comboType
            // 
            this.comboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboType.BackColor = System.Drawing.SystemColors.Window;
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Típico",
            "Trajeto",
            "Equiparado"});
            this.comboType.Location = new System.Drawing.Point(560, 102);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(99, 24);
            this.comboType.TabIndex = 21;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // hourBox
            // 
            this.hourBox.CustomFormat = "HH:mm";
            this.hourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hourBox.Location = new System.Drawing.Point(560, 30);
            this.hourBox.Name = "hourBox";
            this.hourBox.ShowUpDown = true;
            this.hourBox.Size = new System.Drawing.Size(64, 24);
            this.hourBox.TabIndex = 7;
            this.hourBox.Value = new System.DateTime(2020, 6, 17, 0, 0, 0, 0);
            // 
            // txtWeekDay
            // 
            this.txtWeekDay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeekDay.Location = new System.Drawing.Point(351, 30);
            this.txtWeekDay.Name = "txtWeekDay";
            this.txtWeekDay.ReadOnly = true;
            this.txtWeekDay.Size = new System.Drawing.Size(69, 24);
            this.txtWeekDay.TabIndex = 6;
            // 
            // dateTimeBox
            // 
            this.dateTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBox.Location = new System.Drawing.Point(126, 30);
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.Size = new System.Drawing.Size(95, 24);
            this.dateTimeBox.TabIndex = 5;
            this.dateTimeBox.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimeBox.ValueChanged += new System.EventHandler(this.dateTimeBox_ValueChanged);
            // 
            // lblBodyPart
            // 
            this.lblBodyPart.AutoSize = true;
            this.lblBodyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodyPart.Location = new System.Drawing.Point(430, 69);
            this.lblBodyPart.Name = "lblBodyPart";
            this.lblBodyPart.Size = new System.Drawing.Size(129, 18);
            this.lblBodyPart.TabIndex = 0;
            this.lblBodyPart.Text = "Parte do Corpo:";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(71, 69);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(54, 18);
            this.lblPlace.TabIndex = 0;
            this.lblPlace.Text = "Local:";
            // 
            // lblWeekDay
            // 
            this.lblWeekDay.AutoSize = true;
            this.lblWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekDay.Location = new System.Drawing.Point(223, 33);
            this.lblWeekDay.Name = "lblWeekDay";
            this.lblWeekDay.Size = new System.Drawing.Size(127, 18);
            this.lblWeekDay.TabIndex = 0;
            this.lblWeekDay.Text = "Dia da Semana:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(77, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 18);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Data:";
            // 
            // txtBodyPart
            // 
            this.txtBodyPart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBodyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodyPart.Location = new System.Drawing.Point(560, 66);
            this.txtBodyPart.Name = "txtBodyPart";
            this.txtBodyPart.Size = new System.Drawing.Size(333, 24);
            this.txtBodyPart.TabIndex = 10;
            // 
            // txtPlace
            // 
            this.txtPlace.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlace.Location = new System.Drawing.Point(126, 66);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(294, 24);
            this.txtPlace.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(489, 33);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 18);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Horário:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(56, 187);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDescription.Size = new System.Drawing.Size(824, 198);
            this.txtDescription.TabIndex = 12;
            // 
            // txtInjuryType
            // 
            this.txtInjuryType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInjuryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInjuryType.Location = new System.Drawing.Point(126, 102);
            this.txtInjuryType.Name = "txtInjuryType";
            this.txtInjuryType.Size = new System.Drawing.Size(294, 24);
            this.txtInjuryType.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(370, 158);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(197, 18);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Descrição da Ocorrência";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInjuryType
            // 
            this.lblInjuryType.AutoSize = true;
            this.lblInjuryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInjuryType.Location = new System.Drawing.Point(66, 105);
            this.lblInjuryType.Name = "lblInjuryType";
            this.lblInjuryType.Size = new System.Drawing.Size(59, 18);
            this.lblInjuryType.TabIndex = 0;
            this.lblInjuryType.Text = "Lesão:";
            // 
            // panGrade
            // 
            this.panGrade.Controls.Add(this.lblGrade);
            this.panGrade.Controls.Add(this.comboGrade);
            this.panGrade.Location = new System.Drawing.Point(662, 99);
            this.panGrade.Name = "panGrade";
            this.panGrade.Size = new System.Drawing.Size(244, 30);
            this.panGrade.TabIndex = 22;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(3, 6);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(50, 18);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "Nível:";
            // 
            // comboGrade
            // 
            this.comboGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboGrade.BackColor = System.Drawing.SystemColors.Window;
            this.comboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGrade.FormattingEnabled = true;
            this.comboGrade.Items.AddRange(new object[] {
            "",
            "Sem Afastamento",
            "Com Afastamento"});
            this.comboGrade.Location = new System.Drawing.Point(54, 3);
            this.comboGrade.Name = "comboGrade";
            this.comboGrade.Size = new System.Drawing.Size(141, 24);
            this.comboGrade.TabIndex = 21;
            // 
            // panClass
            // 
            this.panClass.Controls.Add(this.lblClass);
            this.panClass.Controls.Add(this.comboClass);
            this.panClass.Location = new System.Drawing.Point(662, 99);
            this.panClass.Name = "panClass";
            this.panClass.Size = new System.Drawing.Size(244, 30);
            this.panClass.TabIndex = 22;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(3, 6);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(65, 18);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Classe:";
            // 
            // comboClass
            // 
            this.comboClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboClass.BackColor = System.Drawing.SystemColors.Window;
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
            this.comboClass.Location = new System.Drawing.Point(69, 3);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(39, 24);
            this.comboClass.TabIndex = 21;
            // 
            // lblGenInfo
            // 
            this.lblGenInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGenInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenInfo.Location = new System.Drawing.Point(6, 23);
            this.lblGenInfo.Name = "lblGenInfo";
            this.lblGenInfo.Size = new System.Drawing.Size(163, 18);
            this.lblGenInfo.TabIndex = 5;
            this.lblGenInfo.Text = "Informações Gerais";
            this.lblGenInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupGenInfo
            // 
            this.groupGenInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupGenInfo.Controls.Add(this.txtCompany);
            this.groupGenInfo.Controls.Add(this.lblName);
            this.groupGenInfo.Controls.Add(this.txtSector);
            this.groupGenInfo.Controls.Add(this.txtName);
            this.groupGenInfo.Controls.Add(this.lblSector);
            this.groupGenInfo.Controls.Add(this.txtJobRole);
            this.groupGenInfo.Controls.Add(this.lblJobRole);
            this.groupGenInfo.Controls.Add(this.lblCompany);
            this.groupGenInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGenInfo.Location = new System.Drawing.Point(12, 37);
            this.groupGenInfo.Margin = new System.Windows.Forms.Padding(0);
            this.groupGenInfo.Name = "groupGenInfo";
            this.groupGenInfo.Size = new System.Drawing.Size(936, 115);
            this.groupGenInfo.TabIndex = 1;
            this.groupGenInfo.TabStop = false;
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCompany.Location = new System.Drawing.Point(126, 30);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(294, 24);
            this.txtCompany.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(67, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // txtSector
            // 
            this.txtSector.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSector.Location = new System.Drawing.Point(490, 30);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(144, 24);
            this.txtSector.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(126, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 24);
            this.txtName.TabIndex = 3;
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSector.Location = new System.Drawing.Point(435, 33);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(54, 18);
            this.lblSector.TabIndex = 0;
            this.lblSector.Text = "Setor:";
            // 
            // txtJobRole
            // 
            this.txtJobRole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtJobRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobRole.Location = new System.Drawing.Point(490, 66);
            this.txtJobRole.Name = "txtJobRole";
            this.txtJobRole.Size = new System.Drawing.Size(403, 24);
            this.txtJobRole.TabIndex = 4;
            // 
            // lblJobRole
            // 
            this.lblJobRole.AutoSize = true;
            this.lblJobRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobRole.Location = new System.Drawing.Point(430, 69);
            this.lblJobRole.Name = "lblJobRole";
            this.lblJobRole.Size = new System.Drawing.Size(59, 18);
            this.lblJobRole.TabIndex = 0;
            this.lblJobRole.Text = "Cargo:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(45, 33);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(80, 18);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Empresa:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(435, 703);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 38);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // groupAdditionalInfo
            // 
            this.groupAdditionalInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupAdditionalInfo.Controls.Add(this.txtRTA);
            this.groupAdditionalInfo.Controls.Add(this.txtCAT);
            this.groupAdditionalInfo.Controls.Add(this.lblCAT);
            this.groupAdditionalInfo.Controls.Add(this.lblRTA);
            this.groupAdditionalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAdditionalInfo.Location = new System.Drawing.Point(12, 614);
            this.groupAdditionalInfo.Margin = new System.Windows.Forms.Padding(0);
            this.groupAdditionalInfo.Name = "groupAdditionalInfo";
            this.groupAdditionalInfo.Size = new System.Drawing.Size(936, 77);
            this.groupAdditionalInfo.TabIndex = 3;
            this.groupAdditionalInfo.TabStop = false;
            // 
            // txtRTA
            // 
            this.txtRTA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRTA.Location = new System.Drawing.Point(102, 30);
            this.txtRTA.Name = "txtRTA";
            this.txtRTA.Size = new System.Drawing.Size(294, 24);
            this.txtRTA.TabIndex = 15;
            // 
            // txtCAT
            // 
            this.txtCAT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCAT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCAT.Location = new System.Drawing.Point(476, 30);
            this.txtCAT.Name = "txtCAT";
            this.txtCAT.Size = new System.Drawing.Size(144, 24);
            this.txtCAT.TabIndex = 16;
            // 
            // lblCAT
            // 
            this.lblCAT.AutoSize = true;
            this.lblCAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCAT.Location = new System.Drawing.Point(430, 33);
            this.lblCAT.Name = "lblCAT";
            this.lblCAT.Size = new System.Drawing.Size(45, 18);
            this.lblCAT.TabIndex = 0;
            this.lblCAT.Text = "CAT:";
            // 
            // lblRTA
            // 
            this.lblRTA.AutoSize = true;
            this.lblRTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTA.Location = new System.Drawing.Point(56, 33);
            this.lblRTA.Name = "lblRTA";
            this.lblRTA.Size = new System.Drawing.Size(45, 18);
            this.lblRTA.TabIndex = 0;
            this.lblRTA.Text = "RTA:";
            // 
            // lblAdditionalInfo
            // 
            this.lblAdditionalInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdditionalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalInfo.Location = new System.Drawing.Point(0, 599);
            this.lblAdditionalInfo.Name = "lblAdditionalInfo";
            this.lblAdditionalInfo.Size = new System.Drawing.Size(200, 18);
            this.lblAdditionalInfo.TabIndex = 4;
            this.lblAdditionalInfo.Text = "Informações Adicionais";
            this.lblAdditionalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOptional
            // 
            this.lblOptional.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOptional.AutoSize = true;
            this.lblOptional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptional.Location = new System.Drawing.Point(188, 600);
            this.lblOptional.Name = "lblOptional";
            this.lblOptional.Size = new System.Drawing.Size(80, 16);
            this.lblOptional.TabIndex = 7;
            this.lblOptional.Text = "*(opcionais)";
            // 
            // AccidentManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 753);
            this.Controls.Add(this.lblOptional);
            this.Controls.Add(this.lblAdditionalInfo);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblAccidentInfo);
            this.Controls.Add(this.groupAccidentInfo);
            this.Controls.Add(this.lblGenInfo);
            this.Controls.Add(this.groupAdditionalInfo);
            this.Controls.Add(this.groupGenInfo);
            this.Name = "AccidentManagementScreen";
            this.Text = "Adicionar Acidente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccidentAdditionScreen_FormClosing);
            this.Load += new System.EventHandler(this.AccidentAdditionScreen_Load);
            this.groupAccidentInfo.ResumeLayout(false);
            this.groupAccidentInfo.PerformLayout();
            this.panGrade.ResumeLayout(false);
            this.panGrade.PerformLayout();
            this.panClass.ResumeLayout(false);
            this.panClass.PerformLayout();
            this.groupGenInfo.ResumeLayout(false);
            this.groupGenInfo.PerformLayout();
            this.groupAdditionalInfo.ResumeLayout(false);
            this.groupAdditionalInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccidentInfo;
        private System.Windows.Forms.GroupBox groupAccidentInfo;
        private System.Windows.Forms.Label lblBodyPart;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblWeekDay;
        private System.Windows.Forms.TextBox txtWeekDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtBodyPart;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtInjuryType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblInjuryType;
        private System.Windows.Forms.Label lblGenInfo;
        private System.Windows.Forms.GroupBox groupGenInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.TextBox txtJobRole;
        private System.Windows.Forms.Label lblJobRole;
        private System.Windows.Forms.DateTimePicker dateTimeBox;
        private System.Windows.Forms.DateTimePicker hourBox;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupAdditionalInfo;
        private System.Windows.Forms.TextBox txtRTA;
        private System.Windows.Forms.TextBox txtCAT;
        private System.Windows.Forms.Label lblCAT;
        private System.Windows.Forms.Label lblRTA;
        private System.Windows.Forms.Label lblAdditionalInfo;
        private System.Windows.Forms.Label lblOptional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Panel panGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox comboGrade;
        private System.Windows.Forms.Panel panClass;
    }
}