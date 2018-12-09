namespace HideluzEstacionamentos.Views
{
    partial class HomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.panel3 = new System.Windows.Forms.Panel();
            this.combo_VehicleList = new System.Windows.Forms.ComboBox();
            this.txt_VehiclePlate = new System.Windows.Forms.MaskedTextBox();
            this.lbl_VehiclePlate = new System.Windows.Forms.Label();
            this.btn_EntranceSubmit = new System.Windows.Forms.Button();
            this.combo_VehicleTypeEntry = new System.Windows.Forms.ComboBox();
            this.lbl_VehicleType = new System.Windows.Forms.Label();
            this.combo_TaxTypeEntry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_ClientTypeEntry = new System.Windows.Forms.ComboBox();
            this.lbl_ClientName = new System.Windows.Forms.Label();
            this.lbl_Entrance = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_LeaveSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Leave = new System.Windows.Forms.Label();
            this.ReceiptPanel = new System.Windows.Forms.Panel();
            this.btn_EmailReceipt = new System.Windows.Forms.Button();
            this.panel_Receipt = new System.Windows.Forms.Panel();
            this.lbl_VehiclePlateReceipt = new System.Windows.Forms.Label();
            this.lbl_VehiclePlateReceiptName = new System.Windows.Forms.Label();
            this.lbl_DateReceipt = new System.Windows.Forms.Label();
            this.lbl_HourReceipt = new System.Windows.Forms.Label();
            this.lbl_ReceiptOperation = new System.Windows.Forms.Label();
            this.lbl_ReceiptParkingName = new System.Windows.Forms.Label();
            this.btn_PrintReceipt = new System.Windows.Forms.Button();
            this.lbl_Receipt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGrid_ParkedVehicles = new System.Windows.Forms.DataGridView();
            this.lbl_ParkedVehicles = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_OK = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_SelectParkedVehicle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ClientLeave = new System.Windows.Forms.TextBox();
            this.txt_VehicleTypeLeave = new System.Windows.Forms.TextBox();
            this.txt_TaxTypeLeave = new System.Windows.Forms.TextBox();
            this.txt_VehiclePlateLeave = new System.Windows.Forms.TextBox();
            this.txt_EntryTimeLeave = new System.Windows.Forms.TextBox();
            this.lbl_EntryTime = new System.Windows.Forms.Label();
            this.lbl_TotalToPay = new System.Windows.Forms.Label();
            this.lbl_PricePay = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ReceiptPanel.SuspendLayout();
            this.panel_Receipt.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ParkedVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_OK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel3.Controls.Add(this.combo_VehicleList);
            this.panel3.Controls.Add(this.txt_VehiclePlate);
            this.panel3.Controls.Add(this.lbl_VehiclePlate);
            this.panel3.Controls.Add(this.btn_EntranceSubmit);
            this.panel3.Controls.Add(this.combo_VehicleTypeEntry);
            this.panel3.Controls.Add(this.lbl_VehicleType);
            this.panel3.Controls.Add(this.combo_TaxTypeEntry);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.combo_ClientTypeEntry);
            this.panel3.Controls.Add(this.lbl_ClientName);
            this.panel3.Controls.Add(this.lbl_Entrance);
            this.panel3.Location = new System.Drawing.Point(10, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 300);
            this.panel3.TabIndex = 16;
            // 
            // combo_VehicleList
            // 
            this.combo_VehicleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_VehicleList.FormattingEnabled = true;
            this.combo_VehicleList.Location = new System.Drawing.Point(20, 193);
            this.combo_VehicleList.Name = "combo_VehicleList";
            this.combo_VehicleList.Size = new System.Drawing.Size(230, 21);
            this.combo_VehicleList.TabIndex = 65;
            this.combo_VehicleList.Visible = false;
            // 
            // txt_VehiclePlate
            // 
            this.txt_VehiclePlate.Location = new System.Drawing.Point(20, 193);
            this.txt_VehiclePlate.Mask = "AAA-0000";
            this.txt_VehiclePlate.Name = "txt_VehiclePlate";
            this.txt_VehiclePlate.Size = new System.Drawing.Size(230, 20);
            this.txt_VehiclePlate.TabIndex = 64;
            this.txt_VehiclePlate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // lbl_VehiclePlate
            // 
            this.lbl_VehiclePlate.AutoSize = true;
            this.lbl_VehiclePlate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehiclePlate.Location = new System.Drawing.Point(20, 174);
            this.lbl_VehiclePlate.Name = "lbl_VehiclePlate";
            this.lbl_VehiclePlate.Size = new System.Drawing.Size(103, 15);
            this.lbl_VehiclePlate.TabIndex = 63;
            this.lbl_VehiclePlate.Text = "Placa do Veículo:";
            // 
            // btn_EntranceSubmit
            // 
            this.btn_EntranceSubmit.BackColor = System.Drawing.Color.Green;
            this.btn_EntranceSubmit.FlatAppearance.BorderSize = 0;
            this.btn_EntranceSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EntranceSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EntranceSubmit.ForeColor = System.Drawing.Color.White;
            this.btn_EntranceSubmit.Location = new System.Drawing.Point(10, 248);
            this.btn_EntranceSubmit.Margin = new System.Windows.Forms.Padding(10);
            this.btn_EntranceSubmit.Name = "btn_EntranceSubmit";
            this.btn_EntranceSubmit.Size = new System.Drawing.Size(267, 38);
            this.btn_EntranceSubmit.TabIndex = 62;
            this.btn_EntranceSubmit.Text = "MARCAR ENTRADA";
            this.btn_EntranceSubmit.UseVisualStyleBackColor = false;
            this.btn_EntranceSubmit.Click += new System.EventHandler(this.btn_EntranceSubmit_Click);
            // 
            // combo_VehicleTypeEntry
            // 
            this.combo_VehicleTypeEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_VehicleTypeEntry.FormattingEnabled = true;
            this.combo_VehicleTypeEntry.Location = new System.Drawing.Point(20, 105);
            this.combo_VehicleTypeEntry.Name = "combo_VehicleTypeEntry";
            this.combo_VehicleTypeEntry.Size = new System.Drawing.Size(230, 21);
            this.combo_VehicleTypeEntry.TabIndex = 41;
            this.combo_VehicleTypeEntry.SelectedIndexChanged += new System.EventHandler(this.combo_VehicleTypeEntry_SelectedIndexChanged);
            // 
            // lbl_VehicleType
            // 
            this.lbl_VehicleType.AutoSize = true;
            this.lbl_VehicleType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleType.Location = new System.Drawing.Point(20, 86);
            this.lbl_VehicleType.Name = "lbl_VehicleType";
            this.lbl_VehicleType.Size = new System.Drawing.Size(94, 15);
            this.lbl_VehicleType.TabIndex = 40;
            this.lbl_VehicleType.Text = "Tipo de Veículo:";
            // 
            // combo_TaxTypeEntry
            // 
            this.combo_TaxTypeEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_TaxTypeEntry.FormattingEnabled = true;
            this.combo_TaxTypeEntry.Location = new System.Drawing.Point(20, 150);
            this.combo_TaxTypeEntry.Name = "combo_TaxTypeEntry";
            this.combo_TaxTypeEntry.Size = new System.Drawing.Size(230, 21);
            this.combo_TaxTypeEntry.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tipo da Tarifa:";
            // 
            // combo_ClientTypeEntry
            // 
            this.combo_ClientTypeEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ClientTypeEntry.FormattingEnabled = true;
            this.combo_ClientTypeEntry.Location = new System.Drawing.Point(20, 61);
            this.combo_ClientTypeEntry.Name = "combo_ClientTypeEntry";
            this.combo_ClientTypeEntry.Size = new System.Drawing.Size(230, 21);
            this.combo_ClientTypeEntry.TabIndex = 37;
            this.combo_ClientTypeEntry.SelectedIndexChanged += new System.EventHandler(this.combo_ClientTypeEntry_SelectedIndexChanged);
            // 
            // lbl_ClientName
            // 
            this.lbl_ClientName.AutoSize = true;
            this.lbl_ClientName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientName.Location = new System.Drawing.Point(20, 42);
            this.lbl_ClientName.Name = "lbl_ClientName";
            this.lbl_ClientName.Size = new System.Drawing.Size(48, 15);
            this.lbl_ClientName.TabIndex = 36;
            this.lbl_ClientName.Text = "Cliente:";
            // 
            // lbl_Entrance
            // 
            this.lbl_Entrance.AutoSize = true;
            this.lbl_Entrance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Entrance.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Entrance.Location = new System.Drawing.Point(62, 5);
            this.lbl_Entrance.Name = "lbl_Entrance";
            this.lbl_Entrance.Size = new System.Drawing.Size(154, 23);
            this.lbl_Entrance.TabIndex = 20;
            this.lbl_Entrance.Text = "Marcar Entrada";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.txt_EntryTimeLeave);
            this.panel1.Controls.Add(this.lbl_EntryTime);
            this.panel1.Controls.Add(this.txt_VehiclePlateLeave);
            this.panel1.Controls.Add(this.txt_TaxTypeLeave);
            this.panel1.Controls.Add(this.txt_VehicleTypeLeave);
            this.panel1.Controls.Add(this.txt_ClientLeave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_LeaveSubmit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_Leave);
            this.panel1.Location = new System.Drawing.Point(307, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 300);
            this.panel1.TabIndex = 19;
            // 
            // btn_LeaveSubmit
            // 
            this.btn_LeaveSubmit.BackColor = System.Drawing.Color.Green;
            this.btn_LeaveSubmit.Enabled = false;
            this.btn_LeaveSubmit.FlatAppearance.BorderSize = 0;
            this.btn_LeaveSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LeaveSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LeaveSubmit.ForeColor = System.Drawing.Color.White;
            this.btn_LeaveSubmit.Location = new System.Drawing.Point(10, 248);
            this.btn_LeaveSubmit.Margin = new System.Windows.Forms.Padding(10);
            this.btn_LeaveSubmit.Name = "btn_LeaveSubmit";
            this.btn_LeaveSubmit.Size = new System.Drawing.Size(267, 38);
            this.btn_LeaveSubmit.TabIndex = 62;
            this.btn_LeaveSubmit.Text = "MARCAR SAÍDA";
            this.btn_LeaveSubmit.UseVisualStyleBackColor = false;
            this.btn_LeaveSubmit.Click += new System.EventHandler(this.btn_LeaveSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tipo Veículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tipo da Tarifa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Cliente:";
            // 
            // lbl_Leave
            // 
            this.lbl_Leave.AutoSize = true;
            this.lbl_Leave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Leave.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Leave.Location = new System.Drawing.Point(73, 5);
            this.lbl_Leave.Name = "lbl_Leave";
            this.lbl_Leave.Size = new System.Drawing.Size(136, 23);
            this.lbl_Leave.TabIndex = 20;
            this.lbl_Leave.Text = "Marcar Saída";
            // 
            // ReceiptPanel
            // 
            this.ReceiptPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ReceiptPanel.Controls.Add(this.btn_EmailReceipt);
            this.ReceiptPanel.Controls.Add(this.panel_Receipt);
            this.ReceiptPanel.Controls.Add(this.btn_PrintReceipt);
            this.ReceiptPanel.Controls.Add(this.lbl_Receipt);
            this.ReceiptPanel.Location = new System.Drawing.Point(604, 15);
            this.ReceiptPanel.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.ReceiptPanel.Name = "ReceiptPanel";
            this.ReceiptPanel.Size = new System.Drawing.Size(251, 549);
            this.ReceiptPanel.TabIndex = 20;
            this.ReceiptPanel.Visible = false;
            // 
            // btn_EmailReceipt
            // 
            this.btn_EmailReceipt.BackColor = System.Drawing.Color.Green;
            this.btn_EmailReceipt.Enabled = false;
            this.btn_EmailReceipt.FlatAppearance.BorderSize = 0;
            this.btn_EmailReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EmailReceipt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EmailReceipt.ForeColor = System.Drawing.Color.White;
            this.btn_EmailReceipt.Location = new System.Drawing.Point(15, 490);
            this.btn_EmailReceipt.Margin = new System.Windows.Forms.Padding(10);
            this.btn_EmailReceipt.Name = "btn_EmailReceipt";
            this.btn_EmailReceipt.Size = new System.Drawing.Size(221, 38);
            this.btn_EmailReceipt.TabIndex = 67;
            this.btn_EmailReceipt.Text = "E-MAIL";
            this.btn_EmailReceipt.UseVisualStyleBackColor = false;
            // 
            // panel_Receipt
            // 
            this.panel_Receipt.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel_Receipt.Controls.Add(this.lbl_PricePay);
            this.panel_Receipt.Controls.Add(this.lbl_TotalToPay);
            this.panel_Receipt.Controls.Add(this.lbl_VehiclePlateReceipt);
            this.panel_Receipt.Controls.Add(this.lbl_VehiclePlateReceiptName);
            this.panel_Receipt.Controls.Add(this.lbl_DateReceipt);
            this.panel_Receipt.Controls.Add(this.lbl_HourReceipt);
            this.panel_Receipt.Controls.Add(this.lbl_ReceiptOperation);
            this.panel_Receipt.Controls.Add(this.lbl_ReceiptParkingName);
            this.panel_Receipt.Location = new System.Drawing.Point(15, 42);
            this.panel_Receipt.Name = "panel_Receipt";
            this.panel_Receipt.Size = new System.Drawing.Size(221, 269);
            this.panel_Receipt.TabIndex = 66;
            // 
            // lbl_VehiclePlateReceipt
            // 
            this.lbl_VehiclePlateReceipt.AutoSize = true;
            this.lbl_VehiclePlateReceipt.Font = new System.Drawing.Font("Myriad Pro", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehiclePlateReceipt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_VehiclePlateReceipt.Location = new System.Drawing.Point(40, 163);
            this.lbl_VehiclePlateReceipt.Name = "lbl_VehiclePlateReceipt";
            this.lbl_VehiclePlateReceipt.Size = new System.Drawing.Size(139, 33);
            this.lbl_VehiclePlateReceipt.TabIndex = 5;
            this.lbl_VehiclePlateReceipt.Text = "ABC 1234";
            this.lbl_VehiclePlateReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_VehiclePlateReceiptName
            // 
            this.lbl_VehiclePlateReceiptName.AutoSize = true;
            this.lbl_VehiclePlateReceiptName.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehiclePlateReceiptName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_VehiclePlateReceiptName.Location = new System.Drawing.Point(73, 141);
            this.lbl_VehiclePlateReceiptName.Name = "lbl_VehiclePlateReceiptName";
            this.lbl_VehiclePlateReceiptName.Size = new System.Drawing.Size(72, 24);
            this.lbl_VehiclePlateReceiptName.TabIndex = 4;
            this.lbl_VehiclePlateReceiptName.Text = "PLACA";
            this.lbl_VehiclePlateReceiptName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DateReceipt
            // 
            this.lbl_DateReceipt.AutoSize = true;
            this.lbl_DateReceipt.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateReceipt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_DateReceipt.Location = new System.Drawing.Point(73, 105);
            this.lbl_DateReceipt.Name = "lbl_DateReceipt";
            this.lbl_DateReceipt.Size = new System.Drawing.Size(72, 16);
            this.lbl_DateReceipt.TabIndex = 3;
            this.lbl_DateReceipt.Text = "00/00/0000";
            this.lbl_DateReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_HourReceipt
            // 
            this.lbl_HourReceipt.AutoSize = true;
            this.lbl_HourReceipt.Font = new System.Drawing.Font("Myriad Pro", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HourReceipt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_HourReceipt.Location = new System.Drawing.Point(66, 68);
            this.lbl_HourReceipt.Name = "lbl_HourReceipt";
            this.lbl_HourReceipt.Size = new System.Drawing.Size(87, 33);
            this.lbl_HourReceipt.TabIndex = 2;
            this.lbl_HourReceipt.Text = "00:00";
            this.lbl_HourReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ReceiptOperation
            // 
            this.lbl_ReceiptOperation.AutoSize = true;
            this.lbl_ReceiptOperation.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReceiptOperation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ReceiptOperation.Location = new System.Drawing.Point(74, 47);
            this.lbl_ReceiptOperation.Name = "lbl_ReceiptOperation";
            this.lbl_ReceiptOperation.Size = new System.Drawing.Size(70, 24);
            this.lbl_ReceiptOperation.TabIndex = 1;
            this.lbl_ReceiptOperation.Text = "SAÍDA";
            this.lbl_ReceiptOperation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ReceiptParkingName
            // 
            this.lbl_ReceiptParkingName.AutoSize = true;
            this.lbl_ReceiptParkingName.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReceiptParkingName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ReceiptParkingName.Location = new System.Drawing.Point(34, 11);
            this.lbl_ReceiptParkingName.Name = "lbl_ReceiptParkingName";
            this.lbl_ReceiptParkingName.Size = new System.Drawing.Size(151, 14);
            this.lbl_ReceiptParkingName.TabIndex = 0;
            this.lbl_ReceiptParkingName.Text = "ESTACIONAMENTO HIDELUZ";
            this.lbl_ReceiptParkingName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_PrintReceipt
            // 
            this.btn_PrintReceipt.BackColor = System.Drawing.Color.Green;
            this.btn_PrintReceipt.Enabled = false;
            this.btn_PrintReceipt.FlatAppearance.BorderSize = 0;
            this.btn_PrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrintReceipt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintReceipt.ForeColor = System.Drawing.Color.White;
            this.btn_PrintReceipt.Location = new System.Drawing.Point(15, 444);
            this.btn_PrintReceipt.Margin = new System.Windows.Forms.Padding(10);
            this.btn_PrintReceipt.Name = "btn_PrintReceipt";
            this.btn_PrintReceipt.Size = new System.Drawing.Size(221, 38);
            this.btn_PrintReceipt.TabIndex = 65;
            this.btn_PrintReceipt.Text = "IMPRIMIR";
            this.btn_PrintReceipt.UseVisualStyleBackColor = false;
            // 
            // lbl_Receipt
            // 
            this.lbl_Receipt.AutoSize = true;
            this.lbl_Receipt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Receipt.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Receipt.Location = new System.Drawing.Point(59, 5);
            this.lbl_Receipt.Name = "lbl_Receipt";
            this.lbl_Receipt.Size = new System.Drawing.Size(139, 23);
            this.lbl_Receipt.TabIndex = 63;
            this.lbl_Receipt.Text = "Comprovante";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.btn_SelectParkedVehicle);
            this.panel2.Controls.Add(this.dataGrid_ParkedVehicles);
            this.panel2.Controls.Add(this.lbl_ParkedVehicles);
            this.panel2.Location = new System.Drawing.Point(10, 326);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 238);
            this.panel2.TabIndex = 21;
            // 
            // dataGrid_ParkedVehicles
            // 
            this.dataGrid_ParkedVehicles.AllowUserToAddRows = false;
            this.dataGrid_ParkedVehicles.AllowUserToDeleteRows = false;
            this.dataGrid_ParkedVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ParkedVehicles.Location = new System.Drawing.Point(10, 37);
            this.dataGrid_ParkedVehicles.Margin = new System.Windows.Forms.Padding(10);
            this.dataGrid_ParkedVehicles.Name = "dataGrid_ParkedVehicles";
            this.dataGrid_ParkedVehicles.Size = new System.Drawing.Size(564, 172);
            this.dataGrid_ParkedVehicles.TabIndex = 21;
            // 
            // lbl_ParkedVehicles
            // 
            this.lbl_ParkedVehicles.AutoSize = true;
            this.lbl_ParkedVehicles.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ParkedVehicles.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ParkedVehicles.Location = new System.Drawing.Point(182, 4);
            this.lbl_ParkedVehicles.Name = "lbl_ParkedVehicles";
            this.lbl_ParkedVehicles.Size = new System.Drawing.Size(216, 23);
            this.lbl_ParkedVehicles.TabIndex = 20;
            this.lbl_ParkedVehicles.Text = "Veículos Estacionados";
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
            // btn_SelectParkedVehicle
            // 
            this.btn_SelectParkedVehicle.BackColor = System.Drawing.Color.Green;
            this.btn_SelectParkedVehicle.FlatAppearance.BorderSize = 0;
            this.btn_SelectParkedVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectParkedVehicle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectParkedVehicle.ForeColor = System.Drawing.Color.White;
            this.btn_SelectParkedVehicle.Location = new System.Drawing.Point(441, 212);
            this.btn_SelectParkedVehicle.Margin = new System.Windows.Forms.Padding(10);
            this.btn_SelectParkedVehicle.Name = "btn_SelectParkedVehicle";
            this.btn_SelectParkedVehicle.Size = new System.Drawing.Size(133, 22);
            this.btn_SelectParkedVehicle.TabIndex = 66;
            this.btn_SelectParkedVehicle.Text = "SELECIONAR";
            this.btn_SelectParkedVehicle.UseVisualStyleBackColor = false;
            this.btn_SelectParkedVehicle.Click += new System.EventHandler(this.btn_SelectParkedVehicle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "Placa do Veículo:";
            // 
            // txt_ClientLeave
            // 
            this.txt_ClientLeave.Enabled = false;
            this.txt_ClientLeave.Location = new System.Drawing.Point(23, 61);
            this.txt_ClientLeave.Name = "txt_ClientLeave";
            this.txt_ClientLeave.Size = new System.Drawing.Size(230, 20);
            this.txt_ClientLeave.TabIndex = 67;
            // 
            // txt_VehicleTypeLeave
            // 
            this.txt_VehicleTypeLeave.Enabled = false;
            this.txt_VehicleTypeLeave.Location = new System.Drawing.Point(23, 105);
            this.txt_VehicleTypeLeave.Name = "txt_VehicleTypeLeave";
            this.txt_VehicleTypeLeave.Size = new System.Drawing.Size(103, 20);
            this.txt_VehicleTypeLeave.TabIndex = 68;
            // 
            // txt_TaxTypeLeave
            // 
            this.txt_TaxTypeLeave.Enabled = false;
            this.txt_TaxTypeLeave.Location = new System.Drawing.Point(131, 105);
            this.txt_TaxTypeLeave.Name = "txt_TaxTypeLeave";
            this.txt_TaxTypeLeave.Size = new System.Drawing.Size(122, 20);
            this.txt_TaxTypeLeave.TabIndex = 69;
            // 
            // txt_VehiclePlateLeave
            // 
            this.txt_VehiclePlateLeave.Enabled = false;
            this.txt_VehiclePlateLeave.Location = new System.Drawing.Point(23, 151);
            this.txt_VehiclePlateLeave.Name = "txt_VehiclePlateLeave";
            this.txt_VehiclePlateLeave.Size = new System.Drawing.Size(230, 20);
            this.txt_VehiclePlateLeave.TabIndex = 70;
            // 
            // txt_EntryTimeLeave
            // 
            this.txt_EntryTimeLeave.Enabled = false;
            this.txt_EntryTimeLeave.Location = new System.Drawing.Point(23, 193);
            this.txt_EntryTimeLeave.Name = "txt_EntryTimeLeave";
            this.txt_EntryTimeLeave.Size = new System.Drawing.Size(230, 20);
            this.txt_EntryTimeLeave.TabIndex = 72;
            // 
            // lbl_EntryTime
            // 
            this.lbl_EntryTime.AutoSize = true;
            this.lbl_EntryTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EntryTime.Location = new System.Drawing.Point(23, 175);
            this.lbl_EntryTime.Name = "lbl_EntryTime";
            this.lbl_EntryTime.Size = new System.Drawing.Size(96, 15);
            this.lbl_EntryTime.TabIndex = 71;
            this.lbl_EntryTime.Text = "Data de Entrada:";
            // 
            // lbl_TotalToPay
            // 
            this.lbl_TotalToPay.AutoSize = true;
            this.lbl_TotalToPay.Font = new System.Drawing.Font("Myriad Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalToPay.Location = new System.Drawing.Point(64, 210);
            this.lbl_TotalToPay.Name = "lbl_TotalToPay";
            this.lbl_TotalToPay.Size = new System.Drawing.Size(92, 14);
            this.lbl_TotalToPay.TabIndex = 6;
            this.lbl_TotalToPay.Text = "TOTAL A PAGAR";
            this.lbl_TotalToPay.Visible = false;
            // 
            // lbl_PricePay
            // 
            this.lbl_PricePay.AutoSize = true;
            this.lbl_PricePay.Font = new System.Drawing.Font("Myriad Pro", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PricePay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_PricePay.Location = new System.Drawing.Point(45, 224);
            this.lbl_PricePay.Name = "lbl_PricePay";
            this.lbl_PricePay.Size = new System.Drawing.Size(126, 33);
            this.lbl_PricePay.TabIndex = 7;
            this.lbl_PricePay.Text = "R$ 10,00";
            this.lbl_PricePay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_PricePay.Visible = false;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ReceiptPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "HomeView";
            this.Size = new System.Drawing.Size(865, 580);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ReceiptPanel.ResumeLayout(false);
            this.ReceiptPanel.PerformLayout();
            this.panel_Receipt.ResumeLayout(false);
            this.panel_Receipt.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ParkedVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_OK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Entrance;
        private System.Windows.Forms.ComboBox combo_TaxTypeEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_ClientTypeEntry;
        private System.Windows.Forms.Label lbl_ClientName;
        private System.Windows.Forms.ComboBox combo_VehicleTypeEntry;
        private System.Windows.Forms.Label lbl_VehicleType;
        private System.Windows.Forms.Button btn_EntranceSubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_LeaveSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Leave;
        private System.Windows.Forms.Panel ReceiptPanel;
        private System.Windows.Forms.Label lbl_Receipt;
        private System.Windows.Forms.Button btn_PrintReceipt;
        private System.Windows.Forms.Panel panel_Receipt;
        private System.Windows.Forms.Label lbl_HourReceipt;
        private System.Windows.Forms.Label lbl_ReceiptOperation;
        private System.Windows.Forms.Label lbl_ReceiptParkingName;
        private System.Windows.Forms.Label lbl_DateReceipt;
        private System.Windows.Forms.Label lbl_VehiclePlateReceipt;
        private System.Windows.Forms.Label lbl_VehiclePlateReceiptName;
        private System.Windows.Forms.Button btn_EmailReceipt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGrid_ParkedVehicles;
        private System.Windows.Forms.Label lbl_ParkedVehicles;
        private System.Windows.Forms.Label lbl_VehiclePlate;
        private System.Windows.Forms.MaskedTextBox txt_VehiclePlate;
        private System.Windows.Forms.ComboBox combo_VehicleList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider_OK;
        private System.Windows.Forms.Button btn_SelectParkedVehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_VehiclePlateLeave;
        private System.Windows.Forms.TextBox txt_TaxTypeLeave;
        private System.Windows.Forms.TextBox txt_VehicleTypeLeave;
        private System.Windows.Forms.TextBox txt_ClientLeave;
        private System.Windows.Forms.TextBox txt_EntryTimeLeave;
        private System.Windows.Forms.Label lbl_EntryTime;
        private System.Windows.Forms.Label lbl_TotalToPay;
        private System.Windows.Forms.Label lbl_PricePay;
    }
}
