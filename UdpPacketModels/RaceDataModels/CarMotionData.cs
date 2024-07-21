using System.Numerics;
using ForzaTelemetry.ForzaModels.RaceDataModels.Enums;
using ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

namespace ForzaTelemetry.ForzaModels.RaceDataModels;

public record CarMotionData(
    Vector3? WorldPosition,
    Vector3? Acceleration,
    Vector3? Velocity,
    Vector3? AngularVelocity,
    // Vector3? ForwardDirection,
    // Vector3? RightDirection,
    float? Yaw,
    float? Pitch,
    float? Roll,
    float? GForceLateral,
    float? GForceLongitudinal,
    float? GForceVertical
    ) : IRaceData, IDisposable {
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