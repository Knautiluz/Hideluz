using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormSearchVehicle : Form
    {
        public FormSearchVehicle()
        {
            InitializeComponent();
        }

        private void VehicleSearchBtn_Click(object sender, EventArgs e)
        {
            //pesquisa veículo no banco de dados.
            MessageBox.Show("Você clicou em pesquisar!");
        }
    }
}
