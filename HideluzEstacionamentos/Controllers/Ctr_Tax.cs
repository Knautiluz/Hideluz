using System;
using HideluzEstacionamentos.Models;

namespace HideluzEstacionamentos.Controllers
{
    public class Ctr_Tax
    {
        Tax Tax = new Tax();

        public double CalculateTax(Tax tax)
        {
            var hours = Tax.DepartureTime.Hour - Tax.EntryTime.Hour;
            var minutes = Tax.DepartureTime.Minute - Tax.EntryTime.Minute;
            double total = ((hours * 60) + minutes) / 60;
            Math.Ceiling(total);
            var totaltax = Tax.PricePerHour * total;
            return totaltax;
        }
    }
}
