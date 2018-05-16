namespace HideluzEstacionamentos
{
    partial class RegisterVehicle
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
            this.VehiclePanel = new System.Windows.Forms.Panel();
            this.VehicleDocumentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.VehicleTypeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VehicleSignupBtn = new System.Windows.Forms.Button();
            this.DocumentLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlateLabel = new System.Windows.Forms.Label();
            this.VehiclePlateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.VehiclePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleModelTextBox
            // 
            this.VehicleModelTextBox.Location = new System.Drawing.Point(66, 116);
            this.VehicleModelTextBox.Name = "VehicleModelTextBox";
            this.VehicleModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehicleModelTextBox.TabIndex = 3;
            // 
            // VehiclePanel
            // 
            this.VehiclePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VehiclePanel.Controls.Add(this.VehiclePlateTextBox);
            this.VehiclePanel.Controls.Add(this.VehicleDocumentTextBox);
            this.VehiclePanel.Controls.Add(this.VehicleTypeListBox);
            this.VehiclePanel.Controls.Add(this.label1);
            this.VehiclePanel.Controls.Add(this.VehicleSignupBtn);
            this.VehiclePanel.Controls.Add(this.DocumentLabel);
            this.VehiclePanel.Controls.Add(this.ModelLabel);
            this.VehiclePanel.Controls.Add(this.PlateLabel);
            this.VehiclePanel.Controls.Add(this.VehicleModelTextBox);
            this.VehiclePanel.Location = new System.Drawing.Point(295, 102);
            this.VehiclePanel.Name = "VehiclePanel";
            this.VehiclePanel.Size = new System.Drawing.Size(232, 231);
            this.VehiclePanel.TabIndex = 4;
            // 
            // VehicleDocumentTextBox
            // 
            this.VehicleDocumentTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.VehicleDocumentTextBox.Location = new System.Drawing.Point(66, 38);
            this.VehicleDocumentTextBox.Mask = "000.000.000-00";
            this.VehicleDocumentTextBox.Name = "VehicleDocumentTextBox";
            this.VehicleDocumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehicleDocumentTextBox.TabIndex = 1;
            // 
            // VehicleTypeListBox
            // 
            this.VehicleTypeListBox.FormattingEnabled = true;
            this.VehicleTypeListBox.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.VehicleTypeListBox.Location = new System.Drawing.Point(66, 154);
            this.VehicleTypeListBox.Name = "VehicleTypeListBox";
            this.VehicleTypeListBox.Size = new System.Drawing.Size(100, 30);
            this.VehicleTypeListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(63, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VehicleSignupBtn
            // 
            this.VehicleSignupBtn.Location = new System.Drawing.Point(66, 191);
            this.VehicleSignupBtn.Name = "VehicleSignupBtn";
            this.VehicleSignupBtn.Size = new System.Drawing.Size(100, 23);
            this.VehicleSignupBtn.TabIndex = 5;
            this.VehicleSignupBtn.Text = "Cadastrar";
            this.VehicleSignupBtn.UseVisualStyleBackColor = true;
            this.VehicleSignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // DocumentLabel
            // 
            this.DocumentLabel.Location = new System.Drawing.Point(63, 22);
            this.DocumentLabel.Name = "DocumentLabel";
            this.DocumentLabel.Size = new System.Drawing.Size(103, 13);
            this.DocumentLabel.TabIndex = 7;
            this.DocumentLabel.Text = "Documento";
            this.DocumentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Location = new System.Drawing.Point(63, 100);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(103, 13);
            this.ModelLabel.TabIndex = 5;
            this.ModelLabel.Text = "Modelo";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlateLabel
            // 
            this.PlateLabel.Location = new System.Drawing.Point(63, 61);
            this.PlateLabel.Name = "PlateLabel";
            this.PlateLabel.Size = new System.Drawing.Size(103, 13);
            this.PlateLabel.TabIndex = 4;
            this.PlateLabel.Text = "Placa";
            this.PlateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VehiclePlateTextBox
            // 
            this.VehiclePlateTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.VehiclePlateTextBox.Location = new System.Drawing.Point(66, 77);
            this.VehiclePlateTextBox.Mask = "AAA-0000";
            this.VehiclePlateTextBox.Name = "VehiclePlateTextBox";
            this.VehiclePlateTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehiclePlateTextBox.TabIndex = 11;
            // 
            // RegisterVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VehiclePanel);
            this.Name = "RegisterVehicle";
            this.Text = "RegisterVehicle";
            this.VehiclePanel.ResumeLayout(false);
            this.VehiclePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox VehicleModelTextBox;
        private System.Windows.Forms.Panel VehiclePanel;
        private System.Windows.Forms.Label PlateLabel;
        private System.Windows.Forms.Label DocumentLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Button VehicleSignupBtn;
        private System.Windows.Forms.ListBox VehicleTypeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox VehicleDocumentTextBox;
        private System.Windows.Forms.MaskedTextBox VehiclePlateTextBox;
    }
}