using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormModifyClient : Form
    {
        public FormModifyClient()
        {
            InitializeComponent();
        }

        private void ClientSearchBtn_Click(object sender, EventArgs e)
        {
            //pesquisa o cliente antes de alterar os dados
            MessageBox.Show("Você clicou em pesquisar!");
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            //altera dados do cliente
            MessageBox.Show("Você clicou em alterar!");
        }
    }
}
