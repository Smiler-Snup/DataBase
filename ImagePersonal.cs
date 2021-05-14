using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    class ImagePersonal : PictureBox
    {
        public LabelMy labelMy { get; set; }
        public Image imageBase { get; set; }
        public Image imageChange { get; set; }
        public Image ImageClickDown { get; set; }
        public ImagePersonal MyImageBack { get; set; }
        private bool change = false;
        private bool ChangeDown = false;
        public ImagePersonal() : base()
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            MouseEnter += new EventHandler(EnterMouseLabel);
            MouseLeave += new EventHandler(MouseLeaveEvent);
            MouseDown += new MouseEventHandler(MouseDownEvent);
            MouseUp += new MouseEventHandler(MouseUpEvent);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            if(imageBase==null || imageChange==null)
            {
                imageBase = this.Image;
                imageChange = this.Image;
            }
        }
        private void EnterMouseLabel(object sender, EventArgs e)
        {
            if (labelMy != null)
            {
                labelMy.ForeColor = labelMy.ChangeColor;
            }
            if (MyImageBack != null)
            {
                MyImageBack.Show();
            }
            this.Image = imageChange;
        }
        private void MouseLeaveEvent(object sender, EventArgs e)
        {
            if (labelMy != null)
            {
                labelMy.ForeColor = labelMy.BaseColor;
            }
            if (MyImageBack != null)
            {
                MyImageBack.Hide();
            }
            this.Image = imageBase;
            change = !change;
        }
        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            if (!ChangeDown && ImageClickDown!=null)
            {
                this.Image = ImageClickDown;
                ChangeDown = !ChangeDown;
            }
        }
        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            if (ChangeDown && ImageClickDown != null)
            {
                this.Image = imageChange;
                ChangeDown = !ChangeDown;
            }
        }
    }
}
