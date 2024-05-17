using System.Net.NetworkInformation;
using ForzaTelemetry.ForzaModels.DataOut;

namespace ForzaTelemetry.ForzaModels.DataFormatters;

public abstract class ForzaDashFormatter : IPacketFormatter {
    public static ForzaDataOutSled FormatForzaDataOutSled(byte[] bytes) {
        return new() {
            IsRaceOn = IPacketFormatter.ParseInt32(bytes, 0) > 0,
            TimestampMs = IPacketFormatter.ParseUInt32(bytes, 4),
            EngineMaxRpm = IPacketFormatter.ParseSingle(bytes, 8),
            EngineIdleRpm = IPacketFormatter.ParseSingle(bytes, 12),
            CurrentEngineRpm = IPacketFormatter.ParseSingle(bytes, 16),
            AccelerationX = IPacketFormatter.ParseSingle(bytes, 20),
        };
    }
    
    public static ForzaDataOutDash FormatData(byte[] bytes) {
        return new() { };
    }

    private static int Cursor { get; set; } = 0;
}