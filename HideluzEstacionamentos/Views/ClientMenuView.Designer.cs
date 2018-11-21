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
            this.panel_ClientContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_ClientRegister
            // 
            this.btn_ClientRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ClientRegister.FlatAppearance.BorderSize = 0;
            this.btn_ClientRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientRegister.ForeColor = System.Drawing.Color.White;
            this.btn_ClientRegister.Location = new System.Drawing.Point(88, 14);
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
            this.btn_ClientSearch.Location = new System.Drawing.Point(352, 14);
            this.btn_ClientSearch.Name = "btn_ClientSearch";
            this.btn_ClientSearch.Size = new System.Drawing.Size(153, 41);
            this.btn_ClientSearch.TabIndex = 10;
            this.btn_ClientSearch.Text = "Consultar";
            this.btn_ClientSearch.UseVisualStyleBackColor = false;
            // 
            // btn_ClientDelete
            // 
            this.btn_ClientDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ClientDelete.FlatAppearance.BorderSize = 0;
            this.btn_ClientDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientDelete.ForeColor = System.Drawing.Color.White;
            this.btn_ClientDelete.Location = new System.Drawing.Point(616, 14);
            this.btn_ClientDelete.Name = "btn_ClientDelete";
            this.btn_ClientDelete.Size = new System.Drawing.Size(153, 41);
            this.btn_ClientDelete.TabIndex = 11;
            this.btn_ClientDelete.Text = "Excluir";
            this.btn_ClientDelete.UseVisualStyleBackColor = false;
            // 
            // panel_ClientContent
            // 
            this.panel_ClientContent.Location = new System.Drawing.Point(0, 73);
            this.panel_ClientContent.Name = "panel_ClientContent";
            this.panel_ClientContent.Size = new System.Drawing.Size(839, 468);
            this.panel_ClientContent.TabIndex = 3;
            // 
            // ClientMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_ClientContent);
            this.Controls.Add(this.btn_ClientDelete);
            this.Controls.Add(this.btn_ClientSearch);
            this.Controls.Add(this.btn_ClientRegister);
            this.Name = "ClientMenuView";
            this.Size = new System.Drawing.Size(839, 541);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ClientRegister;
        private System.Windows.Forms.Button btn_ClientSearch;
        private System.Windows.Forms.Button btn_ClientDelete;
        private System.Windows.Forms.Panel panel_ClientContent;
    }
}
