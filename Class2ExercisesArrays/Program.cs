using System;

namespace Class2ExercisesArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize an array with the following
            //values: 1, 1, 2, 3, 5, 8.
            int[] myNumberArray = new int[] { 1, 1, 2, 3, 5, 8 };

            // Loop through the array and print out each value.
            foreach (int number in myNumberArray)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
