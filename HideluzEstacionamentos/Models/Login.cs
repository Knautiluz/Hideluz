using System.Windows.Forms;
using HideluzEstacionamentos.Models;

namespace HideluzEstacionamentos
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public static string Message;
        public static Operator Operator = new Operator();

        public bool Verify(string u, string p)
        {
            //verifica os dados no banco para liberar acesso ao form principal.
            MessageBox.Show("Verifica os dados no banco para liberar acesso ao form principal.");
            return true;
        }
    }
}