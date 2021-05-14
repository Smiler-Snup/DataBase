using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace Lab__8
{
    class GradientPanel: Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        public float Angle { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(this.ClientRectangle.X, this.ClientRectangle.Y, this.ClientRectangle.Width+1, this.ClientRectangle.Height+ 1);
            LinearGradientBrush lgb = new LinearGradientBrush(rectangle, this.ColorTop, this.ColorBottom, Angle);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
