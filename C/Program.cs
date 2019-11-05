using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();
            int x = Convert.ToInt32(inputNumbers.Split(" ")[0]);
            int y = Convert.ToInt32(inputNumbers.Split(" ")[1]);
            bool[,] map = new bool[y, x];
            for (int i = 0; i < y; i++)
            {
                string str = Console.ReadLine();
                for (int j = 0; j < str.Length; j++)
                    map[i, j] = str[j] == '#' ? true : false;
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                    Console.Write(map[i,j] ? "#" : ".");
                Console.WriteLine();
            }

            int countOfRoads = 0;
            foreach (var item in map)            
                if (item) countOfRoads = 1;

            if (countOfRoads != 0)
            {
                for (int i = 1; i < map.GetLength(0) - 1; i++)
                    for (int j = 1; j < map.GetLength(1) - 1; j++)                    
                        if (map[i, j])
                        {
                            int countOfDirection = 0;
                            if (map[i - 1, j])
                                countOfDirection++;
                            if (map[i + 1, j])
                                countOfDirection++;
                            if (map[i, j - 1])
                                countOfDirection++;
                            if (map[i, j + 1])
                                countOfDirection++;
                            if (countOfDirection > 2)
                                countOfRoads++;
                        }                    
                Console.WriteLine(countOfRoads);
            }
            else
                Console.WriteLine(0);            
        }
    }
}
