namespace HideluzEstacionamentos
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
            this.UserDataPanel = new System.Windows.Forms.Panel();
            this.UserModifyBtn = new System.Windows.Forms.Button();
            this.UserTypeListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.UserUsernameTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.UserDocumentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UserSearchDocumentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.UserSearchBtn = new System.Windows.Forms.Button();
            this.UserStatusListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserDataPanel
            // 
            this.UserDataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserDataPanel.Controls.Add(this.label5);
            this.UserDataPanel.Controls.Add(this.UserStatusListBox);
            this.UserDataPanel.Controls.Add(this.UserModifyBtn);
            this.UserDataPanel.Controls.Add(this.UserTypeListBox);
            this.UserDataPanel.Controls.Add(this.label4);
            this.UserDataPanel.Controls.Add(this.UserPasswordTextBox);
            this.UserDataPanel.Controls.Add(this.Senha);
            this.UserDataPanel.Controls.Add(this.UserUsernameTextBox);
            this.UserDataPanel.Controls.Add(this.Label3);
            this.UserDataPanel.Controls.Add(this.UserNameTextBox);
            this.UserDataPanel.Controls.Add(this.Label2);
            this.UserDataPanel.Controls.Add(this.Label1);
            this.UserDataPanel.Controls.Add(this.UserDocumentTextBox);
            this.UserDataPanel.Enabled = false;
            this.UserDataPanel.Location = new System.Drawing.Point(119, 83);
            this.UserDataPanel.Name = "UserDataPanel";
            this.UserDataPanel.Size = new System.Drawing.Size(292, 312);
            this.UserDataPanel.TabIndex = 1;
            // 
            // UserModifyBtn
            // 
            this.UserModifyBtn.Location = new System.Drawing.Point(97, 283);
            this.UserModifyBtn.Name = "UserModifyBtn";
            this.UserModifyBtn.Size = new System.Drawing.Size(100, 23);
            this.UserModifyBtn.TabIndex = 9;
            this.UserModifyBtn.Text = "Modificar";
            this.UserModifyBtn.UseVisualStyleBackColor = true;
            this.UserModifyBtn.Click += new System.EventHandler(this.ClientModifyBtn_Click);
            // 
            // UserTypeListBox
            // 
            this.UserTypeListBox.FormattingEnabled = true;
            this.UserTypeListBox.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.UserTypeListBox.Location = new System.Drawing.Point(97, 247);
            this.UserTypeListBox.Name = "UserTypeListBox";
            this.UserTypeListBox.Size = new System.Drawing.Size(100, 30);
            this.UserTypeListBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(97, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "TIPO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPasswordTextBox
            // 
            this.UserPasswordTextBox.Location = new System.Drawing.Point(97, 150);
            this.UserPasswordTextBox.Name = "UserPasswordTextBox";
            this.UserPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserPasswordTextBox.TabIndex = 6;
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(97, 131);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(100, 16);
            this.Senha.TabIndex = 0;
            this.Senha.Text = "SENHA";
            this.Senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserUsernameTextBox
            // 
            this.UserUsernameTextBox.Location = new System.Drawing.Point(97, 108);
            this.UserUsernameTextBox.Name = "UserUsernameTextBox";
            this.UserUsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserUsernameTextBox.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(97, 89);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 16);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "USUÁRIO";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(97, 66);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserNameTextBox.TabIndex = 4;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(97, 47);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "NOME";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(97, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "CPF";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserDocumentTextBox
            // 
            this.UserDocumentTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.UserDocumentTextBox.Location = new System.Drawing.Point(97, 24);
            this.UserDocumentTextBox.Mask = "000.000.000-00";
            this.UserDocumentTextBox.Name = "UserDocumentTextBox";
            this.UserDocumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserDocumentTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(216, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "CPF";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserSearchDocumentTextBox
            // 
            this.UserSearchDocumentTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.UserSearchDocumentTextBox.Location = new System.Drawing.Point(216, 31);
            this.UserSearchDocumentTextBox.Mask = "000.000.000-00";
            this.UserSearchDocumentTextBox.Name = "UserSearchDocumentTextBox";
            this.UserSearchDocumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserSearchDocumentTextBox.TabIndex = 1;
            // 
            // UserSearchBtn
            // 
            this.UserSearchBtn.Location = new System.Drawing.Point(216, 54);
            this.UserSearchBtn.Name = "UserSearchBtn";
            this.UserSearchBtn.Size = new System.Drawing.Size(100, 23);
            this.UserSearchBtn.TabIndex = 2;
            this.UserSearchBtn.Text = "Procurar";
            this.UserSearchBtn.UseVisualStyleBackColor = true;
            this.UserSearchBtn.Click += new System.EventHandler(this.UserSearchBtn_Click);
            // 
            // UserStatusListBox
            // 
            this.UserStatusListBox.FormattingEnabled = true;
            this.UserStatusListBox.Items.AddRange(new object[] {
            "Ativo",
            "Desativado"});
            this.UserStatusListBox.Location = new System.Drawing.Point(97, 194);
            this.UserStatusListBox.Name = "UserStatusListBox";
            this.UserStatusListBox.Size = new System.Drawing.Size(100, 30);
            this.UserStatusListBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(96, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "STATUS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 442);
            this.Controls.Add(this.UserSearchBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UserSearchDocumentTextBox);
            this.Controls.Add(this.UserDataPanel);
            this.Name = "ModifyUser";
            this.Text = "ModifyUser";
            this.UserDataPanel.ResumeLayout(false);
            this.UserDataPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UserDataPanel;
        private System.Windows.Forms.Button UserModifyBtn;
        private System.Windows.Forms.ListBox UserTypeListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserPasswordTextBox;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox UserUsernameTextBox;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.MaskedTextBox UserDocumentTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox UserSearchDocumentTextBox;
        private System.Windows.Forms.Button UserSearchBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox UserStatusListBox;
    }
}