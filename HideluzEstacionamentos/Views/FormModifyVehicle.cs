using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormModifyVehicle : Form
    {
        public FormModifyVehicle()
        {
            InitializeComponent();
        }
        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            //intancia novo veículo com dados recebidos do form e envia para a classe operador alterar os dados no banco.
            MessageBox.Show("Você clicou em alterar!");
        }

        private void VehicleSearchBtn_Click(object sender, EventArgs e)
        {
            //intancia novo veículo com dados recebidos do form e envia para a classe operador pesquisar os dados no banco.
            MessageBox.Show("Você clicou em pesquisar!");
        }
    }
}
