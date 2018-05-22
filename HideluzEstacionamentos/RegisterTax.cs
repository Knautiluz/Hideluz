using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class RegisterTax : Form
    {
        public static string Operation;

        public RegisterTax()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if(Login.Administrator.AddTax((TaxListBox.SelectedIndex + 1), float.Parse(TaxPriceMaskedTextBox.Text)))
            {
                MessageBox.Show("A tarifa foi registrada com sucesso!");
            }
            else
            {
                MessageBox.Show(Operation);
            }
        }
    }
}
