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
                ClientDAO.UpdateClient(OldClient, UpdatedClient);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeVehicle(Vehicle vehicle)
        {
            return true;
        }

        public bool DeleteClient(Client client)
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
            var tunga = new DataTable();
            tunga.Load(ClientDAO.FillClientType());
            return tunga;
        }
    }
}
