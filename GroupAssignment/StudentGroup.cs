using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    internal class StudentGroup : Component
    {
        private string student;
        private List<Component> students;
        public StudentGroup(string v)
        {
            student = v;
            students = new List<Component>();
        }

        public override bool AddStudent(Component c)
        {
            students.Add(c);
            return true;
        }
        public override void StudentDetails()
        {
            Console.WriteLine(student);
            Console.WriteLine("**************");
            foreach (var item in students)
            {
                item.StudentDetails();
            }
            Console.WriteLine("\n");
        }
    }
}