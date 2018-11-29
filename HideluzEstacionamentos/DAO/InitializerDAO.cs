using MySql.Data.MySqlClient;
using System;

namespace HideluzEstacionamentos.DAO
{
    public class InitializerDAO : Connection
    {
        MySqlCommand command = null;

        public void CreateUserTypeTable()
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand("CREATE TABLE IF NOT EXISTS `tb_tipo_cliente` (" +
                    "`id` int(11) NOT NULL AUTO_INCREMENT," +
                    "`tx_tipo` varchar(256) NOT NULL," +
                    "PRIMARY KEY(`id`))", connection);
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void CreateUsersTable()
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand("CREATE TABLE IF NOT EXISTS `tb_usuarios` (" +
                    "`id` int(11) NOT NULL AUTO_INCREMENT," +
                    "`tx_nome` varchar(45) NOT NULL," +
                    "`tx_usuario` varchar(45) NOT NULL," +
                    "`tx_senha` varchar(45) NOT NULL," +
                    "`dt_criacao` timestamp NULL DEFAULT CURRENT_TIMESTAMP," +
                    "`id_tipo` int(11) NOT NULL," +
                    "PRIMARY KEY(`tx_usuario`)," +
                    "UNIQUE KEY `id_UNIQUE` (`id`)," +
                    "KEY `idTipoUsuario_idx` (`id_tipo`)," +
                    "CONSTRAINT `idTipoUsuario` FOREIGN KEY(`id_tipo`) REFERENCES `tb_tipo_usuario` (`id`))", connection);
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
