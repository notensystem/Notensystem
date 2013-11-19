using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notensystem.Domain
{
    /// <summary>
    /// Notenschlüssel
    /// </summary>
    public class GradingKey : IDatabaseObject
    {
        public int Id { get; set; }
        public double Percent { get; set; }
        public int Grade { get; set; }
    }
}
