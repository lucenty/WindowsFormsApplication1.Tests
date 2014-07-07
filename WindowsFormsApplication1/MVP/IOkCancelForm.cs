using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Common.MVP
{
    /// <summary>
    /// Interfejs dla okien z przyciskami OK i Anuluj.
    /// </summary>
    public interface IOkCancelForm
    {
        /// <summary>
        /// Delegat obsługi kliknięcia na przycisk OK.
        /// </summary>
        event EventHandler OkButtonClicked;

        /// <summary>
        /// Delegat obsługi kliknięcia na przycisk Anuluj.
        /// </summary>
        event EventHandler CancelButtonClicked;

        /// <summary>
        /// Zamyka okno, zwracając DialogResult.Cancel.
        /// </summary>
        void CloseWithCancelResult();

        /// <summary>
        /// Zamyka okno, zwracając DialogResult.OK.
        /// </summary>
        void CloseWithOkResult();

        /// <summary>
        /// Wyłącza traktowanie przycisku anulowania jako przycisku anulowania :)
        /// Po wykonaniu tej metody naciśnięcie Esc nie pociągnie akcji związanej z przyciskiem Anuluj.
        /// </summary>
        void DisableCancelButtonAction();
    }
}
