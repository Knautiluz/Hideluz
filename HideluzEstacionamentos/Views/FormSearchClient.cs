using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormSearchClient : Form
    {
        public FormSearchClient()
        {
            InitializeComponent();
        }

        private void SearchClientBtn_Click(object sender, EventArgs e)
        {
            //pesquisa cliente antes de alterá-lo
            MessageBox.Show("Você clicou em pesquisar!");
        }
    }
}
