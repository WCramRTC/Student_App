using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_App
{
    internal class Course
    {

        // fields
        /*
         * Course
         * string teacher
         * List<string> students
         * List<int> grades
         * string name
         * string room
         *              */
        Teacher _teacher;
        List<Student> _students;
        List<int> _grades;
        string _name;
         string _room;

        // constructor
        // access modifier - no return type - name = class name - parameters
        public Course(string name, string room)
        {
            _name = name;
            _room = room;
            _students = new List<Student>();
            _grades = new List<int>();

        } // constructor

        // Overloading
        public Course(string name)
        {
            _name = name;
            _students = new List<Student>();
            _grades = new List<int>();
        } 

        public Course(string name, string room, Teacher teacher)
        {
            _name = name;
            _room = room;
            _teacher = teacher;
            _students = new List<Student>();
            _grades = new List<int>();
        }

        // property
        // access modifier - return type ( same as the field ) - name ( same as field ) - no paremeters
        public Teacher Teacher
        {
            // getter / setter
            get // What we use to read the information
            {
                return _teacher;
            }
            set // is used to change the value of a field
            {
                _teacher = value; // value is what the user is assigning
            }


        } // Teacher

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        } // Name

        public string Room
        {
            get => _room;
            set => _room = value;
        }

        public List<Student> Students
        {
            get
            {
                return _students;
            }
  
        }
 
        // method

        public List<int> Grades
        {
            get => _grades;
        } // Grades

        // Method
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void AddStudent(string firstName, string lastName)
        {
            Student s = new Student(firstName, lastName);
            _students.Add(s);
        }

        public double CourseAverage()
        {
            int sum = 0;

            foreach (int grade in _grades)
            {
                sum += grade;
            }

            double average = (double)sum / (double)_grades.Count;
            return average;
        }


    } // class

    // Allow other parts of code to get access to our code
    // Access Modifier
    // public
    // private
    // internal
    // protected

} // namespace
