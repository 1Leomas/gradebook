using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    
    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name {get; set;}
    }

    public interface IBook
    {
       public void AddGrade(double grade);
       public Statistics GetStatistics();
       string Name{ get;}
       event GradeAddedDelegate GradeAdded;
    }

    public abstract class Book : NamedObject, IBook
    {
        protected Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegate GradeAdded;
        public abstract void AddGrade(double grade);
        public abstract Statistics GetStatistics();
    }
    public class InMemoryBook : Book
    {
        private List<double> grades; //field

        public const string CATEGORY = "Science";

        public InMemoryBook(string name) : base(name) //constructor
        {
            this.Name = name; 
            grades = new List<double>();
        }

        public void AddGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90.0);
                    break;
                case 'B':
                    AddGrade(80.0);
                    break;
                case 'C':
                    AddGrade(70.0);
                    break;
                
                default:
                    AddGrade(0);
                    break;
            }
        }
        public override void AddGrade(double grade) //method
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public override event GradeAddedDelegate GradeAdded;

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            
            for(var index = 0; index < grades.Count; index++)
            {
                result.Add(grades[index]);
            }

            return result;
        }
        public void ShowStatistics()
        {
            

            
        }
    }
}