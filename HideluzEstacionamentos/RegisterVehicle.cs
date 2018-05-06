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
    public partial class RegisterVehicle : Form
    {
        Vehicle Vehicle = new Vehicle();

        public RegisterVehicle()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if(VehiclePlateTextBox.Text == "" || VehicleModelTextBox.Text == "" || VehicleTypeTextBox.Text == "" || VehicleDocumentTextBox.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para completar o cadastro.", "Existem campos obrigatórios vazios.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Vehicle.LicencePlate = VehiclePlateTextBox.Text;
            Vehicle.Model = VehicleModelTextBox.Text;
            Vehicle.Type = VehicleTypeTextBox.Text;
            Vehicle.OwnerDocument = VehicleDocumentTextBox.Text;
            FormLogged.Operator.AddVehicle(Vehicle, FormLogged.Operator.EmployeeRegistry);
        }
    }
}
