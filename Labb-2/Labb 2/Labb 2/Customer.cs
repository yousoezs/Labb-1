using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Labb_2
{
    public class Customer
    {
        private string filename = @"C:\Program Files (x86)\Text From VS";
        public string Name { get; private set; }

        public string Password { get; set; }

        private List<string> _cart;
        public List<string> Cart { get { return _cart; } }

        public Customer(string name, string password)
        {
            Name = name;
            Password = password;
            _cart = new List<string>();
        }

        public bool UserInfo(string userN, string userP)
        {
            if (userN == Name && userP == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ToString()
        {
            return $"Welcome {Name}";
        }
    }
}
