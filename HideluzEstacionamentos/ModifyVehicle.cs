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
    public partial class ModifyVehicle : Form
    {
        Vehicle Vehicle = new Vehicle();
        public ModifyVehicle()
        {
            InitializeComponent();
        }
        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Vehicle.LicencePlate = VehiclePlateTextBox.Text;
            Vehicle.Model = VehicleModelTextBox.Text;
            Vehicle.Type = VehicleTypeTextBox.Text;
            Vehicle.OwnerDocument = VehicleDocumentTextBox.Text;
            FormLogged.Operator.ModifyVehicle(Vehicle, FormLogged.Operator.EmployeeRegistry);
        }
    }
}
