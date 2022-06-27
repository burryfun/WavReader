using System;

namespace UI.Views.Interfaces
{
    public interface IMainView
    {
        string GetOpenFileName();
        void SetSignalTitleLabel(string title);
        void SetSpectrumTitleLabel(string title);
        void SetVisibleRightChannelButton(bool isVisibleRightChannelButton);
        void ShowWarningMessage(string message);
        void ShowFilePath(string filename);
        void DrawSignal(double[] data, UInt32 sampleRate);
        void DrawSpectrum(double[] data, UInt32 sampleRate);

        event Action ShowMetadataEventRaised;
        event Action OpenFileEventRaised;
        event Action ShowRightChannelViewEventRaised;
    }
}
