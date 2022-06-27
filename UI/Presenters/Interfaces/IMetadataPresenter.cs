using DomainModel;
using UI.Views.Interfaces;

namespace UI.Presenters.Interfaces
{
    public interface IMetadataPresenter
    {
        void SetMetadataValuesInView(Signal signal);
        void OnCloseMetadataViewEventRaised();
        IMetadataView GetMetadataView();
    }
}
