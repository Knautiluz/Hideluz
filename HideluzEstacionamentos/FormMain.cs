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
            Splash Splash = new Splash();
            Splash.Show();
            if (!(TextBoxUser.Text == "") && Splash.ProgressComplete)
            {
                MessageBox.Show("Login realizado com sucesso!", "Usuário logado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Splash.Close();
                FormLogged formLogged = new FormLogged();
                formLogged.Show();
            }
            else
            {
                MessageBox.Show(Login.Message, "Falha ao tentar logar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
