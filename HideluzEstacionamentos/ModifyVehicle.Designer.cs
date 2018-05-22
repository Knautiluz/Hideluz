namespace HideluzEstacionamentos
{
    partial class ModifyVehicle
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
            this.VehicleModelTextBox = new System.Windows.Forms.TextBox();
            this.PlateLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.DocumentLabel = new System.Windows.Forms.Label();
            this.VehiclePlateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.VehicleDocumentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.VehicleStatusListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VehicleChangeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.VehicleTypeListBox = new System.Windows.Forms.ListBox();
            this.VehiclePanel = new System.Windows.Forms.Panel();
            this.VehicleSearchPlateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VehicleSearchBtn = new System.Windows.Forms.Button();
            this.VehiclePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleModelTextBox
            // 
            this.VehicleModelTextBox.Location = new System.Drawing.Point(66, 99);
            this.VehicleModelTextBox.Name = "VehicleModelTextBox";
            this.VehicleModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehicleModelTextBox.TabIndex = 5;
            // 
            // PlateLabel
            // 
            this.PlateLabel.Location = new System.Drawing.Point(66, 44);
            this.PlateLabel.Name = "PlateLabel";
            this.PlateLabel.Size = new System.Drawing.Size(100, 13);
            this.PlateLabel.TabIndex = 0;
            this.PlateLabel.Text = "Nova Placa";
            this.PlateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Location = new System.Drawing.Point(66, 83);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(100, 13);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Novo Modelo";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DocumentLabel
            // 
            this.DocumentLabel.Location = new System.Drawing.Point(66, 5);
            this.DocumentLabel.Name = "DocumentLabel";
            this.DocumentLabel.Size = new System.Drawing.Size(100, 13);
            this.DocumentLabel.TabIndex = 0;
            this.DocumentLabel.Text = "Novo Documento";
            this.DocumentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VehiclePlateTextBox
            // 
            this.VehiclePlateTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.VehiclePlateTextBox.Location = new System.Drawing.Point(66, 60);
            this.VehiclePlateTextBox.Mask = "AAA-0000";
            this.VehiclePlateTextBox.Name = "VehiclePlateTextBox";
            this.VehiclePlateTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehiclePlateTextBox.TabIndex = 4;
            // 
            // VehicleDocumentTextBox
            // 
            this.VehicleDocumentTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.VehicleDocumentTextBox.Location = new System.Drawing.Point(66, 21);
            this.VehicleDocumentTextBox.Mask = "000.000.000-00";
            this.VehicleDocumentTextBox.Name = "VehicleDocumentTextBox";
            this.VehicleDocumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehicleDocumentTextBox.TabIndex = 3;
            // 
            // VehicleStatusListBox
            // 
            this.VehicleStatusListBox.FormattingEnabled = true;
            this.VehicleStatusListBox.Items.AddRange(new object[] {
            "Ativado",
            "Desativado"});
            this.VehicleStatusListBox.Location = new System.Drawing.Point(66, 139);
            this.VehicleStatusListBox.Name = "VehicleStatusListBox";
            this.VehicleStatusListBox.Size = new System.Drawing.Size(100, 30);
            this.VehicleStatusListBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(66, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VehicleChangeBtn
            // 
            this.VehicleChangeBtn.Location = new System.Drawing.Point(66, 224);
            this.VehicleChangeBtn.Name = "VehicleChangeBtn";
            this.VehicleChangeBtn.Size = new System.Drawing.Size(100, 23);
            this.VehicleChangeBtn.TabIndex = 8;
            this.VehicleChangeBtn.Text = "Alterar";
            this.VehicleChangeBtn.UseVisualStyleBackColor = true;
            this.VehicleChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(66, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Novo Tipo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VehicleTypeListBox
            // 
            this.VehicleTypeListBox.FormattingEnabled = true;
            this.VehicleTypeListBox.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.VehicleTypeListBox.Location = new System.Drawing.Point(66, 188);
            this.VehicleTypeListBox.Name = "VehicleTypeListBox";
            this.VehicleTypeListBox.Size = new System.Drawing.Size(100, 30);
            this.VehicleTypeListBox.TabIndex = 7;
            // 
            // VehiclePanel
            // 
            this.VehiclePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VehiclePanel.Controls.Add(this.VehicleTypeListBox);
            this.VehiclePanel.Controls.Add(this.label2);
            this.VehiclePanel.Controls.Add(this.VehicleChangeBtn);
            this.VehiclePanel.Controls.Add(this.label1);
            this.VehiclePanel.Controls.Add(this.VehicleStatusListBox);
            this.VehiclePanel.Controls.Add(this.VehicleDocumentTextBox);
            this.VehiclePanel.Controls.Add(this.VehiclePlateTextBox);
            this.VehiclePanel.Controls.Add(this.DocumentLabel);
            this.VehiclePanel.Controls.Add(this.ModelLabel);
            this.VehiclePanel.Controls.Add(this.PlateLabel);
            this.VehiclePanel.Controls.Add(this.VehicleModelTextBox);
            this.VehiclePanel.Enabled = false;
            this.VehiclePanel.Location = new System.Drawing.Point(277, 124);
            this.VehiclePanel.Name = "VehiclePanel";
            this.VehiclePanel.Size = new System.Drawing.Size(232, 255);
            this.VehiclePanel.TabIndex = 5;
            // 
            // VehicleSearchPlateTextBox
            // 
            this.VehicleSearchPlateTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.VehicleSearchPlateTextBox.Location = new System.Drawing.Point(344, 75);
            this.VehicleSearchPlateTextBox.Mask = "AAA-0000";
            this.VehicleSearchPlateTextBox.Name = "VehicleSearchPlateTextBox";
            this.VehicleSearchPlateTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehicleSearchPlateTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(344, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Placa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VehicleSearchBtn
            // 
            this.VehicleSearchBtn.Location = new System.Drawing.Point(344, 98);
            this.VehicleSearchBtn.Name = "VehicleSearchBtn";
            this.VehicleSearchBtn.Size = new System.Drawing.Size(100, 23);
            this.VehicleSearchBtn.TabIndex = 2;
            this.VehicleSearchBtn.Text = "Procurar";
            this.VehicleSearchBtn.UseVisualStyleBackColor = true;
            this.VehicleSearchBtn.Click += new System.EventHandler(this.VehicleSearchBtn_Click);
            // 
            // ModifyVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VehicleSearchBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VehicleSearchPlateTextBox);
            this.Controls.Add(this.VehiclePanel);
            this.Name = "ModifyVehicle";
            this.Text = "ModifyVehicle";
            this.VehiclePanel.ResumeLayout(false);
            this.VehiclePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VehicleModelTextBox;
        private System.Windows.Forms.Label PlateLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label DocumentLabel;
        private System.Windows.Forms.MaskedTextBox VehiclePlateTextBox;
        private System.Windows.Forms.MaskedTextBox VehicleDocumentTextBox;
        private System.Windows.Forms.ListBox VehicleStatusListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VehicleChangeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox VehicleTypeListBox;
        private System.Windows.Forms.Panel VehiclePanel;
        private System.Windows.Forms.MaskedTextBox VehicleSearchPlateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button VehicleSearchBtn;
    }
}