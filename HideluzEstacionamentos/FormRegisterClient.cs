using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormRegisterClient : Form
    {
        public FormRegisterClient()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            //registra um novo cliente
            MessageBox.Show("Você clicou em cadastrar!");
        }
    }
}
