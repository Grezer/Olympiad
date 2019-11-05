using System;
using System.Collections.Generic;
using System.Globalization;

namespace Olympiad
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, bool[,]> numbers = new Dictionary<int, bool[,]>(10);
            numbers.Add(0, new bool[,] {    { true, true, true },
                                            { true, false, true },                                            
                                            { true, false, true },
                                            { true, false, true },
                                            { true, true, true } });

            numbers.Add(1, new bool[,] {    { false, false, true },
                                            { false, false, true },
                                            { false, false, true },
                                            { false, false, true },
                                            { false, false, true } });

            numbers.Add(2, new bool[,] {    { true, true, true },
                                            { false, false, true },
                                            { true, true, true },
                                            { true, false, false },
                                            { true, true, true } });

            numbers.Add(3, new bool[,] {    { true, true, true },
                                            { false, false, true },
                                            { true, true, true },
                                            { false, false, true },
                                            { true, true, true } });

            numbers.Add(4, new bool[,] {    { true, false, true },
                                            { true, false, true },
                                            { true, true, true },
                                            { false, false, true },
                                            { false, false, true } });

            numbers.Add(5, new bool[,] {    { true, true, true },
                                            { true, false, false },
                                            { true, true, true },
                                            { false, false, true },
                                            { true, true, true } });

            numbers.Add(6, new bool[,] {    { true, true, true },
                                            { true, false, false },
                                            { true, true, true },
                                            { true, false, true },
                                            { true, true, true } });

            numbers.Add(7, new bool[,] {    { true, true, true },
                                            { false, false, true },
                                            { false, false, true },
                                            { false, false, true },
                                            { false, false, true } });

            numbers.Add(8, new bool[,] {    { true, true, true },
                                            { true, false, true },
                                            { true, true, true },
                                            { true, false, true },
                                            { true, true, true } });

            numbers.Add(9, new bool[,] {    { true, true, true },
                                            { true, false, true },
                                            { true, true, true },
                                            { false, false, true },
                                            { true, true, true } });
            
            Console.WriteLine(DateTime.Now.ToString("HHmm"));

            /*
            for (int it = 0; it < 10; it++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)                    
                        Console.Write(numbers[it][i, j] ? "#" : ".");
                    Console.WriteLine();                    
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            */
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
