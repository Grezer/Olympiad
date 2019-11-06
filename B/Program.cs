using System;

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


        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            Cell[,] cells = new Cell[50, 50];
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
            while(it < 100)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(cells[i + 20, j + 20].Status ? "*" : "x");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
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
