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
    public partial class ModifyTax : Form
    {
        public static string Operation;

        public ModifyTax()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
           var list = Login.Operator.CheckTax((VehicleTypeListBox.SelectedIndex + 1));
            if(list.Count > 0)
            {
               TaxPriceMaskedTextBox.Text = list[(VehicleTypeListBox.SelectedIndex + 1).ToString()];
            }
            else
            {
                MessageBox.Show("Não existe tarifa registrada para esse tipo de veículo.", Operation);
            }
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Login.Administrator.ChangeTax((VehicleTypeListBox.SelectedIndex + 1), float.Parse(TaxPriceMaskedTextBox.Text));
            MessageBox.Show(Operation);
        }
    }
}
