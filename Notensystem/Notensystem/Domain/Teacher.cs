using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notensystem.Domain
{
    public class Teacher : Person
    {
        public Teacher(int id, string firstName, string lastName)
            : base(id, firstName, lastName) { }
    }
}
