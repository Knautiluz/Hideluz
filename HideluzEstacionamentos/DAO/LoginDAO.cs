using MySql.Data.MySqlClient;
using System;

namespace HideluzEstacionamentos.DAO
{
    public class LoginDAO : Connection
    {

        MySqlCommand command = null;

        public bool Select(Login login)
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand("SELECT count(*) FROM users WHERE username = @username and password = @password", connection);
                command.Parameters.AddWithValue("@username", login.Username);
                command.Parameters.AddWithValue("@password", login.Password);

                var count = command.ExecuteScalar();

                if (Convert.ToInt32(count) > 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
