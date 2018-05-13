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
            Connection con = new Connection();
            con.RunQuery("SELECT COUNT(*) FROM TIPOCLIENTE", 0);
            var result = con.Rows;
            if (int.Parse(result.ToString()) == 0)
            {
                con.RunQuery("INSERT INTO TIPOCLIENTE (TIPOCLIENTE) VALUES ('Avulso')", 2);
                con.RunQuery("INSERT INTO TIPOCLIENTE (TIPOCLIENTE) VALUES ('Mensalista')", 2);
                con.RunQuery("SELECT TIPOCLIENTE FROM TIPOCLIENTE", 1);
                for(int i = 0; i < con.Fecth.Count; i++)
                {
                    Types.Add(con.Fecth.Values.ElementAt(i).ToString());
                }
            }
            else
            {
                con.RunQuery("SELECT TIPOCLIENTE FROM TIPOCLIENTE", 1);
                for (int i = 0; i < con.Fecth.Count; i++)
                {
                    Types.Add(con.Fecth.Values.ElementAt(i).ToString());
                }
            }
            SplashProgressBar.PerformStep();
            ProgressComplete = true;
        }
    }
}
