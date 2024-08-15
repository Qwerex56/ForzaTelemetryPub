using ForzaTelemetry.ForzaModels.RaceDataModels;
using Plotly.Blazor;
using Plotly.Blazor.Traces;
using Plotly.Blazor.Traces.ScatterLib;

namespace ForzaTelemetry.ForzaModels.DataAnalyzers;

public class CarTelemetryAnalyzer {
    public bool DoGenerateLastLapScatter { get; set; }
    public bool DoGenerateBestLapScatter { get; set; }

    public List<ITrace> SpeedChart() {
        var speedHistory = (from telemetryData in SessionDataSingleton.Instance.CarTelemetryData
                            select telemetryData.Speed * 3.6).ToList();

        IList<object> y = [];
        IList<object> x = [];

        {
            var iter = 0;
            foreach (var speed in speedHistory) {
                y.Add(speed!);
                x.Add(iter++);
            }
        }
        
        var data = new List<ITrace> {
            new Scatter {
                Name = "Speed trace",
                Mode = ModeFlag.Lines,
                X = x,
                Y = y,
                
            }
        };

        // TODO: Add best and last lap
        // if (DoGenerateBestLapScatter) {
        //     data.Add(new Scatter {
        //         Name = "Best lap",
        //         Mode = ModeFlag.Lines,
        //     });
        // }
        //
        // if (!DoGenerateLastLapScatter) {
        //     return data;
        // }
        //
        // var lastLapSpeedHistory = (from lastLap in _lapHistory.LastOrDefault()
        //                            select lastLap.Speed * 3.6).ToList();
        //
        // data.Add(new Scatter {
        //     Name = "Last lap",
        //     Mode = ModeFlag.Lines,
        //     X = Enumerable.Range(0, lastLapSpeedHistory.Count).ToList() as IList<object>,
        //     Y = lastLapSpeedHistory as IList<object>
        // });

        return data;
    }

    public object PedalsChart() {
        throw new NotImplementedException();
    }

    public object GearChart() {
        throw new NotImplementedException();
    }

    public object GForceChart() {
        throw new NotImplementedException();
    }

    public void UpdateSpeedChart(ref IList<ITrace> traces) {
        if (traces.LastOrDefault() is not Scatter scatter) {
            return;
        }

        scatter.Y.Add(SessionDataSingleton.Instance.CarTelemetryData.LastOrDefault()?.Speed);
        scatter.X.Add(SessionDataSingleton.Instance.CarTelemetryData.Count);
    }
}

public enum UpdateMode {
    Speed,
    Pedals,
    Gears,
}