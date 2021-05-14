using System.Windows.Forms;
using System.Collections.Generic;
namespace CourseProject
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        private void AddControlsForAdd()
        {
            ControlsForAdd.Add(LabelTittleAdd);
            ControlsForAdd.Add(ButtonBackAdd);
            ControlsForAdd.Add(LabelAddPatronymicStudent);
            ControlsForAdd.Add(TextBoxAddPatronymicStudent);
            ControlsForAdd.Add(LabelAddSurnameStudent);
            ControlsForAdd.Add(TextBoxAddSurnameStudent);
            ControlsForAdd.Add(LabelNameStudentAdd);
            ControlsForAdd.Add(TextBoxAddNameStudent);
            ControlsForAdd.Add(LabelAddSpecialty);
            ControlsForAdd.Add(ComboBoxAddSpecialty);
            ControlsForAdd.Add(LabelAddFaculty);
            ControlsForAdd.Add(ComboBoxAddFaculty);
            ControlsForAdd.Add(LabelAddPatronymicCurator);
            ControlsForAdd.Add(TextBoxAddPatronymicCurator);
            ControlsForAdd.Add(LabelAddSurnameCurator);
            ControlsForAdd.Add(TextBoxAddSurnameCurator);
            ControlsForAdd.Add(LabelAddNameCurator);
            ControlsForAdd.Add(TextBoxAddNameCurator);
            ControlsForAdd.Add(LabelAddSemesters);
            ControlsForAdd.Add(ComboBoxAddSemesters);
            ControlsForAdd.Add(ButtonAddSemester);
            ControlsForAdd.Add(ButtonDeleteSemester);
            ControlsForAdd.Add(LabelBackAdd);
            ControlsForAdd.Add(LabelAddSaveStudent);
            ControlsForAdd.Add(ButtonAddSaveStudent);
            foreach (Control control in ControlsForAdd)
            {
                control.Hide();
            }
        }
        private void AddControlsForAddSemester()
        {
            ControlsForAddSemester.Add(LabelAddNumberSemester);
            ControlsForAddSemester.Add(ButtonAddExam);
            ControlsForAddSemester.Add(ButtonAddDeleteDiscipline);
            ControlsForAddSemester.Add(LabelAddDisciplines);
            ControlsForAddSemester.Add(ComboBoxAddDisciplines);
            ControlsForAddSemester.Add(LabelAddExam);
            ControlsForAddSemester.Add(LabelAddCredit);
            ControlsForAddSemester.Add(ButtonAddCredit);
            ControlsForAddSemester.Add(ButtonBackAddSemester);
            ControlsForAddSemester.Add(LabelAddSaveSemester);
            ControlsForAddSemester.Add(ButtonAddSaveSemester);
            foreach (Control control in ControlsForAddSemester)
            {
                control.Hide();
            }
        }
        private void AddControlsForAddDisciplines()
        {
            ControlsGenericDiscipline.Add(LabelAddSaveDiscipline);
            ControlsGenericDiscipline.Add(ButtonBackAddDiscipline);
            ControlsGenericDiscipline.Add(TextBoxNameDiscipline);
            ControlsGenericDiscipline.Add(LabelNameDiscipline);
            ControlsGenericDiscipline.Add(TextBoxAddCountHours);
            ControlsGenericDiscipline.Add(LabelCountHoursAdd);
            ControlsGenericDiscipline.Add(TextBoxAddNameTeacher);
            ControlsGenericDiscipline.Add(LabelAddNameTeacher);
            ControlsGenericDiscipline.Add(ButtonAddSaveDiscipline);
            ControlsGenericDiscipline.Add(LabelTittleAddDiscipline);
            foreach (Control control in ControlsGenericDiscipline)
            {
                control.Hide();
            }
        }
        private void AddControlsForChangeSemester()
        {
            ControlsForChangeSemester.Add(imagePersonal4);
            ControlsForChangeSemester.Add(label18);
            ControlsForChangeSemester.Add(imagePersonal5);
            ControlsForChangeSemester.Add(imagePersonal6);
            ControlsForChangeSemester.Add(imagePersonal8);
            ControlsForChangeSemester.Add(labelMy4);
            ControlsForChangeSemester.Add(labelMy3);
            ControlsForChangeSemester.Add(label4);
            ControlsForChangeSemester.Add(comboBox1);
            ControlsForChangeSemester.Add(labelMy6);
            ControlsForChangeSemester.Add(imagePersonal11);
            foreach (Control control in ControlsForChangeSemester)
            {
                control.Hide();
            }
        }
        private void AddControlsForChangeDiscipline()
        {
            ControlsForChangeDiscipline.Add(imagePersonal2);
            ControlsForChangeDiscipline.Add(label3);
            ControlsForChangeDiscipline.Add(label8);
            ControlsForChangeDiscipline.Add(label7);
            ControlsForChangeDiscipline.Add(label6);
            ControlsForChangeDiscipline.Add(textBox4);
            ControlsForChangeDiscipline.Add(textBox3);
            ControlsForChangeDiscipline.Add(textBox2);
            ControlsForChangeDiscipline.Add(imagePersonal3);
            ControlsForChangeDiscipline.Add(labelMy2);
            foreach (Control control in ControlsForChangeDiscipline)
            {
                control.Hide();
            }
        }
        private void AddControlsForUnderMenu()
        {
            ControlsForUnderMenuSort.Add(ButtonSortFaculties);
            ControlsForUnderMenuSort.Add(LabelForFacultySort);
            ControlsForUnderMenuSort.Add(ButtonForSortSpeciality);
            ControlsForUnderMenuSort.Add(LabelForButtonSortSpiciality);
            ControlsForUnderMenuSort.Add(ButtonSuccessLearning);
            ControlsForUnderMenuSort.Add(LabelSuccessLearning);
            ControlsForUnderMenuSort.Add(ButtonForSortSameSurname);
            ControlsForUnderMenuSort.Add(LabelForSortSameSurname);
            foreach (Control control in ControlsForUnderMenuSort)
            {
                control.Hide();
            }
        }
        private void AddControlsForSort()
        {
            ControlsForSort.Add(ComboBoxSortFaculties);
            ControlsForSort.Add(LabelForFacultiesSort);
            ControlsForSort.Add(LabelForComboBoxSortSpeciality);
            ControlsForSort.Add(ComboBoxSpecialitySort);
            ControlsForSort.Add(CheckBoxPassedForFive);
            ControlsForSort.Add(CheckBoxPassedForFour);
            ControlsForSort.Add(CheckBoxPassedForThree);
            ControlsForSort.Add(CheckBoxPassedForTwo);
            ControlsForSort.Add(ButtonGenerateReports);
            foreach (Control control in ControlsForSort)
            {
                control.Hide();
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MainPanel = new Lab__8.GradientPanel();
            this.PanelMenu = new Lab__8.GradientPanel();
            this.ButtonSaveBaseData = new CourseProject.ImagePersonal();
            this.LabelSaveBaseData = new CourseProject.LabelMy();
            this.BackForSaveDataBase = new CourseProject.ImagePersonal();
            this.imagePersonal19 = new CourseProject.ImagePersonal();
            this.labelMy10 = new CourseProject.LabelMy();
            this.imagePersonal20 = new CourseProject.ImagePersonal();
            this.ButtonForSortSameSurname = new CourseProject.ImagePersonal();
            this.LabelForSortSameSurname = new CourseProject.LabelMy();
            this.BackForSortSameSurname = new CourseProject.ImagePersonal();
            this.ButtonSuccessLearning = new CourseProject.ImagePersonal();
            this.LabelSuccessLearning = new CourseProject.LabelMy();
            this.imagePersonal16 = new CourseProject.ImagePersonal();
            this.ButtonForSortSpeciality = new CourseProject.ImagePersonal();
            this.LabelForButtonSortSpiciality = new CourseProject.LabelMy();
            this.ButtonBackSpeciality = new CourseProject.ImagePersonal();
            this.ButtonSortFaculties = new CourseProject.ImagePersonal();
            this.LabelForFacultySort = new CourseProject.LabelMy();
            this.imagePersonal13 = new CourseProject.ImagePersonal();
            this.ButtonForSort = new CourseProject.ImagePersonal();
            this.LabelForSort = new CourseProject.LabelMy();
            this.BackForButtonSort = new CourseProject.ImagePersonal();
            this.ButtonChangeStudent = new CourseProject.ImagePersonal();
            this.LabelChange = new CourseProject.LabelMy();
            this.BackButtonChange = new CourseProject.ImagePersonal();
            this.ButtonAdd = new CourseProject.ImagePersonal();
            this.LabelAdd = new CourseProject.LabelMy();
            this.BackGroundButtonAdd = new CourseProject.ImagePersonal();
            this.TittleMenu = new CourseProject.LabelMy();
            this.ButtonStartSortSurnames = new CourseProject.ImagePersonal();
            this.LabelForSurnames = new System.Windows.Forms.Label();
            this.TextBoxSurnames = new System.Windows.Forms.TextBox();
            this.ButtonGenerateReports = new CourseProject.ImagePersonal();
            this.CheckBoxPassedForTwo = new System.Windows.Forms.CheckBox();
            this.CheckBoxPassedForThree = new System.Windows.Forms.CheckBox();
            this.LabelForComboBoxSortSpeciality = new System.Windows.Forms.Label();
            this.ComboBoxSpecialitySort = new System.Windows.Forms.ComboBox();
            this.LabelForFacultiesSort = new System.Windows.Forms.Label();
            this.ComboBoxSortFaculties = new System.Windows.Forms.ComboBox();
            this.ButtonDeleteObject = new CourseProject.ImagePersonal();
            this.ButtonFindStudent = new System.Windows.Forms.PictureBox();
            this.TextBoxFindStudent = new System.Windows.Forms.TextBox();
            this.LabelAddSaveStudent = new CourseProject.LabelMy();
            this.ButtonAddSaveStudent = new CourseProject.ImagePersonal();
            this.LabelAddSaveSemester = new CourseProject.LabelMy();
            this.ButtonAddSaveSemester = new CourseProject.ImagePersonal();
            this.ButtonBackAddDiscipline = new CourseProject.ImagePersonal();
            this.LabelAddSaveDiscipline = new CourseProject.LabelMy();
            this.ButtonAddSaveDiscipline = new CourseProject.ImagePersonal();
            this.ButtonBackAddSemester = new CourseProject.ImagePersonal();
            this.LabelAddCredit = new CourseProject.LabelMy();
            this.ButtonAddCredit = new CourseProject.ImagePersonal();
            this.LabelAddExam = new CourseProject.LabelMy();
            this.ButtonAddExam = new CourseProject.ImagePersonal();
            this.ButtonBackAdd = new CourseProject.ImagePersonal();
            this.LabelBackAdd = new CourseProject.LabelMy();
            this.LabelNameDiscipline = new System.Windows.Forms.Label();
            this.TextBoxNameDiscipline = new System.Windows.Forms.TextBox();
            this.LabelAddNameCurator = new System.Windows.Forms.Label();
            this.TextBoxAddNameCurator = new System.Windows.Forms.TextBox();
            this.LabelNameStudentAdd = new System.Windows.Forms.Label();
            this.TextBoxAddNameStudent = new System.Windows.Forms.TextBox();
            this.LabelMenu = new CourseProject.LabelMy();
            this.ButtonMenu = new CourseProject.ImagePersonal();
            this.OnOffButton = new CourseProject.OnOffWidjet();
            this.LabelCreditNotPassed = new System.Windows.Forms.Label();
            this.LabelCreditPassed = new System.Windows.Forms.Label();
            this.LabelTittleAddDiscipline = new System.Windows.Forms.Label();
            this.ButtonAddDeleteDiscipline = new CourseProject.ImagePersonal();
            this.LabelAddDisciplines = new System.Windows.Forms.Label();
            this.ComboBoxAddDisciplines = new System.Windows.Forms.ComboBox();
            this.LabelAddAssessment = new System.Windows.Forms.Label();
            this.LabelAddNameTeacher = new System.Windows.Forms.Label();
            this.TextBoxAddNameTeacher = new System.Windows.Forms.TextBox();
            this.LabelCountHoursAdd = new System.Windows.Forms.Label();
            this.TextBoxAddCountHours = new System.Windows.Forms.TextBox();
            this.LabelAddSemesters = new System.Windows.Forms.Label();
            this.ComboBoxAddSemesters = new System.Windows.Forms.ComboBox();
            this.LabelAddPatronymicCurator = new System.Windows.Forms.Label();
            this.TextBoxAddPatronymicCurator = new System.Windows.Forms.TextBox();
            this.LabelAddSurnameCurator = new System.Windows.Forms.Label();
            this.TextBoxAddSurnameCurator = new System.Windows.Forms.TextBox();
            this.LabelAddSpecialty = new System.Windows.Forms.Label();
            this.ComboBoxAddSpecialty = new System.Windows.Forms.ComboBox();
            this.LabelAddFaculty = new System.Windows.Forms.Label();
            this.ComboBoxAddFaculty = new System.Windows.Forms.ComboBox();
            this.LabelAddPatronymicStudent = new System.Windows.Forms.Label();
            this.TextBoxAddPatronymicStudent = new System.Windows.Forms.TextBox();
            this.LabelAddSurnameStudent = new System.Windows.Forms.Label();
            this.TextBoxAddSurnameStudent = new System.Windows.Forms.TextBox();
            this.ButtonDeleteSemester = new CourseProject.ImagePersonal();
            this.ButtonAddSemester = new CourseProject.ImagePersonal();
            this.LabelAddNumberSemester = new System.Windows.Forms.Label();
            this.LabelTittleAdd = new System.Windows.Forms.Label();
            this.TrackBarAssessmentAdd = new System.Windows.Forms.TrackBar();
            this.CheckBoxPassedForFour = new System.Windows.Forms.CheckBox();
            this.CheckBoxPassedForFive = new System.Windows.Forms.CheckBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemestersBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Disciplines = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CountHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTeacherBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuccessDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCurotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelForChnageStudent = new Lab__8.GradientPanel();
            this.onOffWidjet1 = new CourseProject.OnOffWidjet();
            this.labelMy6 = new CourseProject.LabelMy();
            this.imagePersonal11 = new CourseProject.ImagePersonal();
            this.labelMy1 = new CourseProject.LabelMy();
            this.imagePersonal1 = new CourseProject.ImagePersonal();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imagePersonal2 = new CourseProject.ImagePersonal();
            this.labelMy2 = new CourseProject.LabelMy();
            this.imagePersonal3 = new CourseProject.ImagePersonal();
            this.imagePersonal4 = new CourseProject.ImagePersonal();
            this.labelMy3 = new CourseProject.LabelMy();
            this.imagePersonal5 = new CourseProject.ImagePersonal();
            this.labelMy4 = new CourseProject.LabelMy();
            this.imagePersonal6 = new CourseProject.ImagePersonal();
            this.imagePersonal7 = new CourseProject.ImagePersonal();
            this.labelMy5 = new CourseProject.LabelMy();
            this.imagePersonal8 = new CourseProject.ImagePersonal();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.imagePersonal9 = new CourseProject.ImagePersonal();
            this.imagePersonal10 = new CourseProject.ImagePersonal();
            this.label18 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSaveBaseData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackForSaveDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonForSortSameSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackForSortSameSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSuccessLearning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonForSortSpeciality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBackSpeciality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSortFaculties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonForSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackForButtonSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonChangeStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundButtonAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonStartSortSurnames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonGenerateReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDeleteObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonFindStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddSaveStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddSaveSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBackAddDiscipline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddSaveDiscipline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBackAddSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBackAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnOffButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddDeleteDiscipline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDeleteSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAssessmentAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.PanelForChnageStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onOffWidjet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Angle = 75F;
            this.MainPanel.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(156)))), ((int)(((byte)(107)))));
            this.MainPanel.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.MainPanel.Controls.Add(this.PanelMenu);
            this.MainPanel.Controls.Add(this.ButtonStartSortSurnames);
            this.MainPanel.Controls.Add(this.LabelForSurnames);
            this.MainPanel.Controls.Add(this.TextBoxSurnames);
            this.MainPanel.Controls.Add(this.ButtonGenerateReports);
            this.MainPanel.Controls.Add(this.CheckBoxPassedForTwo);
            this.MainPanel.Controls.Add(this.CheckBoxPassedForThree);
            this.MainPanel.Controls.Add(this.LabelForComboBoxSortSpeciality);
            this.MainPanel.Controls.Add(this.ComboBoxSpecialitySort);
            this.MainPanel.Controls.Add(this.LabelForFacultiesSort);
            this.MainPanel.Controls.Add(this.ComboBoxSortFaculties);
            this.MainPanel.Controls.Add(this.ButtonDeleteObject);
            this.MainPanel.Controls.Add(this.ButtonFindStudent);
            this.MainPanel.Controls.Add(this.TextBoxFindStudent);
            this.MainPanel.Controls.Add(this.LabelAddSaveStudent);
            this.MainPanel.Controls.Add(this.LabelAddSaveSemester);
            this.MainPanel.Controls.Add(this.ButtonBackAddDiscipline);
            this.MainPanel.Controls.Add(this.LabelAddSaveDiscipline);
            this.MainPanel.Controls.Add(this.ButtonBackAddSemester);
            this.MainPanel.Controls.Add(this.LabelAddCredit);
            this.MainPanel.Controls.Add(this.LabelAddExam);
            this.MainPanel.Controls.Add(this.ButtonBackAdd);
            this.MainPanel.Controls.Add(this.LabelBackAdd);
            this.MainPanel.Controls.Add(this.ButtonAddSaveDiscipline);
            this.MainPanel.Controls.Add(this.LabelNameDiscipline);
            this.MainPanel.Controls.Add(this.TextBoxNameDiscipline);
            this.MainPanel.Controls.Add(this.LabelAddNameCurator);
            this.MainPanel.Controls.Add(this.TextBoxAddNameCurator);
            this.MainPanel.Controls.Add(this.LabelNameStudentAdd);
            this.MainPanel.Controls.Add(this.TextBoxAddNameStudent);
            this.MainPanel.Controls.Add(this.LabelMenu);
            this.MainPanel.Controls.Add(this.ButtonAddExam);
            this.MainPanel.Controls.Add(this.ButtonMenu);
            this.MainPanel.Controls.Add(this.ButtonAddSaveStudent);
            this.MainPanel.Controls.Add(this.OnOffButton);
            this.MainPanel.Controls.Add(this.LabelCreditNotPassed);
            this.MainPanel.Controls.Add(this.LabelCreditPassed);
            this.MainPanel.Controls.Add(this.LabelTittleAddDiscipline);
            this.MainPanel.Controls.Add(this.ButtonAddCredit);
            this.MainPanel.Controls.Add(this.ButtonAddDeleteDiscipline);
            this.MainPanel.Controls.Add(this.LabelAddDisciplines);
            this.MainPanel.Controls.Add(this.ComboBoxAddDisciplines);
            this.MainPanel.Controls.Add(this.LabelAddAssessment);
            this.MainPanel.Controls.Add(this.LabelAddNameTeacher);
            this.MainPanel.Controls.Add(this.TextBoxAddNameTeacher);
            this.MainPanel.Controls.Add(this.LabelCountHoursAdd);
            this.MainPanel.Controls.Add(this.TextBoxAddCountHours);
            this.MainPanel.Controls.Add(this.LabelAddSemesters);
            this.MainPanel.Controls.Add(this.ComboBoxAddSemesters);
            this.MainPanel.Controls.Add(this.LabelAddPatronymicCurator);
            this.MainPanel.Controls.Add(this.TextBoxAddPatronymicCurator);
            this.MainPanel.Controls.Add(this.LabelAddSurnameCurator);
            this.MainPanel.Controls.Add(this.TextBoxAddSurnameCurator);
            this.MainPanel.Controls.Add(this.LabelAddSpecialty);
            this.MainPanel.Controls.Add(this.ComboBoxAddSpecialty);
            this.MainPanel.Controls.Add(this.LabelAddFaculty);
            this.MainPanel.Controls.Add(this.ComboBoxAddFaculty);
            this.MainPanel.Controls.Add(this.LabelAddPatronymicStudent);
            this.MainPanel.Controls.Add(this.TextBoxAddPatronymicStudent);
            this.MainPanel.Controls.Add(this.LabelAddSurnameStudent);
            this.MainPanel.Controls.Add(this.TextBoxAddSurnameStudent);
            this.MainPanel.Controls.Add(this.ButtonDeleteSemester);
            this.MainPanel.Controls.Add(this.ButtonAddSemester);
            this.MainPanel.Controls.Add(this.LabelAddNumberSemester);
            this.MainPanel.Controls.Add(this.LabelTittleAdd);
            this.MainPanel.Controls.Add(this.TrackBarAssessmentAdd);
            this.MainPanel.Controls.Add(this.CheckBoxPassedForFour);
            this.MainPanel.Controls.Add(this.CheckBoxPassedForFive);
            this.MainPanel.Controls.Add(this.ButtonAddSaveSemester);
            this.MainPanel.Controls.Add(this.DataGrid);
            this.MainPanel.ForeColor = System.Drawing.Color.Black;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.MinimumSize = new System.Drawing.Size(906, 542);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1027, 675);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Resize += new System.EventHandler(this.MainPanel_Resize);
            // 
            // PanelMenu
            // 
            this.PanelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelMenu.Angle = 25F;
            this.PanelMenu.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(102)))), ((int)(((byte)(104)))));
            this.PanelMenu.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.PanelMenu.Controls.Add(this.ButtonSaveBaseData);
            this.PanelMenu.Controls.Add(this.LabelSaveBaseData);
            this.PanelMenu.Controls.Add(this.BackForSaveDataBase);
            this.PanelMenu.Controls.Add(this.imagePersonal19);
            this.PanelMenu.Controls.Add(this.imagePersonal20);
            this.PanelMenu.Controls.Add(this.labelMy10);
            this.PanelMenu.Controls.Add(this.ButtonForSortSameSurname);
            this.PanelMenu.Controls.Add(this.BackForSortSameSurname);
            this.PanelMenu.Controls.Add(this.ButtonSuccessLearning);
            this.PanelMenu.Controls.Add(this.imagePersonal16);
            this.PanelMenu.Controls.Add(this.ButtonForSortSpeciality);
            this.PanelMenu.Controls.Add(this.ButtonBackSpeciality);
            this.PanelMenu.Controls.Add(this.ButtonSortFaculties);
            this.PanelMenu.Controls.Add(this.imagePersonal13);
            this.PanelMenu.Controls.Add(this.ButtonForSort);
            this.PanelMenu.Controls.Add(this.LabelForSort);
            this.PanelMenu.Controls.Add(this.BackForButtonSort);
            this.PanelMenu.Controls.Add(this.ButtonChangeStudent);
            this.PanelMenu.Controls.Add(this.LabelChange);
            this.PanelMenu.Controls.Add(this.ButtonAdd);
            this.PanelMenu.Controls.Add(this.BackGroundButtonAdd);
            this.PanelMenu.Controls.Add(this.TittleMenu);
            this.PanelMenu.Controls.Add(this.LabelAdd);
            this.PanelMenu.Controls.Add(this.BackButtonChange);
            this.PanelMenu.Controls.Add(this.LabelForFacultySort);
            this.PanelMenu.Controls.Add(this.LabelForButtonSortSpiciality);
            this.PanelMenu.Controls.Add(this.LabelSuccessLearning);
            this.PanelMenu.Controls.Add(this.LabelForSortSameSurname);
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(310, 675);
            this.PanelMenu.TabIndex = 1;
            this.PanelMenu.Visible = false;
            // 
            // ButtonSaveBaseData
            // 
            this.ButtonSaveBaseData.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSaveBaseData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSaveBaseData.Image = global::CourseProject.Properties.Resources.СохранитьБезФонаБазу;
            this.ButtonSaveBaseData.imageBase = global::CourseProject.Properties.Resources.СохранитьБезФонаБазу;
            this.ButtonSaveBaseData.imageChange = global::CourseProject.Properties.Resources.СохранитьСфономБазу;
            this.ButtonSaveBaseData.ImageClickDown = global::CourseProject.Properties.Resources.СохранитьСфономПоНажатиюБазу;
            this.ButtonSaveBaseData.labelMy = this.LabelSaveBaseData;
            this.ButtonSaveBaseData.Location = new System.Drawing.Point(30, 305);
            this.ButtonSaveBaseData.MyImageBack = this.BackForSaveDataBase;
            this.ButtonSaveBaseData.Name = "ButtonSaveBaseData";
            this.ButtonSaveBaseData.Size = new System.Drawing.Size(51, 46);
            this.ButtonSaveBaseData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonSaveBaseData.TabIndex = 38;
            this.ButtonSaveBaseData.TabStop = false;
            this.ButtonSaveBaseData.Click += new System.EventHandler(this.ButtonSaveBaseData_Click);
            // 
            // LabelSaveBaseData
            // 
            this.LabelSaveBaseData.AutoSize = true;
            this.LabelSaveBaseData.BackColor = System.Drawing.Color.Transparent;
            this.LabelSaveBaseData.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.LabelSaveBaseData.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.LabelSaveBaseData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSaveBaseData.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSaveBaseData.imagePersonal = this.ButtonSaveBaseData;
            this.LabelSaveBaseData.Location = new System.Drawing.Point(97, 307);
            this.LabelSaveBaseData.Name = "LabelSaveBaseData";
            this.LabelSaveBaseData.Size = new System.Drawing.Size(181, 36);
            this.LabelSaveBaseData.TabIndex = 37;
            this.LabelSaveBaseData.Text = "Сохранить";
            this.LabelSaveBaseData.Click += new System.EventHandler(this.LabelSaveBaseData_Click);
            // 
            // BackForSaveDataBase
            // 
            this.BackForSaveDataBase.BackColor = System.Drawing.Color.Transparent;
            this.BackForSaveDataBase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackForSaveDataBase.Image = ((System.Drawing.Image)(resources.GetObject("BackForSaveDataBase.Image")));
            this.BackForSaveDataBase.imageBase = ((System.Drawing.Image)(resources.GetObject("BackForSaveDataBase.imageBase")));
            this.BackForSaveDataBase.imageChange = ((System.Drawing.Image)(resources.GetObject("BackForSaveDataBase.imageChange")));
            this.BackForSaveDataBase.ImageClickDown = null;
            this.BackForSaveDataBase.labelMy = null;
            this.BackForSaveDataBase.Location = new System.Drawing.Point(15, 293);
            this.BackForSaveDataBase.MyImageBack = null;
            this.BackForSaveDataBase.Name = "BackForSaveDataBase";
            this.BackForSaveDataBase.Size = new System.Drawing.Size(81, 69);
            this.BackForSaveDataBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackForSaveDataBase.TabIndex = 36;
            this.BackForSaveDataBase.TabStop = false;
            this.BackForSaveDataBase.Visible = false;
            // 
            // imagePersonal19
            // 
            this.imagePersonal19.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal19.imageBase = null;
            this.imagePersonal19.imageChange = null;
            this.imagePersonal19.ImageClickDown = null;
            this.imagePersonal19.labelMy = this.labelMy10;
            this.imagePersonal19.Location = new System.Drawing.Point(49, 558);
            this.imagePersonal19.MyImageBack = this.imagePersonal20;
            this.imagePersonal19.Name = "imagePersonal19";
            this.imagePersonal19.Size = new System.Drawing.Size(38, 35);
            this.imagePersonal19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePersonal19.TabIndex = 35;
            this.imagePersonal19.TabStop = false;
            this.imagePersonal19.Visible = false;
            // 
            // labelMy10
            // 
            this.labelMy10.AutoSize = true;
            this.labelMy10.BackColor = System.Drawing.Color.Transparent;
            this.labelMy10.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.labelMy10.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.labelMy10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMy10.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMy10.imagePersonal = this.imagePersonal19;
            this.labelMy10.Location = new System.Drawing.Point(96, 560);
            this.labelMy10.Name = "labelMy10";
            this.labelMy10.Size = new System.Drawing.Size(166, 29);
            this.labelMy10.TabIndex = 34;
            this.labelMy10.Text = "Факультеты";
            this.labelMy10.Visible = false;
            // 
            // imagePersonal20
            // 
            this.imagePersonal20.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal20.imageBase = null;
            this.imagePersonal20.imageChange = null;
            this.imagePersonal20.ImageClickDown = null;
            this.imagePersonal20.labelMy = null;
            this.imagePersonal20.Location = new System.Drawing.Point(36, 544);
            this.imagePersonal20.MyImageBack = null;
            this.imagePersonal20.Name = "imagePersonal20";
            this.imagePersonal20.Size = new System.Drawing.Size(63, 60);
            this.imagePersonal20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePersonal20.TabIndex = 33;
            this.imagePersonal20.TabStop = false;
            this.imagePersonal20.Visible = false;
            // 
            // ButtonForSortSameSurname
            // 
            this.ButtonForSortSameSurname.BackColor = System.Drawing.Color.Transparent;
            this.ButtonForSortSameSurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonForSortSameSurname.Image = global::CourseProject.Properties.Resources.ОднофамильцыБезФона;
            this.ButtonForSortSameSurname.imageBase = global::CourseProject.Properties.Resources.ОднофамильцыБезФона;
            this.ButtonForSortSameSurname.imageChange = global::CourseProject.Properties.Resources.ОднофамильцыСФоном;
            this.ButtonForSortSameSurname.ImageClickDown = global::CourseProject.Properties.Resources.ОднофамильцыСФономПоНажатию;
            this.ButtonForSortSameSurname.labelMy = this.LabelForSortSameSurname;
            this.ButtonForSortSameSurname.Location = new System.Drawing.Point(49, 495);
            this.ButtonForSortSameSurname.MyImageBack = this.BackForSortSameSurname;
            this.ButtonForSortSameSurname.Name = "ButtonForSortSameSurname";
            this.ButtonForSortSameSurname.Size = new System.Drawing.Size(38, 35);
            this.ButtonForSortSameSurname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonForSortSameSurname.TabIndex = 32;
            this.ButtonForSortSameSurname.TabStop = false;
            this.ButtonForSortSameSurname.Visible = false;
            this.ButtonForSortSameSurname.Click += new System.EventHandler(this.ButtonForSortSameSurname_Click);
            // 
            // LabelForSortSameSurname
            // 
            this.LabelForSortSameSurname.AutoSize = true;
            this.LabelForSortSameSurname.BackColor = System.Drawing.Color.Transparent;
            this.LabelForSortSameSurname.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.LabelForSortSameSurname.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.LabelForSortSameSurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelForSortSameSurname.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForSortSameSurname.imagePersonal = this.ButtonForSortSameSurname;
            this.LabelForSortSameSurname.Location = new System.Drawing.Point(96, 497);
            this.LabelForSortSameSurname.Name = "LabelForSortSameSurname";
            this.LabelForSortSameSurname.Size = new System.Drawing.Size(213, 29);
            this.LabelForSortSameSurname.TabIndex = 31;
            this.LabelForSortSameSurname.Text = "Однофамильцы";
            this.LabelForSortSameSurname.Visible = false;
            // 
            // BackForSortSameSurname
            // 
            this.BackForSortSameSurname.BackColor = System.Drawing.Color.Transparent;
            this.BackForSortSameSurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackForSortSameSurname.Image = global::CourseProject.Properties.Resources.Фон;
            this.BackForSortSameSurname.imageBase = global::CourseProject.Properties.Resources.Фон;
            this.BackForSortSameSurname.imageChange = global::CourseProject.Properties.Resources.Фон;
            this.BackForSortSameSurname.ImageClickDown = null;
            this.BackForSortSameSurname.labelMy = null;
            this.BackForSortSameSurname.Location = new System.Drawing.Point(36, 481);
            this.BackForSortSameSurname.MyImageBack = null;
            this.BackForSortSameSurname.Name = "BackForSortSameSurname";
            this.BackForSortSameSurname.Size = new System.Drawing.Size(63, 60);
            this.BackForSortSameSurname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackForSortSameSurname.TabIndex = 30;
            this.BackForSortSameSurname.TabStop = false;
            this.BackForSortSameSurname.Visible = false;
            // 
            // ButtonSuccessLearning
            // 
            this.ButtonSuccessLearning.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSuccessLearning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSuccessLearning.Image = global::CourseProject.Properties.Resources.УспеваемостьБезФона;
            this.ButtonSuccessLearning.imageBase = global::CourseProject.Properties.Resources.УспеваемостьБезФона;
            this.ButtonSuccessLearning.imageChange = global::CourseProject.Properties.Resources.УспеваемостьСФоном;
            this.ButtonSuccessLearning.ImageClickDown = global::CourseProject.Properties.Resources.УспеваемостьСФономПоНажатию;
            this.ButtonSuccessLearning.labelMy = this.LabelSuccessLearning;
            this.ButtonSuccessLearning.Location = new System.Drawing.Point(49, 432);
            this.ButtonSuccessLearning.MyImageBack = this.imagePersonal16;
            this.ButtonSuccessLearning.Name = "ButtonSuccessLearning";
            this.ButtonSuccessLearning.Size = new System.Drawing.Size(38, 35);
            this.ButtonSuccessLearning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonSuccessLearning.TabIndex = 29;
            this.ButtonSuccessLearning.TabStop = false;
            this.ButtonSuccessLearning.Visible = false;
            this.ButtonSuccessLearning.Click += new System.EventHandler(this.ButtonSuccessLearning_Click);
            // 
            // LabelSuccessLearning
            // 
            this.LabelSuccessLearning.AutoSize = true;
            this.LabelSuccessLearning.BackColor = System.Drawing.Color.Transparent;
            this.LabelSuccessLearning.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.LabelSuccessLearning.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.LabelSuccessLearning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSuccessLearning.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSuccessLearning.imagePersonal = this.ButtonSuccessLearning;
            this.LabelSuccessLearning.Location = new System.Drawing.Point(96, 434);
            this.LabelSuccessLearning.Name = "LabelSuccessLearning";
            this.LabelSuccessLearning.Size = new System.Drawing.Size(188, 29);
            this.LabelSuccessLearning.TabIndex = 28;
            this.LabelSuccessLearning.Text = "Успеваемость";
            this.LabelSuccessLearning.Visible = false;
            // 
            // imagePersonal16
            // 
            this.imagePersonal16.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal16.Image = ((System.Drawing.Image)(resources.GetObject("imagePersonal16.Image")));
            this.imagePersonal16.imageBase = ((System.Drawing.Image)(resources.GetObject("imagePersonal16.imageBase")));
            this.imagePersonal16.imageChange = ((System.Drawing.Image)(resources.GetObject("imagePersonal16.imageChange")));
            this.imagePersonal16.ImageClickDown = null;
            this.imagePersonal16.labelMy = null;
            this.imagePersonal16.Location = new System.Drawing.Point(36, 418);
            this.imagePersonal16.MyImageBack = null;
            this.imagePersonal16.Name = "imagePersonal16";
            this.imagePersonal16.Size = new System.Drawing.Size(63, 60);
            this.imagePersonal16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePersonal16.TabIndex = 27;
            this.imagePersonal16.TabStop = false;
            this.imagePersonal16.Visible = false;
            // 
            // ButtonForSortSpeciality
            // 
            this.ButtonForSortSpeciality.BackColor = System.Drawing.Color.Transparent;
            this.ButtonForSortSpeciality.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonForSortSpeciality.Image = global::CourseProject.Properties.Resources.СпециальностьБезФона;
            this.ButtonForSortSpeciality.imageBase = global::CourseProject.Properties.Resources.СпециальностьБезФона;
            this.ButtonForSortSpeciality.imageChange = global::CourseProject.Properties.Resources.СпециальностьСФоном;
            this.ButtonForSortSpeciality.ImageClickDown = global::CourseProject.Properties.Resources.СпециальностьСФономПоНажатию;
            this.ButtonForSortSpeciality.labelMy = this.LabelForButtonSortSpiciality;
            this.ButtonForSortSpeciality.Location = new System.Drawing.Point(49, 369);
            this.ButtonForSortSpeciality.MyImageBack = this.ButtonBackSpeciality;
            this.ButtonForSortSpeciality.Name = "ButtonForSortSpeciality";
            this.ButtonForSortSpeciality.Size = new System.Drawing.Size(38, 35);
            this.ButtonForSortSpeciality.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonForSortSpeciality.TabIndex = 26;
            this.ButtonForSortSpeciality.TabStop = false;
            this.ButtonForSortSpeciality.Visible = false;
            this.ButtonForSortSpeciality.Click += new System.EventHandler(this.ButtonForSortSpeciality_Click);
            // 
            // LabelForButtonSortSpiciality
            // 
            this.LabelForButtonSortSpiciality.AutoSize = true;
            this.LabelForButtonSortSpiciality.BackColor = System.Drawing.Color.Transparent;
            this.LabelForButtonSortSpiciality.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.LabelForButtonSortSpiciality.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.LabelForButtonSortSpiciality.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelForButtonSortSpiciality.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForButtonSortSpiciality.imagePersonal = this.ButtonForSortSpeciality;
            this.LabelForButtonSortSpiciality.Location = new System.Drawing.Point(96, 371);
            this.LabelForButtonSortSpiciality.Name = "LabelForButtonSortSpiciality";
            this.LabelForButtonSortSpiciality.Size = new System.Drawing.Size(208, 29);
            this.LabelForButtonSortSpiciality.TabIndex = 25;
            this.LabelForButtonSortSpiciality.Text = "Специальности";
            this.LabelForButtonSortSpiciality.Visible = false;
            // 
            // ButtonBackSpeciality
            // 
            this.ButtonBackSpeciality.BackColor = System.Drawing.Color.Transparent;
            this.ButtonBackSpeciality.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBackSpeciality.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBackSpeciality.Image")));
            this.ButtonBackSpeciality.imageBase = ((System.Drawing.Image)(resources.GetObject("ButtonBackSpeciality.imageBase")));
            this.ButtonBackSpeciality.imageChange = ((System.Drawing.Image)(resources.GetObject("ButtonBackSpeciality.imageChange")));
            this.ButtonBackSpeciality.ImageClickDown = null;
            this.ButtonBackSpeciality.labelMy = null;
            this.ButtonBackSpeciality.Location = new System.Drawing.Point(36, 355);
            this.ButtonBackSpeciality.MyImageBack = null;
            this.ButtonBackSpeciality.Name = "ButtonBackSpeciality";
            this.ButtonBackSpeciality.Size = new System.Drawing.Size(63, 60);
            this.ButtonBackSpeciality.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonBackSpeciality.TabIndex = 24;
            this.ButtonBackSpeciality.TabStop = false;
            this.ButtonBackSpeciality.Visible = false;
            // 
            // ButtonSortFaculties
            // 
            this.ButtonSortFaculties.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSortFaculties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSortFaculties.Image = global::CourseProject.Properties.Resources.ФакультетыБезФона;
            this.ButtonSortFaculties.imageBase = global::CourseProject.Properties.Resources.ФакультетыБезФона;
            this.ButtonSortFaculties.imageChange = global::CourseProject.Properties.Resources.ФакультетыСФоном;
            this.ButtonSortFaculties.ImageClickDown = global::CourseProject.Properties.Resources.ФакультетыСФономПоНажатию;
            this.ButtonSortFaculties.labelMy = this.LabelForFacultySort;
            this.ButtonSortFaculties.Location = new System.Drawing.Point(48, 306);
            this.ButtonSortFaculties.MyImageBack = this.imagePersonal13;
            this.ButtonSortFaculties.Name = "ButtonSortFaculties";
            this.ButtonSortFaculties.Size = new System.Drawing.Size(38, 35);
            this.ButtonSortFaculties.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonSortFaculties.TabIndex = 23;
            this.ButtonSortFaculties.TabStop = false;
            this.ButtonSortFaculties.Click += new System.EventHandler(this.ButtonSortFaculties_Click);
            // 
            // LabelForFacultySort
            // 
            this.LabelForFacultySort.AutoSize = true;
            this.LabelForFacultySort.BackColor = System.Drawing.Color.Transparent;
            this.LabelForFacultySort.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.LabelForFacultySort.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.LabelForFacultySort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelForFacultySort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForFacultySort.imagePersonal = this.ButtonSortFaculties;
            this.LabelForFacultySort.Location = new System.Drawing.Point(95, 308);
            this.LabelForFacultySort.Name = "LabelForFacultySort";
            this.LabelForFacultySort.Size = new System.Drawing.Size(166, 29);
            this.LabelForFacultySort.TabIndex = 22;
            this.LabelForFacultySort.Text = "Факультеты";
            // 
            // imagePersonal13
            // 
            this.imagePersonal13.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal13.Image = ((System.Drawing.Image)(resources.GetObject("imagePersonal13.Image")));
            this.imagePersonal13.imageBase = ((System.Drawing.Image)(resources.GetObject("imagePersonal13.imageBase")));
            this.imagePersonal13.imageChange = ((System.Drawing.Image)(resources.GetObject("imagePersonal13.imageChange")));
            this.imagePersonal13.ImageClickDown = null;
            this.imagePersonal13.labelMy = null;
            this.imagePersonal13.Location = new System.Drawing.Point(35, 292);
            this.imagePersonal13.MyImageBack = null;
            this.imagePersonal13.Name = "imagePersonal13";
            this.imagePersonal13.Size = new System.Drawing.Size(63, 60);
            this.imagePersonal13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePersonal13.TabIndex = 21;
            this.imagePersonal13.TabStop = false;
            this.imagePersonal13.Visible = false;
            // 
            // ButtonForSort
            // 
            this.ButtonForSort.BackColor = System.Drawing.Color.Transparent;
            this.ButtonForSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonForSort.Image = global::CourseProject.Properties.Resources.МенюСортировокБезФона;
            this.ButtonForSort.imageBase = global::CourseProject.Properties.Resources.МенюСортировокБезФона;
            this.ButtonForSort.imageChange = global::CourseProject.Properties.Resources.МенюСортировокСФоном;
            this.ButtonForSort.ImageClickDown = global::CourseProject.Properties.Resources.МенюСортировокСФономПоНажатию;
            this.ButtonForSort.labelMy = this.LabelForSort;
            this.ButtonForSort.Location = new System.Drawing.Point(25, 241);
            this.ButtonForSort.MyImageBack = this.BackForButtonSort;
            this.ButtonForSort.Name = "ButtonForSort";
            this.ButtonForSort.Size = new System.Drawing.Size(62, 25);
            this.ButtonForSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonForSort.TabIndex = 20;
            this.ButtonForSort.TabStop = false;
            this.ButtonForSort.Click += new System.EventHandler(this.ButtonForSort_Click);
            // 
            // LabelForSort
            // 
            this.LabelForSort.AutoSize = true;
            this.LabelForSort.BackColor = System.Drawing.Color.Transparent;
            this.LabelForSort.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.LabelForSort.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.LabelForSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelForSort.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForSort.imagePersonal = this.ButtonForSort;
            this.LabelForSort.Location = new System.Drawing.Point(97, 232);
            this.LabelForSort.Name = "LabelForSort";
            this.LabelForSort.Size = new System.Drawing.Size(203, 36);
            this.LabelForSort.TabIndex = 19;
            this.LabelForSort.Text = "Сортировки";
            this.LabelForSort.Click += new System.EventHandler(this.LabelForSort_Click);
            // 
            // BackForButtonSort
            // 
            this.BackForButtonSort.BackColor = System.Drawing.Color.Transparent;
            this.BackForButtonSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackForButtonSort.Image = ((System.Drawing.Image)(resources.GetObject("BackForButtonSort.Image")));
            this.BackForButtonSort.imageBase = ((System.Drawing.Image)(resources.GetObject("BackForButtonSort.imageBase")));
            this.BackForButtonSort.imageChange = ((System.Drawing.Image)(resources.GetObject("BackForButtonSort.imageChange")));
            this.BackForButtonSort.ImageClickDown = null;
            this.BackForButtonSort.labelMy = null;
            this.BackForButtonSort.Location = new System.Drawing.Point(15, 218);
            this.BackForButtonSort.MyImageBack = null;
            this.BackForButtonSort.Name = "BackForButtonSort";
            this.BackForButtonSort.Size = new System.Drawing.Size(81, 69);
            this.BackForButtonSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackForButtonSort.TabIndex = 18;
            this.BackForButtonSort.TabStop = false;
            this.BackForButtonSort.Visible = false;
            // 
            // ButtonChangeStudent
            // 
            this.ButtonChangeStudent.BackColor = System.Drawing.Color.Transparent;
            this.ButtonChangeStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChangeStudent.Image = global::CourseProject.Properties.Resources.ИзменитьБезФон;
            this.ButtonChangeStudent.imageBase = global::CourseProject.Properties.Resources.ИзменитьБезФон1;
            this.ButtonChangeStudent.imageChange = global::CourseProject.Properties.Resources.ИзменитьСФон;
            this.ButtonChangeStudent.ImageClickDown = global::CourseProject.Properties.Resources.ИзменитьСФонПонажатию;
            this.ButtonChangeStudent.labelMy = this.LabelChange;
            this.ButtonChangeStudent.Location = new System.Drawing.Point(29, 147);
            this.ButtonChangeStudent.MyImageBack = this.BackButtonChange;
            this.ButtonChangeStudent.Name = "ButtonChangeStudent";
            this.ButtonChangeStudent.Size = new System.Drawing.Size(55, 54);
            this.ButtonChangeStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonChangeStudent.TabIndex = 17;
            this.ButtonChangeStudent.TabStop = false;
            this.ButtonChangeStudent.Click += new System.EventHandler(this.ButtonChangeStudent_Click);
            // 
            // LabelChange
            // 
            this.LabelChange.AutoSize = true;
            this.LabelChange.BackColor = System.Drawing.Color.Transparent;
            this.LabelChange.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.LabelChange.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.LabelChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelChange.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelChange.imagePersonal = this.ButtonChangeStudent;
            this.LabelChange.Location = new System.Drawing.Point(97, 158);
            this.LabelChange.Name = "LabelChange";
            this.LabelChange.Size = new System.Drawing.Size(167, 36);
            this.LabelChange.TabIndex = 16;
            this.LabelChange.Text = "Изменить";
            this.LabelChange.Click += new System.EventHandler(this.LabelChange_Click);
            // 
            // BackButtonChange
            // 
            this.BackButtonChange.BackColor = System.Drawing.Color.Transparent;
            this.BackButtonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButtonChange.Image = ((System.Drawing.Image)(resources.GetObject("BackButtonChange.Image")));
            this.BackButtonChange.imageBase = ((System.Drawing.Image)(resources.GetObject("BackButtonChange.imageBase")));
            this.BackButtonChange.imageChange = ((System.Drawing.Image)(resources.GetObject("BackButtonChange.imageChange")));
            this.BackButtonChange.ImageClickDown = null;
            this.BackButtonChange.labelMy = null;
            this.BackButtonChange.Location = new System.Drawing.Point(15, 140);
            this.BackButtonChange.MyImageBack = null;
            this.BackButtonChange.Name = "BackButtonChange";
            this.BackButtonChange.Size = new System.Drawing.Size(81, 69);
            this.BackButtonChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButtonChange.TabIndex = 15;
            this.BackButtonChange.TabStop = false;
            this.BackButtonChange.Visible = false;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.Image = global::CourseProject.Properties.Resources.НоваяСоздатьБезФона;
            this.ButtonAdd.imageBase = global::CourseProject.Properties.Resources.НоваяСоздатьБезФона;
            this.ButtonAdd.imageChange = global::CourseProject.Properties.Resources.НоваяСоздатьСФоном;
            this.ButtonAdd.ImageClickDown = global::CourseProject.Properties.Resources.НоваяСоздатьСФономПонажатию;
            this.ButtonAdd.labelMy = this.LabelAdd;
            this.ButtonAdd.Location = new System.Drawing.Point(29, 75);
            this.ButtonAdd.MyImageBack = this.BackGroundButtonAdd;
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(55, 54);
            this.ButtonAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonAdd.TabIndex = 12;
            this.ButtonAdd.TabStop = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // LabelAdd
            // 
            this.LabelAdd.AutoSize = true;
            this.LabelAdd.BackColor = System.Drawing.Color.Transparent;
            this.LabelAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.LabelAdd.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.LabelAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelAdd.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAdd.imagePersonal = this.ButtonAdd;
            this.LabelAdd.Location = new System.Drawing.Point(98, 85);
            this.LabelAdd.Name = "LabelAdd";
            this.LabelAdd.Size = new System.Drawing.Size(165, 36);
            this.LabelAdd.TabIndex = 11;
            this.LabelAdd.Text = "Добавить";
            this.LabelAdd.Click += new System.EventHandler(this.LabelAdd_Click);
            // 
            // BackGroundButtonAdd
            // 
            this.BackGroundButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.BackGroundButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackGroundButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("BackGroundButtonAdd.Image")));
            this.BackGroundButtonAdd.imageBase = ((System.Drawing.Image)(resources.GetObject("BackGroundButtonAdd.imageBase")));
            this.BackGroundButtonAdd.imageChange = ((System.Drawing.Image)(resources.GetObject("BackGroundButtonAdd.imageChange")));
            this.BackGroundButtonAdd.ImageClickDown = null;
            this.BackGroundButtonAdd.labelMy = null;
            this.BackGroundButtonAdd.Location = new System.Drawing.Point(15, 68);
            this.BackGroundButtonAdd.MyImageBack = null;
            this.BackGroundButtonAdd.Name = "BackGroundButtonAdd";
            this.BackGroundButtonAdd.Size = new System.Drawing.Size(81, 69);
            this.BackGroundButtonAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackGroundButtonAdd.TabIndex = 13;
            this.BackGroundButtonAdd.TabStop = false;
            this.BackGroundButtonAdd.Visible = false;
            // 
            // TittleMenu
            // 
            this.TittleMenu.AutoSize = true;
            this.TittleMenu.BackColor = System.Drawing.Color.Transparent;
            this.TittleMenu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(156)))), ((int)(((byte)(107)))));
            this.TittleMenu.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.TittleMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TittleMenu.Font = new System.Drawing.Font("Impact", 46F);
            this.TittleMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(156)))), ((int)(((byte)(107)))));
            this.TittleMenu.imagePersonal = null;
            this.TittleMenu.Location = new System.Drawing.Point(71, -3);
            this.TittleMenu.Name = "TittleMenu";
            this.TittleMenu.Size = new System.Drawing.Size(189, 75);
            this.TittleMenu.TabIndex = 0;
            this.TittleMenu.Text = "Меню";
            this.TittleMenu.Click += new System.EventHandler(this.TittleMenu_Click);
            // 
            // ButtonStartSortSurnames
            // 
            this.ButtonStartSortSurnames.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonStartSortSurnames.BackColor = System.Drawing.Color.Transparent;
            this.ButtonStartSortSurnames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStartSortSurnames.Image = global::CourseProject.Properties.Resources.ПускБезФона1;
            this.ButtonStartSortSurnames.imageBase = global::CourseProject.Properties.Resources.ПускБезФона1;
            this.ButtonStartSortSurnames.imageChange = global::CourseProject.Properties.Resources.ПускСФоном;
            this.ButtonStartSortSurnames.ImageClickDown = global::CourseProject.Properties.Resources.ПускПоНажатию;
            this.ButtonStartSortSurnames.labelMy = null;
            this.ButtonStartSortSurnames.Location = new System.Drawing.Point(692, 185);
            this.ButtonStartSortSurnames.MyImageBack = null;
            this.ButtonStartSortSurnames.Name = "ButtonStartSortSurnames";
            this.ButtonStartSortSurnames.Size = new System.Drawing.Size(75, 59);
            this.ButtonStartSortSurnames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonStartSortSurnames.TabIndex = 94;
            this.ButtonStartSortSurnames.TabStop = false;
            this.ButtonStartSortSurnames.Visible = false;
            this.ButtonStartSortSurnames.Click += new System.EventHandler(this.ButtonStartSortSurnames_Click);
            // 
            // LabelForSurnames
            // 
            this.LabelForSurnames.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelForSurnames.AutoSize = true;
            this.LabelForSurnames.BackColor = System.Drawing.Color.Transparent;
            this.LabelForSurnames.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForSurnames.Location = new System.Drawing.Point(775, 186);
            this.LabelForSurnames.Name = "LabelForSurnames";
            this.LabelForSurnames.Size = new System.Drawing.Size(108, 26);
            this.LabelForSurnames.TabIndex = 93;
            this.LabelForSurnames.Text = "Фамилия";
            this.LabelForSurnames.Visible = false;
            // 
            // TextBoxSurnames
            // 
            this.TextBoxSurnames.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSurnames.Location = new System.Drawing.Point(773, 212);
            this.TextBoxSurnames.Name = "TextBoxSurnames";
            this.TextBoxSurnames.Size = new System.Drawing.Size(167, 32);
            this.TextBoxSurnames.TabIndex = 92;
            this.TextBoxSurnames.Visible = false;
            this.TextBoxSurnames.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TextBoxSurnames.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            // 
            // ButtonGenerateReports
            // 
            this.ButtonGenerateReports.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonGenerateReports.BackColor = System.Drawing.Color.Transparent;
            this.ButtonGenerateReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGenerateReports.Image = global::CourseProject.Properties.Resources.ОтчетУспеваемостиБезФона;
            this.ButtonGenerateReports.imageBase = global::CourseProject.Properties.Resources.ОтчетУспеваемостиБезФона;
            this.ButtonGenerateReports.imageChange = global::CourseProject.Properties.Resources.ОтчетУспеваемостиСФоном;
            this.ButtonGenerateReports.ImageClickDown = global::CourseProject.Properties.Resources.ОтчетУспеваемостиСФономПоНажатию;
            this.ButtonGenerateReports.labelMy = null;
            this.ButtonGenerateReports.Location = new System.Drawing.Point(3, 185);
            this.ButtonGenerateReports.MyImageBack = null;
            this.ButtonGenerateReports.Name = "ButtonGenerateReports";
            this.ButtonGenerateReports.Size = new System.Drawing.Size(75, 59);
            this.ButtonGenerateReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonGenerateReports.TabIndex = 91;
            this.ButtonGenerateReports.TabStop = false;
            this.ButtonGenerateReports.Click += new System.EventHandler(this.ButtonGenerateReports_Click);
            // 
            // CheckBoxPassedForTwo
            // 
            this.CheckBoxPassedForTwo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CheckBoxPassedForTwo.AutoSize = true;
            this.CheckBoxPassedForTwo.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxPassedForTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxPassedForTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxPassedForTwo.Location = new System.Drawing.Point(228, 215);
            this.CheckBoxPassedForTwo.Name = "CheckBoxPassedForTwo";
            this.CheckBoxPassedForTwo.Size = new System.Drawing.Size(155, 30);
            this.CheckBoxPassedForTwo.TabIndex = 90;
            this.CheckBoxPassedForTwo.Text = "Не сдавшие";
            this.CheckBoxPassedForTwo.UseVisualStyleBackColor = false;
            this.CheckBoxPassedForTwo.CheckedChanged += new System.EventHandler(this.CheckBoxPassedForTwo_CheckedChanged);
            // 
            // CheckBoxPassedForThree
            // 
            this.CheckBoxPassedForThree.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CheckBoxPassedForThree.AutoSize = true;
            this.CheckBoxPassedForThree.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxPassedForThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxPassedForThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxPassedForThree.Location = new System.Drawing.Point(228, 180);
            this.CheckBoxPassedForThree.Name = "CheckBoxPassedForThree";
            this.CheckBoxPassedForThree.Size = new System.Drawing.Size(144, 30);
            this.CheckBoxPassedForThree.TabIndex = 89;
            this.CheckBoxPassedForThree.Text = "Троишники";
            this.CheckBoxPassedForThree.UseVisualStyleBackColor = false;
            this.CheckBoxPassedForThree.CheckedChanged += new System.EventHandler(this.CheckBoxPassedForThree_CheckedChanged);
            // 
            // LabelForComboBoxSortSpeciality
            // 
            this.LabelForComboBoxSortSpeciality.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelForComboBoxSortSpeciality.AutoSize = true;
            this.LabelForComboBoxSortSpeciality.BackColor = System.Drawing.Color.Transparent;
            this.LabelForComboBoxSortSpeciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForComboBoxSortSpeciality.Location = new System.Drawing.Point(596, 186);
            this.LabelForComboBoxSortSpeciality.Name = "LabelForComboBoxSortSpeciality";
            this.LabelForComboBoxSortSpeciality.Size = new System.Drawing.Size(171, 26);
            this.LabelForComboBoxSortSpeciality.TabIndex = 84;
            this.LabelForComboBoxSortSpeciality.Text = "Специальности";
            this.LabelForComboBoxSortSpeciality.Visible = false;
            // 
            // ComboBoxSpecialitySort
            // 
            this.ComboBoxSpecialitySort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBoxSpecialitySort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxSpecialitySort.FormattingEnabled = true;
            this.ComboBoxSpecialitySort.Location = new System.Drawing.Point(593, 212);
            this.ComboBoxSpecialitySort.Name = "ComboBoxSpecialitySort";
            this.ComboBoxSpecialitySort.Size = new System.Drawing.Size(199, 33);
            this.ComboBoxSpecialitySort.TabIndex = 83;
            this.ComboBoxSpecialitySort.Text = "Специальности";
            this.ComboBoxSpecialitySort.Visible = false;
            this.ComboBoxSpecialitySort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSpecialitySort_SelectedIndexChanged);
            // 
            // LabelForFacultiesSort
            // 
            this.LabelForFacultiesSort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelForFacultiesSort.AutoSize = true;
            this.LabelForFacultiesSort.BackColor = System.Drawing.Color.Transparent;
            this.LabelForFacultiesSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForFacultiesSort.Location = new System.Drawing.Point(394, 185);
            this.LabelForFacultiesSort.Name = "LabelForFacultiesSort";
            this.LabelForFacultiesSort.Size = new System.Drawing.Size(138, 26);
            this.LabelForFacultiesSort.TabIndex = 82;
            this.LabelForFacultiesSort.Text = "Факультеты";
            this.LabelForFacultiesSort.Visible = false;
            this.LabelForFacultiesSort.Click += new System.EventHandler(this.LabelForFacultiesSort_Click);
            // 
            // ComboBoxSortFaculties
            // 
            this.ComboBoxSortFaculties.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBoxSortFaculties.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxSortFaculties.FormattingEnabled = true;
            this.ComboBoxSortFaculties.Location = new System.Drawing.Point(391, 211);
            this.ComboBoxSortFaculties.Name = "ComboBoxSortFaculties";
            this.ComboBoxSortFaculties.Size = new System.Drawing.Size(199, 33);
            this.ComboBoxSortFaculties.TabIndex = 81;
            this.ComboBoxSortFaculties.Text = "Факультеты";
            this.ComboBoxSortFaculties.Visible = false;
            this.ComboBoxSortFaculties.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSortFaculties_SelectedIndexChanged);
            // 
            // ButtonDeleteObject
            // 
            this.ButtonDeleteObject.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonDeleteObject.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDeleteObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDeleteObject.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteObject.Image")));
            this.ButtonDeleteObject.imageBase = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteObject.imageBase")));
            this.ButtonDeleteObject.imageChange = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteObject.imageChange")));
            this.ButtonDeleteObject.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteObject.ImageClickDown")));
            this.ButtonDeleteObject.labelMy = null;
            this.ButtonDeleteObject.Location = new System.Drawing.Point(944, 184);
            this.ButtonDeleteObject.MyImageBack = null;
            this.ButtonDeleteObject.Name = "ButtonDeleteObject";
            this.ButtonDeleteObject.Size = new System.Drawing.Size(75, 59);
            this.ButtonDeleteObject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonDeleteObject.TabIndex = 80;
            this.ButtonDeleteObject.TabStop = false;
            this.ButtonDeleteObject.Click += new System.EventHandler(this.ButtonDeleteObject_Click);
            // 
            // ButtonFindStudent
            // 
            this.ButtonFindStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonFindStudent.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFindStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFindStudent.Image = global::CourseProject.Properties.Resources.Лупа;
            this.ButtonFindStudent.Location = new System.Drawing.Point(988, 16);
            this.ButtonFindStudent.Name = "ButtonFindStudent";
            this.ButtonFindStudent.Size = new System.Drawing.Size(27, 27);
            this.ButtonFindStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonFindStudent.TabIndex = 79;
            this.ButtonFindStudent.TabStop = false;
            this.ButtonFindStudent.Click += new System.EventHandler(this.ButtonFindStudent_Click);
            // 
            // TextBoxFindStudent
            // 
            this.TextBoxFindStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFindStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFindStudent.Location = new System.Drawing.Point(845, 16);
            this.TextBoxFindStudent.Name = "TextBoxFindStudent";
            this.TextBoxFindStudent.Size = new System.Drawing.Size(137, 29);
            this.TextBoxFindStudent.TabIndex = 78;
            this.TextBoxFindStudent.Text = "Id/Фамилия";
            this.TextBoxFindStudent.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            this.TextBoxFindStudent.Leave += new System.EventHandler(this.TextBoxFindStudent_Leave);
            // 
            // LabelAddSaveStudent
            // 
            this.LabelAddSaveStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAddSaveStudent.AutoSize = true;
            this.LabelAddSaveStudent.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddSaveStudent.BaseColor = System.Drawing.Color.Black;
            this.LabelAddSaveStudent.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.LabelAddSaveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelAddSaveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddSaveStudent.imagePersonal = this.ButtonAddSaveStudent;
            this.LabelAddSaveStudent.Location = new System.Drawing.Point(797, 612);
            this.LabelAddSaveStudent.Name = "LabelAddSaveStudent";
            this.LabelAddSaveStudent.Size = new System.Drawing.Size(236, 26);
            this.LabelAddSaveStudent.TabIndex = 76;
            this.LabelAddSaveStudent.Text = "Сохранить студента";
            // 
            // ButtonAddSaveStudent
            // 
            this.ButtonAddSaveStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddSaveStudent.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddSaveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddSaveStudent.Image = global::CourseProject.Properties.Resources.СохранитьБезФона;
            this.ButtonAddSaveStudent.imageBase = global::CourseProject.Properties.Resources.СохранитьБезФона;
            this.ButtonAddSaveStudent.imageChange = global::CourseProject.Properties.Resources.СохранитьСФоном;
            this.ButtonAddSaveStudent.ImageClickDown = global::CourseProject.Properties.Resources.СохранитьСФономПоНажатию;
            this.ButtonAddSaveStudent.labelMy = this.LabelAddSaveStudent;
            this.ButtonAddSaveStudent.Location = new System.Drawing.Point(705, 590);
            this.ButtonAddSaveStudent.MyImageBack = null;
            this.ButtonAddSaveStudent.Name = "ButtonAddSaveStudent";
            this.ButtonAddSaveStudent.Size = new System.Drawing.Size(105, 73);
            this.ButtonAddSaveStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonAddSaveStudent.TabIndex = 77;
            this.ButtonAddSaveStudent.TabStop = false;
            this.ButtonAddSaveStudent.Click += new System.EventHandler(this.ButtonAddSaveStudent_Click);
            // 
            // LabelAddSaveSemester
            // 
            this.LabelAddSaveSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAddSaveSemester.AutoSize = true;
            this.LabelAddSaveSemester.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddSaveSemester.BaseColor = System.Drawing.Color.Black;
            this.LabelAddSaveSemester.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.LabelAddSaveSemester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelAddSaveSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddSaveSemester.imagePersonal = this.ButtonAddSaveSemester;
            this.LabelAddSaveSemester.Location = new System.Drawing.Point(797, 612);
            this.LabelAddSaveSemester.Name = "LabelAddSaveSemester";
            this.LabelAddSaveSemester.Size = new System.Drawing.Size(228, 26);
            this.LabelAddSaveSemester.TabIndex = 74;
            this.LabelAddSaveSemester.Text = "Сохранить семестр";
            this.LabelAddSaveSemester.Click += new System.EventHandler(this.LabelAddSaveSemester_Click);
            // 
            // ButtonAddSaveSemester
            // 
            this.ButtonAddSaveSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddSaveSemester.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddSaveSemester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddSaveSemester.Image = global::CourseProject.Properties.Resources.СохранитьБезФона;
            this.ButtonAddSaveSemester.imageBase = global::CourseProject.Properties.Resources.СохранитьБезФона;
            this.ButtonAddSaveSemester.imageChange = global::CourseProject.Properties.Resources.СохранитьСФоном;
            this.ButtonAddSaveSemester.ImageClickDown = global::CourseProject.Properties.Resources.СохранитьСФономПоНажатию;
            this.ButtonAddSaveSemester.labelMy = this.LabelAddSaveSemester;
            this.ButtonAddSaveSemester.Location = new System.Drawing.Point(705, 590);
            this.ButtonAddSaveSemester.MyImageBack = null;
            this.ButtonAddSaveSemester.Name = "ButtonAddSaveSemester";
            this.ButtonAddSaveSemester.Size = new System.Drawing.Size(105, 73);
            this.ButtonAddSaveSemester.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonAddSaveSemester.TabIndex = 75;
            this.ButtonAddSaveSemester.TabStop = false;
            this.ButtonAddSaveSemester.Click += new System.EventHandler(this.ButtonAddSaveSemester_Click);
            // 
            // ButtonBackAddDiscipline
            // 
            this.ButtonBackAddDiscipline.BackColor = System.Drawing.Color.Transparent;
            this.ButtonBackAddDiscipline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBackAddDiscipline.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBackAddDiscipline.Image")));
            this.ButtonBackAddDiscipline.imageBase = ((System.Drawing.Image)(resources.GetObject("ButtonBackAddDiscipline.imageBase")));
            this.ButtonBackAddDiscipline.imageChange = ((System.Drawing.Image)(resources.GetObject("ButtonBackAddDiscipline.imageChange")));
            this.ButtonBackAddDiscipline.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("ButtonBackAddDiscipline.ImageClickDown")));
            this.ButtonBackAddDiscipline.labelMy = null;
            this.ButtonBackAddDiscipline.Location = new System.Drawing.Point(43, 430);
            this.ButtonBackAddDiscipline.MyImageBack = null;
            this.ButtonBackAddDiscipline.Name = "ButtonBackAddDiscipline";
            this.ButtonBackAddDiscipline.Size = new System.Drawing.Size(58, 52);
            this.ButtonBackAddDiscipline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonBackAddDiscipline.TabIndex = 67;
            this.ButtonBackAddDiscipline.TabStop = false;
            this.ButtonBackAddDiscipline.Visible = false;
            this.ButtonBackAddDiscipline.Click += new System.EventHandler(this.ButtonBackAddDiscipline_Click);
            // 
            // LabelAddSaveDiscipline
            // 
            this.LabelAddSaveDiscipline.AutoSize = true;
            this.LabelAddSaveDiscipline.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddSaveDiscipline.BaseColor = System.Drawing.Color.Black;
            this.LabelAddSaveDiscipline.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.LabelAddSaveDiscipline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelAddSaveDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddSaveDiscipline.imagePersonal = this.ButtonAddSaveDiscipline;
            this.LabelAddSaveDiscipline.Location = new System.Drawing.Point(103, 572);
            this.LabelAddSaveDiscipline.Name = "LabelAddSaveDiscipline";
            this.LabelAddSaveDiscipline.Size = new System.Drawing.Size(268, 26);
            this.LabelAddSaveDiscipline.TabIndex = 55;
            this.LabelAddSaveDiscipline.Text = "Сохранить дисциплину";
            this.LabelAddSaveDiscipline.Click += new System.EventHandler(this.LabelAddSaveDiscipline_Click);
            // 
            // ButtonAddSaveDiscipline
            // 
            this.ButtonAddSaveDiscipline.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddSaveDiscipline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddSaveDiscipline.Image = global::CourseProject.Properties.Resources.СохранитьБезФона;
            this.ButtonAddSaveDiscipline.imageBase = global::CourseProject.Properties.Resources.СохранитьБезФона;
            this.ButtonAddSaveDiscipline.imageChange = global::CourseProject.Properties.Resources.СохранитьСФоном;
            this.ButtonAddSaveDiscipline.ImageClickDown = global::CourseProject.Properties.Resources.СохранитьСФономПоНажатию;
            this.ButtonAddSaveDiscipline.labelMy = this.LabelAddSaveDiscipline;
            this.ButtonAddSaveDiscipline.Location = new System.Drawing.Point(12, 547);
            this.ButtonAddSaveDiscipline.MyImageBack = null;
            this.ButtonAddSaveDiscipline.Name = "ButtonAddSaveDiscipline";
            this.ButtonAddSaveDiscipline.Size = new System.Drawing.Size(105, 73);
            this.ButtonAddSaveDiscipline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonAddSaveDiscipline.TabIndex = 56;
            this.ButtonAddSaveDiscipline.TabStop = false;
            this.ButtonAddSaveDiscipline.Click += new System.EventHandler(this.ButtonAddSaveDiscipline_Click);
            // 
            // ButtonBackAddSemester
            // 
            this.ButtonBackAddSemester.BackColor = System.Drawing.Color.Transparent;
            this.ButtonBackAddSemester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBackAddSemester.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBackAddSemester.Image")));
            this.ButtonBackAddSemester.imageBase = ((System.Drawing.Image)(resources.GetObject("ButtonBackAddSemester.imageBase")));
            this.ButtonBackAddSemester.imageChange = ((System.Drawing.Image)(resources.GetObject("ButtonBackAddSemester.imageChange")));
            this.ButtonBackAddSemester.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("ButtonBackAddSemester.ImageClickDown")));
            this.ButtonBackAddSemester.labelMy = null;
            this.ButtonBackAddSemester.Location = new System.Drawing.Point(7, 276);
            this.ButtonBackAddSemester.MyImageBack = null;
            this.ButtonBackAddSemester.Name = "ButtonBackAddSemester";
            this.ButtonBackAddSemester.Size = new System.Drawing.Size(58, 52);
            this.ButtonBackAddSemester.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonBackAddSemester.TabIndex = 66;
            this.ButtonBackAddSemester.TabStop = false;
            this.ButtonBackAddSemester.Visible = false;
            this.ButtonBackAddSemester.Click += new System.EventHandler(this.ButtonBackAddSemester_Click);
            // 
            // LabelAddCredit
            // 
            this.LabelAddCredit.AutoSize = true;
            this.LabelAddCredit.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddCredit.BaseColor = System.Drawing.Color.Black;
            this.LabelAddCredit.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.LabelAddCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelAddCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddCredit.ForeColor = System.Drawing.Color.Black;
            this.LabelAddCredit.imagePersonal = this.ButtonAddCredit;
            this.LabelAddCredit.Location = new System.Drawing.Point(416, 343);
            this.LabelAddCredit.Name = "LabelAddCredit";
            this.LabelAddCredit.Size = new System.Drawing.Size(128, 46);
            this.LabelAddCredit.TabIndex = 64;
            this.LabelAddCredit.Text = "Зачет";
            this.LabelAddCredit.Click += new System.EventHandler(this.LabelAddCredit_Click);
            // 
            // ButtonAddCredit
            // 
            this.ButtonAddCredit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddCredit.Image = global::CourseProject.Properties.Resources.ЗачетБезФона;
            this.ButtonAddCredit.imageBase = global::CourseProject.Properties.Resources.ЗачетБезФона;
            this.ButtonAddCredit.imageChange = global::CourseProject.Properties.Resources.ЗачетСФоном;
            this.ButtonAddCredit.ImageClickDown = global::CourseProject.Properties.Resources.ЗачетСФономПоНажатию;
            this.ButtonAddCredit.labelMy = this.LabelAddCredit;
            this.ButtonAddCredit.Location = new System.Drawing.Point(323, 332);
            this.ButtonAddCredit.MyImageBack = null;
            this.ButtonAddCredit.Name = "ButtonAddCredit";
            this.ButtonAddCredit.Size = new System.Drawing.Size(105, 73);
            this.ButtonAddCredit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonAddCredit.TabIndex = 65;
            this.ButtonAddCredit.TabStop = false;
            this.ButtonAddCredit.Visible = false;
            this.ButtonAddCredit.Click += new System.EventHandler(this.ButtonAddCredit_Click);
            // 
            // LabelAddExam
            // 
            this.LabelAddExam.AutoSize = true;
            this.LabelAddExam.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddExam.BaseColor = System.Drawing.Color.Black;
            this.LabelAddExam.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.LabelAddExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelAddExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddExam.ForeColor = System.Drawing.Color.Black;
            this.LabelAddExam.imagePersonal = this.ButtonAddExam;
            this.LabelAddExam.Location = new System.Drawing.Point(132, 343);
            this.LabelAddExam.Name = "LabelAddExam";
            this.LabelAddExam.Size = new System.Drawing.Size(185, 46);
            this.LabelAddExam.TabIndex = 63;
            this.LabelAddExam.Text = "Экзамен";
            this.LabelAddExam.Click += new System.EventHandler(this.LabelAddExam_Click);
            // 
            // ButtonAddExam
            // 
            this.ButtonAddExam.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddExam.Image = global::CourseProject.Properties.Resources.ЭкзаменбезФона;
            this.ButtonAddExam.imageBase = global::CourseProject.Properties.Resources.ЭкзаменбезФона;
            this.ButtonAddExam.imageChange = global::CourseProject.Properties.Resources.ЭкзаменСФона;
            this.ButtonAddExam.ImageClickDown = global::CourseProject.Properties.Resources.ЭкзаменСФонаПонажатию;
            this.ButtonAddExam.labelMy = this.LabelAddExam;
            this.ButtonAddExam.Location = new System.Drawing.Point(43, 332);
            this.ButtonAddExam.MyImageBack = null;
            this.ButtonAddExam.Name = "ButtonAddExam";
            this.ButtonAddExam.Size = new System.Drawing.Size(105, 73);
            this.ButtonAddExam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonAddExam.TabIndex = 44;
            this.ButtonAddExam.TabStop = false;
            this.ButtonAddExam.Click += new System.EventHandler(this.ButtonAddExam_Click);
            // 
            // ButtonBackAdd
            // 
            this.ButtonBackAdd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonBackAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBackAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBackAdd.Image")));
            this.ButtonBackAdd.imageBase = ((System.Drawing.Image)(resources.GetObject("ButtonBackAdd.imageBase")));
            this.ButtonBackAdd.imageChange = ((System.Drawing.Image)(resources.GetObject("ButtonBackAdd.imageChange")));
            this.ButtonBackAdd.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("ButtonBackAdd.ImageClickDown")));
            this.ButtonBackAdd.labelMy = this.LabelBackAdd;
            this.ButtonBackAdd.Location = new System.Drawing.Point(7, 3);
            this.ButtonBackAdd.MyImageBack = null;
            this.ButtonBackAdd.Name = "ButtonBackAdd";
            this.ButtonBackAdd.Size = new System.Drawing.Size(58, 52);
            this.ButtonBackAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonBackAdd.TabIndex = 62;
            this.ButtonBackAdd.TabStop = false;
            this.ButtonBackAdd.Visible = false;
            this.ButtonBackAdd.Click += new System.EventHandler(this.ButtonBackAdd_Click);
            // 
            // LabelBackAdd
            // 
            this.LabelBackAdd.AutoSize = true;
            this.LabelBackAdd.BackColor = System.Drawing.Color.Transparent;
            this.LabelBackAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.LabelBackAdd.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.LabelBackAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelBackAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBackAdd.imagePersonal = this.ButtonBackAdd;
            this.LabelBackAdd.Location = new System.Drawing.Point(68, 9);
            this.LabelBackAdd.Name = "LabelBackAdd";
            this.LabelBackAdd.Size = new System.Drawing.Size(135, 46);
            this.LabelBackAdd.TabIndex = 61;
            this.LabelBackAdd.Text = "Назад";
            this.LabelBackAdd.Visible = false;
            this.LabelBackAdd.Click += new System.EventHandler(this.LabelBackAdd_Click);
            // 
            // LabelNameDiscipline
            // 
            this.LabelNameDiscipline.AutoSize = true;
            this.LabelNameDiscipline.BackColor = System.Drawing.Color.Transparent;
            this.LabelNameDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameDiscipline.Location = new System.Drawing.Point(43, 485);
            this.LabelNameDiscipline.Name = "LabelNameDiscipline";
            this.LabelNameDiscipline.Size = new System.Drawing.Size(213, 24);
            this.LabelNameDiscipline.TabIndex = 47;
            this.LabelNameDiscipline.Text = "Название дисциплины";
            // 
            // TextBoxNameDiscipline
            // 
            this.TextBoxNameDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNameDiscipline.Location = new System.Drawing.Point(43, 512);
            this.TextBoxNameDiscipline.Name = "TextBoxNameDiscipline";
            this.TextBoxNameDiscipline.Size = new System.Drawing.Size(213, 29);
            this.TextBoxNameDiscipline.TabIndex = 46;
            this.TextBoxNameDiscipline.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TextBoxNameDiscipline.DoubleClick += new System.EventHandler(this.TextBoxDoubleClick);
            this.TextBoxNameDiscipline.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            // 
            // LabelAddNameCurator
            // 
            this.LabelAddNameCurator.AutoSize = true;
            this.LabelAddNameCurator.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddNameCurator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddNameCurator.Location = new System.Drawing.Point(25, 206);
            this.LabelAddNameCurator.Name = "LabelAddNameCurator";
            this.LabelAddNameCurator.Size = new System.Drawing.Size(132, 24);
            this.LabelAddNameCurator.TabIndex = 34;
            this.LabelAddNameCurator.Text = "Имя куратора";
            // 
            // TextBoxAddNameCurator
            // 
            this.TextBoxAddNameCurator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddNameCurator.Location = new System.Drawing.Point(25, 233);
            this.TextBoxAddNameCurator.Name = "TextBoxAddNameCurator";
            this.TextBoxAddNameCurator.Size = new System.Drawing.Size(179, 29);
            this.TextBoxAddNameCurator.TabIndex = 33;
            this.TextBoxAddNameCurator.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TextBoxAddNameCurator.DoubleClick += new System.EventHandler(this.TextBoxDoubleClick);
            this.TextBoxAddNameCurator.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            // 
            // LabelNameStudentAdd
            // 
            this.LabelNameStudentAdd.AutoSize = true;
            this.LabelNameStudentAdd.BackColor = System.Drawing.Color.Transparent;
            this.LabelNameStudentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameStudentAdd.Location = new System.Drawing.Point(25, 122);
            this.LabelNameStudentAdd.Name = "LabelNameStudentAdd";
            this.LabelNameStudentAdd.Size = new System.Drawing.Size(134, 24);
            this.LabelNameStudentAdd.TabIndex = 24;
            this.LabelNameStudentAdd.Text = "Имя студента";
            // 
            // TextBoxAddNameStudent
            // 
            this.TextBoxAddNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddNameStudent.Location = new System.Drawing.Point(25, 149);
            this.TextBoxAddNameStudent.Name = "TextBoxAddNameStudent";
            this.TextBoxAddNameStudent.Size = new System.Drawing.Size(179, 29);
            this.TextBoxAddNameStudent.TabIndex = 23;
            this.TextBoxAddNameStudent.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TextBoxAddNameStudent.DoubleClick += new System.EventHandler(this.TextBoxDoubleClick);
            this.TextBoxAddNameStudent.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            // 
            // LabelMenu
            // 
            this.LabelMenu.AutoSize = true;
            this.LabelMenu.BackColor = System.Drawing.Color.Transparent;
            this.LabelMenu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.LabelMenu.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.LabelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMenu.imagePersonal = this.ButtonMenu;
            this.LabelMenu.Location = new System.Drawing.Point(133, 36);
            this.LabelMenu.Name = "LabelMenu";
            this.LabelMenu.Size = new System.Drawing.Size(125, 46);
            this.LabelMenu.TabIndex = 5;
            this.LabelMenu.Text = "Меню";
            this.LabelMenu.Click += new System.EventHandler(this.LabelMenu_Click);
            // 
            // ButtonMenu
            // 
            this.ButtonMenu.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMenu.Image = global::CourseProject.Properties.Resources.МенюСерое;
            this.ButtonMenu.imageBase = global::CourseProject.Properties.Resources.МенюСерое;
            this.ButtonMenu.imageChange = global::CourseProject.Properties.Resources.МенюСФоном;
            this.ButtonMenu.ImageClickDown = global::CourseProject.Properties.Resources.МенюСФономНажатое2;
            this.ButtonMenu.labelMy = this.LabelMenu;
            this.ButtonMenu.Location = new System.Drawing.Point(22, 14);
            this.ButtonMenu.MyImageBack = null;
            this.ButtonMenu.Name = "ButtonMenu";
            this.ButtonMenu.Size = new System.Drawing.Size(105, 90);
            this.ButtonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonMenu.TabIndex = 20;
            this.ButtonMenu.TabStop = false;
            this.ButtonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // OnOffButton
            // 
            this.OnOffButton.BackColor = System.Drawing.Color.Transparent;
            this.OnOffButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnOffButton.Image = global::CourseProject.Properties.Resources.OnOffCredit;
            this.OnOffButton.ImageOff = global::CourseProject.Properties.Resources.OnOffCredit;
            this.OnOffButton.ImageOn = global::CourseProject.Properties.Resources.OnOffExam;
            this.OnOffButton.Location = new System.Drawing.Point(807, 498);
            this.OnOffButton.Name = "OnOffButton";
            this.OnOffButton.Size = new System.Drawing.Size(93, 43);
            this.OnOffButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OnOffButton.TabIndex = 73;
            this.OnOffButton.TabStop = false;
            this.OnOffButton.Visible = false;
            // 
            // LabelCreditNotPassed
            // 
            this.LabelCreditNotPassed.AutoSize = true;
            this.LabelCreditNotPassed.BackColor = System.Drawing.Color.Transparent;
            this.LabelCreditNotPassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCreditNotPassed.Location = new System.Drawing.Point(902, 515);
            this.LabelCreditNotPassed.Name = "LabelCreditNotPassed";
            this.LabelCreditNotPassed.Size = new System.Drawing.Size(85, 24);
            this.LabelCreditNotPassed.TabIndex = 71;
            this.LabelCreditNotPassed.Text = "Незачет";
            this.LabelCreditNotPassed.Visible = false;
            // 
            // LabelCreditPassed
            // 
            this.LabelCreditPassed.AutoSize = true;
            this.LabelCreditPassed.BackColor = System.Drawing.Color.Transparent;
            this.LabelCreditPassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCreditPassed.Location = new System.Drawing.Point(740, 515);
            this.LabelCreditPassed.Name = "LabelCreditPassed";
            this.LabelCreditPassed.Size = new System.Drawing.Size(64, 24);
            this.LabelCreditPassed.TabIndex = 70;
            this.LabelCreditPassed.Text = "Зачет";
            this.LabelCreditPassed.Visible = false;
            // 
            // LabelTittleAddDiscipline
            // 
            this.LabelTittleAddDiscipline.AutoSize = true;
            this.LabelTittleAddDiscipline.BackColor = System.Drawing.Color.Transparent;
            this.LabelTittleAddDiscipline.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTittleAddDiscipline.Location = new System.Drawing.Point(107, 444);
            this.LabelTittleAddDiscipline.Name = "LabelTittleAddDiscipline";
            this.LabelTittleAddDiscipline.Size = new System.Drawing.Size(364, 38);
            this.LabelTittleAddDiscipline.TabIndex = 68;
            this.LabelTittleAddDiscipline.Text = "Добавление дисциплины";
            this.LabelTittleAddDiscipline.Visible = false;
            // 
            // ButtonAddDeleteDiscipline
            // 
            this.ButtonAddDeleteDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddDeleteDiscipline.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddDeleteDiscipline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddDeleteDiscipline.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAddDeleteDiscipline.Image")));
            this.ButtonAddDeleteDiscipline.imageBase = ((System.Drawing.Image)(resources.GetObject("ButtonAddDeleteDiscipline.imageBase")));
            this.ButtonAddDeleteDiscipline.imageChange = ((System.Drawing.Image)(resources.GetObject("ButtonAddDeleteDiscipline.imageChange")));
            this.ButtonAddDeleteDiscipline.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("ButtonAddDeleteDiscipline.ImageClickDown")));
            this.ButtonAddDeleteDiscipline.labelMy = null;
            this.ButtonAddDeleteDiscipline.Location = new System.Drawing.Point(844, 323);
            this.ButtonAddDeleteDiscipline.MyImageBack = null;
            this.ButtonAddDeleteDiscipline.Name = "ButtonAddDeleteDiscipline";
            this.ButtonAddDeleteDiscipline.Size = new System.Drawing.Size(75, 59);
            this.ButtonAddDeleteDiscipline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonAddDeleteDiscipline.TabIndex = 59;
            this.ButtonAddDeleteDiscipline.TabStop = false;
            this.ButtonAddDeleteDiscipline.Click += new System.EventHandler(this.ButtonAddDeleteDiscipline_Click);
            // 
            // LabelAddDisciplines
            // 
            this.LabelAddDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAddDisciplines.AutoSize = true;
            this.LabelAddDisciplines.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddDisciplines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddDisciplines.Location = new System.Drawing.Point(655, 323);
            this.LabelAddDisciplines.Name = "LabelAddDisciplines";
            this.LabelAddDisciplines.Size = new System.Drawing.Size(123, 24);
            this.LabelAddDisciplines.TabIndex = 58;
            this.LabelAddDisciplines.Text = "Дисциплины";
            // 
            // ComboBoxAddDisciplines
            // 
            this.ComboBoxAddDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxAddDisciplines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxAddDisciplines.FormattingEnabled = true;
            this.ComboBoxAddDisciplines.Location = new System.Drawing.Point(655, 350);
            this.ComboBoxAddDisciplines.Name = "ComboBoxAddDisciplines";
            this.ComboBoxAddDisciplines.Size = new System.Drawing.Size(179, 32);
            this.ComboBoxAddDisciplines.TabIndex = 57;
            this.ComboBoxAddDisciplines.Text = "Дисциплины";
            // 
            // LabelAddAssessment
            // 
            this.LabelAddAssessment.AutoSize = true;
            this.LabelAddAssessment.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddAssessment.Location = new System.Drawing.Point(761, 469);
            this.LabelAddAssessment.Name = "LabelAddAssessment";
            this.LabelAddAssessment.Size = new System.Drawing.Size(92, 24);
            this.LabelAddAssessment.TabIndex = 53;
            this.LabelAddAssessment.Text = "Оценка 1";
            this.LabelAddAssessment.Visible = false;
            // 
            // LabelAddNameTeacher
            // 
            this.LabelAddNameTeacher.AutoSize = true;
            this.LabelAddNameTeacher.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddNameTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddNameTeacher.Location = new System.Drawing.Point(499, 485);
            this.LabelAddNameTeacher.Name = "LabelAddNameTeacher";
            this.LabelAddNameTeacher.Size = new System.Drawing.Size(235, 24);
            this.LabelAddNameTeacher.TabIndex = 51;
            this.LabelAddNameTeacher.Text = "Фамилия преподавателя";
            // 
            // TextBoxAddNameTeacher
            // 
            this.TextBoxAddNameTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddNameTeacher.Location = new System.Drawing.Point(499, 512);
            this.TextBoxAddNameTeacher.Name = "TextBoxAddNameTeacher";
            this.TextBoxAddNameTeacher.Size = new System.Drawing.Size(235, 29);
            this.TextBoxAddNameTeacher.TabIndex = 50;
            this.TextBoxAddNameTeacher.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TextBoxAddNameTeacher.DoubleClick += new System.EventHandler(this.TextBoxDoubleClick);
            this.TextBoxAddNameTeacher.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            // 
            // LabelCountHoursAdd
            // 
            this.LabelCountHoursAdd.AutoSize = true;
            this.LabelCountHoursAdd.BackColor = System.Drawing.Color.Transparent;
            this.LabelCountHoursAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCountHoursAdd.Location = new System.Drawing.Point(271, 485);
            this.LabelCountHoursAdd.Name = "LabelCountHoursAdd";
            this.LabelCountHoursAdd.Size = new System.Drawing.Size(128, 24);
            this.LabelCountHoursAdd.TabIndex = 49;
            this.LabelCountHoursAdd.Text = "Кол-во часов";
            // 
            // TextBoxAddCountHours
            // 
            this.TextBoxAddCountHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddCountHours.Location = new System.Drawing.Point(271, 512);
            this.TextBoxAddCountHours.Name = "TextBoxAddCountHours";
            this.TextBoxAddCountHours.Size = new System.Drawing.Size(213, 29);
            this.TextBoxAddCountHours.TabIndex = 48;
            this.TextBoxAddCountHours.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TextBoxAddCountHours.DoubleClick += new System.EventHandler(this.TextBoxDoubleClick);
            this.TextBoxAddCountHours.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            // 
            // LabelAddSemesters
            // 
            this.LabelAddSemesters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAddSemesters.AutoSize = true;
            this.LabelAddSemesters.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddSemesters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddSemesters.Location = new System.Drawing.Point(632, 203);
            this.LabelAddSemesters.Name = "LabelAddSemesters";
            this.LabelAddSemesters.Size = new System.Drawing.Size(102, 24);
            this.LabelAddSemesters.TabIndex = 40;
            this.LabelAddSemesters.Text = "Семестры";
            // 
            // ComboBoxAddSemesters
            // 
            this.ComboBoxAddSemesters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxAddSemesters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxAddSemesters.FormattingEnabled = true;
            this.ComboBoxAddSemesters.Location = new System.Drawing.Point(628, 230);
            this.ComboBoxAddSemesters.Name = "ComboBoxAddSemesters";
            this.ComboBoxAddSemesters.Size = new System.Drawing.Size(182, 32);
            this.ComboBoxAddSemesters.TabIndex = 39;
            this.ComboBoxAddSemesters.Text = "Семестры";
            // 
            // LabelAddPatronymicCurator
            // 
            this.LabelAddPatronymicCurator.AutoSize = true;
            this.LabelAddPatronymicCurator.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddPatronymicCurator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddPatronymicCurator.Location = new System.Drawing.Point(395, 203);
            this.LabelAddPatronymicCurator.Name = "LabelAddPatronymicCurator";
            this.LabelAddPatronymicCurator.Size = new System.Drawing.Size(184, 24);
            this.LabelAddPatronymicCurator.TabIndex = 38;
            this.LabelAddPatronymicCurator.Text = "Отчество куратора";
            // 
            // TextBoxAddPatronymicCurator
            // 
            this.TextBoxAddPatronymicCurator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddPatronymicCurator.Location = new System.Drawing.Point(395, 233);
            this.TextBoxAddPatronymicCurator.Name = "TextBoxAddPatronymicCurator";
            this.TextBoxAddPatronymicCurator.Size = new System.Drawing.Size(179, 29);
            this.TextBoxAddPatronymicCurator.TabIndex = 37;
            this.TextBoxAddPatronymicCurator.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TextBoxAddPatronymicCurator.DoubleClick += new System.EventHandler(this.TextBoxDoubleClick);
            this.TextBoxAddPatronymicCurator.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            // 
            // LabelAddSurnameCurator
            // 
            this.LabelAddSurnameCurator.AutoSize = true;
            this.LabelAddSurnameCurator.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddSurnameCurator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddSurnameCurator.Location = new System.Drawing.Point(210, 203);
            this.LabelAddSurnameCurator.Name = "LabelAddSurnameCurator";
            this.LabelAddSurnameCurator.Size = new System.Drawing.Size(177, 24);
            this.LabelAddSurnameCurator.TabIndex = 36;
            this.LabelAddSurnameCurator.Text = "Фамилия куратора";
            // 
            // TextBoxAddSurnameCurator
            // 
            this.TextBoxAddSurnameCurator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddSurnameCurator.Location = new System.Drawing.Point(210, 233);
            this.TextBoxAddSurnameCurator.Name = "TextBoxAddSurnameCurator";
            this.TextBoxAddSurnameCurator.Size = new System.Drawing.Size(179, 29);
            this.TextBoxAddSurnameCurator.TabIndex = 35;
            this.TextBoxAddSurnameCurator.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TextBoxAddSurnameCurator.DoubleClick += new System.EventHandler(this.TextBoxDoubleClick);
            this.TextBoxAddSurnameCurator.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            // 
            // LabelAddSpecialty
            // 
            this.LabelAddSpecialty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAddSpecialty.AutoSize = true;
            this.LabelAddSpecialty.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddSpecialty.Location = new System.Drawing.Point(812, 122);
            this.LabelAddSpecialty.Name = "LabelAddSpecialty";
            this.LabelAddSpecialty.Size = new System.Drawing.Size(151, 24);
            this.LabelAddSpecialty.TabIndex = 32;
            this.LabelAddSpecialty.Text = "Специальность";
            // 
            // ComboBoxAddSpecialty
            // 
            this.ComboBoxAddSpecialty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxAddSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxAddSpecialty.FormattingEnabled = true;
            this.ComboBoxAddSpecialty.Location = new System.Drawing.Point(816, 146);
            this.ComboBoxAddSpecialty.Name = "ComboBoxAddSpecialty";
            this.ComboBoxAddSpecialty.Size = new System.Drawing.Size(199, 32);
            this.ComboBoxAddSpecialty.TabIndex = 31;
            this.ComboBoxAddSpecialty.Text = "Специальности";
            // 
            // LabelAddFaculty
            // 
            this.LabelAddFaculty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAddFaculty.AutoSize = true;
            this.LabelAddFaculty.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddFaculty.Location = new System.Drawing.Point(632, 119);
            this.LabelAddFaculty.Name = "LabelAddFaculty";
            this.LabelAddFaculty.Size = new System.Drawing.Size(106, 24);
            this.LabelAddFaculty.TabIndex = 30;
            this.LabelAddFaculty.Text = "Факультет";
            // 
            // ComboBoxAddFaculty
            // 
            this.ComboBoxAddFaculty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxAddFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxAddFaculty.FormattingEnabled = true;
            this.ComboBoxAddFaculty.Location = new System.Drawing.Point(628, 146);
            this.ComboBoxAddFaculty.Name = "ComboBoxAddFaculty";
            this.ComboBoxAddFaculty.Size = new System.Drawing.Size(182, 32);
            this.ComboBoxAddFaculty.TabIndex = 29;
            this.ComboBoxAddFaculty.Text = "Факультеты";
            this.ComboBoxAddFaculty.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAddFaculty_SelectedIndexChanged);
            // 
            // LabelAddPatronymicStudent
            // 
            this.LabelAddPatronymicStudent.AutoSize = true;
            this.LabelAddPatronymicStudent.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddPatronymicStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddPatronymicStudent.Location = new System.Drawing.Point(395, 119);
            this.LabelAddPatronymicStudent.Name = "LabelAddPatronymicStudent";
            this.LabelAddPatronymicStudent.Size = new System.Drawing.Size(186, 24);
            this.LabelAddPatronymicStudent.TabIndex = 28;
            this.LabelAddPatronymicStudent.Text = "Отчество студента";
            // 
            // TextBoxAddPatronymicStudent
            // 
            this.TextBoxAddPatronymicStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddPatronymicStudent.Location = new System.Drawing.Point(395, 149);
            this.TextBoxAddPatronymicStudent.Name = "TextBoxAddPatronymicStudent";
            this.TextBoxAddPatronymicStudent.Size = new System.Drawing.Size(179, 29);
            this.TextBoxAddPatronymicStudent.TabIndex = 27;
            this.TextBoxAddPatronymicStudent.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TextBoxAddPatronymicStudent.DoubleClick += new System.EventHandler(this.TextBoxDoubleClick);
            this.TextBoxAddPatronymicStudent.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            // 
            // LabelAddSurnameStudent
            // 
            this.LabelAddSurnameStudent.AutoSize = true;
            this.LabelAddSurnameStudent.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddSurnameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddSurnameStudent.Location = new System.Drawing.Point(210, 119);
            this.LabelAddSurnameStudent.Name = "LabelAddSurnameStudent";
            this.LabelAddSurnameStudent.Size = new System.Drawing.Size(179, 24);
            this.LabelAddSurnameStudent.TabIndex = 26;
            this.LabelAddSurnameStudent.Text = "Фамилия студента";
            // 
            // TextBoxAddSurnameStudent
            // 
            this.TextBoxAddSurnameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddSurnameStudent.Location = new System.Drawing.Point(210, 149);
            this.TextBoxAddSurnameStudent.Name = "TextBoxAddSurnameStudent";
            this.TextBoxAddSurnameStudent.Size = new System.Drawing.Size(179, 29);
            this.TextBoxAddSurnameStudent.TabIndex = 25;
            this.TextBoxAddSurnameStudent.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TextBoxAddSurnameStudent.DoubleClick += new System.EventHandler(this.TextBoxDoubleClick);
            this.TextBoxAddSurnameStudent.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            // 
            // ButtonDeleteSemester
            // 
            this.ButtonDeleteSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeleteSemester.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDeleteSemester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDeleteSemester.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteSemester.Image")));
            this.ButtonDeleteSemester.imageBase = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteSemester.imageBase")));
            this.ButtonDeleteSemester.imageChange = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteSemester.imageChange")));
            this.ButtonDeleteSemester.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteSemester.ImageClickDown")));
            this.ButtonDeleteSemester.labelMy = null;
            this.ButtonDeleteSemester.Location = new System.Drawing.Point(925, 215);
            this.ButtonDeleteSemester.MyImageBack = null;
            this.ButtonDeleteSemester.Name = "ButtonDeleteSemester";
            this.ButtonDeleteSemester.Size = new System.Drawing.Size(75, 59);
            this.ButtonDeleteSemester.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonDeleteSemester.TabIndex = 42;
            this.ButtonDeleteSemester.TabStop = false;
            this.ButtonDeleteSemester.Click += new System.EventHandler(this.ButtonDeleteSemester_Click);
            // 
            // ButtonAddSemester
            // 
            this.ButtonAddSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddSemester.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddSemester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddSemester.Image = global::CourseProject.Properties.Resources.ДобавитьСеместрБезФона;
            this.ButtonAddSemester.imageBase = global::CourseProject.Properties.Resources.ДобавитьСеместрБезФона;
            this.ButtonAddSemester.imageChange = global::CourseProject.Properties.Resources.ДобавитьСеместрСФоном;
            this.ButtonAddSemester.ImageClickDown = global::CourseProject.Properties.Resources.ДобавитьСеместрСФономКрашенныелисты;
            this.ButtonAddSemester.labelMy = null;
            this.ButtonAddSemester.Location = new System.Drawing.Point(844, 215);
            this.ButtonAddSemester.MyImageBack = null;
            this.ButtonAddSemester.Name = "ButtonAddSemester";
            this.ButtonAddSemester.Size = new System.Drawing.Size(75, 59);
            this.ButtonAddSemester.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonAddSemester.TabIndex = 41;
            this.ButtonAddSemester.TabStop = false;
            this.ButtonAddSemester.Click += new System.EventHandler(this.ButtonAddSemester_Click);
            // 
            // LabelAddNumberSemester
            // 
            this.LabelAddNumberSemester.AutoSize = true;
            this.LabelAddNumberSemester.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddNumberSemester.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddNumberSemester.Location = new System.Drawing.Point(64, 290);
            this.LabelAddNumberSemester.Name = "LabelAddNumberSemester";
            this.LabelAddNumberSemester.Size = new System.Drawing.Size(361, 38);
            this.LabelAddNumberSemester.TabIndex = 43;
            this.LabelAddNumberSemester.Text = "Заполение семестра № 1";
            this.LabelAddNumberSemester.Visible = false;
            // 
            // LabelTittleAdd
            // 
            this.LabelTittleAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelTittleAdd.AutoSize = true;
            this.LabelTittleAdd.BackColor = System.Drawing.Color.Transparent;
            this.LabelTittleAdd.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTittleAdd.Location = new System.Drawing.Point(240, 43);
            this.LabelTittleAdd.Name = "LabelTittleAdd";
            this.LabelTittleAdd.Size = new System.Drawing.Size(672, 61);
            this.LabelTittleAdd.TabIndex = 21;
            this.LabelTittleAdd.Text = "Добавление нового студента";
            this.LabelTittleAdd.Visible = false;
            // 
            // TrackBarAssessmentAdd
            // 
            this.TrackBarAssessmentAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.TrackBarAssessmentAdd.Location = new System.Drawing.Point(765, 496);
            this.TrackBarAssessmentAdd.Maximum = 5;
            this.TrackBarAssessmentAdd.Minimum = 1;
            this.TrackBarAssessmentAdd.Name = "TrackBarAssessmentAdd";
            this.TrackBarAssessmentAdd.Size = new System.Drawing.Size(217, 45);
            this.TrackBarAssessmentAdd.TabIndex = 52;
            this.TrackBarAssessmentAdd.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackBarAssessmentAdd.Value = 1;
            this.TrackBarAssessmentAdd.Visible = false;
            this.TrackBarAssessmentAdd.Scroll += new System.EventHandler(this.TrackBarAssessmentAdd_Scroll);
            // 
            // CheckBoxPassedForFour
            // 
            this.CheckBoxPassedForFour.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CheckBoxPassedForFour.AutoSize = true;
            this.CheckBoxPassedForFour.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxPassedForFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxPassedForFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxPassedForFour.Location = new System.Drawing.Point(85, 216);
            this.CheckBoxPassedForFour.Name = "CheckBoxPassedForFour";
            this.CheckBoxPassedForFour.Size = new System.Drawing.Size(149, 30);
            this.CheckBoxPassedForFour.TabIndex = 88;
            this.CheckBoxPassedForFour.Text = "Хорошисты";
            this.CheckBoxPassedForFour.UseVisualStyleBackColor = false;
            this.CheckBoxPassedForFour.CheckedChanged += new System.EventHandler(this.CheckBoxPassedForFour_CheckedChanged);
            // 
            // CheckBoxPassedForFive
            // 
            this.CheckBoxPassedForFive.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CheckBoxPassedForFive.AutoSize = true;
            this.CheckBoxPassedForFive.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxPassedForFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxPassedForFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxPassedForFive.Location = new System.Drawing.Point(85, 180);
            this.CheckBoxPassedForFive.Name = "CheckBoxPassedForFive";
            this.CheckBoxPassedForFive.Size = new System.Drawing.Size(142, 30);
            this.CheckBoxPassedForFive.TabIndex = 87;
            this.CheckBoxPassedForFive.Text = "Отличники";
            this.CheckBoxPassedForFive.UseVisualStyleBackColor = false;
            this.CheckBoxPassedForFive.CheckedChanged += new System.EventHandler(this.CheckBoxPassedForFive_CheckedChanged);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.NameGrid,
            this.SemestersBox,
            this.Disciplines,
            this.CountHours,
            this.NameTeacherBox,
            this.SuccessDiscipline,
            this.Faculty,
            this.Speciality,
            this.NameCurotor});
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGrid.Location = new System.Drawing.Point(0, 252);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(1027, 423);
            this.DataGrid.TabIndex = 12;
            this.DataGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataGrid_EditingControlShowing);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // NameGrid
            // 
            this.NameGrid.HeaderText = "ФИО";
            this.NameGrid.Name = "NameGrid";
            this.NameGrid.ReadOnly = true;
            // 
            // SemestersBox
            // 
            this.SemestersBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SemestersBox.HeaderText = "Семестры";
            this.SemestersBox.Name = "SemestersBox";
            this.SemestersBox.ToolTipText = "Информация о зачетной книжке";
            // 
            // Disciplines
            // 
            this.Disciplines.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Disciplines.HeaderText = "Дисциплины";
            this.Disciplines.Name = "Disciplines";
            // 
            // CountHours
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CountHours.DefaultCellStyle = dataGridViewCellStyle1;
            this.CountHours.HeaderText = "Кол-во часов дисциплины";
            this.CountHours.Name = "CountHours";
            this.CountHours.ReadOnly = true;
            // 
            // NameTeacherBox
            // 
            this.NameTeacherBox.HeaderText = "Фамилия преподавателя дисциплины";
            this.NameTeacherBox.Name = "NameTeacherBox";
            this.NameTeacherBox.ReadOnly = true;
            this.NameTeacherBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SuccessDiscipline
            // 
            this.SuccessDiscipline.HeaderText = "Оценка";
            this.SuccessDiscipline.Name = "SuccessDiscipline";
            this.SuccessDiscipline.ReadOnly = true;
            this.SuccessDiscipline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Faculty
            // 
            this.Faculty.HeaderText = "Факультет";
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            this.Faculty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Speciality
            // 
            this.Speciality.HeaderText = "Специальность";
            this.Speciality.Name = "Speciality";
            this.Speciality.ReadOnly = true;
            this.Speciality.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NameCurotor
            // 
            this.NameCurotor.HeaderText = "ФИО куратора";
            this.NameCurotor.Name = "NameCurotor";
            this.NameCurotor.ReadOnly = true;
            this.NameCurotor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PanelForChnageStudent
            // 
            this.PanelForChnageStudent.Angle = 75F;
            this.PanelForChnageStudent.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(156)))), ((int)(((byte)(107)))));
            this.PanelForChnageStudent.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.PanelForChnageStudent.Controls.Add(this.onOffWidjet1);
            this.PanelForChnageStudent.Controls.Add(this.labelMy6);
            this.PanelForChnageStudent.Controls.Add(this.labelMy1);
            this.PanelForChnageStudent.Controls.Add(this.pictureBox1);
            this.PanelForChnageStudent.Controls.Add(this.textBox1);
            this.PanelForChnageStudent.Controls.Add(this.label1);
            this.PanelForChnageStudent.Controls.Add(this.label2);
            this.PanelForChnageStudent.Controls.Add(this.label3);
            this.PanelForChnageStudent.Controls.Add(this.imagePersonal2);
            this.PanelForChnageStudent.Controls.Add(this.labelMy2);
            this.PanelForChnageStudent.Controls.Add(this.imagePersonal4);
            this.PanelForChnageStudent.Controls.Add(this.labelMy3);
            this.PanelForChnageStudent.Controls.Add(this.imagePersonal5);
            this.PanelForChnageStudent.Controls.Add(this.labelMy4);
            this.PanelForChnageStudent.Controls.Add(this.imagePersonal7);
            this.PanelForChnageStudent.Controls.Add(this.labelMy5);
            this.PanelForChnageStudent.Controls.Add(this.imagePersonal8);
            this.PanelForChnageStudent.Controls.Add(this.label4);
            this.PanelForChnageStudent.Controls.Add(this.comboBox1);
            this.PanelForChnageStudent.Controls.Add(this.imagePersonal3);
            this.PanelForChnageStudent.Controls.Add(this.label5);
            this.PanelForChnageStudent.Controls.Add(this.label6);
            this.PanelForChnageStudent.Controls.Add(this.textBox2);
            this.PanelForChnageStudent.Controls.Add(this.label7);
            this.PanelForChnageStudent.Controls.Add(this.textBox3);
            this.PanelForChnageStudent.Controls.Add(this.label8);
            this.PanelForChnageStudent.Controls.Add(this.textBox4);
            this.PanelForChnageStudent.Controls.Add(this.label9);
            this.PanelForChnageStudent.Controls.Add(this.comboBox2);
            this.PanelForChnageStudent.Controls.Add(this.label10);
            this.PanelForChnageStudent.Controls.Add(this.textBox5);
            this.PanelForChnageStudent.Controls.Add(this.label11);
            this.PanelForChnageStudent.Controls.Add(this.textBox6);
            this.PanelForChnageStudent.Controls.Add(this.label12);
            this.PanelForChnageStudent.Controls.Add(this.textBox7);
            this.PanelForChnageStudent.Controls.Add(this.label13);
            this.PanelForChnageStudent.Controls.Add(this.comboBox3);
            this.PanelForChnageStudent.Controls.Add(this.label14);
            this.PanelForChnageStudent.Controls.Add(this.comboBox4);
            this.PanelForChnageStudent.Controls.Add(this.label15);
            this.PanelForChnageStudent.Controls.Add(this.textBox8);
            this.PanelForChnageStudent.Controls.Add(this.label16);
            this.PanelForChnageStudent.Controls.Add(this.textBox9);
            this.PanelForChnageStudent.Controls.Add(this.label17);
            this.PanelForChnageStudent.Controls.Add(this.textBox10);
            this.PanelForChnageStudent.Controls.Add(this.imagePersonal9);
            this.PanelForChnageStudent.Controls.Add(this.imagePersonal10);
            this.PanelForChnageStudent.Controls.Add(this.label18);
            this.PanelForChnageStudent.Controls.Add(this.imagePersonal6);
            this.PanelForChnageStudent.Controls.Add(this.trackBar1);
            this.PanelForChnageStudent.Controls.Add(this.imagePersonal1);
            this.PanelForChnageStudent.Controls.Add(this.label19);
            this.PanelForChnageStudent.Controls.Add(this.imagePersonal11);
            this.PanelForChnageStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForChnageStudent.Location = new System.Drawing.Point(0, 0);
            this.PanelForChnageStudent.Name = "PanelForChnageStudent";
            this.PanelForChnageStudent.Size = new System.Drawing.Size(1027, 675);
            this.PanelForChnageStudent.TabIndex = 81;
            this.PanelForChnageStudent.Visible = false;
            this.PanelForChnageStudent.Resize += new System.EventHandler(this.PanelForChnageStudent_Resize);
            // 
            // onOffWidjet1
            // 
            this.onOffWidjet1.BackColor = System.Drawing.Color.Transparent;
            this.onOffWidjet1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onOffWidjet1.Image = global::CourseProject.Properties.Resources.OnOffCredit;
            this.onOffWidjet1.ImageOff = global::CourseProject.Properties.Resources.OnOffCredit;
            this.onOffWidjet1.ImageOn = global::CourseProject.Properties.Resources.OnOffExam;
            this.onOffWidjet1.Location = new System.Drawing.Point(800, 503);
            this.onOffWidjet1.Name = "onOffWidjet1";
            this.onOffWidjet1.Size = new System.Drawing.Size(93, 43);
            this.onOffWidjet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.onOffWidjet1.TabIndex = 126;
            this.onOffWidjet1.TabStop = false;
            this.onOffWidjet1.Visible = false;
            // 
            // labelMy6
            // 
            this.labelMy6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMy6.AutoSize = true;
            this.labelMy6.BackColor = System.Drawing.Color.Transparent;
            this.labelMy6.BaseColor = System.Drawing.Color.Black;
            this.labelMy6.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.labelMy6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMy6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMy6.imagePersonal = this.imagePersonal11;
            this.labelMy6.Location = new System.Drawing.Point(791, 617);
            this.labelMy6.Name = "labelMy6";
            this.labelMy6.Size = new System.Drawing.Size(228, 26);
            this.labelMy6.TabIndex = 131;
            this.labelMy6.Text = "Сохранить семестр";
            this.labelMy6.Visible = false;
            // 
            // imagePersonal11
            // 
            this.imagePersonal11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePersonal11.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal11.Image = ((System.Drawing.Image)(resources.GetObject("imagePersonal11.Image")));
            this.imagePersonal11.imageBase = ((System.Drawing.Image)(resources.GetObject("imagePersonal11.imageBase")));
            this.imagePersonal11.imageChange = ((System.Drawing.Image)(resources.GetObject("imagePersonal11.imageChange")));
            this.imagePersonal11.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("imagePersonal11.ImageClickDown")));
            this.imagePersonal11.labelMy = this.labelMy6;
            this.imagePersonal11.Location = new System.Drawing.Point(698, 595);
            this.imagePersonal11.MyImageBack = null;
            this.imagePersonal11.Name = "imagePersonal11";
            this.imagePersonal11.Size = new System.Drawing.Size(105, 73);
            this.imagePersonal11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePersonal11.TabIndex = 132;
            this.imagePersonal11.TabStop = false;
            this.imagePersonal11.Visible = false;
            this.imagePersonal11.Click += new System.EventHandler(this.imagePersonal11_Click);
            // 
            // labelMy1
            // 
            this.labelMy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMy1.AutoSize = true;
            this.labelMy1.BackColor = System.Drawing.Color.Transparent;
            this.labelMy1.BaseColor = System.Drawing.Color.Black;
            this.labelMy1.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.labelMy1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMy1.imagePersonal = this.imagePersonal1;
            this.labelMy1.Location = new System.Drawing.Point(790, 617);
            this.labelMy1.Name = "labelMy1";
            this.labelMy1.Size = new System.Drawing.Size(236, 26);
            this.labelMy1.TabIndex = 127;
            this.labelMy1.Text = "Сохранить студента";
            // 
            // imagePersonal1
            // 
            this.imagePersonal1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePersonal1.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal1.Image = ((System.Drawing.Image)(resources.GetObject("imagePersonal1.Image")));
            this.imagePersonal1.imageBase = ((System.Drawing.Image)(resources.GetObject("imagePersonal1.imageBase")));
            this.imagePersonal1.imageChange = ((System.Drawing.Image)(resources.GetObject("imagePersonal1.imageChange")));
            this.imagePersonal1.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("imagePersonal1.ImageClickDown")));
            this.imagePersonal1.labelMy = this.labelMy1;
            this.imagePersonal1.Location = new System.Drawing.Point(698, 595);
            this.imagePersonal1.MyImageBack = null;
            this.imagePersonal1.Name = "imagePersonal1";
            this.imagePersonal1.Size = new System.Drawing.Size(105, 73);
            this.imagePersonal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePersonal1.TabIndex = 128;
            this.imagePersonal1.TabStop = false;
            this.imagePersonal1.Click += new System.EventHandler(this.imagePersonal1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CourseProject.Properties.Resources.Лупа;
            this.pictureBox1.Location = new System.Drawing.Point(981, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 130;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(838, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 29);
            this.textBox1.TabIndex = 129;
            this.textBox1.Text = "Id/Фамилия";
            this.textBox1.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            this.textBox1.Leave += new System.EventHandler(this.TextBoxFindStudent_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(895, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 125;
            this.label1.Text = "Незачет";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(733, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 124;
            this.label2.Text = "Зачет";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(100, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 38);
            this.label3.TabIndex = 123;
            this.label3.Text = "Добавление дисциплины";
            this.label3.Visible = false;
            // 
            // imagePersonal2
            // 
            this.imagePersonal2.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal2.Image = ((System.Drawing.Image)(resources.GetObject("imagePersonal2.Image")));
            this.imagePersonal2.imageBase = ((System.Drawing.Image)(resources.GetObject("imagePersonal2.imageBase")));
            this.imagePersonal2.imageChange = ((System.Drawing.Image)(resources.GetObject("imagePersonal2.imageChange")));
            this.imagePersonal2.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("imagePersonal2.ImageClickDown")));
            this.imagePersonal2.labelMy = null;
            this.imagePersonal2.Location = new System.Drawing.Point(36, 435);
            this.imagePersonal2.MyImageBack = null;
            this.imagePersonal2.Name = "imagePersonal2";
            this.imagePersonal2.Size = new System.Drawing.Size(58, 52);
            this.imagePersonal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePersonal2.TabIndex = 122;
            this.imagePersonal2.TabStop = false;
            this.imagePersonal2.Visible = false;
            this.imagePersonal2.Click += new System.EventHandler(this.imagePersonal2_Click);
            // 
            // labelMy2
            // 
            this.labelMy2.AutoSize = true;
            this.labelMy2.BackColor = System.Drawing.Color.Transparent;
            this.labelMy2.BaseColor = System.Drawing.Color.Black;
            this.labelMy2.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.labelMy2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMy2.imagePersonal = this.imagePersonal3;
            this.labelMy2.Location = new System.Drawing.Point(96, 577);
            this.labelMy2.Name = "labelMy2";
            this.labelMy2.Size = new System.Drawing.Size(268, 26);
            this.labelMy2.TabIndex = 111;
            this.labelMy2.Text = "Сохранить дисциплину";
            this.labelMy2.Visible = false;
            // 
            // imagePersonal3
            // 
            this.imagePersonal3.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal3.Image = ((System.Drawing.Image)(resources.GetObject("imagePersonal3.Image")));
            this.imagePersonal3.imageBase = ((System.Drawing.Image)(resources.GetObject("imagePersonal3.imageBase")));
            this.imagePersonal3.imageChange = ((System.Drawing.Image)(resources.GetObject("imagePersonal3.imageChange")));
            this.imagePersonal3.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("imagePersonal3.ImageClickDown")));
            this.imagePersonal3.labelMy = this.labelMy2;
            this.imagePersonal3.Location = new System.Drawing.Point(5, 552);
            this.imagePersonal3.MyImageBack = null;
            this.imagePersonal3.Name = "imagePersonal3";
            this.imagePersonal3.Size = new System.Drawing.Size(105, 73);
            this.imagePersonal3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePersonal3.TabIndex = 112;
            this.imagePersonal3.TabStop = false;
            this.imagePersonal3.Visible = false;
            this.imagePersonal3.Click += new System.EventHandler(this.imagePersonal3_Click);
            // 
            // imagePersonal4
            // 
            this.imagePersonal4.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal4.Image = ((System.Drawing.Image)(resources.GetObject("imagePersonal4.Image")));
            this.imagePersonal4.imageBase = ((System.Drawing.Image)(resources.GetObject("imagePersonal4.imageBase")));
            this.imagePersonal4.imageChange = ((System.Drawing.Image)(resources.GetObject("imagePersonal4.imageChange")));
            this.imagePersonal4.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("imagePersonal4.ImageClickDown")));
            this.imagePersonal4.labelMy = null;
            this.imagePersonal4.Location = new System.Drawing.Point(18, 279);
            this.imagePersonal4.MyImageBack = null;
            this.imagePersonal4.Name = "imagePersonal4";
            this.imagePersonal4.Size = new System.Drawing.Size(58, 52);
            this.imagePersonal4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePersonal4.TabIndex = 121;
            this.imagePersonal4.TabStop = false;
            this.imagePersonal4.Visible = false;
            this.imagePersonal4.Click += new System.EventHandler(this.imagePersonal4_Click);
            // 
            // labelMy3
            // 
            this.labelMy3.AutoSize = true;
            this.labelMy3.BackColor = System.Drawing.Color.Transparent;
            this.labelMy3.BaseColor = System.Drawing.Color.Black;
            this.labelMy3.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.labelMy3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMy3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMy3.ForeColor = System.Drawing.Color.Black;
            this.labelMy3.imagePersonal = this.imagePersonal5;
            this.labelMy3.Location = new System.Drawing.Point(409, 348);
            this.labelMy3.Name = "labelMy3";
            this.labelMy3.Size = new System.Drawing.Size(128, 46);
            this.labelMy3.TabIndex = 119;
            this.labelMy3.Text = "Зачет";
            this.labelMy3.Visible = false;
            // 
            // imagePersonal5
            // 
            this.imagePersonal5.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal5.Image = global::CourseProject.Properties.Resources.ЗачетБезФона;
            this.imagePersonal5.imageBase = global::CourseProject.Properties.Resources.ЗачетБезФона;
            this.imagePersonal5.imageChange = global::CourseProject.Properties.Resources.ЗачетСФоном;
            this.imagePersonal5.ImageClickDown = global::CourseProject.Properties.Resources.ЗачетСФономПоНажатию;
            this.imagePersonal5.labelMy = this.labelMy3;
            this.imagePersonal5.Location = new System.Drawing.Point(316, 337);
            this.imagePersonal5.MyImageBack = null;
            this.imagePersonal5.Name = "imagePersonal5";
            this.imagePersonal5.Size = new System.Drawing.Size(105, 73);
            this.imagePersonal5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePersonal5.TabIndex = 120;
            this.imagePersonal5.TabStop = false;
            this.imagePersonal5.Visible = false;
            this.imagePersonal5.Click += new System.EventHandler(this.imagePersonal5_Click);
            // 
            // labelMy4
            // 
            this.labelMy4.AutoSize = true;
            this.labelMy4.BackColor = System.Drawing.Color.Transparent;
            this.labelMy4.BaseColor = System.Drawing.Color.Black;
            this.labelMy4.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.labelMy4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMy4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMy4.ForeColor = System.Drawing.Color.Black;
            this.labelMy4.imagePersonal = this.imagePersonal6;
            this.labelMy4.Location = new System.Drawing.Point(125, 348);
            this.labelMy4.Name = "labelMy4";
            this.labelMy4.Size = new System.Drawing.Size(185, 46);
            this.labelMy4.TabIndex = 118;
            this.labelMy4.Text = "Экзамен";
            this.labelMy4.Visible = false;
            // 
            // imagePersonal6
            // 
            this.imagePersonal6.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal6.Image = global::CourseProject.Properties.Resources.ЭкзаменбезФона;
            this.imagePersonal6.imageBase = global::CourseProject.Properties.Resources.ЭкзаменбезФона;
            this.imagePersonal6.imageChange = global::CourseProject.Properties.Resources.ЭкзаменСФона;
            this.imagePersonal6.ImageClickDown = global::CourseProject.Properties.Resources.ЭкзаменСФонаПонажатию;
            this.imagePersonal6.labelMy = this.labelMy4;
            this.imagePersonal6.Location = new System.Drawing.Point(36, 337);
            this.imagePersonal6.MyImageBack = null;
            this.imagePersonal6.Name = "imagePersonal6";
            this.imagePersonal6.Size = new System.Drawing.Size(105, 73);
            this.imagePersonal6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePersonal6.TabIndex = 102;
            this.imagePersonal6.TabStop = false;
            this.imagePersonal6.Visible = false;
            this.imagePersonal6.Click += new System.EventHandler(this.imagePersonal6_Click);
            // 
            // imagePersonal7
            // 
            this.imagePersonal7.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal7.Image = ((System.Drawing.Image)(resources.GetObject("imagePersonal7.Image")));
            this.imagePersonal7.imageBase = ((System.Drawing.Image)(resources.GetObject("imagePersonal7.imageBase")));
            this.imagePersonal7.imageChange = ((System.Drawing.Image)(resources.GetObject("imagePersonal7.imageChange")));
            this.imagePersonal7.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("imagePersonal7.ImageClickDown")));
            this.imagePersonal7.labelMy = this.labelMy5;
            this.imagePersonal7.Location = new System.Drawing.Point(18, 9);
            this.imagePersonal7.MyImageBack = null;
            this.imagePersonal7.Name = "imagePersonal7";
            this.imagePersonal7.Size = new System.Drawing.Size(58, 52);
            this.imagePersonal7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePersonal7.TabIndex = 117;
            this.imagePersonal7.TabStop = false;
            this.imagePersonal7.Click += new System.EventHandler(this.imagePersonal7_Click);
            // 
            // labelMy5
            // 
            this.labelMy5.AutoSize = true;
            this.labelMy5.BackColor = System.Drawing.Color.Transparent;
            this.labelMy5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.labelMy5.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.labelMy5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMy5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMy5.imagePersonal = this.imagePersonal7;
            this.labelMy5.Location = new System.Drawing.Point(79, 15);
            this.labelMy5.Name = "labelMy5";
            this.labelMy5.Size = new System.Drawing.Size(135, 46);
            this.labelMy5.TabIndex = 116;
            this.labelMy5.Text = "Назад";
            this.labelMy5.Click += new System.EventHandler(this.labelMy5_Click);
            // 
            // imagePersonal8
            // 
            this.imagePersonal8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePersonal8.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal8.Image = ((System.Drawing.Image)(resources.GetObject("imagePersonal8.Image")));
            this.imagePersonal8.imageBase = ((System.Drawing.Image)(resources.GetObject("imagePersonal8.imageBase")));
            this.imagePersonal8.imageChange = ((System.Drawing.Image)(resources.GetObject("imagePersonal8.imageChange")));
            this.imagePersonal8.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("imagePersonal8.ImageClickDown")));
            this.imagePersonal8.labelMy = null;
            this.imagePersonal8.Location = new System.Drawing.Point(837, 328);
            this.imagePersonal8.MyImageBack = null;
            this.imagePersonal8.Name = "imagePersonal8";
            this.imagePersonal8.Size = new System.Drawing.Size(75, 59);
            this.imagePersonal8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePersonal8.TabIndex = 115;
            this.imagePersonal8.TabStop = false;
            this.imagePersonal8.Visible = false;
            this.imagePersonal8.Click += new System.EventHandler(this.imagePersonal8_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(625, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 114;
            this.label4.Text = "Дисциплины";
            this.label4.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(625, 355);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 32);
            this.comboBox1.TabIndex = 113;
            this.comboBox1.Text = "Дисциплины";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(754, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 110;
            this.label5.Text = "Оценка 1";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(492, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 24);
            this.label6.TabIndex = 108;
            this.label6.Text = "Фамилия преподавателя";
            this.label6.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(492, 517);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 29);
            this.textBox2.TabIndex = 107;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.textBox2.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(264, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 24);
            this.label7.TabIndex = 106;
            this.label7.Text = "Кол-во часов";
            this.label7.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(264, 517);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 29);
            this.textBox3.TabIndex = 105;
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.textBox3.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(36, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 24);
            this.label8.TabIndex = 104;
            this.label8.Text = "Название дисциплины";
            this.label8.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(36, 517);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(213, 29);
            this.textBox4.TabIndex = 103;
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.textBox4.Enter += new System.EventHandler(this.TextBoxFindStudent_Enter);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(625, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 98;
            this.label9.Text = "Семестры";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(621, 235);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 32);
            this.comboBox2.TabIndex = 97;
            this.comboBox2.Text = "Семестры";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(388, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 24);
            this.label10.TabIndex = 96;
            this.label10.Text = "Отчество куратора";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(388, 238);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(179, 29);
            this.textBox5.TabIndex = 95;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(203, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 24);
            this.label11.TabIndex = 94;
            this.label11.Text = "Фамилия куратора";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(203, 238);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(179, 29);
            this.textBox6.TabIndex = 93;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(18, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 24);
            this.label12.TabIndex = 92;
            this.label12.Text = "Имя куратора";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(18, 238);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(179, 29);
            this.textBox7.TabIndex = 91;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(805, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 24);
            this.label13.TabIndex = 90;
            this.label13.Text = "Специальность";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(809, 151);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(199, 32);
            this.comboBox3.TabIndex = 89;
            this.comboBox3.Text = "Специальности";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(625, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 24);
            this.label14.TabIndex = 88;
            this.label14.Text = "Факультет";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(621, 151);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(182, 32);
            this.comboBox4.TabIndex = 87;
            this.comboBox4.Text = "Факультеты";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(388, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 24);
            this.label15.TabIndex = 86;
            this.label15.Text = "Отчество студента";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(388, 154);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(179, 29);
            this.textBox8.TabIndex = 85;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(203, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(179, 24);
            this.label16.TabIndex = 84;
            this.label16.Text = "Фамилия студента";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(203, 154);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(179, 29);
            this.textBox9.TabIndex = 83;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(18, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 24);
            this.label17.TabIndex = 82;
            this.label17.Text = "Имя студента";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.Location = new System.Drawing.Point(18, 154);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(179, 29);
            this.textBox10.TabIndex = 81;
            // 
            // imagePersonal9
            // 
            this.imagePersonal9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePersonal9.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal9.Image = ((System.Drawing.Image)(resources.GetObject("imagePersonal9.Image")));
            this.imagePersonal9.imageBase = ((System.Drawing.Image)(resources.GetObject("imagePersonal9.imageBase")));
            this.imagePersonal9.imageChange = ((System.Drawing.Image)(resources.GetObject("imagePersonal9.imageChange")));
            this.imagePersonal9.ImageClickDown = ((System.Drawing.Image)(resources.GetObject("imagePersonal9.ImageClickDown")));
            this.imagePersonal9.labelMy = null;
            this.imagePersonal9.Location = new System.Drawing.Point(918, 220);
            this.imagePersonal9.MyImageBack = null;
            this.imagePersonal9.Name = "imagePersonal9";
            this.imagePersonal9.Size = new System.Drawing.Size(75, 59);
            this.imagePersonal9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePersonal9.TabIndex = 100;
            this.imagePersonal9.TabStop = false;
            this.imagePersonal9.Click += new System.EventHandler(this.imagePersonal9_Click);
            // 
            // imagePersonal10
            // 
            this.imagePersonal10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePersonal10.BackColor = System.Drawing.Color.Transparent;
            this.imagePersonal10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePersonal10.Image = global::CourseProject.Properties.Resources.ДобавитьСеместрБезФона;
            this.imagePersonal10.imageBase = global::CourseProject.Properties.Resources.ДобавитьСеместрБезФона;
            this.imagePersonal10.imageChange = global::CourseProject.Properties.Resources.ДобавитьСеместрСФоном;
            this.imagePersonal10.ImageClickDown = global::CourseProject.Properties.Resources.ДобавитьСеместрСФономКрашенныелисты;
            this.imagePersonal10.labelMy = null;
            this.imagePersonal10.Location = new System.Drawing.Point(837, 220);
            this.imagePersonal10.MyImageBack = null;
            this.imagePersonal10.Name = "imagePersonal10";
            this.imagePersonal10.Size = new System.Drawing.Size(75, 59);
            this.imagePersonal10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePersonal10.TabIndex = 99;
            this.imagePersonal10.TabStop = false;
            this.imagePersonal10.Click += new System.EventHandler(this.imagePersonal10_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(75, 293);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(361, 38);
            this.label18.TabIndex = 101;
            this.label18.Text = "Заполение семестра № 1";
            this.label18.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar1.Location = new System.Drawing.Point(758, 501);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(217, 45);
            this.trackBar1.TabIndex = 109;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 1;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(305, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(485, 61);
            this.label19.TabIndex = 80;
            this.label19.Text = "Изменение студента";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 675);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.PanelForChnageStudent);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1043, 714);
            this.Name = "FormMain";
            this.Text = "База Данных";
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSaveBaseData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackForSaveDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonForSortSameSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackForSortSameSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSuccessLearning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonForSortSpeciality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBackSpeciality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSortFaculties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonForSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackForButtonSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonChangeStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundButtonAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonStartSortSurnames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonGenerateReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDeleteObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonFindStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddSaveStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddSaveSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBackAddDiscipline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddSaveDiscipline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBackAddSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBackAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnOffButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddDeleteDiscipline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDeleteSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAssessmentAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.PanelForChnageStudent.ResumeLayout(false);
            this.PanelForChnageStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onOffWidjet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonal10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private List<Control> ControlsForAdd = new List<Control>();
        private List<Control> ControlsForAddSemester = new List<Control>();
        private List<Control> ControlsGenericDiscipline = new List<Control>();
        private List<Control> ControlsForChangeSemester = new List<Control>();
        private List<Control> ControlsForChangeDiscipline = new List<Control>();
        private List<Control> ControlsForUnderMenuSort = new List<Control>();
        private List<Control> ControlsForSort = new List<Control>();
        private Lab__8.GradientPanel MainPanel;
        private System.Windows.Forms.DataGridView DataGrid;
        private Lab__8.GradientPanel PanelMenu;
        private BindingSource studentBindingSource;
        private LabelMy TittleMenu;
        private ImagePersonal ButtonMenu;
        private LabelMy LabelMenu;
        private ImagePersonal ButtonAdd;
        private LabelMy LabelAdd;
        private ImagePersonal BackGroundButtonAdd;
        private Label LabelTittleAdd;
        private Label LabelAddPatronymicStudent;
        private TextBox TextBoxAddPatronymicStudent;
        private Label LabelAddSurnameStudent;
        private TextBox TextBoxAddSurnameStudent;
        private Label LabelNameStudentAdd;
        private TextBox TextBoxAddNameStudent;
        private Label LabelAddSpecialty;
        private ComboBox ComboBoxAddSpecialty;
        private Label LabelAddFaculty;
        private ComboBox ComboBoxAddFaculty;
        private Label LabelAddPatronymicCurator;
        private TextBox TextBoxAddPatronymicCurator;
        private Label LabelAddSurnameCurator;
        private TextBox TextBoxAddSurnameCurator;
        private Label LabelAddNameCurator;
        private TextBox TextBoxAddNameCurator;
        private Label LabelAddSemesters;
        private ComboBox ComboBoxAddSemesters;
        private ImagePersonal ButtonAddSemester;
        private ImagePersonal ButtonDeleteSemester;
        private Label LabelAddNumberSemester;
        private ImagePersonal ButtonAddExam;
        private Label LabelAddNameTeacher;
        private TextBox TextBoxAddNameTeacher;
        private Label LabelCountHoursAdd;
        private TextBox TextBoxAddCountHours;
        private Label LabelNameDiscipline;
        private TextBox TextBoxNameDiscipline;
        private Label LabelAddAssessment;
        private TrackBar TrackBarAssessmentAdd;
        private ImagePersonal ButtonAddSaveDiscipline;
        private LabelMy LabelAddSaveDiscipline;
        private ImagePersonal ButtonAddDeleteDiscipline;
        private Label LabelAddDisciplines;
        private ComboBox ComboBoxAddDisciplines;
        private ImagePersonal ButtonBackAdd;
        private LabelMy LabelBackAdd;
        private LabelMy LabelAddExam;
        private LabelMy LabelAddCredit;
        private ImagePersonal ButtonAddCredit;
        private ImagePersonal ButtonBackAddSemester;
        private Label LabelTittleAddDiscipline;
        private ImagePersonal ButtonBackAddDiscipline;
        private Label LabelCreditNotPassed;
        private Label LabelCreditPassed;
        private OnOffWidjet OnOffButton;
        private ImagePersonal ButtonAddSaveSemester;
        private LabelMy LabelAddSaveSemester;
        private TextBox TextBoxFindStudent;
        private PictureBox ButtonFindStudent;
        private ImagePersonal ButtonChangeStudent;
        private LabelMy LabelChange;
        private ImagePersonal BackButtonChange;
        private ImagePersonal ButtonDeleteObject;
        private LabelMy LabelAddSaveStudent;
        private ImagePersonal ButtonAddSaveStudent;
        private Lab__8.GradientPanel PanelForChnageStudent;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private LabelMy labelMy1;
        private ImagePersonal imagePersonal1;
        private OnOffWidjet onOffWidjet1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ImagePersonal imagePersonal2;
        private LabelMy labelMy2;
        private ImagePersonal imagePersonal3;
        private ImagePersonal imagePersonal4;
        private LabelMy labelMy3;
        private ImagePersonal imagePersonal5;
        private LabelMy labelMy4;
        private ImagePersonal imagePersonal6;
        private ImagePersonal imagePersonal7;
        private LabelMy labelMy5;
        private ImagePersonal imagePersonal8;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private ComboBox comboBox2;
        private Label label10;
        private TextBox textBox5;
        private Label label11;
        private TextBox textBox6;
        private Label label12;
        private TextBox textBox7;
        private Label label13;
        private ComboBox comboBox3;
        private Label label14;
        private ComboBox comboBox4;
        private Label label15;
        private TextBox textBox8;
        private Label label16;
        private TextBox textBox9;
        private Label label17;
        private TextBox textBox10;
        private ImagePersonal imagePersonal9;
        private ImagePersonal imagePersonal10;
        private Label label18;
        private TrackBar trackBar1;
        private Label label19;
        private LabelMy labelMy6;
        private ImagePersonal imagePersonal11;
        private ImagePersonal ButtonForSort;
        private LabelMy LabelForSort;
        private ImagePersonal BackForButtonSort;
        private ImagePersonal ButtonSortFaculties;
        private LabelMy LabelForFacultySort;
        private ImagePersonal imagePersonal13;
        private ImagePersonal imagePersonal19;
        private LabelMy labelMy10;
        private ImagePersonal imagePersonal20;
        private ImagePersonal ButtonForSortSameSurname;
        private LabelMy LabelForSortSameSurname;
        private ImagePersonal BackForSortSameSurname;
        private ImagePersonal ButtonSuccessLearning;
        private LabelMy LabelSuccessLearning;
        private ImagePersonal imagePersonal16;
        private ImagePersonal ButtonForSortSpeciality;
        private LabelMy LabelForButtonSortSpiciality;
        private ImagePersonal ButtonBackSpeciality;
        private Label LabelForFacultiesSort;
        private ComboBox ComboBoxSortFaculties;
        private Label LabelForComboBoxSortSpeciality;
        private ComboBox ComboBoxSpecialitySort;
        private CheckBox CheckBoxPassedForFive;
        private CheckBox CheckBoxPassedForTwo;
        private CheckBox CheckBoxPassedForThree;
        private CheckBox CheckBoxPassedForFour;
        private ImagePersonal ButtonGenerateReports;
        private ImagePersonal ButtonSaveBaseData;
        private LabelMy LabelSaveBaseData;
        private ImagePersonal BackForSaveDataBase;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn NameGrid;
        private DataGridViewComboBoxColumn SemestersBox;
        private DataGridViewComboBoxColumn Disciplines;
        private DataGridViewTextBoxColumn CountHours;
        private DataGridViewTextBoxColumn NameTeacherBox;
        private DataGridViewTextBoxColumn SuccessDiscipline;
        private DataGridViewTextBoxColumn Faculty;
        private DataGridViewTextBoxColumn Speciality;
        private DataGridViewTextBoxColumn NameCurotor;
        private Label LabelForSurnames;
        private TextBox TextBoxSurnames;
        private ContextMenuStrip contextMenuStrip1;
        private ImagePersonal ButtonStartSortSurnames;
    }
}

