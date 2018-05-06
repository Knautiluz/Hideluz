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
            this.VehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddVehicleToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultVehicleToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeVehicleToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveVehicleToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperatorStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelPayment = new System.Windows.Forms.Panel();
            this.ClientTextBoxKey = new System.Windows.Forms.MaskedTextBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGenerateValue = new System.Windows.Forms.Button();
            this.ClientResultListBox = new System.Windows.Forms.ListBox();
            this.HideluzMenuStrip.SuspendLayout();
            this.PanelPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // HideluzMenuStrip
            // 
            this.HideluzMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientToolStripMenuItem,
            this.VehicleToolStripMenuItem,
            this.taxaToolStripMenuItem,
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
            // 
            // ChangeClientToolStripItem
            // 
            this.ChangeClientToolStripItem.Name = "ChangeClientToolStripItem";
            this.ChangeClientToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.ChangeClientToolStripItem.Text = "Alterar";
            this.ChangeClientToolStripItem.Click += new System.EventHandler(this.ChangeClientToolStripItem_Click);
            // 
            // RemoveClientToolStripItem
            // 
            this.RemoveClientToolStripItem.Name = "RemoveClientToolStripItem";
            this.RemoveClientToolStripItem.Size = new System.Drawing.Size(125, 22);
            this.RemoveClientToolStripItem.Text = "Remover";
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
            // 
            // ChangeVehicleToolStripItem
            // 
            this.ChangeVehicleToolStripItem.Name = "ChangeVehicleToolStripItem";
            this.ChangeVehicleToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.ChangeVehicleToolStripItem.Text = "Alterar";
            this.ChangeVehicleToolStripItem.Click += new System.EventHandler(this.ChangeVehicleToolStripItem_Click);
            // 
            // RemoveVehicleToolStripItem
            // 
            this.RemoveVehicleToolStripItem.Name = "RemoveVehicleToolStripItem";
            this.RemoveVehicleToolStripItem.Size = new System.Drawing.Size(125, 22);
            this.RemoveVehicleToolStripItem.Text = "Remover";
            // 
            // taxaToolStripMenuItem
            // 
            this.taxaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.alterarToolStripMenuItem});
            this.taxaToolStripMenuItem.Name = "taxaToolStripMenuItem";
            this.taxaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.taxaToolStripMenuItem.Text = "&Taxa";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
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
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // PanelPayment
            // 
            this.PanelPayment.BackColor = System.Drawing.SystemColors.Control;
            this.PanelPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelPayment.Controls.Add(this.ClientTextBoxKey);
            this.PanelPayment.Controls.Add(this.LabelResult);
            this.PanelPayment.Controls.Add(this.button1);
            this.PanelPayment.Controls.Add(this.BtnGenerateValue);
            this.PanelPayment.Controls.Add(this.ClientResultListBox);
            this.PanelPayment.Location = new System.Drawing.Point(266, 104);
            this.PanelPayment.Name = "PanelPayment";
            this.PanelPayment.Size = new System.Drawing.Size(279, 243);
            this.PanelPayment.TabIndex = 7;
            // 
            // ClientTextBoxKey
            // 
            this.ClientTextBoxKey.Culture = new System.Globalization.CultureInfo("en-US");
            this.ClientTextBoxKey.Location = new System.Drawing.Point(39, 11);
            this.ClientTextBoxKey.Mask = "000.000.000-00";
            this.ClientTextBoxKey.Name = "ClientTextBoxKey";
            this.ClientTextBoxKey.Size = new System.Drawing.Size(197, 20);
            this.ClientTextBoxKey.TabIndex = 1;
            // 
            // LabelResult
            // 
            this.LabelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelResult.Location = new System.Drawing.Point(39, 163);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(197, 23);
            this.LabelResult.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Localizar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnGenerateValue
            // 
            this.BtnGenerateValue.Location = new System.Drawing.Point(39, 137);
            this.BtnGenerateValue.Name = "BtnGenerateValue";
            this.BtnGenerateValue.Size = new System.Drawing.Size(197, 23);
            this.BtnGenerateValue.TabIndex = 3;
            this.BtnGenerateValue.Text = "Gerar Valor";
            this.BtnGenerateValue.UseVisualStyleBackColor = true;
            // 
            // ClientResultListBox
            // 
            this.ClientResultListBox.FormattingEnabled = true;
            this.ClientResultListBox.Location = new System.Drawing.Point(39, 62);
            this.ClientResultListBox.Name = "ClientResultListBox";
            this.ClientResultListBox.Size = new System.Drawing.Size(197, 69);
            this.ClientResultListBox.TabIndex = 1;
            // 
            // FormLogged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelPayment);
            this.Controls.Add(this.HideluzMenuStrip);
            this.MainMenuStrip = this.HideluzMenuStrip;
            this.Name = "FormLogged";
            this.Text = "Hideluz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogged_FormClosing);
            this.HideluzMenuStrip.ResumeLayout(false);
            this.HideluzMenuStrip.PerformLayout();
            this.PanelPayment.ResumeLayout(false);
            this.PanelPayment.PerformLayout();
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
        private System.Windows.Forms.Button BtnGenerateValue;
        private System.Windows.Forms.ListBox ClientResultListBox;
        private System.Windows.Forms.ToolStripMenuItem taxaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperatorStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
    }
}