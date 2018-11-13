using System;
using System.Collections.Generic;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            
            string longString = @"Lorem ipsum dolor " +
                "sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque " +
                "sollicitudin. Ut at sagittis augue. Praesent " +
                "quis rhoncus justo. Aliquam erat volutpat. " +
                "Donec sit amet suscipit metus, non lobortis " +
                "massa. Vestibulum augue ex, dapibus ac " +
                "suscipit vel, volutpat eget massa. Donec nec " +
                "velit non ligula efficitur luctus.";

            foreach (char character in longString)
            {
                if (charCount.ContainsKey(character)) // If character already in dictionary...
                {
                    charCount[character]++; //charCount[character] += 1;
                }
                else // If character not yet in dictionary...
                {
                    charCount.Add(character, 1); //... add dictionary item with key of given character and value of 1
                }
            }

            // Below loops through and actually shows the dictionary results
            foreach (KeyValuePair<char, int> soloCharacterCount in charCount)
            {
                Console.WriteLine(soloCharacterCount.Key + ": " + soloCharacterCount.Value);
            }

            Console.ReadLine();


            /* while (longString.Length > 0)
            {
                Console.Write(longString[0] + ": ");
                int count = 0;
                for (int j = 0; j < longString.Length; j++)
                {
                    if (longString[0] == longString[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                longString = longString.Replace(longString[0].ToString(), string.Empty);
            }
            Console.ReadLine(); */

        }
    }
}
