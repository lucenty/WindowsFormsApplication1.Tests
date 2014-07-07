using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Common.Controls.Views
{
    public class CheckBoxView : ControlView, ICheckedControlView
    {
        public CheckBoxView(CheckBox chb)
            : base(chb)
        {
            _chb = chb;
        }

        public event EventHandler CheckedChanged
        {
            add { _chb.CheckedChanged += value; }
            remove { _chb.CheckedChanged -= value; }
        }

        private readonly CheckBox _chb;

        public bool Checked
        {
            get { return _chb.Checked; }
            set { _chb.Checked = value; }
        }
    }
}
