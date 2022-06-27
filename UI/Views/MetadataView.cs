using System;
using System.Windows.Forms;
using UI.Views.Interfaces;

namespace UI.Views
{
    public partial class MetadataView : Form, IMetadataView
    {
        public MetadataView()
        {
            InitializeComponent();

            button1.Click += (sender, args) => Invoke(CloseMetadataViewEventRaised);
        }

        public event Action CloseMetadataViewEventRaised;

        public void CloseMetadataView()
        {
            this.Close();
        }

        public void SetMetadataValues(
                                      string chunkid,
                                      uint chunksize,
                                      string format,
                                      string subchunk1id,
                                      uint subchink1size,
                                      ushort audioformat,
                                      ushort numchannels,
                                      uint samplerate,
                                      uint byterate,
                                      ushort blockalign,
                                      ushort bitspersample,
                                      string subchunk2id,
                                      uint subchunk2size)
        {
            ChunkIDValue.Text = chunkid;
            ChunkSizeValue.Text = chunksize.ToString();
            FormatValue.Text = format.ToString();
            Subchunk1IDValue.Text = subchunk1id.ToString();
            Subchunk1SizeValue.Text = subchink1size.ToString();
            AudioFormatValue.Text = audioformat.ToString();
            NumChannelsValue.Text = numchannels.ToString();
            SampleRateValue.Text = samplerate.ToString();
            ByteRateValue.Text = byterate.ToString();
            BlockAlignValue.Text = blockalign.ToString();
            BitsPerSampleValue.Text = bitspersample.ToString();
            Subchunk2IDValue.Text = subchunk2id.ToString();
            Subchunk2SizeValue.Text = subchunk2size.ToString();
        }

        public void ShowMetadataView()
        {
            this.ShowDialog();
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

    }
}
