using ForzaTelemetry.ForzaModels.RaceDataModels.Enums;
using ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

namespace ForzaTelemetry.ForzaModels.RaceDataModels;

public record TireData(
    float SlipRatio,
    float SlipAngle,
    float CombinedSlip,
    float Temperature,
    float Wear) : IRaceData, IDisposable {
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