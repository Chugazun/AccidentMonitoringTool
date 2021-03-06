﻿namespace Petrobras_AccidentsMonitoring_Tool
{
    partial class AccidentDetailsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccidentDetailsScreen));
            this.groupGenInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.txtJobRole = new System.Windows.Forms.TextBox();
            this.lblJobRole = new System.Windows.Forms.Label();
            this.lblGenInfo = new System.Windows.Forms.Label();
            this.groupAccidentInfo = new System.Windows.Forms.GroupBox();
            this.lblBodyPart = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblWeekDay = new System.Windows.Forms.Label();
            this.txtWeekDay = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtBodyPart = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtInjuryType = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblInjuryType = new System.Windows.Forms.Label();
            this.lblAccidentInfo = new System.Windows.Forms.Label();
            this.groupGenInfo.SuspendLayout();
            this.groupAccidentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupGenInfo
            // 
            this.groupGenInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupGenInfo.Controls.Add(this.lblName);
            this.groupGenInfo.Controls.Add(this.lblCompany);
            this.groupGenInfo.Controls.Add(this.txtCompany);
            this.groupGenInfo.Controls.Add(this.txtSector);
            this.groupGenInfo.Controls.Add(this.txtName);
            this.groupGenInfo.Controls.Add(this.lblSector);
            this.groupGenInfo.Controls.Add(this.txtJobRole);
            this.groupGenInfo.Controls.Add(this.lblJobRole);
            this.groupGenInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGenInfo.Location = new System.Drawing.Point(12, 37);
            this.groupGenInfo.Margin = new System.Windows.Forms.Padding(0);
            this.groupGenInfo.Name = "groupGenInfo";
            this.groupGenInfo.Size = new System.Drawing.Size(936, 115);
            this.groupGenInfo.TabIndex = 3;
            this.groupGenInfo.TabStop = false;
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
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(126, 30);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(294, 24);
            this.txtCompany.TabIndex = 2;
            this.txtCompany.Text = "Pronto Express Tpc";
            // 
            // txtSector
            // 
            this.txtSector.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSector.Location = new System.Drawing.Point(490, 30);
            this.txtSector.Name = "txtSector";
            this.txtSector.ReadOnly = true;
            this.txtSector.Size = new System.Drawing.Size(144, 24);
            this.txtSector.TabIndex = 2;
            this.txtSector.Text = "RNEST/ESTO/SOP";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(126, 66);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(294, 24);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Sylvio Leopoldo de Macambira Barbosa";
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
            this.txtJobRole.ReadOnly = true;
            this.txtJobRole.Size = new System.Drawing.Size(403, 24);
            this.txtJobRole.TabIndex = 2;
            this.txtJobRole.Text = "Técnico de Inspeção De Equipamentos e Instalações Pleno\r\n";
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
            // lblGenInfo
            // 
            this.lblGenInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGenInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenInfo.Location = new System.Drawing.Point(6, 23);
            this.lblGenInfo.Name = "lblGenInfo";
            this.lblGenInfo.Size = new System.Drawing.Size(163, 18);
            this.lblGenInfo.TabIndex = 0;
            this.lblGenInfo.Text = "Informações Gerais";
            this.lblGenInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupAccidentInfo
            // 
            this.groupAccidentInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupAccidentInfo.Controls.Add(this.lblBodyPart);
            this.groupAccidentInfo.Controls.Add(this.lblPlace);
            this.groupAccidentInfo.Controls.Add(this.lblWeekDay);
            this.groupAccidentInfo.Controls.Add(this.txtWeekDay);
            this.groupAccidentInfo.Controls.Add(this.lblDate);
            this.groupAccidentInfo.Controls.Add(this.txtDate);
            this.groupAccidentInfo.Controls.Add(this.txtTime);
            this.groupAccidentInfo.Controls.Add(this.txtClass);
            this.groupAccidentInfo.Controls.Add(this.txtBodyPart);
            this.groupAccidentInfo.Controls.Add(this.txtPlace);
            this.groupAccidentInfo.Controls.Add(this.lblTime);
            this.groupAccidentInfo.Controls.Add(this.lblClass);
            this.groupAccidentInfo.Controls.Add(this.txtDescription);
            this.groupAccidentInfo.Controls.Add(this.txtInjuryType);
            this.groupAccidentInfo.Controls.Add(this.lblDescription);
            this.groupAccidentInfo.Controls.Add(this.lblInjuryType);
            this.groupAccidentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAccidentInfo.Location = new System.Drawing.Point(12, 181);
            this.groupAccidentInfo.Margin = new System.Windows.Forms.Padding(0);
            this.groupAccidentInfo.Name = "groupAccidentInfo";
            this.groupAccidentInfo.Size = new System.Drawing.Size(936, 403);
            this.groupAccidentInfo.TabIndex = 3;
            this.groupAccidentInfo.TabStop = false;
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
            this.lblWeekDay.Location = new System.Drawing.Point(217, 33);
            this.lblWeekDay.Name = "lblWeekDay";
            this.lblWeekDay.Size = new System.Drawing.Size(127, 18);
            this.lblWeekDay.TabIndex = 0;
            this.lblWeekDay.Text = "Dia da Semana:";
            // 
            // txtWeekDay
            // 
            this.txtWeekDay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeekDay.Location = new System.Drawing.Point(345, 30);
            this.txtWeekDay.Name = "txtWeekDay";
            this.txtWeekDay.ReadOnly = true;
            this.txtWeekDay.Size = new System.Drawing.Size(75, 24);
            this.txtWeekDay.TabIndex = 2;
            this.txtWeekDay.Text = "Domingo";
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
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(126, 30);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(83, 24);
            this.txtDate.TabIndex = 2;
            this.txtDate.Text = "18/12/1994";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(560, 30);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(48, 24);
            this.txtTime.TabIndex = 2;
            this.txtTime.Text = "00:00";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(682, 30);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(24, 24);
            this.txtClass.TabIndex = 2;
            this.txtClass.Text = "0";
            this.txtClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBodyPart
            // 
            this.txtBodyPart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBodyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodyPart.Location = new System.Drawing.Point(560, 66);
            this.txtBodyPart.Name = "txtBodyPart";
            this.txtBodyPart.ReadOnly = true;
            this.txtBodyPart.Size = new System.Drawing.Size(333, 24);
            this.txtBodyPart.TabIndex = 2;
            this.txtBodyPart.Text = "Estacionamento do Restaurante";
            // 
            // txtPlace
            // 
            this.txtPlace.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlace.Location = new System.Drawing.Point(126, 66);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.ReadOnly = true;
            this.txtPlace.Size = new System.Drawing.Size(294, 24);
            this.txtPlace.TabIndex = 2;
            this.txtPlace.Text = "Estacionamento do Restaurante";
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
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(616, 33);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(65, 18);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Classe:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(56, 187);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDescription.Size = new System.Drawing.Size(824, 198);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = resources.GetString("txtDescription.Text");
            // 
            // txtInjuryType
            // 
            this.txtInjuryType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInjuryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInjuryType.Location = new System.Drawing.Point(126, 102);
            this.txtInjuryType.Name = "txtInjuryType";
            this.txtInjuryType.ReadOnly = true;
            this.txtInjuryType.Size = new System.Drawing.Size(294, 24);
            this.txtInjuryType.TabIndex = 2;
            this.txtInjuryType.Text = "Perfuração Por Projétil (Arma de Fogo)";
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
            // lblAccidentInfo
            // 
            this.lblAccidentInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccidentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccidentInfo.Location = new System.Drawing.Point(6, 167);
            this.lblAccidentInfo.Name = "lblAccidentInfo";
            this.lblAccidentInfo.Size = new System.Drawing.Size(200, 18);
            this.lblAccidentInfo.TabIndex = 0;
            this.lblAccidentInfo.Text = "Informações do Acidente";
            this.lblAccidentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccidentDetailsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(960, 658);
            this.Controls.Add(this.lblAccidentInfo);
            this.Controls.Add(this.groupAccidentInfo);
            this.Controls.Add(this.lblGenInfo);
            this.Controls.Add(this.groupGenInfo);
            this.Name = "AccidentDetailsScreen";
            this.Text = "Detalhes do Acidente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccidentDetailsScreen_Load);
            this.groupGenInfo.ResumeLayout(false);
            this.groupGenInfo.PerformLayout();
            this.groupAccidentInfo.ResumeLayout(false);
            this.groupAccidentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupGenInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.TextBox txtJobRole;
        private System.Windows.Forms.Label lblJobRole;
        private System.Windows.Forms.Label lblGenInfo;
        private System.Windows.Forms.GroupBox groupAccidentInfo;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtInjuryType;
        private System.Windows.Forms.Label lblInjuryType;
        private System.Windows.Forms.Label lblAccidentInfo;
        private System.Windows.Forms.Label lblWeekDay;
        private System.Windows.Forms.TextBox txtWeekDay;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBodyPart;
        private System.Windows.Forms.TextBox txtBodyPart;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}