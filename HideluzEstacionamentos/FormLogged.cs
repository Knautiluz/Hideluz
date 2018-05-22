using System;
using System.Drawing;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormLogged : Form
    {
        
        public static Administrator Administrator;
        public RegisterClient RegisterClient = new RegisterClient();
        public RegisterVehicle RegisterVehicle = new RegisterVehicle();
        public RegisterUser RegisterUser = new RegisterUser();
        public RegisterTax RegisterTax = new RegisterTax();
        public ModifyClient ModifyClient = new ModifyClient();
        public ModifyVehicle ModifyVehicle = new ModifyVehicle();
        public ModifyUser ModifyUser = new ModifyUser();
        public ModifyTax ModifyTax = new ModifyTax();
        public SearchClient SearchClient = new SearchClient();
        public SearchVehicle SearchVehicle = new SearchVehicle();
        public SearchUser SearchUser = new SearchUser();
        public SearchTax SearchTax = new SearchTax();
        public RemoveUser RemoveUser = new RemoveUser();
        public RemoveClient RemoveClient = new RemoveClient();
        public RemoveVehicle RemoveVehicle = new RemoveVehicle();
        public RemoveTax RemoveTax = new RemoveTax();
        public FormLogged()
        {
            InitializeComponent();
            OperatorStripMenuItem.Text = Login.Operator.Name;
            if(Login.Operator.Type == 1)
            {
                OperatorTaxToolStripMenuItem.Available = false;
            } else
            {
                AdmTaxToolStripMenuItem.Available = false;
                UserToolStripMenuItem.Available = false;
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
                FormLoggedMainPanel.Hide();
                RegisterClient.Show();

            }
            catch (ObjectDisposedException)
            {
                RegisterClient = new RegisterClient();
                RegisterClient.MdiParent = this;
                FormLoggedMainPanel.Hide();
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
            RegisterVehicle.Close();
            RegisterTax.Close();
            ModifyUser.Close();
            ModifyVehicle.Close();
            ModifyClient.Close();
            ModifyTax.Close();
            SearchClient.Close();
            SearchUser.Close();
            SearchVehicle.Close();
            SearchTax.Close();
            RemoveUser.Close();
            RemoveClient.Close();
            RemoveVehicle.Close();
            RemoveTax.Close();
            var form = Application.OpenForms[0];
            form.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterClient.Close();
            RegisterUser.Close();
            RegisterVehicle.Close();
            RegisterTax.Close();
            ModifyUser.Close();
            ModifyVehicle.Close();
            ModifyClient.Close();
            ModifyTax.Close();
            SearchClient.Close();
            SearchUser.Close();
            SearchVehicle.Close();
            SearchTax.Close();
            RemoveUser.Close();
            RemoveClient.Close();
            RemoveVehicle.Close();
            RemoveTax.Close();
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

        private void ConsultVehicleToolStripItem_Click(object sender, EventArgs e)
        {
            try
            {
                SearchVehicle.Show();
            }
            catch (ObjectDisposedException)
            {
                SearchVehicle = new SearchVehicle();
                SearchVehicle.Show();
            }
        }

        private void RemoveClientToolStripItem_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveClient.Show();
            }
            catch (ObjectDisposedException)
            {
                RemoveClient = new RemoveClient();
                RemoveClient.Show();
            }
        }

        private void RemoveVehicleToolStripItem_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveVehicle.Show();
            }
            catch (ObjectDisposedException)
            {
                RemoveVehicle = new RemoveVehicle();
                RemoveVehicle.Show();
            }
        }
        private void AddUserToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void ConsultUserToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void ChangeUserToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void RemoveUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveUser.Show();
            }
            catch (ObjectDisposedException)
            {
                RemoveUser = new RemoveUser();
                RemoveUser.Show();
            }
        }

        private void AdministratorAddTaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterTax.Show();
            }
            catch (ObjectDisposedException)
            {
                RegisterTax = new RegisterTax();
                RegisterTax.Show();
            }
        }

        private void OperatorConsultTaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SearchTax.Show();
            }
            catch (ObjectDisposedException)
            {
                SearchTax = new SearchTax();
                SearchTax.Show();
            }
        }

        private void AdministratorConsultTaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SearchTax.Show();
            }
            catch (ObjectDisposedException)
            {
                SearchTax = new SearchTax();
                SearchTax.Show();
            }
        }

        private void AdministratorChangeTaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ModifyTax.Show();
            }
            catch (ObjectDisposedException)
            {
                ModifyTax = new ModifyTax();
                ModifyTax.Show();
            }
        }

        private void AdministratorRemoveTaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveTax.Show();
            }
            catch (ObjectDisposedException)
            {
                RemoveTax = new RemoveTax();
                RemoveTax.Show();
            }
        }
    }
}
