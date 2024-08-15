using ForzaTelemetry.ForzaModels.RaceDataModels.Enums;
using ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

namespace ForzaTelemetry.ForzaModels.RaceDataModels;

public record TrackDataSample(
    int? TrackId = null,
    float? TrackLength = null,
    float? SessionTime = null,
    ushort? LapNumber = null) : IRaceDataSample {
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