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
    public partial class SearchTax : Form
    {
        public static string Operation;

        public SearchTax()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var list = Login.Operator.CheckTax((TaxListBox.SelectedIndex + 1));
            if (list.Count > 0)
            {
                TaxPriceLabel.Text = list[(TaxListBox.SelectedIndex + 1).ToString()];
            }
            else
            {
                MessageBox.Show("Não existe tarifa cadastrada para o tipo de veículo informado.");
            }
        }
    }
}
