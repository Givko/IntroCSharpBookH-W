using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07CreateNamespaces.MyNamespaces
{
    public class Cat
    {
        private string name;
        private string color;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "grey";
        }
        public Cat(string name,string color)
        {
            this.name = name;
            this.color = color;
        }
        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said: Miauuuuuu!",name);
        }
    }
}
