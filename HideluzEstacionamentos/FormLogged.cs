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
    public partial class FormLogged : Form
    {
        public FormLogged()
        {
            InitializeComponent();
        }
        private void AddVehicleToolStripItem_Click(object sender, EventArgs e)
        {
            RegisterVehicle registerVehicle = new RegisterVehicle();
            registerVehicle.Show();
        }

        private void AddClientToolStripItem_Click(object sender, EventArgs e)
        {
            RegisterClient registerClient = new RegisterClient();
            registerClient.Show();
        }
    }
}
