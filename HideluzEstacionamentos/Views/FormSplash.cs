﻿using HideluzEstacionamentos.Controllers;
using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormSplash : Form
    {

        InitializerController Controller = new InitializerController();

        public FormSplash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            SplashProgressBar.PerformStep();
        }
    }
}
