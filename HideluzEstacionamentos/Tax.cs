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

        public double CalculateTax(double PricePerHour, TimeSpan EntryTime, TimeSpan DepartureTime)
        {
            // lógica do método
            return 0.1;
        }
    }
}
