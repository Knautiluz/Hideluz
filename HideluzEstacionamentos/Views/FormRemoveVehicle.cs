using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormRemoveVehicle : Form
    {

        public FormRemoveVehicle()
        {
            InitializeComponent();
        }

        private void VehicleDeleteBtn_Click(object sender, EventArgs e)
        {
            //deleta veículo do banco
            MessageBox.Show("Você clicou em deletar!");
        }
    }
}
