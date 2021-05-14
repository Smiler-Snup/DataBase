using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public delegate void valchng(object sender, EventArgs e);
    public class MyDataGridViewComboBoxCell : DataGridViewComboBoxCell
    {
        public event valchng ValueChanged;

        protected override bool SetValue(int rowIndex, object value)
        {

            if (ValueChanged != null && rowIndex != -1)
            {

                base.SetValue(rowIndex, value);
                ValueChanged(this, new EventArgs());
                return true;

            }
            return base.SetValue(rowIndex, value);

        }

        protected override object GetValue(int rowIndex)
        {
            return base.GetValue(rowIndex);
        }
    }
}
