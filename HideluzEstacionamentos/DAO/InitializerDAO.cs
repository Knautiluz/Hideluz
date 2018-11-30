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
            finally
            {
                CloseConnection();
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
            finally
            {
                CloseConnection();
            }
        }

        public void InsertDefaultUserValues()
        {
            try
            {
                OpenConnection();
                MySqlCommand DefaultUserTypeAdmin = new MySqlCommand("INSERT INTO tb_tipo_usuario " +
                    "SELECT t.* " +
                    "FROM((SELECT 1 as col1, 'Administrador' as col2)) t " +
                    "WHERE NOT EXISTS(SELECT* FROM tb_tipo_usuario)", connection);

                MySqlCommand DefaultUserTypeOperator = new MySqlCommand("INSERT INTO tb_tipo_usuario " +
                    "SELECT t.* " +
                    "FROM((SELECT 2 as col1, 'Operador' as col2)) t " +
                    "WHERE NOT EXISTS(SELECT* FROM tb_tipo_usuario where tx_tipo != 'Administrador')", connection);

                DefaultUserTypeAdmin.ExecuteNonQuery();
                DefaultUserTypeOperator.ExecuteNonQuery();
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
            finally
            {
                CloseConnection();
            }
        }

        public void InsertDefaultClientValues()
        {
            try
            {
                OpenConnection();
                MySqlCommand DefaultClientTypeLoose = new MySqlCommand("INSERT INTO tb_tipo_cliente " +
                    "SELECT t.* " +
                    "FROM((SELECT 1 as col1, 'Avulso' as col2)) t " +
                    "WHERE NOT EXISTS(SELECT* FROM tb_tipo_cliente)", connection);

                MySqlCommand DefaultClientTypeMonthly = new MySqlCommand("INSERT INTO tb_tipo_cliente " +
                    "SELECT t.* " +
                    "FROM((SELECT 2 as col1, 'Mensalista' as col2)) t " +
                    "WHERE NOT EXISTS(SELECT* FROM tb_tipo_cliente where tx_tipo != 'Avulso')", connection);

                DefaultClientTypeLoose.ExecuteNonQuery();
                DefaultClientTypeMonthly.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                OpenConnection();
            }
        }

        public void CreateClientsTable()
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS `tb_clientes` (" +
                    "`id` int(11) NOT NULL AUTO_INCREMENT," +
                    "`tx_cpf` varchar(256) NOT NULL," +
                    "`tx_nome` varchar(256) NOT NULL," +
                    "`tx_email` varchar(256) NOT NULL," +
                    "`tx_telefone` varchar(256) NOT NULL," +
                    "`id_tipocliente` int(11) NOT NULL," +
                    "`tx_estado` varchar(256) NOT NULL," +
                    "`tx_cidade` varchar(256) NOT NULL," +
                    "`tx_bairro` varchar(256) NOT NULL," +
                    "`tx_rua` varchar(256) NOT NULL," +
                    "`tx_numero` varchar(256) NOT NULL," +
                    "`tx_cep` varchar(256) NOT NULL," +
                    "`fl_ativo` bit(1) NOT NULL," +
                    "`dt_criacao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP," +
                    "`dt_atualizacao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP," +
                    "PRIMARY KEY(`tx_cpf`)," +
                    "UNIQUE KEY `id_UNIQUE` (`id`)," +
                    "KEY `idTipoCliente_idx` (`id_tipocliente`)," +
                    "CONSTRAINT `idTipoCliente` FOREIGN KEY(`id_tipocliente`) REFERENCES `tb_tipo_cliente` (`id`))", connection);
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

        #endregion
    }
}
