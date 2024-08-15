using ForzaTelemetry.ForzaModels.RaceDataModels.Enums;
using ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

namespace ForzaTelemetry.ForzaModels.RaceDataModels;

public record TireDataSample(
    float[]? SlipRatio = null,
    float[]? SlipAngle = null,
    float[]? CombinedSlip = null,
    float[]? Temperature = null,
    float[]? Wear = null) : IRaceDataSample {
    public RacingGameTitleEnum GameTitle { get; init; }

    private void Dispose(bool disposing) {
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