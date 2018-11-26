using MySql.Data.MySqlClient;
using System;

namespace HideluzEstacionamentos.DAO
{
    public class InitializerDAO : Connection
    {
        MySqlCommand command = null;

        public void CreateUsersTable()
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand("CREATE TABLE IF NOT EXISTS `users` (" +
                    "`id` int(11) UNIQUE KEY AUTO_INCREMENT NOT NULL," +
                    "`username` varchar(45) PRIMARY KEY NOT NULL," +
                    "`password` varchar(45) NOT NULL," +
                    "`created_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP" +
                    ")", connection);

                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
