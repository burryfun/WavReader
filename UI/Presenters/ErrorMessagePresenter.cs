using UI.Presenters.Interfaces;
using UI.Views.Interfaces;

namespace UI.Presenters
{
    public class ErrorMessagePresenter : IErrorMessagePresenter
    {
        IErrorMessageView _errorMessageView;

        public ErrorMessagePresenter(IErrorMessageView errorMessageView)
        {
            _errorMessageView = errorMessageView;

            _errorMessageView.CloseErrorMessageViewEventRaised += () => OnCloseErrorMessageViewEventRaised();
        }

        public void OnCloseErrorMessageViewEventRaised()
        {
            _errorMessageView.CloseErrorMessageView();
        }

        public void ShowErrorMessage(string message)
        {
            _errorMessageView.ShowErrorMessageView(message);
        }
    }
}
