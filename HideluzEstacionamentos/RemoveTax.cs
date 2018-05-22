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
    public partial class RemoveTax : Form
    {
        public static string Operation;

        public RemoveTax()
        {
            InitializeComponent();
        }

        private void TaxDeleteBtn_Click(object sender, EventArgs e)
        {
            Login.Administrator.DeleteTax((VehicleTypeListBox.SelectedIndex + 1));
        }
    }
}
