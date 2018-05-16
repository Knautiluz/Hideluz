using System.Linq;

namespace HideluzEstacionamentos
{
    class Login
    {
        public static string EmployeeRegistry;
        public static string Name;
        public static int Type;
        public static string Message;
        public bool Verify(string u, string p)
        {

            Connection con = new Connection();
            con.RunQuery(string.Format("SELECT COUNT(*) FROM USUARIO WHERE USUARIO = '{0}' AND SENHA = '{1}'", u, p), 0);
            if (con.Rows > 0)
            {
                con.RunQuery(string.Format("SELECT * FROM USUARIO WHERE USUARIO = '{0}' AND SENHA = '{1}'", u, p), 1);
                EmployeeRegistry = con.Fecth.Values.ElementAt(0);
                Name = con.Fecth.Values.ElementAt(1);
                Type = int.Parse(con.Fecth.Values.ElementAt(5));
                return true;
            }
            else
            {
                Message = "Os dados digitados não estão corretos.";
                return false;
            }
        }
        public Login()
        {
            // construtor padrao
        }

    }
}