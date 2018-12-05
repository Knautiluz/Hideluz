using System;

namespace HideluzEstacionamentos.Models
{
    public class Vehicle
    {
        public string Plate { get; set; }
        public string Model { get; set; }
        public string OwnerDocument { get; set; }
        public int IdType { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
