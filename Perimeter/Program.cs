using System;

namespace Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height:");
            string heightInput = Console.ReadLine();

            Console.WriteLine("Enter width:");
            string widthInput = Console.ReadLine();

            // Calculate perimeter
            int perimeter = CalculatePerimeter(heightInput, widthInput);

            // Print perimeter
            Console.WriteLine("Perimeter: " + perimeter);
            Console.ReadLine();
        }

        // The below is like a function (a.k.a. a method for C#)
        private static int CalculatePerimeter(string the_height, string the_width) {
            int perimeter = 0;
            int height = int.Parse(the_height);
            int width = int.Parse(the_width);
            // int.Parse converts string to integer

            perimeter = 2 * height + 2 * width;

            return perimeter;
        }
    }
}
