using ForzaTelemetry.ForzaModels.DataOut;

namespace ForzaTelemetry.ForzaModels.DataFormatters;

public static class ForzaFormatter {
    public static bool IsRaceOn(this byte[] bytes) {
        ArgumentOutOfRangeException.ThrowIfLessThan(bytes.Length, 4, "Packet is to small to parse");

        return PacketFormatter.ParseInt32(bytes, 0) > 0;
    }
    
    public static ForzaDataOutSled DataOutSled(ref byte[] bytes) {
        var cursor = 0;
        
        return new() {
            IsRaceOn    = PacketFormatter.ReadInt32(bytes, ref cursor),
            TimestampMs = PacketFormatter.ReadUInt32(bytes, ref cursor),
            
            EngineMaxRpm     = PacketFormatter.ReadSingle(bytes, ref cursor),
            EngineIdleRpm    = PacketFormatter.ReadSingle(bytes, ref cursor),
            CurrentEngineRpm = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            AccelerationX = PacketFormatter.ReadSingle(bytes, ref cursor),
            AccelerationY = PacketFormatter.ReadSingle(bytes, ref cursor),
            AccelerationZ = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            VelocityX = PacketFormatter.ReadSingle(bytes, ref cursor),
            VelocityY = PacketFormatter.ReadSingle(bytes, ref cursor),
            VelocityZ = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            AngularVelocityX = PacketFormatter.ReadSingle(bytes, ref cursor),
            AngularVelocityY = PacketFormatter.ReadSingle(bytes, ref cursor),
            AngularVelocityZ = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            Yaw   = PacketFormatter.ReadSingle(bytes, ref cursor),
            Pitch = PacketFormatter.ReadSingle(bytes, ref cursor),
            Roll  = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            NormalizedSuspensionTravelFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            TireSlipRatioFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireSlipRatioFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireSlipRatioRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireSlipRatioRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            WheelRotationSpeedFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelRotationSpeedFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelRotationSpeedRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelRotationSpeedRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            WheelOnRumbleStripFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            WheelInPuddleDepthFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            SurfaceRumbleFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            SurfaceRumbleFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            SurfaceRumbleRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            SurfaceRumbleRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            TireSlipAngleFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireSlipAngleFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireSlipAngleRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireSlipAngleRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            TireCombinedSlipFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireCombinedSlipFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireCombinedSlipRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireCombinedSlipRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            SuspensionTravelMetersFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            CarId          = PacketFormatter.ReadInt32(bytes, ref cursor),
            CarClass       = PacketFormatter.ReadInt32(bytes, ref cursor),
            CarPi          = PacketFormatter.ReadInt32(bytes, ref cursor),
            DrivetrainType = PacketFormatter.ReadInt32(bytes, ref cursor),
            CylinderCount  = PacketFormatter.ReadInt32(bytes, ref cursor)
        };
    }
    
    public static ForzaDataOutDash DataOutDash(ref byte[] bytes) {
        var cursor = 0;
        
        return new() {
            IsRaceOn    = PacketFormatter.ReadInt32(bytes, ref cursor),
            TimestampMs = PacketFormatter.ReadUInt32(bytes, ref cursor),
            
            EngineMaxRpm     = PacketFormatter.ReadSingle(bytes, ref cursor),
            EngineIdleRpm    = PacketFormatter.ReadSingle(bytes, ref cursor),
            CurrentEngineRpm = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            AccelerationX = PacketFormatter.ReadSingle(bytes, ref cursor),
            AccelerationY = PacketFormatter.ReadSingle(bytes, ref cursor),
            AccelerationZ = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            Yaw   = PacketFormatter.ReadSingle(bytes, ref cursor),
            Pitch = PacketFormatter.ReadSingle(bytes, ref cursor),
            Roll  = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            VelocityX = PacketFormatter.ReadSingle(bytes, ref cursor),
            VelocityY = PacketFormatter.ReadSingle(bytes, ref cursor),
            VelocityZ = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            AngularVelocityX = PacketFormatter.ReadSingle(bytes, ref cursor),
            AngularVelocityY = PacketFormatter.ReadSingle(bytes, ref cursor),
            AngularVelocityZ = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            NormalizedSuspensionTravelFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            TireSlipRatioFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireSlipRatioFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireSlipRatioRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireSlipRatioRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            WheelRotationSpeedFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelRotationSpeedFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelRotationSpeedRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelRotationSpeedRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            WheelOnRumbleStripFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            WheelInPuddleDepthFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            SurfaceRumbleFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            SurfaceRumbleFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            SurfaceRumbleRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            SurfaceRumbleRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            TireSlipAngleFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireSlipAngleFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireSlipAngleRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireSlipAngleRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            TireCombinedSlipFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireCombinedSlipFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireCombinedSlipRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireCombinedSlipRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            SuspensionTravelMetersFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            CarId          = PacketFormatter.ReadInt32(bytes, ref cursor),
            CarClass       = PacketFormatter.ReadInt32(bytes, ref cursor),
            CarPi          = PacketFormatter.ReadInt32(bytes, ref cursor),
            DrivetrainType = PacketFormatter.ReadInt32(bytes, ref cursor),
            CylinderCount  = PacketFormatter.ReadInt32(bytes, ref cursor),
            
            PositionX = PacketFormatter.ReadSingle(bytes, ref cursor),
            PositionY = PacketFormatter.ReadSingle(bytes, ref cursor),
            PositionZ = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            Speed = PacketFormatter.ReadSingle(bytes, ref cursor),
            Power = PacketFormatter.ReadSingle(bytes, ref cursor),
            Torque = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            TireTempFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireTempFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireTempRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireTempRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            Boost = PacketFormatter.ReadSingle(bytes, ref cursor),
            Fuel = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            DistanceTraveled = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            BestLap = PacketFormatter.ReadSingle(bytes, ref cursor),
            LastLap = PacketFormatter.ReadSingle(bytes, ref cursor),
            CurrentLap = PacketFormatter.ReadSingle(bytes, ref cursor),
            CurrentRaceTime = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            LapNumber = PacketFormatter.ReadUInt16(bytes, ref cursor),
            RacePosition = PacketFormatter.ReadUInt8(bytes, ref cursor),
            
            Accel = PacketFormatter.ReadUInt8(bytes, ref cursor),
            Brake = PacketFormatter.ReadUInt8(bytes, ref cursor),
            Clutch = PacketFormatter.ReadUInt8(bytes, ref cursor),
            HandBrake = PacketFormatter.ReadUInt8(bytes, ref cursor),
            Gear = PacketFormatter.ReadUInt8(bytes, ref cursor),
            Steer = PacketFormatter.ReadInt8(bytes, ref cursor),
            
            NormalizedDrivingLine = PacketFormatter.ReadInt8(bytes, ref cursor),
            NormalizedAiBrakeDiff = PacketFormatter.ReadInt8(bytes, ref cursor),
            
            TireWearFl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireWearFr = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireWearRl = PacketFormatter.ReadSingle(bytes, ref cursor),
            TireWearRr = PacketFormatter.ReadSingle(bytes, ref cursor),
            
            TrackId = PacketFormatter.ReadInt32(bytes, ref cursor)
        };
    }
}