using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[3] { 3.2, 3.4, 3.3};

            var result = 0.0;
            
            foreach(var number in numbers)
            {
                result += number;
            }

            Console.WriteLine(result);
        }
    }
}
