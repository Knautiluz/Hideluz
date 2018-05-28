using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormRegisterTax : Form
    {
        public static string Operation;

        public FormRegisterTax()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            //cadastra nova taxa.
            MessageBox.Show("Você clicou em cadastrar!");
        }
    }
}
