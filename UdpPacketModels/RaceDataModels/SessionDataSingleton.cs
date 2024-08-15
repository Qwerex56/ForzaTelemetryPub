using ForzaTelemetry.ForzaModels.DataOut.Interfaces;
using ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

namespace ForzaTelemetry.ForzaModels.RaceDataModels;

// TODO: -x-Data classes rename to -x-Sample and this singleton needs to be controller/service
public sealed class SessionDataSingleton {
    private static Lazy<SessionDataSingleton> _lazyInstance = new(() => new());

    public static SessionDataSingleton Instance => _lazyInstance.Value;

    public List<CarTelemetryDataSample> CarTelemetryData = [];
    public List<CarMotionDataSample> CarMotionData = [];
    public List<LapDataSample> LapData = [];
    public List<StintDataSample> StintData = [];
    public List<TireDataSample> TireData = [];
    public List<WheelDataSample> WheelData = [];
    
    private TrackDataSample _trackDataSample = new();

    public TrackDataSample TrackDataSample {
        get => _trackDataSample;
        set {
            if (value.TrackId != _trackDataSample.TrackId) {
                FlushSamples();
            }

            if (value.SessionTime < _trackDataSample.SessionTime) {
                FlushSamples();
            }

            if (value.LapNumber < _trackDataSample.LapNumber) {
                FlushSamples();
            }

            _trackDataSample = value;
        }
    }

    private SessionDataSingleton() {
    }

    public void AddSample(IRaceDataSample sample) {
        switch (sample) {
            case CarTelemetryDataSample telemetrySample:
                CarTelemetryData.Add(telemetrySample);

                break;
            case CarMotionDataSample motionSample:
                CarMotionData.Add(motionSample);

                break;
            case LapDataSample lapSample:
                LapData.Add(lapSample);

                break;
            case StintDataSample stintSample:
                StintData.Add(stintSample);

                break;
            case TireDataSample tireSample:
                TireData.Add(tireSample);

                break;
            case WheelDataSample wheelSample:
                WheelData.Add(wheelSample);

                break;
        }
    }

    public void AddData(IDataOut data) {
        AddSample(data.GetCarTelemetryData());
        AddSample(data.GetCarMotionData());
        AddSample(data.GetLapData());
        AddSample(data.GetStintData());
        AddSample(data.GetTiresData());
        AddSample(data.GetWheelsData());
    }

    public void AddSamples(IEnumerable<IRaceDataSample> samples) {
        foreach (var sample in samples) {
            AddSample(sample);
        }
    }

    public static void FlushSamples() {
        _lazyInstance = new(() => new());
    }
    
}