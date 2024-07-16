namespace ForzaTelemetry.ForzaModels.RaceDataModels;

public record TireData(
    float SlipRatio,
    float SlipAngle,
    float CombinedSlip,
    float Temperature,
    float Wear) : IDisposable {
    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private void Dispose(bool disposing) {
        if (!disposing) {
            return;
        }
        
        // Delete managed resources
    }
}