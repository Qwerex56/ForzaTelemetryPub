namespace ForzaTelemetry.ForzaModels.RaceDataModels;

public record TrackData(
    int? TrackId) : IDisposable {
    private void Dispose(bool disposing) {
        if (!disposing) {
            return;
        }

        // TODO release managed resources here
    }

    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
};