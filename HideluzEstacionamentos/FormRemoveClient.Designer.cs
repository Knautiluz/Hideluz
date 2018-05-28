namespace HideluzEstacionamentos
{
    partial class FormRemoveClient
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
            this.ClientDeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientDocumentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ClientDeleteBtn
            // 
            this.ClientDeleteBtn.Location = new System.Drawing.Point(79, 91);
            this.ClientDeleteBtn.Name = "ClientDeleteBtn";
            this.ClientDeleteBtn.Size = new System.Drawing.Size(100, 23);
            this.ClientDeleteBtn.TabIndex = 5;
            this.ClientDeleteBtn.Text = "Deletar Cliente";
            this.ClientDeleteBtn.UseVisualStyleBackColor = true;
            this.ClientDeleteBtn.Click += new System.EventHandler(this.ClientDeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(79, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientDocumentTextBox
            // 
            this.ClientDocumentTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.ClientDocumentTextBox.Location = new System.Drawing.Point(79, 65);
            this.ClientDocumentTextBox.Mask = "000.000.000-00";
            this.ClientDocumentTextBox.Name = "ClientDocumentTextBox";
            this.ClientDocumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientDocumentTextBox.TabIndex = 3;
            // 
            // RemoveClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 163);
            this.Controls.Add(this.ClientDeleteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientDocumentTextBox);
            this.Name = "RemoveClient";
            this.Text = "RemoveClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientDeleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox ClientDocumentTextBox;
    }
}