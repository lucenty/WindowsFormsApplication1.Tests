using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Common.MVP;
using WindowsFormsApplication1.Common.Controls.Views;

namespace WindowsFormsApplication1
{
    public interface IForm1View
    {
        ICheckedControlView CheckboxRemoveDocumentAfter { get; }

        INumericEditView NumericUpDownArchivePeriod { get; }

        IOkCancelForm OkCancelFormController { get; }

        IUserCommunicator UserCommunicator { get; }
    }
}
