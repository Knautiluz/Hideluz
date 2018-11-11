using MySql.Data.MySqlClient;
using System;

namespace HideluzEstacionamentos.DAO
{
    public class ClientDAO : Connection
    {

        MySqlCommand command = null;

        public void Save(Client client)
        {
            try
            {
                OpenConnection();

                command = new MySqlCommand(
                            "INSERT INTO clientes (cpf, nome, estado, cidade, bairro, rua, numero, cep, email, telContato, idTipoCliente)" +
                            "VALUES (@document, @name, @state, @city, @neighborhood, @street, @number, @zipcode, @email, @phone, @type)", connection);
                command.Parameters.AddWithValue("@document", client.Document);
                command.Parameters.AddWithValue("@name", client.Name);
                command.Parameters.AddWithValue("@state", client.Email);
                command.Parameters.AddWithValue("@city", client.Address.City);
                command.Parameters.AddWithValue("@neighborhood", client.Address.Neighborhood);
                command.Parameters.AddWithValue("@street", client.Address.Street);
                command.Parameters.AddWithValue("@number", client.Address.Number);
                command.Parameters.AddWithValue("@zipcode", client.Address.ZIPCode);
                command.Parameters.AddWithValue("@email", client.Email);
                command.Parameters.AddWithValue("@phone", client.Phone);
                command.Parameters.AddWithValue("@type", client.IdType);

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

        public MySqlDataReader FillClientType()
        {

            try
            {
                OpenConnection();
                command = new MySqlCommand("SELECT * FROM tipocliente", connection);
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
