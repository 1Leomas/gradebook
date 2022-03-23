using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Sam's grade book");
            book.AddGrade(89.1); 
            book.AddGrade(12.4); 
            book.AddGrade(77.5); 
            var result = book.GetStatistics();

            //:N2 - limits float number to only 2 digits
            Console.WriteLine($"The average grade is {result.Average:N2}");
            Console.WriteLine($"The highest grade is {result.High:N2}");
            Console.WriteLine($"The lowest grade is {result.Low:N2}");
        }
    }
}