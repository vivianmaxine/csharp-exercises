using System;
using System.Collections.Generic;
using System.Linq;

namespace DogAgesDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dogs = new Dictionary<string, int>();
            string newDog;

            Console.WriteLine("Enter the dog's name: ");

            do
            {
                Console.WriteLine("Name: ");
                newDog = Console.ReadLine();
                if (newDog != "") // Get dog's age
                {
                    Console.WriteLine("Age: ");
                    int newAge = int.Parse(Console.ReadLine());
                    dogs.Add(newDog, newAge);
                }
            }
            while (newDog != "");

            // Print Roster
            Console.WriteLine("\nDOG ROSTER");
            foreach (KeyValuePair<string, int> dog in dogs)
            {
                Console.WriteLine(dog.Key + " (" + dog.Value + ")");
            }

            // Print Average
            int sum = dogs.Values.Sum();
            int avg = sum / dogs.Count();
            Console.WriteLine("The average age of the dogs is: " + avg);
            Console.ReadLine();
        }
    }
}
