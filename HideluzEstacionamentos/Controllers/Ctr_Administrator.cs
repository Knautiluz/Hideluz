using HideluzEstacionamentos.Models;

namespace HideluzEstacionamentos.Controllers
{
    class Ctr_Administrator
    {
        public bool AddTax(Tax tax)
        {
            return true;
        }
        public bool ChangeTax(Tax tax)
        {
            return true;
        }
        public bool DeleteTax(Tax tax)
        {
            return true;
        }
        public bool AddUser(User user)
        {
            return true;
        }
        public bool ChangeUser(User user)
        {
            return true;
        }
        public User CheckUser(User user)
        {
            return user;
        }
        public bool DeleteUser(User user)
        {
            return true;
        }
    }
}
