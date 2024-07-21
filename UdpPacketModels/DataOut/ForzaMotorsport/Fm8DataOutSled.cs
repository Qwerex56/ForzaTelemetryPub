// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace ForzaTelemetry.ForzaModels.DataOut.ForzaMotorsport;

public class Fm8DataOutSled {
    public int IsRaceOn { get; init; }
    
    public uint TimestampMs { get; init; }
    public float EngineMaxRpm { get; init; }
    public float EngineIdleRpm { get; init; }
    public float CurrentEngineRpm { get; init; }
    
    public float AccelerationX { get; init; }
    public float AccelerationY { get; init; }
    public float AccelerationZ { get; init; }
    
    public float VelocityX { get; init; }
    public float VelocityY { get; init; }
    public float VelocityZ { get; init; }
    
    public float AngularVelocityX { get; init; }
    public float AngularVelocityY { get; init; }
    public float AngularVelocityZ { get; init; }
    
    public float Yaw { get; init; }
    public float Pitch { get; init; }
    public float Roll { get; init; }
    
    public float NormalizedSuspensionTravelFl { get; init; }
    public float NormalizedSuspensionTravelFr { get; init; }
    public float NormalizedSuspensionTravelRl { get; init; }
    public float NormalizedSuspensionTravelRr { get; init; }
    
    public float TireSlipRatioFl { get; init; }
    public float TireSlipRatioFr { get; init; }
    public float TireSlipRatioRl { get; init; }
    public float TireSlipRatioRr { get; init; }
    
    public float WheelRotationSpeedFl { get; init; }
    public float WheelRotationSpeedFr { get; init; }
    public float WheelRotationSpeedRl { get; init; }
    public float WheelRotationSpeedRr { get; init; }
    
    public float WheelOnRumbleStripFl { get; init; }
    public float WheelOnRumbleStripFr { get; init; }
    public float WheelOnRumbleStripRl { get; init; }
    public float WheelOnRumbleStripRr { get; init; }
    
    public float WheelInPuddleDepthFl { get; init; }
    public float WheelInPuddleDepthFr { get; init; }
    public float WheelInPuddleDepthRl { get; init; }
    public float WheelInPuddleDepthRr { get; init; }
    
    public float SurfaceRumbleFl { get; init; }
    public float SurfaceRumbleFr { get; init; }
    public float SurfaceRumbleRl { get; init; }
    public float SurfaceRumbleRr { get; init; }
    
    public float TireSlipAngleFl { get; init; }
    public float TireSlipAngleFr { get; init; }
    public float TireSlipAngleRl { get; init; }
    public float TireSlipAngleRr { get; init; }
    
    public float TireCombinedSlipFl { get; init; }
    public float TireCombinedSlipFr { get; init; }
    public float TireCombinedSlipRl { get; init; }
    public float TireCombinedSlipRr { get; init; }
    
    public float SuspensionTravelMetersFl { get; init; }
    public float SuspensionTravelMetersFr { get; init; }
    public float SuspensionTravelMetersRl { get; init; }
    public float SuspensionTravelMetersRr { get; init; }
    
    public int CarId { get; init; }
    public int CarClass { get; init; }
    public int CarPi { get; init; }
    public int DrivetrainType { get; init; }
    public int CylinderCount { get; init; }
}