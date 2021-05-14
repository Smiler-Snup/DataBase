using System;
using System.Collections.Generic;

namespace CourseProject
{
    /// <summary>
    /// Класс явялется семестром, который хранит список дисциплин студента
    /// </summary>
    [Serializable]
    class Semester
    {
        public List<Discipline> Disciplines { get; private set; }
        public int NumberOrder {get; set;}
        public Semester(int number,List<Discipline> disciplines)
        {
            Disciplines = new List<Discipline>();
            foreach(var item in disciplines)
            {
                if(item is Exam)
                    Disciplines.Add(new Exam(item as Exam));
                else
                    Disciplines.Add(new Credit(item as Credit));
            }
            NumberOrder = number;
        }
        public Semester(Semester semester,int number)
        {
            Disciplines = new List<Discipline>();
            NumberOrder = number;
            foreach (var item in semester.Disciplines)
            {
                
                if (item is Exam)
                    Disciplines.Add(new Exam(item as Exam));
                else
                    Disciplines.Add(new Credit(item as Credit));
            }
        }
        public void ChangeListDisciplines(List<Discipline> disciplines)
        {
            Disciplines.Clear();
            foreach (var item in disciplines)
            {
                if (item is Exam)
                    Disciplines.Add(new Exam(item as Exam));
                else
                    Disciplines.Add(new Credit(item as Credit));
            }
        }
    }
}
