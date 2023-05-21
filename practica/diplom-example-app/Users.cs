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
        public List<Blog> BlogsList {  get; set; } = new List<Blog>();


    }

    [Serializable]
    public class Blog
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Rate { get; set; }

        public Blog() { }

        public Blog(string Name , string Sex, int Age)
        {
            this.Name = Name;           
            this.Author = Sex;
            this.Rate = Age;
        }

    }
}
