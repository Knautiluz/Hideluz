using HideluzEstacionamentos.Controllers;
using HideluzEstacionamentos.Views;
using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormMain : Form
    {
        //atributos de inicialização.
        private Login InputLogin = new Login();
        private LoginController Controller = new LoginController();
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

            if (Controller.ValidateUser(InputLogin))
            {
                Controller.FillUserData(InputLogin);
                MessageBox.Show("Login realizado com sucesso!", "Usuário logado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Splash.Close();
                FormLoggerv2 formLogged = new FormLoggerv2(InputLogin);
                formLogged.Show();
            }

            else
            {
                MessageBox.Show("Dados inválidos", "Falha ao tentar logar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Splash.Close();
                var form = Application.OpenForms[0];
                form.Show();
            }
        }
    }
}
