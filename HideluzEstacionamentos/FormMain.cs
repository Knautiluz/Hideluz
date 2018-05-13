using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (Login.Verify(TextBoxUser.Text, TextBoxPass.Text) && Splash.ProgressComplete)
            {
                MessageBox.Show(string.Format("{0}, bem-vindo!", Login.Name));
                Splash.Close();
                FormLogged formLogged = new FormLogged();
                formLogged.Show();
            }
            else
            {
                MessageBox.Show(OperationResult);
                Splash.Close();
                var form = Application.OpenForms[0];
                form.Show();
            }
        }
    }
}
