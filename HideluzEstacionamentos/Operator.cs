using System.Collections.Generic;
using System.Linq;

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
            //verifica se cliente já existe no banco e caso não exista adiciona um novo cliente.
            //se ouver algum erro ele será preenchido no form de origem da requisição atráves de um atributo public static string
            return true;
        }

        public bool AddVehicle(Vehicle vehicle, string operatorId)
        {
            //verifica se veículo já existe e adiciona um novo veículo no banco.
            //se ouver algum erro ele será preenchido no form de origem da requisição atráves de um atributo public static string
            return true;
        }
        public bool ChangeClient(Client client, string doc)
        {
            //altera o cliente no banco de dados
            //se ouver algum erro ele será preenchido no form de origem da requisição atráves de um atributo public static string
            return true;
        }

        public bool ChangeVehicle(Vehicle vehicle, string plate)
        {
            //altera o veículo no banco de dados
            //se ouver algum erro ele será preenchido no form de origem da requisição atráves de um atributo public static string
            return true;
        }
        public bool DeleteClient(string doc)
        {
            //verifica se cliente existe e se existir apaga
            //se ouver algum erro ele será preenchido no form de origem da requisição atráves de um atributo public static string
            return true;
        }

        public bool DeleteVehicle(string plate)
        {
            //verifica se veículo existe e se existir apaga.
            //se ouver algum erro ele será preenchido no form de origem da requisição atráves de um atributo public static string
            return true;
        }
        public Client[] CheckClient(string document)
        {
            //verifica os clientes no banco de dados e retorna o numero de linhas
            int rows = 1; //supondo que retornou 1 cliente
            var clients = new Client[rows]; //instancia clientes com o numero retornado do banco
            return clients; //retorna o vetor de clientes preenchidos com os dados do banco.            
        }

        public Vehicle[] CheckVehicle(string plate)
        {
            //verifica os veículos no banco de dados e retorna o numero de linhas
            int rows = 1; //supondo que retornou 1 veículo
            var vehicles = new Vehicle[rows]; //instancia clientes com o numero retornado do banco
            return vehicles; //retorna o vetor de veículos preenchidos com os dados do banco.            
        }
        public Tax[] CheckTax(int type)
        {
            //verifica as tarifas no banco de dados e retorna o numero de linhas
            int rows = 1; //supondo que retornou 1 tarifa
            var taxes = new Tax[rows]; //instancia tarifas com o numero retornado do banco
            return taxes; //retorna o vetor de tarifas preenchidos com os dados do banco.            
        }
    }
}
