using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideluzEstacionamentos
{
    public class Operator
    {
        public string EmployeeRegistry { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        Address Address = new Address();

        public Operator()
        {
            // constructor
        }

        public void AddClient(string Document, string Name, Address Address, string Email, string Type)
        {
            // method logic
        }

        public void AddVehicle(string LicencePlate, string Model, string Type, string OwnerDocument)
        {
            // method logic
        }

        public void AddTax(double PricePerHour, string Type)
        {
            // method logic
        }

        public void ModifyClient(string Document)
        {
            // method logic
        }

        public void ModifyVehicle(string LicencePlate)
        {
            // method logic
        }

        public void ModifyTax()
        {
            // method logic
        }

        public bool DeleteClient(string Document)
        {
            // method logic
            return true;
        }

        public bool DeleteVehicle(string LicencePlate)
        {
            // method logic
            return true;
        }

        public bool DeleteTax(string Id)
        {
            // method logic
            return true;
        }

        public string SearchClient(string Document)
        {
            // method logic
            return "Cliente";
        }

        public string SearchVehicle(string LicencePlate)
        {
            // method logic
            return "Veículo";
        }

        public string SearchTax(string ID)
        {
            // method logic
            return "Tarifa";
        }

        public List<string> ParkedVehicles()
        {
            var ParkedVehicles = new List<string>();
            // method logic
            return ParkedVehicles;
        }
    }
}
