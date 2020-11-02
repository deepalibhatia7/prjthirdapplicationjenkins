using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects_Eg
{
    class Customer
    {
        internal int Cid;
        internal string Name;
    internal int age;
    internal string city;
        internal string phoneno; 
        internal Customer() // no arguments
    {
        Console.WriteLine("Default Constructor");
    }
    internal Customer (int Cid,string Name, int age,string city, string phoneno) // n arguments
    {
            this.Cid = Cid;
            this.Name = Name;
            this.age = age;
            this.city = city;
            this.phoneno = phoneno;

    }
   
    internal void DisplayCustomer()
    {
        Console.WriteLine("Customer ID :{0}||Name:{1}||age:{2}||City:{3}||Phone No.:{4}", Cid, Name,age,city,phoneno);
    }
}
    class AssignmentDay3
    {
        static void Main()
        {
            Customer customer = new Customer();
            Customer customer1 = new Customer(111,"Deepali",22,"Faridabad","986542123");

            customer1.DisplayCustomer();
            Console.Read();
        }
    }
}
