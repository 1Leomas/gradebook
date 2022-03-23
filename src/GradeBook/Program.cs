using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Grade book");
            
            Console.WriteLine("This is the grade book, enter the grades");
            Console.WriteLine("To finish press x");
            var input = "";
            
            while(true)
            {
                Console.Write("Input: ");
                input = Console.ReadLine();

                if(input == "x") break;

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }

            var result = book.GetStatistics();

            //:N2 - limits float number to only 2 digits
            Console.WriteLine($"The average grade is {result.Average:N2}");
            Console.WriteLine($"The highest grade is {result.High:N2}");
            Console.WriteLine($"The lowest grade is {result.Low:N2}");
            Console.WriteLine($"The letter grade is {result.Letter:N2}");
        }
    }
}