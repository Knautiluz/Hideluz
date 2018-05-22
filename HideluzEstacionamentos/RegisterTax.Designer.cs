namespace HideluzEstacionamentos
{
    partial class RegisterTax
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
            this.SignupBtn = new System.Windows.Forms.Button();
            this.TaxListBox = new System.Windows.Forms.ListBox();
            this.RegisterClientPanel = new System.Windows.Forms.Panel();
            this.TaxPriceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignupBtn
            // 
            this.SignupBtn.Location = new System.Drawing.Point(67, 79);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(100, 23);
            this.SignupBtn.TabIndex = 3;
            this.SignupBtn.Text = "Cadastrar";
            this.SignupBtn.UseVisualStyleBackColor = true;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // TaxListBox
            // 
            this.TaxListBox.FormattingEnabled = true;
            this.TaxListBox.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.TaxListBox.Location = new System.Drawing.Point(67, 3);
            this.TaxListBox.Name = "TaxListBox";
            this.TaxListBox.Size = new System.Drawing.Size(100, 30);
            this.TaxListBox.TabIndex = 1;
            // 
            // RegisterClientPanel
            // 
            this.RegisterClientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterClientPanel.Controls.Add(this.label1);
            this.RegisterClientPanel.Controls.Add(this.TaxPriceMaskedTextBox);
            this.RegisterClientPanel.Controls.Add(this.TaxListBox);
            this.RegisterClientPanel.Controls.Add(this.SignupBtn);
            this.RegisterClientPanel.Location = new System.Drawing.Point(278, 61);
            this.RegisterClientPanel.Name = "RegisterClientPanel";
            this.RegisterClientPanel.Size = new System.Drawing.Size(232, 108);
            this.RegisterClientPanel.TabIndex = 1;
            // 
            // TaxPriceMaskedTextBox
            // 
            this.TaxPriceMaskedTextBox.Location = new System.Drawing.Point(67, 53);
            this.TaxPriceMaskedTextBox.Mask = "000,00";
            this.TaxPriceMaskedTextBox.Name = "TaxPriceMaskedTextBox";
            this.TaxPriceMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.TaxPriceMaskedTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Preço da Tarifa";
            // 
            // RegisterTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.RegisterClientPanel);
            this.Name = "RegisterTax";
            this.Text = "RegisterTax";
            this.RegisterClientPanel.ResumeLayout(false);
            this.RegisterClientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SignupBtn;
        private System.Windows.Forms.ListBox TaxListBox;
        private System.Windows.Forms.Panel RegisterClientPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TaxPriceMaskedTextBox;
    }
}