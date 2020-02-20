using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Checkmate(123);
        }

        static void Checkmate(int a)
        {
            Console.WriteLine($"Checkmate: {a}");
        }
    }
}
