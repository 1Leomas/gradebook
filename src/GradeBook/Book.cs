using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        List<double> grades; //fild

        public Book()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}