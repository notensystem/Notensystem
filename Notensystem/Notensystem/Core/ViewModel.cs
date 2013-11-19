using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notensystem.Domain;

namespace Notensystem.Core
{
    public class ViewModel
    {
        public Year CurrentYear { get; set; }
        public Period CurrentPeriod { get; set; }
        public Class CurrentClass { get; set; }
        public Subject CurrentSubject { get; set; }
        
        public bool CanLogin()
        {
            return true;
        }

        public List<Class> GetClassesByCycle(int cycle)
        {
            return null;
        }

        public List<Class> GetDummyClasses()
        {
            List<Class> classes = new List<Class>();
            for (int i = 1; i < 5; i++)
            {
                classes.Add(new Class(string.Format("{0} A", i)));
            }
            return classes;
        }

        public List<Subject> GetDummySubjects()
        {
            List<Subject> subjects = new List<Subject>();
            subjects.Add(new Subject(1, "Deutsch"));
            subjects.Add(new Subject(2, "Englisch"));
            subjects.Add(new Subject(3, "Mathematik"));
            return subjects;
        }

        public List<Evaluation> GetDummyEvaluations()
        {
            List<Evaluation> evaluations = new List<Evaluation>();

            Weight weight = new Weight(1, 40);
            EvaluationType type = new EvaluationType(1, "MAK", weight);
            Evaluation e = new Evaluation(1);
            
            e.Student = new Student(1, "Fabian", "Weber");
            e.Reached = 50.6;
            e.EvaluationType = type;
            evaluations.Add(e);

            return evaluations;
        }
    }
}
