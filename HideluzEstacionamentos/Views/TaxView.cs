using HideluzEstacionamentos.Controllers;
using HideluzEstacionamentos.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace HideluzEstacionamentos.Views
{
    public partial class TaxView : UserControl
    {
        OperatorController Controller = new OperatorController();
        Tax tax = new Tax();
        Tax UpdatedTax = new Tax();

        public TaxView()
        {
            InitializeComponent();
            combo_VehicleType.DataSource = Controller.FillVehicleType();
            combo_VehicleType.DisplayMember = "tx_tipo";
            combo_VehicleType.ValueMember = "id";

            combo_TaxType.DataSource = Controller.FillTaxType();
            combo_TaxType.DisplayMember = "tx_tipo";
            combo_TaxType.ValueMember = "id";

            dataGrid_AllTaxes.DataSource = Controller.FillTaxTable();
            dataGrid_AllTaxes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_AllTaxes.Columns[0].HeaderText = "id";
            dataGrid_AllTaxes.Columns[1].HeaderText = "Preço";
            dataGrid_AllTaxes.Columns[2].HeaderText = "Tipo Tarifa";
            dataGrid_AllTaxes.Columns[3].HeaderText = "Tipo Veículo";
        }

        #region Buttons

        private void btn_RegisterSubmit_Click(object sender, System.EventArgs e)
        {
            Tax tax = new Tax();
            tax.IdType = Convert.ToInt32(combo_TaxType.SelectedValue);
            tax.Price = num_TaxPrice.Value;
            tax.IdVehicleType = Convert.ToInt32(combo_VehicleType.SelectedValue);

            if (PriceValidator())
            {
                try
                {
                    Controller.AddTax(tax);
                    MessageBox.Show("Tarifa Cadastrada com Sucesso!");

                    combo_TaxType.SelectedValue = 1;
                    num_TaxPrice.Value = 0;
                    combo_VehicleType.SelectedValue = 1;
                    RefreshDataGrid();
                }

                catch (Exception)
                {
                    MessageBox.Show("Ocorreu algum erro ao tentar adicionar a Tarifa.");
                }
            }
        }

        private void btn_SelectVehicle_Click(object sender, System.EventArgs e)
        {
            DataRowView SelectedRow = (DataRowView)dataGrid_AllTaxes.CurrentRow?.DataBoundItem;
            if (!(SelectedRow == null))
            {
                tax = Controller.RowConverterTax(SelectedRow, tax);
                PopulateFormTax(tax);
                btn_UpdateTax.Enabled = true;
                btn_DeleteTax.Enabled = true;
            }
        }

        private void btn_UpdateTax_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja salvar as alterações?", "Atualizar Tarifa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (PriceValidator())
                {
                    UpdatedTax.Id = Convert.ToInt32(txt_TaxID.Text);
                    UpdatedTax.IdType = Convert.ToInt32(combo_TaxType.SelectedValue);
                    UpdatedTax.Price = num_TaxPrice.Value;
                    UpdatedTax.IdVehicleType = Convert.ToInt32(combo_VehicleType.SelectedValue);

                    if (Controller.UpdateTax(tax, UpdatedTax))
                    {
                        MessageBox.Show("Tarifa atualizada!");
                        btn_UpdateTax.Enabled = false;
                        btn_DeleteTax.Enabled = false;
                        RefreshDataGrid();
                        ClearFields();
                    }
                }
            }
        }

        private void btn_DeleteTax_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir esse cliente?", "Excluir Tarifa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (Controller.DeleteTax(tax))
                {
                    ClearFields();
                    MessageBox.Show("Tarifa excluida");
                    RefreshDataGrid();
                    btn_UpdateTax.Enabled = false;
                    btn_DeleteTax.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ocorreu um problema ao excluir a tarifa");
                }

            }
        }

        #endregion

        #region Validators

        public bool PriceValidator()
        {
            errorProvider1.Clear();
            errorProvider_OK.Clear();

            if (num_TaxPrice.Value == 0)
            {
                errorProvider1.SetError(num_TaxPrice, "Preencha um valor maior que zero.");
                return false;
            }

            else
            {
                errorProvider_OK.SetError(num_TaxPrice, "OK");
                return true;
            }
        }

        #endregion

        #region GeneralMethods

        private void PopulateFormTax(Tax SelectedTax)
        {
            txt_TaxID.Text = SelectedTax.Id.ToString();
            combo_TaxType.SelectedValue = SelectedTax.IdType;
            num_TaxPrice.Value = SelectedTax.Price;
            combo_VehicleType.SelectedValue = SelectedTax.IdVehicleType;
        }

        public void RefreshDataGrid()
        {
            dataGrid_AllTaxes.Refresh();
            dataGrid_AllTaxes.DataSource = Controller.FillTaxTable();
        }

        private void ClearFields()
        {
            txt_TaxID.Clear();
            combo_TaxType.SelectedValue = 1;
            num_TaxPrice.Value = 0;
            combo_VehicleType.SelectedValue = 1;
        }

        #endregion
    }
}
