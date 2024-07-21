using ForzaTelemetry.ForzaModels.RaceDataModels;

namespace ForzaTelemetry.ForzaModels.Interfaces;

public interface IDataOut {
    public LapData GetLapData();

    public TireData[] GetTiresData();

    public WheelData[] GetWheelsData();
    
    
}