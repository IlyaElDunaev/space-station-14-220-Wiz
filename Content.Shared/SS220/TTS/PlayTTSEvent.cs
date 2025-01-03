using Robust.Shared.Serialization;

namespace Content.Shared.SS220.TTS;

[Serializable, NetSerializable]
// ReSharper disable once InconsistentNaming
public sealed class PlayTTSEvent : EntityEventArgs
{
    public byte[] Data { get; }
    public NetEntity? SourceUid { get; }
    public bool IsRadio { get; }
    public float VolumeModifier { get; set; }
    public bool IsWhisper { get; }

    public PlayTTSEvent(byte[] data, NetEntity? sourceUid = null, bool isRadio = false, bool isWhisper = false, float volumeModifier = 1f)
    {
        Data = data;
        SourceUid = sourceUid;
        IsRadio = isRadio;
        VolumeModifier = volumeModifier;
        IsWhisper = isWhisper;
    }

    public void SetVolumeModifier(float modifier)
    {
        VolumeModifier = Math.Clamp(modifier, 0, 3);
    }
}
