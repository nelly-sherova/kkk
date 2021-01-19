using System;

namespace firstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Задание 1");
                Console.Write("a = "); double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = "); double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{Math.Sqrt(a * b)}");
            }
        }
    }
}
