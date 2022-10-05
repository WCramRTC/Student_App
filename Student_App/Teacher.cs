using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_App
{
    internal class Teacher
    {

        // Teacher
        // string firstName
        // string lastName
        // string empId
        // List<Course> courses
        string _firstName;
        string _lastName;
        string _empId;
        List<Course> _courses;

        // Constructor
        // access modifier - no return type - name same as class - parameters
        public Teacher(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;

            Random rand = new Random();
            _empId = rand.Next(10000, 99999).ToString();
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

        public string EmpId
        {
            get => _empId;
        }

        public List<Course> Courses
        {
            get => _courses;
        }

    } // class

} // namespace
