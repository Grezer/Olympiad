using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Словарь с "картами" циферок
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


            
            string userInput = Console.ReadLine().Insert(2, ":");    // Читаем чё ввели и добавляем двоеточие (нужно для нормальной конвертации в DateTime)           
            string inputTime = DateTime.Today.Add(TimeSpan.Parse(userInput)).ToString("HHmm");   // Парсим входную строчку в DateTime и сохраняем это в строчку в формате HHmm            
            string inputTimePlusOne = DateTime.Today.Add(TimeSpan.Parse(userInput)).AddMinutes(1).ToString("HHmm");     // То что выше, но плюс 1 минута

            // понеслась
            int hammingDistance = 0; // переменная для подсчёта
            for (int stringPosition = 0; stringPosition < 4; stringPosition++) // проходим 4 цифры
                for (int i = 0; i < 5; i++)     // для каждой строки
                    for (int j = 0; j < 3; j++) // для каждого столбца   
                        // идём в словарь в ячейку номер inputTime[stringPosition]-48 (48 из-за char символов) 
                        // в bool массив в i,j ячейку и если != тому же самому в ячейке словаря номер inputTimePlusOne[stringPosition] - 48, тогда +1
                        if (numbers[inputTime[stringPosition] - 48][i, j] != numbers[inputTimePlusOne[stringPosition] - 48][i, j]) 
                            hammingDistance++;                    
            Console.WriteLine(hammingDistance);
                
            

            /* вывод словаря чисто посмотреть чё там
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
           
            Console.ReadKey();
        }
    }
}
