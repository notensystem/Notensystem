using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notensystem.Domain
{
    public class Period : IDatabaseObject
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }

        private List<Class> classes;
        public ObservableCollection<Class> Classes { get { return new ObservableCollection<Class>(classes); } }

        public Period(int value, string name)
        {
            Value = value;
            Name = name;
            classes = new List<Class>();
        }

        public void AddClasses(IEnumerable<Class> cl)
        {
            foreach (Class c in cl)
            {
                classes.Add(c);
            }
        }
    }
}
