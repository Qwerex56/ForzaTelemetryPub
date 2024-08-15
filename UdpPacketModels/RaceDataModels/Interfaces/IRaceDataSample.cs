using ForzaTelemetry.ForzaModels.RaceDataModels.Enums;

namespace ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

public interface IRaceDataSample : IDisposable {
    RacingGameTitleEnum GameTitle { get; init; }

    public void Dispose(bool disposing) {
        if (!disposing) {
            return;
        }
    
        // Release managed resources here
    }
};