using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects_Eg
{
    class Coursedetails
    {
        int courseid,fees;
        string coursename;
        internal static string institutionname;
        internal Coursedetails(int courseid,int fees, string coursename)
        {
            this.courseid = courseid;
            this.fees = fees;
            this.coursename = coursename;
        }
       internal void DisplayDetails()
        {
            Console.WriteLine("THe CourseId:{0} || CourseName:{1}||Fees{2}||instiutionname:{3}", courseid, coursename, fees,institutionname);
        }
        static int CollegeID = 2553;
        internal static int DisplayCollegeID()
        {
            return CollegeID;
        }
    }
       
    class Questionnairre
    {
        static void Main()
        {
            int CourseID, Fees;
            string CourseName;
            Console.WriteLine("Enter Institution Name");
           Coursedetails.institutionname = Console.ReadLine();
            Console.WriteLine("Enter College ID:{0}", Coursedetails.DisplayCollegeID());
            
            Console.WriteLine("Enter the no. of courses");
            int size = Convert.ToInt32(Console.ReadLine());
            Coursedetails[] coursedetails = new Coursedetails [size];
            
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("Enter CourseId,CourseName,Fees");
                CourseID = Convert.ToInt32(Console.ReadLine());
                CourseName = Console.ReadLine();
                Fees = Convert.ToInt32(Console.ReadLine());
                coursedetails [i] = new Coursedetails(CourseID, Fees, CourseName);


            }
            for (int i = 0; i < size; i++)
            {
                coursedetails[i].DisplayDetails();
                Console.WriteLine("some Changes");
            }
            Console.Read();
        }
    }
}
