using HideluzEstacionamentos.Models;

namespace HideluzEstacionamentos.Controllers
{
    public class Ctr_Operator
    {
        public bool AddClient(Client Client, Operator Operator)
        {
            return true;
        }

        public bool AddVehicle(Vehicle Vehicle, Operator Operator)
        {
            return true;
        }

        public bool ChangeClient(Client Client)
        {
            return true;
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
            return client;
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
    }
}
