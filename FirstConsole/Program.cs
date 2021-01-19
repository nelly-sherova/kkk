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
            {
                Console.WriteLine("Задание 2");
                Console.Write("a = "); double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = "); double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c = "); double c = Convert.ToDouble(Console.ReadLine());
                double ac = Math.Abs(c - a), bc = Math.Abs(c - b);
                Console.WriteLine($"AC = {ac}, BC = {bc}");
                Console.WriteLine($"{ac} + {bc} = {ac + bc}");
                
            }
        }
    }
}
