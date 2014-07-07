using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WindowsFormsApplication1.Common.MVP;
using WindowsFormsApplication1.Common.Controls.Views;

namespace WindowsFormsApplication1.Tests
{
    [TestClass]
    public class Form1Presenter_BehaviorTest
    {
        private Mock<ICheckedControlView> _mCheckboxRemoveDocumentAfter;
        private Mock<IForm1View> _mView;
        private Mock<IOkCancelForm> _mOkCancelForm;
        private Mock<IUserCommunicator> _mUserCommunicator;
        private Mock<INumericEditView> _mNumericUpDownArchivePeriod;
        private Form1Presenter _presenter;

        [TestInitialize]
        public void Setup()
        {
            _mView = new Mock<IForm1View>();
            _mCheckboxRemoveDocumentAfter = new Mock<ICheckedControlView>();
            _mView.Setup(v => v.CheckboxRemoveDocumentAfter).Returns(_mCheckboxRemoveDocumentAfter.Object);
            _mNumericUpDownArchivePeriod = new Mock<INumericEditView>();
            _mView.Setup(v => v.NumericUpDownArchivePeriod).Returns(_mNumericUpDownArchivePeriod.Object);
            _mView.Setup(v => v.OkCancelFormController).Returns(new Mock<IOkCancelForm>().Object);
            _mUserCommunicator = new Mock<IUserCommunicator>();
            _mView.Setup(v => v.UserCommunicator).Returns(_mUserCommunicator.Object);
            _mOkCancelForm = new Mock<IOkCancelForm>();
            _mView.Setup(v => v.OkCancelFormController).Returns(_mOkCancelForm.Object);

            /* Czy muszę to robić dla każdego stuba? */
            _mCheckboxRemoveDocumentAfter.SetupAllProperties();
            _mNumericUpDownArchivePeriod.SetupAllProperties();

            _presenter = new Form1Presenter(_mView.Object);
        }

        [TestMethod]
        public void CheckboxChecked_Always_ShouldEnableNumEditControl()
        {
            _mCheckboxRemoveDocumentAfter.Object.Checked = true;

            _mCheckboxRemoveDocumentAfter.Raise(chb => chb.CheckedChanged += null, EventArgs.Empty);

            Assert.AreEqual(true, _mView.Object.NumericUpDownArchivePeriod.Enabled);
        }

        [TestMethod]
        public void CheckboxUnchecked_Always_ShouldDisableNumEditControl()
        {
            _mCheckboxRemoveDocumentAfter.Object.Checked = false;

            _mCheckboxRemoveDocumentAfter.Raise(chb => chb.CheckedChanged += null, EventArgs.Empty);

            Assert.AreEqual(false, _mView.Object.NumericUpDownArchivePeriod.Enabled);
        }
    }
}
