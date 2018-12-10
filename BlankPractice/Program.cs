using System;

namespace BlankPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student viv = new Student(); // created an instance of Student named viv
            viv.Name = "Vivian";
            Console.WriteLine("Hi there, " + viv.Name);
            viv.sayHi(); // have new object viv perform the Student class method sayHi

            Console.ReadLine();
        }
    }

    public class Student
    {

        // FIELDS!!!

        private string name;
        private int studentID;
        private int numberOfCredits = 0;
        private double gpa = 0;
        private string message = "Hi Viv."; // practice field

        // PROPERTIES!!!

        public string Name // accessors/getter and setter methods; private field + accessor methods = property
        {
            internal get { return name; }
            internal set { name = value; }
        }

        public int StudentID
        {
            internal get { return studentID; }
            internal set { studentID = value; }
        }

        public int NumberOfCredits
        {
            internal get { return numberOfCredits; }
            internal set { numberOfCredits = value; }
        }

        public double Gpa
        {
            internal get { return gpa; }
            internal set { gpa = value; }
        }

        // if accessibility level same for access method and accessors, can use the following shortcut:

        /*
        public string Name { get; set; }
        */


        // CONSTRUCTORS!!!
        public Student(string name, int studentID, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentID = studentID;
            NumberOfCredits = numberOfCredits; // Good for a transfer student
            Gpa = gpa;
        }

        public Student(string name, int studentID)
        {
            Name = name;
            StudentID = studentID;
            NumberOfCredits = 0; // Good for a brand new student
            Gpa = 0.0;
        }

        // Could also write the second constructor like this:
        /* public Student(string name, int studentId)
            : this(name, studentId, 0, 0.0) { }
            */


        // METHODS!!!

        public void sayHi() // practice method
        {
            string message = "No thanks, Viv."; // local variable (within method) vs. field (within class)
            Console.WriteLine(message); // will print "No thanks, Viv."
            Console.WriteLine(this.message); // will print "Hi Viv."
        }

    }
}
