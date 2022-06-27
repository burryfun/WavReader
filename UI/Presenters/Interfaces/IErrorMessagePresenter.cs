
namespace UI.Presenters.Interfaces
{
    public interface IErrorMessagePresenter
    {
        void ShowErrorMessage(string message);
        void OnCloseErrorMessageViewEventRaised();
    }
}
