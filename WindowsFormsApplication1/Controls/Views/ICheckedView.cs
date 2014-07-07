using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Common.Controls.Views
{
    public interface ICheckedView
    {
        Boolean Checked { get; set; }

        event EventHandler CheckedChanged;
    }
}
