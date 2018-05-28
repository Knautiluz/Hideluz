using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideluzEstacionamentos
{
    public class Vehicle
    {
        public string LicencePlate { get; set; }
        // placa do veículo
        public string Model { get; set; }
        // modelo do veículo
        public int Status { get; set; }
        // estado do veículo, se está ativo ou não
        public int Type { get; set; }
        // tipo do veículo, se é moto, carro...
        public string OwnerDocument { get; set; }
        // cpf do proprietário
        public Vehicle()
        {
            // constructor
        }
    }
}
