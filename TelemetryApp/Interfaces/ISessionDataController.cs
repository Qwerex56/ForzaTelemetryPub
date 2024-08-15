using ForzaTelemetry.ForzaModels.DataOut.Interfaces;
using ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

namespace TelemetryApp.Interfaces;

public interface ISessionDataController {
    public void AddDataSample(IRaceDataSample dataSample);

    public void AddData(IDataOut raceData);

    public object GetLapData();
}