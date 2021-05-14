using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CourseProject
{
    /// <summary>
    ///Основная форма для работы с базой данных
    ///<item>_myDataBase<description>Класс содержит базу данных</description></item>
    /// </summary>
    public partial class FormMain : Form
    {
        private DataBase _myDataBase = new DataBase();
        private List<Semester> BufferSemesters = new List<Semester>();
        private List<Discipline> BufferDiscipline = new List<Discipline>();
        private List<Discipline> ChangeBufferDiscipline = new List<Discipline>();
        private bool CreateExam = false;
        private List<string> Faculties = new List<string>() { "ФВТ","ФИТЭ", "Медицинский"};
        private List<string>[] Specialities;
        private List<Student> BufferSortStudents=new List<Student>();
        private Student studentTemp;
        private Student studentSave;
        private int ChooseStudent=-1;
        private bool CreateOrChange;
        private bool ChangeDiscipline;
        /// <summary>
        /// Метод заполняет списки названиями специальностей дла каждого факультета и факультетами
        /// </summary>
        private void FillInSpecialities()
        {
            for(int i = 0;i<Specialities.Length;i++)
            {
                Specialities[i] = new List<string>();
            }
            Specialities[0].Add("Программная инженерия");
            Specialities[0].Add("Информационные системы и технологии");
            Specialities[0].Add("Прикладная информатика");
            Specialities[0].Add("Прикладная математика");
            Specialities[0].Add("Документоведение и архивоведение");

            Specialities[1].Add("Физика конденсированного состояния вещества");
            Specialities[1].Add("Проектирование и технология радиоэлектронных средств");
            Specialities[1].Add("Стандартизация и сертификация");
            Specialities[1].Add("Информационно-измерительная техника и технологии");

            Specialities[2].Add("Лечебное дело");
            Specialities[2].Add("Медицинская кибернетика");
            Specialities[2].Add("Фармация");
            Specialities[2].Add("Стоматология");
            foreach(string Faculty in Faculties)
            {
                ComboBoxAddFaculty.Items.Add(Faculty);
                ComboBoxSortFaculties.Items.Add(Faculty);
                comboBox4.Items.Add(Faculty);
            }
        }
        public FormMain()
        {
            InitializeComponent();
            AddControlsForAdd();
            AddControlsForAddSemester();
            AddControlsForAddDisciplines();
            AddControlsForChangeSemester();
            AddControlsForChangeDiscipline();
            AddControlsForUnderMenu();
            AddControlsForSort();
            this.DataGrid.Columns[0].Width = 45;
            //this.DataGrid.Cells[4].Value = Convert.ToInt32(text);
            Specialities = new List<string>[Faculties.Count];
            FillInSpecialities();
            var binFormater = new BinaryFormatter();
            using (var file = new FileStream("FileSaveBaseData.bin", FileMode.OpenOrCreate))
            {
                _myDataBase = binFormater.Deserialize(file) as DataBase;
                file.Close();
                if(_myDataBase.ListObjects.Count==0)
                {
                    Student.ID = 0;
                }
                else
                {
                    Student.ID = _myDataBase.ListObjects[_myDataBase.ListObjects.Count - 1].PersonalID+1;
                }
            }
            _myDataBase.CreateSource(DataGrid, _myDataBase.ListObjects);
            this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
            this.DataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            var notify = new Form2();
            notify.ShowDialog();
        }
        /// <summary>
        /// Перерисовывает форму при её изменениях размера
        /// </summary>
        private void MainPanel_Resize(object sender, EventArgs e)
        {
            this.DataGrid.Size = new Size(this.Size.Width,this.Size.Height/2+50);
            this.Refresh();
        }
        /// <summary>
        /// Открывает панель с меню
        /// </summary>
        private void LabelMenu_Click(object sender, EventArgs e)
        {
            PanelMenu.Show();
        }
        /// <summary>
        /// Закрывает панель с меню
        /// </summary>
        private void TittleMenu_Click(object sender, EventArgs e)
        {
            PanelMenu.Hide();
        }
        /// <summary>
        /// Открывает панель с меню
        /// </summary>
        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            LabelMenu_Click(sender, e);
        }
        /// <summary>
        /// Изменяет значения в выпадающем списке дисцпилин в соответствии с выбранным семестром в другом выпадающем списке
        /// </summary>
        private void DataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // My combobox column is the second one so I hard coded a 1, flavor to taste
            if(DataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
            {
                DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)DataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cb.Value != null)
                {
                    if (e.ColumnIndex == 2)
                    {
                        //MessageBox.Show(cb.Items.IndexOf(cb.Value).ToString());
                        //MessageBox.Show(cb.Value.ToString());
                        DataGridViewComboBoxCell itemCellDisciplines = (DataGridViewComboBoxCell)DataGrid.Rows[e.RowIndex].Cells[3];
                        var id = int.Parse(DataGrid[0, e.RowIndex].Value.ToString());
                        int index = -1;
                        for (int i = 0; i < _myDataBase.ListObjects.Count; i++)
                        {
                            if (id == _myDataBase.ListObjects[i].PersonalID)
                            {
                                index = i;
                            }
                        }
                        itemCellDisciplines.Items.Clear();
                        foreach (Discipline discipline in _myDataBase.ListObjects[index].PersonalRecordBook.Semesters[cb.Items.IndexOf(cb.Value)].Disciplines)
                        {
                            itemCellDisciplines.Items.Add(discipline.ToString());
                        }
                        itemCellDisciplines.Value = _myDataBase.ListObjects[index].PersonalRecordBook.Semesters[cb.Items.IndexOf(cb.Value)].Disciplines[0].ToString();
                        DataGrid.Rows[e.RowIndex].Cells[4].Value = Convert.ToInt32(_myDataBase.ListObjects[index].PersonalRecordBook.Semesters[cb.Items.IndexOf(cb.Value)].Disciplines[0].NumberHours.ToString());
                        DataGrid.Rows[e.RowIndex].Cells[5].Value = _myDataBase.ListObjects[index].PersonalRecordBook.Semesters[cb.Items.IndexOf(cb.Value)].Disciplines[0].NameTeacher.ToString();
                        DataGrid.Rows[e.RowIndex].Cells[6].Value = _myDataBase.ListObjects[index].PersonalRecordBook.Semesters[cb.Items.IndexOf(cb.Value)].Disciplines[0].GetSuccess();
                    }
                    // do stuff
                    DataGrid.Invalidate();
                }
            }
        }
        /// <summary>
        /// Запоминает значения, которое было в ячейки до изменения
        /// </summary>
        private void DataGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DataGrid.IsCurrentCellDirty)
            {
                //// This fires the cell value changed handler below
                DataGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        /// <summary>
        /// Скрывает виджеты для работы с базой данных
        /// </summary>
        private void HideMainWidget()
        {
            DataGrid.Hide();
            LabelMenu.Hide();
            ButtonMenu.Hide();
            PanelMenu.Hide();
            TextBoxFindStudent.Hide();
            ButtonFindStudent.Hide();
            ButtonDeleteObject.Hide();
            foreach (Control control in ControlsForSort)
            {
                control.Hide();
            }
        }
        /// <summary>
        /// Открывает виджеты для добавление нового объекта
        /// </summary>
        private void LabelAdd_Click(object sender, EventArgs e)
        {
            HideMainWidget();
            foreach (Control control in ControlsForAdd)
            {
                control.Show();
            }
        }
        /// <summary>
        /// Открывает виджеты для добавление нового объекта
        /// </summary>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            LabelAdd_Click(sender, e);
        }
        /// <summary>
        /// Изменяет текст на TrackBar при его изменения значения
        /// </summary>
        private void TrackBarAssessmentAdd_Scroll(object sender, EventArgs e)
        {
            LabelAddAssessment.Text = string.Format("Оценка " + TrackBarAssessmentAdd.Value);
        }
        /// <summary>
        /// Возвращает виджеты для работы с базой данных и скрывает виджеты для добавления студента
        /// </summary>
        private void ButtonBackAdd_Click(object sender, EventArgs e)
        {
            foreach (Control control in ControlsForAdd)
            {
                control.Hide();
            }
            foreach (Control control in ControlsForAddSemester)
            {
                control.Hide();
            }
            foreach (Control control in ControlsGenericDiscipline)
            {
                control.Hide();
            }
            ComboBoxAddFaculty.Text = "Факультеты";
            ComboBoxAddSpecialty.Text = "Специальности";
            TrackBarAssessmentAdd.Hide();
            LabelAddAssessment.Hide();
            OnOffButton.Hide();
            LabelCreditPassed.Hide();
            LabelCreditNotPassed.Hide();
            DataGrid.Show();
            LabelMenu.Show();
            ButtonMenu.Show();
            TextBoxFindStudent.Show();
            ButtonFindStudent.Show();
            ButtonDeleteObject.Show();
            if (_myDataBase.ListObjects.Count != this.DataGrid.Rows.Count)
            {
                this.DataGrid.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged -= new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
                this.DataGrid.Rows.Clear();
                _myDataBase.CreateSource(DataGrid, _myDataBase.ListObjects);
                this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            }
        }
        /// <summary>
        /// Открывает или скрывает виджеты для добавления зачета
        /// </summary>
        private void ButtonAddCredit_Click(object sender, EventArgs e)
        {
            if (TrackBarAssessmentAdd.Visible)
            {
                TrackBarAssessmentAdd.Hide();
                LabelAddAssessment.Hide();         
            }
            else
            {
                ButtonAddSaveSemester.Visible = !ButtonAddSaveSemester.Visible;
                LabelAddSaveSemester.Visible = !LabelAddSaveSemester.Visible;
                foreach (Control control in ControlsGenericDiscipline)
                {
                    control.Visible = !control.Visible;
                }
            }
            OnOffButton.Visible = !OnOffButton.Visible;
            LabelCreditPassed.Visible = !LabelCreditPassed.Visible;
            LabelCreditNotPassed.Visible = !LabelCreditNotPassed.Visible;
            CreateExam = false;
        }
        /// <summary>
        /// Открывает виджеты для создания семестра
        /// </summary>
        private void ButtonAddSemester_Click(object sender, EventArgs e)
        {
            this.LabelAddNumberSemester.Text = "Заполнение семестра №" + (BufferSemesters.Count + 1).ToString();
            ComboBoxAddSemesters.Text = "Создается семестр";
            foreach (Control control in ControlsForAddSemester)
            {
                control.Visible = !control.Visible ;
            }
            LabelAddSaveStudent.Visible = !LabelAddSaveStudent.Visible;
            ButtonAddSaveStudent.Visible = !ButtonAddSaveStudent.Visible;
            foreach (Control control in ControlsGenericDiscipline)
            {
                control.Hide();
            }
            TrackBarAssessmentAdd.Hide();
            LabelAddAssessment.Hide();
            OnOffButton.Hide();
            LabelCreditPassed.Hide();
            LabelCreditNotPassed.Hide();
        }
        /// <summary>
        /// Скрывает виджеты для добавления семестра
        /// </summary>
        private void ButtonBackAddSemester_Click(object sender, EventArgs e)
        {
            foreach (Control control in ControlsForAddSemester)
            {
                control.Hide();
            }
            foreach (Control control in ControlsGenericDiscipline)
            {
                control.Hide();
            }
            ComboBoxAddSemesters.Text = "Семестры";
            TrackBarAssessmentAdd.Hide();
            LabelAddAssessment.Hide();
            OnOffButton.Hide();
            LabelCreditPassed.Hide();
            LabelCreditNotPassed.Hide();
            LabelAddSaveStudent.Show();
            ButtonAddSaveStudent.Show();
        }
        /// <summary>
        /// Открывает или скрывает виджеты для добавления экзамена
        /// </summary>
        private void ButtonAddExam_Click(object sender, EventArgs e)
        {
            if (OnOffButton.Visible)
            {
                OnOffButton.Hide();
                LabelCreditPassed.Hide();
                LabelCreditNotPassed.Hide();
            }
            else
            {
                foreach (Control control in ControlsGenericDiscipline)
                {
                    control.Visible = !control.Visible;
                }
                ButtonAddSaveSemester.Visible = !ButtonAddSaveSemester.Visible;
                LabelAddSaveSemester.Visible = !LabelAddSaveSemester.Visible;
            }
            CreateExam = true;
            TrackBarAssessmentAdd.Visible = !TrackBarAssessmentAdd.Visible;
            LabelAddAssessment.Visible = !LabelAddAssessment.Visible;
        }
        /// <summary>
        /// Скрывает виджеты для добавления дисциплины
        /// </summary>
        private void ButtonBackAddDiscipline_Click(object sender, EventArgs e)
        {
            foreach (Control control in ControlsGenericDiscipline)
            {
                control.Hide();
            }
            ButtonAddSaveSemester.Show();
            LabelAddSaveSemester.Show();
            OnOffButton.Hide();
            LabelCreditPassed.Hide();
            LabelCreditNotPassed.Hide();
            TrackBarAssessmentAdd.Hide();
            LabelAddAssessment.Hide();
        }
        /// <summary>
        /// Возвращает виджеты для работы с базой данных и скрывает виджеты для добавления студента
        /// </summary>
        private void LabelBackAdd_Click(object sender, EventArgs e)
        {
            ButtonBackAdd_Click(sender, e);
        }
        /// <summary>
        /// Открывает или скрывает виджеты для добавления экзамена
        /// </summary>
        private void LabelAddExam_Click(object sender, EventArgs e)
        {
            ButtonAddExam_Click(sender, e);
        }
        /// <summary>
        /// Открывает или скрывает виджеты для добавления зачета
        /// </summary>
        private void LabelAddCredit_Click(object sender, EventArgs e)
        {
            ButtonAddCredit_Click( sender, e);
        }
        /// <summary>
        /// Изменяет в textbox текст на поступающую строку и цвет текста на красный
        /// </summary>
        private void CheckTextBoxMistake(TextBox textBox,string Message)
        {
            textBox.Text = Message;
            textBox.ForeColor = Color.Red;
        }
        /// <summary>
        /// Проверяет textbox на пустоту и возвращает состояние этого
        /// </summary>
        private bool CheckTextBoxStringEmpty(TextBox textBox)
        {
            if(textBox.Text =="")
            {
                textBox.Text = "Ошибка:Пустая строка";
                textBox.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Сохраняет дисциплину в список
        /// </summary>
        private void ButtonAddSaveDiscipline_Click(object sender, EventArgs e)
        {
            bool Success = true;
            if (TextBoxNameDiscipline.Text == "")
            {
                CheckTextBoxMistake(TextBoxNameDiscipline, "Ошибка:Пустая строка");
                Success = false;
            }
            int CountHours = 0;
            if(!int.TryParse(TextBoxAddCountHours.Text,out CountHours))
            {
                CheckTextBoxMistake(TextBoxAddCountHours, "Ошибка: Требуется натуральное число");
                Success = false;
            }
            if(TextBoxAddNameTeacher.Text =="")
            {
                CheckTextBoxMistake(TextBoxAddNameTeacher, "Ошибка:Пустая строка");
                Success = false;
            }
            if (Success)
            {
                Discipline TempObject;
                if (CreateExam)
                {
                    TempObject = new Exam(TextBoxNameDiscipline.Text, int.Parse(TextBoxAddCountHours.Text), TextBoxAddNameTeacher.Text, TrackBarAssessmentAdd.Value);
                }
                else
                {
                    TempObject = new Credit(TextBoxNameDiscipline.Text, int.Parse(TextBoxAddCountHours.Text), TextBoxAddNameTeacher.Text, this.OnOffButton.ChoiceLeft);
                }
                BufferDiscipline.Add(TempObject);
                ComboBoxAddDisciplines.Items.Add(TempObject.NameDiscipline);
                TextBoxNameDiscipline.Text = "Успешно";
                TextBoxAddCountHours.Text = "Успешно";
                TextBoxAddNameTeacher.Text = "Успешно";
                TextBoxAddNameTeacher.ForeColor = Color.Green;
                TextBoxNameDiscipline.ForeColor = Color.Green;
                TextBoxAddCountHours.ForeColor = Color.Green;
            }
        }
        /// <summary>
        /// Сохраняет дисциплину в список
        /// </summary>
        private void LabelAddSaveDiscipline_Click(object sender, EventArgs e)
        {
            ButtonAddSaveDiscipline_Click(sender,e);
        }
        /// <summary>
        /// Удаляет дисциплину из списка
        /// </summary>
        private void ButtonAddDeleteDiscipline_Click(object sender, EventArgs e)
        {
            if(ComboBoxAddDisciplines.SelectedIndex!=-1)
            {
                BufferDiscipline.RemoveAt(ComboBoxAddDisciplines.SelectedIndex);
                ComboBoxAddDisciplines.Items.RemoveAt(ComboBoxAddDisciplines.SelectedIndex);
                ComboBoxAddDisciplines.Text = "Дисциплины";
            }
        }
        /// <summary>
        /// Изменяет в textbox цвет текста на черный и текст внутри на пустую строку при двойном нажатии
        /// </summary>
        private void TextBoxDoubleClick(object sender, EventArgs e)
        {
            if(sender is TextBox)
            {
                var TempBox = sender as TextBox;
                if (TempBox.ForeColor == Color.Red || TempBox.ForeColor == Color.Green)
                {
                    TempBox.ForeColor = Color.Black;
                    TempBox.Text = "";
                }
            }
        }
        /// <summary>
        /// Изменяет в textbox цвет текста на черный, если текущей цвет красный или зеленый при изменении текста
        /// </summary>
        private void TextBoxChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                var TempBox = sender as TextBox;
                if (TempBox.ForeColor == Color.Red || TempBox.ForeColor == Color.Green)
                {
                    TempBox.ForeColor = Color.Black;
                }
            }
        }
        /// <summary>
        /// Сохраняет семестр в список
        /// </summary>
        private void ButtonAddSaveSemester_Click(object sender, EventArgs e)
        {
            if(BufferDiscipline.Count!=0)
            {
                BufferSemesters.Add(new Semester(BufferSemesters.Count + 1, BufferDiscipline));
                ComboBoxAddSemesters.Items.Add("Семестр №"+ BufferSemesters.Count);
                ButtonBackAddSemester_Click(sender, e);
                BufferDiscipline.Clear();
                ComboBoxAddDisciplines.Items.Clear();
                ComboBoxAddDisciplines.Text = "Дисциплины";
            }
            else
            {
                ComboBoxAddDisciplines.Text = "Недостаточно дисциплин";
            }
        }
        /// <summary>
        /// Удаляет семестр из списка
        /// </summary>
        private void ButtonDeleteSemester_Click(object sender, EventArgs e)
        {
            if(ComboBoxAddSemesters.SelectedIndex!=-1)
            {
                BufferSemesters.RemoveAt(ComboBoxAddSemesters.SelectedIndex);
                ComboBoxAddSemesters.Items.RemoveAt(ComboBoxAddSemesters.SelectedIndex);
                ComboBoxAddSemesters.Items.Clear();
                for(int i =0;i< BufferSemesters.Count;i++)
                {
                    BufferSemesters[i].NumberOrder = i + 1;
                    ComboBoxAddSemesters.Items.Add("Семестр №"+(i+1));
                }
                this.LabelAddNumberSemester.Text = "Заполнение семестра №" + (BufferSemesters.Count + 1).ToString();
                ComboBoxAddSemesters.Text = "Семестры";
            }
        }
        /// <summary>
        /// Сохраняет семестр в список
        /// </summary>
        private void LabelAddSaveSemester_Click(object sender, EventArgs e)
        {
            ButtonAddSaveSemester_Click(sender,e);
        }
        /// <summary>
        /// Изменяет специальности в combobox при изменение факультета
        /// </summary>
        private void ComboBoxAddFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxAddSpecialty.Items.Clear();
            ComboBoxAddSpecialty.Text = "Специальности";
            foreach (string Speciality in Specialities[ComboBoxAddFaculty.SelectedIndex])
            {
                ComboBoxAddSpecialty.Items.Add(Speciality);
            }
        }
        /// <summary>
        /// Сохраняет студента в базу данных
        /// </summary>
        private void ButtonAddSaveStudent_Click(object sender, EventArgs e)
        {
            bool Success = CheckTextBoxStringEmpty(TextBoxAddNameStudent) & CheckTextBoxStringEmpty(TextBoxAddSurnameStudent) & CheckTextBoxStringEmpty(TextBoxAddPatronymicStudent)
                & CheckTextBoxStringEmpty(TextBoxAddNameCurator) & CheckTextBoxStringEmpty(TextBoxAddSurnameCurator) & CheckTextBoxStringEmpty(TextBoxAddPatronymicCurator);
            if(ComboBoxAddSemesters.Items.Count==0)
            {
                ComboBoxAddSemesters.Text = "Недостаточно семестров";
                Success = false;
            }
            if(ComboBoxAddFaculty.SelectedIndex==-1)
            {
                ComboBoxAddFaculty.Text = "Выберите факультет";
                Success = false;
            }
            else
            {
                if(ComboBoxAddSpecialty.SelectedIndex==-1)
                {
                    ComboBoxAddSpecialty.Text = "Выберите специальность";
                    Success = false;
                }
            }
            if(Success)
            {
                Student student = new Student(TextBoxAddNameStudent.Text,TextBoxAddSurnameStudent.Text,TextBoxAddPatronymicStudent.Text,
                    new RecordBook(BufferSemesters), ComboBoxAddFaculty.SelectedItem as string,ComboBoxAddSpecialty.SelectedItem as string,TextBoxAddNameCurator.Text,
                    TextBoxAddSurnameCurator.Text,TextBoxAddPatronymicCurator.Text);
                BufferDiscipline = new List<Discipline>();
                BufferSemesters = new List<Semester>();
                this.DataGrid.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged -= new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
                _myDataBase.AddObject(student,DataGrid);
                ButtonBackAdd_Click(sender, e);
                ComboBoxAddSemesters.Items.Clear();
                ComboBoxAddSemesters.Text = "Семестры";
                ComboBoxAddDisciplines.Items.Clear();
                ComboBoxAddDisciplines.Text = "Дисциплины";
                this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
                DataGrid.Show();
            }
        }
        /// <summary>
        /// Находит студента в базе данных по Id или по фамилии
        /// </summary>
        private void ButtonFindStudent_Click(object sender, EventArgs e)
        {
            if(TextBoxFindStudent.Text!="")
            {
                int id;
                int index = -1;
                int count = 0;
                if (int.TryParse(TextBoxFindStudent.Text, out id))
                {
                    //foreach (var student in _myDataBase.ListObjects)
                    //{
                    //    if (id == student.PersonalID)
                    //    {
                    //        index = count;
                    //        break;
                    //    }
                    //    count++;
                    //}
                    for(int i =0;i<this.DataGrid.Rows.Count;i++)
                    {
                        if(int.Parse(this.DataGrid.Rows[i].Cells[0].Value.ToString())==id)
                        {
                            index = i;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < this.DataGrid.Rows.Count; i++)
                    {
                        if (this.DataGrid.Rows[i].Cells[1].Value.ToString().ToLower() == TextBoxFindStudent.Text.ToLower())
                        {
                            index = i;
                            break;
                        }
                    }
                    //foreach (var student in _myDataBase.ListObjects)
                    //{
                    //    if (student.SurnameStudent.ToLower() == TextBoxFindStudent.Text.ToLower())
                    //    {
                    //        index = count;
                    //        break;
                    //    }
                    //    count++;
                    //}
                }
                if(index!=-1 && index< DataGrid.Rows.Count)
                {
                    DataGrid.ClearSelection();
                    DataGrid.Rows[index].Selected = true;
                    DataGrid.FirstDisplayedScrollingRowIndex = index;
                }
            }
        }
        /// <summary>
        /// Удаляет студента из базы данных
        /// </summary>
        private void ButtonDeleteObject_Click(object sender, EventArgs e)
        {
            if (this.DataGrid.Rows.Count!=0)
            {
                var id = int.Parse(DataGrid[0,this.DataGrid.SelectedCells[0].RowIndex].Value.ToString());
                int index=-1;
                for (int i =0;i<_myDataBase.ListObjects.Count;i++)
                {
                    if(id== _myDataBase.ListObjects[i].PersonalID)
                    {
                        index = i;
                    }
                }
                if (index != -1)
                {
                    this.DataGrid.Rows.RemoveAt(this.DataGrid.SelectedCells[0].RowIndex);
                    this._myDataBase.ListObjects.RemoveAt(index);
                    DataGrid.Invalidate();
                }
                }
        }
        /// <summary>
        /// Открывает панель для изменения атрибутов студента
        /// </summary>
        private void ButtonChangeStudent_Click(object sender, EventArgs e)
        {
            MainPanel.Hide();
            PanelMenu.Hide();
            PanelForChnageStudent.Show();
        }
        /// <summary>
        /// Перерисовывает панель изменения при изменении её размера
        /// </summary>
        private void PanelForChnageStudent_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }
        /// <summary>
        /// Возвращет основную панель, скрывая панель для изменения
        /// </summary>
        private void imagePersonal7_Click(object sender, EventArgs e)
        {
            MainPanel.Show();
            PanelForChnageStudent.Hide();
            foreach(Control control in PanelForChnageStudent.Controls)
            {
                if(control is TextBox)
                {
                    control.Text = "";
                }
            }
            comboBox4.Text = "Факультеты";
            comboBox3.Text = "Специальности";
            comboBox2.Items.Clear();
            comboBox2.Text = "Семестры";
            comboBox1.Items.Clear();
            comboBox1.Text = "Дисциплины";
            textBox1.Text = "Id/Фамилия";
            ChooseStudent = -1;
            foreach (Control control in ControlsForChangeSemester)
            {
                control.Hide();
            }
            foreach (Control control in ControlsForChangeDiscipline)
            {
                control.Hide();
            }
            label2.Hide();
            label1.Hide();
            onOffWidjet1.Hide();
            trackBar1.Hide();
            label5.Hide();
            if (_myDataBase.ListObjects.Count != this.DataGrid.Rows.Count)
            {
                this.DataGrid.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged -= new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
                this.DataGrid.Rows.Clear();
                _myDataBase.CreateSource(DataGrid, _myDataBase.ListObjects);
                this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            }
        }
        /// <summary>
        /// Находит студента в базе данных и возвращает его атрибуты для изменения
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int id;
                int index = -1;
                int count = 0;
                if (int.TryParse(textBox1.Text, out id))
                {
                    foreach (var student in _myDataBase.ListObjects)
                    {
                        if (id == student.PersonalID)
                        {
                            index = count;
                            break;
                        }
                        count++;
                    }
                }
                else
                {
                    foreach (var student in _myDataBase.ListObjects)
                    {
                        if (student.SurnameStudent.ToLower() == textBox1.Text.ToLower())
                        {
                            index = count;
                            break;
                        }
                        count++;
                    }
                }
                if (index != -1)
                {
                    ChooseStudent = index;
                    imagePersonal4_Click(sender, e);
                    studentTemp = _myDataBase.ListObjects[index];
                    studentSave = new Student(studentTemp);
                    textBox10.Text = studentTemp.NameStudent;
                    textBox9.Text = studentTemp.SurnameStudent;
                    textBox8.Text = studentTemp.PatronymicStudent;
                    textBox7.Text = studentTemp.NameCurator;
                    textBox6.Text = studentTemp.SurnameCurator;
                    textBox5.Text = studentTemp.PatronymicCurator;
                    comboBox4.SelectedIndex = comboBox4.Items.IndexOf(studentTemp.Faculty);
                    comboBox3.SelectedIndex = comboBox3.Items.IndexOf(studentTemp.Specialty);
                    comboBox2.Items.Clear();
                    comboBox2.Text = "Семестры";
                    foreach (var semester in studentTemp.PersonalRecordBook.Semesters)
                    {
                        comboBox2.Items.Add("Семестр №" + semester.NumberOrder);
                    }
                }
            }
        }
        /// <summary>
        /// Изменяет специальности при изменения факультета
        /// </summary>
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Text = "Специальности";
            foreach (string Speciality in Specialities[comboBox4.SelectedIndex])
            {
                comboBox3.Items.Add(Speciality);
            }
        }
        /// <summary>
        /// Открывает семестр при его выборе в выпадающем списке для изменения
        /// </summary>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex!=-1)
            {
                comboBox1.Items.Clear();
                comboBox1.Text = "Дисциплины";
                ChangeBufferDiscipline.Clear();
                foreach (var Disciplines in studentSave.PersonalRecordBook.Semesters[comboBox2.SelectedIndex].Disciplines)
                {
                    comboBox1.Items.Add(Disciplines.NameDiscipline);
                    ChangeBufferDiscipline.Add(Disciplines);
                }
                label18.Text = "Изменение семестра №" + (comboBox2.SelectedIndex + 1).ToString();
                foreach (var control in ControlsForChangeSemester)
                {
                    control.Show();
                }
                imagePersonal2_Click(sender, e);
                imagePersonal1.Hide();
                labelMy1.Hide();
                CreateOrChange = false;
            }
        }
        /// <summary>
        ///  Открывает дисциплину при её выборе в выпадающем списке для изменения
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex!=-1)
            {
                labelMy6.Hide();
                imagePersonal11.Hide();
                foreach(var control in ControlsForChangeDiscipline)
                {
                    control.Show();
                }
                label3.Text = "Изменение дисциплины";
                var discipline = ChangeBufferDiscipline[comboBox1.SelectedIndex];
                textBox4.Text = discipline.NameDiscipline;
                textBox3.Text = discipline.NumberHours.ToString();
                textBox2.Text = discipline.NameTeacher;
                ChangeDiscipline = true;
                if(discipline is Exam)
                {
                    if(label2.Visible)
                    {
                        label2.Hide();
                        label1.Hide();
                        onOffWidjet1.Hide();
                    }
                    var exam = discipline as Exam;
                    label5.Text = "Оценка " + exam.Assessment.ToString();
                    trackBar1.Value = exam.Assessment;
                    label5.Show();
                    trackBar1.Show();
                }
                else
                {
                    var credit = discipline as Credit;
                    if (label5.Visible)
                    {
                        label5.Hide();
                        trackBar1.Hide();
                    }
                    if(credit.Passed!=onOffWidjet1.ChoiceLeft)
                    {
                        onOffWidjet1.MyClick(this,new EventArgs());
                    }
                    label2.Show();
                    label1.Show();
                    onOffWidjet1.Show();
                }
            }
        }
        /// <summary>
        ///  Открывает дисциплину при её выборе в выпадающем списке для изменения
        /// </summary>
        private void imagePersonal4_Click(object sender, EventArgs e)
        {
            foreach (var control in ControlsForChangeSemester)
            {
                control.Hide();
            }
            imagePersonal2_Click(sender, e);
            imagePersonal1.Show();
            labelMy1.Show();
            imagePersonal11.Hide();
            labelMy6.Hide();
        }
        /// <summary>
        ///  Изменяет тескт в соответствии с измненеием Trackbar
        /// </summary>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = "Оценка " + trackBar1.Value.ToString();
        }
        private void DataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DataGrid.CurrentCell.ColumnIndex == 3)
            {
                ComboBox combo = e.Control as ComboBox;
                combo.SelectedIndexChanged -= new EventHandler(Control_Changed);
                combo.SelectedIndexChanged += new EventHandler(Control_Changed);
            }
        }
        /// <summary>
        /// Изменяет значение для дисцпилины соответствии с выбранной из списка
        /// </summary>
        private void Control_Changed(object sender, System.EventArgs e)
        {
            int col = DataGrid.CurrentCell.ColumnIndex;
            if (col == 3)
            {
                int row = DataGrid.CurrentCell.RowIndex;
                int i = ((ComboBox)sender).SelectedIndex;
                DataGridViewComboBoxCell itemCellDisciplines = (DataGridViewComboBoxCell)DataGrid.Rows[row].Cells[2];
                int index = itemCellDisciplines.Items.IndexOf(itemCellDisciplines.Value);
                var id = int.Parse(DataGrid[0, row].Value.ToString());
                int ind = -1;
                for (int j = 0; j < _myDataBase.ListObjects.Count; j++)
                {
                    if (id == _myDataBase.ListObjects[j].PersonalID)
                    {
                        ind = j;
                    }
                }
                DataGrid.Rows[row].Cells[4].Value = Convert.ToInt32(_myDataBase.ListObjects[ind].PersonalRecordBook.Semesters[index].Disciplines[i].NumberHours.ToString());
                DataGrid.Rows[row].Cells[5].Value = _myDataBase.ListObjects[ind].PersonalRecordBook.Semesters[index].Disciplines[i].NameTeacher.ToString();
                DataGrid.Rows[row].Cells[6].Value = _myDataBase.ListObjects[ind].PersonalRecordBook.Semesters[index].Disciplines[i].GetSuccess();
            }
        }
        /// <summary>
        /// Скрывает виджеты для изменения или создание дисциплины
        /// </summary>
        private void imagePersonal2_Click(object sender, EventArgs e)
        {
            foreach(var Control in ControlsForChangeDiscipline)
            {
                Control.Hide();
            }
            imagePersonal11.Show();
            labelMy6.Show();
            label2.Hide();
            label1.Hide();
            onOffWidjet1.Hide();
            label5.Hide();
            trackBar1.Hide();
        }
        /// <summary>
        /// Скрывает или отображает виджеты для создания семестра
        /// </summary>
        private void imagePersonal10_Click(object sender, EventArgs e)
        {
            if (ChooseStudent != -1)
            {
                if (!label18.Visible)
                {
                    foreach (var control in ControlsForChangeSemester)
                    {
                        control.Visible = !control.Visible;
                    }
                }
                label18.Text = "Заполнение семестра №" + (studentSave.PersonalRecordBook.Semesters.Count+1).ToString();
                comboBox1.Items.Clear();
                comboBox1.Text = "Дисциплины";
                comboBox2.Text = "Создается семестр";
                imagePersonal2_Click(sender,e);
                CreateOrChange = true;
            }
        }
        /// <summary>
        ///  Удаляет семестр из списка
        /// </summary>
        private void imagePersonal9_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                studentSave.PersonalRecordBook.Semesters.RemoveAt(comboBox2.SelectedIndex);
                comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
                comboBox2.Items.Clear();
                comboBox1.Items.Clear();
                for (int i = 0; i < studentSave.PersonalRecordBook.Semesters.Count; i++)
                {
                    studentSave.PersonalRecordBook.Semesters[i].NumberOrder = i + 1;
                    comboBox2.Items.Add("Семестр №" + (i + 1));
                }
                this.label18.Text = "Заполнение семестра №" + (studentSave.PersonalRecordBook.Semesters.Count + 1).ToString();
                comboBox2.Text = "Семестры";
                imagePersonal4_Click(sender,e);
            }
        }
        /// <summary>
        /// Возвращет основную панель, скрывая панель для изменения
        /// </summary>
        private void labelMy5_Click(object sender, EventArgs e)
        {
            imagePersonal7_Click(sender, e);
        }
        /// <summary>
        /// Открывает панель для изменения атрибутов студента
        /// </summary>
        private void LabelChange_Click(object sender, EventArgs e)
        {
            ButtonChangeStudent_Click(sender, e);
        }
        /// <summary>
        /// Изменяет строку в textbox на пустую
        /// </summary>
        private void TextBoxFindStudent_Enter(object sender, EventArgs e)
        {
            if(sender is TextBox)
            {
                var MyTextBox = sender as TextBox;
                if (MyTextBox.Text == "Id/Фамилия" || MyTextBox.Text =="Ошибка:Неверные данные" || MyTextBox.ForeColor==Color.Red || MyTextBox.ForeColor == Color.Green)
                {
                    MyTextBox.Text = "";
                }
            }
        }
        /// <summary>
        /// Изменяет строку в textbox на id/Фамилия
        /// </summary>
        private void TextBoxFindStudent_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                var MyTextBox = sender as TextBox;
                if (MyTextBox.Text == "")
                {
                    MyTextBox.Text = "Id/Фамилия";
                }
            }
        }
        /// <summary>
        /// Создаёт пустые строку в textbox 
        /// </summary>
        private void TextBoxEmpty()
        {
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
        }
        /// <summary>
        /// Открывает виджеты для добавления дисциплин в существующий семестр
        /// </summary>
        private void imagePersonal6_Click(object sender, EventArgs e)
        {
            if(!label3.Visible)
            {
                foreach(Control control in ControlsForChangeDiscipline)
                {
                    control.Show();
                    if(control is TextBox)
                    {
                        control.Text = "";
                    }
                }
            }
            comboBox1.Text = "Дисциплины";
            label3.Text = "Добавление дисциплины";
            imagePersonal11.Hide();
            labelMy6.Hide();
            TextBoxEmpty();
            ChangeDiscipline = false;
            if(!trackBar1.Visible)
            {
                label2.Hide();
                label1.Hide();
                onOffWidjet1.Hide();
                trackBar1.Show();
                label5.Show();
            }
        }
        /// <summary>
        /// Сохраняет созданную или измененную дисциплину
        /// </summary>
        private void imagePersonal3_Click(object sender, EventArgs e)
        {
            bool success = true;
            if(textBox4.Text=="")
            {
                CheckTextBoxMistake(textBox4, "Ошибка:Пустая строка");
                success = false;
            }
            int CountHours;
            if(!int.TryParse(textBox3.Text, out CountHours))
            {
                CheckTextBoxMistake(textBox3, "Ошибка:Нужно число");
                success = false;
            }
            if (textBox2.Text == "")
            {
                CheckTextBoxMistake(textBox2, "Ошибка:Пустая строка");
                success = false;
            }
            if (success)
            {
                if (ChangeDiscipline)
                {
                    if (onOffWidjet1.Visible)
                    {
                        ChangeBufferDiscipline[comboBox1.SelectedIndex] = new Credit(textBox4.Text, int.Parse(textBox3.Text), textBox2.Text, onOffWidjet1.ChoiceLeft);
                    }
                    else
                    {
                        ChangeBufferDiscipline[comboBox1.SelectedIndex] = new Exam(textBox4.Text, int.Parse(textBox3.Text), textBox2.Text, trackBar1.Value);
                    }
                }
                else
                {
                    if (onOffWidjet1.Visible)
                    {
                        ChangeBufferDiscipline.Add(new Credit(textBox4.Text, int.Parse(textBox3.Text), textBox2.Text, onOffWidjet1.ChoiceLeft));
                    }
                    else
                    {
                        ChangeBufferDiscipline.Add(new Exam(textBox4.Text, int.Parse(textBox3.Text), textBox2.Text, trackBar1.Value));
                    }
                }
                comboBox1.Items.Clear();
                comboBox1.Text = textBox4.Text;
                foreach (var item in ChangeBufferDiscipline)
                {
                    comboBox1.Items.Add(item.NameDiscipline);
                }
                #region Код Временный
                //if (CreateOrChange)
                //{
                //    if (ChangeDiscipline)
                //    {
                //        if (onOffWidjet1.Visible)
                //        {
                //            ChangeBufferDiscipline[comboBox1.SelectedIndex] = new Credit(textBox4.Text, int.Parse(textBox3.Text), textBox2.Text, onOffWidjet1.ChoiceLeft);
                //        }
                //        else
                //        {
                //            ChangeBufferDiscipline[comboBox1.SelectedIndex] = new Exam(textBox4.Text, int.Parse(textBox3.Text), textBox2.Text, trackBar1.Value);
                //        }
                //    }
                //    else
                //    {
                //        if (onOffWidjet1.Visible)
                //        {
                //            ChangeBufferDiscipline.Add(new Credit(textBox4.Text, int.Parse(textBox3.Text), textBox2.Text, onOffWidjet1.ChoiceLeft));
                //        }
                //        else
                //        {
                //            ChangeBufferDiscipline.Add(new Exam(textBox4.Text, int.Parse(textBox3.Text), textBox2.Text, trackBar1.Value));
                //        }
                //    }
                //    comboBox1.Items.Clear();
                //    comboBox1.Text = textBox4.Text;
                //    foreach (var item in ChangeBufferDiscipline)
                //    {
                //        comboBox1.Items.Add(item.NameDiscipline);
                //    }
                //}
                //else
                //{
                //    if (ChangeDiscipline)
                //    {
                //        if (onOffWidjet1.Visible)
                //        {
                //            studentSave.PersonalRecordBook.Semesters[comboBox2.SelectedIndex].Disciplines[comboBox1.SelectedIndex] = new Credit(textBox4.Text, int.Parse(textBox3.Text), textBox2.Text, onOffWidjet1.ChoiceLeft);
                //        }
                //        else
                //        {
                //            studentSave.PersonalRecordBook.Semesters[comboBox2.SelectedIndex].Disciplines[comboBox1.SelectedIndex] = new Exam(textBox4.Text, int.Parse(textBox3.Text), textBox2.Text, trackBar1.Value);
                //        }
                //    }
                //    else
                //    {
                //        if (onOffWidjet1.Visible)
                //        {
                //            studentSave.PersonalRecordBook.Semesters[comboBox2.SelectedIndex].Disciplines.Add(new Credit(textBox4.Text, int.Parse(textBox3.Text), textBox2.Text, onOffWidjet1.ChoiceLeft));
                //        }
                //        else
                //        {
                //            studentSave.PersonalRecordBook.Semesters[comboBox2.SelectedIndex].Disciplines.Add(new Exam(textBox4.Text, int.Parse(textBox3.Text), textBox2.Text, trackBar1.Value));
                //        }
                //    }
                //    comboBox1.Items.Clear();
                //    comboBox1.Text = textBox4.Text;
                //    foreach (var item in studentSave.PersonalRecordBook.Semesters[comboBox2.SelectedIndex].Disciplines)
                //    {
                //        comboBox1.Items.Add(item.NameDiscipline);
                //    }
                #endregion
                textBox4.Text = "Успешно";
                textBox3.Text = "Успешно";
                textBox2.Text = "Успешно";
                textBox4.ForeColor = Color.Green;
                textBox3.ForeColor = Color.Green;
                textBox2.ForeColor = Color.Green;
            }
        }
        /// <summary>
        /// Открывает виджеты для добавления дисцпилины в новый семестр
        /// </summary>
        private void imagePersonal5_Click(object sender, EventArgs e)
        {
            if (!label3.Visible)
            {
                foreach (Control control in ControlsForChangeDiscipline)
                {
                    control.Show();
                    if (control is TextBox)
                    {
                        control.Text = "";
                    }
                }
            }
            comboBox1.Text = "Дисциплины";
            label3.Text = "Добавление дисциплины";
            imagePersonal11.Hide();
            labelMy6.Hide();
            TextBoxEmpty();
            ChangeDiscipline = false;
            if (trackBar1.Visible)
            {
                trackBar1.Hide();
                label5.Hide();
            }
            label2.Show();
            label1.Show();
            onOffWidjet1.Show();
        }
        /// <summary>
        /// Добавляет или изменяет семестр у студента
        /// </summary>
        private void imagePersonal11_Click(object sender, EventArgs e)
        {
            if (CreateOrChange)
            {
                studentSave.PersonalRecordBook.AddSemester(studentSave.PersonalRecordBook.Semesters.Count+1,ChangeBufferDiscipline);
                comboBox2.Items.Clear();
                foreach (var semester in studentSave.PersonalRecordBook.Semesters)
                {
                    comboBox2.Items.Add("Семестр №" + semester.NumberOrder);
                }
            }
            else
            {
                studentSave.PersonalRecordBook.Semesters[comboBox2.SelectedIndex].ChangeListDisciplines(ChangeBufferDiscipline);
            }
            ChangeBufferDiscipline.Clear();
            imagePersonal4_Click(sender, e);
            imagePersonal11.Hide();
            labelMy6.Hide();
        }
        /// <summary>
        /// Удаяляет дисциплину
        /// </summary>
        private void imagePersonal8_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex!=-1)
            {
                ChangeBufferDiscipline.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                imagePersonal2_Click(sender, e);
                comboBox1.Text = "Дисциплины";
            }
        }
        /// <summary>
        /// Изменяет атрибуты студента
        /// </summary>
        private void imagePersonal1_Click(object sender, EventArgs e)
        {
            if (ChooseStudent == -1)
            {
                return;
            }
            bool success = true;
            if (textBox10.Text == "")
            {
                CheckTextBoxMistake(textBox10, "Пустая строка");
                success = false;
            }
            if (textBox9.Text == "")
            {
                CheckTextBoxMistake(textBox9, "Пустая строка");
                success = false;
            }
            if (textBox8.Text == "")
            {
                CheckTextBoxMistake(textBox8, "Пустая строка");
                success = false;
            }
            if (textBox7.Text == "")
            {
                CheckTextBoxMistake(textBox7, "Пустая строка");
                success = false;
            }
            if (textBox6.Text == "")
            {
                CheckTextBoxMistake(textBox6, "Пустая строка");
                success = false;
            }
            if (textBox5.Text == "")
            {
                CheckTextBoxMistake(textBox5, "Пустая строка");
                success = false;
            }
            if (comboBox4.SelectedIndex == -1)
            {
                comboBox4.Text = "Выберите факультет";
                success = false;
            }
            else
            {
                if (comboBox3.SelectedIndex == -1)
                {
                    comboBox3.Text = "Выберите специальность";
                    success = false;
                }
            }
            if(comboBox2.Items.Count==0)
            {
                comboBox2.Text = "Недостаточно семестров";
                success = false;
            }
            if(success)
            {
                this.DataGrid.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged -= new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
                studentSave.NameStudent = textBox10.Text;
                studentSave.SurnameStudent = textBox9.Text;
                studentSave.PatronymicStudent = textBox8.Text;
                studentSave.NameCurator = textBox7.Text;
                studentSave.SurnameCurator = textBox6.Text;
                studentSave.PatronymicCurator = textBox5.Text;
                studentSave.Faculty = comboBox4.Text;
                studentSave.Specialty = comboBox3.Text;
                _myDataBase.ChangeObject(studentSave, ChooseStudent, DataGrid);
                studentSave = null;
                imagePersonal7_Click(sender,e);
                this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            }
            
        }
        /// <summary>
        /// Открывает подменю для фильтрации базы данных
        /// </summary>
        private void ButtonForSort_Click(object sender, EventArgs e)
        {
            foreach(var control in ControlsForUnderMenuSort)
            {
                control.Visible=!control.Visible;
            }
            ButtonSaveBaseData.Visible = !ButtonSaveBaseData.Visible;
            LabelSaveBaseData.Visible = !LabelSaveBaseData.Visible;
        }
        /// <summary>
        /// Открывает виджеты для фильтрации по факультетам
        /// </summary>
        private void ButtonSortFaculties_Click(object sender, EventArgs e)
        {
            HideControlsForSurnames();
            if (ComboBoxSpecialitySort.Visible)
            {
                foreach (Control control in ControlsForSort)
                {
                    control.Hide();
                }
                ComboBoxSortFaculties.Show();
                LabelForFacultiesSort.Show();
            }
            else
            {
                ComboBoxSortFaculties.Visible = !ComboBoxSortFaculties.Visible;
                LabelForFacultiesSort.Visible = !LabelForFacultiesSort.Visible;
            }
            ComboBoxSortFaculties.Text = "Факультеты";
            if (_myDataBase.ListObjects.Count != this.DataGrid.Rows.Count)
            {
                this.DataGrid.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged -= new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
                this.DataGrid.Rows.Clear();
                _myDataBase.CreateSource(DataGrid, _myDataBase.ListObjects);
                this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            }
        }
        /// <summary>
        /// Фильтрует данные базы данных по выбранному факультету
        /// </summary>
        private void ComboBoxSortFaculties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ComboBoxSpecialitySort.Visible)
            {
                BufferSortStudents = _myDataBase.ListObjects.Where(x => x.Faculty == ComboBoxSortFaculties.Text).ToList();
                this.DataGrid.Rows.Clear();
                this.DataGrid.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged -= new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
                _myDataBase.CreateSource(DataGrid, BufferSortStudents);
                this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            }
            else
            {
                ComboBoxSpecialitySort.Items.Clear();
                ComboBoxSpecialitySort.Text = "Специальности";
                foreach (string Speciality in Specialities[ComboBoxSortFaculties.SelectedIndex])
                {
                    ComboBoxSpecialitySort.Items.Add(Speciality);
                }
            }
        }

        private void LabelForFacultiesSort_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Открывает виджеты для фильтрации по  специальностям
        /// </summary>
        private void ButtonForSortSpeciality_Click(object sender, EventArgs e)
        {
            HideControlsForSurnames();
            if (ComboBoxSpecialitySort.Visible)
            {
                if (!CheckBoxPassedForTwo.Visible)
                {
                    foreach (Control control in ControlsForSort)
                    {
                        control.Hide();
                    }
                }
                else
                {
                    CheckBoxPassedForFive.Hide();
                    CheckBoxPassedForFour.Hide();
                    CheckBoxPassedForThree.Hide();
                    CheckBoxPassedForTwo.Hide();
                    ButtonGenerateReports.Hide();
                    LabelForComboBoxSortSpeciality.Show();
                    LabelForFacultiesSort.Show();
                    ComboBoxSpecialitySort.Show();
                    ComboBoxSortFaculties.Show();
                }
            }
            else
            { 
                LabelForComboBoxSortSpeciality.Show();
                LabelForFacultiesSort.Show();
                ComboBoxSpecialitySort.Show();
                ComboBoxSortFaculties.Show();
            }
            if (_myDataBase.ListObjects.Count != this.DataGrid.Rows.Count)
            {
                this.DataGrid.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged -= new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
                this.DataGrid.Rows.Clear();
                _myDataBase.CreateSource(DataGrid, _myDataBase.ListObjects);
                this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            }
            ComboBoxSpecialitySort.Text = "Специальности";
            ComboBoxSortFaculties.Text = "Факультеты";
        }
        /// <summary>
        /// Фильтрует данные базы данных по выбранной спецаильности
        /// </summary>
        private void ComboBoxSpecialitySort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!CheckBoxPassedForFive.Visible)
            {
                BufferSortStudents = _myDataBase.ListObjects.Where(x => x.Specialty == ComboBoxSpecialitySort.Text).ToList();
                this.DataGrid.Rows.Clear();
                this.DataGrid.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged -= new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
                _myDataBase.CreateSource(DataGrid, BufferSortStudents);
                this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            }
        }
        /// <summary>
        /// Открывает виджеты для фильтрации по успеваемости
        /// </summary>
        private void ButtonSuccessLearning_Click(object sender, EventArgs e)
        {
            HideControlsForSurnames();
            if (CheckBoxPassedForTwo.Visible)
            {
                LabelForComboBoxSortSpeciality.Hide();
                LabelForFacultiesSort.Hide();
                ComboBoxSpecialitySort.Hide();
                ComboBoxSortFaculties.Hide();
                CheckBoxPassedForFive.Hide();
                CheckBoxPassedForFour.Hide();
                CheckBoxPassedForThree.Hide();
                CheckBoxPassedForTwo.Hide();
                ButtonGenerateReports.Hide();
                if (_myDataBase.ListObjects.Count != this.DataGrid.Rows.Count)
                {
                    this.DataGrid.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                    this.DataGrid.CurrentCellDirtyStateChanged -= new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
                    this.DataGrid.Rows.Clear();
                    _myDataBase.CreateSource(DataGrid, _myDataBase.ListObjects);
                    this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                    this.DataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
                }
            }
            else
            {
                if (!LabelForComboBoxSortSpeciality.Visible)
                {
                    LabelForComboBoxSortSpeciality.Show();
                    ComboBoxSpecialitySort.Show();
                }
                if (!LabelForFacultiesSort.Visible)
                {
                    LabelForFacultiesSort.Show();
                    ComboBoxSortFaculties.Show();
                }
                CheckBoxPassedForFive.Show();
                ButtonGenerateReports.Show();
                CheckBoxPassedForFour.Show();
                CheckBoxPassedForThree.Show();
                CheckBoxPassedForTwo.Show();
                ComboBoxSpecialitySort.Text = "Специальности";
                ComboBoxSortFaculties.Text = "Факультеты";
                BufferSortStudents.Clear();
            }
            foreach (Control control in ControlsForSort)
            {
                if(control is CheckBox)
                {
                    (control as CheckBox).Checked = false ;
                }
            }
        }
        /// <summary>
        /// устанавливает выбор флажков на выкл. у всех, кроме варианта "не сдавшие"
        /// </summary>
        private void CheckBoxPassedForTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxPassedForTwo.Checked)
            {
                CheckBoxPassedForFive.Checked = false;
                CheckBoxPassedForFour.Checked = false;
                CheckBoxPassedForThree.Checked = false;
                CheckBoxPassedForTwo.Checked = true;
            }
        }
        /// <summary>
        ///  Устанавливает флажок на выкл. у варианта "не сдавшие"
        /// </summary>
        private void CheckBoxPassedForThree_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxPassedForTwo.Checked = false;
        }
        /// <summary>
        ///  Устанавливает флажок на выкл. у варианта "не сдавшие"
        /// </summary>
        private void CheckBoxPassedForFive_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxPassedForTwo.Checked = false;
        }
        /// <summary>
        ///  Устанавливает флажок на выкл. у варианта "не сдавшие"
        /// </summary>
        private void CheckBoxPassedForFour_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxPassedForTwo.Checked = false;
        }
        /// <summary>
        ///  Фильтрует студентов по успеваемости с выбор факультета и специальности включительно
        /// </summary>
        private void ButtonGenerateReports_Click(object sender, EventArgs e)
        {
            BufferSortStudents.Clear();
            if (CheckBoxPassedForFive.Checked)
            {
                if(BufferSortStudents.Count==0)
                {
                    BufferSortStudents = _myDataBase.ListObjects.Where(x => x.PersonalRecordBook.Semesters.All(y => y.Disciplines.All(z =>z.GetSuccess()== "оценка 5" || z.GetSuccess() == "зачет"))).ToList();
                }
            }
            if(CheckBoxPassedForFour.Checked)
            {
                if (BufferSortStudents.Count == 0)
                {
                    BufferSortStudents = _myDataBase.ListObjects.Where(x => x.PersonalRecordBook.Semesters.All(y => y.Disciplines.All(z => z.GetSuccess() == "оценка 5" || z.GetSuccess() == "оценка 4" || z.GetSuccess() == "зачет") && y.Disciplines.Any(z => z.GetSuccess() == "оценка 4"))).ToList();
                }
                else
                {
                    BufferSortStudents=BufferSortStudents.Union(_myDataBase.ListObjects.Where(x => x.PersonalRecordBook.Semesters.All(y => y.Disciplines.All(z => z.GetSuccess() == "оценка 5" || z.GetSuccess() == "оценка 4" || z.GetSuccess() == "зачет"))).ToList()).ToList();
                }
            }
            if (CheckBoxPassedForThree.Checked)
            {
                if (BufferSortStudents.Count == 0)
                {
                    BufferSortStudents = _myDataBase.ListObjects.Where(x => x.PersonalRecordBook.Semesters.All(y => y.Disciplines.All(z => z.GetSuccess() == "оценка 5" || z.GetSuccess() == "оценка 4" || z.GetSuccess() == "оценка 3" || z.GetSuccess() == "зачет") && y.Disciplines.Any(z => z.GetSuccess() == "оценка 3"))).ToList();
                }
                else
                {
                    BufferSortStudents = BufferSortStudents.Union(_myDataBase.ListObjects.Where(x => x.PersonalRecordBook.Semesters.All(y => y.Disciplines.All(z => z.GetSuccess() == "оценка 5" || z.GetSuccess() == "оценка 4" || z.GetSuccess() == "оценка 3" || z.GetSuccess() == "зачет"))).ToList()).ToList();
                }
            }
            if (CheckBoxPassedForTwo.Checked)
            {
                if (BufferSortStudents.Count == 0)
                {
                    BufferSortStudents = _myDataBase.ListObjects.Where(x => x.PersonalRecordBook.Semesters.All(y => y.Disciplines.Any(z => z.GetSuccess() == "оценка 1" || z.GetSuccess() == "оценка 2" || z.GetSuccess() == "незачет"))).ToList();
                }
            }
            if(ComboBoxSortFaculties.SelectedIndex!=-1)
            {
                if (BufferSortStudents.Count == 0)
                {
                    BufferSortStudents = _myDataBase.ListObjects.Where(x => x.Faculty == ComboBoxSortFaculties.Text).ToList();
                }
                else
                {
                    BufferSortStudents = BufferSortStudents.Where(x => x.Faculty == ComboBoxSortFaculties.Text).ToList();
                }
            }
            if (ComboBoxSpecialitySort.SelectedIndex != -1)
            {
                BufferSortStudents = BufferSortStudents.Where(x => x.Specialty == ComboBoxSpecialitySort.Text).ToList();
            }
            this.DataGrid.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
            this.DataGrid.CurrentCellDirtyStateChanged -= new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            this.DataGrid.Rows.Clear();
            _myDataBase.CreateSource(DataGrid, BufferSortStudents);
            this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
            this.DataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
        }
        /// <summary>
        /// Сохраняет базу данных в файл
        /// </summary>
        private void ButtonSaveBaseData_Click(object sender, EventArgs e)
        {
            var binFormater = new BinaryFormatter();
            using (var file = new FileStream("FileSaveBaseData.bin", FileMode.OpenOrCreate))
            {
                binFormater.Serialize(file, _myDataBase);
                file.Close();
            }
        }
        /// <summary>
        /// Открывает подменю для фильтрации базы данных
        /// </summary>
        private void LabelForSort_Click(object sender, EventArgs e)
        {
            ButtonForSort_Click(sender, e);
        }
        /// <summary>
        /// Сохраняет базу данных в файл
        /// </summary>
        private void LabelSaveBaseData_Click(object sender, EventArgs e)
        {
            ButtonSaveBaseData_Click(sender, e);
        }
        /// <summary>
        /// Скрывает виджеты для фильтрации по фамилиям
        /// </summary>
        private void HideControlsForSurnames()
        {
            ButtonStartSortSurnames.Hide();
            TextBoxSurnames.Hide();
            LabelForSurnames.Hide();
        }
        /// <summary>
        /// Скрывает или открывает виджеты для фильтрации по фамилиям
        /// </summary>
        private void ButtonForSortSameSurname_Click(object sender, EventArgs e)
        {
            foreach (Control control in ControlsForSort)
            {
                control.Hide();
            }
            if (_myDataBase.ListObjects.Count != this.DataGrid.Rows.Count)
            {
                this.DataGrid.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged -= new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
                this.DataGrid.Rows.Clear();
                _myDataBase.CreateSource(DataGrid, _myDataBase.ListObjects);
                this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
                this.DataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            }
            ButtonStartSortSurnames.Visible = !ButtonStartSortSurnames.Visible;
            TextBoxSurnames.Visible = !TextBoxSurnames.Visible;
            LabelForSurnames.Visible = !LabelForSurnames.Visible;
        }
        /// <summary>
        /// Фильтрует студентов по фамилии
        /// </summary>
        private void ButtonStartSortSurnames_Click(object sender, EventArgs e)
        {
            BufferSortStudents.Clear();
            BufferSortStudents = _myDataBase.ListObjects.Where(x => x.SurnameStudent == TextBoxSurnames.Text).ToList();
            if(BufferSortStudents.Count==0)
            {
                TextBoxSurnames.Text = "Не найдено";
                TextBoxSurnames.ForeColor = Color.Red;
                this.ActiveControl = null;
                return;
            }
           this.DataGrid.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
            this.DataGrid.CurrentCellDirtyStateChanged -= new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            this.DataGrid.Rows.Clear();
            _myDataBase.CreateSource(DataGrid, BufferSortStudents);
            this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
            this.DataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
        }
    }
}
