using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormRegisterUser : Form
    {
        public FormRegisterUser()
        {
            InitializeComponent();
        }

        private void ClientCreateBtn_Click(object sender, EventArgs e)
        {
            //registra novo usuário.
            MessageBox.Show("Você clicou em registrar.");
        }
    }
}
