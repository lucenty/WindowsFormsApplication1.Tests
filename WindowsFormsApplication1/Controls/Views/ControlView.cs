using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Common.Controls.Views
{
    /// <summary>
    /// Widok standardowej kontrolki.
    /// </summary>
    public class ControlView : IControlView, ITextEditable
    {
        /// <summary>
        /// Tworzy widok standardowej kontrolki.
        /// </summary>
        /// <param name="ctrl">Kontrolka.</param>
        public ControlView(Control ctrl)
        {
            _ctrl = ctrl;
        }

        private readonly Control _ctrl;

        public bool Visible 
        {
            get { return _ctrl.Visible; }
            set { _ctrl.Visible = value; }
        }

        public String Text
        {
            get { return _ctrl.Text; }
            set { _ctrl.Text = value; }
        }

        public Boolean Enabled
        {
            get { return _ctrl.Enabled; }
            set { _ctrl.Enabled = value; }
        }
    }
}
