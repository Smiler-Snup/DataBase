using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CourseProject
{
    class OnOffWidjet:PictureBox
    {
        public Image ImageOn { get; set; }
        public Image ImageOff { get; set; }
        public bool ChoiceLeft { get; private set; }
        public OnOffWidjet()
        {
            ChoiceLeft = true;
            this.Click += new EventHandler(MyClick);
        }
        public void MyClick(object sender, EventArgs e)
        {
            if(ChoiceLeft)
            {
                this.Image = ImageOn;
            }
            else
            {
                this.Image = ImageOff;
            }
            ChoiceLeft = !ChoiceLeft;
        }
    }
}
