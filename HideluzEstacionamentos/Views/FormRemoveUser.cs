using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormRemoveUser : Form
    {
        public FormRemoveUser()
        {
            InitializeComponent();
        }

        private void UserDeleteBtn_Click(object sender, EventArgs e)
        {
            //deleta usuário do banco de dados
            MessageBox.Show("Você clicou em deletar!");
        }
    }
}
