using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects_Eg
{
    class Product
    {

        internal int Pid;
        internal string Pname;
        internal int Price;
        internal static string shopname;
        internal Product(  int Pid, string Pname,int Price)
        {
            this.Pid = Pid;
            this.Pname = Pname;
            this.Price = Price;
        }
       internal void DisplayProduct()
        {
            Console.WriteLine("Product ID:{0}||Product Name{1}||Price:{2}||Shop Name :{3}", Pid,Pname,Price,shopname);
        }
    }
    class QuestionProduct
    {
        static void Main()
        {
           
           int Productid;
       string Productname;
        int ProductPrice;
            
            Console.WriteLine("Enter shop name");
            Product.shopname = Console.ReadLine();
            Console.WriteLine("Enter the number of products");
            int noofproducts = Convert.ToInt32(Console.ReadLine());
            Product[] pro = new Product[noofproducts];
            for (int i = 0; i < noofproducts; i++)
            {
                Console.WriteLine("Enter ProductID , Product Name and Price");
                Productid = Convert.ToInt32(Console.ReadLine());
                Productname = Console.ReadLine();
                ProductPrice = Convert.ToInt32(Console.ReadLine());
                pro[i] = new Product(Productid, Productname ,ProductPrice);

            }
            for (int i = 0; i < noofproducts; i++)
            {
                pro[i].DisplayProduct();
            }
            Console.Read();
        }
    }
}
