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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Location = new System.Drawing.Point(113, 75);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(100, 20);
            this.TextBoxUser.TabIndex = 2;
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(113, 101);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPass.TabIndex = 3;
            this.TextBoxPass.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(113, 127);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Hideluz Estacionamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Button BtnLogin;
    }
}

