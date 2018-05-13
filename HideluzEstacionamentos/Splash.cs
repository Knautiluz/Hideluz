using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class Splash : Form
    {
        public static bool ProgressComplete;
        public static List<string> Types = new List<string>();
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            OracleConnection Connection = new OracleConnection
            {
                ConnectionString = "User Id=system;Password=1234;Data Source=127.0.0.1:1521"
            };
            OracleCommand SelectCount = Connection.CreateCommand();
            SelectCount.CommandText = "SELECT COUNT(*) FROM TIPOCLIENTE";
            try
            {
                Connection.Open();
            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            var result = SelectCount.ExecuteScalar();
            if (int.Parse(result.ToString()) == 0)
            {
                // Cadastra os tipos de cliente.
                OracleCommand Insert = Connection.CreateCommand();
                Insert.CommandText = "INSERT INTO TIPOCLIENTE (TIPOCLIENTE) VALUES ('Avulso')";
                Insert.ExecuteNonQuery();
                Insert.CommandText = "INSERT INTO TIPOCLIENTE (TIPOCLIENTE) VALUES ('Mensalista')";
                Insert.ExecuteNonQuery();
                // Popula o listbox.
                OracleCommand Select = Connection.CreateCommand();
                Select.CommandText = "SELECT TIPOCLIENTE FROM TIPOCLIENTE";
                OracleDataReader Reader = Select.ExecuteReader();
                while (Reader.Read())
                {
                    Types.Add(Reader.GetValue(0).ToString());
                }
            }
            else
            {
                OracleCommand Select = Connection.CreateCommand();
                Select.CommandText = "SELECT TIPOCLIENTE FROM TIPOCLIENTE";
                OracleDataReader Reader = Select.ExecuteReader();
                while (Reader.Read())
                {
                    Types.Add(Reader.GetValue(0).ToString());
                }
            }
            SplashProgressBar.PerformStep();
            ProgressComplete = true;
        }
    }
}
