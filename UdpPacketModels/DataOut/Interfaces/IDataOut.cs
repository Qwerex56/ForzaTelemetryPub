using ForzaTelemetry.ForzaModels.RaceDataModels;

namespace ForzaTelemetry.ForzaModels.DataOut.Interfaces;

public interface IDataOut {
    public CarMotionDataSample GetCarMotionData();

    public CarTelemetryDataSample GetCarTelemetryData();
    
    public LapDataSample GetLapData();

    public StintDataSample GetStintData();
    
    public TireDataSample GetTiresData();

    public TrackDataSample GetTrackData();
    
    public WheelDataSample GetWheelsData();
}