using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormSearchUser : Form
    {
        public FormSearchUser()
        {
            InitializeComponent();
        }

        private void UserSearchBtn_Click(object sender, EventArgs e)
        {
            //pesquisa usuário no banco
            MessageBox.Show("Você clicou em pesquisar!");
        }
    }
}
