using System;
using System.Collections.Generic;

namespace Class2ExercisesLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myNumList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            int mySumOfEvens = AddEvenNums(myNumList);
            Console.WriteLine("The sum of my even numbers is " + mySumOfEvens);
            Console.ReadLine();
        }

        private static int AddEvenNums(List<int> numList)
        {
            int evenSum = 0;
            foreach (int num in numList)
            {
                if (num % 2 == 0)
                {
                    evenSum += num;
                }
            }

            return evenSum;
        }
    }
}
