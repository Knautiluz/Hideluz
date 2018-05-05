namespace HideluzEstacionamentos
{
    partial class RegisterClient
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
            this.PanelPayment = new System.Windows.Forms.Panel();
            this.ClientTextBoxKey = new System.Windows.Forms.MaskedTextBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGenerateValue = new System.Windows.Forms.Button();
            this.ClientResultListBox = new System.Windows.Forms.ListBox();
            this.PanelPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPayment
            // 
            this.PanelPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelPayment.Controls.Add(this.ClientTextBoxKey);
            this.PanelPayment.Controls.Add(this.LabelResult);
            this.PanelPayment.Controls.Add(this.button1);
            this.PanelPayment.Controls.Add(this.BtnGenerateValue);
            this.PanelPayment.Controls.Add(this.ClientResultListBox);
            this.PanelPayment.Location = new System.Drawing.Point(261, 104);
            this.PanelPayment.Name = "PanelPayment";
            this.PanelPayment.Size = new System.Drawing.Size(279, 243);
            this.PanelPayment.TabIndex = 6;
            // 
            // ClientTextBoxKey
            // 
            this.ClientTextBoxKey.Culture = new System.Globalization.CultureInfo("en-US");
            this.ClientTextBoxKey.Location = new System.Drawing.Point(39, 11);
            this.ClientTextBoxKey.Mask = "000.000.000-00";
            this.ClientTextBoxKey.Name = "ClientTextBoxKey";
            this.ClientTextBoxKey.Size = new System.Drawing.Size(197, 20);
            this.ClientTextBoxKey.TabIndex = 1;
            // 
            // LabelResult
            // 
            this.LabelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelResult.Location = new System.Drawing.Point(39, 163);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(197, 23);
            this.LabelResult.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Localizar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnGenerateValue
            // 
            this.BtnGenerateValue.Location = new System.Drawing.Point(39, 137);
            this.BtnGenerateValue.Name = "BtnGenerateValue";
            this.BtnGenerateValue.Size = new System.Drawing.Size(197, 23);
            this.BtnGenerateValue.TabIndex = 3;
            this.BtnGenerateValue.Text = "Gerar Valor";
            this.BtnGenerateValue.UseVisualStyleBackColor = true;
            // 
            // ClientResultListBox
            // 
            this.ClientResultListBox.FormattingEnabled = true;
            this.ClientResultListBox.Location = new System.Drawing.Point(39, 62);
            this.ClientResultListBox.Name = "ClientResultListBox";
            this.ClientResultListBox.Size = new System.Drawing.Size(197, 69);
            this.ClientResultListBox.TabIndex = 1;
            // 
            // RegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelPayment);
            this.Name = "RegisterClient";
            this.Text = "RegisterClient";
            this.PanelPayment.ResumeLayout(false);
            this.PanelPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPayment;
        private System.Windows.Forms.MaskedTextBox ClientTextBoxKey;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnGenerateValue;
        private System.Windows.Forms.ListBox ClientResultListBox;
    }
}