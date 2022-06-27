using UI.Views.Interfaces;

namespace UI.Presenters.Interfaces
{
    public interface IMainPresenter
    {

        IMainView GetMainView();
        void OnOpenFileEventRaised();
        void OnShowMetadataEventRaised();
        void OnShowRightChannelEventRaised();
    }
}
