namespace ForzaTelemetry.ForzaModels.DataOut;

public class Fm8DataOutSled {
    public int IsRaceOn { get; set; }
    
    public uint TimestampMs { get; set; }
    public float EngineMaxRpm { get; set; }
    public float EngineIdleRpm { get; set; }
    public float CurrentEngineRpm { get; set; }
    
    public float AccelerationX { get; set; }
    public float AccelerationY { get; set; }
    public float AccelerationZ { get; set; }
    
    public float VelocityX { get; set; }
    public float VelocityY { get; set; }
    public float VelocityZ { get; set; }
    
    public float AngularVelocityX { get; set; }
    public float AngularVelocityY { get; set; }
    public float AngularVelocityZ { get; set; }
    
    public float Yaw { get; set; }
    public float Pitch { get; set; }
    public float Roll { get; set; }
    
    public float NormalizedSuspensionTravelFl { get; set; }
    public float NormalizedSuspensionTravelFr { get; set; }
    public float NormalizedSuspensionTravelRl { get; set; }
    public float NormalizedSuspensionTravelRr { get; set; }
    
    public float TireSlipRatioFl { get; set; }
    public float TireSlipRatioFr { get; set; }
    public float TireSlipRatioRl { get; set; }
    public float TireSlipRatioRr { get; set; }
    
    public float WheelRotationSpeedFl { get; set; }
    public float WheelRotationSpeedFr { get; set; }
    public float WheelRotationSpeedRl { get; set; }
    public float WheelRotationSpeedRr { get; set; }
    
    public float WheelOnRumbleStripFl { get; set; }
    public float WheelOnRumbleStripFr { get; set; }
    public float WheelOnRumbleStripRl { get; set; }
    public float WheelOnRumbleStripRr { get; set; }
    
    public float WheelInPuddleDepthFl { get; set; }
    public float WheelInPuddleDepthFr { get; set; }
    public float WheelInPuddleDepthRl { get; set; }
    public float WheelInPuddleDepthRr { get; set; }
    
    public float SurfaceRumbleFl { get; set; }
    public float SurfaceRumbleFr { get; set; }
    public float SurfaceRumbleRl { get; set; }
    public float SurfaceRumbleRr { get; set; }
    
    public float TireSlipAngleFl { get; set; }
    public float TireSlipAngleFr { get; set; }
    public float TireSlipAngleRl { get; set; }
    public float TireSlipAngleRr { get; set; }
    
    public float TireCombinedSlipFl { get; set; }
    public float TireCombinedSlipFr { get; set; }
    public float TireCombinedSlipRl { get; set; }
    public float TireCombinedSlipRr { get; set; }
    
    public float SuspensionTravelMetersFl { get; set; }
    public float SuspensionTravelMetersFr { get; set; }
    public float SuspensionTravelMetersRl { get; set; }
    public float SuspensionTravelMetersRr { get; set; }
    
    public int CarId { get; set; }
    public int CarClass { get; set; }
    public int CarPi { get; set; }
    public int DrivetrainType { get; set; }
    public int CylinderCount { get; set; }
}