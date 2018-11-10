using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // ***REVIEW TRIM AT 16:30 IN THE VIDEO WORKING WITH STRINGS***

            // Use \ before character to allow double quotes within the string ""
            // Use \n to create a line break (e.g., Line one \nLine 2)
            string vivsString = "My \"favorite\" task \nis this";
            Console.WriteLine(vivsString);
            Console.ReadLine();

            // Tells us to use \ as characters only, not escape sequences
            string vivString2 = @"Go to your c:\ drive";
            Console.WriteLine(vivString2);
            Console.ReadLine();

            // Replace a character
            string stringReplace = "My_name_is_Vivian!";
            stringReplace = stringReplace.Replace("_", " ");
            Console.WriteLine(stringReplace);
            Console.ReadLine();

            // Grabs a portion of a string (start, length)
            string stringStrip = " I am at Peet's Coffee.  ";
            stringStrip = stringStrip.Substring(9, 13);
            Console.WriteLine(stringStrip);
            Console.ReadLine();

            // Can also remove characters with myString.Remove(start, length);

            // For all Uppercase, use myString = myString.ToUpper();

            string myLoopString = "";
            for (int i = 0; i <= 10; i++)
            {
                myLoopString += "*" + i.ToString();
            }
            Console.WriteLine(myLoopString);
            Console.ReadLine();

            // Instead of Above, Use String Builder Below
            StringBuilder myNewLoopString = new StringBuilder();
            for (int j = 0; j <= 10; j++)
            {
                myNewLoopString.Append("*");
                myNewLoopString.Append(j);
            }

            Console.WriteLine(myNewLoopString);
            Console.ReadLine();
 

            // The .Format method
            string vivString3 = String.Format("{1} & {0}", "Miles", "Dominic");
            Console.WriteLine(vivString3);
            Console.ReadLine();

            // Use {__:P} to format as a percent

            // Create a custom format
            string phoneNumber = string.Format("Phone Number: {0:(###) ###-####}", 5738556212);
            Console.WriteLine(phoneNumber);
            Console.ReadLine();


            // Format numbers with commas and decimals to hundredths by using {__:N}
            string commaString = String.Format("{0:N} OR {1:N} OR {2:N}", 3746473739, 23434, 929283847);
            Console.WriteLine(commaString);
            Console.ReadLine();


            // Format numbers for U.S. currency by using {__:C}
            string currencyString = String.Format("{0:C} or {1:C}", 54.70, 13.46);
            Console.WriteLine(currencyString);
            Console.ReadLine();

        }
    }
}
