namespace HideluzEstacionamentos.Views
{
    partial class VehicleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_UpdateSubmit = new System.Windows.Forms.Button();
            this.lbl_VehiclePlateSearch = new System.Windows.Forms.Label();
            this.btn_DeleteVehicle = new System.Windows.Forms.Button();
            this.btn_VehicleSearch = new System.Windows.Forms.Button();
            this.txt_SearchInformation = new System.Windows.Forms.MaskedTextBox();
            this.lbl_SearchClient = new System.Windows.Forms.Label();
            this.btn_SelectVehicle = new System.Windows.Forms.Button();
            this.btn_RegisterSubmit = new System.Windows.Forms.Button();
            this.dataGrid_AllVehicles = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_VehicleDocumentOwner = new System.Windows.Forms.MaskedTextBox();
            this.check_VehicleStatus = new System.Windows.Forms.CheckBox();
            this.txt_VehiclePlate = new System.Windows.Forms.MaskedTextBox();
            this.combo_VehicleType = new System.Windows.Forms.ComboBox();
            this.lbl_VehicleType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_VehiclePlate = new System.Windows.Forms.Label();
            this.txt_VehicleModel = new System.Windows.Forms.TextBox();
            this.lbl_VehicleModel = new System.Windows.Forms.Label();
            this.lbl_VehicleOwner = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_OK = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_AllVehicles)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_OK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_SelectVehicle);
            this.panel1.Controls.Add(this.btn_RegisterSubmit);
            this.panel1.Controls.Add(this.dataGrid_AllVehicles);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 580);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.btn_UpdateSubmit);
            this.panel2.Controls.Add(this.lbl_VehiclePlateSearch);
            this.panel2.Controls.Add(this.btn_DeleteVehicle);
            this.panel2.Controls.Add(this.btn_VehicleSearch);
            this.panel2.Controls.Add(this.txt_SearchInformation);
            this.panel2.Controls.Add(this.lbl_SearchClient);
            this.panel2.Location = new System.Drawing.Point(595, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 273);
            this.panel2.TabIndex = 48;
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
            // lbl_VehiclePlateSearch
            // 
            this.lbl_VehiclePlateSearch.AutoSize = true;
            this.lbl_VehiclePlateSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehiclePlateSearch.Location = new System.Drawing.Point(38, 56);
            this.lbl_VehiclePlateSearch.Name = "lbl_VehiclePlateSearch";
            this.lbl_VehiclePlateSearch.Size = new System.Drawing.Size(103, 15);
            this.lbl_VehiclePlateSearch.TabIndex = 41;
            this.lbl_VehiclePlateSearch.Text = "Placa do Veículo:";
            // 
            // btn_DeleteVehicle
            // 
            this.btn_DeleteVehicle.BackColor = System.Drawing.Color.Green;
            this.btn_DeleteVehicle.Enabled = false;
            this.btn_DeleteVehicle.FlatAppearance.BorderSize = 0;
            this.btn_DeleteVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteVehicle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteVehicle.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteVehicle.Location = new System.Drawing.Point(38, 209);
            this.btn_DeleteVehicle.Name = "btn_DeleteVehicle";
            this.btn_DeleteVehicle.Size = new System.Drawing.Size(162, 30);
            this.btn_DeleteVehicle.TabIndex = 43;
            this.btn_DeleteVehicle.Text = "Excluir";
            this.btn_DeleteVehicle.UseVisualStyleBackColor = false;
            this.btn_DeleteVehicle.Click += new System.EventHandler(this.btn_DeleteVehicle_Click);
            // 
            // btn_VehicleSearch
            // 
            this.btn_VehicleSearch.BackColor = System.Drawing.Color.Green;
            this.btn_VehicleSearch.FlatAppearance.BorderSize = 0;
            this.btn_VehicleSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VehicleSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VehicleSearch.ForeColor = System.Drawing.Color.White;
            this.btn_VehicleSearch.Location = new System.Drawing.Point(20, 120);
            this.btn_VehicleSearch.Name = "btn_VehicleSearch";
            this.btn_VehicleSearch.Size = new System.Drawing.Size(204, 30);
            this.btn_VehicleSearch.TabIndex = 60;
            this.btn_VehicleSearch.Text = "Buscar";
            this.btn_VehicleSearch.UseVisualStyleBackColor = false;
            this.btn_VehicleSearch.Click += new System.EventHandler(this.btn_VehicleSearch_Click);
            // 
            // txt_SearchInformation
            // 
            this.txt_SearchInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchInformation.Location = new System.Drawing.Point(38, 74);
            this.txt_SearchInformation.Mask = "AAA-0000";
            this.txt_SearchInformation.Name = "txt_SearchInformation";
            this.txt_SearchInformation.Size = new System.Drawing.Size(162, 22);
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
            // btn_SelectVehicle
            // 
            this.btn_SelectVehicle.BackColor = System.Drawing.Color.Green;
            this.btn_SelectVehicle.FlatAppearance.BorderSize = 0;
            this.btn_SelectVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectVehicle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectVehicle.ForeColor = System.Drawing.Color.White;
            this.btn_SelectVehicle.Location = new System.Drawing.Point(698, 533);
            this.btn_SelectVehicle.Name = "btn_SelectVehicle";
            this.btn_SelectVehicle.Size = new System.Drawing.Size(140, 30);
            this.btn_SelectVehicle.TabIndex = 47;
            this.btn_SelectVehicle.Text = "Selecionar";
            this.btn_SelectVehicle.UseVisualStyleBackColor = false;
            this.btn_SelectVehicle.Click += new System.EventHandler(this.btn_SelectVehicle_Click);
            // 
            // btn_RegisterSubmit
            // 
            this.btn_RegisterSubmit.BackColor = System.Drawing.Color.Green;
            this.btn_RegisterSubmit.FlatAppearance.BorderSize = 0;
            this.btn_RegisterSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegisterSubmit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterSubmit.ForeColor = System.Drawing.Color.White;
            this.btn_RegisterSubmit.Location = new System.Drawing.Point(552, 533);
            this.btn_RegisterSubmit.Name = "btn_RegisterSubmit";
            this.btn_RegisterSubmit.Size = new System.Drawing.Size(140, 30);
            this.btn_RegisterSubmit.TabIndex = 46;
            this.btn_RegisterSubmit.Text = "Cadastrar Veículo";
            this.btn_RegisterSubmit.UseVisualStyleBackColor = false;
            this.btn_RegisterSubmit.Click += new System.EventHandler(this.btn_RegisterSubmit_Click);
            // 
            // dataGrid_AllVehicles
            // 
            this.dataGrid_AllVehicles.AllowUserToAddRows = false;
            this.dataGrid_AllVehicles.AllowUserToDeleteRows = false;
            this.dataGrid_AllVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_AllVehicles.Location = new System.Drawing.Point(26, 346);
            this.dataGrid_AllVehicles.Name = "dataGrid_AllVehicles";
            this.dataGrid_AllVehicles.ReadOnly = true;
            this.dataGrid_AllVehicles.Size = new System.Drawing.Size(812, 181);
            this.dataGrid_AllVehicles.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel3.Controls.Add(this.txt_VehicleDocumentOwner);
            this.panel3.Controls.Add(this.check_VehicleStatus);
            this.panel3.Controls.Add(this.txt_VehiclePlate);
            this.panel3.Controls.Add(this.combo_VehicleType);
            this.panel3.Controls.Add(this.lbl_VehicleType);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_VehiclePlate);
            this.panel3.Controls.Add(this.txt_VehicleModel);
            this.panel3.Controls.Add(this.lbl_VehicleModel);
            this.panel3.Controls.Add(this.lbl_VehicleOwner);
            this.panel3.Location = new System.Drawing.Point(25, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 273);
            this.panel3.TabIndex = 14;
            // 
            // txt_VehicleDocumentOwner
            // 
            this.txt_VehicleDocumentOwner.Location = new System.Drawing.Point(20, 158);
            this.txt_VehicleDocumentOwner.Mask = "000\\.000\\.000-00";
            this.txt_VehicleDocumentOwner.Name = "txt_VehicleDocumentOwner";
            this.txt_VehicleDocumentOwner.Size = new System.Drawing.Size(245, 20);
            this.txt_VehicleDocumentOwner.TabIndex = 32;
            this.txt_VehicleDocumentOwner.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // check_VehicleStatus
            // 
            this.check_VehicleStatus.AutoSize = true;
            this.check_VehicleStatus.Location = new System.Drawing.Point(20, 236);
            this.check_VehicleStatus.Name = "check_VehicleStatus";
            this.check_VehicleStatus.Size = new System.Drawing.Size(50, 17);
            this.check_VehicleStatus.TabIndex = 34;
            this.check_VehicleStatus.Text = "Ativo";
            this.check_VehicleStatus.UseVisualStyleBackColor = true;
            // 
            // txt_VehiclePlate
            // 
            this.txt_VehiclePlate.Location = new System.Drawing.Point(20, 72);
            this.txt_VehiclePlate.Mask = "AAA-0000";
            this.txt_VehiclePlate.Name = "txt_VehiclePlate";
            this.txt_VehiclePlate.Size = new System.Drawing.Size(245, 20);
            this.txt_VehiclePlate.TabIndex = 30;
            this.txt_VehiclePlate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // combo_VehicleType
            // 
            this.combo_VehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_VehicleType.FormattingEnabled = true;
            this.combo_VehicleType.Location = new System.Drawing.Point(20, 199);
            this.combo_VehicleType.Name = "combo_VehicleType";
            this.combo_VehicleType.Size = new System.Drawing.Size(245, 21);
            this.combo_VehicleType.TabIndex = 33;
            // 
            // lbl_VehicleType
            // 
            this.lbl_VehicleType.AutoSize = true;
            this.lbl_VehicleType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleType.Location = new System.Drawing.Point(20, 181);
            this.lbl_VehicleType.Name = "lbl_VehicleType";
            this.lbl_VehicleType.Size = new System.Drawing.Size(94, 15);
            this.lbl_VehicleType.TabIndex = 21;
            this.lbl_VehicleType.Text = "Tipo de Veículo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(23, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Informações do Veículo";
            // 
            // lbl_VehiclePlate
            // 
            this.lbl_VehiclePlate.AutoSize = true;
            this.lbl_VehiclePlate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehiclePlate.Location = new System.Drawing.Point(20, 54);
            this.lbl_VehiclePlate.Name = "lbl_VehiclePlate";
            this.lbl_VehiclePlate.Size = new System.Drawing.Size(103, 15);
            this.lbl_VehiclePlate.TabIndex = 1;
            this.lbl_VehiclePlate.Text = "Placa do Veículo:";
            // 
            // txt_VehicleModel
            // 
            this.txt_VehicleModel.Location = new System.Drawing.Point(20, 113);
            this.txt_VehicleModel.Name = "txt_VehicleModel";
            this.txt_VehicleModel.Size = new System.Drawing.Size(245, 20);
            this.txt_VehicleModel.TabIndex = 31;
            // 
            // lbl_VehicleModel
            // 
            this.lbl_VehicleModel.AutoSize = true;
            this.lbl_VehicleModel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleModel.Location = new System.Drawing.Point(20, 95);
            this.lbl_VehicleModel.Name = "lbl_VehicleModel";
            this.lbl_VehicleModel.Size = new System.Drawing.Size(51, 15);
            this.lbl_VehicleModel.TabIndex = 3;
            this.lbl_VehicleModel.Text = "Modelo:";
            // 
            // lbl_VehicleOwner
            // 
            this.lbl_VehicleOwner.AutoSize = true;
            this.lbl_VehicleOwner.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleOwner.Location = new System.Drawing.Point(20, 136);
            this.lbl_VehicleOwner.Name = "lbl_VehicleOwner";
            this.lbl_VehicleOwner.Size = new System.Drawing.Size(114, 15);
            this.lbl_VehicleOwner.TabIndex = 5;
            this.lbl_VehicleOwner.Text = "CPF do Proprietário:";
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
            // VehicleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "VehicleView";
            this.Size = new System.Drawing.Size(865, 580);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_AllVehicles)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_OK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox txt_VehiclePlate;
        private System.Windows.Forms.ComboBox combo_VehicleType;
        private System.Windows.Forms.Label lbl_VehicleType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_VehiclePlate;
        private System.Windows.Forms.TextBox txt_VehicleModel;
        private System.Windows.Forms.Label lbl_VehicleModel;
        private System.Windows.Forms.Label lbl_VehicleOwner;
        private System.Windows.Forms.DataGridView dataGrid_AllVehicles;
        private System.Windows.Forms.Button btn_SelectVehicle;
        private System.Windows.Forms.Button btn_RegisterSubmit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_UpdateSubmit;
        private System.Windows.Forms.Label lbl_VehiclePlateSearch;
        private System.Windows.Forms.Button btn_DeleteVehicle;
        private System.Windows.Forms.Button btn_VehicleSearch;
        private System.Windows.Forms.MaskedTextBox txt_SearchInformation;
        private System.Windows.Forms.Label lbl_SearchClient;
        private System.Windows.Forms.CheckBox check_VehicleStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider_OK;
        private System.Windows.Forms.MaskedTextBox txt_VehicleDocumentOwner;
    }
}
