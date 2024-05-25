namespace ForzaTelemetry.ForzaModels.DataOut;

public class ForzaDataOutDash {
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
    
    public float PositionX { get; set; }
    public float PositionY { get; set; }
    public float PositionZ { get; set; }
    
    public float Speed { get; set; }
    public float Power { get; set; }
    public float Torque { get; set; }
    
    public float TireTempFl { get; set; }
    public float TireTempFr { get; set; }
    public float TireTempRl { get; set; }
    public float TireTempRr { get; set; }
    
    public float Boost { get; set; }
    public float Fuel { get; set; }
    
    public float DistanceTraveled { get; set; }
    
    public float BestLap { get; set; }
    public float LastLap { get; set; }
    public float CurrentLap { get; set; }
    public float CurrentRaceTime { get; set; }
    
    public ushort LapNumber { get; set; }
    public byte RacePosition { get; set; }
    
    public byte Accel { get; set; }
    public byte Brake { get; set; }
    public byte Clutch { get; set; }
    public byte HandBrake { get; set; }
    public byte Gear { get; set; }
    public sbyte Steer { get; set; }
    
    public sbyte NormalizedDrivingLine { get; set; }
    public sbyte NormalizedAiBrakeDiff { get; set; }
    
    public float TireWearFl { get; set; }
    public float TireWearFr { get; set; }
    public float TireWearRl { get; set; }
    public float TireWearRr { get; set; }
    
    public int TrackId { get; set; }
}