using System;

namespace AreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop with range examples below
            for (int n = 10; n < 21; n++)
            {
                Console.WriteLine(n);
            }

            for (int v = 50; v > 0; v -= 10)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("What is the radius of your circle?");
            string radiusString = Console.ReadLine();
            double circleArea = CalculateCircleArea(radiusString);
            Console.WriteLine("The area of your circle is: " + circleArea + " squared units");
            Console.ReadLine();
        }

        private static double CalculateCircleArea(string radius_string)
        {
            int radius = int.Parse(radius_string);
            //return Math.Round(Math.PI * Math.Pow(radius, 2), 3);
            int radius_squared = radius * radius;
            double circleArea = 3.14 * radius_squared;
            return circleArea;
        }
    }
}
