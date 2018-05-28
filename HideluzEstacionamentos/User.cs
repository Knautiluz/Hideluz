namespace HideluzEstacionamentos
{
    public class User
    {
        public string Document { get; set; }
        // cpf do usuário (operador / adm)
        public string Name { get; set; }
        // nome do usário (operador / adm)
        public string Username { get; set; }
        // nome de usuário (operador / adm)
        public string Password { get; set; }
        // senha (operador / adm)
        public int Status { get; set; }
        // se o operador / adm está ativo no sistema ou não
        public int Type { get; set; }
        // se é adm ou operador
        public User()
        {
            // construtor padrão
        }
    }
}
