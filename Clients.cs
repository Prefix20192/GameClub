using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClub
{
    class Clients
    {
        public string Email { get; set; }
        public string password { get; set; }
        public string time { get; set; }
        public string balance { get; set; }

        public Clients(string email, string password, string time, string balance)
        {
            Email = email;
            this.password = password;
            this.time = time;
            this.balance = balance;
        }
    }
}
