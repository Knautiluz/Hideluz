using System;

namespace HideluzEstacionamentos.Models
{
    public class Client
    {
        public string Document { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int IdType { get; set; }
        public Address Address { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public Client()
        {
            Address = new Address();
        }
    }
}
