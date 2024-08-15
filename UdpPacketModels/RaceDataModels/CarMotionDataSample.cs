using System.Numerics;
using ForzaTelemetry.ForzaModels.RaceDataModels.Enums;
using ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

namespace ForzaTelemetry.ForzaModels.RaceDataModels;

public record CarMotionDataSample(
    Vector3? WorldPosition = null,
    Vector3? Acceleration = null,
    Vector3? Velocity = null,
    Vector3? AngularVelocity = null,
    // Vector3? ForwardDirection,
    // Vector3? RightDirection,
    float? Yaw = null,
    float? Pitch = null,
    float? Roll = null,
    float? GForceLateral = null,
    float? GForceLongitudinal = null,
    float? GForceVertical = null
    ) : IRaceDataSample {
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