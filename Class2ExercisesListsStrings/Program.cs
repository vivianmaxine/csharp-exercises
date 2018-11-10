using System;
using System.Collections.Generic;
using System.Linq;

namespace Class2ExercisesListsStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWordList = new List<string>();
            string newWord;

            Console.WriteLine("Type a word you'd like to add to your word list or click ENTER when finished.");

            do
            {
                newWord = Console.ReadLine();
                if (newWord != "")
                {
                    myWordList.Add(newWord);
                }
            }
            while (newWord != "");

            Console.WriteLine(String.Join(", ", myWordList.ToArray()));
            Console.ReadLine();

            List<string> my5LetterWordList = Print5LetterWords(myWordList);
            Console.WriteLine(String.Join(", ", my5LetterWordList.ToArray()));
            Console.ReadLine();
        }

        private static List<string> Print5LetterWords(List<string> wordList)
        {
            List<string> changingList = new List<string>();

            foreach (string word in wordList)
            {
                if (word.Length == 5)
                {
                    changingList.Add(word);
                }
            }

            return changingList;
        }
    }
}
