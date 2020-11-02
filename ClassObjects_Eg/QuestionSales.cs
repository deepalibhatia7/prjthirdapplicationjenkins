using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects_Eg
{
    class Salesdetails
    {
        internal int Salesno;
        internal int Productno;
        internal int Price;
        
        internal int Qty;
        internal float TotalAmount;
        internal DateTime Dateofsale;
        internal float Sales(int Qty,float Price)
        {
            TotalAmount = Qty * Price;
            return TotalAmount;
        }
        internal Salesdetails(int Salesno, int Productno,DateTime Dateofsale)
        {
            this.Salesno = Salesno;
            this.Productno = Productno;
           
            this.Dateofsale = Dateofsale;
        }
        internal void ShowData()
        {
            Console.WriteLine("Sales NO. :{0}||Product NO:{1}||Date Of Sale:{2}||TotalAmount:{3}", Salesno, Productno,  Dateofsale,TotalAmount);
        }
    }
    class QuestionSales
    {
        static void Main()
        {
            Console.WriteLine("Enter sales no.");
            int Salesno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product no.");
            int Productno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity");
            int Qty = Convert.ToInt32(Console.ReadLine());
            DateTime DateofSale = new DateTime(2018, 7, 24);
            Console.WriteLine (DateofSale.ToString());
            Salesdetails salesdetails = new Salesdetails(Salesno,Productno,DateofSale);
            salesdetails.Sales(Qty, Price);
            salesdetails.ShowData();
            Console.Read();
        }
    }
}
