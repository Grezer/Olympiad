using System;

namespace G2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myString = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long subjectCount = Convert.ToInt32(myString[0]) - 1;
            long totalPoints = Convert.ToInt32(myString[1]) - 1;
            Console.WriteLine((factorial(totalPoints) / (factorial(totalPoints - subjectCount) * factorial(subjectCount))) % (Math.Pow(10, 9) + 7));
        }
        public static long factorial(long input)
        {
            long result = 1;
            for (long i = input; i > 0; i--)
                result *= i;
            return result;
        }
    }
}
