﻿using System;
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
    public partial class RegisterClient : Form
    {
        Client Client = new Client();
        Address ClientAddress = new Address();
        public RegisterClient()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if (ClientNameTextBox.Text == "" || ClientDocumentTextBox.Text == "" || ClientStateTextBox.Text == "" || ClientCityTextBox.Text == "" || ClientStreetNumberTextBox.Text == "" || ClientCepTextBox.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para completar o cadastro. E-mail não obrigatório.", "Existem campos obrigatórios vazios.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            FormLogged.Operator.AddClient(Client, FormLogged.Operator.EmployeeRegistry);
            ResultLabel.Text = "Cadastro efetuado com sucesso.";
        }
    }
}
