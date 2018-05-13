using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideluzEstacionamentos
{
    public class Operator
    {
        public string EmployeeRegistry { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }

        public Operator(string employeeRegistry, string name, int type)
        {
            EmployeeRegistry = employeeRegistry;
            Name = name;
            Type = type;
        }
        public bool AddUser(User user, string operatorId)
        {
            Connection con = new Connection();
            con.RunQuery(string.Format("SELECT COUNT(CPF) FROM USUARIO WHERE CPF = '{0}'", user.Document), 0);
            var result = con.Rows;
            if (result > 0)
            {
                RegisterUser.Operation = "O CPF informado já está cadastrado.";
                return false;
            }
            else
            {
                con.RunQuery(string.Format("INSERT INTO USUARIO (CPF, NOME, USUARIO, SENHA, STATUS, TIPOUSUARIO) values ('{0}', '{1}', '{2}', '{3}', {4}, {5})", user.Document, user.Name, user.Username, user.Password, 1, user.Type), 2);
                RegisterUser.Operation = "Usuário cadastrado com sucesso!";
                return true;
            }
        }
        public bool ModifyUser(User user, string operatorId)
        {
            Connection con = new Connection();
            return true;
        }
        public Dictionary<string, string> SearchUser(string document)
        {
            var results = new Dictionary<string, string>();
            Connection con = new Connection();
            con.RunQuery(string.Format("SELECT COUNT(*) FROM USUARIO WHERE CPF = '{0}'", document), 0);
            var result = con.Rows;
            if (result < 1)
            {
                return results;
            }
            con.RunQuery(string.Format("SELECT * FROM USUARIO WHERE CPF = '{0}'", document), 1);
            results.Add("CPF", con.Fecth.Values.ElementAt(0));
            results.Add("NOME", con.Fecth.Values.ElementAt(1));
            results.Add("USUARIO", con.Fecth.Values.ElementAt(2));
            results.Add("STATUS", con.Fecth.Values.ElementAt(4));
            results.Add("TIPO", con.Fecth.Values.ElementAt(5));
            return results;
        }
        public bool DeleteUser(string doc)
        {
            Connection con = new Connection();
            con.RunQuery(string.Format("SELECT COUNT(CPF) FROM USUARIO WHERE CPF = {0}", doc), 0);
            var result = con.Rows;
            if(result > 0)
            {
                con.RunQuery(string.Format("DELETE FROM USUARIO WHERE CPF = {0}", doc), 4);
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public bool AddClient(Client client, string operatorId)
        {
            Connection con = new Connection();
            try
            {
                con.RunQuery(string.Format("SELECT COUNT(CPF) FROM CLIENTE WHERE CPF = '{0}'", client.Document), 0);
                var result = con.Rows;
                if(result > 0)
                {
                    RegisterClient.Operation = "O CPF informado já está cadastrado.";
                    return false;
                }
                else
                {
                    con.RunQuery(string.Format("INSERT INTO CLIENTE (CPF, NOME, ESTADO, CIDADE, BAIRRO, RUA, NUMERO, CEP, EMAIL, TELCONTATO, IDTIPOCLIENTE) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10})", client.Document, client.Name, client.Address.State, client.Address.City, client.Address.Neighborhood, client.Address.Street, client.Address.Number, client.Address.Cep, client.Email, client.Tel, client.Type), 2);
                    RegisterClient.Operation = "Usuário cadastrado com sucesso!";
                    return true;
                }
            }
            catch(OracleException Ex)
            {
                Debug.Write(Ex.ToString());
                RegisterClient.Operation = "Ocorreu um erro interno no sistema, se persistir informe ao administrador.";
                return false;
            }
        }

        public void AddVehicle(Vehicle vehicle, string operatorId)
        {
            // method logic
        }

        public void AddTax(Tax tax)
        {
            // method logic
        }

        public void ModifyClient(Client client, string operatorId)
        {
            /*---------------------*/
            // search for client in SGBD
            /*---------------------*/
            if(client.Name != null)
            {
                // change in SGBD
            }
            if (client.Address != null)
            {
                // change in SGBD
            }
            if (client.Email != null)
            {
                // change in SGBD
            }

        }

        public void ModifyVehicle(Vehicle vehicle, string operatorId)
        {
            /*---------------------*/
            // search for client in SGBD
            /*---------------------*/
            if (vehicle.Model != null)
            {
                // change in SGBD
            }
            if (vehicle.Type != null)
            {
                // change in SGBD
            }
            if (vehicle.OwnerDocument != null)
            {
                // change in SGBD
            }
        }

        public void ModifyTax(Tax tax, string operatorId)
        {
            // method logic
        }

        public bool DeleteClient(string document)
        {
            // method logic
            return true;
        }

        public bool DeleteVehicle(string licencePlate)
        {
            // method logic
            return true;
        }

        public bool DeleteTax(string id)
        {
            // method logic
            return true;
        }

        public Dictionary<string, string> SearchClient(string document)
        {
            var results = new Dictionary<string, string>();
            Connection con = new Connection();
            con.RunQuery(string.Format("SELECT COUNT(*) FROM CLIENTE WHERE CPF = '{0}'", document), 0);
            var result = con.Rows;
            if(result < 1)
            {
                return results;
            }
            con.RunQuery(string.Format("SELECT * FROM CLIENTE WHERE CPF = '{0}'", document), 1);
            results.Add("CPF", con.Fecth.Values.ElementAt(0));
            results.Add("NOME", con.Fecth.Values.ElementAt(1));
            results.Add("ESTADO", con.Fecth.Values.ElementAt(2));
            results.Add("CIDADE", con.Fecth.Values.ElementAt(3));
            results.Add("BAIRRO", con.Fecth.Values.ElementAt(4));
            results.Add("RUA", con.Fecth.Values.ElementAt(5));
            results.Add("NUMERO", con.Fecth.Values.ElementAt(6));
            results.Add("CEP", con.Fecth.Values.ElementAt(7));
            results.Add("EMAIL", con.Fecth.Values.ElementAt(8));
            results.Add("TELEFONE", con.Fecth.Values.ElementAt(9));
            return results;
        }

        public string SearchVehicle(string licencePlate)
        {
            // method logic
            return "Veículo";
        }

        public string SearchTax(string id)
        {
            // method logic
            return "Tarifa";
        }

        public List<string> ParkedVehicles()
        {
            var ParkedVehicles = new List<string>();
            // method logic
            return ParkedVehicles;
        }
    }
}
