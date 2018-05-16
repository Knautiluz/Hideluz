using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class RegisterVehicle : Form
    {
        public Vehicle Vehicle = new Vehicle();
        public static string Operation = "";
        public RegisterVehicle()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if(VehiclePlateTextBox.Text == "" || VehicleModelTextBox.Text == "" || VehicleTypeListBox.SelectedIndex == -1 || VehicleDocumentTextBox.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para completar o cadastro.", "Existem campos obrigatórios vazios.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Vehicle.LicencePlate = VehiclePlateTextBox.Text;
            Vehicle.Model = VehicleModelTextBox.Text;
            Vehicle.Type = VehicleTypeListBox.SelectedIndex + 1;
            Vehicle.OwnerDocument = VehicleDocumentTextBox.Text;
            if(FormLogged.Operator.AddVehicle(Vehicle, FormLogged.Operator.EmployeeRegistry))
            {
                MessageBox.Show(Operation);
            }
            else
            {
                MessageBox.Show(Operation);
            }
        }
    }
}
