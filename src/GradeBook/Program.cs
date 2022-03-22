using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 3.2, 3.4, 3.3}; 

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            //Count contains numeber of items in the list
            result = result / grades.Count; 

            //:N2 - limits float number to only 2 digits
            Console.WriteLine($"The average grade is {result:N2}");
        }
    }
}
