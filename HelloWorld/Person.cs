using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public  class Person
    {
        public string Name { set; get; }
        public ushort Age { set; get; }

        public Person()
        {
        }

        public Person(string name , ushort age)
        {
            Name = name;
            Age = age; 
        }

        public void SayName()
        {
            Console.WriteLine(Name+ " " + Age);
        }




    }
}
