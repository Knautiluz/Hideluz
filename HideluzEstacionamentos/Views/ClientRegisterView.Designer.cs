namespace HideluzEstacionamentos.Views
{
    partial class ClientRegisterView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRegisterView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_RegisterSubmit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_ClientPhone = new System.Windows.Forms.MaskedTextBox();
            this.txt_ClientDocument = new System.Windows.Forms.MaskedTextBox();
            this.combo_ClientType = new System.Windows.Forms.ComboBox();
            this.lbl_ClientType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ClientDocument = new System.Windows.Forms.Label();
            this.lbl_ClientPhone = new System.Windows.Forms.Label();
            this.txt_ClientName = new System.Windows.Forms.TextBox();
            this.lbl_ClientName = new System.Windows.Forms.Label();
            this.txt_ClientEmail = new System.Windows.Forms.TextBox();
            this.lbl_ClientEmail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_ClientZIPCode = new System.Windows.Forms.MaskedTextBox();
            this.lbl_AddressTitle = new System.Windows.Forms.Label();
            this.lbl_ClientNumber = new System.Windows.Forms.Label();
            this.lbl_ClientState = new System.Windows.Forms.Label();
            this.txt_ClientNumber = new System.Windows.Forms.TextBox();
            this.txt_ClientState = new System.Windows.Forms.TextBox();
            this.lbl_ClientZIPCode = new System.Windows.Forms.Label();
            this.txt_ClientCity = new System.Windows.Forms.TextBox();
            this.lbl_ClientCity = new System.Windows.Forms.Label();
            this.lbl_ClientStreet = new System.Windows.Forms.Label();
            this.txt_ClientNeighborhood = new System.Windows.Forms.TextBox();
            this.txt_ClientStreet = new System.Windows.Forms.TextBox();
            this.lbl_ClientNeighborhood = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_OK = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_OK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btn_RegisterSubmit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 567);
            this.panel1.TabIndex = 12;
            // 
            // btn_RegisterSubmit
            // 
            this.btn_RegisterSubmit.BackColor = System.Drawing.Color.Green;
            this.btn_RegisterSubmit.FlatAppearance.BorderSize = 0;
            this.btn_RegisterSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegisterSubmit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterSubmit.ForeColor = System.Drawing.Color.White;
            this.btn_RegisterSubmit.Location = new System.Drawing.Point(389, 377);
            this.btn_RegisterSubmit.Name = "btn_RegisterSubmit";
            this.btn_RegisterSubmit.Size = new System.Drawing.Size(291, 46);
            this.btn_RegisterSubmit.TabIndex = 41;
            this.btn_RegisterSubmit.Text = "Registrar";
            this.btn_RegisterSubmit.UseVisualStyleBackColor = false;
            this.btn_RegisterSubmit.Click += new System.EventHandler(this.btn_RegisterSubmit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel3.Controls.Add(this.txt_ClientPhone);
            this.panel3.Controls.Add(this.txt_ClientDocument);
            this.panel3.Controls.Add(this.combo_ClientType);
            this.panel3.Controls.Add(this.lbl_ClientType);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_ClientDocument);
            this.panel3.Controls.Add(this.lbl_ClientPhone);
            this.panel3.Controls.Add(this.txt_ClientName);
            this.panel3.Controls.Add(this.lbl_ClientName);
            this.panel3.Controls.Add(this.txt_ClientEmail);
            this.panel3.Controls.Add(this.lbl_ClientEmail);
            this.panel3.Location = new System.Drawing.Point(47, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 266);
            this.panel3.TabIndex = 13;
            // 
            // txt_ClientPhone
            // 
            this.txt_ClientPhone.Location = new System.Drawing.Point(17, 187);
            this.txt_ClientPhone.Mask = "(00) 00000-0000";
            this.txt_ClientPhone.Name = "txt_ClientPhone";
            this.txt_ClientPhone.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientPhone.TabIndex = 33;
            this.txt_ClientPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_ClientDocument
            // 
            this.txt_ClientDocument.Location = new System.Drawing.Point(17, 64);
            this.txt_ClientDocument.Mask = "000\\.000\\.000-00";
            this.txt_ClientDocument.Name = "txt_ClientDocument";
            this.txt_ClientDocument.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientDocument.TabIndex = 30;
            this.txt_ClientDocument.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // combo_ClientType
            // 
            this.combo_ClientType.FormattingEnabled = true;
            this.combo_ClientType.Location = new System.Drawing.Point(17, 227);
            this.combo_ClientType.Name = "combo_ClientType";
            this.combo_ClientType.Size = new System.Drawing.Size(245, 21);
            this.combo_ClientType.TabIndex = 34;
            // 
            // lbl_ClientType
            // 
            this.lbl_ClientType.AutoSize = true;
            this.lbl_ClientType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientType.Location = new System.Drawing.Point(17, 210);
            this.lbl_ClientType.Name = "lbl_ClientType";
            this.lbl_ClientType.Size = new System.Drawing.Size(90, 15);
            this.lbl_ClientType.TabIndex = 21;
            this.lbl_ClientType.Text = "Tipo de Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(29, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Informações do Cliente";
            // 
            // lbl_ClientDocument
            // 
            this.lbl_ClientDocument.AutoSize = true;
            this.lbl_ClientDocument.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientDocument.Location = new System.Drawing.Point(17, 46);
            this.lbl_ClientDocument.Name = "lbl_ClientDocument";
            this.lbl_ClientDocument.Size = new System.Drawing.Size(31, 15);
            this.lbl_ClientDocument.TabIndex = 1;
            this.lbl_ClientDocument.Text = "CPF:";
            // 
            // lbl_ClientPhone
            // 
            this.lbl_ClientPhone.AutoSize = true;
            this.lbl_ClientPhone.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientPhone.Location = new System.Drawing.Point(17, 169);
            this.lbl_ClientPhone.Name = "lbl_ClientPhone";
            this.lbl_ClientPhone.Size = new System.Drawing.Size(118, 15);
            this.lbl_ClientPhone.TabIndex = 7;
            this.lbl_ClientPhone.Text = "Telefone de Contato:";
            // 
            // txt_ClientName
            // 
            this.txt_ClientName.Location = new System.Drawing.Point(17, 105);
            this.txt_ClientName.Name = "txt_ClientName";
            this.txt_ClientName.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientName.TabIndex = 31;
            // 
            // lbl_ClientName
            // 
            this.lbl_ClientName.AutoSize = true;
            this.lbl_ClientName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientName.Location = new System.Drawing.Point(17, 87);
            this.lbl_ClientName.Name = "lbl_ClientName";
            this.lbl_ClientName.Size = new System.Drawing.Size(42, 15);
            this.lbl_ClientName.TabIndex = 3;
            this.lbl_ClientName.Text = "Nome:";
            // 
            // txt_ClientEmail
            // 
            this.txt_ClientEmail.Location = new System.Drawing.Point(17, 146);
            this.txt_ClientEmail.Name = "txt_ClientEmail";
            this.txt_ClientEmail.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientEmail.TabIndex = 32;
            // 
            // lbl_ClientEmail
            // 
            this.lbl_ClientEmail.AutoSize = true;
            this.lbl_ClientEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientEmail.Location = new System.Drawing.Point(17, 128);
            this.lbl_ClientEmail.Name = "lbl_ClientEmail";
            this.lbl_ClientEmail.Size = new System.Drawing.Size(38, 15);
            this.lbl_ClientEmail.TabIndex = 5;
            this.lbl_ClientEmail.Text = "Email:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.txt_ClientZIPCode);
            this.panel2.Controls.Add(this.lbl_AddressTitle);
            this.panel2.Controls.Add(this.lbl_ClientNumber);
            this.panel2.Controls.Add(this.lbl_ClientState);
            this.panel2.Controls.Add(this.txt_ClientNumber);
            this.panel2.Controls.Add(this.txt_ClientState);
            this.panel2.Controls.Add(this.lbl_ClientZIPCode);
            this.panel2.Controls.Add(this.txt_ClientCity);
            this.panel2.Controls.Add(this.lbl_ClientCity);
            this.panel2.Controls.Add(this.lbl_ClientStreet);
            this.panel2.Controls.Add(this.txt_ClientNeighborhood);
            this.panel2.Controls.Add(this.txt_ClientStreet);
            this.panel2.Controls.Add(this.lbl_ClientNeighborhood);
            this.panel2.Location = new System.Drawing.Point(389, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 304);
            this.panel2.TabIndex = 14;
            // 
            // txt_ClientZIPCode
            // 
            this.txt_ClientZIPCode.Location = new System.Drawing.Point(22, 228);
            this.txt_ClientZIPCode.Mask = "00000-999";
            this.txt_ClientZIPCode.Name = "txt_ClientZIPCode";
            this.txt_ClientZIPCode.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientZIPCode.TabIndex = 39;
            this.txt_ClientZIPCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_AddressTitle
            // 
            this.lbl_AddressTitle.AutoSize = true;
            this.lbl_AddressTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddressTitle.ForeColor = System.Drawing.Color.Gray;
            this.lbl_AddressTitle.Location = new System.Drawing.Point(22, 4);
            this.lbl_AddressTitle.Name = "lbl_AddressTitle";
            this.lbl_AddressTitle.Size = new System.Drawing.Size(247, 23);
            this.lbl_AddressTitle.TabIndex = 0;
            this.lbl_AddressTitle.Text = "Informações de Endereço";
            // 
            // lbl_ClientNumber
            // 
            this.lbl_ClientNumber.AutoSize = true;
            this.lbl_ClientNumber.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientNumber.Location = new System.Drawing.Point(22, 251);
            this.lbl_ClientNumber.Name = "lbl_ClientNumber";
            this.lbl_ClientNumber.Size = new System.Drawing.Size(53, 15);
            this.lbl_ClientNumber.TabIndex = 19;
            this.lbl_ClientNumber.Text = "Número:";
            // 
            // lbl_ClientState
            // 
            this.lbl_ClientState.AutoSize = true;
            this.lbl_ClientState.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientState.Location = new System.Drawing.Point(22, 46);
            this.lbl_ClientState.Name = "lbl_ClientState";
            this.lbl_ClientState.Size = new System.Drawing.Size(45, 15);
            this.lbl_ClientState.TabIndex = 9;
            this.lbl_ClientState.Text = "Estado:";
            // 
            // txt_ClientNumber
            // 
            this.txt_ClientNumber.Location = new System.Drawing.Point(22, 269);
            this.txt_ClientNumber.Name = "txt_ClientNumber";
            this.txt_ClientNumber.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientNumber.TabIndex = 40;
            // 
            // txt_ClientState
            // 
            this.txt_ClientState.Location = new System.Drawing.Point(22, 64);
            this.txt_ClientState.Name = "txt_ClientState";
            this.txt_ClientState.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientState.TabIndex = 35;
            // 
            // lbl_ClientZIPCode
            // 
            this.lbl_ClientZIPCode.AutoSize = true;
            this.lbl_ClientZIPCode.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientZIPCode.Location = new System.Drawing.Point(22, 210);
            this.lbl_ClientZIPCode.Name = "lbl_ClientZIPCode";
            this.lbl_ClientZIPCode.Size = new System.Drawing.Size(31, 15);
            this.lbl_ClientZIPCode.TabIndex = 17;
            this.lbl_ClientZIPCode.Text = "CEP:";
            // 
            // txt_ClientCity
            // 
            this.txt_ClientCity.Location = new System.Drawing.Point(22, 105);
            this.txt_ClientCity.Name = "txt_ClientCity";
            this.txt_ClientCity.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientCity.TabIndex = 36;
            // 
            // lbl_ClientCity
            // 
            this.lbl_ClientCity.AutoSize = true;
            this.lbl_ClientCity.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientCity.Location = new System.Drawing.Point(22, 87);
            this.lbl_ClientCity.Name = "lbl_ClientCity";
            this.lbl_ClientCity.Size = new System.Drawing.Size(49, 15);
            this.lbl_ClientCity.TabIndex = 11;
            this.lbl_ClientCity.Text = "Cidade:";
            // 
            // lbl_ClientStreet
            // 
            this.lbl_ClientStreet.AutoSize = true;
            this.lbl_ClientStreet.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientStreet.Location = new System.Drawing.Point(22, 169);
            this.lbl_ClientStreet.Name = "lbl_ClientStreet";
            this.lbl_ClientStreet.Size = new System.Drawing.Size(31, 15);
            this.lbl_ClientStreet.TabIndex = 15;
            this.lbl_ClientStreet.Text = "Rua:";
            // 
            // txt_ClientNeighborhood
            // 
            this.txt_ClientNeighborhood.Location = new System.Drawing.Point(22, 146);
            this.txt_ClientNeighborhood.Name = "txt_ClientNeighborhood";
            this.txt_ClientNeighborhood.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientNeighborhood.TabIndex = 37;
            // 
            // txt_ClientStreet
            // 
            this.txt_ClientStreet.Location = new System.Drawing.Point(22, 187);
            this.txt_ClientStreet.Name = "txt_ClientStreet";
            this.txt_ClientStreet.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientStreet.TabIndex = 38;
            // 
            // lbl_ClientNeighborhood
            // 
            this.lbl_ClientNeighborhood.AutoSize = true;
            this.lbl_ClientNeighborhood.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientNeighborhood.Location = new System.Drawing.Point(22, 128);
            this.lbl_ClientNeighborhood.Name = "lbl_ClientNeighborhood";
            this.lbl_ClientNeighborhood.Size = new System.Drawing.Size(42, 15);
            this.lbl_ClientNeighborhood.TabIndex = 13;
            this.lbl_ClientNeighborhood.Text = "Bairro:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider_OK
            // 
            this.errorProvider_OK.ContainerControl = this;
            this.errorProvider_OK.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_OK.Icon")));
            // 
            // ClientRegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.panel1);
            this.Name = "ClientRegisterView";
            this.Size = new System.Drawing.Size(863, 567);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_OK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ClientName;
        private System.Windows.Forms.TextBox txt_ClientName;
        private System.Windows.Forms.Label lbl_ClientDocument;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_ClientType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ClientPhone;
        private System.Windows.Forms.TextBox txt_ClientEmail;
        private System.Windows.Forms.Label lbl_ClientEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_AddressTitle;
        private System.Windows.Forms.Label lbl_ClientNumber;
        private System.Windows.Forms.Label lbl_ClientState;
        private System.Windows.Forms.TextBox txt_ClientNumber;
        private System.Windows.Forms.TextBox txt_ClientState;
        private System.Windows.Forms.Label lbl_ClientZIPCode;
        private System.Windows.Forms.TextBox txt_ClientCity;
        private System.Windows.Forms.Label lbl_ClientCity;
        private System.Windows.Forms.Label lbl_ClientStreet;
        private System.Windows.Forms.TextBox txt_ClientNeighborhood;
        private System.Windows.Forms.TextBox txt_ClientStreet;
        private System.Windows.Forms.Label lbl_ClientNeighborhood;
        private System.Windows.Forms.ComboBox combo_ClientType;
        private System.Windows.Forms.Button btn_RegisterSubmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox txt_ClientDocument;
        private System.Windows.Forms.MaskedTextBox txt_ClientPhone;
        private System.Windows.Forms.ErrorProvider errorProvider_OK;
        private System.Windows.Forms.MaskedTextBox txt_ClientZIPCode;
    }
}
