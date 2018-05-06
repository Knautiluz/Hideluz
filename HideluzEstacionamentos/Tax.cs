using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideluzEstacionamentos
{
    public class Tax
    {
        public string Id { get; set; }
        public double PricePerHour { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime DepartureTime { get; set; }

        public Tax()
        {
            // constructor
        }

        public double CalculateTax(double pricePerHour, DateTime entryTime, DateTime departureTime)
        {
            // lógica do método
            var hours = departureTime.Hour - entryTime.Hour;
            var minutes = departureTime.Minute - entryTime.Minute;
            double total = ((hours * 60) + minutes) / 60;
            Math.Ceiling(total);
            var totaltax = pricePerHour * total;
            return totaltax;
        }
    }
}
