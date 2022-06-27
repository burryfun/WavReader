using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.Views.Interfaces;

namespace UI.Views
{
    public partial class RightChannelView : Form, IRightChannelView
    {
        public RightChannelView()
        {
            InitializeComponent();
        }

        public void ShowRightChannelView()
        {
            this.ShowDialog();
        }
        public void DrawSignal(double[] data, UInt32 sampleRate)
        {

            double[] time = new double[data.Length];
            double[] magnitude = new double[data.Length];

            for (int i = 0; i != data.Length; i++)
            {
                time[i] = (double)i / sampleRate;
                magnitude[i] = data[i] / Int16.MaxValue;
            }

            SignalPlot.Plot.Clear();
            SignalPlot.Plot.XLabel("Time, s");
            SignalPlot.Plot.YLabel("Magnitude");
            SignalPlot.Plot.AddSignalXY(time, magnitude);
            SignalPlot.Refresh();
        }

        public void DrawSpectrum(double[] data, UInt32 sampleRate)
        {
            List<double> frequency = new List<double>();
            List<double> magnitude = new List<double>();

            for (int i = 0; i != data.Length; i++)
            {
                double freq = i * sampleRate / data.Length;
                double mag = data[i];
                if (mag > 0)
                {
                    frequency.Add(freq);
                    magnitude.Add(mag);
                }
            }

            SpectrumPlot.Plot.Clear();
            SpectrumPlot.Plot.XLabel("Frequency, Hz");
            SpectrumPlot.Plot.YLabel("Magnitude");
            SpectrumPlot.Plot.AddSignalXY(frequency.ToArray(), magnitude.ToArray());
            SpectrumPlot.Refresh();
        }
    }
}
