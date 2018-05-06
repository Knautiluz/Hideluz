﻿namespace HideluzEstacionamentos
{
    partial class RegisterClient
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
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelStreet = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelDocument = new System.Windows.Forms.Label();
            this.ClientStreetNumberTextBox = new System.Windows.Forms.TextBox();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientStreetTextBox = new System.Windows.Forms.TextBox();
            this.ClientDocumentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ClientNeighborhoodTextBox = new System.Windows.Forms.TextBox();
            this.LabelNeighborhood = new System.Windows.Forms.Label();
            this.LabelCep = new System.Windows.Forms.Label();
            this.ClientCepTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ClientStateTextBox = new System.Windows.Forms.TextBox();
            this.LabelState = new System.Windows.Forms.Label();
            this.ClientCityTextBox = new System.Windows.Forms.TextBox();
            this.LabelCity = new System.Windows.Forms.Label();
            this.ClientEmailTextBox = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.ClientListBox = new System.Windows.Forms.ListBox();
            this.RegisterClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterClientPanel
            // 
            this.RegisterClientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterClientPanel.Controls.Add(this.ClientListBox);
            this.RegisterClientPanel.Controls.Add(this.LabelEmail);
            this.RegisterClientPanel.Controls.Add(this.ClientEmailTextBox);
            this.RegisterClientPanel.Controls.Add(this.LabelCity);
            this.RegisterClientPanel.Controls.Add(this.SignupBtn);
            this.RegisterClientPanel.Controls.Add(this.ClientCepTextBox);
            this.RegisterClientPanel.Controls.Add(this.ClientCityTextBox);
            this.RegisterClientPanel.Controls.Add(this.LabelCep);
            this.RegisterClientPanel.Controls.Add(this.LabelState);
            this.RegisterClientPanel.Controls.Add(this.LabelNeighborhood);
            this.RegisterClientPanel.Controls.Add(this.ClientStateTextBox);
            this.RegisterClientPanel.Controls.Add(this.ClientNeighborhoodTextBox);
            this.RegisterClientPanel.Controls.Add(this.ClientDocumentTextBox);
            this.RegisterClientPanel.Controls.Add(this.ResultLabel);
            this.RegisterClientPanel.Controls.Add(this.LabelNumber);
            this.RegisterClientPanel.Controls.Add(this.LabelStreet);
            this.RegisterClientPanel.Controls.Add(this.LabelName);
            this.RegisterClientPanel.Controls.Add(this.LabelDocument);
            this.RegisterClientPanel.Controls.Add(this.ClientStreetNumberTextBox);
            this.RegisterClientPanel.Controls.Add(this.ClientNameTextBox);
            this.RegisterClientPanel.Controls.Add(this.ClientStreetTextBox);
            this.RegisterClientPanel.Location = new System.Drawing.Point(284, 12);
            this.RegisterClientPanel.Name = "RegisterClientPanel";
            this.RegisterClientPanel.Size = new System.Drawing.Size(232, 432);
            this.RegisterClientPanel.TabIndex = 0;
            // 
            // ResultLabel
            // 
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultLabel.Location = new System.Drawing.Point(67, 407);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(100, 17);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignupBtn
            // 
            this.SignupBtn.Location = new System.Drawing.Point(67, 381);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(100, 23);
            this.SignupBtn.TabIndex = 10;
            this.SignupBtn.Text = "Cadastrar";
            this.SignupBtn.UseVisualStyleBackColor = true;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // LabelNumber
            // 
            this.LabelNumber.Location = new System.Drawing.Point(64, 156);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(103, 13);
            this.LabelNumber.TabIndex = 0;
            this.LabelNumber.Text = "Nº";
            this.LabelNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelStreet
            // 
            this.LabelStreet.Location = new System.Drawing.Point(64, 120);
            this.LabelStreet.Name = "LabelStreet";
            this.LabelStreet.Size = new System.Drawing.Size(103, 13);
            this.LabelStreet.TabIndex = 0;
            this.LabelStreet.Text = "Rua";
            this.LabelStreet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelName
            // 
            this.LabelName.Location = new System.Drawing.Point(64, 42);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(103, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Nome";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelDocument
            // 
            this.LabelDocument.Location = new System.Drawing.Point(64, 3);
            this.LabelDocument.Name = "LabelDocument";
            this.LabelDocument.Size = new System.Drawing.Size(103, 13);
            this.LabelDocument.TabIndex = 0;
            this.LabelDocument.Text = "CPF";
            this.LabelDocument.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientStreetNumberTextBox
            // 
            this.ClientStreetNumberTextBox.Location = new System.Drawing.Point(67, 171);
            this.ClientStreetNumberTextBox.Name = "ClientStreetNumberTextBox";
            this.ClientStreetNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientStreetNumberTextBox.TabIndex = 5;
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(67, 58);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientNameTextBox.TabIndex = 2;
            // 
            // ClientStreetTextBox
            // 
            this.ClientStreetTextBox.Location = new System.Drawing.Point(67, 133);
            this.ClientStreetTextBox.Name = "ClientStreetTextBox";
            this.ClientStreetTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientStreetTextBox.TabIndex = 4;
            // 
            // ClientDocumentTextBox
            // 
            this.ClientDocumentTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.ClientDocumentTextBox.Location = new System.Drawing.Point(67, 19);
            this.ClientDocumentTextBox.Mask = "000.000.000-00";
            this.ClientDocumentTextBox.Name = "ClientDocumentTextBox";
            this.ClientDocumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientDocumentTextBox.TabIndex = 1;
            this.ClientDocumentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientNeighborhoodTextBox
            // 
            this.ClientNeighborhoodTextBox.Location = new System.Drawing.Point(67, 210);
            this.ClientNeighborhoodTextBox.Name = "ClientNeighborhoodTextBox";
            this.ClientNeighborhoodTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientNeighborhoodTextBox.TabIndex = 6;
            // 
            // LabelNeighborhood
            // 
            this.LabelNeighborhood.Location = new System.Drawing.Point(64, 194);
            this.LabelNeighborhood.Name = "LabelNeighborhood";
            this.LabelNeighborhood.Size = new System.Drawing.Size(103, 13);
            this.LabelNeighborhood.TabIndex = 0;
            this.LabelNeighborhood.Text = "Bairro";
            this.LabelNeighborhood.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelCep
            // 
            this.LabelCep.Location = new System.Drawing.Point(64, 233);
            this.LabelCep.Name = "LabelCep";
            this.LabelCep.Size = new System.Drawing.Size(103, 13);
            this.LabelCep.TabIndex = 0;
            this.LabelCep.Text = "CEP";
            this.LabelCep.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientCepTextBox
            // 
            this.ClientCepTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.ClientCepTextBox.Location = new System.Drawing.Point(67, 249);
            this.ClientCepTextBox.Mask = "00000-000";
            this.ClientCepTextBox.Name = "ClientCepTextBox";
            this.ClientCepTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientCepTextBox.TabIndex = 7;
            this.ClientCepTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientStateTextBox
            // 
            this.ClientStateTextBox.Location = new System.Drawing.Point(67, 288);
            this.ClientStateTextBox.Name = "ClientStateTextBox";
            this.ClientStateTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientStateTextBox.TabIndex = 8;
            // 
            // LabelState
            // 
            this.LabelState.Location = new System.Drawing.Point(64, 272);
            this.LabelState.Name = "LabelState";
            this.LabelState.Size = new System.Drawing.Size(103, 13);
            this.LabelState.TabIndex = 0;
            this.LabelState.Text = "Estado";
            this.LabelState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientCityTextBox
            // 
            this.ClientCityTextBox.Location = new System.Drawing.Point(67, 327);
            this.ClientCityTextBox.Name = "ClientCityTextBox";
            this.ClientCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientCityTextBox.TabIndex = 9;
            // 
            // LabelCity
            // 
            this.LabelCity.Location = new System.Drawing.Point(64, 311);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(103, 13);
            this.LabelCity.TabIndex = 0;
            this.LabelCity.Text = "Cidade";
            this.LabelCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientEmailTextBox
            // 
            this.ClientEmailTextBox.Location = new System.Drawing.Point(67, 97);
            this.ClientEmailTextBox.Name = "ClientEmailTextBox";
            this.ClientEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientEmailTextBox.TabIndex = 3;
            // 
            // LabelEmail
            // 
            this.LabelEmail.Location = new System.Drawing.Point(64, 81);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(103, 13);
            this.LabelEmail.TabIndex = 0;
            this.LabelEmail.Text = "E-mail";
            this.LabelEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientListBox
            // 
            this.ClientListBox.FormattingEnabled = true;
            this.ClientListBox.Items.AddRange(new object[] {
            "Avulso",
            "Mensalista"});
            this.ClientListBox.Location = new System.Drawing.Point(67, 349);
            this.ClientListBox.Name = "ClientListBox";
            this.ClientListBox.Size = new System.Drawing.Size(100, 30);
            this.ClientListBox.TabIndex = 11;
            // 
            // RegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterClientPanel);
            this.Name = "RegisterClient";
            this.Text = "RegisterClient";
            this.RegisterClientPanel.ResumeLayout(false);
            this.RegisterClientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegisterClientPanel;
        private System.Windows.Forms.MaskedTextBox ClientCepTextBox;
        private System.Windows.Forms.Label LabelCep;
        private System.Windows.Forms.Label LabelNeighborhood;
        private System.Windows.Forms.TextBox ClientNeighborhoodTextBox;
        private System.Windows.Forms.MaskedTextBox ClientDocumentTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button SignupBtn;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelStreet;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelDocument;
        private System.Windows.Forms.TextBox ClientStreetNumberTextBox;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.TextBox ClientStreetTextBox;
        private System.Windows.Forms.Label LabelCity;
        private System.Windows.Forms.TextBox ClientCityTextBox;
        private System.Windows.Forms.Label LabelState;
        private System.Windows.Forms.TextBox ClientStateTextBox;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox ClientEmailTextBox;
        private System.Windows.Forms.ListBox ClientListBox;
    }
}