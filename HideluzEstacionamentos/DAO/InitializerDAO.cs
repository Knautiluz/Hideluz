using MySql.Data.MySqlClient;
using System;

namespace HideluzEstacionamentos.DAO
{
    public class InitializerDAO : Connection
    {
        #region Users

        public void CreateUserTypeTable()
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS `tb_tipo_usuario` (" +
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
                MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS `tb_usuarios` (" +
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

        public void InsertDefaultUserValues()
        {
            try
            {
                OpenConnection();
                MySqlCommand DefaultUserTypeAdmin = new MySqlCommand("INSERT INTO tb_tipo_usuario" +
                    "SELECT t.*" +
                    "FROM((SELECT 1 as col1, 'Administrador' as col2)) t" +
                    "WHERE NOT EXISTS(SELECT* FROM tb_tipo_usuario)", connection);

                MySqlCommand DefaultUserTypeOperator = new MySqlCommand("INSERT INTO tb_tipo_usuario" +
                    "SELECT t.*" +
                    "FROM((SELECT 2 as col1, 'Operador' as col2)) t" +
                    "WHERE NOT EXISTS(SELECT* FROM tb_tipo_usuario where tx_tipo != 'Administrador')", connection);

                DefaultUserTypeAdmin.ExecuteNonQuery();
                DefaultUserTypeOperator.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        #endregion

        #region Clients

        public void CreateClientTypeTable()
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS `tb_tipo_cliente` (" +
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

        public void InsertDefaultClientValues()
        {
            try
            {
                OpenConnection();
                MySqlCommand DefaultClientTypeLoose = new MySqlCommand("INSERT INTO tb_tipo_cliente" +
                    "SELECT t.*" +
                    "FROM((SELECT 1 as col1, 'Avulso' as col2)) t" +
                    "WHERE NOT EXISTS(SELECT* FROM tb_tipo_cliente)", connection);

                MySqlCommand DefaultClientTypeMonthly = new MySqlCommand("INSERT INTO tb_tipo_cliente" +
                    "SELECT t.*" +
                    "FROM((SELECT 2 as col1, 'Mensalista' as col2)) t" +
                    "WHERE NOT EXISTS(SELECT* FROM tb_tipo_cliente where tx_tipo != 'Avulso')", connection);

                DefaultClientTypeLoose.ExecuteNonQuery();
                DefaultClientTypeMonthly.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        #endregion
    }
}
