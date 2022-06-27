using System;
using System.Collections.Generic;
using System.IO;
using WavLib;

namespace DomainModel
{
    public class Signal
    {
        public string FilePath { get; set; }
        public WavMetaData Metadata { get; }
        public WavData RawData { get; }

        public Signal(string filepath)
        {
            if (filepath == null)
            {
                throw new FileLoadException("File not found", FilePath);
            }
            FilePath = filepath;
            Wav openedWav = new Wav(FilePath);
            Metadata = openedWav.GetMetaData();
            RawData = openedWav.GetRawData();
        }
    }
}
