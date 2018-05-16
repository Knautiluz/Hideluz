using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class RemoveUser : Form
    {
        public static string Operation = "";
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void UserDeleteBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UserDocumentTextBox.Text))
            {
                MessageBox.Show("Digite o CPF para continuar", "CPF inválido.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(FormLogged.Administrator.DeleteUser(UserDocumentTextBox.Text))
            {
                MessageBox.Show(Operation);
            }
            else
            {
                MessageBox.Show(Operation);
            }
        }
    }
}
