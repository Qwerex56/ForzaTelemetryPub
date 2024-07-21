using ForzaTelemetry.ForzaModels.RaceDataModels;

namespace ForzaTelemetry.ForzaModels.DataAnalyzers;

public sealed class SteerAnalyzer {
    private uint _samplesCount;
    private float _onThrottleTime;
    private float _offThrottleTime;
    private float _onBrakeTime;

    // TODO: change tuple to record type
    private readonly
        List<(uint samplesInLap, float onThrottleTimeInLap, float offThrottleTimeInLap, float onBrakeTimeInLap)>
        _perLapSteerAnalyze = [];

    public void AddSample(CarTelemetryData carTelemetryData) {
        // ArgumentNullException.ThrowIfNull(carTelemetryData.Brake);
        // ArgumentNullException.ThrowIfNull(carTelemetryData.Throttle);

        if (carTelemetryData.Brake is null) return;
        if (carTelemetryData.Throttle is null) return;

        _samplesCount += 1;

        if (carTelemetryData.Brake > 0) {
            _onBrakeTime += 1;

            return;
        }

        if (carTelemetryData.Throttle > 0) {
            _onThrottleTime += 1;

            return;
        }

        _offThrottleTime += 1;
    }

    public void SaveLapSteerAndReset() {
        _perLapSteerAnalyze.Add((_samplesCount, _onThrottleTime, _offThrottleTime, _onBrakeTime));
        
        _samplesCount = 0;
        _onThrottleTime = 0;
        _offThrottleTime = 0;
        _onBrakeTime = 0;
    }
 
    public float OnThrottleTimePercentage() {
        if (_samplesCount <= 0) return 0f;

        return _onThrottleTime / _samplesCount;
    }

    public float OnBrakeTimePercentage() {
        if (_samplesCount <= 0) return 0f;

        return _onBrakeTime / _samplesCount;
    }

    public float OffThrottleTimePercentage() {
        if (_samplesCount <= 0) return 0f;

        return _offThrottleTime / _samplesCount;
    }
}