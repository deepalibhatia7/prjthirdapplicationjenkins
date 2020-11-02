using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects_Eg
{
    class Pen
    {
        public int ISBN;
        public string brand;
        internal string color;
        //constructor is a special method and private by default
        //initialize the value for variables
        //constructor dont have return type

        //Constructor overloading
        internal Pen() // no arguments
        {
            Console.WriteLine("Default Constructor");
        }
        internal Pen( int ISBN) // 1 argument
        {
            this.ISBN = ISBN;
            Console.WriteLine(ISBN);
        }
        internal Pen(string b,string color)
        {
            brand = b;
            this.color = color;
        }
        internal void DisplayPen()
        {
            Console.WriteLine("Brand:{0}||Color:{1}", brand, color);
        }
    }
    class ConstructorEg
    {
        static void Main()
        {
            Pen pen = new Pen("Parker", "Blue");
            Pen p = new Pen();
            Pen p1 = new Pen(1234);
            /* pen.brand="Parker";
             * pen.color="Blue";*/
            pen.DisplayPen();
            Console.Read();
        }
    }
}
