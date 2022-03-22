using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        private List<double> grades; //fild
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
    }
}