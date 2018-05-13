using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideluzEstacionamentos
{
    public class Connection
    {
        private OracleConnection Conn { get; set; }
        public Dictionary<string, string> Fecth { get; private set; }
        public int Rows { get; private set; }
        public string Message { get; private set; }
        public Connection()
        {
            try
            {
                Conn = new OracleConnection
                {
                    ConnectionString = "User Id=system;Password=1234;Data Source=127.0.0.1:1521"
                };
            }
            catch(OracleException ex)
            {
                Message = ex.Message;
            }
        }

        public bool RunQuery(string query, int type)
        {
            Conn.Open();
            Fecth = new Dictionary<string, string>();
            if (type == 0)
            {
                try
                {
                    OracleCommand SelectCount = Conn.CreateCommand();
                    SelectCount.CommandText = query;
                    var result = SelectCount.ExecuteScalar();
                    Conn.Close();
                    Rows = int.Parse(result.ToString());
                    Message = "Os dados foram selecionados.";
                    return true;
                }
                catch(OracleException ex)
                {
                    Message = ex.Message;
                    return false;
                }
            }
            if (type == 1)
            {
                try
                {
                    OracleCommand Select = Conn.CreateCommand();
                    Select.CommandText = query;
                    var reader = Select.ExecuteReader();
                    Rows = 0;
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Fecth.Add(reader.GetName(i) + "_" + Rows, reader.GetValue(i).ToString());
                        }
                        Rows++;
                    }
                    Conn.Close();
                    Message = "Os dados foram obtidos.";
                    return true;
                }
                catch(OracleException ex)
                {
                    Message = ex.Message;
                    return false;
                }
            }
            if (type == 2)
            {
                try
                {
                    OracleCommand Insert = Conn.CreateCommand();
                    Insert.CommandText = query;
                    Insert.ExecuteNonQuery();
                    Conn.Close();
                    Message = "Os dados foram inseridos corretamente.";
                    return true;
                }
                catch(OracleException ex)
                {
                    Message = ex.Message;
                    return false;
                }
            }
            if (type == 3)
            {
                try
                {
                    OracleCommand Update = Conn.CreateCommand();
                    Update.CommandText = query;
                    Update.ExecuteNonQuery();
                    Conn.Close();
                    Message = "Os dados foram atualizados.";
                    return true;
                }
                catch(OracleException ex)
                {
                    Message = ex.Message;
                    return false;
                }
            }
            if (type == 4)
            {
                try
                {
                    OracleCommand Delete = Conn.CreateCommand();
                    Delete.CommandText = query;
                    Delete.ExecuteNonQuery();
                    Conn.Close();
                    Message = "Os dados foram apagados.";
                    return true;
                }
                catch(OracleException ex)
                {
                    Message = ex.Message;
                    return false;
                }
            }
            Message = "Operação desconhecida.";
            return false;
        }
    }
}
