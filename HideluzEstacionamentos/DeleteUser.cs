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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
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
            if(FormLogged.Operator.DeleteUser(UserDocumentTextBox.Text))
            {
                MessageBox.Show("Usuário deletado.");
            }
            else
            {
                MessageBox.Show("Esse CPF não está cadastrado.");
            }
        }
    }
}
