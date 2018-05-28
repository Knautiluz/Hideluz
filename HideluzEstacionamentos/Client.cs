namespace HideluzEstacionamentos
{
    public class Client
    {
        public string Document { get; set; }
        // documento do cliente (cpf)
        public string Name { get; set; }
        // nome do cliente
        public Address Address { get; set; }
        // endereço do cliente
        public string Email { get; set; }
        // e-mail do cliente
        public string Tel { get; set; }
        // telefone do cliente
        public int Type { get; set; }
        // tipo do cliente mensalista / avulso

        public Client()
        {
            // constructor
        }
    }
}
