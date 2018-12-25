

//              Challenge: Student Manager
//  1. Get student name and grade from console input
//  2. Able to handle any number of students
//  3. Display all students names and grades once the user finishes adding students
//  4. Use a list instead of an array so that additional students can be added at any time
//  5. Gather more information about student and display info in console, neatly formatted


using System;
using System.Collections.Generic;

namespace Student_Manager_List_Challenge
{
    //  I create a Pupil struct to carry info of students
    // more info variables could be added to Pupil struct 
    // to add more details about each Pupil
    struct Pupil
    {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private string phoneNumber;
        //  below is a "Property" a way to set private variable
        // without using a setter function. (Replaces setter function)
        public string PhoneNumber
        {
            set { phoneNumber = value; }
        }
        // setter function (not needed)
        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public string getPhoneNumber()
        {
            return  phoneNumber;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Pupil>();
            var isMoreStudents = true;



               while(isMoreStudents)
            {
                var p = new Pupil();

                Console.Write("Student Name: ");
                p.Name = Console.ReadLine();

                Console.Write("Student Grade: ");
                p.Grade = int.Parse(Console.ReadLine());

                Console.Write("Student Birthday (dd/mm/yy): ");
                p.Birthday = Console.ReadLine();

                Console.Write("Student Address: ");
                p.Address = Console.ReadLine();

                Console.Write("Student Phone Number: ");
                p.setPhoneNumber(Console.ReadLine());

                students.Add(p);

                Console.Write("Add another student (y/n): ");
                
                if(Console.ReadLine() != "y")
                {
                    isMoreStudents = false;
                }

            }

            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("    Student Name    | Grade | Birthday |         Address         |   Phone Number   | ");
            Console.WriteLine("--------------------------------------------------------------------------------------");

            //   'For each' <span style='bold'>student</span> in List, students, Console.WriteLine...
            foreach (var student in students)
            {
                // formatting below lines up well in the console
                Console.WriteLine(String.Format("{0,-19} | {1,-5} | {2,-8} | {3,-23} | {4,-16} |", 
                    student.Name, student.Grade, student.Birthday, student.Address, student.getPhoneNumber()));
            }

            Console.WriteLine("--------------------------------------------------------------------------------------");


            Console.ReadLine();
        }
    }
}
