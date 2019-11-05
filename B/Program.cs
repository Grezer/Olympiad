using System;

namespace B
{
    class Program
    {
        //bool[,] cells;
        class Cell
        {
            public bool Status = false;
            public int Count = 0;
            public Cell()
            {
                Status = false;
                Count = 0;
            }
            public void Reload(int size, Cell[,] cells)
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
                        Count = Sum;
                    }
            }

            public int Check(int x, int y, int size, Cell[,] cells)
            {
                if (x < 0 || x == size || y < 0 || y == size)
                    return 0;
                return Convert.ToInt32(Status);
            }

        }
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            Cell[,] cells = new Cell[size, size];
            for (int i = 0; i < size; i++)            
                for (int j = 0; j < size; j++)                
                    cells[i, j] = new Cell();           
            for (int i = 0; i < size; i++)
            {
                string inputLine = Console.ReadLine();
                for (int j = 0; j < size; j++)                
                    if (inputLine[j] == '*') 
                        cells[i, j].Status = true;                
            }
            Console.WriteLine();

            int it = 0;
            while(it < 100)
            {
                cells.Reload(size, cells);
                it++;                
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(cells[i, j].Status ? "*" : "x");
                }
                Console.WriteLine();
            }
        }
    }
}
