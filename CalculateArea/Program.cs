using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the width?");
            string width_input = Console.ReadLine();

            Console.WriteLine("What is the height?");
            string height_input = Console.ReadLine();

            int area = CalculateArea(width_input, height_input);

            Console.WriteLine("Area: " + area + " squared units");
            Console.ReadLine();

        }

        // Method for the above class Program
        private static int CalculateArea(string string_width, string string_height) {
            // int area = 0; << Don't need to do this for this function
            int width = int.Parse(string_width);
            int height = int.Parse(string_height);
            int area = width * height;

            return area;
        }
    }
}
