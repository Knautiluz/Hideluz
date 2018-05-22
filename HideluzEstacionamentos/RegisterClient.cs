using System;
using System.Linq;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class RegisterClient : Form
    {
        public Client Client = new Client();
        public Address ClientAddress = new Address();
        public static string Operation = "";
        public RegisterClient()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if (ClientNameTextBox.Text == "" || ClientDocumentTextBox.Text == "" || ClientStateTextBox.Text == "" || ClientCityTextBox.Text == "" || ClientStreetNumberTextBox.Text == "" || ClientCepTextBox.Text == "" || ClientListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos para completar o cadastro. E-mail não obrigatório.", "Existem campos obrigatórios vazios.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            if(Login.Operator.AddClient(Client, Login.Operator.EmployeeRegistry))
            {
                MessageBox.Show(Operation, "Hideluz informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Operation, "Hideluz informa:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterClient_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Splash.Types.Count; i++)
            {
                ClientListBox.Items.Add(Splash.Types.ElementAt(i));
            }
        }
    }
}
