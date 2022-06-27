using DomainModel;
using UI.Presenters.Interfaces;
using UI.Views.Interfaces;

namespace UI
{
    public class MetadataPresenter : IMetadataPresenter
    {
        IMetadataView _metadataView;
        Signal _signal;
        public MetadataPresenter(IMetadataView metadataView)
        {
            _metadataView = metadataView;

            _metadataView.CloseMetadataViewEventRaised += () => OnCloseMetadataViewEventRaised();
        }

        public void SetMetadataValuesInView(Signal signal)
        {

            _signal = signal;
            _metadataView.SetMetadataValues(
                                            _signal.Metadata._ChunkID,
                                            _signal.Metadata._ChunkSize,
                                            _signal.Metadata._Format,
                                            _signal.Metadata._Subchunk1ID,
                                            _signal.Metadata._Subchunk1Size,
                                            _signal.Metadata._AudioFormat,
                                            _signal.Metadata._NumChannels,
                                            _signal.Metadata._SampleRate,
                                            _signal.Metadata._ByteRate,
                                            _signal.Metadata._BlockAlign,
                                            _signal.Metadata._BitsPerSample,
                                            _signal.Metadata._Subchunk2ID,
                                            _signal.Metadata._Subchunk2Size
                                           );
        }

        public IMetadataView GetMetadataView()
        {
            return _metadataView;
        }

        public void OnCloseMetadataViewEventRaised()
        {
            _metadataView.CloseMetadataView();
        }
    }
}
