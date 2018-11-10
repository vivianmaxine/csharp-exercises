using System;

namespace Class2ExercisesListsStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    private static int Print5LetterWords()
    {
        foreach (string word in words)
        {
            if (word.Count == 5)
            {
                Console.Write(word);
            }
        }
    }
}
