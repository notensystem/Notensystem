using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notensystem.Domain
{
    public class Subject : IDatabaseObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<EvaluationType> EvaluationType { get; set; }

        private List<Evaluation> evaluations;
        public ObservableCollection<Evaluation> Evaluations
        {
            get
            {
                if (evaluations == null)
                {
                    evaluations = new List<Evaluation>();
                }
                return new ObservableCollection<Evaluation>(evaluations);
            }
        }

        public void AddEvaluations(List<Evaluation> evaluations)
        {
            foreach (var e in evaluations)
            {
                this.evaluations.Add(e);
            }
        }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
            evaluations = new List<Evaluation>();
        }
    }
}
