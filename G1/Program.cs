using System;

namespace G1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myString = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int subjectCount = Convert.ToInt32(myString[0]) - 1;
            int totalPoints = Convert.ToInt32(myString[1]) - 1;
            Console.WriteLine(factorial(totalPoints) / (factorial(totalPoints - subjectCount) * factorial(subjectCount)));
        }
        public static int factorial(int input)
        {
            int result = 1;
            for (int i = input; i > 0; i--)
                result *= i;
            return result;
        }
    }
}
