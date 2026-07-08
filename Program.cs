using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEC1Con_Lib
{
    /// <summary>
    /// Class student to demonstrate the use of methods in C#.
    /// </summary>
    class Student
    {
        /// <summary>
        /// Fields to store student details: Roll Number, Name, and Course.
        /// </summary>
        public int RollNo;
        public string Name;
        public string Course;

        /// <summary>
        /// Gets student data from user input and stores it in the fields.
        /// </summary>
        public void GetStudentData()
        {
            Console.Write("Enter Roll Number : ");
            RollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name : ");
            Name = Console.ReadLine();

            Console.Write("Enter Course : ");
            Course = Console.ReadLine();
        }

        /// <summary>
        /// Displays the student data stored in the fields to the console.
        /// </summary>
        public void DisplayStudentData()
        {
            Console.WriteLine("\n===== Student Details =====");
            Console.WriteLine("Roll Number : " + RollNo);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Course      : " + Course);
        }

        /// <summary>
        /// Main method to create a Student object, get student data, and display it.
        /// </summary>
        static void Main()
        {
            Student s = new Student();

            s.GetStudentData();
            s.DisplayStudentData();

            Console.ReadKey();
        }
    }
}
