using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
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
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;

            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach(var grade in grades) 
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }

            result.Average /= grades.Count; 

            return result;
        }
        public void ShowStatistics()
        {
            

            
        }
    }
}