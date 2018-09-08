using System;

namespace HideluzEstacionamentos.Models
{
    public class Tax
    {
        public string Id { get; set; }
        public double PricePerHour { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}
