using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class ModifyUser : Form
    {
        User User = new User();
        public static string Operation = "";
        public ModifyUser()
        {
            InitializeComponent();
        }

        private void ClientModifyBtn_Click(object sender, EventArgs e)
        {
            User.Document = UserDocumentTextBox.Text;
            User.Name = UserNameTextBox.Text;
            User.Username = UserUsernameTextBox.Text;
            User.Password = UserPasswordTextBox.Text;
            User.Status = UserStatusListBox.SelectedIndex + 1;
            User.Type = UserTypeListBox.SelectedIndex + 1;
            if(UserStatusListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o novo status do usuário.");
                return;
            }
            if(UserTypeListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o novo tipo do usuário.");
                return;
            }
            if (FormLogged.Administrator.ChangeUser(User, UserSearchDocumentTextBox.Text))
            {
                MessageBox.Show(Operation);
            }
            else
            {
                MessageBox.Show(Operation);
            }
        }

        private void UserSearchBtn_Click(object sender, EventArgs e)
        {
            var list = FormLogged.Administrator.SearchUser(UserSearchDocumentTextBox.Text);
            if (list.Count == 0)
            {
                MessageBox.Show("Esse usuário não existe.");
                UserDataPanel.Enabled = false;
                return;
            }
            UserDataPanel.Enabled = true;
            UserDocumentTextBox.Text = list["CPF"];
            UserNameTextBox.Text = list["NOME"];
            UserUsernameTextBox.Text = list["USUARIO"];
            UserPasswordTextBox.Text = list["SENHA"];
        }
    }
}
