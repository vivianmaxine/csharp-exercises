using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogAgesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxDogs = 10;

            string[] dogs = new string[maxDogs];
            int[] ages = new int[maxDogs];

            string newDog;
            int numDogs = 0;

            Console.WriteLine("Enter the name of the dog: ");

            do
            {
                newDog = Console.ReadLine();
                if (newDog != "")
                {
                    dogs[numDogs] = newDog;
                    numDogs++;
                }
            }
            while (newDog != "" && numDogs < maxDogs);

            // Get student grades
            for (int i = 0; i < numDogs; i++)
            {
                Console.Write("Age for " + dogs[i] + ": ");
                int dogAge = int.Parse(Console.ReadLine());
                ages[i] = dogAge;
            }

            // Print roster of dogs, summing ages
            Console.WriteLine("\nDOG ROSTER:");
            int sum = 0;
            // Must use explicit index; "i" separate from "j" index
            for (int j = 0; j < numDogs; j++)
            {
                Console.WriteLine(dogs[j] + " (" + ages[j] + ")");
            }
            

            for (int j = 0; j < numDogs; j++)
            {
                sum += ages[j];
            }

            int avg = sum / numDogs;
            Console.WriteLine("Average Age of Dogs: " + avg);
            Console.ReadLine();
            
        }
    }
}
