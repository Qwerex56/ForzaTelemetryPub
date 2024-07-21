using ForzaTelemetry.ForzaModels.RaceDataModels.Enums;
using ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

namespace ForzaTelemetry.ForzaModels.RaceDataModels;

public record CarTelemetryData(
    ushort? Speed,
    float? Throttle,
    float? Steer,
    float? Brake,
    byte? Clutch,
    sbyte? Gear,
    ushort? EngineRpm) : IRaceData, IDisposable {
    public RacingGameTitleEnum GameTitle { get; init; }

    public void Dispose(bool disposing) {
        if (!disposing) {
            return;
        }
    }
    
    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}