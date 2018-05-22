using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class ModifyClient : Form
    {
        public Client Client = new Client();
        public Address ClientAddress = new Address();
        public static string Operation = "";
        public ModifyClient()
        {
            InitializeComponent();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Client.Name = ClientNameTextBox.Text;
            Client.Document = ClientDocumentTextBox.Text;
            Client.Email = ClientEmailTextBox.Text;
            Client.Tel = ClientTelTextBox.Text;
            Client.Type = ClientListBox.SelectedIndex;
            ClientAddress.State = ClientStateTextBox.Text;
            ClientAddress.City = ClientCityTextBox.Text;
            ClientAddress.Street = ClientStreetTextBox.Text;
            ClientAddress.Number = ClientStreetNumberTextBox.Text;
            ClientAddress.Neighborhood = ClientNeighborhoodTextBox.Text;
            ClientAddress.Cep = ClientCepTextBox.Text;
            Client.Address = ClientAddress;
            // cadastrar cliente no banco.
            if(ClientListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o tipo do cliente.");
                return;
            }
            if(Login.Operator.ChangeClient(Client, ClientSearchTextBox.Text))
            {
                MessageBox.Show("Dados alterados.");
                RegisterClientPanel.Enabled = false;
            } else
            {
                MessageBox.Show(Operation);
            }
        }

        private void ClientSearchBtn_Click(object sender, EventArgs e)
        {
            var list = Login.Operator.CheckClient(ClientSearchTextBox.Text);
            if(list.Count == 0)
            {
                MessageBox.Show("Esse usuário não existe.");
                RegisterClientPanel.Enabled = false;
                return;
            }

            RegisterClientPanel.Enabled = true;
            ClientDocumentTextBox.Text = list["CPF"];
            ClientNameTextBox.Text = list["NOME"];
            ClientTelTextBox.Text = list["TELEFONE"];
            ClientEmailTextBox.Text = list["EMAIL"];
            ClientStateTextBox.Text = list["ESTADO"];
            ClientCityTextBox.Text = list["CIDADE"];
            ClientNeighborhoodTextBox.Text = list["BAIRRO"];
            ClientStreetTextBox.Text = list["RUA"];
            ClientStreetNumberTextBox.Text = list["NUMERO"];
            ClientCepTextBox.Text = list["CEP"];
        }
    }
}
