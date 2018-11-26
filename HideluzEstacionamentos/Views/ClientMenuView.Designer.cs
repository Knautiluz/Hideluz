namespace HideluzEstacionamentos.Views
{
    partial class ClientMenuView
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ClientRegister = new System.Windows.Forms.Button();
            this.btn_ClientSearch = new System.Windows.Forms.Button();
            this.btn_ClientDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientSearchView = new HideluzEstacionamentos.Views.ClientSearchView();
            this.clientRegisterView = new HideluzEstacionamentos.Views.ClientRegisterView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ClientRegister
            // 
            this.btn_ClientRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ClientRegister.FlatAppearance.BorderSize = 0;
            this.btn_ClientRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientRegister.ForeColor = System.Drawing.Color.White;
            this.btn_ClientRegister.Location = new System.Drawing.Point(67, 5);
            this.btn_ClientRegister.Name = "btn_ClientRegister";
            this.btn_ClientRegister.Size = new System.Drawing.Size(153, 41);
            this.btn_ClientRegister.TabIndex = 9;
            this.btn_ClientRegister.Text = "Cadastrar";
            this.btn_ClientRegister.UseVisualStyleBackColor = false;
            this.btn_ClientRegister.Click += new System.EventHandler(this.btn_ClientRegister_Click);
            // 
            // btn_ClientSearch
            // 
            this.btn_ClientSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ClientSearch.FlatAppearance.BorderSize = 0;
            this.btn_ClientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientSearch.ForeColor = System.Drawing.Color.White;
            this.btn_ClientSearch.Location = new System.Drawing.Point(325, 5);
            this.btn_ClientSearch.Name = "btn_ClientSearch";
            this.btn_ClientSearch.Size = new System.Drawing.Size(153, 41);
            this.btn_ClientSearch.TabIndex = 10;
            this.btn_ClientSearch.Text = "Consultar";
            this.btn_ClientSearch.UseVisualStyleBackColor = false;
            this.btn_ClientSearch.Click += new System.EventHandler(this.btn_ClientSearch_Click);
            // 
            // btn_ClientDelete
            // 
            this.btn_ClientDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ClientDelete.FlatAppearance.BorderSize = 0;
            this.btn_ClientDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientDelete.ForeColor = System.Drawing.Color.White;
            this.btn_ClientDelete.Location = new System.Drawing.Point(598, 5);
            this.btn_ClientDelete.Name = "btn_ClientDelete";
            this.btn_ClientDelete.Size = new System.Drawing.Size(153, 41);
            this.btn_ClientDelete.TabIndex = 11;
            this.btn_ClientDelete.Text = "Excluir";
            this.btn_ClientDelete.UseVisualStyleBackColor = false;
            this.btn_ClientDelete.Click += new System.EventHandler(this.btn_ClientDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btn_ClientRegister);
            this.panel1.Controls.Add(this.btn_ClientDelete);
            this.panel1.Controls.Add(this.btn_ClientSearch);
            this.panel1.Location = new System.Drawing.Point(15, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 53);
            this.panel1.TabIndex = 12;
            // 
            // clientSearchView
            // 
            this.clientSearchView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.clientSearchView.Location = new System.Drawing.Point(15, 66);
            this.clientSearchView.Name = "clientSearchView";
            this.clientSearchView.Size = new System.Drawing.Size(837, 472);
            this.clientSearchView.TabIndex = 14;
            // 
            // clientRegisterView
            // 
            this.clientRegisterView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.clientRegisterView.Location = new System.Drawing.Point(15, 66);
            this.clientRegisterView.Name = "clientRegisterView";
            this.clientRegisterView.Size = new System.Drawing.Size(837, 472);
            this.clientRegisterView.TabIndex = 13;
            // 
            // ClientMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.clientRegisterView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientSearchView);
            this.Name = "ClientMenuView";
            this.Size = new System.Drawing.Size(863, 567);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ClientRegister;
        private System.Windows.Forms.Button btn_ClientSearch;
        private System.Windows.Forms.Button btn_ClientDelete;
        private System.Windows.Forms.Panel panel1;
        private ClientRegisterView clientRegisterView;
        private ClientSearchView clientSearchView;
    }
}
