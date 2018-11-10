using System;

namespace Class2ExercisesLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>(1, 2, 3, 4, 5);
        }
    }

    private static int AddEvenNums()
    {
        int evenSum = 0;
        foreach (int number in numList)
        {
            if (number % 2)
            {
                evenSum += number;
            }
        }

        return evenSum;
{        
    }
}
