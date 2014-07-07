using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Common.MVP
{
    /// <summary>
    /// Interfejs do prezentowania użytkownikowi komunikatów.
    /// </summary>
    public interface IUserCommunicator
    {
        /// <summary>
        /// Wyświetla komunikat o błędzie.
        /// </summary>
        /// <param name="errorMessage">Komunikat o błędzie do wyświetlenia.</param>
        void ShowError(String errorMessage);

        /// <summary>
        /// Wyświetla komunikat ze zwykłą informacją.
        /// </summary>
        /// <param name="messageText">Treść komunikatu.</param>
        void ShowInformation(String messageText);

        /// <summary>
        /// Wywietla komunikat z ostrzeżeniem (MBox.Attension).
        /// </summary>
        /// <param name="messageText">Komunikat do wyświetlenia.</param>
        void ShowWarning(String messageText);

        void SetWaitCursor();

        void SetDefaultCursor();
    }
}
