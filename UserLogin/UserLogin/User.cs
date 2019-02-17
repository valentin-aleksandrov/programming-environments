using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class User
    {
        public String Username;
        public String Password;
        public String FakNum;
        public Int32 Role;

        public User(String username, String password, String fakNum, Int32 role)
        {
            this.Username = username;
            this.Password = password;
            this.FakNum = fakNum;
            this.Role = role;
        }
    }
    
}
