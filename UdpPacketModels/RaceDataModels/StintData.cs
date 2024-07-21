using ForzaTelemetry.ForzaModels.RaceDataModels.Enums;
using ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

namespace ForzaTelemetry.ForzaModels.RaceDataModels;

// TODO: Add model values
public record StintData(
    byte? TyreCompound,
    byte? EndLap) : IRaceData, IDisposable {
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
}