using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Common.Controls.Views
{
    public class NumericEditView : INumericEditView, IControlView
    {
        public NumericEditView(NumericUpDown num)
        {
            _num = num;
        }

        private readonly NumericUpDown _num;

        public Decimal Value
        {
            get
            {
                return _num.Value;
            }
            set
            {
                _num.Value = value;
            }
        }

        public bool Visible
        {
            get
            {
                return _num.Visible;
            }
            set
            {
                _num.Visible = value;
            }
        }

        public bool Enabled
        {
            get
            {
                return _num.Enabled;
            }
            set
            {
                _num.Enabled = value;
            }
        }
    }
}
