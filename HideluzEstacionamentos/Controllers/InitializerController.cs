using HideluzEstacionamentos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideluzEstacionamentos.Controllers
{
    public class InitializerController
    {
        InitializerDAO InitializerDAO = new InitializerDAO();

        public void CreateUsersTable()
        {
            InitializerDAO.CreateUsersTable();
        }
    }
}
