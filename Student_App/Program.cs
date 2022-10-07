using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_App
{
    internal class Program
    {
        static List<Course> courses = new List<Course>();
        static List<Student> students = new List<Student>();
        static List<Teacher> teachers = new List<Teacher>();

        static void Main(string[] args)
        {
            PreloadLists();
            Menu();

        } // Main

        public static void Menu()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("RTC Database");
                Console.WriteLine("1 - Display Teachers");
                Console.WriteLine("2 - Display Students");
                Console.WriteLine("3 - Display Classes");
                Console.WriteLine("4 - Exit Application");

                string userInput = Console.ReadLine();

                // if, switch
                switch (userInput)
                {
                    case "1":

                        DisplayTeachers(teachers);
                        break;
                    case "2":
                        DisplayStudentName(students);
                        break;
                    case "3":
                        DisplayCourses(courses);
                        break;
                    case "4":
                        isRunning = false;
                        break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Good Bye");
        } // Menu
        
        // Method to display class names from list of courses, takes a list<course>

        public static void DisplayTeachers(List<Teacher> teachers)
        {
            foreach (Teacher item in teachers)
            {
                Console.WriteLine($"Teacher Name: {item.FirstName} {item.LastName}");
            }
        }

        public static void DisplayStudentName(List<Student> students)
        {
            foreach (Student item in students)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }

        public static void DisplayCourses(List<Course> courses)
        {
            foreach (Course item in courses)
            {
                // DO A DOT
                Console.WriteLine(item.Name);
            }
        }


        public static void DisplayGrades(List<int> grades)
        {
            foreach (int item in grades)
            {
                Console.WriteLine(item);
            }
        }

        public static void RandomizeGrades(List<int> grades, int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                grades.Add(rand.Next(1, 101));
            }
        }

 

        public static void PreloadLists()
        {
            // Instance of an object
            Course prog120 = new Course("Programming 120", "J109");
            Course prog252 = new Course("Rich Internet Applications", "J107");
            Course prog122 = new Course("Programming 122", "J108");

            courses.Add(prog120);
            courses.Add(prog122);
            courses.Add(prog252);

            students.Add(new Student("Xulong", "Huang"));
            students.Add(new Student("Samantha", "Jimenez-Chable"));
            students.Add(new Student("Zach", "Zepezauer"));

            teachers.Add(new Teacher("Dimpy", "Gill"));
            teachers.Add(new Teacher("Will", "Cram"));
            teachers.Add(new Teacher("Josh", "Emery"));
            teachers.Add(new Teacher("Lhoucine", "Zerrouki"));


            prog120.AddStudent(students[0]);
            courses[1].AddStudent(students[1]);
            courses[2].AddStudent(students[2]);
        }

        public static void Examples()
        {






            //Teacher josh = new Teacher("Josh", "Emery");
            //Console.WriteLine(prog252.Name);

            //Console.WriteLine(prog252.Teacher.FirstName + " " + prog252.Teacher.LastName);
            //Console.WriteLine(prog252.Teacher.EmpId);
        }
    }
}
