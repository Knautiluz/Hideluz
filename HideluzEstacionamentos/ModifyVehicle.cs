using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class ModifyVehicle : Form
    {
        Vehicle Vehicle = new Vehicle();
        public static string Operation;
        public ModifyVehicle()
        {
            InitializeComponent();
        }
        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Vehicle.LicencePlate = VehiclePlateTextBox.Text;
            Vehicle.Model = VehicleModelTextBox.Text;
            Vehicle.OwnerDocument = VehicleDocumentTextBox.Text;
            Vehicle.Status = VehicleStatusListBox.SelectedIndex + 1;
            Vehicle.Type = VehicleTypeListBox.SelectedIndex + 1;
            if (VehicleStatusListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o novo status do veículo.");
                return;
            }
            if (VehicleTypeListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o novo tipo do veículo.");
                return;
            }
            if (FormLogged.Operator.ChangeVehicle(Vehicle, VehicleSearchPlateTextBox.Text))
            {
                MessageBox.Show(Operation);
            }
            else
            {
                MessageBox.Show(Operation);
            }
        }

        private void VehicleSearchBtn_Click(object sender, EventArgs e)
        {
            var list = FormLogged.Operator.SearchVehicle(VehicleSearchPlateTextBox.Text);
            if (list.Count == 0)
            {
                MessageBox.Show("Esse usuário não existe.");
                VehiclePanel.Enabled = false;
                return;
            }
            VehiclePanel.Enabled = true;
            VehiclePlateTextBox.Text = list["PLACA"];
            VehicleModelTextBox.Text = list["MODELO"];
            VehicleDocumentTextBox.Text = list["CLIENTE_CPF"];
        }
    }
}
