using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notensystem.Domain
{
    public class Class : IDatabaseObject
    {
        public int Id { get; set; }
        private List<Subject> subjects;
        public ObservableCollection<Subject> Subjects
        {
            get
            {
                if (subjects == null)
                {
                    subjects = new List<Subject>();
                }
                return new ObservableCollection<Subject>(subjects);
            }
        }

        private List<Student> students;
        public ObservableCollection<Student> Students
        {
            get
            {
                if (students == null)
                {
                    students = new List<Student>();
                }
                return new ObservableCollection<Student>(students);
            }
        }

        public string Name { get; set; }

        public Class(string name)
        {
            Name = name;
        }

        public Class(string name, List<Subject> subjects)
            : this(name)
        {
            this.subjects = subjects;
        }

        public void AddSubjects(IEnumerable<Subject> subj)
        {
            foreach (Subject s in subj)
            {
                subjects.Add(s);
            }
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        public void RemoveSubject(Subject subject)
        {
            subjects.Remove(subject);
        }
    }
}
