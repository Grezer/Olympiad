using System;
using System.Collections.Generic;

namespace E
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            Dictionary<int, List<int>> rooms = new Dictionary<int, List<int>>();
            int countOfRooms = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= countOfRooms; i++)
                rooms[i] = new List<int>();
            for (int i = 0; i < countOfRooms; i++)
            {
                string inputDors = Console.ReadLine();
                rooms[Convert.ToInt32(inputDors.Split(" ")[0])].Add(Convert.ToInt32(inputDors.Split(" ")[1]));
            }

            List<int> lastRoom = new List<int>();
            for (int i = 0; i <= countOfRooms; i++)
                if (rooms[i].Count == 0)
                    lastRoom.Add(i);

            go(0, 1, rooms, result);
            for (int i = 0; i < result.Count; i++)     
                if(lastRoom.Contains(i))
                    Console.WriteLine(i + ": 1/" + result[i]);
        }

        public static void go(int nowRoom, int main, Dictionary<int, List<int>> rooms, Dictionary<int, string> result)
        {            
            result[nowRoom] = main.ToString();
            int countOfChilds = rooms[nowRoom].Count;
            if (countOfChilds == 0) return;
            foreach (var item in rooms[nowRoom])
                go(item, main * countOfChilds, rooms, result);              
        }
    }
}
