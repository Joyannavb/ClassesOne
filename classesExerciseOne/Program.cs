using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesExerciseOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prius = new Car();
            prius.Make = "Toyota";
            prius.Model = "Prius";
            prius.Year = 2016;

            Console.WriteLine($"{prius.Make} {prius.Model} {prius.Year}");

        }
    }
}
