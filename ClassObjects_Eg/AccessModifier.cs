using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects_Eg
{
    class Person
    {
        internal string name;
        internal int age;
        internal void DisplayPerson()
        {
            Console.WriteLine("Name:{0}||Age:{1}", name, age);
        }
    }
    class AccessModifier
    {
    }
}
