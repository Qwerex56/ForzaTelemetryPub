namespace ForzaTelemetry.ForzaModels.DataOut;

public interface IForzaDataOut {
    int IsRaceOn { get; set; }
    
    uint TimestampMs { get; set; }
    float EngineMaxRpm { get; set; }
    float EngineIdleRpm { get; set; }
    float CurrentEngineRpm { get; set; }
    
    float AccelerationX { get; set; }
    float AccelerationY { get; set; }
    float AccelerationZ { get; set; }
    
    float VelocityX { get; set; }
    float VelocityY { get; set; }
    float VelocityZ { get; set; }
    
    float AngularVelocityX { get; set; }
    float AngularVelocityY { get; set; }
    float AngularVelocityZ { get; set; }
    
    float Yaw { get; set; }
    float Pitch { get; set; }
    float Roll { get; set; }
    
    float NormalizedSuspensionTravelFl { get; set; }
    float NormalizedSuspensionTravelFr { get; set; }
    float NormalizedSuspensionTravelRl { get; set; }
    float NormalizedSuspensionTravelRr { get; set; }
    
    float TireSlipRatioFl { get; set; }
    float TireSlipRatioFr { get; set; }
    float TireSlipRatioRl { get; set; }
    float TireSlipRatioRr { get; set; }
    
    float WheelRotationSpeedFl { get; set; }
    float WheelRotationSpeedFr { get; set; }
    float WheelRotationSpeedRl { get; set; }
    float WheelRotationSpeedRr { get; set; }
    
    float WheelOnRumbleStripFl { get; set; }
    float WheelOnRumbleStripFr { get; set; }
    float WheelOnRumbleStripRl { get; set; }
    float WheelOnRumbleStripRr { get; set; }
    
    float WheelInPuddleDepthFl { get; set; }
    float WheelInPuddleDepthFr { get; set; }
    float WheelInPuddleDepthRl { get; set; }
    float WheelInPuddleDepthRr { get; set; }
    
    float SurfaceRumbleFl { get; set; }
    float SurfaceRumbleFr { get; set; }
    float SurfaceRumbleRl { get; set; }
    float SurfaceRumbleRr { get; set; }
    
    float TireSlipAngleFl { get; set; }
    float TireSlipAngleFr { get; set; }
    float TireSlipAngleRl { get; set; }
    float TireSlipAngleRr { get; set; }
    
    float TireCombinedSlipFl { get; set; }
    float TireCombinedSlipFr { get; set; }
    float TireCombinedSlipRl { get; set; }
    float TireCombinedSlipRr { get; set; }
    
    float SuspensionTravelMetersFl { get; set; }
    float SuspensionTravelMetersFr { get; set; }
    float SuspensionTravelMetersRl { get; set; }
    float SuspensionTravelMetersRr { get; set; }
    
    int CarId { get; set; }
    int CarClass { get; set; }
    int CarPi { get; set; }
    int DrivetrainType { get; set; }
    int CylinderCount { get; set; }
}