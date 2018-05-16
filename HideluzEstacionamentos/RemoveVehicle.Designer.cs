namespace HideluzEstacionamentos
{
    partial class RemoveVehicle
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
            this.VehicleDeleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.VehiclePlateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // VehicleDeleteBtn
            // 
            this.VehicleDeleteBtn.Location = new System.Drawing.Point(352, 235);
            this.VehicleDeleteBtn.Name = "VehicleDeleteBtn";
            this.VehicleDeleteBtn.Size = new System.Drawing.Size(100, 23);
            this.VehicleDeleteBtn.TabIndex = 8;
            this.VehicleDeleteBtn.Text = "Deletar";
            this.VehicleDeleteBtn.UseVisualStyleBackColor = true;
            this.VehicleDeleteBtn.Click += new System.EventHandler(this.VehicleDeleteBtn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(349, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Placa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VehiclePlateTextBox
            // 
            this.VehiclePlateTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            this.VehiclePlateTextBox.Location = new System.Drawing.Point(352, 209);
            this.VehiclePlateTextBox.Mask = "AAA-0000";
            this.VehiclePlateTextBox.Name = "VehiclePlateTextBox";
            this.VehiclePlateTextBox.Size = new System.Drawing.Size(100, 20);
            this.VehiclePlateTextBox.TabIndex = 7;
            // 
            // RemoveVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VehicleDeleteBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VehiclePlateTextBox);
            this.Name = "RemoveVehicle";
            this.Text = "RemoveVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VehicleDeleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox VehiclePlateTextBox;
    }
}