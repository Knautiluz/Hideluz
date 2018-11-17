using HideluzEstacionamentos.Models;
using HideluzEstacionamentos.Controllers;
using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormRegisterClient : Form
    {
        OperatorController Controller = new OperatorController();

        public FormRegisterClient()
        {
            InitializeComponent();
            ClientListBox.DataSource = Controller.FillType();
            ClientListBox.DisplayMember = "tipoCliente";
            ClientListBox.ValueMember = "idTipo";
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            Client Client = new Client();

            Client.Document = ClientDocumentTextBox.Text;
            Client.Name = ClientNameTextBox.Text;
            Client.Email = ClientEmailTextBox.Text;
            Client.Phone = ClientTelTextBox.Text;
            Client.IdType = Convert.ToInt32(ClientListBox.SelectedValue.ToString());
            Client.Address.Street = ClientStreetTextBox.Text;
            Client.Address.Number = ClientStreetNumberTextBox.Text;
            Client.Address.Neighborhood = ClientNeighborhoodTextBox.Text;
            Client.Address.ZIPCode = ClientCepTextBox.Text;
            Client.Address.State = ClientStateTextBox.Text;
            Client.Address.City = ClientCityTextBox.Text;

            try
            {
                Controller.AddClient(Client);
                MessageBox.Show("Usuário Cadastrado com Sucesso!");

                ClientDocumentTextBox.Clear();
                ClientNameTextBox.Clear();
                ClientEmailTextBox.Clear();
                ClientTelTextBox.Clear();
                ClientStreetTextBox.Clear();
                ClientStreetNumberTextBox.Clear();
                ClientNeighborhoodTextBox.Clear();
                ClientCepTextBox.Clear();
                ClientStateTextBox.Clear();
                ClientCityTextBox.Clear();
            }

            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum erro ao tentar adicionar o cliente.");
            }

        }
    }
}
