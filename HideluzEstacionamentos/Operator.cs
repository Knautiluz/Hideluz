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

        public Operator(string employeeRegistry, string name, string email, Address address = null)
        {
            EmployeeRegistry = employeeRegistry;
            Name = name;
            Email = email;
            Address = address;
        }

        public void AddClient(Client client, string operatorId)
        {
            // method logic
        }

        public void AddVehicle(Vehicle vehicle, string operatorId)
        {
            // method logic
        }

        public void AddTax(Tax tax)
        {
            // method logic
        }

        public void ModifyClient(Client client, string operatorId)
        {
            /*---------------------*/
            // search for client in SGBD
            /*---------------------*/
            if(client.Name != null)
            {
                // change in SGBD
            }
            if (client.Address != null)
            {
                // change in SGBD
            }
            if (client.Email != null)
            {
                // change in SGBD
            }
            if (client.Type != null)
            {
                // change in SGBD
            }

        }

        public void ModifyVehicle(Vehicle vehicle, string operatorId)
        {
            /*---------------------*/
            // search for client in SGBD
            /*---------------------*/
            if (vehicle.Model != null)
            {
                // change in SGBD
            }
            if (vehicle.Type != null)
            {
                // change in SGBD
            }
            if (vehicle.OwnerDocument != null)
            {
                // change in SGBD
            }
        }

        public void ModifyTax(Tax tax, string operatorId)
        {
            // method logic
        }

        public bool DeleteClient(string document)
        {
            // method logic
            return true;
        }

        public bool DeleteVehicle(string licencePlate)
        {
            // method logic
            return true;
        }

        public bool DeleteTax(string id)
        {
            // method logic
            return true;
        }

        public string SearchClient(string document)
        {
            // method logic
            return "Cliente";
        }

        public string SearchVehicle(string licencePlate)
        {
            // method logic
            return "Veículo";
        }

        public string SearchTax(string id)
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
