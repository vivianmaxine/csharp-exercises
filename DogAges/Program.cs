using System;
using System.Collections.Generic;
using System.Linq;

namespace DogAges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Establish dog list
            List<string> dogs = new List<string>();
            //Establish age list
            List<int> ages = new List<int>();

            string newDog;

            Console.WriteLine("Enter your dog's name or press ENTER to finish.");

            // Add new dogs as needed
            do
            {
                newDog = Console.ReadLine();
                if (newDog != "")
                {
                    dogs.Add(newDog);
                }
            }
            while (newDog != "");


            // Get dog ages
            foreach (string dog in dogs)
            {
                Console.WriteLine(dog + " is this many years old: ");
                int newAge = int.Parse(Console.ReadLine());
                ages.Add(newAge);
            }

            // Use i for index of a list item while looping (loop index)
            // ___.Count gives the number of items in a list via integer
            Console.WriteLine("\nOur Dogs:");
            for (int i = 0; i < dogs.Count; i++)
            {
                Console.WriteLine(dogs[i] + " (" + ages[i] + ")");
            }
            // Find sum of dogs' ages
            int sum = ages.Sum();
            int avg = sum / ages.Count;
            Console.WriteLine("Average age:" + avg);
            Console.ReadLine();
        }
    }
}
