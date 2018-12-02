using HideluzEstacionamentos.DAO;
using System;

namespace HideluzEstacionamentos.Controllers
{
    public class InitializerController
    {
        InitializerDAO InitializerDAO = new InitializerDAO();

        #region Users Table

        public void CreateUsersTable()
        {
            InitializerDAO.CreateUsersTable();
        }

        public void CreateUserTypeTable()
        {
            InitializerDAO.CreateUserTypeTable();
        }

        public void InsertDefaultUsersValues()
        {
            InitializerDAO.InsertDefaultUserValues();
        }

        #endregion

        #region Clients Tables

        public void CreateClientTypeTable()
        {
            InitializerDAO.CreateClientTypeTable();
        }

        public void InsertDefaultClientValues()
        {
            InitializerDAO.InsertDefaultClientValues();
        }

        public void CreateClientsTable()
        {
            InitializerDAO.CreateClientsTable();
        }

        #endregion

        #region Vehicles Tables

        public void CreateVehicleTypeTable()
        {
            InitializerDAO.CreateVehicleTypeTable();
        }

        public void InsertDefaultVehicleValues()
        {
            InitializerDAO.InsertDefaultVehicleValues();
        }

        public void CreateVehiclesTable()
        {
            try
            {
                InitializerDAO.CreateVehiclesTable();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        #endregion
    }
}
