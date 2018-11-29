using HideluzEstacionamentos.Models;
using HideluzEstacionamentos.DAO;
using System;
using System.Data;

namespace HideluzEstacionamentos.Controllers
{
    public class OperatorController
    {
        /* Instancia ClientDAO */
        ClientDAO ClientDAO = new ClientDAO();

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

        public bool AddVehicle(Vehicle Vehicle, Operator Operator)
        {
            return true;
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

        public bool ChangeVehicle(Vehicle vehicle)
        {
            return true;
        }

        public bool DeleteVehicle(Vehicle vehicle)
        {
            return true;
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

        public Vehicle CheckVehicle(string plate)
        {
            var vehicle = new Vehicle();
            return vehicle;
        }

        public Tax CheckTax(int type)
        {
            var tax = new Tax();
            return tax;
        }

        public Vehicle[] ParkedVehicles()
        {
            var vehicles = new Vehicle[500];
            return vehicles;
        }

        public DataTable FillType()
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

        public Client RowConverter(DataRowView SelectedRow, Client client)
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
    }
}
