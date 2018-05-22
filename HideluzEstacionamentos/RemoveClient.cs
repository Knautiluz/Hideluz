using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class RemoveClient : Form
    {
        public static string Operation = "";
        public RemoveClient()
        {
            InitializeComponent();
        }

        private void ClientDeleteBtn_Click(object sender, EventArgs e)
        {
            if(Login.Operator.DeleteClient(ClientDocumentTextBox.Text))
            {
                MessageBox.Show(Operation);
            }
            else
            {
                MessageBox.Show(Operation);
            }
        }
    }
}
