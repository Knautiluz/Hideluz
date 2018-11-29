using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideluzEstacionamentos.Views
{
    public partial class FormLoggerv2 : Form
    {
        public FormLoggerv2(Login user)
        {
            InitializeComponent();
            lbl_Username.Text = user.Name;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_selectedMenu.Height = btn_home.Height;
            panel_selectedMenu.Top = btn_home.Top;
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            panel_selectedMenu.Height = btn_clients.Height;
            panel_selectedMenu.Top = btn_clients.Top;
        }

        private void btn_vehicles_Click(object sender, EventArgs e)
        {
            panel_selectedMenu.Height = btn_vehicles.Height;
            panel_selectedMenu.Top = btn_vehicles.Top;
        }

        private void btn_taxes_Click(object sender, EventArgs e)
        {
            panel_selectedMenu.Height = btn_taxes.Height;
            panel_selectedMenu.Top = btn_taxes.Top;
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            panel_selectedMenu.Height = btn_reports.Height;
            panel_selectedMenu.Top = btn_reports.Top;
        }
    }
}
