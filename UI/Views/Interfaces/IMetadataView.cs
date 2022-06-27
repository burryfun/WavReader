using System;

namespace UI.Views.Interfaces
{
    public interface IMetadataView
    {
        void SetMetadataValues(
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
                               uint subchunk2size
            );
        void ShowMetadataView();
        void CloseMetadataView();

        event Action CloseMetadataViewEventRaised;
    }
}
