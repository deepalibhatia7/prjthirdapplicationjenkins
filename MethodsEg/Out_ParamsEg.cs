using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEg
{
    class Out_ParamsEg
    {
        void Calculation(float n1,float n2,int l,out float s, out float p, out int c)
        {
            s = n1 + n2; // float
            p = n1 * n2; // float 
            c = 1 + 2 * 4; // int
        }
        void studentdetails(string name, params string [] hobbies)
        {
            Console.WriteLine("Name:{0}", name);
            for(int i=0;i<hobbies.Length;i++)
            {
                Console.WriteLine(hobbies[i]);
            }

        }
        static void Main()
        {
            //Out PArameter
            float num1 = 10, num2 = 80, sum = 0, product = 0;
            int length = 10, cal = 0;
            Out_ParamsEg obj = new Out_ParamsEg();
            obj.Calculation(num1, num2, length, out sum, out product, out cal);
            if(sum>0 && product>0)
            {
                Console.WriteLine("Sum:{0}||Product{1}||Cal:{2}",  sum,  product,  cal);
            }
            Console.WriteLine("_____________________________________");
            //string[]h= new string[3]{"Singing","Playing","Reading"};
            //params is keyword which is used to specify a parameter that takes variable no. of arguments
            //only one params is allowed & no additional parameter is permitted after the params keyword
            //obj StudentDetails("Sunitha","Singing","Playing","Reading","Chennai",90,80)
            obj.studentdetails("Edward", "Singing", "Playing", "Reading");
            Console.Read();



        }
    }
}
