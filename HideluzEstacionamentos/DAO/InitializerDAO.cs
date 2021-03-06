﻿using MySql.Data.MySqlClient;
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

        #region Vehicles

        public void CreateVehicleTypeTable()
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS `tb_tipo_veiculo` (" +
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

        public void InsertDefaultVehicleValues()
        {
            try
            {
                OpenConnection();
                MySqlCommand DefaultClientTypeLoose = new MySqlCommand("INSERT INTO tb_tipo_veiculo " +
                    "SELECT t.* " +
                    "FROM((SELECT 1 as col1, 'Carro' as col2)) t " +
                    "WHERE NOT EXISTS(SELECT* FROM tb_tipo_veiculo)", connection);

                MySqlCommand DefaultClientTypeMonthly = new MySqlCommand("INSERT INTO tb_tipo_veiculo " +
                    "SELECT t.* " +
                    "FROM((SELECT 2 as col1, 'Motocicleta' as col2)) t " +
                    "WHERE NOT EXISTS(SELECT* FROM tb_tipo_veiculo where tx_tipo != 'Carro')", connection);

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

        public void CreateVehiclesTable()
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS `tb_veiculos` (" +
                    "`id` int(11) NOT NULL AUTO_INCREMENT," +
                    "`tx_placa` varchar(45) NOT NULL," +
                    "`tx_modelo` varchar(45) NOT NULL," +
                    "`tx_documento_cliente` varchar(45) NOT NULL," +
                    "`id_tipo` int(11) NOT NULL," +
                    "`fl_ativo` bit(1) NOT NULL," +
                    "`dt_criacao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP," +
                    "`dt_atualizacao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP," +
                    "PRIMARY KEY(`tx_placa`)," +
                    "UNIQUE KEY `id_UNIQUE` (`id`)," +
                    "KEY `IdTipoVeiculo_idx` (`id_tipo`)," +
                    "KEY `DocumentoVeiculoCliente_idx` (`tx_documento_cliente`)," +
                    "CONSTRAINT `DocumentoVeiculoCliente` FOREIGN KEY(`tx_documento_cliente`) REFERENCES `tb_clientes` (`tx_cpf`)," +
                    "CONSTRAINT `IdTipoVeiculo` FOREIGN KEY(`id_tipo`) REFERENCES `tb_tipo_veiculo` (`id`))", connection);
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

        #region Taxes

        public void CreateTaxesTypeTable()
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS `tb_tipo_tarifa` (" +
                    "`id` int(11) NOT NULL AUTO_INCREMENT," +
                    "`tx_tipo` varchar(256) NOT NULL," +
                    "PRIMARY KEY(`id`))");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void InsertDefaultTaxesValues()
        {
            try
            {
                OpenConnection();
                MySqlCommand DefaultClientTypeDaily = new MySqlCommand("INSERT INTO tb_tipo_tarifa " +
                    "SELECT t.* " +
                    "FROM((SELECT 1 as col1, 'Diária' as col2)) t " +
                    "WHERE NOT EXISTS(SELECT* FROM tb_tipo_tarifa)", connection);

                MySqlCommand DefaultClientTypeMonthly = new MySqlCommand("INSERT INTO tb_tipo_tarifa " +
                    "SELECT t.* " +
                    "FROM((SELECT 2 as col1, 'Mensal' as col2)) t " +
                    "WHERE NOT EXISTS(SELECT* FROM tb_tipo_tarifa where tx_tipo != 'Diária')", connection);

                MySqlCommand DefaultClientTypeHour = new MySqlCommand("INSERT INTO tb_tipo_tarifa " +
                    "SELECT t.* " +
                    "FROM((SELECT 3 as col1, 'Hora' as col2)) t " +
                    "WHERE NOT EXISTS(SELECT* FROM tb_tipo_tarifa where tx_tipo != 'Diária' and tx_tipo != 'Mensal')", connection);

                DefaultClientTypeDaily.ExecuteNonQuery();
                DefaultClientTypeMonthly.ExecuteNonQuery();
                DefaultClientTypeHour.ExecuteNonQuery();
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

        public void CreateTaxesTable()
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS `tb_tarifas` (" +
                    "`id` int(11) NOT NULL AUTO_INCREMENT," +
                    "`dl_preco` decimal(10, 0) NOT NULL," +
                    "`id_tipo_tarifa` int(11) NOT NULL," +
                    "`id_tipo_veiculo_tarifa` int(11) NOT NULL," +
                    "PRIMARY KEY(`id`)," +
                    "KEY `IdTipoTarifa_idx` (`id_tipo_tarifa`)," +
                    "KEY `IdTipoVeiculoTarifa_idx` (`id_tipo_veiculo_tarifa`)," +
                    "CONSTRAINT `IdTipoTarifa` FOREIGN KEY(`id_tipo_tarifa`) REFERENCES `tb_tipo_tarifa` (`id`)," +
                    "CONSTRAINT `IdTipoVeiculoTarifa` FOREIGN KEY(`id_tipo_veiculo_tarifa`) REFERENCES `tb_tipo_veiculo` (`id`))", connection);
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
