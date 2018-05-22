namespace HideluzEstacionamentos
{
    partial class RemoveTax
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
            this.TaxDeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VehicleTypeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TaxDeleteBtn
            // 
            this.TaxDeleteBtn.Location = new System.Drawing.Point(345, 231);
            this.TaxDeleteBtn.Name = "TaxDeleteBtn";
            this.TaxDeleteBtn.Size = new System.Drawing.Size(100, 23);
            this.TaxDeleteBtn.TabIndex = 5;
            this.TaxDeleteBtn.Text = "Deletar Taxa";
            this.TaxDeleteBtn.UseVisualStyleBackColor = true;
            this.TaxDeleteBtn.Click += new System.EventHandler(this.TaxDeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(345, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Veículo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleTypeListBox
            // 
            this.VehicleTypeListBox.FormattingEnabled = true;
            this.VehicleTypeListBox.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.VehicleTypeListBox.Location = new System.Drawing.Point(345, 195);
            this.VehicleTypeListBox.Name = "VehicleTypeListBox";
            this.VehicleTypeListBox.Size = new System.Drawing.Size(100, 30);
            this.VehicleTypeListBox.TabIndex = 6;
            // 
            // RemoveTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VehicleTypeListBox);
            this.Controls.Add(this.TaxDeleteBtn);
            this.Controls.Add(this.label1);
            this.Name = "RemoveTax";
            this.Text = "RemoveTax";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TaxDeleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox VehicleTypeListBox;
    }
}