using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStringWindows = Console.ReadLine();
            int y = Convert.ToInt32(inputStringWindows.Split(" ")[0]);
            int x = Convert.ToInt32(inputStringWindows.Split(" ")[1]);
            bool[,] windows = new bool[y, x];
            for (int i = 0; i < y; i++)
            {
                string inputWindows = Console.ReadLine().Replace(" ", "");
                for (int j = 0; j < x; j++)                
                    windows[i, j] = inputWindows[j] == '1' ? true : false;                
            }
            string inputStringImage = Console.ReadLine();
            int yP = Convert.ToInt32(inputStringImage.Split(" ")[0]);
            int xP = Convert.ToInt32(inputStringImage.Split(" ")[1]);
            bool[,] image = new bool[yP, xP];
            for (int i = 0; i < yP; i++)
            {
                string inputWindowsImage = Console.ReadLine();
                for (int j = 0; j < xP; j++)
                    image[i, j] = inputWindowsImage[j] == '1' ? true : false;                
            }

            int iterator = 0;
            for (int i1 = 0; i1 < y-yP+1; i1++)            
                for (int j1 = 0; j1 < x-xP+1; j1++)
                {
                    bool check = true;         
                    for (int i = 0; i < xP; i++)                    
                        for (int j = 0; j < yP; j++)                        
                            if (image[i, j] && windows[i1+i, j1+j] == false) check = false;
                    if (check) iterator++;
                }
            Console.WriteLine(iterator);
        }
    }
}
