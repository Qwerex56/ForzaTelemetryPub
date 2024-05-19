using ForzaTelemetry.ForzaModels.DataOut;

namespace ForzaTelemetry.ForzaModels.DataFormatters;

public abstract class ForzaFormatter : PacketFormatter {
    public static ForzaDataOutSled DataOutSled(byte[] bytes) {
        var cursor = 0;
        
        return new() {
            IsRaceOn    = ReadInt32(bytes, ref cursor),
            TimestampMs = ReadUInt32(bytes, ref cursor),
            
            EngineMaxRpm     = ReadSingle(bytes, ref cursor),
            EngineIdleRpm    = ReadSingle(bytes, ref cursor),
            CurrentEngineRpm = ReadSingle(bytes, ref cursor),
            
            AccelerationX = ReadSingle(bytes, ref cursor),
            AccelerationY = ReadSingle(bytes, ref cursor),
            AccelerationZ = ReadSingle(bytes, ref cursor),
            
            VelocityX = ReadSingle(bytes, ref cursor),
            VelocityY = ReadSingle(bytes, ref cursor),
            VelocityZ = ReadSingle(bytes, ref cursor),
            
            AngularVelocityX = ReadSingle(bytes, ref cursor),
            AngularVelocityY = ReadSingle(bytes, ref cursor),
            AngularVelocityZ = ReadSingle(bytes, ref cursor),
            
            Yaw   = ReadSingle(bytes, ref cursor),
            Pitch = ReadSingle(bytes, ref cursor),
            Roll  = ReadSingle(bytes, ref cursor),
            
            NormalizedSuspensionTravelFl = ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelFr = ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelRl = ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelRr = ReadSingle(bytes, ref cursor),
            
            TireSlipRatioFl = ReadSingle(bytes, ref cursor),
            TireSlipRatioFr = ReadSingle(bytes, ref cursor),
            TireSlipRatioRl = ReadSingle(bytes, ref cursor),
            TireSlipRatioRr = ReadSingle(bytes, ref cursor),
            
            WheelRotationSpeedFl = ReadSingle(bytes, ref cursor),
            WheelRotationSpeedFr = ReadSingle(bytes, ref cursor),
            WheelRotationSpeedRl = ReadSingle(bytes, ref cursor),
            WheelRotationSpeedRr = ReadSingle(bytes, ref cursor),
            
            WheelOnRumbleStripFl = ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripFr = ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripRl = ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripRr = ReadSingle(bytes, ref cursor),
            
            WheelInPuddleDepthFl = ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthFr = ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthRl = ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthRr = ReadSingle(bytes, ref cursor),
            
            SurfaceRumbleFl = ReadSingle(bytes, ref cursor),
            SurfaceRumbleFr = ReadSingle(bytes, ref cursor),
            SurfaceRumbleRl = ReadSingle(bytes, ref cursor),
            SurfaceRumbleRr = ReadSingle(bytes, ref cursor),
            
            TireSlipAngleFl = ReadSingle(bytes, ref cursor),
            TireSlipAngleFr = ReadSingle(bytes, ref cursor),
            TireSlipAngleRl = ReadSingle(bytes, ref cursor),
            TireSlipAngleRr = ReadSingle(bytes, ref cursor),
            
            TireCombinedSlipFl = ReadSingle(bytes, ref cursor),
            TireCombinedSlipFr = ReadSingle(bytes, ref cursor),
            TireCombinedSlipRl = ReadSingle(bytes, ref cursor),
            TireCombinedSlipRr = ReadSingle(bytes, ref cursor),
            
            SuspensionTravelMetersFl = ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersFr = ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersRl = ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersRr = ReadSingle(bytes, ref cursor),
            
            CarId          = ReadInt32(bytes, ref cursor),
            CarClass       = ReadInt32(bytes, ref cursor),
            CarPi          = ReadInt32(bytes, ref cursor),
            DrivetrainType = ReadInt32(bytes, ref cursor),
            CylinderCount  = ReadInt32(bytes, ref cursor)
        };
    }
    
    public static ForzaDataOutDash DataOutDash(byte[] bytes) {
        var cursor = 0;
        
        return new() {
            IsRaceOn    = ReadInt32(bytes, ref cursor),
            TimestampMs = ReadUInt32(bytes, ref cursor),
            
            EngineMaxRpm     = ReadSingle(bytes, ref cursor),
            EngineIdleRpm    = ReadSingle(bytes, ref cursor),
            CurrentEngineRpm = ReadSingle(bytes, ref cursor),
            
            AccelerationX = ReadSingle(bytes, ref cursor),
            AccelerationY = ReadSingle(bytes, ref cursor),
            AccelerationZ = ReadSingle(bytes, ref cursor),
            
            Yaw   = ReadSingle(bytes, ref cursor),
            Pitch = ReadSingle(bytes, ref cursor),
            Roll  = ReadSingle(bytes, ref cursor),
            
            VelocityX = ReadSingle(bytes, ref cursor),
            VelocityY = ReadSingle(bytes, ref cursor),
            VelocityZ = ReadSingle(bytes, ref cursor),
            
            AngularVelocityX = ReadSingle(bytes, ref cursor),
            AngularVelocityY = ReadSingle(bytes, ref cursor),
            AngularVelocityZ = ReadSingle(bytes, ref cursor),
            
            NormalizedSuspensionTravelFl = ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelFr = ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelRl = ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelRr = ReadSingle(bytes, ref cursor),
            
            TireSlipRatioFl = ReadSingle(bytes, ref cursor),
            TireSlipRatioFr = ReadSingle(bytes, ref cursor),
            TireSlipRatioRl = ReadSingle(bytes, ref cursor),
            TireSlipRatioRr = ReadSingle(bytes, ref cursor),
            
            WheelRotationSpeedFl = ReadSingle(bytes, ref cursor),
            WheelRotationSpeedFr = ReadSingle(bytes, ref cursor),
            WheelRotationSpeedRl = ReadSingle(bytes, ref cursor),
            WheelRotationSpeedRr = ReadSingle(bytes, ref cursor),
            
            WheelOnRumbleStripFl = ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripFr = ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripRl = ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripRr = ReadSingle(bytes, ref cursor),
            
            WheelInPuddleDepthFl = ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthFr = ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthRl = ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthRr = ReadSingle(bytes, ref cursor),
            
            SurfaceRumbleFl = ReadSingle(bytes, ref cursor),
            SurfaceRumbleFr = ReadSingle(bytes, ref cursor),
            SurfaceRumbleRl = ReadSingle(bytes, ref cursor),
            SurfaceRumbleRr = ReadSingle(bytes, ref cursor),
            
            TireSlipAngleFl = ReadSingle(bytes, ref cursor),
            TireSlipAngleFr = ReadSingle(bytes, ref cursor),
            TireSlipAngleRl = ReadSingle(bytes, ref cursor),
            TireSlipAngleRr = ReadSingle(bytes, ref cursor),
            
            TireCombinedSlipFl = ReadSingle(bytes, ref cursor),
            TireCombinedSlipFr = ReadSingle(bytes, ref cursor),
            TireCombinedSlipRl = ReadSingle(bytes, ref cursor),
            TireCombinedSlipRr = ReadSingle(bytes, ref cursor),
            
            SuspensionTravelMetersFl = ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersFr = ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersRl = ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersRr = ReadSingle(bytes, ref cursor),
            
            CarId          = ReadInt32(bytes, ref cursor),
            CarClass       = ReadInt32(bytes, ref cursor),
            CarPi          = ReadInt32(bytes, ref cursor),
            DrivetrainType = ReadInt32(bytes, ref cursor),
            CylinderCount  = ReadInt32(bytes, ref cursor),
            
            PositionX = ReadSingle(bytes, ref cursor),
            PositionY = ReadSingle(bytes, ref cursor),
            PositionZ = ReadSingle(bytes, ref cursor),
            
            Speed = ReadSingle(bytes, ref cursor),
            Power = ReadSingle(bytes, ref cursor),
            Torque = ReadSingle(bytes, ref cursor),
            
            TireTempFl = ReadSingle(bytes, ref cursor),
            TireTempFr = ReadSingle(bytes, ref cursor),
            TireTempRl = ReadSingle(bytes, ref cursor),
            TireTempRr = ReadSingle(bytes, ref cursor),
            
            Boost = ReadSingle(bytes, ref cursor),
            Fuel = ReadSingle(bytes, ref cursor),
            
            DistanceTraveled = ReadSingle(bytes, ref cursor),
            
            BestLap = ReadSingle(bytes, ref cursor),
            LastLap = ReadSingle(bytes, ref cursor),
            CurrentLap = ReadSingle(bytes, ref cursor),
            CurrentRaceTime = ReadSingle(bytes, ref cursor),
            
            LapNumber = ReadUInt16(bytes, ref cursor),
            RacePosition = ReadUInt8(bytes, ref cursor),
            
            Accel = ReadUInt8(bytes, ref cursor),
            Brake = ReadUInt8(bytes, ref cursor),
            Clutch = ReadUInt8(bytes, ref cursor),
            HandBrake = ReadUInt8(bytes, ref cursor),
            Gear = ReadUInt8(bytes, ref cursor),
            Steer = ReadInt8(bytes, ref cursor),
            
            NormalizedDrivingLine = ReadInt8(bytes, ref cursor),
            NormalizedAiBrakeDiff = ReadInt8(bytes, ref cursor),
            
            TireWearFl = ReadSingle(bytes, ref cursor),
            TireWearFr = ReadSingle(bytes, ref cursor),
            TireWearRl = ReadSingle(bytes, ref cursor),
            TireWearRr = ReadSingle(bytes, ref cursor),
            
            TrackId = ReadInt32(bytes, ref cursor)
        };
    }

    // private bool ValidateBytes(in byte[] bytes) {
    //     
    // }
}