using HideluzEstacionamentos.DAO;
using HideluzEstacionamentos.Models;
using System;

namespace HideluzEstacionamentos.Controllers
{
    public class UserController
    {
        UserDAO LoginDAO = new UserDAO();

        public bool ValidateUser(User inputLogin)
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

        public User FillUserData(User inputLogin)
        {
            return LoginDAO.FillUserData(inputLogin);
        }
    }
}
