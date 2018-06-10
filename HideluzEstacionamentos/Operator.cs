using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public class Operator
    {
        public string EmployeeRegistry { get; set; }
        //registro do empregado
        public string Name { get; set; }
        //nome do empregado
        public int Type { get; set; }
        //tipo do empregado, se é operador ou adm

        public Operator()
        {

        }
        public bool AddClient(Client client, string operatorId)
        {
            //método que adiciona um novo cliente, que recebe como parametro o objeto cliente e o id do operador que fez o registro.
            MessageBox.Show("Esse é o método que adiciona o cliente.");
            return true;
        }

        public bool AddVehicle(Vehicle vehicle, string operatorId)
        {
            //método que adiciona um novo veículo, que recebe como parametro o objeto veículo e o id do operador que fez o registro.
            MessageBox.Show("Esse é o método que adiciona o veículo.");
            return true;
        }
        public bool ChangeClient(Client client)
        {
            //método que altera o cliente, que recebe como parametro o objeto cliente.
            MessageBox.Show("Esse é o método que altera o cliente.");
            return true;
        }

        public bool ChangeVehicle(Vehicle vehicle)
        {
            //método que altera um veículo, que recebe como parametro o objeto veículo.
            MessageBox.Show("Esse é o método que altera o veículo.");
            return true;
        }
        public bool DeleteClient(string doc)
        {
            //método que deleta um cliente, recebe como parametro o documento do cliente.
            MessageBox.Show("Esse é o método que deleta o cliente.");
            return true;
        }

        public bool DeleteVehicle(string plate)
        {
            //método que deleta o veículo, que recebe como parametro a placa do veículo.
            MessageBox.Show("Esse é o método que deleta o veículo.");
            return true;
        }
        public Client CheckClient(string document)
        {
            var client = new Client();
            //método usado para verificar um veículo, que recebe como parametro o documento do cliente.
            MessageBox.Show("Esse é o método que verifica o cliente.");
            return client;
        }

        public Vehicle CheckVehicle(string plate)
        {
            var vehicle = new Vehicle();
            //método usado para verificar um veículo, que recebe como parametro a placa do veículo.
            MessageBox.Show("Esse é o método que verifica o veículo.");
            return vehicle;
        }
        public Tax CheckTax(int type)
        {
            var tax = new Tax();
            //método usado para verificar uma tarifa, que recebe como parametro o tipo da tarifa, se é de carro ou moto ou ect...
            MessageBox.Show("Esse é o método que verifica a tarifa.");
            return tax;
        }
        public Vehicle[] ParkedVehicles()
        {
            //retorna o numero de veículos marcados como estacionados no banco.
            var vehicles = new Vehicle[500]; 
            MessageBox.Show("Esse é o método que retorna os veículos marcados como estacionados.");
            return vehicles; //retorna o vetor de veículos preenchidos com os dados do banco.
        }
    }
}
