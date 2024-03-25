using System;
namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var finished = false;
            double value1=1;
            double value2=1;
            while (!finished)
            {
                Console.WriteLine("Enter two numbers:");
                try
                {
                    Console.Write("Number 1: ");
                    value1 = double.Parse(Console.ReadLine());
                    Console.Write("Number 2: ");
                    value2 = double.Parse(Console.ReadLine());
                    finished = true;
                }
                catch (FormatException ex) { Console.WriteLine("That isn't a valid Number, try again."); }

            }
            var addition = (double value1, double value2) =>
            {
                var sum = value1 + value2;
                return sum;
            };

            var multiplaction = (double value1, double value2) =>
            {
                var product = value1 * value2;
                return product;
            };

            var compare = (double value1, double value2) =>
            {
                if (value1 < value2) { return value1; }
                else { return value2; }                    
            };
            Console.WriteLine($"{value1} added to {value2} is {addition(value1, value2)}");
            Console.WriteLine($"{value1} multiplied by {value2} is {multiplaction(value1,value2)}");
            Console.WriteLine($"The lower number of {value1} or {value2} is {compare(value1,value2)}");
        }
    }
}