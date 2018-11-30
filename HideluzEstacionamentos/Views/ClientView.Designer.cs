namespace HideluzEstacionamentos.Views
{
    partial class ClientView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_UpdateSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DeleteClient = new System.Windows.Forms.Button();
            this.btn_ClientSearch = new System.Windows.Forms.Button();
            this.txt_SearchInformation = new System.Windows.Forms.MaskedTextBox();
            this.lbl_SearchClient = new System.Windows.Forms.Label();
            this.dataGrid_AllClients = new System.Windows.Forms.DataGridView();
            this.btn_SelectClient = new System.Windows.Forms.Button();
            this.btn_RegisterSubmit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox_ClientStatus = new System.Windows.Forms.CheckBox();
            this.txt_ClientZIPCode = new System.Windows.Forms.MaskedTextBox();
            this.txt_ClientPhone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_AddressTitle = new System.Windows.Forms.Label();
            this.lbl_ClientNumber = new System.Windows.Forms.Label();
            this.txt_ClientDocument = new System.Windows.Forms.MaskedTextBox();
            this.lbl_ClientState = new System.Windows.Forms.Label();
            this.combo_ClientType = new System.Windows.Forms.ComboBox();
            this.txt_ClientNumber = new System.Windows.Forms.TextBox();
            this.lbl_ClientType = new System.Windows.Forms.Label();
            this.txt_ClientState = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ClientZIPCode = new System.Windows.Forms.Label();
            this.lbl_ClientDocument = new System.Windows.Forms.Label();
            this.txt_ClientCity = new System.Windows.Forms.TextBox();
            this.lbl_ClientPhone = new System.Windows.Forms.Label();
            this.lbl_ClientCity = new System.Windows.Forms.Label();
            this.txt_ClientName = new System.Windows.Forms.TextBox();
            this.lbl_ClientStreet = new System.Windows.Forms.Label();
            this.lbl_ClientName = new System.Windows.Forms.Label();
            this.txt_ClientNeighborhood = new System.Windows.Forms.TextBox();
            this.txt_ClientEmail = new System.Windows.Forms.TextBox();
            this.txt_ClientStreet = new System.Windows.Forms.TextBox();
            this.lbl_ClientEmail = new System.Windows.Forms.Label();
            this.lbl_ClientNeighborhood = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_OK = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_AllClients)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_OK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGrid_AllClients);
            this.panel1.Controls.Add(this.btn_SelectClient);
            this.panel1.Controls.Add(this.btn_RegisterSubmit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 580);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.btn_UpdateSubmit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_DeleteClient);
            this.panel2.Controls.Add(this.btn_ClientSearch);
            this.panel2.Controls.Add(this.txt_SearchInformation);
            this.panel2.Controls.Add(this.lbl_SearchClient);
            this.panel2.Location = new System.Drawing.Point(595, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 273);
            this.panel2.TabIndex = 45;
            // 
            // btn_UpdateSubmit
            // 
            this.btn_UpdateSubmit.BackColor = System.Drawing.Color.Green;
            this.btn_UpdateSubmit.Enabled = false;
            this.btn_UpdateSubmit.FlatAppearance.BorderSize = 0;
            this.btn_UpdateSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateSubmit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateSubmit.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateSubmit.Location = new System.Drawing.Point(38, 166);
            this.btn_UpdateSubmit.Name = "btn_UpdateSubmit";
            this.btn_UpdateSubmit.Size = new System.Drawing.Size(162, 30);
            this.btn_UpdateSubmit.TabIndex = 61;
            this.btn_UpdateSubmit.Text = "Salvar Alterações";
            this.btn_UpdateSubmit.UseVisualStyleBackColor = false;
            this.btn_UpdateSubmit.Click += new System.EventHandler(this.btn_UpdateSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "CPF:";
            // 
            // btn_DeleteClient
            // 
            this.btn_DeleteClient.BackColor = System.Drawing.Color.Green;
            this.btn_DeleteClient.Enabled = false;
            this.btn_DeleteClient.FlatAppearance.BorderSize = 0;
            this.btn_DeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteClient.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteClient.Location = new System.Drawing.Point(38, 209);
            this.btn_DeleteClient.Name = "btn_DeleteClient";
            this.btn_DeleteClient.Size = new System.Drawing.Size(162, 30);
            this.btn_DeleteClient.TabIndex = 43;
            this.btn_DeleteClient.Text = "Excluir";
            this.btn_DeleteClient.UseVisualStyleBackColor = false;
            this.btn_DeleteClient.Click += new System.EventHandler(this.btn_DeleteClient_Click);
            // 
            // btn_ClientSearch
            // 
            this.btn_ClientSearch.BackColor = System.Drawing.Color.Green;
            this.btn_ClientSearch.FlatAppearance.BorderSize = 0;
            this.btn_ClientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientSearch.ForeColor = System.Drawing.Color.White;
            this.btn_ClientSearch.Location = new System.Drawing.Point(20, 120);
            this.btn_ClientSearch.Name = "btn_ClientSearch";
            this.btn_ClientSearch.Size = new System.Drawing.Size(204, 30);
            this.btn_ClientSearch.TabIndex = 60;
            this.btn_ClientSearch.Text = "Buscar";
            this.btn_ClientSearch.UseVisualStyleBackColor = false;
            this.btn_ClientSearch.Click += new System.EventHandler(this.btn_ClientSearch_Click);
            // 
            // txt_SearchInformation
            // 
            this.txt_SearchInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchInformation.Location = new System.Drawing.Point(10, 74);
            this.txt_SearchInformation.Mask = "000\\.000\\.000-00";
            this.txt_SearchInformation.Name = "txt_SearchInformation";
            this.txt_SearchInformation.Size = new System.Drawing.Size(221, 22);
            this.txt_SearchInformation.TabIndex = 59;
            this.txt_SearchInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SearchInformation.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // lbl_SearchClient
            // 
            this.lbl_SearchClient.AutoSize = true;
            this.lbl_SearchClient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchClient.ForeColor = System.Drawing.Color.Gray;
            this.lbl_SearchClient.Location = new System.Drawing.Point(68, 5);
            this.lbl_SearchClient.Name = "lbl_SearchClient";
            this.lbl_SearchClient.Size = new System.Drawing.Size(97, 23);
            this.lbl_SearchClient.TabIndex = 41;
            this.lbl_SearchClient.Text = "Consultar";
            // 
            // dataGrid_AllClients
            // 
            this.dataGrid_AllClients.AllowUserToAddRows = false;
            this.dataGrid_AllClients.AllowUserToDeleteRows = false;
            this.dataGrid_AllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_AllClients.Location = new System.Drawing.Point(25, 313);
            this.dataGrid_AllClients.Name = "dataGrid_AllClients";
            this.dataGrid_AllClients.ReadOnly = true;
            this.dataGrid_AllClients.Size = new System.Drawing.Size(812, 181);
            this.dataGrid_AllClients.TabIndex = 44;
            // 
            // btn_SelectClient
            // 
            this.btn_SelectClient.BackColor = System.Drawing.Color.Green;
            this.btn_SelectClient.FlatAppearance.BorderSize = 0;
            this.btn_SelectClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectClient.ForeColor = System.Drawing.Color.White;
            this.btn_SelectClient.Location = new System.Drawing.Point(697, 500);
            this.btn_SelectClient.Name = "btn_SelectClient";
            this.btn_SelectClient.Size = new System.Drawing.Size(140, 30);
            this.btn_SelectClient.TabIndex = 42;
            this.btn_SelectClient.Text = "Selecionar";
            this.btn_SelectClient.UseVisualStyleBackColor = false;
            this.btn_SelectClient.Click += new System.EventHandler(this.btn_SelectClient_Click);
            // 
            // btn_RegisterSubmit
            // 
            this.btn_RegisterSubmit.BackColor = System.Drawing.Color.Green;
            this.btn_RegisterSubmit.FlatAppearance.BorderSize = 0;
            this.btn_RegisterSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegisterSubmit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterSubmit.ForeColor = System.Drawing.Color.White;
            this.btn_RegisterSubmit.Location = new System.Drawing.Point(551, 500);
            this.btn_RegisterSubmit.Name = "btn_RegisterSubmit";
            this.btn_RegisterSubmit.Size = new System.Drawing.Size(140, 30);
            this.btn_RegisterSubmit.TabIndex = 41;
            this.btn_RegisterSubmit.Text = "Cadastrar Cliente";
            this.btn_RegisterSubmit.UseVisualStyleBackColor = false;
            this.btn_RegisterSubmit.Click += new System.EventHandler(this.btn_RegisterSubmit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel3.Controls.Add(this.checkBox_ClientStatus);
            this.panel3.Controls.Add(this.txt_ClientZIPCode);
            this.panel3.Controls.Add(this.txt_ClientPhone);
            this.panel3.Controls.Add(this.lbl_AddressTitle);
            this.panel3.Controls.Add(this.lbl_ClientNumber);
            this.panel3.Controls.Add(this.txt_ClientDocument);
            this.panel3.Controls.Add(this.lbl_ClientState);
            this.panel3.Controls.Add(this.combo_ClientType);
            this.panel3.Controls.Add(this.txt_ClientNumber);
            this.panel3.Controls.Add(this.lbl_ClientType);
            this.panel3.Controls.Add(this.txt_ClientState);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_ClientZIPCode);
            this.panel3.Controls.Add(this.lbl_ClientDocument);
            this.panel3.Controls.Add(this.txt_ClientCity);
            this.panel3.Controls.Add(this.lbl_ClientPhone);
            this.panel3.Controls.Add(this.lbl_ClientCity);
            this.panel3.Controls.Add(this.txt_ClientName);
            this.panel3.Controls.Add(this.lbl_ClientStreet);
            this.panel3.Controls.Add(this.lbl_ClientName);
            this.panel3.Controls.Add(this.txt_ClientNeighborhood);
            this.panel3.Controls.Add(this.txt_ClientEmail);
            this.panel3.Controls.Add(this.txt_ClientStreet);
            this.panel3.Controls.Add(this.lbl_ClientEmail);
            this.panel3.Controls.Add(this.lbl_ClientNeighborhood);
            this.panel3.Location = new System.Drawing.Point(25, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 273);
            this.panel3.TabIndex = 13;
            // 
            // checkBox_ClientStatus
            // 
            this.checkBox_ClientStatus.AutoSize = true;
            this.checkBox_ClientStatus.Location = new System.Drawing.Point(479, 237);
            this.checkBox_ClientStatus.Name = "checkBox_ClientStatus";
            this.checkBox_ClientStatus.Size = new System.Drawing.Size(50, 17);
            this.checkBox_ClientStatus.TabIndex = 41;
            this.checkBox_ClientStatus.Text = "Ativo";
            this.checkBox_ClientStatus.UseVisualStyleBackColor = true;
            // 
            // txt_ClientZIPCode
            // 
            this.txt_ClientZIPCode.Location = new System.Drawing.Point(288, 235);
            this.txt_ClientZIPCode.Mask = "00000-999";
            this.txt_ClientZIPCode.Name = "txt_ClientZIPCode";
            this.txt_ClientZIPCode.Size = new System.Drawing.Size(71, 20);
            this.txt_ClientZIPCode.TabIndex = 39;
            this.txt_ClientZIPCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_ClientPhone
            // 
            this.txt_ClientPhone.Location = new System.Drawing.Point(20, 195);
            this.txt_ClientPhone.Mask = "(00) 00000-0000";
            this.txt_ClientPhone.Name = "txt_ClientPhone";
            this.txt_ClientPhone.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientPhone.TabIndex = 33;
            this.txt_ClientPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_AddressTitle
            // 
            this.lbl_AddressTitle.AutoSize = true;
            this.lbl_AddressTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddressTitle.ForeColor = System.Drawing.Color.Gray;
            this.lbl_AddressTitle.Location = new System.Drawing.Point(287, 5);
            this.lbl_AddressTitle.Name = "lbl_AddressTitle";
            this.lbl_AddressTitle.Size = new System.Drawing.Size(247, 23);
            this.lbl_AddressTitle.TabIndex = 0;
            this.lbl_AddressTitle.Text = "Informações de Endereço";
            // 
            // lbl_ClientNumber
            // 
            this.lbl_ClientNumber.AutoSize = true;
            this.lbl_ClientNumber.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientNumber.Location = new System.Drawing.Point(390, 218);
            this.lbl_ClientNumber.Name = "lbl_ClientNumber";
            this.lbl_ClientNumber.Size = new System.Drawing.Size(53, 15);
            this.lbl_ClientNumber.TabIndex = 19;
            this.lbl_ClientNumber.Text = "Número:";
            // 
            // txt_ClientDocument
            // 
            this.txt_ClientDocument.Location = new System.Drawing.Point(20, 72);
            this.txt_ClientDocument.Mask = "000\\.000\\.000-00";
            this.txt_ClientDocument.Name = "txt_ClientDocument";
            this.txt_ClientDocument.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientDocument.TabIndex = 30;
            this.txt_ClientDocument.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // lbl_ClientState
            // 
            this.lbl_ClientState.AutoSize = true;
            this.lbl_ClientState.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientState.Location = new System.Drawing.Point(288, 54);
            this.lbl_ClientState.Name = "lbl_ClientState";
            this.lbl_ClientState.Size = new System.Drawing.Size(45, 15);
            this.lbl_ClientState.TabIndex = 9;
            this.lbl_ClientState.Text = "Estado:";
            // 
            // combo_ClientType
            // 
            this.combo_ClientType.FormattingEnabled = true;
            this.combo_ClientType.Location = new System.Drawing.Point(20, 235);
            this.combo_ClientType.Name = "combo_ClientType";
            this.combo_ClientType.Size = new System.Drawing.Size(245, 21);
            this.combo_ClientType.TabIndex = 34;
            // 
            // txt_ClientNumber
            // 
            this.txt_ClientNumber.Location = new System.Drawing.Point(390, 235);
            this.txt_ClientNumber.Name = "txt_ClientNumber";
            this.txt_ClientNumber.Size = new System.Drawing.Size(53, 20);
            this.txt_ClientNumber.TabIndex = 40;
            // 
            // lbl_ClientType
            // 
            this.lbl_ClientType.AutoSize = true;
            this.lbl_ClientType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientType.Location = new System.Drawing.Point(20, 218);
            this.lbl_ClientType.Name = "lbl_ClientType";
            this.lbl_ClientType.Size = new System.Drawing.Size(90, 15);
            this.lbl_ClientType.TabIndex = 21;
            this.lbl_ClientType.Text = "Tipo de Cliente:";
            // 
            // txt_ClientState
            // 
            this.txt_ClientState.Location = new System.Drawing.Point(288, 72);
            this.txt_ClientState.Name = "txt_ClientState";
            this.txt_ClientState.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientState.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(23, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Informações do Cliente";
            // 
            // lbl_ClientZIPCode
            // 
            this.lbl_ClientZIPCode.AutoSize = true;
            this.lbl_ClientZIPCode.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientZIPCode.Location = new System.Drawing.Point(288, 218);
            this.lbl_ClientZIPCode.Name = "lbl_ClientZIPCode";
            this.lbl_ClientZIPCode.Size = new System.Drawing.Size(31, 15);
            this.lbl_ClientZIPCode.TabIndex = 17;
            this.lbl_ClientZIPCode.Text = "CEP:";
            // 
            // lbl_ClientDocument
            // 
            this.lbl_ClientDocument.AutoSize = true;
            this.lbl_ClientDocument.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientDocument.Location = new System.Drawing.Point(20, 54);
            this.lbl_ClientDocument.Name = "lbl_ClientDocument";
            this.lbl_ClientDocument.Size = new System.Drawing.Size(31, 15);
            this.lbl_ClientDocument.TabIndex = 1;
            this.lbl_ClientDocument.Text = "CPF:";
            // 
            // txt_ClientCity
            // 
            this.txt_ClientCity.Location = new System.Drawing.Point(288, 113);
            this.txt_ClientCity.Name = "txt_ClientCity";
            this.txt_ClientCity.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientCity.TabIndex = 36;
            // 
            // lbl_ClientPhone
            // 
            this.lbl_ClientPhone.AutoSize = true;
            this.lbl_ClientPhone.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientPhone.Location = new System.Drawing.Point(20, 177);
            this.lbl_ClientPhone.Name = "lbl_ClientPhone";
            this.lbl_ClientPhone.Size = new System.Drawing.Size(118, 15);
            this.lbl_ClientPhone.TabIndex = 7;
            this.lbl_ClientPhone.Text = "Telefone de Contato:";
            // 
            // lbl_ClientCity
            // 
            this.lbl_ClientCity.AutoSize = true;
            this.lbl_ClientCity.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientCity.Location = new System.Drawing.Point(288, 95);
            this.lbl_ClientCity.Name = "lbl_ClientCity";
            this.lbl_ClientCity.Size = new System.Drawing.Size(49, 15);
            this.lbl_ClientCity.TabIndex = 11;
            this.lbl_ClientCity.Text = "Cidade:";
            // 
            // txt_ClientName
            // 
            this.txt_ClientName.Location = new System.Drawing.Point(20, 113);
            this.txt_ClientName.Name = "txt_ClientName";
            this.txt_ClientName.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientName.TabIndex = 31;
            // 
            // lbl_ClientStreet
            // 
            this.lbl_ClientStreet.AutoSize = true;
            this.lbl_ClientStreet.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientStreet.Location = new System.Drawing.Point(288, 177);
            this.lbl_ClientStreet.Name = "lbl_ClientStreet";
            this.lbl_ClientStreet.Size = new System.Drawing.Size(31, 15);
            this.lbl_ClientStreet.TabIndex = 15;
            this.lbl_ClientStreet.Text = "Rua:";
            // 
            // lbl_ClientName
            // 
            this.lbl_ClientName.AutoSize = true;
            this.lbl_ClientName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientName.Location = new System.Drawing.Point(20, 95);
            this.lbl_ClientName.Name = "lbl_ClientName";
            this.lbl_ClientName.Size = new System.Drawing.Size(42, 15);
            this.lbl_ClientName.TabIndex = 3;
            this.lbl_ClientName.Text = "Nome:";
            // 
            // txt_ClientNeighborhood
            // 
            this.txt_ClientNeighborhood.Location = new System.Drawing.Point(288, 154);
            this.txt_ClientNeighborhood.Name = "txt_ClientNeighborhood";
            this.txt_ClientNeighborhood.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientNeighborhood.TabIndex = 37;
            // 
            // txt_ClientEmail
            // 
            this.txt_ClientEmail.Location = new System.Drawing.Point(20, 154);
            this.txt_ClientEmail.Name = "txt_ClientEmail";
            this.txt_ClientEmail.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientEmail.TabIndex = 32;
            // 
            // txt_ClientStreet
            // 
            this.txt_ClientStreet.Location = new System.Drawing.Point(288, 195);
            this.txt_ClientStreet.Name = "txt_ClientStreet";
            this.txt_ClientStreet.Size = new System.Drawing.Size(245, 20);
            this.txt_ClientStreet.TabIndex = 38;
            // 
            // lbl_ClientEmail
            // 
            this.lbl_ClientEmail.AutoSize = true;
            this.lbl_ClientEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientEmail.Location = new System.Drawing.Point(20, 136);
            this.lbl_ClientEmail.Name = "lbl_ClientEmail";
            this.lbl_ClientEmail.Size = new System.Drawing.Size(38, 15);
            this.lbl_ClientEmail.TabIndex = 5;
            this.lbl_ClientEmail.Text = "Email:";
            // 
            // lbl_ClientNeighborhood
            // 
            this.lbl_ClientNeighborhood.AutoSize = true;
            this.lbl_ClientNeighborhood.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientNeighborhood.Location = new System.Drawing.Point(288, 136);
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
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.panel1);
            this.Name = "ClientView";
            this.Size = new System.Drawing.Size(865, 580);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_AllClients)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button btn_DeleteClient;
        private System.Windows.Forms.Button btn_SelectClient;
        private System.Windows.Forms.DataGridView dataGrid_AllClients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_SearchClient;
        private System.Windows.Forms.Button btn_ClientSearch;
        private System.Windows.Forms.MaskedTextBox txt_SearchInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_UpdateSubmit;
        private System.Windows.Forms.CheckBox checkBox_ClientStatus;
    }
}
