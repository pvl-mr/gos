using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom_example_app
{
    [Serializable]
    public class Users
    {
        public List<User> UserList {  get; set; } = new List<User>();


    }

    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public User() { }

        public User(string Name , string Sex, int Age)
        {
            this.Name = Name;           
            this.Sex = Sex;
            this.Age = Age;
        }

    }
}
