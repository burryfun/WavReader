using DomainModel;
using FFTWrapper;
using UI.Presenters.Interfaces;
using UI.Views.Interfaces;


namespace UI.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        Signal _signal;
        IMainView _view;
        IMetadataPresenter _metadataPresenter;
        IRightChannelView _rightChannelView;

        public MainPresenter(IMainView view, IMetadataPresenter metadataPresenter, IRightChannelView rightChannelView)
        {
            _view = view;
            _metadataPresenter = metadataPresenter;
            _rightChannelView = rightChannelView;

            _view.ShowMetadataEventRaised += () => OnShowMetadataEventRaised();
            _view.OpenFileEventRaised += () => OnOpenFileEventRaised();
            _view.ShowRightChannelViewEventRaised += () => OnShowRightChannelEventRaised();
        }

        public IMainView GetMainView()
        {
            return _view;
        }

        public void OnOpenFileEventRaised()
        {

            string filename = _view.GetOpenFileName();

            if (filename != null)
            {
                if (filename.IndexOf("wav") == -1)
                {
                    _view.ShowWarningMessage("Invalid file format");
                    return;
                }

                _signal = new Signal(filename);
                _view.ShowFilePath(filename);

                if (_signal.Metadata._NumChannels == 1)
                {
                    _view.SetSignalTitleLabel("Mono Signal");
                    _view.SetVisibleRightChannelButton(false);
                }
                if (_signal.Metadata._NumChannels == 2)
                {
                    _view.SetSignalTitleLabel("Stereo Signal");
                    _view.SetVisibleRightChannelButton(true);
                }

                _view.DrawSignal(_signal.RawData._LeftChannelData, _signal.Metadata._SampleRate);

                FFT fft = new FFT(_signal.RawData._LeftChannelData);
                _view.DrawSpectrum(fft.Spectrum, _signal.Metadata._SampleRate);
            }
        }

        public void OnShowMetadataEventRaised()
        {
            if (_signal == null)
            {
                _view.ShowWarningMessage("Please, load file");
            }
            else
            {
                _metadataPresenter.SetMetadataValuesInView(_signal);
                _metadataPresenter.GetMetadataView().ShowMetadataView();
            }
        }

        public void OnShowRightChannelEventRaised()
        {
            _rightChannelView.DrawSignal(_signal.RawData._RightChannelData, _signal.Metadata._SampleRate);

            FFT fft = new FFT(_signal.RawData._RightChannelData);
            _rightChannelView.DrawSpectrum(fft.Spectrum, _signal.Metadata._SampleRate);

            _rightChannelView.ShowRightChannelView();

        }
    }
}
