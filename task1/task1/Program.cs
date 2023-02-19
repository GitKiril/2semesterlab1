using System;

namespace task1
{
    internal class Task1
    {
        public delegate int arithmetic(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("Write first number: ");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second number: ");
            int p = int.Parse(Console.ReadLine());
            arithmetic arithmetic = (x, y) => x + y;
            Console.WriteLine("Sum: ");
            Console.WriteLine(arithmetic(t, p));
            Console.WriteLine("subtraction:");
            arithmetic += (x, y) => x - y;
            Console.WriteLine(arithmetic(t, p));
            Console.WriteLine("mult:");
            arithmetic += (x, y) => x * y;
            Console.WriteLine(arithmetic(t, p));
            Console.WriteLine("division by zero: ");
            arithmetic += (x, y) =>
            {
                int g = 0;
                try
                {
                    g = x / y;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                return g;
            };
            Console.WriteLine(arithmetic(t, p));
        }
    }
}
