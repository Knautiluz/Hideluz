using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormRemoveClient : Form
    {
        public FormRemoveClient()
        {
            InitializeComponent();
        }

        private void ClientDeleteBtn_Click(object sender, EventArgs e)
        {
            //deleta cliente
            MessageBox.Show("Você clicou em deletar!");
        }
    }
}
