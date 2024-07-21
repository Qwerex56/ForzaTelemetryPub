namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Data;

public record HeaderData(
    ushort PacketFormat,
    byte GameMajorVersion,
    byte GameMinorVersion,
    byte PacketVersion,
    byte PacketId,
    ulong SessionId,
    float SessionTime,
    uint FrameIdentifier,
    byte PlayerCarIndex,
    byte SecondaryPlayerCarIndex);