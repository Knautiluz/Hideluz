using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormModifyUser : Form
    {
        public FormModifyUser()
        {
            InitializeComponent();
        }

        private void UserSearchBtn_Click(object sender, EventArgs e)
        {
            //instancia um novo usuário com os dados do form e o operador faz a requisição de pesquisa.
            MessageBox.Show("Você clicou em pesquisar!");
        }

        private void ClientModifyBtn_Click(object sender, EventArgs e)
        {
            //instancia um novo usuário com os dados do form e o operador faz a requisição de alteração.
            MessageBox.Show("Você clicou em alterar!");
        }
    }
}
