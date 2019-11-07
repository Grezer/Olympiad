using System;
using System.Collections.Generic;
using System.Linq;

namespace B
{
    class Program
    {
        class Cell
        {
            public bool Status = false;
            public int Count = 0;
            public Cell()
            {
                Status = false;
                Count = 0;
            }
        }

        private static int Check(int x, int y, int size, Cell[,] cells)
        {
            if (x < 0 || x == size || y < 0 || y == size)
                return 0;
            return Convert.ToInt32(cells[x, y].Status);
        }

        private static void Reload(int size, Cell[,] cells)
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                {
                    int Sum = 0;
                    Sum += Check(x + 1, y + 1, size, cells);
                    Sum += Check(x + 1, y - 1, size, cells);
                    Sum += Check(x - 1, y - 1, size, cells);
                    Sum += Check(x - 1, y + 1, size, cells);
                    Sum += Check(x + 1, y, size, cells);
                    Sum += Check(x - 1, y, size, cells);
                    Sum += Check(x, y + 1, size, cells);
                    Sum += Check(x, y - 1, size, cells);
                    cells[x, y].Count = Sum;
                }
        }

        private static string cellsToString(Cell[,] cells)
        {
            string result = "";
            for (int i = 0; i < cells.GetLength(0); i++)
                for (int j = 0; j < cells.GetLength(1); j++)
                    result += cells[i, j].Status ? "1" : "0";
            return result;
        }

        private static bool checkLife(Cell[,] cells)
        {            
            for (int i = 0; i < cells.GetLength(0); i++)
                for (int j = 0; j < cells.GetLength(1); j++)
                    if (cells[i, j].Status) return true;
            return false;
        }


        static void Main(string[] args)
        {
           
            //int a = String.Compare(firstStr, secondtStr);
            int size = Convert.ToInt32(Console.ReadLine());
            Cell[,] cells = new Cell[50, 50];
            Dictionary<int, string> Epochs = new Dictionary<int, string>();

            
            for (int i = 0; i < 50; i++)            
                for (int j = 0; j < 50; j++)                
                    cells[i, j] = new Cell();           
            for (int i = 0; i < size; i++)
            {
                string inputLine = Console.ReadLine();
                for (int j = 0; j < size; j++)                
                    if (inputLine[j] == '*') 
                        cells[i + 20, j + 20].Status = true;                
            }
            Console.WriteLine();

            int it = 0;
            while(true)
            {
                Epochs.Add(it, cellsToString(cells));
                int repetitions = -1;
                for (int i = 0; i < Epochs.Count; i++)
                {
                    for (int j = i; j < Epochs.Count; j++)
                    {
                        if(String.Compare(Epochs[i], Epochs[j]) == 0 && j != i)
                        {
                            repetitions = i;
                            break;
                        }
                    }
                    if (repetitions != -1)
                        break;
                }

                if (repetitions != -1)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine(repetitions);
                    break;                    
                }               
                
                if(!checkLife(cells))
                {
                    Console.WriteLine("No");
                    Console.WriteLine(it);
                    break;
                }

                Reload(50, cells);
                foreach (var item in cells)
                {
                    if(item.Status)
                    {
                        if (item.Count < 2 || item.Count > 3)
                            item.Status = false;
                    }
                    else                    
                        if(item.Count == 3)
                            item.Status = true;
                }
                it++;                
            }            
        }
    }
}
