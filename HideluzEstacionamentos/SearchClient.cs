using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class SearchClient : Form
    {
        public Client Client = new Client();
        public Address ClientAddress = new Address();
        public static string Operation = "";

        public SearchClient()
        {
            InitializeComponent();
        }

        private void SearchClientBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(ClientDocumentTextBox.Text))
            {
                MessageBox.Show("Digite o CPF para continuar", "CPF inválido.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var list = Login.Operator.CheckClient(ClientDocumentTextBox.Text);
            if(list.Count < 1)
            {
                MessageBox.Show("O CPF consultado não foi cadastrado!", "CPF inválido.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ClientDocumentLabel.Text = list["CPF"];
            ClientNameLabel.Text = list["NOME"];
            ClientTelLabel.Text = list["TELEFONE"];
            ClientEmailLabel.Text = list["EMAIL"];
            ClientStateLabel.Text = list["ESTADO"];
            ClientCityLabel.Text = list["CIDADE"];
            ClientNeighborhoodLabel.Text = list["BAIRRO"];
            ClientStreetLabel.Text = list["RUA"];
            ClientNumberLabel.Text = list["NUMERO"];
            ClientCepLabel.Text = list["CEP"];
        }
    }
}
