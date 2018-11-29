namespace HideluzEstacionamentos.Views
{
    partial class FormLoggerv2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoggerv2));
            this.panel_TopContent = new System.Windows.Forms.Panel();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.panel_TopInfo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_taxes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btn_vehicles = new System.Windows.Forms.Button();
            this.btn_clients = new System.Windows.Forms.Button();
            this.panel_selectedMenu = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_ContentView = new System.Windows.Forms.Panel();
            this.clientView1 = new HideluzEstacionamentos.Views.ClientView();
            this.panel_TopContent.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_ContentView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TopContent
            // 
            this.panel_TopContent.BackColor = System.Drawing.Color.White;
            this.panel_TopContent.Controls.Add(this.panel_Logo);
            this.panel_TopContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TopContent.Location = new System.Drawing.Point(0, 0);
            this.panel_TopContent.Name = "panel_TopContent";
            this.panel_TopContent.Size = new System.Drawing.Size(1043, 59);
            this.panel_TopContent.TabIndex = 0;
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(92)))));
            this.panel_Logo.Controls.Add(this.panel_TopInfo);
            this.panel_Logo.Controls.Add(this.pictureBox1);
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(180, 59);
            this.panel_Logo.TabIndex = 6;
            // 
            // panel_TopInfo
            // 
            this.panel_TopInfo.Location = new System.Drawing.Point(178, 0);
            this.panel_TopInfo.Name = "panel_TopInfo";
            this.panel_TopInfo.Size = new System.Drawing.Size(864, 59);
            this.panel_TopInfo.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 59);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.btn_reports);
            this.panel2.Controls.Add(this.btn_taxes);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btn_vehicles);
            this.panel2.Controls.Add(this.btn_clients);
            this.panel2.Controls.Add(this.panel_selectedMenu);
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 580);
            this.panel2.TabIndex = 0;
            // 
            // btn_reports
            // 
            this.btn_reports.FlatAppearance.BorderSize = 0;
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.Color.White;
            this.btn_reports.Image = ((System.Drawing.Image)(resources.GetObject("btn_reports.Image")));
            this.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.Location = new System.Drawing.Point(7, 274);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(171, 40);
            this.btn_reports.TabIndex = 7;
            this.btn_reports.Text = "       Relatórios";
            this.btn_reports.UseVisualStyleBackColor = true;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_taxes
            // 
            this.btn_taxes.FlatAppearance.BorderSize = 0;
            this.btn_taxes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taxes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taxes.ForeColor = System.Drawing.Color.White;
            this.btn_taxes.Image = ((System.Drawing.Image)(resources.GetObject("btn_taxes.Image")));
            this.btn_taxes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taxes.Location = new System.Drawing.Point(7, 228);
            this.btn_taxes.Name = "btn_taxes";
            this.btn_taxes.Size = new System.Drawing.Size(171, 40);
            this.btn_taxes.TabIndex = 6;
            this.btn_taxes.Text = "       Tarifas";
            this.btn_taxes.UseVisualStyleBackColor = true;
            this.btn_taxes.Click += new System.EventHandler(this.btn_taxes_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(79)))));
            this.panel4.Controls.Add(this.lbl_Username);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.lbl_Welcome);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 79);
            this.panel4.TabIndex = 5;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.White;
            this.lbl_Username.Location = new System.Drawing.Point(66, 38);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(63, 13);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "userName";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Welcome.Location = new System.Drawing.Point(66, 23);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(60, 13);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Bem-vindo,";
            // 
            // btn_vehicles
            // 
            this.btn_vehicles.FlatAppearance.BorderSize = 0;
            this.btn_vehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicles.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vehicles.ForeColor = System.Drawing.Color.White;
            this.btn_vehicles.Image = ((System.Drawing.Image)(resources.GetObject("btn_vehicles.Image")));
            this.btn_vehicles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vehicles.Location = new System.Drawing.Point(7, 182);
            this.btn_vehicles.Name = "btn_vehicles";
            this.btn_vehicles.Size = new System.Drawing.Size(171, 40);
            this.btn_vehicles.TabIndex = 4;
            this.btn_vehicles.Text = "       Veículos";
            this.btn_vehicles.UseVisualStyleBackColor = true;
            this.btn_vehicles.Click += new System.EventHandler(this.btn_vehicles_Click);
            // 
            // btn_clients
            // 
            this.btn_clients.FlatAppearance.BorderSize = 0;
            this.btn_clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clients.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clients.ForeColor = System.Drawing.Color.White;
            this.btn_clients.Image = ((System.Drawing.Image)(resources.GetObject("btn_clients.Image")));
            this.btn_clients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clients.Location = new System.Drawing.Point(7, 136);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(171, 40);
            this.btn_clients.TabIndex = 3;
            this.btn_clients.Text = "       Clientes";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // panel_selectedMenu
            // 
            this.panel_selectedMenu.BackColor = System.Drawing.Color.Crimson;
            this.panel_selectedMenu.Location = new System.Drawing.Point(0, 90);
            this.panel_selectedMenu.Name = "panel_selectedMenu";
            this.panel_selectedMenu.Size = new System.Drawing.Size(5, 40);
            this.panel_selectedMenu.TabIndex = 2;
            // 
            // btn_home
            // 
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(7, 90);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(171, 40);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "       Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_ContentView
            // 
            this.panel_ContentView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel_ContentView.Controls.Add(this.clientView1);
            this.panel_ContentView.Location = new System.Drawing.Point(181, 59);
            this.panel_ContentView.Name = "panel_ContentView";
            this.panel_ContentView.Size = new System.Drawing.Size(860, 580);
            this.panel_ContentView.TabIndex = 1;
            // 
            // clientView1
            // 
            this.clientView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.clientView1.Location = new System.Drawing.Point(0, 0);
            this.clientView1.Name = "clientView1";
            this.clientView1.Size = new System.Drawing.Size(865, 580);
            this.clientView1.TabIndex = 0;
            // 
            // FormLoggerv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 639);
            this.Controls.Add(this.panel_ContentView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_TopContent);
            this.Name = "FormLoggerv2";
            this.Text = "FormLoggerv2";
            this.panel_TopContent.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_ContentView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_TopContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Panel panel_selectedMenu;
        private System.Windows.Forms.Button btn_vehicles;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_taxes;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Panel panel_ContentView;
        private System.Windows.Forms.Panel panel_TopInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Welcome;
        private ClientView clientView1;
    }
}