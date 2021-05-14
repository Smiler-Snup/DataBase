using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject
{
    /// <summary>
    /// Класс хранит список со студентам и работает с ним
    /// </summary>
    [Serializable]
    class DataBase
    {
        public List<Student> ListObjects { get; private set; }
        public DataBase()
        {
            ListObjects = new List<Student>();
        }
        public void AddObject(Student student, DataGridView dataGrid)
        {
            ListObjects.Add(student);
            dataGrid.Rows.Add();
            int i = dataGrid.Rows.Count-1;
            dataGrid.Rows[i].Cells[0].Value = ListObjects[i].PersonalID.ToString();
            dataGrid.Rows[i].Cells[1].Value = ListObjects[i].SurnameStudent + " " + ListObjects[i].NameStudent[0] + "." + ListObjects[i].PatronymicStudent[0] + ".";
            DataGridViewComboBoxCell itemCell = (DataGridViewComboBoxCell)dataGrid.Rows[i].Cells[2];
            foreach (Semester semester in ListObjects[i].PersonalRecordBook.Semesters)
            {
                itemCell.Items.Add("Семестр №" + semester.NumberOrder.ToString());
            }
            itemCell.Value = itemCell.Items[0];
            DataGridViewComboBoxCell itemCellDisciplines = (DataGridViewComboBoxCell)dataGrid.Rows[i].Cells[3];
            foreach (Discipline discipline in ListObjects[i].PersonalRecordBook.Semesters[0].Disciplines)
            {
                itemCellDisciplines.Items.Add(discipline.ToString());
            }
            itemCellDisciplines.Value = ListObjects[i].PersonalRecordBook.Semesters[0].Disciplines[0].ToString();
            dataGrid.Rows[i].Cells[4].Value = Convert.ToInt32(ListObjects[i].PersonalRecordBook.Semesters[0].Disciplines[0].NumberHours.ToString());
            dataGrid.Rows[i].Cells[5].Value = ListObjects[i].PersonalRecordBook.Semesters[0].Disciplines[0].NameTeacher.ToString();
            dataGrid.Rows[i].Cells[6].Value = ListObjects[i].PersonalRecordBook.Semesters[0].Disciplines[0].GetSuccess();
            dataGrid.Rows[i].Cells[7].Value = ListObjects[i].Faculty;
            dataGrid.Rows[i].Cells[8].Value = ListObjects[i].Specialty;
            dataGrid.Rows[i].Cells[9].Value = ListObjects[i].SurnameCurator + " " + ListObjects[i].NameCurator[0] + "." + ListObjects[i].PatronymicCurator[0] + ".";
            dataGrid.Invalidate();
        }
        public void ChangeObject(Student student,int i, DataGridView dataGrid)
        {
            
            ListObjects[i] = new Student(student);
            int row = 0;
            while (true)
            {
                if (dataGrid.Rows.Count == row)
                {
                    break;
                }
                if (ListObjects[i].PersonalID == int.Parse(dataGrid.Rows[row].Cells[0].Value.ToString()))
                {
                    break;
                }
                row++;
            }
            if (dataGrid.Rows.Count != row)
            {
                dataGrid.Rows[row].Cells[0].Value = ListObjects[i].PersonalID.ToString();
                dataGrid.Rows[row].Cells[1].Value = ListObjects[i].SurnameStudent + " " + ListObjects[i].NameStudent[0] + "." + ListObjects[i].PatronymicStudent[0] + ".";
                DataGridViewComboBoxCell itemCell = (DataGridViewComboBoxCell)dataGrid.Rows[row].Cells[2];
                itemCell.Items.Clear();
                foreach (Semester semester in ListObjects[i].PersonalRecordBook.Semesters)
                {
                    itemCell.Items.Add("Семестр №" + semester.NumberOrder.ToString());
                }
                itemCell.Value = itemCell.Items[0];
                DataGridViewComboBoxCell itemCellDisciplines = (DataGridViewComboBoxCell)dataGrid.Rows[row].Cells[3];
                itemCellDisciplines.Items.Clear();
                foreach (Discipline discipline in ListObjects[i].PersonalRecordBook.Semesters[0].Disciplines)
                {
                    itemCellDisciplines.Items.Add(discipline.ToString());
                }
                itemCellDisciplines.Value = ListObjects[i].PersonalRecordBook.Semesters[0].Disciplines[0].ToString();
                dataGrid.Rows[row].Cells[4].Value = Convert.ToInt32(ListObjects[i].PersonalRecordBook.Semesters[0].Disciplines[0].NumberHours.ToString());
                dataGrid.Rows[row].Cells[5].Value = ListObjects[i].PersonalRecordBook.Semesters[0].Disciplines[0].NameTeacher.ToString();
                dataGrid.Rows[row].Cells[6].Value = ListObjects[i].PersonalRecordBook.Semesters[0].Disciplines[0].GetSuccess();
                dataGrid.Rows[row].Cells[7].Value = ListObjects[i].Faculty;
                dataGrid.Rows[row].Cells[8].Value = ListObjects[i].Specialty;
                dataGrid.Rows[row].Cells[9].Value = ListObjects[i].SurnameCurator + " " + ListObjects[i].NameCurator[0] + "." + ListObjects[i].PatronymicCurator[0] + ".";
                dataGrid.Invalidate();
            }
        }
        public void AddObject(string faculty, Random random, string speciality="")
        {
            RecordBook recordBook = new RecordBook();
            List<string> BaseDisciplines = new List<string> { "Математика","Экономика","Основы механики","Физкультура","Правоведение","Обществознание","Русский язык","Испанский язык","Биология","Химия","Астраномия","Компонентрое мышление","Основы программирование","География","Риторика","Логика","Информатика","Программирование","Естествознание","Архитектура", "Физика", "История", "Английский язык", "Техника", "Философия","Анатомия","Конструирование" };
            List<string> BaseNameTeacher = new List<string> { "Иванов", "Петров", "Сидоров", "Остапчуков", "Кладин", "Висильнюков", "Кривоносов", "Хрюшкин" };
            List<string> BaseSurnameStudent = new List<string> { "Иванов", "Петров", "Сидоров", "Кириенко", "Кладин", "Висильнюков", "Кривоносов", "Хрюшкин", "Егоров", "Калинкин", "Вислоухов", "Шестунов", "Телефонов", "Карасев", "Гайков", "Эринов","Мленков","Клоунов","Крандинов" };
            List<string> BaseNameStudent = new List<string> { "Иван", "Петр", "Сидор", "Остапчук", "Егор", "Висилий", "Николай", "Никита","Данила","Александр","Одиссей","Олег","Макар","Глеб","Алексей","Илья","Григорий","Дмитрий","Тимофей" };
            List<string> BasePathronomicStudent = new List<string> { "Иванович", "Петрович", "Сидорович", "Остапчуков", "Егорович", "Висильевич", "Николаевич", "Никитич", "Данилович", "Александрович", "Одиссеивич", "Олегович", "Макарович", "Глебович", "Алексеевич", "Ильич", "Григоривич", "Дмитривич", "Тимофеевич" };
            for (int j = 0; j < random.Next(1, 4); j++)
            {
                List<Discipline> disciplines = new List<Discipline>();
                for (int i = 0; i < random.Next(1, 4); i++)
                {
                    if (random.Next(0, 2) == 0)
                    {
                        disciplines.Add(new Exam(BaseDisciplines[random.Next(0, BaseDisciplines.Count)], random.Next(72, 144), BaseNameTeacher[random.Next(0, BaseNameTeacher.Count)], random.Next(1, 6)));
                    }
                    else
                    {
                        bool passed = true;
                        if (random.Next(0, 2) == 1)
                        {
                            passed = false;
                        }
                        disciplines.Add(new Credit(BaseDisciplines[random.Next(0, BaseDisciplines.Count)], random.Next(36, 70), BaseNameTeacher[random.Next(0, BaseNameTeacher.Count)], passed));
                    }
                }
                recordBook.AddSemester(recordBook.Semesters.Count + 1, disciplines);
            }
            Student newstudent = new Student(BaseNameStudent[random.Next(0, BaseNameStudent.Count)], BaseSurnameStudent[random.Next(0, BaseSurnameStudent.Count)], BasePathronomicStudent[random.Next(0, BasePathronomicStudent.Count)], recordBook, faculty, speciality, "Виталий","Васнецов","Егорович");
            ListObjects.Add(newstudent);
        }
        public void CreateSource(DataGridView dataGrid,List<Student> MyList)
        {
            for (int i = 0; i < MyList.Count; i++)
            {
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = MyList[i].PersonalID.ToString();
                dataGrid.Rows[i].Cells[1].Value = MyList[i].SurnameStudent+" "+ MyList[i].NameStudent[0]+"."+ MyList[i].PatronymicStudent[0]+".";
                DataGridViewComboBoxCell itemCell = (DataGridViewComboBoxCell)dataGrid.Rows[i].Cells[2];
                foreach (Semester semester in MyList[i].PersonalRecordBook.Semesters)
                {
                    itemCell.Items.Add("Семестр №"+semester.NumberOrder.ToString());
                }
                itemCell.Value= itemCell.Items[0];
                DataGridViewComboBoxCell itemCellDisciplines = (DataGridViewComboBoxCell)dataGrid.Rows[i].Cells[3];
                foreach(Discipline discipline in MyList[i].PersonalRecordBook.Semesters[0].Disciplines)
                {
                    itemCellDisciplines.Items.Add(discipline.ToString());
                }
                itemCellDisciplines.Value = MyList[i].PersonalRecordBook.Semesters[0].Disciplines[0].ToString();
                dataGrid.Rows[i].Cells[4].Value = Convert.ToInt32(MyList[i].PersonalRecordBook.Semesters[0].Disciplines[0].NumberHours.ToString());
                dataGrid.Rows[i].Cells[5].Value = MyList[i].PersonalRecordBook.Semesters[0].Disciplines[0].NameTeacher.ToString();
                dataGrid.Rows[i].Cells[6].Value = MyList[i].PersonalRecordBook.Semesters[0].Disciplines[0].GetSuccess();
                dataGrid.Rows[i].Cells[7].Value = MyList[i].Faculty;
                dataGrid.Rows[i].Cells[8].Value = MyList[i].Specialty;
                dataGrid.Rows[i].Cells[9].Value = MyList[i].SurnameCurator + " " + MyList[i].NameCurator[0] + "." + MyList[i].PatronymicCurator[0] + ".";
            }
            dataGrid.Update();
        }
    }
}
