﻿namespace HideluzEstacionamentos
{
    partial class ModifyUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClientModifyBtn = new System.Windows.Forms.Button();
            this.ClientTypeListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientPasswordTextBox = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.ClientUsernameTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ClientDocumentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClientModifyBtn);
            this.panel1.Controls.Add(this.ClientTypeListBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ClientPasswordTextBox);
            this.panel1.Controls.Add(this.Senha);
            this.panel1.Controls.Add(this.ClientUsernameTextBox);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.ClientNameTextBox);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.ClientDocumentTextBox);
            this.panel1.Location = new System.Drawing.Point(116, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 266);
            this.panel1.TabIndex = 1;
            // 
            // ClientModifyBtn
            // 
            this.ClientModifyBtn.Location = new System.Drawing.Point(97, 233);
            this.ClientModifyBtn.Name = "ClientModifyBtn";
            this.ClientModifyBtn.Size = new System.Drawing.Size(100, 23);
            this.ClientModifyBtn.TabIndex = 5;
            this.ClientModifyBtn.Text = "Modificar";
            this.ClientModifyBtn.UseVisualStyleBackColor = true;
            this.ClientModifyBtn.Click += new System.EventHandler(this.ClientModifyBtn_Click);
            // 
            // ClientTypeListBox
            // 
            this.ClientTypeListBox.FormattingEnabled = true;
            this.ClientTypeListBox.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.ClientTypeListBox.Location = new System.Drawing.Point(97, 197);
            this.ClientTypeListBox.Name = "ClientTypeListBox";
            this.ClientTypeListBox.Size = new System.Drawing.Size(100, 30);
            this.ClientTypeListBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(97, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "TIPO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientPasswordTextBox
            // 
            this.ClientPasswordTextBox.Location = new System.Drawing.Point(97, 155);
            this.ClientPasswordTextBox.Name = "ClientPasswordTextBox";
            this.ClientPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientPasswordTextBox.TabIndex = 3;
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(97, 136);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(100, 16);
            this.Senha.TabIndex = 0;
            this.Senha.Text = "SENHA";
            this.Senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientUsernameTextBox
            // 
            this.ClientUsernameTextBox.Location = new System.Drawing.Point(97, 113);
            this.ClientUsernameTextBox.Name = "ClientUsernameTextBox";
            this.ClientUsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientUsernameTextBox.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(97, 94);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 16);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "USUÁRIO";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(97, 71);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientNameTextBox.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(97, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "NOME";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(97, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "CPF";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientDocumentTextBox
            // 
            this.ClientDocumentTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.ClientDocumentTextBox.Location = new System.Drawing.Point(97, 29);
            this.ClientDocumentTextBox.Mask = "000.000.000-00";
            this.ClientDocumentTextBox.Name = "ClientDocumentTextBox";
            this.ClientDocumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientDocumentTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(116, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Insira o CPF e somente os dados que deseja alterar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 442);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "ModifyUser";
            this.Text = "ModifyUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClientModifyBtn;
        private System.Windows.Forms.ListBox ClientTypeListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClientPasswordTextBox;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox ClientUsernameTextBox;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.MaskedTextBox ClientDocumentTextBox;
        private System.Windows.Forms.Label label5;
    }
}