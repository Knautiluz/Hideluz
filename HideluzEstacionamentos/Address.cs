using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideluzEstacionamentos
{
    public class Address
    {
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string Cep { get; set; }

        public Address()
        {
            // constructor
        }
    }
}
