using System.Collections.Generic;
using System.Linq;

namespace HideluzEstacionamentos
{
    public class Administrator : Operator
    {

        public Administrator()
        {

        }
        public bool AddTax(int type, float value)
        {
            return true;
        }
        public bool ChangeTax(int type, float value)
        {
            return true;
        }
        public bool DeleteTax(int type)
        {
            return true;
        }
        public bool AddUser(User user, string operatorId)
        {
            return true;
        }
        public bool ChangeUser(User user, string doc)
        {
            return true;
        }
        public Client[] CheckUser(string document)
        {
            //recebe o numero de clientes do banco
            int num_clients = 1;
            //instancia um vetor de clientes com os clientes recebidos do banco
            Client[] clients = new Client[num_clients];
            //adiciona os clientes no vetor e retorna o vetor de clientes;
            return clients;
        }
        public bool DeleteUser(string doc)
        {
            return true;
        }
    }
}
