using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Form1Presenter
    {
        public Form1Presenter(IForm1View view)
        {
            _view = view;
            view.CheckboxRemoveDocumentAfter.Checked = false;
            view.NumericUpDownArchivePeriod.Enabled = false;
            view.CheckboxRemoveDocumentAfter.CheckedChanged += CheckboxRemoveDocumentAfter_CheckedChanged;     
            view.OkCancelFormController.OkButtonClicked += OkButtonClicked;
        }

        void CheckboxRemoveDocumentAfter_CheckedChanged(object sender, EventArgs e)
        {
            _view.NumericUpDownArchivePeriod.Enabled = _view.CheckboxRemoveDocumentAfter.Checked;
        }

        private IForm1View _view;

        private void OkButtonClicked(Object sender, EventArgs e)
        {
            if (_view.CheckboxRemoveDocumentAfter.Checked && _view.NumericUpDownArchivePeriod.Value < 0)
            {
                _view.UserCommunicator.ShowError("Wartość nie może być mniejsza niż 0!");
                return;
            }
            _view.OkCancelFormController.CloseWithOkResult();
        }
    }
}
