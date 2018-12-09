using HideluzEstacionamentos.DAO;
using HideluzEstacionamentos.Models;
using System;
using System.Data;

namespace HideluzEstacionamentos.Controllers
{
    public class OperatorController
    {
        /* Instancia ClientDAO */
        ClientDAO ClientDAO = new ClientDAO();
        VehicleDAO VehicleDAO = new VehicleDAO();
        TaxDAO TaxDAO = new TaxDAO();

        #region Client Controller

        public bool AddClient(Client Client)
        {
            try
            {
                ClientDAO.Save(Client);
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool UpdateClient(Client OldClient, Client UpdatedClient)
        {
            if (OldClient != UpdatedClient)
            {
                try
                {
                    ClientDAO.UpdateClient(OldClient, UpdatedClient);
                    return true;
                }
                catch (Exception err)
                {

                    throw err;
                }
            }
            else
            {
                return false;
            }
        }

        public bool DeleteClient(Client client)
        {
            try
            {
                ClientDAO.DeleteClient(client);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Client CheckClient(Client client)
        {
            try
            {
                ClientDAO.SearchByDocument(client);
                return client;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable FillClientType()
        {
            DataTable ClientTypes = new DataTable();
            ClientTypes.Load(ClientDAO.FillClientType());
            return ClientTypes;
        }

        public DataTable FillClientTable()
        {
            DataTable AllClients = new DataTable();
            AllClients.Load(ClientDAO.SelectAllClients());
            return AllClients;
        }

        public bool CheckClientExists(Client client)
        {
            if (ClientDAO.CheckClientExists(client)) { return true; }
            else { return false; }
        }

        public Client RowConverterClient(DataRowView SelectedRow, Client client)
        {
            client.Document = SelectedRow.Row.ItemArray[1].ToString();
            client.Name = SelectedRow.Row.ItemArray[2].ToString();
            client.Email = SelectedRow.Row.ItemArray[3].ToString();
            client.Phone = SelectedRow.Row.ItemArray[4].ToString();
            client.IdType = SelectedRow.Row.ItemArray[5].ToString() == "Avulso" ? 1 : 2;
            client.Address.State = SelectedRow.Row.ItemArray[6].ToString();
            client.Address.City = SelectedRow.Row.ItemArray[7].ToString();
            client.Address.Neighborhood = SelectedRow.Row.ItemArray[8].ToString();
            client.Address.Street = SelectedRow.Row.ItemArray[9].ToString();
            client.Address.Number = SelectedRow.Row.ItemArray[10].ToString();
            client.Address.ZIPCode = SelectedRow.Row.ItemArray[11].ToString();
            client.Status = Convert.ToBoolean(SelectedRow.Row.ItemArray[12]);
            client.CreatedDate = Convert.ToDateTime(SelectedRow.Row.ItemArray[13].ToString());

            return client;
        }

        public Client SearchClientById(int ClientID, Client client)
        {
            try
            {
                return ClientDAO.SearchClientById(ClientID, client);
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        #endregion

        #region Vehicle Controller

        public void AddVehicle(Vehicle vehicle)
        {
            try
            {
                VehicleDAO.CreateVehicle(vehicle);
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public bool CheckVehicleExists(Vehicle vehicle)
        {
            if (VehicleDAO.CheckVehicleExists(vehicle)) { return true; }
            else { return false; }
        }

        public bool CheckOwnerExists(Vehicle vehicle)
        {
            if (VehicleDAO.CheckOwnerExists(vehicle)) { return true; }
            else { return false; }
        }

        public DataTable FillVehicleType()
        {
            DataTable VehicleTypes = new DataTable();
            VehicleTypes.Load(VehicleDAO.FillVehicleType());
            return VehicleTypes;
        }

        public DataTable FillVehicleTable()
        {
            DataTable AllVehicles = new DataTable();
            AllVehicles.Load(VehicleDAO.SelectAllVehicles());
            return AllVehicles;
        }

        public Vehicle CheckVehicle(Vehicle vehicle)
        {
            try
            {
                VehicleDAO.SearchByPlate(vehicle);
                return vehicle;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool UpdateVehicle(Vehicle OldVehicle, Vehicle UpdatedVehicle)
        {
            if (CheckOwnerExists(OldVehicle))
            {

                if (OldVehicle != UpdatedVehicle)
                {
                    try
                    {
                        VehicleDAO.UpdateVehicle(OldVehicle, UpdatedVehicle);
                        return true;
                    }
                    catch (Exception err)
                    {

                        throw err;
                    }
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public bool DeleteVehicle(Vehicle vehicle)
        {
            try
            {
                VehicleDAO.DeleteVehicle(vehicle);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Vehicle RowConverterVehicle(DataRowView SelectedRow, Vehicle vehicle)
        {
            vehicle.Plate = SelectedRow.Row.ItemArray[1].ToString();
            vehicle.Model = SelectedRow.Row.ItemArray[2].ToString();
            vehicle.OwnerDocument = SelectedRow.Row.ItemArray[3].ToString();
            vehicle.IdType = SelectedRow.Row.ItemArray[4].ToString() == "Carro" ? 1 : 2;
            vehicle.Status = Convert.ToBoolean(SelectedRow.Row.ItemArray[5]);
            vehicle.CreatedDate = Convert.ToDateTime(SelectedRow.Row.ItemArray[6].ToString());

            return vehicle;
        }

        public DataTable FillParkedVehiclesTable()
        {
            DataTable ParkedVehicles = new DataTable();
            ParkedVehicles.Load(VehicleDAO.FillParkedVehicles());
            return ParkedVehicles;
        }

        public DataTable FillVehicleList(int ClientID, int VehicleTypeID)
        {
            DataTable VehicleList = new DataTable();
            VehicleList.Load(VehicleDAO.FillVehicleList(ClientID, VehicleTypeID));
            return VehicleList;
        }

        public void AddVehicleEntrance(Client EntryClient, Vehicle EntryVehicle, Tax EntryTax)
        {
            try
            {
                VehicleDAO.AddVehicleEntrance(EntryClient, EntryVehicle, EntryTax);
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public bool CheckVehicleAlreadyParked(Vehicle vehicle)
        {
            try
            {
                return VehicleDAO.CheckVehicleAlreadyParked(vehicle);
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public void AddVehicleLeave(int RegistryID, string VehiclePlate, decimal TotalPrice)
        {
            try
            {
                VehicleDAO.AddVehicleLeave(RegistryID, VehiclePlate, TotalPrice);
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        #endregion

        #region Tax Controller

        public void AddTax(Tax tax)
        {
            try
            {
                TaxDAO.CreateTax(tax);
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public bool UpdateTax(Tax OldTax, Tax UpdatedTax)
        {

            if (OldTax != UpdatedTax)
            {
                try
                {
                    TaxDAO.UpdateTax(OldTax, UpdatedTax);
                    return true;
                }
                catch (Exception err)
                {

                    throw err;
                }
            }
            else
            {
                return false;
            }
        }

        public bool DeleteTax(Tax tax)
        {
            try
            {
                TaxDAO.DeleteTax(tax);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable FillTaxType()
        {
            DataTable TaxesType = new DataTable();
            TaxesType.Load(TaxDAO.FillTaxType());
            return TaxesType;
        }

        public DataTable FillTaxTable()
        {
            DataTable AllTaxes = new DataTable();
            AllTaxes.Load(TaxDAO.SelectAllTaxes());
            return AllTaxes;
        }

        public Tax RowConverterTax(DataRowView SelectedRow, Tax tax)
        {
            tax.Id = Convert.ToInt32(SelectedRow.Row.ItemArray[0]);
            tax.Price = Convert.ToDecimal(SelectedRow.Row.ItemArray[1]);
            tax.IdType = (SelectedRow.Row.ItemArray[2].ToString() == "Diária") ? 1 : (SelectedRow.Row.ItemArray[2].ToString() == "Mensal") ? 2 : 3;
            tax.IdVehicleType = SelectedRow.Row.ItemArray[3].ToString() == "Carro" ? 1 : 2;

            return tax;
        }

        public DataTable FillTaxTypeComplete(int VehicleTypeID)
        {
            DataTable TaxesType = new DataTable();
            TaxesType.Load(TaxDAO.FillTaxTypeComplete(VehicleTypeID));
            return TaxesType;
        }

        public decimal TaxCalculator(DateTime EntryTime, decimal TaxPrice, string TaxType)
        {
            if (TaxType == "Diária")
            {
                return TaxPrice;
            }

            if (TaxType == "Hora")
            {
                decimal hours = DateTime.Now.Hour - EntryTime.Hour;
                decimal minutes = DateTime.Now.Minute - EntryTime.Minute;
                decimal total = ((hours * 60) + minutes) / 60;
                total = Math.Ceiling(total);
                if (total == 0) { return TaxPrice; }
                else { return TaxPrice * total; }
            }
            else
            {
                return TaxPrice;
            }
        }

        #endregion

    }
}
