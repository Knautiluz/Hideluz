﻿namespace HideluzEstacionamentos
{
    partial class FormModifyClient
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
            this.RegisterClientPanel = new System.Windows.Forms.Panel();
            this.ClientTelTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientListBox = new System.Windows.Forms.ListBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.ClientEmailTextBox = new System.Windows.Forms.TextBox();
            this.LabelCity = new System.Windows.Forms.Label();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.ClientCepTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ClientCityTextBox = new System.Windows.Forms.TextBox();
            this.LabelCep = new System.Windows.Forms.Label();
            this.LabelState = new System.Windows.Forms.Label();
            this.LabelNeighborhood = new System.Windows.Forms.Label();
            this.ClientStateTextBox = new System.Windows.Forms.TextBox();
            this.ClientNeighborhoodTextBox = new System.Windows.Forms.TextBox();
            this.ClientDocumentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelStreet = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelDocument = new System.Windows.Forms.Label();
            this.ClientStreetNumberTextBox = new System.Windows.Forms.TextBox();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientStreetTextBox = new System.Windows.Forms.TextBox();
            this.ClientSearchTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientSearchBtn = new System.Windows.Forms.Button();
            this.RegisterClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterClientPanel
            // 
            this.RegisterClientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterClientPanel.Controls.Add(this.ClientTelTextBox);
            this.RegisterClientPanel.Controls.Add(this.label1);
            this.RegisterClientPanel.Controls.Add(this.ClientListBox);
            this.RegisterClientPanel.Controls.Add(this.LabelEmail);
            this.RegisterClientPanel.Controls.Add(this.ClientEmailTextBox);
            this.RegisterClientPanel.Controls.Add(this.LabelCity);
            this.RegisterClientPanel.Controls.Add(this.ChangeBtn);
            this.RegisterClientPanel.Controls.Add(this.ClientCepTextBox);
            this.RegisterClientPanel.Controls.Add(this.ClientCityTextBox);
            this.RegisterClientPanel.Controls.Add(this.LabelCep);
            this.RegisterClientPanel.Controls.Add(this.LabelState);
            this.RegisterClientPanel.Controls.Add(this.LabelNeighborhood);
            this.RegisterClientPanel.Controls.Add(this.ClientStateTextBox);
            this.RegisterClientPanel.Controls.Add(this.ClientNeighborhoodTextBox);
            this.RegisterClientPanel.Controls.Add(this.ClientDocumentTextBox);
            this.RegisterClientPanel.Controls.Add(this.LabelNumber);
            this.RegisterClientPanel.Controls.Add(this.LabelStreet);
            this.RegisterClientPanel.Controls.Add(this.LabelName);
            this.RegisterClientPanel.Controls.Add(this.LabelDocument);
            this.RegisterClientPanel.Controls.Add(this.ClientStreetNumberTextBox);
            this.RegisterClientPanel.Controls.Add(this.ClientNameTextBox);
            this.RegisterClientPanel.Controls.Add(this.ClientStreetTextBox);
            this.RegisterClientPanel.Enabled = false;
            this.RegisterClientPanel.Location = new System.Drawing.Point(29, 88);
            this.RegisterClientPanel.Name = "RegisterClientPanel";
            this.RegisterClientPanel.Size = new System.Drawing.Size(232, 462);
            this.RegisterClientPanel.TabIndex = 1;
            // 
            // ClientTelTextBox
            // 
            this.ClientTelTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.ClientTelTextBox.Location = new System.Drawing.Point(67, 136);
            this.ClientTelTextBox.Mask = "(00)00000-0000";
            this.ClientTelTextBox.Name = "ClientTelTextBox";
            this.ClientTelTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientTelTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(64, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Novo Telefone";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientListBox
            // 
            this.ClientListBox.FormattingEnabled = true;
            this.ClientListBox.Items.AddRange(new object[] {
            "Avulso",
            "Mensalista"});
            this.ClientListBox.Location = new System.Drawing.Point(67, 388);
            this.ClientListBox.Name = "ClientListBox";
            this.ClientListBox.Size = new System.Drawing.Size(100, 30);
            this.ClientListBox.TabIndex = 13;
            // 
            // LabelEmail
            // 
            this.LabelEmail.Location = new System.Drawing.Point(64, 81);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(103, 13);
            this.LabelEmail.TabIndex = 0;
            this.LabelEmail.Text = "Novo E-mail";
            this.LabelEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientEmailTextBox
            // 
            this.ClientEmailTextBox.Location = new System.Drawing.Point(67, 97);
            this.ClientEmailTextBox.Name = "ClientEmailTextBox";
            this.ClientEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientEmailTextBox.TabIndex = 5;
            // 
            // LabelCity
            // 
            this.LabelCity.Location = new System.Drawing.Point(64, 350);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(103, 13);
            this.LabelCity.TabIndex = 0;
            this.LabelCity.Text = "Nova Cidade";
            this.LabelCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(67, 420);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(100, 23);
            this.ChangeBtn.TabIndex = 14;
            this.ChangeBtn.Text = "Alterar";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // ClientCepTextBox
            // 
            this.ClientCepTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.ClientCepTextBox.Location = new System.Drawing.Point(67, 288);
            this.ClientCepTextBox.Mask = "00000-000";
            this.ClientCepTextBox.Name = "ClientCepTextBox";
            this.ClientCepTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientCepTextBox.TabIndex = 10;
            this.ClientCepTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientCityTextBox
            // 
            this.ClientCityTextBox.Location = new System.Drawing.Point(67, 366);
            this.ClientCityTextBox.Name = "ClientCityTextBox";
            this.ClientCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientCityTextBox.TabIndex = 12;
            // 
            // LabelCep
            // 
            this.LabelCep.Location = new System.Drawing.Point(64, 272);
            this.LabelCep.Name = "LabelCep";
            this.LabelCep.Size = new System.Drawing.Size(103, 13);
            this.LabelCep.TabIndex = 0;
            this.LabelCep.Text = "Novo CEP";
            this.LabelCep.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelState
            // 
            this.LabelState.Location = new System.Drawing.Point(64, 311);
            this.LabelState.Name = "LabelState";
            this.LabelState.Size = new System.Drawing.Size(103, 13);
            this.LabelState.TabIndex = 0;
            this.LabelState.Text = "Novo Estado";
            this.LabelState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelNeighborhood
            // 
            this.LabelNeighborhood.Location = new System.Drawing.Point(64, 233);
            this.LabelNeighborhood.Name = "LabelNeighborhood";
            this.LabelNeighborhood.Size = new System.Drawing.Size(103, 13);
            this.LabelNeighborhood.TabIndex = 0;
            this.LabelNeighborhood.Text = "Novo Bairro";
            this.LabelNeighborhood.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientStateTextBox
            // 
            this.ClientStateTextBox.Location = new System.Drawing.Point(67, 327);
            this.ClientStateTextBox.Name = "ClientStateTextBox";
            this.ClientStateTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientStateTextBox.TabIndex = 11;
            // 
            // ClientNeighborhoodTextBox
            // 
            this.ClientNeighborhoodTextBox.Location = new System.Drawing.Point(67, 249);
            this.ClientNeighborhoodTextBox.Name = "ClientNeighborhoodTextBox";
            this.ClientNeighborhoodTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientNeighborhoodTextBox.TabIndex = 9;
            // 
            // ClientDocumentTextBox
            // 
            this.ClientDocumentTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.ClientDocumentTextBox.Location = new System.Drawing.Point(67, 19);
            this.ClientDocumentTextBox.Mask = "000.000.000-00";
            this.ClientDocumentTextBox.Name = "ClientDocumentTextBox";
            this.ClientDocumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientDocumentTextBox.TabIndex = 3;
            this.ClientDocumentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelNumber
            // 
            this.LabelNumber.Location = new System.Drawing.Point(64, 195);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(103, 13);
            this.LabelNumber.TabIndex = 0;
            this.LabelNumber.Text = "Novo Nº";
            this.LabelNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelStreet
            // 
            this.LabelStreet.Location = new System.Drawing.Point(64, 159);
            this.LabelStreet.Name = "LabelStreet";
            this.LabelStreet.Size = new System.Drawing.Size(103, 13);
            this.LabelStreet.TabIndex = 0;
            this.LabelStreet.Text = "Nova Rua";
            this.LabelStreet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelName
            // 
            this.LabelName.Location = new System.Drawing.Point(64, 42);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(103, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Novo Nome";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelDocument
            // 
            this.LabelDocument.Location = new System.Drawing.Point(64, 3);
            this.LabelDocument.Name = "LabelDocument";
            this.LabelDocument.Size = new System.Drawing.Size(103, 13);
            this.LabelDocument.TabIndex = 0;
            this.LabelDocument.Text = "Novo CPF";
            this.LabelDocument.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientStreetNumberTextBox
            // 
            this.ClientStreetNumberTextBox.Location = new System.Drawing.Point(67, 210);
            this.ClientStreetNumberTextBox.Name = "ClientStreetNumberTextBox";
            this.ClientStreetNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientStreetNumberTextBox.TabIndex = 8;
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(67, 58);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientNameTextBox.TabIndex = 4;
            // 
            // ClientStreetTextBox
            // 
            this.ClientStreetTextBox.Location = new System.Drawing.Point(67, 172);
            this.ClientStreetTextBox.Name = "ClientStreetTextBox";
            this.ClientStreetTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientStreetTextBox.TabIndex = 7;
            // 
            // ClientSearchTextBox
            // 
            this.ClientSearchTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.ClientSearchTextBox.Location = new System.Drawing.Point(97, 38);
            this.ClientSearchTextBox.Mask = "000.000.000-00";
            this.ClientSearchTextBox.Name = "ClientSearchTextBox";
            this.ClientSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientSearchTextBox.TabIndex = 1;
            this.ClientSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(94, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientSearchBtn
            // 
            this.ClientSearchBtn.Location = new System.Drawing.Point(97, 62);
            this.ClientSearchBtn.Name = "ClientSearchBtn";
            this.ClientSearchBtn.Size = new System.Drawing.Size(100, 23);
            this.ClientSearchBtn.TabIndex = 2;
            this.ClientSearchBtn.Text = "Buscar";
            this.ClientSearchBtn.UseVisualStyleBackColor = true;
            this.ClientSearchBtn.Click += new System.EventHandler(this.ClientSearchBtn_Click);
            // 
            // ModifyClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 617);
            this.Controls.Add(this.ClientSearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientSearchTextBox);
            this.Controls.Add(this.RegisterClientPanel);
            this.Name = "ModifyClient";
            this.Text = "ModifyClient";
            this.RegisterClientPanel.ResumeLayout(false);
            this.RegisterClientPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RegisterClientPanel;
        private System.Windows.Forms.ListBox ClientListBox;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox ClientEmailTextBox;
        private System.Windows.Forms.Label LabelCity;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.MaskedTextBox ClientCepTextBox;
        private System.Windows.Forms.TextBox ClientCityTextBox;
        private System.Windows.Forms.Label LabelCep;
        private System.Windows.Forms.Label LabelState;
        private System.Windows.Forms.Label LabelNeighborhood;
        private System.Windows.Forms.TextBox ClientStateTextBox;
        private System.Windows.Forms.TextBox ClientNeighborhoodTextBox;
        private System.Windows.Forms.MaskedTextBox ClientDocumentTextBox;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelStreet;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelDocument;
        private System.Windows.Forms.TextBox ClientStreetNumberTextBox;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.TextBox ClientStreetTextBox;
        private System.Windows.Forms.MaskedTextBox ClientSearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClientSearchBtn;
        private System.Windows.Forms.MaskedTextBox ClientTelTextBox;
        private System.Windows.Forms.Label label1;
    }
}