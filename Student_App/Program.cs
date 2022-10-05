using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Examples();
        }

        public static void Examples()
        {
            // Instance of an object
            Course prog120 = new Course("Programming 120", "J109");

            //prog120.Teacher = "William Cram";

            Teacher josh = new Teacher("Josh", "Emery");

            Course prog252 = new Course("Rich Internet Applications", "J107", josh);


            Console.WriteLine(prog252.Name);

            Console.WriteLine(prog252.Teacher.FirstName + " " + prog252.Teacher.LastName);
            Console.WriteLine(prog252.Teacher.EmpId);
        }
    }
}
