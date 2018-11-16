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

        private void BtnLogin_MouseHover(object sender, EventArgs e)
        {
            BtnLogin.BackColor = System.Drawing.Color.LimeGreen;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.BackColor = System.Drawing.Color.DarkGreen;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void picture_Logo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
