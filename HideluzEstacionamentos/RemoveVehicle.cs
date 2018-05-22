using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class RemoveVehicle : Form
    {
        public static string Operation = "";
        public RemoveVehicle()
        {
            InitializeComponent();
        }

        private void VehicleDeleteBtn_Click(object sender, EventArgs e)
        {
            if (Login.Operator.DeleteVehicle(VehiclePlateTextBox.Text))
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
