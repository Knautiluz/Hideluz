using System.Linq;

namespace HideluzEstacionamentos
{
    class Login
    {
        public static string Message;
        //caso o login falhar, ele preenche o Message com a mensagem do erro do banco algo genérico como "falha ao se conectar com o servidor."
        public static Operator Operator = new Operator();
        //instancia um novo operador
        //public static Administrator Administrator = new Administrator();

        public bool Verify(string u, string p)
        {
            //verifica os dados no banco para liberar acesso ao form principal.
            return true;
        }
        public Login()
        {
            // construtor padrao
        }

    }
}