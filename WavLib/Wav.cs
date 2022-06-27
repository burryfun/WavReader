using System;
using System.IO;
using System.Text;

/*
    0-44 bytes - metadata
    44+ - data
 */

namespace WavLib
{
    public struct WavMetaData
    {
        // RIFF chunk description
        public string _ChunkID;
        public UInt32 _ChunkSize;
        public string _Format;

        // fmt sub-chunk
        public string _Subchunk1ID;
        public UInt32 _Subchunk1Size;
        public UInt16 _AudioFormat;
        public UInt16 _NumChannels;
        public UInt32 _SampleRate; // Частота дискретизации
        public UInt32 _ByteRate;
        public UInt16 _BlockAlign;
        public UInt16 _BitsPerSample;

        // data sub-chunk
        public string _Subchunk2ID;
        public UInt32 _Subchunk2Size;
    }

    public struct WavData
    {
        public double[] _LeftChannelData;
        public double[] _RightChannelData;
    }

    public class Wav
    {
        private readonly WavMetaData _metaData;

        private readonly byte[] _data;

        public Wav(string FilePath)
        {
            if (!File.Exists(FilePath))
            {
                throw new FileNotFoundException("File not exists", FilePath);
            }

            using (var fs = new FileStream(FilePath, FileMode.Open))
            {
                using (var reader = new BinaryReader(fs))
                {
                    _metaData._ChunkID = Encoding.Default.GetString(reader.ReadBytes(4));
                    _metaData._ChunkSize = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
                    _metaData._Format = Encoding.Default.GetString(reader.ReadBytes(4));

                    _metaData._Subchunk1ID = Encoding.Default.GetString(reader.ReadBytes(4));
                    _metaData._Subchunk1Size = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
                    _metaData._AudioFormat = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
                    _metaData._NumChannels = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
                    _metaData._SampleRate = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
                    _metaData._ByteRate = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
                    _metaData._BlockAlign = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
                    _metaData._BitsPerSample = BitConverter.ToUInt16(reader.ReadBytes(2), 0);

                    _metaData._Subchunk2ID = Encoding.Default.GetString(reader.ReadBytes(4));
                    _metaData._Subchunk2Size = BitConverter.ToUInt32(reader.ReadBytes(4), 0);

                    _data = reader.ReadBytes((int)_metaData._Subchunk2Size);
                }
            }
        }

        public WavMetaData GetMetaData()
        {
            return _metaData;
        }

        public WavData GetRawData()
        {
            /* 
             * Count of samples = Subchunk2Size * 8 / BitsPerSample / NumChannels 
             */
            WavData wavData = new WavData();

            if (_metaData._NumChannels == 1)
            {
                double[] rawData = new double[_metaData._Subchunk2Size * 8 / _metaData._BitsPerSample / _metaData._NumChannels];

                if (_metaData._BitsPerSample == 16)
                {
                    for (int i = 0; i < _metaData._Subchunk2Size; i += 2)
                    {
                        short sample = (short)(_data[i] | (_data[i + 1] << 8));
                        rawData[i / 2] = sample;
                    }
                }

                if (_metaData._BitsPerSample == 24)
                {
                    for (int i = 0; i < _metaData._Subchunk2Size; i += 3)
                    {
                        short sample = (short)(_data[i] | (_data[i + 1] << 8) | (_data[i + 2] << 16));
                        rawData[i / 3] = sample;
                    }
                }

                if (_metaData._BitsPerSample == 32)
                {
                    for (int i = 0; i < _metaData._Subchunk2Size; i += 4)
                    {
                        short sample = (short)(_data[i] | (_data[i + 1] << 8) | (_data[i + 2] << 16) | (_data[i + 3] << 24));
                        rawData[i / 4] = sample;
                    }
                }

                wavData._LeftChannelData = rawData;
            }

            if (_metaData._NumChannels == 2)
            {
                double[] rawDataLeft = new double[_metaData._Subchunk2Size * 8 / _metaData._BitsPerSample / _metaData._NumChannels];
                double[] rawDataRight = new double[_metaData._Subchunk2Size * 8 / _metaData._BitsPerSample / _metaData._NumChannels];

                if (_metaData._BitsPerSample == 16)
                {
                    for (int i = 0; i < _metaData._Subchunk2Size; i += 4)
                    {
                        short sampleLeft = (short)(_data[i] | (_data[i + 1] << 8));
                        short sampleRight = (short)(_data[i + 2] | (_data[i + 3] << 8));
                        rawDataLeft[i / 4] = sampleLeft;
                        rawDataRight[i / 4] = sampleRight;
                    }
                }

                if (_metaData._BitsPerSample == 24)
                {
                    for (int i = 0; i < _metaData._Subchunk2Size; i += 6)
                    {
                        short sampleLeft = (short)(_data[i] | (_data[i + 1] << 8) | (_data[i + 2] << 16));
                        short sampleRight = (short)(_data[i + 3] | (_data[i + 4] << 8) | (_data[i + 5] << 16));
                        rawDataLeft[i / 6] = sampleLeft;
                        rawDataRight[i / 6] = sampleRight;
                    }
                }

                if (_metaData._BitsPerSample == 32)
                {
                    for (int i = 0; i < _metaData._Subchunk2Size; i += 8)
                    {
                        short sampleLeft = (short)(_data[i] | (_data[i + 1] << 8) | (_data[i+2] << 16) | (_data[i+3] << 24));
                        short sampleRight = (short)(_data[i + 4] | (_data[i + 5] << 8) | (_data[i + 6] << 16) | (_data[i + 7] << 24));
                        rawDataLeft[i / 8] = sampleLeft;
                        rawDataRight[i / 8] = sampleRight;
                    }
                }

                wavData._LeftChannelData = rawDataLeft;
                wavData._RightChannelData = rawDataRight;
            }

            return wavData;
        }
    }
}
