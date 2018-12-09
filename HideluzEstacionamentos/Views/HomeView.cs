using HideluzEstacionamentos.Controllers;
using HideluzEstacionamentos.Models;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace HideluzEstacionamentos.Views
{
    public partial class HomeView : UserControl
    {
        OperatorController Controller = new OperatorController();
        Client SelectedClient = new Client();
        Vehicle SelectedVehicle = new Vehicle();

        public HomeView()
        {
            InitializeComponent();

            combo_ClientTypeEntry.DataSource = Controller.FillClientTable();
            combo_ClientTypeEntry.DisplayMember = "tx_nome";
            combo_ClientTypeEntry.ValueMember = "id";

            combo_VehicleTypeEntry.DataSource = Controller.FillVehicleType();
            combo_VehicleTypeEntry.DisplayMember = "tx_tipo";
            combo_VehicleTypeEntry.ValueMember = "id";

            dataGrid_ParkedVehicles.DataSource = Controller.FillParkedVehiclesTable();
            dataGrid_ParkedVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_ParkedVehicles.Columns[0].HeaderText = "id";
            dataGrid_ParkedVehicles.Columns[1].HeaderText = "Entrada";
            dataGrid_ParkedVehicles.Columns[2].HeaderText = "Cliente";
            dataGrid_ParkedVehicles.Columns[3].HeaderText = "Tipo Cliente";
            dataGrid_ParkedVehicles.Columns[4].HeaderText = "Tipo Veículo";
            dataGrid_ParkedVehicles.Columns[5].HeaderText = "Placa Veículo";
        }

        #region Buttons

        private void btn_EntranceSubmit_Click(object sender, EventArgs e)
        {
            Client EntryClient = new Client();
            Vehicle EntryVehicle = new Vehicle();
            Tax EntryTax = new Tax();
            EntryVehicle.Plate = combo_VehicleList.Enabled == true ? combo_VehicleList.Text : txt_VehiclePlate.Text;

            EntryClient = Controller.SearchClientById(Convert.ToInt32(combo_ClientTypeEntry.SelectedValue), EntryClient);
            EntryVehicle = Controller.CheckVehicle(EntryVehicle);
            EntryTax.IdType = Convert.ToInt32(combo_TaxTypeEntry.SelectedValue);

            if (CheckVehiclePlate(EntryVehicle))
            {
                try
                {
                    Controller.AddVehicleEntrance(EntryClient, EntryVehicle, EntryTax);
                    RefreshDataGrid();
                    UpdateReceiptEntry(EntryClient, EntryVehicle, EntryTax);
                }
                catch (Exception err)
                {
                    throw err;
                }
            }
            else
            {
                MessageBox.Show("Verifique se os campos foram preenchidos corretamente.");
            }
        }

        private void btn_SelectParkedVehicle_Click(object sender, EventArgs e)
        {
            DataRowView SelectedRow = (DataRowView)dataGrid_ParkedVehicles.CurrentRow?.DataBoundItem;
            if (!(SelectedRow == null))
            {
                PopulateFormLeaveReceipt(SelectedRow);
                btn_LeaveSubmit.Enabled = true;
            }
        }

        private void btn_LeaveSubmit_Click(object sender, EventArgs e)
        {
            var EntryTime = Convert.ToDateTime(txt_EntryTimeLeave.Text);
            var VehiclePlate = txt_VehiclePlateLeave.Text;
            var RegistryID = Convert.ToInt32(txt_ClientLeave.Text.Split('-')[0].Trim());
            var AuxTreatment = txt_TaxTypeLeave.Text.Split('-');
            var TaxPrice = decimal.Parse(AuxTreatment[0], CultureInfo.InvariantCulture);
            var TaxType = AuxTreatment[1].Trim();

            var total = Controller.TaxCalculator(EntryTime, TaxPrice, TaxType);

            try
            {
                Controller.AddVehicleLeave(RegistryID, VehiclePlate, total);
                RefreshDataGrid();
                UpdateReceiptLeave(VehiclePlate, total);
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        #endregion

        #region Buttons Events

        private void combo_ClientTypeEntry_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RefreshVehicleList();
        }

        private void combo_VehicleTypeEntry_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshVehicleList();
        }

        #endregion  

        #region Validators

        public bool CheckVehiclePlate(Vehicle EntryVehicle)
        {
            errorProvider1.Clear();
            errorProvider_OK.Clear();

            if (combo_VehicleList.Enabled == true)
            {
                if (!string.IsNullOrEmpty(combo_VehicleList.Text))
                {
                    if (Controller.CheckVehicleAlreadyParked(EntryVehicle))
                    {
                        errorProvider_OK.SetError(combo_VehicleList, "OK");
                        return true;
                    }
                    else
                    {
                        errorProvider1.SetError(combo_VehicleList, "Veículo já está estacionado.");
                        return false;
                    }
                }
                else
                {
                    errorProvider1.SetError(combo_VehicleList, "Selecione um veículo ou cadastre um na sessão de veículos caso não exista.");
                    return false;
                }
            }

            if (txt_VehiclePlate.Enabled == true)
            {
                if (!string.IsNullOrEmpty(txt_VehiclePlate.Text))
                {
                    if (Controller.CheckVehicleAlreadyParked(EntryVehicle))
                    {
                        errorProvider_OK.SetError(txt_VehiclePlate, "OK");
                        return true;
                    }
                    else
                    {
                        errorProvider1.SetError(txt_VehiclePlate, "Veículo já está estacionado.");
                        return false;
                    }
                }
                else
                {
                    errorProvider1.SetError(txt_VehiclePlate, "Preencha a placa do veículo.");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region GeneralMethods

        public void RefreshVehicleList()
        {
            if (!string.IsNullOrEmpty(combo_ClientTypeEntry.ValueMember))
            {
                var ClientID = Convert.ToInt32(combo_ClientTypeEntry.SelectedValue);
                var VehicleDefault = 1;
                var VehicleTypeID = int.TryParse(combo_VehicleTypeEntry.SelectedValue.ToString(), out VehicleDefault) ? combo_VehicleTypeEntry.SelectedValue : 1;
                if (ClientID > 1)
                {
                    txt_VehiclePlate.Enabled = false;
                    txt_VehiclePlate.Visible = false;
                    combo_VehicleList.Enabled = true;
                    combo_VehicleList.Visible = true;
                    lbl_VehiclePlate.Text = "Veículo";
                    Controller.SearchClientById(ClientID, SelectedClient);
                    combo_TaxTypeEntry.SelectedValue = SelectedClient.IdType;
                    combo_VehicleList.DataSource = Controller.FillVehicleList(ClientID, (int)VehicleTypeID);
                    combo_VehicleList.DisplayMember = "tx_placa";
                    combo_VehicleList.ValueMember = "id";
                }

                else
                {
                    txt_VehiclePlate.Enabled = true;
                    txt_VehiclePlate.Visible = true;
                    combo_VehicleList.Enabled = false;
                    combo_VehicleList.Visible = false;
                    lbl_VehiclePlate.Text = "Placa do Veículo";
                }

                combo_TaxTypeEntry.DataSource = Controller.FillTaxTypeComplete((int)VehicleTypeID);
                combo_TaxTypeEntry.DisplayMember = "tx_tipo";
                combo_TaxTypeEntry.ValueMember = "id";
            }
        }

        public void RefreshDataGrid()
        {
            dataGrid_ParkedVehicles.Refresh();
            dataGrid_ParkedVehicles.DataSource = Controller.FillParkedVehiclesTable();
        }

        public void UpdateReceiptEntry(Client EntryClient, Vehicle EntryVehicle, Tax EntryTax)
        {
            ReceiptPanel.Visible = true;
            var NowTime = DateTime.Now;

            lbl_ReceiptOperation.Text = "ENTRADA";
            lbl_ReceiptOperation.Location = new Point(58,47);
            lbl_HourReceipt.Text = NowTime.ToString("HH:mm");
            lbl_DateReceipt.Text = NowTime.ToString("dd/MM/yyyy");
            lbl_VehiclePlateReceipt.Text = EntryVehicle.Plate;
            lbl_TotalToPay.Visible = false;
            lbl_PricePay.Visible = false;
        }

        public void UpdateReceiptLeave(string VehiclePlate, decimal TotalPrice)
        {
            ReceiptPanel.Visible = true;
            var NowTime = DateTime.Now;

            lbl_ReceiptOperation.Text = "SAÍDA";
            lbl_ReceiptOperation.Location = new Point(74,47);
            lbl_HourReceipt.Text = NowTime.ToString("HH:mm");
            lbl_DateReceipt.Text = NowTime.ToString("dd/MM/yyyy");
            lbl_VehiclePlateReceipt.Text = VehiclePlate;
            lbl_TotalToPay.Visible = true;
            lbl_PricePay.Text = "R$ " + TotalPrice.ToString();
            lbl_PricePay.Visible = true;
        }

        private void PopulateFormLeaveReceipt(DataRowView SelectedRow)
        {
            txt_ClientLeave.Text = SelectedRow.Row.ItemArray[0].ToString() + " - " + SelectedRow.Row.ItemArray[2].ToString();
            txt_VehicleTypeLeave.Text = SelectedRow.Row.ItemArray[4].ToString();
            txt_TaxTypeLeave.Text = SelectedRow.Row.ItemArray[3].ToString();
            txt_VehiclePlateLeave.Text = SelectedRow.Row.ItemArray[5].ToString();
            txt_EntryTimeLeave.Text = SelectedRow.Row.ItemArray[1].ToString();
        }

        #endregion

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(panel_Receipt.Width, panel_Receipt.Height);
            panel_Receipt.DrawToBitmap(bm, new Rectangle(0, 0, panel_Receipt.Width, panel_Receipt.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btn_PrintReceipt_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.BringToFront();
            printPreviewDialog1.Show();
        }
    }
}
