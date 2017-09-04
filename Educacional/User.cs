using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacional
{
    class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Profile
        {
            get
            {
                return Id + " - " + Name;
            }
        }

        public User() { }

        public User(int Id, string Name, string Username, string Password)
        {
            this.Id = Id;
            this.Name = Name;
            this.Username = Username;
            this.Password = Password;
        }
    }
}
