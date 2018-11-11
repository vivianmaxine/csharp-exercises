using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercisesDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize new dictionary called "students" with string key and int value.
            // Create a string to represent each instance of a new students called "newStudent"
            Dictionary<string, int> students = new Dictionary<string, int>();
            string newStudent;

            Console.WriteLine("Type in a student or press ENTER when finished.");

            do
            {
                Console.Write("Name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    Console.Write("ID: ");
                    int newID = int.Parse(Console.ReadLine());
                    students.Add(newStudent, newID);
                }
            }
            while (newStudent != "");

            Console.WriteLine("\n**STUDENT ROSTER**");
            /*
            foreach (KeyValuePair<string, int> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }
            */

            // Instead of Above, Use String Builder Below
            StringBuilder newLoopRoster = new StringBuilder();
            foreach (KeyValuePair<string, int> student in students)
            {
                newLoopRoster.Append(" | ");
                newLoopRoster.Append(student);
            }

            Console.WriteLine(newLoopRoster);
            Console.ReadLine();
        }
    }
}
