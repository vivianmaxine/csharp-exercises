using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AliceInWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            string aliceWords = "Alice was beginning to get very tired " +
               "of sitting by her sister on the bank, and of having nothing " +
               "to do: once or twice she had peeped into the book her sister " +
               "was reading, but it had no pictures or conversations in it, " +
               "'and what is the use of a book,' thought Alice 'without " +
               "pictures or conversation?'";

            string[] wordArray = formatString(aliceWords);
            string wordString = String.Join(" ", wordArray);
            Console.WriteLine(wordString);
            Console.ReadLine();

            Console.WriteLine("Enter a word to search.");
            string wordInQuestion = Console.ReadLine();

            string trueOrFalseWord = findWord(wordInQuestion, wordArray);
            Console.WriteLine(trueOrFalseWord);
            Console.ReadLine();

        }

        // Create a function that removes all special characters and returns long string as a list
        private static string[] formatString(string longString)
        {

            longString = new Regex(",|:|\\?|'").Replace(longString, "");

            // Create list for each word, separating by space
            string[] singleWordList = longString.Split(' ');

            return singleWordList;
        }

        // Create a function that takes an input word and searches for it in the the list; return true if present
        private static string findWord(string wordToSearch, string[] wordList)
        {
            foreach (string word in wordList)
            {
                if (word == wordToSearch)
                {
                    return "True.";
                }
            }

            return "False.";
        }
    }
}
