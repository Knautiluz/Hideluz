using System.Collections.Generic;
using System.Linq;

namespace HideluzEstacionamentos
{
    public class Operator
    {
        public string EmployeeRegistry { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }

        public Operator()
        {

        }
        public bool AddClient(Client client, string operatorId)
        {
            Connection con = new Connection();
            if(con.RunQuery(string.Format("SELECT COUNT(CPF) FROM CLIENTE WHERE CPF = '{0}'", client.Document), 0))
            {
                if (con.Rows > 0)
                {
                    RegisterClient.Operation = "O CPF informado já está cadastrado.";
                    return false;
                }
                else
                {
                    if(con.RunQuery(string.Format("INSERT INTO CLIENTE (CPF, NOME, ESTADO, CIDADE, BAIRRO, RUA, NUMERO, CEP, EMAIL, TELCONTATO, IDTIPOCLIENTE) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10})", client.Document, client.Name, client.Address.State, client.Address.City, client.Address.Neighborhood, client.Address.Street, client.Address.Number, client.Address.Cep, client.Email, client.Tel, client.Type), 2))
                    {
                        RegisterClient.Operation = "Usuário cadastrado com sucesso!";
                        return true;
                    }
                    else
                    {
                        RegisterClient.Operation = con.Message;
                        return false;
                    }
                }
            }
            else
            {
                RegisterClient.Operation = con.Message;
                return false;
            }
        }

        public bool AddVehicle(Vehicle vehicle, string operatorId)
        {
            Connection con = new Connection();
            if(con.RunQuery(string.Format("SELECT COUNT(CPF) FROM CLIENTE WHERE CPF = '{0}'", vehicle.OwnerDocument), 0))
            {
                if (con.Rows > 0)
                {
                    if (con.RunQuery(string.Format("INSERT INTO VEICULO (PLACA, MODELO, CLIENTE_CPF, STATUS, IDTIPOVEICULO) values ('{0}', '{1}', '{2}', {3}, {4})", vehicle.LicencePlate, vehicle.Model, vehicle.OwnerDocument, 1, vehicle.Type), 2))
                    {
                        RegisterVehicle.Operation = "Veículo cadastrado com sucesso!";
                        return true;
                    }
                    else
                    {
                        RegisterVehicle.Operation = con.Message;
                        return false;
                    }
                }
                else
                {
                    RegisterVehicle.Operation = "Esse cliente não está cadastrado, não foi possivel registrar o veículo.";
                    return false;
                }
            }
            else
            {
                RegisterVehicle.Operation = con.Message;
                return false;
            }
        }
        public bool ChangeClient(Client client, string doc)
        {
            Connection con = new Connection();
            if(con.RunQuery(string.Format("UPDATE CLIENTE SET CPF = '{0}', NOME = '{1}', ESTADO = '{2}', CIDADE = '{3}', BAIRRO = '{4}', RUA = '{5}', NUMERO = '{6}', CEP = '{7}', EMAIL = '{8}', TELCONTATO = '{9}', IDTIPOCLIENTE = {10} WHERE CPF = '{11}'", client.Document, client.Name, client.Address.State, client.Address.City, client.Address.Neighborhood, client.Address.Street, client.Address.Number, client.Address.Cep, client.Email, client.Tel, client.Type, doc), 3))
            {
                ModifyClient.Operation = "Cliente atualizado com sucesso!";
                return true;
            }
            else
            {
                ModifyClient.Operation = con.Message;
                return false;
            }
        }

        public bool ChangeVehicle(Vehicle vehicle, string plate)
        {
            Connection con = new Connection();
            if (con.RunQuery(string.Format("UPDATE VEICULO SET PLACA = '{0}', MODELO = '{1}', CLIENTE_CPF = '{2}', STATUS = {3}, IDTIPOVEICULO = {4} WHERE PLACA = '{5}'", vehicle.LicencePlate, vehicle.Model, vehicle.OwnerDocument, vehicle.Status, vehicle.Type, plate), 3))
            {
                ModifyVehicle.Operation = "Veículo atualizado com sucesso!";
                return true;
            }
            else
            {
                ModifyVehicle.Operation = con.Message;
                return false;
            }
        }
        public bool DeleteClient(string doc)
        {
            Connection con = new Connection();
            if(con.RunQuery(string.Format("SELECT COUNT(CPF) FROM CLIENTE WHERE CPF = '{0}'", doc), 0))
            {
                if (con.Rows > 0)
                {
                    if (con.RunQuery(string.Format("DELETE FROM CLIENTE WHERE CPF = '{0}'", doc), 4))
                    {
                        RemoveClient.Operation = "O cliente foi apagado!";
                        return true;
                    }
                    else
                    {
                        RemoveClient.Operation = con.Message;
                        return false;
                    }
                }
                else
                {
                    RemoveClient.Operation = "O CPF digitado não foi encontrado.";
                    return false;
                }
            }
            else
            {
                RemoveClient.Operation = con.Message;
                return false;
            }
        }

        public bool DeleteVehicle(string plate)
        {
            Connection con = new Connection();
            if(con.RunQuery(string.Format("SELECT COUNT(PLACA) FROM VEICULO WHERE PLACA = '{0}'", plate), 0))
            {
                if (con.Rows > 0)
                {
                    if (con.RunQuery(string.Format("DELETE FROM VEICULO WHERE PLACA = '{0}'", plate), 4))
                    {
                        RemoveVehicle.Operation = "O veículo foi apagado!";
                        return true;
                    }
                    else
                    {
                        RemoveVehicle.Operation = con.Message;
                        return false;
                    }
                }
                else
                {
                    RemoveVehicle.Operation = "A placa digitada não foi encontrada.";
                    return false;
                }
            }
            else
            {
                RemoveVehicle.Operation = con.Message;
                return false;
            }
        }
        public Dictionary<string, string> CheckClient(string document)
        {
            var results = new Dictionary<string, string>();
            Connection con = new Connection();
            if(con.RunQuery(string.Format("SELECT COUNT(*) FROM CLIENTE WHERE CPF = '{0}'", document), 0))
            {
                if (con.Rows < 1)
                {
                    SearchClient.Operation = "Não existe cliente cadastrado com o CPF informado.";
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
            else
            {
                SearchClient.Operation = con.Message;
                return results;
            }
        }

        public Dictionary<string, string> CheckVehicle(string plate)
        {
            var results = new Dictionary<string, string>();
            Connection con = new Connection();
            if(con.RunQuery(string.Format("SELECT COUNT(*) FROM VEICULO WHERE PLACA = '{0}'", plate), 0))
            {
                if (con.Rows < 1)
                {
                    SearchVehicle.Operation = "Não existe veículo cadastrado com a placa informada.";
                    return results;
                }
                con.RunQuery(string.Format("SELECT * FROM VEICULO WHERE PLACA = '{0}'", plate), 1);
                results.Add("PLACA", con.Fecth.Values.ElementAt(0));
                results.Add("MODELO", con.Fecth.Values.ElementAt(1));
                results.Add("CLIENTE_CPF", con.Fecth.Values.ElementAt(2));
                results.Add("STATUS", con.Fecth.Values.ElementAt(3));
                results.Add("TIPO", con.Fecth.Values.ElementAt(4));
                return results;
            }
            else
            {
                SearchVehicle.Operation = con.Message;
                return results;
            }
        }
        public Dictionary<string, string> CheckTax(int type)
        {
            var results = new Dictionary<string, string>();
            Connection con = new Connection();
            if(con.RunQuery(string.Format("SELECT * FROM PRECOTARIFA WHERE IDTIPOVEICULO = '{0}'", type), 1))
            {
                if (con.Rows > 0)
                {
                    results.Add(con.Fecth.Values.ElementAt(2), con.Fecth.Values.ElementAt(1));
                    return results;
                }
                else
                {
                    SearchTax.Operation = "Não existe tarifa cadastrada para este veículo.";
                    return results;
                }
            }
            else
            {
                SearchTax.Operation = con.Message;
                return results;
            }
        }
    }
}
