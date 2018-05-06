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
    public partial class ModifyClient : Form
    {
        Client Client = new Client();
        Address ClientAddress = new Address();
        public ModifyClient()
        {
            InitializeComponent();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Client.Name = ClientNameTextBox.Text;
            Client.Document = ClientDocumentTextBox.Text;
            Client.Email = ClientEmailTextBox.Text;
            Client.Type = ClientListBox.SelectedItem.ToString();
            ClientAddress.State = ClientStateTextBox.Text;
            ClientAddress.City = ClientCityTextBox.Text;
            ClientAddress.Street = ClientStreetTextBox.Text;
            ClientAddress.Number = ClientStreetNumberTextBox.Text;
            ClientAddress.Neighborhood = ClientNeighborhoodTextBox.Text;
            ClientAddress.Cep = ClientCepTextBox.Text;
            Client.Address = ClientAddress;
            // cadastrar cliente no banco.
            FormLogged.Operator.ModifyClient(Client, FormLogged.Operator.EmployeeRegistry);
            ResultLabel.Text = "Cliente alterado.";
        }
    }
}
