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

        public bool ValidateUser(Login inputLogin)
        {
            try
            {
                if (LoginDAO.CheckUser(inputLogin)) { return true; }

                else { return false; }
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public Login FillUserData(Login inputLogin)
        {
            return LoginDAO.FillUserData(inputLogin);
        }
    }
}
