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
    public partial class ModifyUser : Form
    {
        User User = new User();
        public static string Operation = "";
        public ModifyUser()
        {
            InitializeComponent();
        }

        private void ClientModifyBtn_Click(object sender, EventArgs e)
        {
            User.Document = ClientDocumentTextBox.Text;
            User.Name = ClientNameTextBox.Text;
            User.Username = ClientUsernameTextBox.Text;
            User.Password = ClientPasswordTextBox.Text;
            User.Type = ClientTypeListBox.SelectedIndex;
            if (FormLogged.Operator.ModifyUser(User, FormLogged.Operator.EmployeeRegistry))
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
