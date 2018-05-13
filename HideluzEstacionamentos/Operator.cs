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
            OracleConnection Connection = new OracleConnection
            {
                ConnectionString = "User Id=system;Password=1234;Data Source=127.0.0.1:1521"
            };
            Connection.Open();
            OracleCommand Insert = Connection.CreateCommand();
            Insert.CommandText = "INSERT INTO USUARIO (CPF, NOME, USUARIO, SENHA, STATUS, TIPOUSUARIO) values (:cpf, :nome, :usuario, :senha, :status, :tipo)";
            OracleParameter[] parametersList = new OracleParameter[]
            {
                new OracleParameter("cpf", user.Document),
                new OracleParameter("nome", user.Name),
                new OracleParameter("usuario", user.Username),
                new OracleParameter("senha", user.Password),
                new OracleParameter("status", 1),
                new OracleParameter("tipo", user.Type)
            };
            Insert.Parameters.AddRange(parametersList);
            try
            {
                OracleCommand SelectCount = Connection.CreateCommand();
                SelectCount.CommandText = "SELECT COUNT(CPF) FROM USUARIO WHERE CPF = :cpf";
                SelectCount.Parameters.Add("cpf", user.Document);
                var result = SelectCount.ExecuteScalar();
                if (int.Parse(result.ToString()) > 0)
                {
                    RegisterUser.Operation = "O CPF informado já está cadastrado.";
                    return false;
                }
                else
                {
                    Insert.ExecuteNonQuery();
                    RegisterUser.Operation = "Usuário cadastrado com sucesso!";
                    return true;
                }
            }
            catch (OracleException Ex)
            {
                Debug.Write(Ex.ToString());
                RegisterUser.Operation = "Ocorreu um erro interno no sistema, se persistir informe ao administrador.";
                return false;
            }
        }
        public bool ModifyUser(User user, string operatorId)
        {
            OracleConnection Connection = new OracleConnection
            {
                ConnectionString = "User Id=system;Password=1234;Data Source=127.0.0.1:1521"
            };
            Connection.Open();
            OracleCommand Update = Connection.CreateCommand();
            // falta criar o resto do comando
            return true;
        }
        public Dictionary<string, string> SearchUser(string document)
        {
            var results = new Dictionary<string, string>();
            OracleConnection Connection = new OracleConnection
            {
                ConnectionString = "User Id=system;Password=1234;Data Source=127.0.0.1:1521"
            };
            Connection.Open();
            OracleCommand SelectCount = Connection.CreateCommand();
            SelectCount.CommandText = "SELECT COUNT(*) FROM USUARIO WHERE CPF = :cpf";
            SelectCount.Parameters.Add("cpf", document);
            var result = SelectCount.ExecuteScalar();
            if (int.Parse(result.ToString()) < 1)
            {
                return results;
            }
            OracleCommand Select = Connection.CreateCommand();
            Select.CommandText = "SELECT * FROM USUARIO WHERE CPF = :cpf";
            Select.Parameters.Add("cpf", document);
            OracleDataReader Reader = Select.ExecuteReader();
            while (Reader.Read())
            {
                results.Add("CPF", Reader.GetValue(0).ToString());
                results.Add("NOME", Reader.GetValue(1).ToString());
                results.Add("USUARIO", Reader.GetValue(2).ToString());
                results.Add("STATUS", Reader.GetValue(4).ToString());
                results.Add("TIPO", Reader.GetValue(5).ToString());
            }
            return results;
        }
        public bool DeleteUser(string doc)
        {
            OracleConnection Connection = new OracleConnection
            {
                ConnectionString = "User Id=system;Password=1234;Data Source=127.0.0.1:1521"
            };
            Connection.Open();
            OracleCommand SelectCount = Connection.CreateCommand();
            SelectCount.CommandText = "SELECT COUNT(CPF) FROM USUARIO WHERE CPF = :cpf";
            SelectCount.Parameters.Add("cpf", doc);
            var result = SelectCount.ExecuteScalar();
            if(int.Parse(result.ToString()) > 0)
            {
                OracleCommand Delete = Connection.CreateCommand();
                Delete.CommandText = "DELETE FROM USUARIO WHERE CPF = :cpf";
                Delete.Parameters.Add("cpf", doc);
                Delete.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public bool AddClient(Client client, string operatorId)
        {
            OracleConnection Connection = new OracleConnection
            {
                ConnectionString = "User Id=system;Password=1234;Data Source=127.0.0.1:1521"
            };
            Connection.Open();
            OracleCommand Insert = Connection.CreateCommand();
            Insert.CommandText = "INSERT INTO CLIENTE (CPF, NOME, ESTADO, CIDADE, BAIRRO, RUA, NUMERO, CEP, EMAIL, TELCONTATO, IDTIPOCLIENTE) values (:cpf, :nome, :estado, :cidade, :bairro, :rua, :numero, :cep, :email, :tel, :tipo)";
            OracleParameter[] parametersList = new OracleParameter[]
            {
                new OracleParameter("cpf", client.Document),
                new OracleParameter("nome", client.Name),
                new OracleParameter("estado", client.Address.State),
                new OracleParameter("cidade", client.Address.City),
                new OracleParameter("bairro", client.Address.Neighborhood),
                new OracleParameter("rua", client.Address.Street),
                new OracleParameter("numero", client.Address.Number),
                new OracleParameter("cep", client.Address.Cep),
                new OracleParameter("email", client.Email),
                new OracleParameter("tel", client.Tel),
                new OracleParameter("tipo", client.Type)

            };
            Insert.Parameters.AddRange(parametersList);
            try
            {
                OracleCommand SelectCount = Connection.CreateCommand();
                SelectCount.CommandText = "SELECT COUNT(CPF) FROM CLIENTE WHERE CPF = :cpf";
                SelectCount.Parameters.Add("cpf", client.Document);
                var result = SelectCount.ExecuteScalar();
                if(int.Parse(result.ToString()) > 0)
                {
                    RegisterClient.Operation = "O CPF informado já está cadastrado.";
                    return false;
                }
                else
                {
                    Insert.ExecuteNonQuery();
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
            OracleConnection Connection = new OracleConnection
            {
                ConnectionString = "User Id=system;Password=1234;Data Source=127.0.0.1:1521"
            };
            Connection.Open();
            OracleCommand SelectCount = Connection.CreateCommand();
            SelectCount.CommandText = "SELECT COUNT(*) FROM CLIENTE WHERE CPF = :cpf";
            SelectCount.Parameters.Add("cpf", document);
            var result = SelectCount.ExecuteScalar();
            if(int.Parse(result.ToString()) < 1)
            {
                return results;
            }
            OracleCommand Select = Connection.CreateCommand();
            Select.CommandText = "SELECT * FROM CLIENTE WHERE CPF = :cpf";
            Select.Parameters.Add("cpf", document);
            OracleDataReader Reader = Select.ExecuteReader();
            while(Reader.Read())
            {
                results.Add("CPF", Reader.GetValue(0).ToString());
                results.Add("NOME", Reader.GetValue(1).ToString());
                results.Add("ESTADO", Reader.GetValue(2).ToString());
                results.Add("CIDADE", Reader.GetValue(3).ToString());
                results.Add("BAIRRO", Reader.GetValue(4).ToString());
                results.Add("RUA", Reader.GetValue(5).ToString());
                results.Add("NUMERO", Reader.GetValue(6).ToString());
                results.Add("CEP", Reader.GetValue(7).ToString());
                results.Add("EMAIL", Reader.GetValue(8).ToString());
                results.Add("TELEFONE", Reader.GetValue(9).ToString());
            }
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
