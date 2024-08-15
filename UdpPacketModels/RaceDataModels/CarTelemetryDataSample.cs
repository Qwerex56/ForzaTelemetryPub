using ForzaTelemetry.ForzaModels.RaceDataModels.Enums;
using ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

namespace ForzaTelemetry.ForzaModels.RaceDataModels;

public record CarTelemetryDataSample(
    ushort? Speed = null,
    float? Throttle = null,
    float? Steer = null,
    float? Brake = null,
    byte? Clutch = null,
    sbyte? Gear = null,
    ushort? EngineRpm = null) : IRaceDataSample {
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