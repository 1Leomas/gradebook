using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization types
            double[] numbers = new double[3] { 1.2, 3.4, 4.1};
            double[] numbers_1 = new double[] { 1.2, 3.4, 4.1};
            double[] numbers_2 = new [] { 1.2, 3.4, 4.1};
            double[] numbers_3 = { 1.2, 3.4, 4.1};
            
            var result = numbers[0];
            result += numbers[1];
            Console.WriteLine(numbers[2]);
            //Console.WriteLine($"Result is: {result}");
        }
    }
}
