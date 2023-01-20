using System;
using ClassLibraryForConsole;

namespace UserInputCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}!");
            string resultStr = Concatenation.Concatenate($"{DateTime.Now}: ", "Hello, ", $"{userName}");
            Console.WriteLine(resultStr);
            Console.ReadLine();
        }
    }
}
