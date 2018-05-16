namespace HideluzEstacionamentos
{
    partial class RemoveUser
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
            this.UserDocumentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserDeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserDocumentTextBox
            // 
            this.UserDocumentTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.UserDocumentTextBox.Location = new System.Drawing.Point(68, 83);
            this.UserDocumentTextBox.Mask = "000.000.000-00";
            this.UserDocumentTextBox.Name = "UserDocumentTextBox";
            this.UserDocumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserDocumentTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(68, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserDeleteBtn
            // 
            this.UserDeleteBtn.Location = new System.Drawing.Point(68, 109);
            this.UserDeleteBtn.Name = "UserDeleteBtn";
            this.UserDeleteBtn.Size = new System.Drawing.Size(100, 23);
            this.UserDeleteBtn.TabIndex = 2;
            this.UserDeleteBtn.Text = "Deletar Usuário";
            this.UserDeleteBtn.UseVisualStyleBackColor = true;
            this.UserDeleteBtn.Click += new System.EventHandler(this.UserDeleteBtn_Click);
            // 
            // RemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 192);
            this.Controls.Add(this.UserDeleteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserDocumentTextBox);
            this.Name = "RemoveUser";
            this.Text = "DeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox UserDocumentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserDeleteBtn;
    }
}