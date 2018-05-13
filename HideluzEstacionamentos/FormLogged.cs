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
    public partial class FormLogged : Form
    {
        public static Operator Operator;
        public static RegisterClient RegisterClient = new RegisterClient();
        public static RegisterVehicle RegisterVehicle = new RegisterVehicle();
        public static ModifyClient ModifyClient = new ModifyClient();
        public static ModifyVehicle ModifyVehicle = new ModifyVehicle();
        public static SearchClient SearchClient = new SearchClient();
        public static RegisterUser RegisterUser = new RegisterUser();
        public static ModifyUser ModifyUser = new ModifyUser();
        public static SearchUser SearchUser = new SearchUser();
        public static DeleteUser DeleteUser = new DeleteUser();

        public FormLogged()
        {
            InitializeComponent();
            Operator = new Operator(Login.EmployeeRegistry, Login.Name, Login.Type);
            OperatorStripMenuItem.Text = Operator.Name;
            if(Operator.Type == 0)
            {
                ToolStripMenuItem adm = new ToolStripMenuItem
                {
                    Text = "Administrador",
                    Name = "AdministratorStripMenuItem",
                    DropDownDirection = ToolStripDropDownDirection.BelowRight
                };
                ToolStripMenuItem addUser = new ToolStripMenuItem
                {
                    Text = "Adicionar Usuário",
                    Name = "AddUserStripMenuItem"
                };
                addUser.Click += (s, e) => AddUserToolStripItem_Click();
                ToolStripMenuItem changeUser = new ToolStripMenuItem
                {
                    Text = "Alterar Usuário",
                    Name = "ChangeUserStripMenuItem"
                };
                //changeUser.Click += (s, e) => ChangeUserToolStripItem_Click();
                ToolStripMenuItem searchUser = new ToolStripMenuItem
                {
                    Text = "Pesquisar Usuário",
                    Name = "SearchUserStripMenuItem"
                };
                searchUser.Click += (s, e) => SearchUserToolStripItem_Click();
                ToolStripMenuItem deleteUser = new ToolStripMenuItem
                {
                    Text = "Deletar Usuário",
                    Name = "DeleteUserStripMenuItem"
                };
                deleteUser.Click += (s, e) => DeleteUserToolStripItem_Click();

                adm.DropDownItems.Add(addUser);
                adm.DropDownItems.Add(changeUser);
                adm.DropDownItems.Add(searchUser);
                adm.DropDownItems.Add(deleteUser);
                HideluzMenuStrip.Items.Add(adm);
            }
        }

        private void DeleteUserToolStripItem_Click()
        {
            try
            {
                DeleteUser.Show();
            }
            catch (ObjectDisposedException)
            {
                DeleteUser = new DeleteUser();
                DeleteUser.Show();
            }
        }

        private void SearchUserToolStripItem_Click()
        {
            try
            {
                SearchUser.Show();
            }
            catch (ObjectDisposedException)
            {
                SearchUser = new SearchUser();
                SearchUser.Show();
            }
        }

        private void AddUserToolStripItem_Click()
        {
            try
            {
                RegisterUser.Show();
            }
            catch (ObjectDisposedException)
            {
                RegisterUser = new RegisterUser();
                RegisterUser.Show();
            }
        }

        private void ChangeUserToolStripItem_Click()
        {
            try
            {
                ModifyUser.Show();
            }
            catch (ObjectDisposedException)
            {
                ModifyUser = new ModifyUser();
                ModifyUser.Show();
            }
        }

        private void AddVehicleToolStripItem_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterVehicle.Show();
            }
            catch (ObjectDisposedException)
            {
                RegisterVehicle = new RegisterVehicle();
                RegisterVehicle.Show();
            }
        }

        private void AddClientToolStripItem_Click(object sender, EventArgs e)
        {   
            try
            {
                RegisterClient.Show();
            }
            catch (ObjectDisposedException)
            {
                RegisterClient = new RegisterClient();
                RegisterClient.Show();
            }
        }
        private void ChangeClientToolStripItem_Click(object sender, EventArgs e)
        {
            try
            {
                ModifyClient.Show();
            }
            catch (ObjectDisposedException)
            {
                ModifyClient = new ModifyClient();
                ModifyClient.Show();
            }
        }
        private void ChangeVehicleToolStripItem_Click(object sender, EventArgs e)
        {
            try
            {
                ModifyVehicle.Show();
            }
            catch (ObjectDisposedException)
            {
                ModifyVehicle = new ModifyVehicle();
                ModifyVehicle.Show();
            }
        }

        private void FormLogged_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegisterClient.Close();
            RegisterUser.Close();
            ModifyUser.Close();
            RegisterVehicle.Close();
            ModifyVehicle.Close();
            ModifyClient.Close();
            SearchClient.Close();
            SearchUser.Close();
            DeleteUser.Close();
            var form = Application.OpenForms[0];
            form.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterClient.Close();
            RegisterUser.Close();
            ModifyUser.Close();
            RegisterVehicle.Close();
            ModifyVehicle.Close();
            ModifyClient.Close();
            SearchClient.Close();
            SearchUser.Close();
            DeleteUser.Close();
            var form = Application.OpenForms[0];
            form.Show();
            Close();
        }

        private void ConsultClientToolStripItem_Click(object sender, EventArgs e)
        {
            try
            {
                SearchClient.Show();
            }
            catch (ObjectDisposedException)
            {
                SearchClient = new SearchClient();
                SearchClient.Show();
            }
        }
    }
}
