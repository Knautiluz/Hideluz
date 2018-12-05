namespace HideluzEstacionamentos.Views
{
    partial class TaxView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxView));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.num_TaxPrice = new System.Windows.Forms.NumericUpDown();
            this.combo_TaxType = new System.Windows.Forms.ComboBox();
            this.combo_VehicleType = new System.Windows.Forms.ComboBox();
            this.lbl_VehicleType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_VehiclePlate = new System.Windows.Forms.Label();
            this.lbl_VehicleModel = new System.Windows.Forms.Label();
            this.dataGrid_AllTaxes = new System.Windows.Forms.DataGridView();
            this.btn_SelectVehicle = new System.Windows.Forms.Button();
            this.btn_RegisterSubmit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_UpdateTax = new System.Windows.Forms.Button();
            this.btn_DeleteTax = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_OK = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TaxID = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_AllTaxes)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_OK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel3.Controls.Add(this.txt_TaxID);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.num_TaxPrice);
            this.panel3.Controls.Add(this.combo_TaxType);
            this.panel3.Controls.Add(this.combo_VehicleType);
            this.panel3.Controls.Add(this.lbl_VehicleType);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_VehiclePlate);
            this.panel3.Controls.Add(this.lbl_VehicleModel);
            this.panel3.Location = new System.Drawing.Point(25, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 273);
            this.panel3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(20, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 64;
            this.label1.Text = "R$";
            // 
            // num_TaxPrice
            // 
            this.num_TaxPrice.DecimalPlaces = 2;
            this.num_TaxPrice.Location = new System.Drawing.Point(42, 158);
            this.num_TaxPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_TaxPrice.Name = "num_TaxPrice";
            this.num_TaxPrice.Size = new System.Drawing.Size(223, 20);
            this.num_TaxPrice.TabIndex = 63;
            // 
            // combo_TaxType
            // 
            this.combo_TaxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_TaxType.FormattingEnabled = true;
            this.combo_TaxType.Location = new System.Drawing.Point(20, 113);
            this.combo_TaxType.Name = "combo_TaxType";
            this.combo_TaxType.Size = new System.Drawing.Size(245, 21);
            this.combo_TaxType.TabIndex = 35;
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
            this.label2.Size = new System.Drawing.Size(210, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Informações da Tarifa";
            // 
            // lbl_VehiclePlate
            // 
            this.lbl_VehiclePlate.AutoSize = true;
            this.lbl_VehiclePlate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehiclePlate.Location = new System.Drawing.Point(20, 95);
            this.lbl_VehiclePlate.Name = "lbl_VehiclePlate";
            this.lbl_VehiclePlate.Size = new System.Drawing.Size(81, 15);
            this.lbl_VehiclePlate.TabIndex = 1;
            this.lbl_VehiclePlate.Text = "Tipo da Tarifa:";
            // 
            // lbl_VehicleModel
            // 
            this.lbl_VehicleModel.AutoSize = true;
            this.lbl_VehicleModel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleModel.Location = new System.Drawing.Point(20, 136);
            this.lbl_VehicleModel.Name = "lbl_VehicleModel";
            this.lbl_VehicleModel.Size = new System.Drawing.Size(42, 15);
            this.lbl_VehicleModel.TabIndex = 3;
            this.lbl_VehicleModel.Text = "Preço:";
            // 
            // dataGrid_AllTaxes
            // 
            this.dataGrid_AllTaxes.AllowUserToAddRows = false;
            this.dataGrid_AllTaxes.AllowUserToDeleteRows = false;
            this.dataGrid_AllTaxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_AllTaxes.Location = new System.Drawing.Point(26, 346);
            this.dataGrid_AllTaxes.Name = "dataGrid_AllTaxes";
            this.dataGrid_AllTaxes.ReadOnly = true;
            this.dataGrid_AllTaxes.Size = new System.Drawing.Size(812, 181);
            this.dataGrid_AllTaxes.TabIndex = 50;
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
            this.btn_SelectVehicle.TabIndex = 52;
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
            this.btn_RegisterSubmit.TabIndex = 51;
            this.btn_RegisterSubmit.Text = "Cadastrar Tarifa";
            this.btn_RegisterSubmit.UseVisualStyleBackColor = false;
            this.btn_RegisterSubmit.Click += new System.EventHandler(this.btn_RegisterSubmit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.btn_UpdateTax);
            this.panel2.Controls.Add(this.btn_DeleteTax);
            this.panel2.Location = new System.Drawing.Point(596, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 124);
            this.panel2.TabIndex = 62;
            // 
            // btn_UpdateTax
            // 
            this.btn_UpdateTax.BackColor = System.Drawing.Color.Green;
            this.btn_UpdateTax.Enabled = false;
            this.btn_UpdateTax.FlatAppearance.BorderSize = 0;
            this.btn_UpdateTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateTax.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateTax.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateTax.Location = new System.Drawing.Point(36, 26);
            this.btn_UpdateTax.Name = "btn_UpdateTax";
            this.btn_UpdateTax.Size = new System.Drawing.Size(162, 30);
            this.btn_UpdateTax.TabIndex = 61;
            this.btn_UpdateTax.Text = "Salvar Alterações";
            this.btn_UpdateTax.UseVisualStyleBackColor = false;
            this.btn_UpdateTax.Click += new System.EventHandler(this.btn_UpdateTax_Click);
            // 
            // btn_DeleteTax
            // 
            this.btn_DeleteTax.BackColor = System.Drawing.Color.Green;
            this.btn_DeleteTax.Enabled = false;
            this.btn_DeleteTax.FlatAppearance.BorderSize = 0;
            this.btn_DeleteTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteTax.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteTax.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteTax.Location = new System.Drawing.Point(36, 69);
            this.btn_DeleteTax.Name = "btn_DeleteTax";
            this.btn_DeleteTax.Size = new System.Drawing.Size(162, 30);
            this.btn_DeleteTax.TabIndex = 43;
            this.btn_DeleteTax.Text = "Excluir";
            this.btn_DeleteTax.UseVisualStyleBackColor = false;
            this.btn_DeleteTax.Click += new System.EventHandler(this.btn_DeleteTax_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 65;
            this.label3.Text = "ID da Tarifa:";
            // 
            // txt_TaxID
            // 
            this.txt_TaxID.Enabled = false;
            this.txt_TaxID.Location = new System.Drawing.Point(20, 72);
            this.txt_TaxID.Name = "txt_TaxID";
            this.txt_TaxID.Size = new System.Drawing.Size(245, 20);
            this.txt_TaxID.TabIndex = 66;
            // 
            // TaxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_SelectVehicle);
            this.Controls.Add(this.btn_RegisterSubmit);
            this.Controls.Add(this.dataGrid_AllTaxes);
            this.Controls.Add(this.panel3);
            this.Name = "TaxView";
            this.Size = new System.Drawing.Size(865, 580);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_AllTaxes)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_OK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox combo_VehicleType;
        private System.Windows.Forms.Label lbl_VehicleType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_VehiclePlate;
        private System.Windows.Forms.Label lbl_VehicleModel;
        private System.Windows.Forms.DataGridView dataGrid_AllTaxes;
        private System.Windows.Forms.Button btn_SelectVehicle;
        private System.Windows.Forms.Button btn_RegisterSubmit;
        private System.Windows.Forms.ComboBox combo_TaxType;
        private System.Windows.Forms.NumericUpDown num_TaxPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_UpdateTax;
        private System.Windows.Forms.Button btn_DeleteTax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider_OK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TaxID;
    }
}
