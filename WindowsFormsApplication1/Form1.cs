using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Common.Controls.Views;
using WindowsFormsApplication1.Common.MVP;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form, IForm1View
    {
        public Form1()
        {
            InitializeComponent();
            CheckboxRemoveDocumentAfter = new CheckBoxView(chbRemoveAfter);
            OkCancelFormController = new OkCancelFormController(btnOK, btnCancel);
            UserCommunicator = new UserCommunicator(this);
            NumericUpDownArchivePeriod = new NumericEditView(numArchivePeriod);
        }

        public ICheckedControlView CheckboxRemoveDocumentAfter { get; private set; }

        public INumericEditView NumericUpDownArchivePeriod { get; private set; }

        public IOkCancelForm OkCancelFormController { get; private set; }

        public IUserCommunicator UserCommunicator { get; private set; }
    }
}
