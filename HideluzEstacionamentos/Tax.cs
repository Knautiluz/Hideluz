using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideluzEstacionamentos
{
    public class Tax
    {
        public double PricePerHour { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime DepartureTime { get; set; }

        public Tax()
        {
            // constructor
        }

        public double CalculateTax(double PricePerHour, DateTime EntryTime, DateTime DepartureTime)
        {
            // lógica do método
            var hours = DepartureTime.Hour - EntryTime.Hour;
            var minutes = DepartureTime.Minute - EntryTime.Minute;
            double total = ((hours * 60) + minutes) / 60;
            Math.Ceiling(total);
            var totaltax = PricePerHour * total;
            return totaltax;
        }
    }
}
