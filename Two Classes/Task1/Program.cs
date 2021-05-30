using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pi = Math.PI;
            var e = Math.E;

            Console.WriteLine($"PI = {pi}");
            Console.WriteLine($"E = {e}");
            Console.WriteLine($"MyFavoriteNumber = {Math.MyFavoriteNumber}");

            Console.WriteLine("Write two numbers");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Max = {Math.Max(a, b)}");
            Console.WriteLine($"Min = {Math.Min(a, b)}");
            Console.WriteLine($"Min = {Math.Min(new int[] { a, b, Math.MyFavoriteNumber })}");
        }
    }
}
