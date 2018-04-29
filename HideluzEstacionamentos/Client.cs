using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideluzEstacionamentos
{
    public class Client
    {
        public string Document { get; set; }
        public string Name { get; set; }
        Address Address = new Address();
        public string Email { get; set; }
        public string Type { get; set; }

        public Client()
        {
            // constructor
        }
    }
}
