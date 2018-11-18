using HideluzEstacionamentos.Controllers;
using System;
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

        private void btn_RegisterSubmit_Click(object sender, System.EventArgs e)
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
    }
}
