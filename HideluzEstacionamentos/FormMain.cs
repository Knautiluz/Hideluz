﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormMain : Form
    {
        //atributos de inicialização.
        Login Login = new Login();

        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Splash Splash = new Splash();
            Splash.Show();
            if(Login.Verify(TextBoxUser.Text, TextBoxPass.Text))
            {
                Splash.Hide();
                MessageBox.Show("Usuário aceito.");
                FormLogged formLogged = new FormLogged();
                formLogged.Show();
            }
        }
    }
}
