using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        private List<double> grades; //field
        private string name;
        public Book(string name) //constructor
        {
            this.name = name;
            grades = new List<double>();
        }
        public void AddGrade(double grade) //method
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(var number in grades) 
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            //Count contains numeber of items in the list
            result = result / grades.Count; 

            //:N2 - limits float number to only 2 digits
            Console.WriteLine($"The average grade is {result:N2}");
            Console.WriteLine($"The highest grade is {highGrade:N2}");
            Console.WriteLine($"The lowest grade is {lowGrade:N2}");
        }
    }
}