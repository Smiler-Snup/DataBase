using System;
using System.Collections.Generic;

namespace CourseProject
{
    /// <summary>
    /// Класс является зачетной книжной, который хранит семестры студента
    /// </summary>
    [Serializable]
    class RecordBook
    {
        public List<Semester> Semesters { get; private set; }
        public RecordBook()
        {
            Semesters = new List<Semester>();
        }
        public RecordBook(List<Semester> semesters) : this()
        {
            foreach (var item in semesters)
            {
                Semesters.Add(item);
            }
        }
        public RecordBook(RecordBook recordBook)
        {
            Semesters = new List<Semester>();
            int number = 1;
            foreach (var item in recordBook.Semesters)
            {
                Semesters.Add(new Semester(item,number++));
            }
        }
        public void AddSemester(int NumberSemester,List<Discipline> disciplines)
        {
            Semester TempSemester = new Semester(NumberSemester,disciplines);
            Semesters.Add(TempSemester);
        }
        public override string ToString()
        {
            return Semesters[0].NumberOrder.ToString();
        }
    }
}
