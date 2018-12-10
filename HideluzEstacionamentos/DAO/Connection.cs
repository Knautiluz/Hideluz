using MySql.Data.MySqlClient;
using System;

namespace HideluzEstacionamentos.DAO
{
    public class Connection
    {
        string connString = "Server=hideluz.mysql.uhserver.com;Database=hideluz;Uid=hideko;Pwd=SwordMaster@10;";

        protected MySqlConnection connection = null;

        public void OpenConnection()
        {
            try
            {
                connection = new MySqlConnection(connString);
                connection.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection = new MySqlConnection(connString);
                connection.Close();
            }

            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
