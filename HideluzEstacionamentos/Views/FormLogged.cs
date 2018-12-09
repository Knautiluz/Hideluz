using HideluzEstacionamentos.Models;
using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos.Views
{
    public partial class FormLogged : Form
    {
        public FormLogged(Login user)
        {
            InitializeComponent();
            lbl_Username.Text = user.Name;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_selectedMenu.Height = btn_home.Height;
            panel_selectedMenu.Top = btn_home.Top;
            homeView.BringToFront();
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            panel_selectedMenu.Height = btn_clients.Height;
            panel_selectedMenu.Top = btn_clients.Top;
            clientView.BringToFront();
        }

        private void btn_vehicles_Click(object sender, EventArgs e)
        {
            panel_selectedMenu.Height = btn_vehicles.Height;
            panel_selectedMenu.Top = btn_vehicles.Top;
            vehicleView.BringToFront();
        }

        private void btn_taxes_Click(object sender, EventArgs e)
        {
            panel_selectedMenu.Height = btn_taxes.Height;
            panel_selectedMenu.Top = btn_taxes.Top;
            taxView.BringToFront();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            panel_selectedMenu.Height = btn_reports.Height;
            panel_selectedMenu.Top = btn_reports.Top;
        }

        private void FormLoggerv2_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Application.OpenForms[0];
            form.Show();
        }
    }
}
