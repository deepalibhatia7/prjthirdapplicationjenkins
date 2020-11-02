using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects_Eg
{
    class Mobile
    {
        internal static string companyname;//class variable
        internal string modelname; //object variable
        internal void DisplayModel()
        {
            Console.WriteLine("CompanyName:{0}||ModelName{1}", companyname,modelname);
        }
       internal  static void GetData()
        {
            //int isbn = 1900;
            Console.WriteLine("CompanyName:{0}", companyname);
        }
    }
   
    class StaticEg2
    {
        //float f = 30.94f;
        internal static void info()
        {
            Console.WriteLine("Hey");
        }
        static void Main()
        {
            //error trying to access non-static member inside static function
            //f=f+f
            Mobile mobile = new Mobile();
            mobile.modelname = "Moto G4 Plus";
            Mobile.companyname = "Motorola";
            mobile.DisplayModel();
            Mobile.GetData();
            // info method and staticmethod in same class // no need to mention class name
            info();
            Console.Read();

        }
       


    }
}
