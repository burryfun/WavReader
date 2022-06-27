using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.Views.Interfaces;

namespace UI.Views
{
    public partial class MainView : Form, IMainView
    {

        public MainView()
        {
            InitializeComponent();

            ShowMetadataButton.Click += (sender, args) => Invoke(ShowMetadataEventRaised);
            ShowRightChannelButton.Click += (sender, args) => Invoke(ShowRightChannelViewEventRaised);

            openToolStripMenuItem.Click += (sender, args) => Invoke(OpenFileEventRaised);

        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        public event Action ShowMetadataEventRaised;
        public event Action OpenFileEventRaised;
        public event Action ShowRightChannelViewEventRaised;

        public string GetOpenFileName()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }

        public void SetSignalTitleLabel(string title)
        {
            SignalTitleLabel.Text = title;
        }

        public void SetSpectrumTitleLabel(string title)
        {
            SpectrumTitleLabel.Text = title;
        }

        public void SetVisibleRightChannelButton(bool isVisibleRightChannelButton)
        {
            if (isVisibleRightChannelButton)
            {
                ShowRightChannelButton.Visible = true;
            }
            else
            {
                ShowRightChannelButton.Visible = false;
            }
        }

        public void ShowFilePath(string filename)
        {
            FilePathLabel.Text = filename + " loading succsessful";
            FilePathLabel.Visible = true;

            var timer = new Timer();
            timer.Interval = 3000; // it will Tick in 3 seconds
            timer.Tick += (s, e) =>
            {
                FilePathLabel.Hide();
                timer.Stop();
            };
            timer.Start();
        }

        public void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
