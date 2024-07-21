using ForzaTelemetry.ForzaModels.RaceDataModels;
using ScottPlot.Blazor;

namespace ForzaTelemetry.ForzaModels.DataAnalyzers;

public class CarTelemetryAnalyzer {
    private readonly List<CarTelemetryData> _carTelemetryHistory = [];

    // private float _bestLapTime;

    public void AddSample(CarTelemetryData sample) {
        _carTelemetryHistory.Add(sample);
    }

    public void FlushSamples() => _carTelemetryHistory.Clear();
    
    public BlazorPlot SpeedChart() {
        var blazorPLot = new BlazorPlot();

        blazorPLot.Plot.XLabel("Time");
        blazorPLot.Plot.YLabel("Speed");

        var data = from telemetryData in _carTelemetryHistory select telemetryData.Speed;
        blazorPLot.Plot.Add.Signal(data.ToArray());

        blazorPLot.Plot.SavePng("okay.png", 400, 300);
        return blazorPLot;
    }
    
}