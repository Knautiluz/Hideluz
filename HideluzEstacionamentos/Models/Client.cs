namespace HideluzEstacionamentos
{
    public class Client
    {
        public string Document { get; set; }
        // documento do cliente (cpf)
        public string Name { get; set; }
        // nome do cliente
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
        public class Address
        {
            public string State { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public string Number { get; set; }
            public string Neighborhood { get; set; }
            public string Cep { get; set; }

            public Address()
            {
                // constructor
            }
        }
    }
}
