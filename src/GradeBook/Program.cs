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

            book.ShowStatistics();
        }
    }
}