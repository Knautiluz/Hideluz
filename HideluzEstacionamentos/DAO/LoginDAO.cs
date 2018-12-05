using HideluzEstacionamentos.Models;
using MySql.Data.MySqlClient;
using System;

namespace HideluzEstacionamentos.DAO
{
    public class LoginDAO : Connection
    {
        public bool CheckUser(Login inputLogin)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT count(*) FROM tb_usuarios WHERE tx_usuario = @username and tx_senha = @password LIMIT 1", connection);
                command.Parameters.AddWithValue("@username", inputLogin.Username);
                command.Parameters.AddWithValue("@password", inputLogin.Password);
                var count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    return true;
                }

                else { return false; }

            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public Login FillUserData(Login inputLogin)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_usuarios WHERE tx_usuario = @username and tx_senha = @password LIMIT 1", connection);
                command.Parameters.AddWithValue("@username", inputLogin.Username);
                command.Parameters.AddWithValue("@password", inputLogin.Password);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    inputLogin.Name = reader["tx_nome"].ToString();
                    inputLogin.IdType = Convert.ToInt32(reader["id_tipo"]);
                }
                return inputLogin;

            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
