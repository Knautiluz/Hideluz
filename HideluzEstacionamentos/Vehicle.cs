using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideluzEstacionamentos
{
    public class Vehicle
    {
        public string LicencePlate { get; set; }
        public string Model { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public string OwnerDocument { get; set; }

        public Vehicle()
        {
            // constructor
        }
    }
}
