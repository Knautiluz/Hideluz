using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class SearchUser : Form
    {
        public SearchUser()
        {
            InitializeComponent();
        }

        private void UserSearchBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UserDocumentTextBox.Text))
            {
                MessageBox.Show("Digite o CPF para continuar", "CPF inválido.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var list = FormLogged.Administrator.SearchUser(UserDocumentTextBox.Text);
            if (list.Count < 1)
            {
                MessageBox.Show("O CPF consultado não foi cadastrado!", "CPF inválido.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UserDocumentLabel.Text = list["CPF"];
            UserNameLabel.Text = list["NOME"];
            UserUsernameLabel.Text = list["USUARIO"];
            UserStatusLabel.Text = list["STATUS"];
            UserTypeLabel.Text = list["TIPO"];
        }
    }
}
