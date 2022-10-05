using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_App
{
    internal class Student
    {
        // Student
        // string firstName
        // string lastName
        // string studentId
        // List<Course> courses
        string _firstName;
        string _lastName;
        string _studentId;
        List<Course> _courses;

        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public string StudentId
        {
            get => _studentId;
           
        }

        public List<Course> Course
        {
            get => _courses;
        }

    } // class

} // namespace
