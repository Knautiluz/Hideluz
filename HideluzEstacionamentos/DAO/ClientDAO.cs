using HideluzEstacionamentos.Models;
using MySql.Data.MySqlClient;
using System;

namespace HideluzEstacionamentos.DAO
{
    public class ClientDAO : Connection
    {

        public void Save(Client client)
        {
            try
            {
                OpenConnection();

                MySqlCommand command = new MySqlCommand(
                            "INSERT INTO tb_clientes (tx_cpf, tx_nome, tx_email, tx_telefone, id_tipocliente, tx_estado, tx_cidade, tx_bairro, tx_rua, tx_numero, tx_cep, fl_ativo)" +
                            "VALUES (@document, @name, @email, @phone, @type, @state, @city, @neighborhood, @street, @number, @zipcode, @status)", connection);
                command.Parameters.AddWithValue("@document", client.Document);
                command.Parameters.AddWithValue("@name", client.Name);
                command.Parameters.AddWithValue("@email", client.Email);
                command.Parameters.AddWithValue("@phone", client.Phone);
                command.Parameters.AddWithValue("@type", client.IdType);
                command.Parameters.AddWithValue("@state", client.Address.State);
                command.Parameters.AddWithValue("@city", client.Address.City);
                command.Parameters.AddWithValue("@neighborhood", client.Address.Neighborhood);
                command.Parameters.AddWithValue("@street", client.Address.Street);
                command.Parameters.AddWithValue("@number", client.Address.Number);
                command.Parameters.AddWithValue("@zipcode", client.Address.ZIPCode);
                command.Parameters.AddWithValue("@status", 1);

                command.ExecuteNonQuery();
            }

            catch (Exception err)
            {
                throw err;
            }

            finally
            {
                CloseConnection();
            }
        }

        public Client SearchByDocument(Client client)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_clientes where tx_cpf = @ClientDocument LIMIT 1", connection);
                command.Parameters.AddWithValue("@ClientDocument", client.Document);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    client.Document = reader["tx_cpf"].ToString();
                    client.Name = reader["tx_nome"].ToString();
                    client.Email = reader["tx_email"].ToString();
                    client.Phone = reader["tx_telefone"].ToString();
                    client.IdType = Convert.ToInt32(reader["id_tipocliente"].ToString());
                    client.Address.State = reader["tx_estado"].ToString();
                    client.Address.City = reader["tx_cidade"].ToString();
                    client.Address.Neighborhood = reader["tx_bairro"].ToString();
                    client.Address.Street = reader["tx_rua"].ToString();
                    client.Address.Number = reader["tx_numero"].ToString();
                    client.Address.ZIPCode = reader["tx_cep"].ToString();
                    client.CreatedDate = Convert.ToDateTime(reader["dt_criacao"].ToString());
                    client.Status = Convert.ToBoolean(reader["fl_ativo"]);
                }

                return client;
            }
            catch (Exception err)
            {

                throw err;
            }
            finally
            {
                CloseConnection();
            }
        }

        public MySqlDataReader SelectAllClients()
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT tb_clientes.id, tx_cpf, tx_nome, tx_email, tx_telefone, tx_tipo, tx_estado," +
                    "tx_cidade, tx_bairro, tx_rua, tx_numero, tx_cep, fl_ativo, dt_criacao FROM tb_clientes " +
                    "inner join tb_tipo_cliente on tb_tipo_cliente.id = tb_clientes.id_tipocliente;", connection);
                MySqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void UpdateClient(Client OldClient, Client UpdatedClient)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("UPDATE tb_clientes set tx_cpf = @ClientDocument, tx_nome = @ClientName, tx_email = @ClientEmail," +
                    "tx_telefone = @ClientPhone, id_tipocliente = @ClientType, tx_estado = @ClientState, tx_cidade = @ClientCity," +
                    "tx_bairro = @ClientNeighborhood, tx_rua = @ClientStreet, tx_numero = @ClientNumber, tx_cep = @ClientZIPCode," +
                    "fl_ativo = @ClientStatus WHERE tx_cpf = @OldClientDocument", connection);
                command.Parameters.AddWithValue("@OldClientDocument", OldClient.Document);
                command.Parameters.AddWithValue("@ClientDocument", UpdatedClient.Document);
                command.Parameters.AddWithValue("@ClientName", UpdatedClient.Name);
                command.Parameters.AddWithValue("@ClientEmail", UpdatedClient.Email);
                command.Parameters.AddWithValue("@ClientPhone", UpdatedClient.Phone);
                command.Parameters.AddWithValue("@ClientType", UpdatedClient.IdType);
                command.Parameters.AddWithValue("@ClientState", UpdatedClient.Address.State);
                command.Parameters.AddWithValue("@ClientCity", UpdatedClient.Address.City);
                command.Parameters.AddWithValue("@ClientNeighborhood", UpdatedClient.Address.Neighborhood);
                command.Parameters.AddWithValue("@ClientStreet", UpdatedClient.Address.Street);
                command.Parameters.AddWithValue("@ClientNumber", UpdatedClient.Address.Number);
                command.Parameters.AddWithValue("@ClientZIPCode", UpdatedClient.Address.ZIPCode);
                command.Parameters.AddWithValue("@ClientStatus", UpdatedClient.Status);

                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {

                throw err;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void DeleteClient(Client client)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("DELETE FROM tb_clientes WHERE tx_cpf = @ClientDocument", connection);
                command.Parameters.AddWithValue("@ClientDocument", client.Document);

                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool CheckClientExists(Client client)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM tb_clientes where tx_cpf = @ClientDocument LIMIT 1", connection);
                command.Parameters.AddWithValue("@ClientDocument", client.Document);
                var count = Convert.ToInt32(command.ExecuteScalar());
                if (count >= 1) { return true; }
                else { return false; }
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                CloseConnection();
            }
        }

        public MySqlDataReader FillClientType()
        {

            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_tipo_cliente", connection);
                MySqlDataReader reader = command.ExecuteReader();
                return reader;
            }

            catch (Exception err)
            {
                throw err;
            }

            finally
            {
                CloseConnection();
            }

        }
    }
}
