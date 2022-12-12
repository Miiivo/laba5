using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit;

            Console.WriteLine("Enter your deposit");
            deposit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (deposit < 100)
            {
                deposit *= 1.05;
                Console.WriteLine($"You`ll get {Math.Round(deposit, 2)}");
            }
            else 
            if (deposit > 200)
            {
                deposit *= 1.1;
                Console.WriteLine($"You`ll get {Math.Round(deposit, 2)}");
            }
            else
            {
                deposit *= 1.07;
                Console.WriteLine($"You`ll get {Math.Round(deposit, 2)}");
            }
        }
    }
}