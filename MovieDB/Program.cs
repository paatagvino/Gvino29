using System;
using MovieDB.Data;

namespace MovieDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MovieDB Project");

            using (var context = new MovieDbContext())
            {
                Console.WriteLine("MovieDbContext created successfully!");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}