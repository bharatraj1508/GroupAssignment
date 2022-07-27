using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    internal abstract class Component
    {
        public abstract void StudentDetails();
        public abstract bool AddStudent(Component c);
    }
}