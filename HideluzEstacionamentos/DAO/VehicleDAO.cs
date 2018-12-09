using HideluzEstacionamentos.Models;
using MySql.Data.MySqlClient;
using System;

namespace HideluzEstacionamentos.DAO
{
    public class VehicleDAO : Connection
    {
        public void CreateVehicle(Vehicle vehicle)
        {
            try
            {
                OpenConnection();

                MySqlCommand command = new MySqlCommand(
                            "INSERT INTO tb_veiculos (tx_placa, tx_modelo, tx_documento_cliente, id_tipo, fl_ativo)" +
                            "VALUES (@plate, @model, @documentOwner, @type, @status)", connection);
                command.Parameters.AddWithValue("@plate", vehicle.Plate);
                command.Parameters.AddWithValue("@model", vehicle.Model);
                command.Parameters.AddWithValue("@documentOwner", vehicle.OwnerDocument);
                command.Parameters.AddWithValue("@type", vehicle.IdType);
                command.Parameters.AddWithValue("@status", vehicle.Status);

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

        public bool CheckVehicleExists(Vehicle vehicle)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM tb_veiculos where tx_placa = @VehiclePlate LIMIT 1", connection);
                command.Parameters.AddWithValue("@VehiclePlate", vehicle.Plate);
                var count = Convert.ToInt32(command.ExecuteScalar());
                if (count >= 1) { return true; }
                else { return false; }
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

        public bool CheckOwnerExists(Vehicle vehicle)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM tb_clientes where tx_cpf = @OwnerDocument LIMIT 1", connection);
                command.Parameters.AddWithValue("@OwnerDocument", vehicle.OwnerDocument);
                var count = Convert.ToInt32(command.ExecuteScalar());
                if (count >= 1) { return true; }
                else { return false; }
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

        public MySqlDataReader FillVehicleType()
        {

            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_tipo_veiculo", connection);
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

        public MySqlDataReader FillParkedVehicles()
        {

            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT tb_registro.id, dt_entrada, tb_clientes.tx_nome, CONCAT(tb_tarifas.dl_preco, @Divisor ,tb_tipo_tarifa.tx_tipo) as tx_tipo_cliente_tarifa, tb_tipo_veiculo.tx_tipo, tb_registro.tx_placa_veiculo FROM tb_registro" +
                    " INNER JOIN tb_clientes ON tb_clientes.tx_cpf = tb_registro.tx_documento_cliente" +
                    " INNER JOIN tb_tarifas ON tb_registro.id_tarifa = tb_tarifas.id" +
                    " INNER JOIN tb_tipo_tarifa ON tb_tarifas.id_tipo_tarifa = tb_tipo_tarifa.id" +
                    " INNER JOIN tb_tipo_veiculo ON tb_tarifas.id_tipo_veiculo_tarifa = tb_tipo_veiculo.id" +
                    " WHERE dt_saida IS NULL; ", connection);
                command.Parameters.AddWithValue("@Divisor", " - ");
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

        public MySqlDataReader SelectAllVehicles()
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT tb_veiculos.id, tx_placa, tx_modelo, tx_documento_cliente, tx_tipo, fl_ativo, dt_criacao FROM tb_veiculos " +
                    "INNER JOIN tb_tipo_veiculo ON tb_veiculos.id_tipo = tb_tipo_veiculo.id; ", connection);
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

        public Vehicle SearchByPlate(Vehicle vehicle)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_veiculos where tx_placa = @VehiclePlate LIMIT 1", connection);
                command.Parameters.AddWithValue("@VehiclePlate", vehicle.Plate);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    vehicle.Plate = reader["tx_placa"].ToString();
                    vehicle.Model = reader["tx_modelo"].ToString();
                    vehicle.OwnerDocument = reader["tx_documento_cliente"].ToString();
                    vehicle.IdType = Convert.ToInt32(reader["id_tipo"].ToString());
                    vehicle.Status = Convert.ToBoolean(reader["fl_ativo"]);
                    vehicle.CreatedDate = Convert.ToDateTime(reader["dt_criacao"].ToString());
                }

                return vehicle;
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

        public void UpdateVehicle(Vehicle OldVehicle, Vehicle UpdatedVehicle)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("UPDATE tb_veiculos set tx_placa = @VehiclePlate, tx_modelo = @VehicleModel, tx_documento_cliente = @VehicleOwnerDocument," +
                    "id_tipo = @VehicleIdType, fl_ativo = @VehicleStatus WHERE tx_placa = @OldVehiclePlate", connection);
                command.Parameters.AddWithValue("@OldVehiclePlate", OldVehicle.Plate);
                command.Parameters.AddWithValue("@VehiclePlate", UpdatedVehicle.Plate);
                command.Parameters.AddWithValue("@VehicleModel", UpdatedVehicle.Model);
                command.Parameters.AddWithValue("@VehicleOwnerDocument", UpdatedVehicle.OwnerDocument);
                command.Parameters.AddWithValue("@VehicleIdType", UpdatedVehicle.IdType);
                command.Parameters.AddWithValue("@VehicleStatus", UpdatedVehicle.Status);

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

        public void DeleteVehicle(Vehicle vehicle)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("DELETE FROM tb_veiculos WHERE tx_placa = @VehiclePlate", connection);
                command.Parameters.AddWithValue("@VehiclePlate", vehicle.Plate);

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

        public MySqlDataReader FillVehicleList(int ClientID, int VehicleTypeID)
        {

            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT tb_veiculos.* FROM tb_veiculos" +
                    " INNER JOIN tb_clientes on tb_veiculos.tx_documento_cliente = tb_clientes.tx_cpf" +
                    " WHERE tb_clientes.id = @ClientID AND tb_veiculos.id_tipo = @VehicleTypeID", connection);
                command.Parameters.AddWithValue("@ClientID", ClientID);
                command.Parameters.AddWithValue("@VehicleTypeID", VehicleTypeID);
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

        public void AddVehicleEntrance(Client EntryClient, Vehicle EntryVehicle, Tax EntryTax)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO tb_registro (dt_entrada, tx_documento_cliente, tx_placa_veiculo, id_tarifa) " +
                    "VALUES (NOW(), @ClientDocument, @VehiclePlate, @TaxID)", connection);
                command.Parameters.AddWithValue("@ClientDocument", EntryClient.Document);
                command.Parameters.AddWithValue("@VehiclePlate", EntryVehicle.Plate);
                command.Parameters.AddWithValue("@TaxID", EntryTax.IdType);

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

        public bool CheckVehicleAlreadyParked(Vehicle vehicle)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM tb_registro WHERE tx_placa_veiculo = @VehiclePlate" +
                    " AND dt_saida IS NULL LIMIT 1", connection);
                command.Parameters.AddWithValue("@VehiclePlate", vehicle.Plate);
                var count = Convert.ToInt32(command.ExecuteScalar());
                if (count >= 1) { return false; }
                else { return true; }
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

        public void AddVehicleLeave(int RegistryID, string VehiclePlate, decimal TotalPrice)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("UPDATE tb_registro set dt_saida = now(), dl_total = @TotalPrice" +
                    " WHERE id = @RegistryID and tx_placa_veiculo = @VehiclePlate", connection);
                command.Parameters.AddWithValue("@TotalPrice", TotalPrice);
                command.Parameters.AddWithValue("@RegistryID", RegistryID);
                command.Parameters.AddWithValue("@VehiclePlate", VehiclePlate);

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
    }
}
