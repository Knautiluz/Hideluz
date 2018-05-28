using System;

namespace HideluzEstacionamentos
{
    public class Tax
    {
        public string Id { get; set; }
        // qual o tipo da taxa, se é de carro, moto
        public double PricePerHour { get; set; }
        // preço por hora da taxa
        public DateTime EntryTime { get; set; }
        // hora de entrada no estacionamento
        public DateTime DepartureTime { get; set; }
        // hora de saída do estacionamento

        public Tax()
        {
            // constructor
        }

        public double CalculateTax(double pricePerHour, DateTime entryTime, DateTime departureTime)
        {
            // lógica que vai calcular a taxa
            var hours = departureTime.Hour - entryTime.Hour;
            var minutes = departureTime.Minute - entryTime.Minute;
            double total = ((hours * 60) + minutes) / 60;
            Math.Ceiling(total);
            var totaltax = pricePerHour * total;
            return totaltax;
        }
    }
}
