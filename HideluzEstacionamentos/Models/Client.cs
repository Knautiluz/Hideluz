using HideluzEstacionamentos.Models;

namespace HideluzEstacionamentos
{
    public class Client
    {
        public string Document { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int IdType { get; set; }
        public Address Address { get; set; }

        public Client()
        {
            Address Address = new Address();
            this.Address = Address;
        }
    }
}
