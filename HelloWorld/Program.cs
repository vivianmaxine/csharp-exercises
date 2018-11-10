using System; // So we can type Console.__ instead of System.Console.___

namespace HelloWorld // A namespace helps us organize code too
{
    class Program // The Program class is a container for all related methods of application
    {
        static void Main(string[] args) // Method code block; first method to be called when executed
        {
            Console.WriteLine("Hi! What is your name?");
            string name_input = Console.ReadLine();
            Console.WriteLine("Hello, " + name_input);
            Console.ReadLine();
            
            // C# library (general library), Console class (book), WriteLine method (chapter)
        }
    }
}

// Method is a block of code that has a name (for now... more complex than that)
// Class helps us organize our methods
// () help us invoke/exectute a class method; do it now, and pass in any info included in (); code is being called in () when executed
// Console._______ class >> short for System.Console._______ (namespace.class)