using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notensystem.Domain
{
    public class Evaluation : IDatabaseObject
    {
        public int Id { get; set; }
        public double Reached { get; set; }
        public Student Student { get; set; }
        public EvaluationType EvaluationType { get; set; }

        public Evaluation(int id)
        {
            Id = id;
        }
    }
}
