using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    internal class Student : Component
    {
        private string fname;
        private string lname;
        private string email;
        private string dob;

        public Student(string fname, string lname, string email, string dob)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.dob = dob;
        }

        public override bool AddStudent(Component c)
        {
            throw new NotImplementedException();
        }

        public override void StudentDetails()
        {
            Console.WriteLine("Name: " + fname + "\nLast Name: " + lname + "\nEmail: " + email + "\nDate of Birth " + dob);
            Console.WriteLine();
        }
    }
}