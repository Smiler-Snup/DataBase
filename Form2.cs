using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    /// <summary>
    /// Форма с приветствием 
    /// </summary>
    public partial class Form2 : Form
    {
        private int timer = 25;
        public Form2()
        {
            InitializeComponent();
            Rectangle screenSize = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            this.Location = new Point(screenSize.Width/6, screenSize.Height/6);
        }
        /// <summary>
        /// Счетчик отсчитывает до нуля и закрывает форму
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;
            label5.Text = "Закрытие окна через " + timer.ToString()+" . . .";
            if (timer == 0)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Закрывает форму
        /// </summary>
        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Закрывает форму
        /// </summary>
        private void LabelFinish_Click(object sender, EventArgs e)
        {
            ButtonFinish_Click(sender,e);
        }
    }
}
