using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1.Common.Controls.Views;
using WindowsFormsApplication1.Common.MVP;
using Moq;

namespace WindowsFormsApplication1.Tests
{
    [TestClass]
    public class Form1Presenter_ValidationTest
    {
        private const string STR_ValueShouldntBeLessThan0 = "Wartość nie może być mniejsza niż 0!";
        private Mock<IForm1View> _mView;
        private Mock<IOkCancelForm> _mOkCancelForm;
        private Mock<IUserCommunicator> _mUserCommunicator;
        private Mock<INumericEditView> _mNumericUpDownArchivePeriod;
        private Form1Presenter _presenter;

        [TestInitialize]
        public void Setup()
        {
            _mView = new Mock<IForm1View>();

            /* Tutaj widać ile muszę się napisać po to, by podczas uruchamiania testu nie dostawać NullReferenceException w prezenterze.
             * Muszę tworzyć stuby dla tych właściwości widoku, z których korzysta prezenter w konstruktorze i ewentualnie innych
             * członkach klasy, które są wywoływane podczas testu.
             * To jest tylko próbka testu, interfejs często bywa bardziej złożony, więc Setupów byłoby więcej.
             */
            Mock<ICheckedControlView> mCheckboxRemoveDocumentAfter = new Mock<ICheckedControlView>();
            _mView.Setup(v => v.CheckboxRemoveDocumentAfter).Returns(mCheckboxRemoveDocumentAfter.Object);
            mCheckboxRemoveDocumentAfter.Setup(chb => chb.Checked).Returns(true);
            _mNumericUpDownArchivePeriod = new Mock<INumericEditView>();
            _mView.Setup(v => v.NumericUpDownArchivePeriod).Returns(_mNumericUpDownArchivePeriod.Object);
            _mView.Setup(v => v.OkCancelFormController).Returns(new Mock<IOkCancelForm>().Object);
            _mUserCommunicator = new Mock<IUserCommunicator>();
            _mView.Setup(v => v.UserCommunicator).Returns(_mUserCommunicator.Object);
            _mOkCancelForm = new Mock<IOkCancelForm>();
            _mView.Setup(v => v.OkCancelFormController).Returns(_mOkCancelForm.Object);

            _presenter = new Form1Presenter(_mView.Object);
        }

        [TestMethod]
        public void OkClicked_NegativeNumber_ShowsMessageAndDeniesClosing()
        {
            _mNumericUpDownArchivePeriod.Setup(num => num.Value).Returns(-5);

            _mOkCancelForm.Raise(ok => ok.OkButtonClicked += null, new EventArgs());

            _mUserCommunicator.Verify(uc => uc.ShowError(STR_ValueShouldntBeLessThan0), Times.Once);
            _mOkCancelForm.Verify(ok => ok.CloseWithOkResult(), Times.Never);
        }

        [TestMethod]
        public void OkClicked_PositiveNumber_ShowsMessageAndCloses()
        {
            _mNumericUpDownArchivePeriod.Setup(num => num.Value).Returns(5);

            _mOkCancelForm.Raise(ok => ok.OkButtonClicked += null, new EventArgs());

            _mUserCommunicator.Verify(uc => uc.ShowError(STR_ValueShouldntBeLessThan0), Times.Never);
            _mOkCancelForm.Verify(ok => ok.CloseWithOkResult(), Times.Once);
        }
    }
}
