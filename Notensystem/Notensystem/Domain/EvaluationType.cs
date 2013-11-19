using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notensystem.Domain
{
    public class EvaluationType : IDatabaseObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Weight Weight { get; set; }

        public EvaluationType(int id, string name, Weight weight)
        {
            Id = id;
            Name = name;
            Weight = weight;
        }
    }
}
