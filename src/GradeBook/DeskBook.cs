using System;
using System.Collections.Generic;
using System.IO;

namespace GradeBook
{
    public class DeskBook : Book
    {
        public DeskBook(string name) : base(name)
        {
            // try
            // {
            //     FileStream file = File.Create($"/{name}.txt");
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }
        }
        public override event GradeAddedDelegate GradeAdded;
        public override  void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            using(var reader = File.OpenText($"{Name}.txt"))
            {
               var line = reader.ReadLine();
               while(line != null)
               {
                   var number = double.Parse(line);
                   result.Add(number);
                   line = reader.ReadLine();
               }

            }

            return result;

        }
    }
}