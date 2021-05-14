using System;

namespace CourseProject
{
    /// <summary>
    /// Класс для представления сущности зачета
    /// </summary>
    [Serializable]
    class Credit:Discipline
    {
        public bool Passed { get; set; }
        public Credit(string nameDiscipline, int numberHours, string nameTeacher,bool passed) : base(nameDiscipline,numberHours,nameTeacher)
        {
            Passed = passed;
        }
        public override string GetSuccess()
        {
            if (Passed)
                return "зачет";
            else
                return "незачет";
        }
        public Credit(Credit credit):base(credit.NameDiscipline,credit.NumberHours,credit.NameTeacher)
        {
            Passed = credit.Passed;
        }
    }
}
