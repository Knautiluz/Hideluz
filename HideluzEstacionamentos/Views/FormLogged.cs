using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormLogged : Form
    {
        
        public static Administrator Administrator;
        public FormRegisterClient RegisterClient = new FormRegisterClient();
        public FormRegisterVehicle RegisterVehicle = new FormRegisterVehicle();
        public FormRegisterUser RegisterUser = new FormRegisterUser();
        public FormRegisterTax RegisterTax = new FormRegisterTax();
        public FormModifyClient ModifyClient = new FormModifyClient();
        public FormModifyVehicle ModifyVehicle = new FormModifyVehicle();
        public FormModifyUser ModifyUser = new FormModifyUser();
        public FormModifyTax ModifyTax = new FormModifyTax();
        public FormSearchClient SearchClient = new FormSearchClient();
        public FormSearchVehicle SearchVehicle = new FormSearchVehicle();
        public FormSearchUser SearchUser = new FormSearchUser();
        public FormSearchTax SearchTax = new FormSearchTax();
        public FormRemoveUser RemoveUser = new FormRemoveUser();
        public FormRemoveClient RemoveClient = new FormRemoveClient();
        public FormRemoveVehicle RemoveVehicle = new FormRemoveVehicle();
        public FormRemoveTax RemoveTax = new FormRemoveTax();
        public FormLogged()
        {
            InitializeComponent();
            if(Login.Operator.Type == 0)
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
                RegisterVehicle = new FormRegisterVehicle();
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
                RegisterClient = new FormRegisterClient();
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
                ModifyClient = new FormModifyClient();
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
                ModifyVehicle = new FormModifyVehicle();
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
                SearchClient = new FormSearchClient();
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
                SearchVehicle = new FormSearchVehicle();
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
                RemoveClient = new FormRemoveClient();
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
                RemoveVehicle = new FormRemoveVehicle();
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
                RegisterUser = new FormRegisterUser();
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
                SearchUser = new FormSearchUser();
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
                ModifyUser = new FormModifyUser();
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
                RemoveUser = new FormRemoveUser();
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
                RegisterTax = new FormRegisterTax();
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
                SearchTax = new FormSearchTax();
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
                SearchTax = new FormSearchTax();
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
                ModifyTax = new FormModifyTax();
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
                RemoveTax = new FormRemoveTax();
                RemoveTax.Show();
            }
        }
    }
}
