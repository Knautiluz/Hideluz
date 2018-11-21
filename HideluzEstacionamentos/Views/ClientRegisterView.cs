using HideluzEstacionamentos.Controllers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HideluzEstacionamentos.Views
{
    public partial class ClientRegisterView : UserControl
    {
        OperatorController Controller = new OperatorController();

        public ClientRegisterView()
        {
            InitializeComponent();
            combo_ClientType.DataSource = Controller.FillType();
            combo_ClientType.DisplayMember = "tipoCliente";
            combo_ClientType.ValueMember = "idTipo";
        }

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

        #region Validators

        private bool DocumentValidator()
        {
            if (!string.IsNullOrEmpty(txt_ClientDocument.Text) && txt_ClientDocument.Text.Length >= 11)
            {
                errorProvider_OK.SetError(txt_ClientDocument, "OK");
                return true;
            }

            if (txt_ClientDocument.Text.Length < 14)
            {
                if (string.IsNullOrEmpty(txt_ClientDocument.Text))
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
            if (!string.IsNullOrEmpty((txt_ClientPhone.Text)) && txt_ClientPhone.Text.Length >= 11)
            {
                errorProvider_OK.SetError(txt_ClientPhone, "OK");
                return true;
            }

            if (txt_ClientPhone.Text.Length < 8)
            {
                if (string.IsNullOrEmpty(txt_ClientPhone.Text))
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
            if (!string.IsNullOrEmpty((txt_ClientZIPCode.Text)) && txt_ClientZIPCode.Text.Length >= 8)
            {
                errorProvider_OK.SetError(txt_ClientZIPCode, "OK");
                return true;
            }

            if (txt_ClientZIPCode.Text.Length < 8)
            {
                if (string.IsNullOrEmpty(txt_ClientZIPCode.Text))
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
            int falses = 0;

            if (!DocumentValidator())
            {
                falses += 1;
            }

            if (!NameValidator())
            {
                falses += 1;
            }

            if (!EmailValidator())
            {
                falses += 1;
            }

            if (!PhoneValidator())
            {
                falses += 1;
            }

            if (!StateValidator())
            {
                falses += 1;
            }

            if (!CityValidator())
            {
                falses += 1;
            }

            if (!NeighborhoodValidator())
            {
                falses += 1;
            }

            if (!StreetValidator())
            {
                falses += 1;
            }

            if (!ZIPCodeValidator())
            {
                falses += 1;
            }

            if (!NumberValidator())
            {
                falses += 1;
            }

            if (falses == 0) { return true; }
            else { return false; }
        }

        #endregion
    }
}
