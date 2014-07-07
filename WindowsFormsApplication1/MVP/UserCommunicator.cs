using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Common.Controls;

namespace WindowsFormsApplication1.Common.MVP
{
    /// <summary>
    /// Implementuje IUserCommunicator dla podanego okna.
    /// </summary>
    public class UserCommunicator : IUserCommunicator
    {
        public UserCommunicator(Control ctrl)
        {
            _ctrl = ctrl;
        }

        private readonly Control _ctrl;

        public void ShowError(String errorMessage)
        {
            MessageBox.Show(_ctrl, errorMessage, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInformation(String messageText)
        {
            MessageBox.Show(_ctrl, messageText, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowWarning(String messageText)
        {
            MessageBox.Show(_ctrl, messageText, "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void SetWaitCursor()
        {
            _ctrl.Cursor = Cursors.WaitCursor;
        }

        public void SetDefaultCursor()
        {
            _ctrl.Cursor = Cursors.Default;
        }
    }
}
