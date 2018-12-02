using HideluzEstacionamentos.Controllers;
using HideluzEstacionamentos.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace HideluzEstacionamentos.Views
{
    public partial class VehicleView : UserControl
    {
        OperatorController Controller = new OperatorController();
        Vehicle vehicle = new Vehicle();
        Vehicle UpdatedVehicle = new Vehicle();

        public VehicleView()
        {
            InitializeComponent();
            combo_VehicleType.DataSource = Controller.FillVehicleType();
            combo_VehicleType.DisplayMember = "tx_tipo";
            combo_VehicleType.ValueMember = "id";
            dataGrid_AllVehicles.DataSource = Controller.FillVehicleTable();
            dataGrid_AllVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_AllVehicles.Columns[0].HeaderText = "id";
            dataGrid_AllVehicles.Columns[1].HeaderText = "Placa Veículo";
            dataGrid_AllVehicles.Columns[2].HeaderText = "Modelo";
            dataGrid_AllVehicles.Columns[3].HeaderText = "Documento Cliente";
            dataGrid_AllVehicles.Columns[4].HeaderText = "Tipo do Veículo";
            dataGrid_AllVehicles.Columns[5].HeaderText = "Ativo";
            dataGrid_AllVehicles.Columns[6].HeaderText = "Data Criação";
        }

        #region Buttons

        private void btn_RegisterSubmit_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Plate = txt_VehiclePlate.Text;
            vehicle.Model = txt_VehicleModel.Text;
            vehicle.OwnerDocument = txt_VehicleDocumentOwner.Text;
            vehicle.IdType = Convert.ToInt32(combo_VehicleType.SelectedValue);

            if (GeneralValidator())
            {
                try
                {
                    Controller.AddVehicle(vehicle);
                    MessageBox.Show("Veículo Cadastrado com Sucesso!");

                    txt_VehiclePlate.Clear();
                    txt_VehicleModel.Clear();
                    txt_VehicleDocumentOwner.Clear();
                    RefreshDataGrid();
                }

                catch (Exception)
                {
                    MessageBox.Show("Ocorreu algum erro ao tentar adicionar o veículo.");
                }
            }
        }

        private void btn_VehicleSearch_Click(object sender, EventArgs e)
        {
            vehicle.Plate = txt_SearchInformation.Text;
            if (InputValidator())
            {
                try
                {
                    vehicle = Controller.CheckVehicle(vehicle);
                    FillVehicleInfo(vehicle);
                    btn_UpdateSubmit.Enabled = true;
                    btn_DeleteVehicle.Enabled = true;
                }
                catch (Exception err)
                {
                    throw err;
                }
            }
            else { btn_UpdateSubmit.Enabled = false; }
        }

        private void btn_UpdateSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja salvar as alterações?", "Atualizar Veículo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (DocumentOwnerValidator())
                {
                    errorProvider1.Clear();
                    errorProvider_OK.Clear();
                    UpdatedVehicle.Plate = txt_VehiclePlate.Text;
                    UpdatedVehicle.Model = txt_VehicleModel.Text;
                    UpdatedVehicle.OwnerDocument = txt_VehicleDocumentOwner.Text;
                    UpdatedVehicle.IdType = Convert.ToInt32(combo_VehicleType.SelectedValue);
                    UpdatedVehicle.Status = check_VehicleStatus.Checked ? true : false;

                    if (Controller.UpdateVehicle(vehicle, UpdatedVehicle))
                    {
                        MessageBox.Show("Veículo atualizado!");
                        btn_UpdateSubmit.Enabled = false;
                        btn_DeleteVehicle.Enabled = false;
                        RefreshDataGrid();
                        ClearFields();
                    }
                }
            }
        }

        private void btn_DeleteVehicle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir esse cliente?", "Excluir Veículo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (Controller.DeleteVehicle(vehicle))
                {
                    ClearFields();
                    MessageBox.Show("Veículo excluido");
                    RefreshDataGrid();
                    btn_UpdateSubmit.Enabled = false;
                    btn_DeleteVehicle.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ocorreu um problema ao excluir o veículo");
                }

            }
        }

        private void btn_SelectVehicle_Click(object sender, EventArgs e)
        {
            DataRowView SelectedRow = (DataRowView)dataGrid_AllVehicles.CurrentRow?.DataBoundItem;
            if (!(SelectedRow == null))
            {
                vehicle = Controller.RowConverterVehicle(SelectedRow, vehicle);
                PopulateFormVehicle(vehicle);
                btn_UpdateSubmit.Enabled = true;
                btn_DeleteVehicle.Enabled = true;
            }
        }

        #endregion

        #region Validators

        private bool PlateValidator()
        {
            if (!string.IsNullOrEmpty(txt_VehiclePlate.TextNoFormatting()) && txt_VehiclePlate.TextNoFormatting().Length >= 7)
            {
                vehicle.Plate = txt_VehiclePlate.Text;
                if (!Controller.CheckVehicleExists(vehicle))
                {
                    errorProvider_OK.SetError(txt_VehiclePlate, "OK");
                    return true;
                }
                else
                {
                    errorProvider1.SetError(txt_VehiclePlate, "Veículo já cadastrado");
                    return false;
                }
            }

            if (txt_VehiclePlate.TextNoFormatting().Length < 14)
            {
                if (string.IsNullOrEmpty(txt_VehiclePlate.TextNoFormatting()))
                {
                    errorProvider1.SetError(txt_VehiclePlate, "Preencha o campo.");
                    return false;
                }

                else
                {
                    errorProvider1.SetError(txt_VehiclePlate, "Informe uma placa válida");
                    return false;
                }
            }
            return false;
        }

        private bool ModelValidator()
        {
            if (!string.IsNullOrEmpty(txt_VehicleModel.Text))
            {
                errorProvider_OK.SetError(txt_VehicleModel, "OK");
                return true;
            }

            if (string.IsNullOrEmpty(txt_VehicleModel.Text))
            {
                errorProvider1.SetError(txt_VehicleModel, "Preencha o campo");
            }
            return false;
        }

        private bool DocumentOwnerValidator()
        {
            if (!string.IsNullOrEmpty(txt_VehicleDocumentOwner.TextNoFormatting()) && txt_VehicleDocumentOwner.TextNoFormatting().Length >= 11)
            {
                vehicle.OwnerDocument = txt_VehicleDocumentOwner.Text;
                if (!Controller.CheckOwnerExists(vehicle))
                {
                    errorProvider1.SetError(txt_VehicleDocumentOwner, "Documento não pertence a um cliente.");
                    return false;
                }
                else
                {
                    errorProvider_OK.SetError(txt_VehicleDocumentOwner, "OK");
                    return true;
                }
            }

            if (txt_VehicleDocumentOwner.TextNoFormatting().Length < 14)
            {
                if (string.IsNullOrEmpty(txt_VehicleDocumentOwner.TextNoFormatting()))
                {
                    errorProvider1.SetError(txt_VehicleDocumentOwner, "Preencha o campo.");
                    return false;
                }

                else
                {
                    errorProvider1.SetError(txt_VehicleDocumentOwner, "Informe um CPF válido");
                    return false;
                }
            }
            return false;
        }

        private bool GeneralValidator()
        {
            errorProvider1.Clear();
            errorProvider_OK.Clear();
            int falses = 0;

            if (!PlateValidator()) { falses += 1; }
            if (!ModelValidator()) { falses += 1; }
            if (!DocumentOwnerValidator()) { falses += 1; }

            if (falses > 0) { return false; }
            else { return true; }
        }

        private bool InputValidator()
        {
            errorProvider1.Clear();
            errorProvider_OK.Clear();
            ClearFields();

            if (!string.IsNullOrEmpty(txt_SearchInformation.TextNoFormatting()) && txt_SearchInformation.TextNoFormatting().Length >= 7)
            {
                if (Controller.CheckVehicleExists(vehicle))
                {
                    errorProvider_OK.SetError(txt_SearchInformation, "OK");
                    return true;
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider_OK.Clear();
                    errorProvider1.SetError(txt_SearchInformation, "Veículo não cadastrado.");
                    return false;
                }
            }

            if (txt_SearchInformation.TextNoFormatting().Length < 14)
            {
                if (string.IsNullOrEmpty(txt_SearchInformation.TextNoFormatting()))
                {
                    errorProvider1.SetError(txt_SearchInformation, "Preencha o campo.");
                    return false;
                }

                else
                {
                    errorProvider1.SetError(txt_SearchInformation, "Informe um CPF válido");
                    return false;
                }
            }
            return false;
        }

        #endregion

        #region GeneralMethods

        public void RefreshDataGrid()
        {
            dataGrid_AllVehicles.Refresh();
            dataGrid_AllVehicles.DataSource = Controller.FillVehicleTable();
        }

        private void PopulateFormVehicle(Vehicle SelectedVehicle)
        {
            txt_VehiclePlate.Text = SelectedVehicle.Plate;
            txt_VehicleModel.Text = SelectedVehicle.Model;
            txt_VehicleDocumentOwner.Text = SelectedVehicle.OwnerDocument;
            combo_VehicleType.SelectedValue = SelectedVehicle.IdType;
            check_VehicleStatus.Checked = SelectedVehicle.Status;
        }

        private void FillVehicleInfo(Vehicle vehicle)
        {
            txt_VehiclePlate.Text = vehicle.Plate;
            txt_VehicleModel.Text = vehicle.Model;
            txt_VehicleDocumentOwner.Text = vehicle.OwnerDocument;
            combo_VehicleType.SelectedValue = vehicle.IdType;
            check_VehicleStatus.Checked = vehicle.Status;
        }

        private void ClearFields()
        {
            txt_VehiclePlate.Clear();
            txt_VehicleModel.Clear();
            txt_VehicleDocumentOwner.Clear();
            txt_VehicleDocumentOwner.Clear();
            combo_VehicleType.SelectedValue = 1;
        }

        #endregion
    }
}
