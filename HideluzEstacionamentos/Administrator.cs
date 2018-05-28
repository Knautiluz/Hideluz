using System.Collections.Generic;
using System.Linq;

namespace HideluzEstacionamentos
{
    //classe administrador herda tudo de operador, com as funções unicas que são de adicionar novos operadores e modificar as taxas
    public class Administrator : Operator
    {

        public Administrator()
        {

        }
        public bool AddTax(int type, float value)
        {
<<<<<<< HEAD
            //faz a verificação se a tarifa já existe e insere nova tarifa no banco de dados.
=======
>>>>>>> 9c289803da1ef3d38ee126b1662ad633efb0fb79
            return true;
        }
        public bool ChangeTax(int type, float value)
        {
<<<<<<< HEAD
            //altera a tarifa no banco de dados
=======
>>>>>>> 9c289803da1ef3d38ee126b1662ad633efb0fb79
            return true;
        }
        public bool DeleteTax(int type)
        {
<<<<<<< HEAD
            //verifica se a tarifa existe e se exister remove a tarifa no banco.
=======
>>>>>>> 9c289803da1ef3d38ee126b1662ad633efb0fb79
            return true;
        }
        public bool AddUser(User user, string operatorId)
        {
<<<<<<< HEAD
            //verifica se o usuário (operador) já existe e se não existir adiciona ele no banco de dados.
=======
>>>>>>> 9c289803da1ef3d38ee126b1662ad633efb0fb79
            return true;
        }
        public bool ChangeUser(User user, string doc)
        {
<<<<<<< HEAD
            //altera dados do usuário (operador) no banco de dados
            return true;
        }
        public User[] CheckUser(string document)
        {
            //faz consulta no banco pra saber quantos operadores existem e retorna o numero de linhas
            int rows = 1; // supondo que só tenha retornado 1
            var usuarios = new User[rows]; //istancia vetor com o numero de usuarios existentes
            //preenche o vetor de usuários com os dados recebidos e retorna o vetor de objeto usuario
            return usuarios;
        }
        public bool DeleteUser(string doc)
        {
            //verifica se existe usuário e se exister apaga do banco.
=======
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
>>>>>>> 9c289803da1ef3d38ee126b1662ad633efb0fb79
            return true;
        }
    }
}
