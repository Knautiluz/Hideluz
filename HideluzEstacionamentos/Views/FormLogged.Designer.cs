namespace HideluzEstacionamentos
{
    partial class FormLogged
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
            this.HideluzMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClientToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultClientToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeClientToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveClientToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.VehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddVehicleToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultVehicleToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeVehicleToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveVehicleToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperatorTaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperatorConsultTaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmTaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministratorAddTaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministratorConsultTaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministratorChangeTaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministratorRemoveTaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperatorStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelPayment = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGenerateExit = new System.Windows.Forms.Button();
            this.ClientTextBoxKey = new System.Windows.Forms.MaskedTextBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGenerateEntry = new System.Windows.Forms.Button();
            this.VehicleClientResultListBox = new System.Windows.Forms.ListBox();
            this.FormLoggedMainPanel = new System.Windows.Forms.Panel();
            this.HideluzMenuStrip.SuspendLayout();
            this.PanelPayment.SuspendLayout();
            this.FormLoggedMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HideluzMenuStrip
            // 
            this.HideluzMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientToolStripMenuItem,
            this.UserToolStripMenuItem,
            this.VehicleToolStripMenuItem,
            this.OperatorTaxToolStripMenuItem,
            this.AdmTaxToolStripMenuItem,
            this.OperatorStripMenuItem});
            this.HideluzMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.HideluzMenuStrip.Name = "HideluzMenuStrip";
            this.HideluzMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.HideluzMenuStrip.TabIndex = 6;
            this.HideluzMenuStrip.Text = "menuStrip1";
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClientToolStripItem,
            this.ConsultClientToolStripItem,
            this.ChangeClientToolStripItem,
            this.RemoveClientToolStripItem});
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ClientToolStripMenuItem.Text = "&Cliente";
            // 
            // AddClientToolStripItem
            // 
            this.AddClientToolStripItem.Name = "AddClientToolStripItem";
            this.AddClientToolStripItem.Size = new System.Drawing.Size(125, 22);
            this.AddClientToolStripItem.Text = "Adicionar";
            this.AddClientToolStripItem.Click += new System.EventHandler(this.AddClientToolStripItem_Click);
            // 
            // ConsultClientToolStripItem
            // 
            this.ConsultClientToolStripItem.Name = "ConsultClientToolStripItem";
            this.ConsultClientToolStripItem.Size = new System.Drawing.Size(125, 22);
            this.ConsultClientToolStripItem.Text = "Consultar";
            this.ConsultClientToolStripItem.Click += new System.EventHandler(this.ConsultClientToolStripItem_Click);
            // 
            // ChangeClientToolStripItem
            // 
            this.ChangeClientToolStripItem.Name = "ChangeClientToolStripItem";
            this.ChangeClientToolStripItem.Size = new System.Drawing.Size(125, 22);
            this.ChangeClientToolStripItem.Text = "Alterar";
            this.ChangeClientToolStripItem.Click += new System.EventHandler(this.ChangeClientToolStripItem_Click);
            // 
            // RemoveClientToolStripItem
            // 
            this.RemoveClientToolStripItem.Name = "RemoveClientToolStripItem";
            this.RemoveClientToolStripItem.Size = new System.Drawing.Size(125, 22);
            this.RemoveClientToolStripItem.Text = "Remover";
            this.RemoveClientToolStripItem.Click += new System.EventHandler(this.RemoveClientToolStripItem_Click);
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUserToolStripMenuItem1,
            this.ConsultUserToolStripMenuItem1,
            this.ChangeUserToolStripMenuItem1,
            this.RemoveUserToolStripMenuItem1});
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.UserToolStripMenuItem.Text = "&Usuario";
            // 
            // AddUserToolStripMenuItem1
            // 
            this.AddUserToolStripMenuItem1.Name = "AddUserToolStripMenuItem1";
            this.AddUserToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.AddUserToolStripMenuItem1.Text = "Adicionar";
            this.AddUserToolStripMenuItem1.Click += new System.EventHandler(this.AddUserToolStripMenuItem1_Click);
            // 
            // ConsultUserToolStripMenuItem1
            // 
            this.ConsultUserToolStripMenuItem1.Name = "ConsultUserToolStripMenuItem1";
            this.ConsultUserToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.ConsultUserToolStripMenuItem1.Text = "Consultar";
            this.ConsultUserToolStripMenuItem1.Click += new System.EventHandler(this.ConsultUserToolStripMenuItem1_Click);
            // 
            // ChangeUserToolStripMenuItem1
            // 
            this.ChangeUserToolStripMenuItem1.Name = "ChangeUserToolStripMenuItem1";
            this.ChangeUserToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.ChangeUserToolStripMenuItem1.Text = "Alterar";
            this.ChangeUserToolStripMenuItem1.Click += new System.EventHandler(this.ChangeUserToolStripMenuItem1_Click);
            // 
            // RemoveUserToolStripMenuItem1
            // 
            this.RemoveUserToolStripMenuItem1.Name = "RemoveUserToolStripMenuItem1";
            this.RemoveUserToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.RemoveUserToolStripMenuItem1.Text = "Remover";
            this.RemoveUserToolStripMenuItem1.Click += new System.EventHandler(this.RemoveUserToolStripMenuItem1_Click);
            // 
            // VehicleToolStripMenuItem
            // 
            this.VehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddVehicleToolStripItem,
            this.ConsultVehicleToolStripItem,
            this.ChangeVehicleToolStripItem,
            this.RemoveVehicleToolStripItem});
            this.VehicleToolStripMenuItem.Name = "VehicleToolStripMenuItem";
            this.VehicleToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.VehicleToolStripMenuItem.Text = "&Veículo";
            // 
            // AddVehicleToolStripItem
            // 
            this.AddVehicleToolStripItem.Name = "AddVehicleToolStripItem";
            this.AddVehicleToolStripItem.Size = new System.Drawing.Size(125, 22);
            this.AddVehicleToolStripItem.Text = "Adcionar";
            this.AddVehicleToolStripItem.Click += new System.EventHandler(this.AddVehicleToolStripItem_Click);
            // 
            // ConsultVehicleToolStripItem
            // 
            this.ConsultVehicleToolStripItem.Name = "ConsultVehicleToolStripItem";
            this.ConsultVehicleToolStripItem.Size = new System.Drawing.Size(125, 22);
            this.ConsultVehicleToolStripItem.Text = "Consultar";
            this.ConsultVehicleToolStripItem.Click += new System.EventHandler(this.ConsultVehicleToolStripItem_Click);
            // 
            // ChangeVehicleToolStripItem
            // 
            this.ChangeVehicleToolStripItem.Name = "ChangeVehicleToolStripItem";
            this.ChangeVehicleToolStripItem.Size = new System.Drawing.Size(125, 22);
            this.ChangeVehicleToolStripItem.Text = "Alterar";
            this.ChangeVehicleToolStripItem.Click += new System.EventHandler(this.ChangeVehicleToolStripItem_Click);
            // 
            // RemoveVehicleToolStripItem
            // 
            this.RemoveVehicleToolStripItem.Name = "RemoveVehicleToolStripItem";
            this.RemoveVehicleToolStripItem.Size = new System.Drawing.Size(125, 22);
            this.RemoveVehicleToolStripItem.Text = "Remover";
            this.RemoveVehicleToolStripItem.Click += new System.EventHandler(this.RemoveVehicleToolStripItem_Click);
            // 
            // OperatorTaxToolStripMenuItem
            // 
            this.OperatorTaxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OperatorConsultTaxToolStripMenuItem});
            this.OperatorTaxToolStripMenuItem.Name = "OperatorTaxToolStripMenuItem";
            this.OperatorTaxToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.OperatorTaxToolStripMenuItem.Text = "&Taxa";
            // 
            // OperatorConsultTaxToolStripMenuItem
            // 
            this.OperatorConsultTaxToolStripMenuItem.Name = "OperatorConsultTaxToolStripMenuItem";
            this.OperatorConsultTaxToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.OperatorConsultTaxToolStripMenuItem.Text = "Consultar";
            this.OperatorConsultTaxToolStripMenuItem.Click += new System.EventHandler(this.OperatorConsultTaxToolStripMenuItem_Click);
            // 
            // AdmTaxToolStripMenuItem
            // 
            this.AdmTaxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdministratorAddTaxToolStripMenuItem,
            this.AdministratorConsultTaxToolStripMenuItem,
            this.AdministratorChangeTaxToolStripMenuItem,
            this.AdministratorRemoveTaxToolStripMenuItem});
            this.AdmTaxToolStripMenuItem.Name = "AdmTaxToolStripMenuItem";
            this.AdmTaxToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.AdmTaxToolStripMenuItem.Text = "&Taxa";
            // 
            // AdministratorAddTaxToolStripMenuItem
            // 
            this.AdministratorAddTaxToolStripMenuItem.Name = "AdministratorAddTaxToolStripMenuItem";
            this.AdministratorAddTaxToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.AdministratorAddTaxToolStripMenuItem.Text = "Adicionar";
            this.AdministratorAddTaxToolStripMenuItem.Click += new System.EventHandler(this.AdministratorAddTaxToolStripMenuItem_Click);
            // 
            // AdministratorConsultTaxToolStripMenuItem
            // 
            this.AdministratorConsultTaxToolStripMenuItem.Name = "AdministratorConsultTaxToolStripMenuItem";
            this.AdministratorConsultTaxToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.AdministratorConsultTaxToolStripMenuItem.Text = "Consultar";
            this.AdministratorConsultTaxToolStripMenuItem.Click += new System.EventHandler(this.AdministratorConsultTaxToolStripMenuItem_Click);
            // 
            // AdministratorChangeTaxToolStripMenuItem
            // 
            this.AdministratorChangeTaxToolStripMenuItem.Name = "AdministratorChangeTaxToolStripMenuItem";
            this.AdministratorChangeTaxToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.AdministratorChangeTaxToolStripMenuItem.Text = "Alterar";
            this.AdministratorChangeTaxToolStripMenuItem.Click += new System.EventHandler(this.AdministratorChangeTaxToolStripMenuItem_Click);
            // 
            // AdministratorRemoveTaxToolStripMenuItem
            // 
            this.AdministratorRemoveTaxToolStripMenuItem.Name = "AdministratorRemoveTaxToolStripMenuItem";
            this.AdministratorRemoveTaxToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.AdministratorRemoveTaxToolStripMenuItem.Text = "Remover";
            this.AdministratorRemoveTaxToolStripMenuItem.Click += new System.EventHandler(this.AdministratorRemoveTaxToolStripMenuItem_Click);
            // 
            // OperatorStripMenuItem
            // 
            this.OperatorStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SairToolStripMenuItem});
            this.OperatorStripMenuItem.Name = "OperatorStripMenuItem";
            this.OperatorStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.OperatorStripMenuItem.Text = "Operador";
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // PanelPayment
            // 
            this.PanelPayment.BackColor = System.Drawing.SystemColors.Control;
            this.PanelPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelPayment.Controls.Add(this.label2);
            this.PanelPayment.Controls.Add(this.label1);
            this.PanelPayment.Controls.Add(this.BtnGenerateExit);
            this.PanelPayment.Controls.Add(this.ClientTextBoxKey);
            this.PanelPayment.Controls.Add(this.LabelResult);
            this.PanelPayment.Controls.Add(this.button1);
            this.PanelPayment.Controls.Add(this.BtnGenerateEntry);
            this.PanelPayment.Controls.Add(this.VehicleClientResultListBox);
            this.PanelPayment.Location = new System.Drawing.Point(261, 58);
            this.PanelPayment.Name = "PanelPayment";
            this.PanelPayment.Size = new System.Drawing.Size(279, 336);
            this.PanelPayment.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPF";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(38, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 69);
            this.label1.TabIndex = 6;
            // 
            // BtnGenerateExit
            // 
            this.BtnGenerateExit.Enabled = false;
            this.BtnGenerateExit.Location = new System.Drawing.Point(38, 188);
            this.BtnGenerateExit.Name = "BtnGenerateExit";
            this.BtnGenerateExit.Size = new System.Drawing.Size(197, 23);
            this.BtnGenerateExit.TabIndex = 5;
            this.BtnGenerateExit.Text = "Gerar Saída";
            this.BtnGenerateExit.UseVisualStyleBackColor = true;
            // 
            // ClientTextBoxKey
            // 
            this.ClientTextBoxKey.Culture = new System.Globalization.CultureInfo("en-US");
            this.ClientTextBoxKey.Location = new System.Drawing.Point(38, 34);
            this.ClientTextBoxKey.Mask = "000.000.000-00";
            this.ClientTextBoxKey.Name = "ClientTextBoxKey";
            this.ClientTextBoxKey.Size = new System.Drawing.Size(197, 20);
            this.ClientTextBoxKey.TabIndex = 1;
            // 
            // LabelResult
            // 
            this.LabelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelResult.Location = new System.Drawing.Point(38, 217);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(197, 19);
            this.LabelResult.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Localizar Veículos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnGenerateEntry
            // 
            this.BtnGenerateEntry.Location = new System.Drawing.Point(38, 160);
            this.BtnGenerateEntry.Name = "BtnGenerateEntry";
            this.BtnGenerateEntry.Size = new System.Drawing.Size(197, 23);
            this.BtnGenerateEntry.TabIndex = 3;
            this.BtnGenerateEntry.Text = "Gerar Entrada";
            this.BtnGenerateEntry.UseVisualStyleBackColor = true;
            // 
            // VehicleClientResultListBox
            // 
            this.VehicleClientResultListBox.FormattingEnabled = true;
            this.VehicleClientResultListBox.Location = new System.Drawing.Point(38, 85);
            this.VehicleClientResultListBox.Name = "VehicleClientResultListBox";
            this.VehicleClientResultListBox.Size = new System.Drawing.Size(197, 69);
            this.VehicleClientResultListBox.TabIndex = 1;
            // 
            // FormLoggedMainPanel
            // 
            this.FormLoggedMainPanel.Controls.Add(this.PanelPayment);
            this.FormLoggedMainPanel.Location = new System.Drawing.Point(0, 27);
            this.FormLoggedMainPanel.Name = "FormLoggedMainPanel";
            this.FormLoggedMainPanel.Size = new System.Drawing.Size(800, 421);
            this.FormLoggedMainPanel.TabIndex = 9;
            // 
            // FormLogged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HideluzMenuStrip);
            this.Controls.Add(this.FormLoggedMainPanel);
            this.MainMenuStrip = this.HideluzMenuStrip;
            this.Name = "FormLogged";
            this.Text = "Hideluz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogged_FormClosing);
            this.HideluzMenuStrip.ResumeLayout(false);
            this.HideluzMenuStrip.PerformLayout();
            this.PanelPayment.ResumeLayout(false);
            this.PanelPayment.PerformLayout();
            this.FormLoggedMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip HideluzMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddClientToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultClientToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeClientToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveClientToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem VehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddVehicleToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultVehicleToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeVehicleToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveVehicleToolStripItem;
        private System.Windows.Forms.Panel PanelPayment;
        private System.Windows.Forms.MaskedTextBox ClientTextBoxKey;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnGenerateEntry;
        private System.Windows.Forms.ListBox VehicleClientResultListBox;
        private System.Windows.Forms.ToolStripMenuItem OperatorTaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperatorConsultTaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperatorStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.Panel FormLoggedMainPanel;
        private System.Windows.Forms.ToolStripMenuItem AdmTaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministratorAddTaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministratorConsultTaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministratorChangeTaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministratorRemoveTaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ConsultUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ChangeUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RemoveUserToolStripMenuItem1;
        private System.Windows.Forms.Button BtnGenerateExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}