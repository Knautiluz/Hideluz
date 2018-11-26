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
                            "INSERT INTO clientes (tx_cpf, tx_nome, tx_email, tx_telefone, id_tipocliente, tx_estado, tx_cidade, tx_bairro, tx_rua, tx_numero, tx_cep, fl_ativo)" +
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
