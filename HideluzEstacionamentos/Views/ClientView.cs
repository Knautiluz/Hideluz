using HideluzEstacionamentos.Controllers;
using HideluzEstacionamentos.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace HideluzEstacionamentos.Views
{
    public partial class ClientView : UserControl
    {
        OperatorController Controller = new OperatorController();
        Client Client = new Client();
        Client UpdatedClient = new Client();

        public ClientView()
        {
            InitializeComponent();
            combo_ClientType.DataSource = Controller.FillClientType();
            combo_ClientType.DisplayMember = "tx_tipo";
            combo_ClientType.ValueMember = "id";
            dataGrid_AllClients.DataSource = Controller.FillClientTable();
            dataGrid_AllClients.Columns[0].HeaderText = "id";
            dataGrid_AllClients.Columns[1].HeaderText = "CPF";
            dataGrid_AllClients.Columns[2].HeaderText = "Nome";
            dataGrid_AllClients.Columns[3].HeaderText = "E-mail";
            dataGrid_AllClients.Columns[4].HeaderText = "Telefone";
            dataGrid_AllClients.Columns[5].HeaderText = "Tipo";
            dataGrid_AllClients.Columns[6].HeaderText = "Estado";
            dataGrid_AllClients.Columns[7].HeaderText = "Cidade";
            dataGrid_AllClients.Columns[8].HeaderText = "Bairro";
            dataGrid_AllClients.Columns[9].HeaderText = "Rua";
            dataGrid_AllClients.Columns[10].HeaderText = "Número";
            dataGrid_AllClients.Columns[11].HeaderText = "CEP";
            dataGrid_AllClients.Columns[12].HeaderText = "Ativo";
            dataGrid_AllClients.Columns[13].HeaderText = "Data Criação";
        }

        #region Buttons

        private void btn_RegisterSubmit_Click(object sender, EventArgs e)
        {
            if (GeneralValidator())
            {

                Client Client = new Client();

                Client.Document = txt_ClientDocument.Text;
                Client.Name = txt_ClientName.Text;
                Client.Email = txt_ClientEmail.Text;
                Client.Phone = txt_ClientPhone.Text;
                Client.IdType = Convert.ToInt32(combo_ClientType.SelectedValue.ToString());
                Client.Address.Street = txt_ClientStreet.Text;
                Client.Address.Number = txt_ClientNumber.Text;
                Client.Address.Neighborhood = txt_ClientNeighborhood.Text;
                Client.Address.ZIPCode = txt_ClientZIPCode.Text;
                Client.Address.State = txt_ClientState.Text;
                Client.Address.City = txt_ClientCity.Text;

                try
                {
                    Controller.AddClient(Client);
                    MessageBox.Show("Usuário Cadastrado com Sucesso!");

                    txt_ClientDocument.Clear();
                    txt_ClientName.Clear();
                    txt_ClientEmail.Clear();
                    txt_ClientPhone.Clear();
                    txt_ClientStreet.Clear();
                    txt_ClientNumber.Clear();
                    txt_ClientNeighborhood.Clear();
                    txt_ClientZIPCode.Clear();
                    txt_ClientState.Clear();
                    txt_ClientCity.Clear();
                    RefreshDataGrid();
                }

                catch (Exception)
                {
                    MessageBox.Show("Ocorreu algum erro ao tentar adicionar o cliente.");
                }
            }

            else
            {
                MessageBox.Show("Campos inválidos.");
            }
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
                    btn_DeleteClient.Enabled = true;
                }
                catch (Exception err)
                {
                    throw err;
                    //MessageBox.Show("Ocorreu algum erro ao buscar o cliente.");
                }
            }
            else { btn_UpdateSubmit.Enabled = false; }
        }

        private void btn_UpdateSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja salvar as alterações?", "Atualizar Cliente", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UpdatedClient.Document = txt_ClientDocument.Text;
                UpdatedClient.Name = txt_ClientName.Text;
                UpdatedClient.Email = txt_ClientEmail.Text;
                UpdatedClient.Phone = txt_ClientPhone.Text;
                UpdatedClient.IdType = Convert.ToInt32(combo_ClientType.SelectedValue);
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
                    btn_UpdateSubmit.Enabled = false;
                    btn_DeleteClient.Enabled = false;
                    RefreshDataGrid();
                }
            }
        }

        private void btn_DeleteClient_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir esse cliente?", "Excluir Cliente", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (Controller.DeleteClient(Client))
                {
                    ClearFields();
                    MessageBox.Show("Cliente excluido");
                    RefreshDataGrid();
                    btn_UpdateSubmit.Enabled = false;
                    btn_DeleteClient.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ocorreu um problema ao excluir o cliente");
                }

            }
        }

        private void btn_SelectClient_Click(object sender, EventArgs e)
        {
            DataRowView SelectedRow = (DataRowView)dataGrid_AllClients.CurrentRow?.DataBoundItem;
            if (!(SelectedRow == null))
            {
                Client = Controller.RowConverterClient(SelectedRow, Client);
                PopulateFormClient(Client);
                btn_UpdateSubmit.Enabled = true;
                btn_DeleteClient.Enabled = true;
            }
        }

        #endregion

        #region Validators

        private bool DocumentValidator()
        {
            if (!string.IsNullOrEmpty(txt_ClientDocument.TextNoFormatting()) && txt_ClientDocument.TextNoFormatting().Length >= 11)
            {
                Client.Document = txt_ClientDocument.Text;
                if (!Controller.CheckClientExists(Client))
                {
                    errorProvider_OK.SetError(txt_ClientDocument, "OK");
                    return true;
                }
                else
                {
                    errorProvider1.SetError(txt_ClientDocument, "CPF já cadastrado");
                    return false;
                }
            }

            if (txt_ClientDocument.TextNoFormatting().Length < 14)
            {
                if (string.IsNullOrEmpty(txt_ClientDocument.TextNoFormatting()))
                {
                    errorProvider1.SetError(txt_ClientDocument, "Preencha o campo.");
                    return false;
                }

                else
                {
                    errorProvider1.SetError(txt_ClientDocument, "Informe um CPF válido");
                    return false;
                }
            }
            return false;
        }

        private bool NameValidator()
        {
            if (!string.IsNullOrEmpty(txt_ClientName.Text))
            {
                errorProvider_OK.SetError(txt_ClientName, "OK");
                return true;
            }

            if (string.IsNullOrEmpty(txt_ClientName.Text))
            {
                errorProvider1.SetError(txt_ClientName, "Preencha o campo");
            }
            return false;
        }

        private bool EmailValidator()
        {
            if (!string.IsNullOrEmpty(txt_ClientEmail.Text))
            {
                errorProvider_OK.SetError(txt_ClientEmail, "OK");
                return true;
            }

            if (string.IsNullOrEmpty(txt_ClientEmail.Text))
            {
                errorProvider1.SetError(txt_ClientEmail, "Preencha o campo.");
                return false;
            }

            return false;
        }

        private bool PhoneValidator()
        {
            if (!string.IsNullOrEmpty((txt_ClientPhone.TextNoFormatting())) && txt_ClientPhone.TextNoFormatting().Length >= 11)
            {
                errorProvider_OK.SetError(txt_ClientPhone, "OK");
                return true;
            }

            if (txt_ClientPhone.TextNoFormatting().Length < 8)
            {
                if (string.IsNullOrEmpty(txt_ClientPhone.TextNoFormatting()))
                {
                    errorProvider1.SetError(txt_ClientPhone, "Preencha o campo.");
                    return false;
                }

                else
                {
                    errorProvider1.SetError(txt_ClientPhone, "Informe um telefone válido");
                    return false;
                }
            }
            return false;
        }

        private bool StateValidator()
        {
            if (!string.IsNullOrEmpty(txt_ClientState.Text))
            {
                errorProvider_OK.SetError(txt_ClientState, "OK");
                return true;
            }

            if (string.IsNullOrEmpty(txt_ClientState.Text))
            {
                errorProvider1.SetError(txt_ClientState, "Preencha o campo.");
                return false;
            }

            return false;
        }

        private bool CityValidator()
        {
            if (!string.IsNullOrEmpty(txt_ClientCity.Text))
            {
                errorProvider_OK.SetError(txt_ClientCity, "OK");
                return true;
            }

            if (string.IsNullOrEmpty(txt_ClientCity.Text))
            {
                errorProvider1.SetError(txt_ClientCity, "Preencha o campo.");
                return false;
            }

            return false;
        }

        private bool NeighborhoodValidator()
        {
            if (!string.IsNullOrEmpty(txt_ClientNeighborhood.Text))
            {
                errorProvider_OK.SetError(txt_ClientNeighborhood, "OK");
                return true;
            }

            if (string.IsNullOrEmpty(txt_ClientNeighborhood.Text))
            {
                errorProvider1.SetError(txt_ClientNeighborhood, "Preencha o campo.");
                return false;
            }

            return false;
        }

        private bool StreetValidator()
        {
            if (!string.IsNullOrEmpty(txt_ClientStreet.Text))
            {
                errorProvider_OK.SetError(txt_ClientStreet, "OK");
                return true;
            }

            if (string.IsNullOrEmpty(txt_ClientStreet.Text))
            {
                errorProvider1.SetError(txt_ClientStreet, "Preencha o campo.");
                return false;
            }

            return false;
        }

        private bool ZIPCodeValidator()
        {
            if (!string.IsNullOrEmpty((txt_ClientZIPCode.TextNoFormatting())) && txt_ClientZIPCode.TextNoFormatting().Length >= 8)
            {
                errorProvider_OK.SetError(txt_ClientZIPCode, "OK");
                return true;
            }

            if (txt_ClientZIPCode.TextNoFormatting().Length < 8)
            {
                if (string.IsNullOrEmpty(txt_ClientZIPCode.TextNoFormatting()))
                {
                    errorProvider1.SetError(txt_ClientZIPCode, "Preencha o campo.");
                    return false;
                }

                else
                {
                    errorProvider1.SetError(txt_ClientZIPCode, "Informe um CEP válido");
                    return false;
                }
            }
            return false;
        }

        private bool NumberValidator()
        {
            if (!string.IsNullOrEmpty(txt_ClientNumber.Text))
            {
                errorProvider_OK.SetError(txt_ClientNumber, "OK");
                return true;
            }

            if (string.IsNullOrEmpty(txt_ClientNumber.Text))
            {
                errorProvider1.SetError(txt_ClientNumber, "Preencha o campo.");
                return false;
            }

            return false;
        }

        private bool GeneralValidator()
        {
            errorProvider1.Clear();
            errorProvider_OK.Clear();
            int falses = 0;

            if (!DocumentValidator()) { falses = +1; }
            if (!NameValidator()) { falses = +1; }
            if (!EmailValidator()) { falses = +1; }
            if (!PhoneValidator()) { falses = +1; }
            if (!StateValidator()) { falses = +1; }
            if (!CityValidator()) { falses = +1; }
            if (!NeighborhoodValidator()) { falses = +1; }
            if (!StreetValidator()) { falses = +1; }
            if (!ZIPCodeValidator()) { falses = +1; }
            if (!NumberValidator()) { falses = +1; }

            if (falses > 0) { return false; }
            else { return true; }
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

        #endregion

        #region GeneralMethods

        private void PopulateFormClient(Client SelectedClient)
        {
            txt_ClientDocument.Text = SelectedClient.Document;
            txt_ClientName.Text = SelectedClient.Name;
            txt_ClientEmail.Text = SelectedClient.Email;
            txt_ClientPhone.Text = SelectedClient.Phone;
            combo_ClientType.SelectedValue = SelectedClient.IdType;
            txt_ClientState.Text = SelectedClient.Address.State;
            txt_ClientCity.Text = SelectedClient.Address.City;
            txt_ClientNeighborhood.Text = SelectedClient.Address.Neighborhood;
            txt_ClientStreet.Text = SelectedClient.Address.Street;
            txt_ClientZIPCode.Text = SelectedClient.Address.ZIPCode;
            txt_ClientNumber.Text = SelectedClient.Address.Number;
            checkBox_ClientStatus.Checked = SelectedClient.Status;
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
            checkBox_ClientStatus.Checked = Client.Status;
        }

        private void ClearFields()
        {
            txt_ClientDocument.Clear();
            txt_ClientName.Clear();
            txt_ClientEmail.Clear();
            txt_ClientPhone.Clear();
            combo_ClientType.SelectedValue = 1;
            txt_ClientState.Clear();
            txt_ClientCity.Clear();
            txt_ClientNeighborhood.Clear();
            txt_ClientStreet.Clear();
            txt_ClientNumber.Clear();
            txt_ClientZIPCode.Clear();
        }

        public void RefreshDataGrid()
        {
            dataGrid_AllClients.Refresh();
            dataGrid_AllClients.DataSource = Controller.FillClientTable();
        }

        #endregion

    }
}
