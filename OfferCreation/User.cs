using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferCreation
{
    public class User
    {
        public String userName;
        public bool isAdmin;
        public User(String name, bool admin)
        {
            userName = name;
            isAdmin = admin;
        }
    }
}
