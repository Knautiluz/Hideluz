using HideluzEstacionamentos.Controllers;
using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormMain : Form
    {
        //atributos de inicialização.
        private Login Login = new Login();
        private LoginController Controller = new LoginController();
        private InitializerController Initializator = new InitializerController();
        public static string OperationResult;
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSplash Splash = new FormSplash();
            Splash.Show();

            Login.Username = TextBoxUser.Text;
            Login.Password = TextBoxPass.Text;

            Initializator.CreateUsersTable();
            var validate = Controller.SelectUser(Login);

            if (validate)
            {
                MessageBox.Show("Login realizado com sucesso!", "Usuário logado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Splash.Close();
                FormLogged formLogged = new FormLogged();
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
