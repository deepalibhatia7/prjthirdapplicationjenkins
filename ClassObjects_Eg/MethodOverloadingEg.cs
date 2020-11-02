using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects_Eg
{
    class Shape
    {
        internal double Area(int r)
        {
            Console.WriteLine("Enter the radius");
            r = Convert.ToInt32(Console.ReadLine());
            return (3.14 * r * r);
        }
        internal int Area(int l, int b)
        {
            return (l * b);
        }
        
    }
    class MethodOverloadingEg
    {
        static void Main()
        {
            Shape shape = new Shape();
            Console.WriteLine("Area of Circle:{0}", shape.Area(4));
            Console.WriteLine("Area of rectangle:{0}", shape.Area(6,7));
            Console.Read();


        }
    }
}
