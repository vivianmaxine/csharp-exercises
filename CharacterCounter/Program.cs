using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string longString = "Lorem ipsum dolor " +
                "sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque " +
                "sollicitudin. Ut at sagittis augue. Praesent " +
                "quis rhoncus justo. Aliquam erat volutpat. " +
                "Donec sit amet suscipit metus, non lobortis " +
                "massa. Vestibulum augue ex, dapibus ac " +
                "suscipit vel, volutpat eget massa. Donec nec " +
                "velit non ligula efficitur luctus.";

            var charCount = CharacterCounter.Count(longString);

            foreach (var character in charCount)
            {
                Console.WriteLine("{0} ({1})", character.Key, character.Value);
            }
        }
    }
}
