using System;

namespace firstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*{
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
            {
                Console.WriteLine("Задание 3");
                Console.Write("x1 = "); double x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("y1 = "); double y1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("x2 = "); double x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("y2 = "); double y2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"p = {Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2))}");
            }*/
            {
                Console.WriteLine("Задание 4");
                Console.Write("n = "); int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine((n % 10) * 10 + n / 10);
            }
        }
    }
}
