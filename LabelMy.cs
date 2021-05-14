using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    class LabelMy:Label
    {
        public ImagePersonal imagePersonal { get; set; }
        public Color BaseColor { get; set; }
        public Color ChangeColor { get; set; }
        public LabelMy()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            //this.ForeColor = Color.FromArgb(37, 43, 49);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            MouseEnter += new EventHandler(MouseEnterEvent);
            MouseLeave += new EventHandler(MouseLeaveEvent);
            MouseDown += new MouseEventHandler(MouseDownEvent);
            MouseUp += new MouseEventHandler(MouseUpEvent);
            if (BaseColor==null)
            BaseColor = Color.FromArgb(this.ForeColor.R, this.ForeColor.G, this.ForeColor.B);
            if(ChangeColor==null)
            {
                ChangeColor= Color.FromArgb(193, 200, 199); 
            }
        }
        private void MouseEnterEvent(object sender, EventArgs e)
        {
            this.ForeColor = ChangeColor;
            if (this.imagePersonal != null)
            {
                this.imagePersonal.Image = this.imagePersonal.imageChange;
                if(imagePersonal.MyImageBack != null)
                {
                    imagePersonal.MyImageBack.Show();
                }
            }
        }
        private void MouseLeaveEvent(object sender, EventArgs e)
        {
            this.ForeColor = BaseColor;
            if (this.imagePersonal != null)
            {
                this.imagePersonal.Image = this.imagePersonal.imageBase;
                if (imagePersonal.MyImageBack != null)
                {
                    imagePersonal.MyImageBack.Hide();
                }
            }
        }
        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            if (this.imagePersonal != null && this.imagePersonal.ImageClickDown!=null)
            {
                this.imagePersonal.Image = this.imagePersonal.ImageClickDown;
            }
        }
        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            if (this.imagePersonal != null && this.imagePersonal.ImageClickDown != null)
            {
                this.imagePersonal.Image = this.imagePersonal.imageChange;
            }
        }
    }
}
