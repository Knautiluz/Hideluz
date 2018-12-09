using HideluzEstacionamentos.Controllers;
using HideluzEstacionamentos.Models;
using HideluzEstacionamentos.Views;
using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormMain : Form
    {
        private User InputLogin = new User();
        private UserController Controller = new UserController();
        private InitializerController Initializator = new InitializerController();

        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSplash Splash = new FormSplash();
            Splash.Show();

            InputLogin.Username = TextBoxUser.Text;
            InputLogin.Password = TextBoxPass.Text;

            Initializator.CreateUserTypeTable();
            Initializator.CreateUsersTable();
            Initializator.InsertDefaultUsersValues();
            Initializator.InsertDefaultUser();

            Initializator.CreateClientTypeTable();
            Initializator.InsertDefaultClientValues();
            Initializator.CreateClientsTable();
            Initializator.InsertDefaultClient();

            Initializator.CreateVehicleTypeTable();
            Initializator.InsertDefaultVehicleValues();
            Initializator.CreateVehiclesTable();

            Initializator.CreateTaxesTypeTable();
            Initializator.InsertDefaultTaxesValues();
            Initializator.CreateTaxesTable();
            Initializator.CreateRegistryTable();

            if (Controller.ValidateUser(InputLogin))
            {
                Controller.FillUserData(InputLogin);
                Splash.Close();
                MessageBox.Show("Login realizado com sucesso!", "Usuário logado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLogged formLogged = new FormLogged(InputLogin);
                formLogged.Show();
            }

            else
            {
                Splash.Close();
                MessageBox.Show("Dados inválidos", "Falha ao tentar logar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var form = Application.OpenForms[0];
                form.Show();
            }
        }
    }
}
