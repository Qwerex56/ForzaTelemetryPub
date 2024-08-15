using ForzaTelemetry.ForzaModels.RaceDataModels.Enums;
using ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

namespace ForzaTelemetry.ForzaModels.RaceDataModels;

public record LapDataSample(
    float? DistanceTraveled = null,
    float? BestLapTime = null,
    float? LastLapTime = null,
    float? CurrentLapTime = null,
    float? RaceTime = null,
    ushort? LapNumber = null,
    byte? CurrentPosition = null) : IRaceDataSample {
    public RacingGameTitleEnum GameTitle { get; init; }

    public void Dispose(bool disposing) {
        if (!disposing) {
            return;
        }
        
        // Release managed resources here
    }

    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
};