namespace HideluzEstacionamentos
{
    partial class FormSearchTax
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
            this.TaxListBox = new System.Windows.Forms.ListBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.TaxPriceLabel = new System.Windows.Forms.Label();
            this.RegisterClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterClientPanel
            // 
            this.RegisterClientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterClientPanel.Controls.Add(this.TaxPriceLabel);
            this.RegisterClientPanel.Controls.Add(this.label1);
            this.RegisterClientPanel.Location = new System.Drawing.Point(284, 171);
            this.RegisterClientPanel.Name = "RegisterClientPanel";
            this.RegisterClientPanel.Size = new System.Drawing.Size(232, 50);
            this.RegisterClientPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(67, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Preço da Tarifa";
            // 
            // TaxListBox
            // 
            this.TaxListBox.FormattingEnabled = true;
            this.TaxListBox.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.TaxListBox.Location = new System.Drawing.Point(352, 106);
            this.TaxListBox.Name = "TaxListBox";
            this.TaxListBox.Size = new System.Drawing.Size(100, 30);
            this.TaxListBox.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(352, 142);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 23);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Consultar";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // TaxPriceLabel
            // 
            this.TaxPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxPriceLabel.Location = new System.Drawing.Point(67, 18);
            this.TaxPriceLabel.Name = "TaxPriceLabel";
            this.TaxPriceLabel.Size = new System.Drawing.Size(100, 23);
            this.TaxPriceLabel.TabIndex = 15;
            this.TaxPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterClientPanel);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.TaxListBox);
            this.Name = "SearchTax";
            this.Text = "SearchTax";
            this.RegisterClientPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegisterClientPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TaxListBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label TaxPriceLabel;
    }
}