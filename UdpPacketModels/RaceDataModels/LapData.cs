using ForzaTelemetry.ForzaModels.RaceDataModels.Enums;
using ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

namespace ForzaTelemetry.ForzaModels.RaceDataModels;

public record LapData(
    float? DistanceTraveled,
    float? BestLapTime,
    float? LastLapTime,
    float? CurrentLapTime,
    float? RaceTime,
    ushort? LapNumber,
    byte? CurrentPosition) : IRaceData, IDisposable {
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