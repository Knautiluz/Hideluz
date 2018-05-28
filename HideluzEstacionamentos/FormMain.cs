using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormMain : Form
    {
        //atributos de inicialização.
        private Login Login = new Login();
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
            if (!(TextBoxUser.Text == ""))
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
