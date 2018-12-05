using HideluzEstacionamentos.Models;
using MySql.Data.MySqlClient;
using System;

namespace HideluzEstacionamentos.DAO
{
    public class TaxDAO : Connection
    {
        public void CreateTax(Tax tax)
        {
            try
            {
                OpenConnection();

                MySqlCommand command = new MySqlCommand(
                            "INSERT INTO tb_tarifas (dl_preco, id_tipo_tarifa, id_tipo_veiculo_tarifa)" +
                            "VALUES (@price, @IdTaxType, @IdVehicleType)", connection);
                command.Parameters.AddWithValue("@price", tax.Price);
                command.Parameters.AddWithValue("@IdTaxType", tax.IdType);
                command.Parameters.AddWithValue("IdVehicleType", tax.IdVehicleType);

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

        public void UpdateTax(Tax OldTax, Tax UpdatedTax)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("UPDATE tb_tarifas set dl_preco = @TaxPrice, id_tipo_tarifa = @TaxType, id_tipo_veiculo_tarifa = @TaxVehicleType " +
                    "WHERE id = @TaxId", connection);
                command.Parameters.AddWithValue("@TaxId", OldTax.Id);
                command.Parameters.AddWithValue("@TaxPrice", UpdatedTax.Price);
                command.Parameters.AddWithValue("@TaxType", UpdatedTax.IdType);
                command.Parameters.AddWithValue("@TaxVehicleType", UpdatedTax.IdVehicleType);

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

        public void DeleteTax(Tax tax)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("DELETE FROM tb_tarifas WHERE tx_placa = @TaxId", connection);
                command.Parameters.AddWithValue("@TaxId", tax.Id);

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

        public MySqlDataReader FillTaxType()
        {

            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_tipo_tarifa", connection);
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

        public MySqlDataReader SelectAllTaxes()
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT tb_tarifas.id, dl_preco, tb_tipo_tarifa.tx_tipo, tb_tipo_veiculo.tx_tipo FROM tb_tarifas " +
                    "INNER JOIN tb_tipo_tarifa ON tb_tarifas.id_tipo_tarifa = tb_tipo_tarifa.id " +
                    "INNER JOIN tb_tipo_veiculo ON tb_tarifas.id_tipo_veiculo_tarifa = tb_tipo_veiculo.id;", connection);
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

        
    }
}
