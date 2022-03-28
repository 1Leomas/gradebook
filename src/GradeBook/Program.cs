using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {

            IBook book = new DeskBook("Grade book");
            //Book book = new InMemoryBook("Grade book");

            EnterGrades(book);

            var result = book.GetStatistics();

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The average grade is {result.Average:N2}");
            Console.WriteLine($"The highest grade is {result.High:N2}");
            Console.WriteLine($"The lowest grade is {result.Low:N2}");
            Console.WriteLine($"The letter grade is {result.Letter:N2}");
        }

        private static void EnterGrades(IBook book)
        {
            Console.WriteLine("This is the grade book, enter the grades");
            Console.WriteLine("To finish press x");

            string input;
            while (true)
            {
                Console.Write("Input: ");
                input = Console.ReadLine();

                if (input == "x") break;

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }

        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}