using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Component group = new StudentGroup("Students List");
            do {
                Console.WriteLine("1. Enter Student Details");
                Console.WriteLine("2. Student Details");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Component std = CreateStudent();
                    if (group.AddStudent(std))
                    {
                        Console.WriteLine("Studemt Added");
                    }
                    else
                    {
                        Console.WriteLine("Unable to add student");
                    }
                }
                if(choice == 2)
                {
                    group.StudentDetails();
                }
            }
            while(choice !=0);
        }
        static Student CreateStudent()
        {
            Console.Write("Enter Student Frist Name: ");
            string fname = Console.ReadLine();
            Console.Write("Enter Student Last Name: ");
            string lname = Console.ReadLine();
            Console.Write("Enter Student Email ID: ");
            string email = Console.ReadLine();
            Console.Write("Enter Student Date of Birth: ");
            string dob = Console.ReadLine();

            return new Student(fname, lname, email, dob);
        }
    }
}
