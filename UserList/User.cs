using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User (string login, string name, bool premium)
        {
            Login = login;
            Name = name;
            IsPremium = premium;
        }
    }
}
