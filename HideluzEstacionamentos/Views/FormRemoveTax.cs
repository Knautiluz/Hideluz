using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormRemoveTax : Form
    {
        public FormRemoveTax()
        {
            InitializeComponent();
        }

        private void TaxDeleteBtn_Click(object sender, EventArgs e)
        {
            //deleta taxa do banco
            MessageBox.Show("Você clicou em deletar.");
        }
    }
}
