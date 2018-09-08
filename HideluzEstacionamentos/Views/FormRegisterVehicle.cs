using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormRegisterVehicle : Form
    {
        public FormRegisterVehicle()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            //cadastra novo veículo
            MessageBox.Show("Você clicou em cadastrar!");
        }
    }
}
