namespace HideluzEstacionamentos
{
    partial class FormModifyTax
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
            this.RegisterClientPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TaxPriceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.VehicleTypeListBox = new System.Windows.Forms.ListBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.RegisterClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterClientPanel
            // 
            this.RegisterClientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterClientPanel.Controls.Add(this.label1);
            this.RegisterClientPanel.Controls.Add(this.TaxPriceMaskedTextBox);
            this.RegisterClientPanel.Controls.Add(this.ChangeBtn);
            this.RegisterClientPanel.Location = new System.Drawing.Point(284, 171);
            this.RegisterClientPanel.Name = "RegisterClientPanel";
            this.RegisterClientPanel.Size = new System.Drawing.Size(232, 83);
            this.RegisterClientPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(67, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Preço da Tarifa";
            // 
            // TaxPriceMaskedTextBox
            // 
            this.TaxPriceMaskedTextBox.Location = new System.Drawing.Point(67, 23);
            this.TaxPriceMaskedTextBox.Mask = "000,00";
            this.TaxPriceMaskedTextBox.Name = "TaxPriceMaskedTextBox";
            this.TaxPriceMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.TaxPriceMaskedTextBox.TabIndex = 2;
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(67, 49);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(100, 23);
            this.ChangeBtn.TabIndex = 3;
            this.ChangeBtn.Text = "Alterar";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // VehicleTypeListBox
            // 
            this.VehicleTypeListBox.FormattingEnabled = true;
            this.VehicleTypeListBox.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.VehicleTypeListBox.Location = new System.Drawing.Point(352, 115);
            this.VehicleTypeListBox.Name = "VehicleTypeListBox";
            this.VehicleTypeListBox.Size = new System.Drawing.Size(100, 30);
            this.VehicleTypeListBox.TabIndex = 3;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(352, 146);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 23);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Consultar";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ModifyTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.VehicleTypeListBox);
            this.Controls.Add(this.RegisterClientPanel);
            this.Name = "ModifyTax";
            this.Text = "ModifyTax";
            this.RegisterClientPanel.ResumeLayout(false);
            this.RegisterClientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegisterClientPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TaxPriceMaskedTextBox;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.ListBox VehicleTypeListBox;
        private System.Windows.Forms.Button SearchBtn;
    }
}