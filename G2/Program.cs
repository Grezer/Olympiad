using System;

namespace G2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myString = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            float subjectCount = Convert.ToUInt64(myString[0]) - 1;
            float totalPoints = Convert.ToUInt64(myString[1]) - 1;
            Console.WriteLine((factorial(totalPoints) / (factorial(totalPoints - subjectCount) * factorial(subjectCount))) % Convert.ToUInt64(Math.Pow(10, 9) + 7));
        }
        public static float factorial(float input)
        {
            float result = 1;
            for (float i = input; i > 1; i--)
                result *= i;
            return result;
        }
    }
}
