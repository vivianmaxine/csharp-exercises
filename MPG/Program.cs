using System;

namespace MPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles did you drive today?");
            string miles_input = Console.ReadLine();

            Console.WriteLine("How many gallons of gas did you use today?");
            string gas_input = Console.ReadLine();

            int mpg = CalculateMPG(miles_input, gas_input);

            Console.WriteLine("Miles per Gallon: " + mpg + " m.p.g.");
            Console.ReadLine();
        }

        private static int CalculateMPG(string the_miles, string the_gallons) {
            int miles = int.Parse(the_miles);
            int gallons = int.Parse(the_gallons);
            int mpg = miles / gallons;

            return mpg;
        }
    }
}
