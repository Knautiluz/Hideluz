using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HideluzEstacionamentos
{
    class Login
    {
        public static string EmployeeRegistry;
        public static string Name;
        public static int Type;

        public bool Verify(string u, string p)
        {
            OracleConnection Connection = new OracleConnection
            {
                ConnectionString = "User Id=system;Password=1234;Data Source=127.0.0.1:1521"
            };
            OracleCommand SelectCount = Connection.CreateCommand();
            SelectCount.CommandText = "SELECT COUNT(*) FROM USUARIO WHERE USUARIO = :usuario AND SENHA = :senha";
            OracleParameter[] oracleParameters = new OracleParameter[]
            {
                new OracleParameter("usuario", u),
                new OracleParameter("senha", p)
            };
            SelectCount.Parameters.AddRange(oracleParameters);
            try
            {
                Connection.Open();
                var result = SelectCount.ExecuteScalar();
                if(int.Parse(result.ToString()) > 0)
                {
                    OracleCommand Select = Connection.CreateCommand();
                    Select.CommandText = "SELECT * FROM USUARIO WHERE USUARIO = :usuario AND SENHA = :senha";
                    Select.Parameters.AddRange(oracleParameters);
                    var reader = Select.ExecuteReader();
                    while(reader.Read())
                    {
                        EmployeeRegistry = reader.GetValue(0).ToString();
                        Name = reader.GetValue(1).ToString();
                        Type = int.Parse(reader.GetValue(5).ToString());
                    }
                    return true;
                }
                else
                {
                    FormMain.OperationResult = "Os dados digitados não estão corretos.";
                    return false;
                }
                
            }
            catch(OracleException ex)
            {
                FormMain.OperationResult = "Erro interno: " + ex.Message;
                return false;
            }
        }
        public Login()
        {
            // construtor padrao
        }

    }
}
