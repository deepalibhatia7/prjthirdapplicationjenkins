using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects_Eg
{
    class Movie
    {
        int id;
        string moviename;
        //DateTime year;

        internal Movie( int id, string moviename)
        {
            this.id = id;
            this.moviename = moviename;
            //this.year=year;
        }
        internal void DisplayMovie()
        {
            Console.WriteLine("ID:{0}||MovieName:{1}", id, moviename);
        }
    }
    class ArrayofObjectsEg
    {
        static void Main()
        {
            Console.WriteLine("Hello , This is Deepali");
            int id;
            string moviename;
            Movie movie = new Movie(101, "Dangal");
            movie.DisplayMovie();
           
            //applying aray to abjects to fetch multiple movie info
            //array of object
            //datatype[] arrayname= new datatype[size]
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            Movie[] mov = new Movie[size];
            for (int i = 0; i< size; i++)
            {
                Console.WriteLine("Enter MovieID and MovieName");
                id = Convert.ToInt32(Console.ReadLine());
                moviename = Console.ReadLine();
                mov[i] = new Movie(id, moviename);

            }
            for (int i = 0; i < size; i++)
            {
                mov[i].DisplayMovie();
            }
            Console.Read();
        }
    }
}
