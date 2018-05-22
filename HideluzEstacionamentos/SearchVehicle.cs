using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class SearchVehicle : Form
    {
        public static string Operation;

        public SearchVehicle()
        {
            InitializeComponent();
        }

        private void VehicleSearchBtn_Click(object sender, EventArgs e)
        {
            var list = Login.Operator.CheckVehicle(VehicleSearchPlateTextBox.Text);
            if (list.Count == 0)
            {
                MessageBox.Show("Esse usuário não existe.");
                VehiclePanel.Enabled = false;
                return;
            }
            VehiclePanel.Enabled = true;
            VehicleModelTextBox.Text = list["MODELO"];
            VehicleDocumentTextBox.Text = list["CLIENTE_CPF"];
            VehicleStatusTextBox.Text = list["STATUS"];
            VehicleTypeTextBox.Text = list["TIPO"];
        }
    }
}
