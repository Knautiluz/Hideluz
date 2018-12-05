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
    }
}
