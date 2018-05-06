using System;
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
        public static Operator Operator = new Operator("8080", "Jackson Antunes", "knautiluz@hideluz.com");
        public static RegisterClient registerClient = new RegisterClient();
        public static RegisterVehicle registerVehicle = new RegisterVehicle();
        public static ModifyClient modifyClient = new ModifyClient();
        public static ModifyVehicle modifyVehicle = new ModifyVehicle();

        public FormLogged()
        {
            InitializeComponent();
        }
        private void AddVehicleToolStripItem_Click(object sender, EventArgs e)
        {
            try
            {
                registerVehicle.Show();
            }
            catch (ObjectDisposedException)
            {
                registerVehicle = new RegisterVehicle();
                registerVehicle.Show();
            }
        }

        private void AddClientToolStripItem_Click(object sender, EventArgs e)
        {   
            try
            {
                registerClient.Show();
            }
            catch (ObjectDisposedException)
            {
                registerClient = new RegisterClient();
                registerClient.Show();
            }
        }
        private void ChangeClientToolStripItem_Click(object sender, EventArgs e)
        {
            try
            {
                modifyClient.Show();
            }
            catch (ObjectDisposedException)
            {
                modifyClient = new ModifyClient();
                modifyClient.Show();
            }
        }
        private void ChangeVehicleToolStripItem_Click(object sender, EventArgs e)
        {
            try
            {
                modifyVehicle.Show();
            }
            catch (ObjectDisposedException)
            {
                modifyVehicle = new ModifyVehicle();
                modifyVehicle.Show();
            }
        }

        private void FormLogged_FormClosing(object sender, FormClosingEventArgs e)
        {
            registerClient.Close();
            registerVehicle.Close();
            modifyVehicle.Close();
            modifyClient.Close();
            var form = Application.OpenForms[0];
            form.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerClient.Close();
            registerVehicle.Close();
            modifyVehicle.Close();
            modifyClient.Close();
            var form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
    }
}
