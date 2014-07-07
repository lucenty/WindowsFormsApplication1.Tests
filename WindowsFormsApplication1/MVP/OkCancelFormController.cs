using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Common.Controls;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Common.MVP
{
    /// <summary>
    /// Implementuje IOkCancelForm dla podanych zwykłych przycisków.
    /// </summary>
    public class OkCancelFormController : IOkCancelForm
    {
        public OkCancelFormController(Button btnOk, Button btnCancel)
        {
            _form = btnCancel.FindForm();
            _form.AcceptButton = _btnOk = btnOk;
            _form.CancelButton = _btnCancel = btnCancel;
        }

        private readonly Form _form;

        private readonly Button _btnOk;

        private readonly Button _btnCancel;

        public event EventHandler OkButtonClicked
        {
            remove { _btnOk.Click -= value; }
            add { _btnOk.Click += value; }
        }

        public event EventHandler CancelButtonClicked
        {
            remove { _btnCancel.Click -= value; }
            add { _btnCancel.Click += value; }
        }

        public void CloseWithCancelResult()
        {
            _form.DialogResult = DialogResult.Cancel;
            _form.Close();
        }

        public void CloseWithOkResult()
        {
            _form.DialogResult = DialogResult.OK;
            _form.Close();
        }

        public void DisableCancelButtonAction()
        {
            _form.CancelButton = null;
        }
    }
}
