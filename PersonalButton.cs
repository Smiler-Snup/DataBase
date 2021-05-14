using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace CourseProject
{
    class PersonalButton
    {
        public Label label { get;}
        public PictureBox pictureBox { get;}
        public PersonalButton(Label label, PictureBox pictureBox)
        {
            this.label=label;
            this.pictureBox=pictureBox;
        }
    }
}
