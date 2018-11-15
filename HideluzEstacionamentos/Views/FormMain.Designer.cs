namespace HideluzEstacionamentos
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.panel_topLogo = new System.Windows.Forms.Panel();
            this.picture_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel_topLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Location = new System.Drawing.Point(65, 60);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(147, 20);
            this.TextBoxUser.TabIndex = 2;
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(65, 92);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(147, 20);
            this.TextBoxPass.TabIndex = 3;
            this.TextBoxPass.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(12, 131);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(225, 37);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // panel_topLogo
            // 
            this.panel_topLogo.Controls.Add(this.picture_Logo);
            this.panel_topLogo.Location = new System.Drawing.Point(0, 0);
            this.panel_topLogo.Name = "panel_topLogo";
            this.panel_topLogo.Size = new System.Drawing.Size(250, 40);
            this.panel_topLogo.TabIndex = 5;
            // 
            // picture_Logo
            // 
            this.picture_Logo.Image = ((System.Drawing.Image)(resources.GetObject("picture_Logo.Image")));
            this.picture_Logo.Location = new System.Drawing.Point(0, -1);
            this.picture_Logo.Name = "picture_Logo";
            this.picture_Logo.Size = new System.Drawing.Size(250, 40);
            this.picture_Logo.TabIndex = 0;
            this.picture_Logo.TabStop = false;
            this.picture_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_Logo_MouseDown);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(12, 176);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(225, 37);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "SAIR";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 300);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.panel_topLogo);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hideluz Estacionamentos";
            this.panel_topLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Panel panel_topLogo;
        private System.Windows.Forms.PictureBox picture_Logo;
        private System.Windows.Forms.Button btn_Close;
    }
}

