using System;

namespace CourseProject
{
    /// <summary>
    /// Основной класс сущности студент, который хранится в базе данных
    /// </summary>
    [Serializable]
    class Student
    {
        public static int ID { get; set; }
        public int PersonalID {get;set;}
        public string NameStudent {get;set;}
        public string SurnameStudent { get; set; }
        public string PatronymicStudent { get; set; }
        public RecordBook PersonalRecordBook {get;set;}
        public string Faculty {get;set;}
        public string Specialty {get;set;}
        public string NameCurator { get; set; }
        public string SurnameCurator { get; set; }
        public string PatronymicCurator { get; set; }
        public Student(string name,string surnameStudent,string patronymicStudent,RecordBook recordBook,string faculty,string specialty,string nameCurator,string surnameCurator,string patronymicCurator)
        {
            PersonalID = ID++; NameStudent = name; PersonalRecordBook = recordBook; Faculty = faculty; Specialty = specialty;
            NameCurator = nameCurator;SurnameStudent = surnameStudent;PatronymicStudent = patronymicStudent;SurnameCurator = surnameCurator;PatronymicCurator = patronymicCurator;
        }
        public Student(Student another)
        {
            PersonalID = another.PersonalID; NameStudent = another.NameStudent; PersonalRecordBook = new RecordBook(another.PersonalRecordBook); Faculty = another.Faculty; Specialty = another.Specialty;
            NameCurator = another.NameCurator; SurnameStudent = another.SurnameStudent; PatronymicStudent = another.PatronymicStudent; SurnameCurator = another.SurnameCurator; PatronymicCurator = another.PatronymicCurator;
        }
    }
}
