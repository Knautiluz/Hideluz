using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormModifyTax : Form
    {
        public FormModifyTax()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //envia dados para pesquisar a taxa, antes de alterá-la.
            MessageBox.Show("Você clicou em pesquisar!");
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            //envia dados para alterar a taxa.
            MessageBox.Show("Você clicou em alterar!");
        }
    }
}
