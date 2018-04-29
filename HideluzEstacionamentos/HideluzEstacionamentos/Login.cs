using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideluzEstacionamentos
{
    class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool Verify(string u, string p)
        {
            //implementar verificação no SGBD
            if(true)
            {
                return true;
            }
        }
        public Login()
        {
            // construtor padrao
        }

    }
}
