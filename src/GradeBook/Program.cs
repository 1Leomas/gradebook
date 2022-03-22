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

            Console.WriteLine(result);
        }
    }
}
