using System;

namespace CourseProject
{
    /// <summary>
    /// Базовый абстрактный класс дисциплина, является родителем для класса Credit и Exam
    /// </summary>
    [Serializable]
    abstract class Discipline
    {
        public string NameDiscipline { get; set; }
        public int NumberHours { get; set; }
        public string NameTeacher { get; set; }
        public Discipline(string nameDiscipline,int numberHours,string nameTeacher)
        {
            NameDiscipline = nameDiscipline;NumberHours = numberHours;NameTeacher = nameTeacher;
        }
        public override string ToString()
        {
            return NameDiscipline;
        }
        public abstract string GetSuccess();
    }
}
