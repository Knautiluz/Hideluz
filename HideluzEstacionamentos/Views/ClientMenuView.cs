﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace HideluzEstacionamentos.Views
{
    public partial class ClientMenuView : UserControl
    {
        public ClientRegisterView ClientControl = new ClientRegisterView();

        public ClientMenuView()
        {
            InitializeComponent();
        }

        private void btn_ClientRegister_Click(object sender, EventArgs e)
        {
            panel_ClientContent.Controls.Add(ClientControl);
            btn_ClientRegister.BackColor = Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(92)))));
            btn_ClientSearch.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btn_ClientDelete.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }
    }
}