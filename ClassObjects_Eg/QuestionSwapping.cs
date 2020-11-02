using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects_Eg
{
    class Swapping
    {
        internal void Swap(int a,int b)
        {
            int A = a;
            a = b;
            b = A;
            Console.WriteLine("Swapped Numbers:a={0},b={1}", a, b);
        }
        internal void Swap(string X, string Y)
        {
             string x = X;
            X = Y;
            Y = x;
            Console.WriteLine("Swapped Numbers:a={0},b={1}", X, Y);
        }
    }
    class QuestionSwapping
    {
        static void Main()
        {
            Swapping swapping = new Swapping();
            swapping.Swap(3,4);
            swapping.Swap("Deepali", "Bhatia");
            Console.Read();

        }
    }
}
