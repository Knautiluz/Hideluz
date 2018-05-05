namespace HideluzEstacionamentos
{
    partial class FormLogged
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
            this.HideluzMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClientToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultClientToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeClientToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveClientToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddVehicleToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultVehicleToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeVehicleToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveVehicleToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideluzMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HideluzMenuStrip
            // 
            this.HideluzMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ClientToolStripMenuItem,
            this.VehicleToolStripMenuItem});
            this.HideluzMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.HideluzMenuStrip.Name = "HideluzMenuStrip";
            this.HideluzMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.HideluzMenuStrip.TabIndex = 6;
            this.HideluzMenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClientToolStripItem,
            this.ConsultClientToolStripItem,
            this.ChangeClientToolStripItem,
            this.RemoveClientToolStripItem});
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ClientToolStripMenuItem.Text = "Cliente";
            // 
            // AddClientToolStripItem
            // 
            this.AddClientToolStripItem.Name = "AddClientToolStripItem";
            this.AddClientToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.AddClientToolStripItem.Text = "Adicionar";
            this.AddClientToolStripItem.Click += new System.EventHandler(this.AddClientToolStripItem_Click);
            // 
            // ConsultClientToolStripItem
            // 
            this.ConsultClientToolStripItem.Name = "ConsultClientToolStripItem";
            this.ConsultClientToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.ConsultClientToolStripItem.Text = "Consultar";
            // 
            // ChangeClientToolStripItem
            // 
            this.ChangeClientToolStripItem.Name = "ChangeClientToolStripItem";
            this.ChangeClientToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.ChangeClientToolStripItem.Text = "Alterar";
            // 
            // RemoveClientToolStripItem
            // 
            this.RemoveClientToolStripItem.Name = "RemoveClientToolStripItem";
            this.RemoveClientToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.RemoveClientToolStripItem.Text = "Remover";
            // 
            // VehicleToolStripMenuItem
            // 
            this.VehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddVehicleToolStripItem,
            this.ConsultVehicleToolStripItem,
            this.ChangeVehicleToolStripItem,
            this.RemoveVehicleToolStripItem});
            this.VehicleToolStripMenuItem.Name = "VehicleToolStripMenuItem";
            this.VehicleToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.VehicleToolStripMenuItem.Text = "Veículo";
            // 
            // AddVehicleToolStripItem
            // 
            this.AddVehicleToolStripItem.Name = "AddVehicleToolStripItem";
            this.AddVehicleToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.AddVehicleToolStripItem.Text = "Adcionar";
            this.AddVehicleToolStripItem.Click += new System.EventHandler(this.AddVehicleToolStripItem_Click);
            // 
            // ConsultVehicleToolStripItem
            // 
            this.ConsultVehicleToolStripItem.Name = "ConsultVehicleToolStripItem";
            this.ConsultVehicleToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.ConsultVehicleToolStripItem.Text = "Consultar";
            // 
            // ChangeVehicleToolStripItem
            // 
            this.ChangeVehicleToolStripItem.Name = "ChangeVehicleToolStripItem";
            this.ChangeVehicleToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.ChangeVehicleToolStripItem.Text = "Alterar";
            // 
            // RemoveVehicleToolStripItem
            // 
            this.RemoveVehicleToolStripItem.Name = "RemoveVehicleToolStripItem";
            this.RemoveVehicleToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.RemoveVehicleToolStripItem.Text = "Remover";
            // 
            // FormLogged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HideluzMenuStrip);
            this.MainMenuStrip = this.HideluzMenuStrip;
            this.Name = "FormLogged";
            this.Text = "Hideluz";
            this.HideluzMenuStrip.ResumeLayout(false);
            this.HideluzMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip HideluzMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddClientToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultClientToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeClientToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveClientToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem VehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddVehicleToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultVehicleToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeVehicleToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveVehicleToolStripItem;
    }
}