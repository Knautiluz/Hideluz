using HideluzEstacionamentos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideluzEstacionamentos.Controllers
{
    public class LoginController
    {
        LoginDAO LoginDAO = new LoginDAO();

        public bool SelectUser(Login login)
        {
            try
            {
                var tunga = LoginDAO.Select(login);
                if (tunga) { return true; }
                else { return false; }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
