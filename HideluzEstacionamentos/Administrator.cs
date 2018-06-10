using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            //método que adiciona uma tarifa, recebe como parametro o tipo de tarifa (carro ou moto...) e o valor.
            MessageBox.Show("Método que adiciona uma tarifa, recebe como parametro o tipo de tarifa (carro ou moto...) e o valor.");
            return true;
        }
        public bool ChangeTax(int type, float value)
        {
            //método que altera uma tarifa, recebe como parametro o tipo de tarifa (carro ou moto...) e o valor.
            MessageBox.Show("Método que altera uma tarifa, recebe como parametro o tipo de tarifa (carro ou moto...) e o valor.");
            return true;
        }
        public bool DeleteTax(int type)
        {
            //método que deleta tarifa, recebe como parametro uma tarifa.
            MessageBox.Show("Método que deleta tarifa, recebe como parametro uma tarifa.");
            return true;
        }
        public bool AddUser(User user)
        {
            //método que adiciona um novo usuário, recebe como parametro o objeto usuário
            MessageBox.Show("Método que adiciona um novo usuário, recebe como parametro o objeto usuário.");
            return true;
        }
        public bool ChangeUser(User user)
        {
            //método que altera um usuário, recebe como parametro o objeto usuário.
            MessageBox.Show("Método que altera um usuário, recebe como parametro o objeto usuário.");
            return true;
        }
        public User CheckUser(string userId)
        {
            User user = new User();
            //método que verifica os dados do usuário, recebe como parametro o id do usuário.
            MessageBox.Show("Método que verifica os dados do usuário, recebe como parametro o documento o id do usuário.");
            return user;
        }
        public bool DeleteUser(string userId)
        {
            //método que deleta um usuário, recebe como parametro id do usuário.
            MessageBox.Show("Método que deleta um usuário, recebe como parametro id do usuário.");
            return true;
        }
    }
}
