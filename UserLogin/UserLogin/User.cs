using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class User
    {
        public String Username {get; set;} // this could be a bug.
        public String Password { get; set; }
        public String FakNum { get; set; }
        public Int32 Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime ExpiryDate { get; set; }

        public User(String username, String password, String fakNum, Int32 role)
        {
            this.Username = username;
            this.Password = password;
            this.FakNum = fakNum;
            this.Role = role;
        } 
        public User() { }
        public override string ToString()
        {
            return this.Username+" "+this.Role;
        }
    }  
}
