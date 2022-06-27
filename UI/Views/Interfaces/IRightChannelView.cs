using System;

namespace UI.Views.Interfaces
{
    public interface IRightChannelView
    {
        void ShowRightChannelView();
        void DrawSignal(double[] data, UInt32 sampleRate);
        void DrawSpectrum(double[] data, UInt32 sampleRate);
    }
}
