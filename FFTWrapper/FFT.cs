using System;
using System.Linq;
using System.Numerics;
using MathNet.Numerics.IntegralTransforms;



namespace FFTWrapper
{
    public class FFT
    {
        public double[] Spectrum { get; set; }
        public FFT(double[] data)
        {
            Spectrum = new double[data.Length];
            Complex[] samples = new Complex[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                samples[i] = new Complex(data[i] / Int16.MaxValue, 0);
            }

            Fourier.Forward(samples, FourierOptions.Matlab);

            for (int i = 0; i < samples.Length / 2; i++)
            {
                double magnitude = (2.0 / samples.Length) * Math.Abs(Math.Sqrt(Math.Pow(samples[i].Real, 2) + Math.Pow(samples[i].Imaginary, 2)));
                Spectrum[i] = magnitude;
            }
        }
    }
}
