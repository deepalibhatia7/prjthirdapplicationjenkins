using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects_Eg
{
    class Student
    {
        internal static string collegename = "MIT";
        string name;
        string dept;
        internal Student(string name,string dept)
        {
            this.name = name;
            this.dept = dept;


        }
        internal void DisplayDetails()
        {
            Console.WriteLine("Name:{0}||Dept:{1}||CollegeName:{2}", name, dept, collegename);

        }

    }
   
    class StaticEg
    {
        static void Main()
        {
            //accessing static variale by class name
            Console.WriteLine("Enter collegename");
            Student.collegename = Console.ReadLine();
                       
            string name, dept;
            Console.WriteLine("Enter the no. of students");
            int no = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[no];
            for (int i = 0;i<no;i++)
            {
                Console.WriteLine("Enter the name & dept");
                name = Console.ReadLine();
                dept= Console.ReadLine();
                student[i] = new Student(name, dept);
            }
            for(int i = 0; i < no; i++)
            {
                student[i].DisplayDetails();
            }
            Console.Read();
        }
    }
}
