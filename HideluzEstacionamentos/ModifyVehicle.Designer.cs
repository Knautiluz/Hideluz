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
            this.VehiclePanel = new System.Windows.Forms.Panel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DocumentLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlateLabel = new System.Windows.Forms.Label();
            this.VehiclePlateTextBox = new System.Windows.Forms.TextBox();
            this.VehicleDocumentTextBox = new System.Windows.Forms.TextBox();
            this.VehicleModelTextBox = new System.Windows.Forms.TextBox();
            this.VehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.TipLabel = new System.Windows.Forms.Label();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.VehiclePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehiclePanel
            // 
            this.VehiclePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VehiclePanel.Controls.Add(this.ChangeBtn);
            this.VehiclePanel.Controls.Add(this.ResultLabel);
            this.VehiclePanel.Controls.Add(this.DocumentLabel);
            this.VehiclePanel.Controls.Add(this.TypeLabel);
            this.VehiclePanel.Controls.Add(this.ModelLabel);
            this.VehiclePanel.Controls.Add(this.PlateLabel);
            this.VehiclePanel.Controls.Add(this.VehiclePlateTextBox);
            this.VehiclePanel.Controls.Add(this.VehicleDocumentTextBox);
            this.VehiclePanel.Controls.Add(this.VehicleModelTextBox);
            this.VehiclePanel.Controls.Add(this.VehicleTypeTextBox);
            this.VehiclePanel.Location = new System.Drawing.Point(277, 101);
            this.VehiclePanel.Name = "VehiclePanel";
            this.VehiclePanel.Size = new System.Drawing.Size(232, 248);
            this.VehiclePanel.TabIndex = 5;
            // 
            // ResultLabel
            // 
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultLabel.Location = new System.Drawing.Point(66, 198);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(100, 17);
            this.ResultLabel.TabIndex = 9;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DocumentLabel
            // 
            this.DocumentLabel.Location = new System.Drawing.Point(63, 130);
            this.DocumentLabel.Name = "DocumentLabel";
            this.DocumentLabel.Size = new System.Drawing.Size(103, 13);
            this.DocumentLabel.TabIndex = 7;
            this.DocumentLabel.Text = "Documento";
            this.DocumentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Location = new System.Drawing.Point(63, 91);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(103, 13);
            this.TypeLabel.TabIndex = 6;
            this.TypeLabel.Text = "Tipo";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Location = new System.Drawing.Point(63, 52);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(103, 13);
            this.ModelLabel.TabIndex = 5;
            this.ModelLabel.Text = "Modelo";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlateLabel
            // 
            this.PlateLabel.Location = new System.Drawing.Point(63, 13);
            this.PlateLabel.Name = "PlateLabel";
            this.PlateLabel.Size = new System.Drawing.Size(103, 13);
            this.PlateLabel.TabIndex = 4;
            this.PlateLabel.Text = "Placa";
            this.PlateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VehiclePlateTextBox
            // 
            this.VehiclePlateTextBox.Location = new System.Drawing.Point(66, 29);
            this.VehiclePlateTextBox.Name = "VehiclePlateTextBox";
            this.VehiclePlateTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehiclePlateTextBox.TabIndex = 0;
            // 
            // VehicleDocumentTextBox
            // 
            this.VehicleDocumentTextBox.Location = new System.Drawing.Point(66, 146);
            this.VehicleDocumentTextBox.Name = "VehicleDocumentTextBox";
            this.VehicleDocumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehicleDocumentTextBox.TabIndex = 3;
            // 
            // VehicleModelTextBox
            // 
            this.VehicleModelTextBox.Location = new System.Drawing.Point(66, 68);
            this.VehicleModelTextBox.Name = "VehicleModelTextBox";
            this.VehicleModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehicleModelTextBox.TabIndex = 1;
            // 
            // VehicleTypeTextBox
            // 
            this.VehicleTypeTextBox.Location = new System.Drawing.Point(66, 107);
            this.VehicleTypeTextBox.Name = "VehicleTypeTextBox";
            this.VehicleTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehicleTypeTextBox.TabIndex = 2;
            // 
            // TipLabel
            // 
            this.TipLabel.Location = new System.Drawing.Point(274, 85);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(235, 13);
            this.TipLabel.TabIndex = 8;
            this.TipLabel.Text = "Preencha os campos que deseja alterar.";
            this.TipLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(66, 172);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(100, 23);
            this.ChangeBtn.TabIndex = 10;
            this.ChangeBtn.Text = "Alterar";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // ModifyVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.VehiclePanel);
            this.Name = "ModifyVehicle";
            this.Text = "ModifyVehicle";
            this.VehiclePanel.ResumeLayout(false);
            this.VehiclePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel VehiclePanel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label DocumentLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PlateLabel;
        private System.Windows.Forms.TextBox VehiclePlateTextBox;
        private System.Windows.Forms.TextBox VehicleDocumentTextBox;
        private System.Windows.Forms.TextBox VehicleModelTextBox;
        private System.Windows.Forms.TextBox VehicleTypeTextBox;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Button ChangeBtn;
    }
}