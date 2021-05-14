using System;

namespace CourseProject
{
    /// <summary>
    /// Класс представляет собой сущноность экзамена
    /// </summary>
    [Serializable]
    class Exam: Discipline
    {
        private int _assessment;
        public int Assessment
        {
            get
            {
                return _assessment;
            }
            private set
            {
                if(value<6 && value>0)
                {
                    _assessment = value;
                }
                else
                {
                    _assessment = 1;
                }
            }
        }
        public Exam(string nameDiscipline, int numberHours, string nameTeacher, int assessment) : base(nameDiscipline, numberHours, nameTeacher)
        {
            _assessment = assessment;
            
        }
        public override string GetSuccess()
        {
            return "оценка " + Assessment.ToString();
        }
        public Exam(Exam exam) : base(exam.NameDiscipline,exam.NumberHours,exam.NameTeacher)
        {
            _assessment = exam._assessment;
        }
    }
}
