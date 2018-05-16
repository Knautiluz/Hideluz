namespace HideluzEstacionamentos
{
    partial class SearchVehicle
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
            this.VehicleSearchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.VehicleSearchPlateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.VehiclePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VehicleDocumentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DocumentLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.VehicleModelTextBox = new System.Windows.Forms.TextBox();
            this.VehicleStatusTextBox = new System.Windows.Forms.TextBox();
            this.VehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.VehiclePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleSearchBtn
            // 
            this.VehicleSearchBtn.Location = new System.Drawing.Point(351, 97);
            this.VehicleSearchBtn.Name = "VehicleSearchBtn";
            this.VehicleSearchBtn.Size = new System.Drawing.Size(100, 23);
            this.VehicleSearchBtn.TabIndex = 2;
            this.VehicleSearchBtn.Text = "Procurar";
            this.VehicleSearchBtn.UseVisualStyleBackColor = true;
            this.VehicleSearchBtn.Click += new System.EventHandler(this.VehicleSearchBtn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(348, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Placa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VehicleSearchPlateTextBox
            // 
            this.VehicleSearchPlateTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.VehicleSearchPlateTextBox.Location = new System.Drawing.Point(351, 71);
            this.VehicleSearchPlateTextBox.Mask = "AAA-0000";
            this.VehicleSearchPlateTextBox.Name = "VehicleSearchPlateTextBox";
            this.VehicleSearchPlateTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehicleSearchPlateTextBox.TabIndex = 1;
            // 
            // VehiclePanel
            // 
            this.VehiclePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VehiclePanel.Controls.Add(this.VehicleTypeTextBox);
            this.VehiclePanel.Controls.Add(this.VehicleStatusTextBox);
            this.VehiclePanel.Controls.Add(this.label2);
            this.VehiclePanel.Controls.Add(this.label1);
            this.VehiclePanel.Controls.Add(this.VehicleDocumentTextBox);
            this.VehiclePanel.Controls.Add(this.DocumentLabel);
            this.VehiclePanel.Controls.Add(this.ModelLabel);
            this.VehiclePanel.Controls.Add(this.VehicleModelTextBox);
            this.VehiclePanel.Location = new System.Drawing.Point(284, 126);
            this.VehiclePanel.Name = "VehiclePanel";
            this.VehiclePanel.Size = new System.Drawing.Size(232, 166);
            this.VehiclePanel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(66, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(66, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // DocumentLabel
            // 
            this.DocumentLabel.Location = new System.Drawing.Point(69, 5);
            this.DocumentLabel.Name = "DocumentLabel";
            this.DocumentLabel.Size = new System.Drawing.Size(94, 13);
            this.DocumentLabel.TabIndex = 0;
            this.DocumentLabel.Text = "Documento";
            this.DocumentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Location = new System.Drawing.Point(66, 44);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(100, 13);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Modelo";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VehicleModelTextBox
            // 
            this.VehicleModelTextBox.Location = new System.Drawing.Point(66, 60);
            this.VehicleModelTextBox.Name = "VehicleModelTextBox";
            this.VehicleModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehicleModelTextBox.TabIndex = 4;
            // 
            // VehicleStatusTextBox
            // 
            this.VehicleStatusTextBox.Location = new System.Drawing.Point(66, 97);
            this.VehicleStatusTextBox.Name = "VehicleStatusTextBox";
            this.VehicleStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehicleStatusTextBox.TabIndex = 5;
            // 
            // VehicleTypeTextBox
            // 
            this.VehicleTypeTextBox.Location = new System.Drawing.Point(66, 136);
            this.VehicleTypeTextBox.Name = "VehicleTypeTextBox";
            this.VehicleTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehicleTypeTextBox.TabIndex = 6;
            // 
            // SearchVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VehicleSearchBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VehiclePanel);
            this.Controls.Add(this.VehicleSearchPlateTextBox);
            this.Name = "SearchVehicle";
            this.Text = "SearchVehicle";
            this.VehiclePanel.ResumeLayout(false);
            this.VehiclePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VehicleSearchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox VehicleSearchPlateTextBox;
        private System.Windows.Forms.Panel VehiclePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox VehicleDocumentTextBox;
        private System.Windows.Forms.Label DocumentLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox VehicleModelTextBox;
        private System.Windows.Forms.TextBox VehicleTypeTextBox;
        private System.Windows.Forms.TextBox VehicleStatusTextBox;
    }
}