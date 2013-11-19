using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notensystem.Domain
{
    public class Student : Person
    {
        public Student(int id, string firstName, string lastName)
            : base(id, firstName, lastName) { }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
