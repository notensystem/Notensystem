using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notensystem.Domain
{
    public class Weight : IDatabaseObject
    {
        public int Id { get; set; }
        public double Percent { get; set; }

        public Weight(int id, double percent)
        {
            Id = id;
            Percent = percent;
        }
    }
}
