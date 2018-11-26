using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HideluzEstacionamentos.Controllers;

namespace HideluzEstacionamentos.Views
{
    public partial class ClientSearchView : UserControl
    {
        OperatorController Controller = new OperatorController();
        Client Client = new Client();
        Client UpdatedClient = new Client();

        public ClientSearchView()
        {
            InitializeComponent();
            combo_ClientType.DataSource = Controller.FillType();
            combo_ClientType.DisplayMember = "tipoCliente";
            combo_ClientType.ValueMember = "idTipo";
        }

        private void btn_ClientSearch_Click(object sender, EventArgs e)
        {
            Client.Document = txt_SearchInformation.Text;
            if (InputValidator())
            {
                try
                {
                    Client = Controller.CheckClient(Client);
                    FillClientInfo(Client);
                    btn_UpdateSubmit.Enabled = true;
                }
                catch (Exception err)
                {
                    throw err;
                    //MessageBox.Show("Ocorreu algum erro ao buscar o cliente.");
                }
            }
            else { btn_UpdateSubmit.Enabled = false; }
        }

        private bool InputValidator()
        {
            errorProvider1.Clear();
            errorProvider_OK.Clear();
            ClearFields();

            if (!string.IsNullOrEmpty(txt_SearchInformation.TextNoFormatting()) && txt_SearchInformation.TextNoFormatting().Length >= 11)
            {
                if (Controller.CheckClientExists(Client))
                {
                    errorProvider_OK.SetError(txt_SearchInformation, "OK");
                    return true;
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider_OK.Clear();
                    errorProvider1.SetError(txt_SearchInformation, "CPF não cadastrado.");
                    return false;
                }
            }

            if (txt_SearchInformation.TextNoFormatting().Length < 14)
            {
                if (string.IsNullOrEmpty(txt_SearchInformation.TextNoFormatting()))
                {
                    errorProvider1.SetError(txt_SearchInformation, "Preencha o campo.");
                    return false;
                }

                else
                {
                    errorProvider1.SetError(txt_SearchInformation, "Informe um CPF válido");
                    return false;
                }
            }
            return false;
        }

        private void FillClientInfo(Client client)
        {
            txt_ClientDocument.Text = client.Document;
            txt_ClientName.Text = client.Name;
            txt_ClientEmail.Text = client.Email;
            txt_ClientPhone.Text = client.Phone;
            combo_ClientType.SelectedValue = client.IdType;
            txt_ClientState.Text = client.Address.State;
            txt_ClientCity.Text = client.Address.City;
            txt_ClientNeighborhood.Text = client.Address.Neighborhood;
            txt_ClientStreet.Text = client.Address.Street;
            txt_ClientZIPCode.Text = client.Address.ZIPCode;
            txt_ClientNumber.Text = client.Address.Number;
            txt_ClientCreatedDate.Text = client.CreatedDate.ToString();
            checkBox_ClientStatus.Checked = Client.Status;
        }

        private void btn_UpdateSubmit_Click(object sender, EventArgs e)
        {
            UpdatedClient.Document = txt_ClientDocument.Text;
            UpdatedClient.Name = txt_ClientName.Text;
            UpdatedClient.Email = txt_ClientEmail.Text;
            UpdatedClient.Phone = txt_ClientPhone.Text;
            UpdatedClient.IdType = combo_ClientType.SelectedIndex;
            UpdatedClient.Address.State = txt_ClientState.Text;
            UpdatedClient.Address.City = txt_ClientCity.Text;
            UpdatedClient.Address.Neighborhood = txt_ClientNeighborhood.Text;
            UpdatedClient.Address.Street = txt_ClientStreet.Text;
            UpdatedClient.Address.Number = txt_ClientNumber.Text;
            UpdatedClient.Address.ZIPCode = txt_ClientZIPCode.Text;
            UpdatedClient.Status = checkBox_ClientStatus.Checked ? true : false;

            if (Controller.UpdateClient(Client, UpdatedClient))
            {
                MessageBox.Show("Cliente atualizado!");
            }
        }

        private void ClearFields()
        {
            txt_ClientDocument.Clear();
            txt_ClientName.Clear();
            txt_ClientEmail.Clear();
            txt_ClientPhone.Clear();
            combo_ClientType.SelectedIndex = 1;
            txt_ClientState.Clear();
            txt_ClientCity.Clear();
            txt_ClientNeighborhood.Clear();
            txt_ClientStreet.Clear();
            txt_ClientNumber.Clear();
            txt_ClientZIPCode.Clear();
        }
    }
}
