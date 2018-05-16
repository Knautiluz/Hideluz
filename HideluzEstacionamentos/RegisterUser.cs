using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class RegisterUser : Form
    {
        public static string Operation = "";
        public User User = new User();

        public RegisterUser()
        {
            InitializeComponent();
        }

        private void ClientCreateBtn_Click(object sender, EventArgs e)
        {
            User.Document = ClientDocumentTextBox.Text;
            User.Name = ClientNameTextBox.Text;
            User.Username = ClientUsernameTextBox.Text;
            User.Password = ClientPasswordTextBox.Text;
            User.Type = ClientTypeListBox.SelectedIndex +1;
            if(FormLogged.Administrator.AddUser(User, FormLogged.Operator.EmployeeRegistry))
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
