using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Sam grade book");
            book.AddGrade(89.1); 
            book.AddGrade(12.4); 
            book.AddGrade(77.5); 

            var grades = new List<double>() { 3.2, 3.4, 3.3, 5.7}; 
            
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowestGrade = double.MaxValue;
            foreach(var number in grades) 
            {
                highGrade = Math.Max(number, highGrade);
                lowestGrade = Math.Min(number, lowestGrade);
                result += number;
            }
            //Count contains numeber of items in the list
            result = result / grades.Count; 

            //:N2 - limits float number to only 2 digits
            Console.WriteLine($"The average grade is {result:N2}");
            Console.WriteLine($"The highest grade is {highGrade:N2}");
            Console.WriteLine($"The highest grade is {lowestGrade:N2}");
        }
    }
}
