using ForzaTelemetry.ForzaModels.RaceDataModels.Enums;
using ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

namespace ForzaTelemetry.ForzaModels.RaceDataModels;

/// <summary>
/// Wheel data are in clockwise order starting from the left front wheel.
/// </summary>
/// <param name="RotationSpeed"></param>
/// <param name="OnRumbleStrip"></param>
/// <param name="InPuddleDepth"></param>
public record WheelDataSample(
    float[]? RotationSpeed = null,
    float[]? OnRumbleStrip = null,
    float[]? InPuddleDepth = null) : IRaceDataSample {
    public RacingGameTitleEnum GameTitle { get; init; }

    public void Dispose(bool disposing) {
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