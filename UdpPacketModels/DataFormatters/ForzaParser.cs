using ForzaTelemetry.ForzaModels.DataOut;

namespace ForzaTelemetry.ForzaModels.DataFormatters;

public static class ForzaParser {
    public static bool IsRaceOn(this byte[] bytes) {
        ArgumentOutOfRangeException.ThrowIfLessThan(bytes.Length, 4, "Packet is to small to parse");

        return PacketParser.ParseInt32(bytes, 0) > 0;
    }
    
    public static ForzaDataOutSled DataOutSled(ref byte[] bytes) {
        var cursor = 0;
        
        return new() {
            IsRaceOn    = PacketParser.ReadInt32(bytes, ref cursor),
            TimestampMs = PacketParser.ReadUInt32(bytes, ref cursor),
            
            EngineMaxRpm     = PacketParser.ReadSingle(bytes, ref cursor),
            EngineIdleRpm    = PacketParser.ReadSingle(bytes, ref cursor),
            CurrentEngineRpm = PacketParser.ReadSingle(bytes, ref cursor),
            
            AccelerationX = PacketParser.ReadSingle(bytes, ref cursor),
            AccelerationY = PacketParser.ReadSingle(bytes, ref cursor),
            AccelerationZ = PacketParser.ReadSingle(bytes, ref cursor),
            
            VelocityX = PacketParser.ReadSingle(bytes, ref cursor),
            VelocityY = PacketParser.ReadSingle(bytes, ref cursor),
            VelocityZ = PacketParser.ReadSingle(bytes, ref cursor),
            
            AngularVelocityX = PacketParser.ReadSingle(bytes, ref cursor),
            AngularVelocityY = PacketParser.ReadSingle(bytes, ref cursor),
            AngularVelocityZ = PacketParser.ReadSingle(bytes, ref cursor),
            
            Yaw   = PacketParser.ReadSingle(bytes, ref cursor),
            Pitch = PacketParser.ReadSingle(bytes, ref cursor),
            Roll  = PacketParser.ReadSingle(bytes, ref cursor),
            
            NormalizedSuspensionTravelFl = PacketParser.ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelFr = PacketParser.ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelRl = PacketParser.ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            TireSlipRatioFl = PacketParser.ReadSingle(bytes, ref cursor),
            TireSlipRatioFr = PacketParser.ReadSingle(bytes, ref cursor),
            TireSlipRatioRl = PacketParser.ReadSingle(bytes, ref cursor),
            TireSlipRatioRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            WheelRotationSpeedFl = PacketParser.ReadSingle(bytes, ref cursor),
            WheelRotationSpeedFr = PacketParser.ReadSingle(bytes, ref cursor),
            WheelRotationSpeedRl = PacketParser.ReadSingle(bytes, ref cursor),
            WheelRotationSpeedRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            WheelOnRumbleStripFl = PacketParser.ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripFr = PacketParser.ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripRl = PacketParser.ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            WheelInPuddleDepthFl = PacketParser.ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthFr = PacketParser.ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthRl = PacketParser.ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            SurfaceRumbleFl = PacketParser.ReadSingle(bytes, ref cursor),
            SurfaceRumbleFr = PacketParser.ReadSingle(bytes, ref cursor),
            SurfaceRumbleRl = PacketParser.ReadSingle(bytes, ref cursor),
            SurfaceRumbleRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            TireSlipAngleFl = PacketParser.ReadSingle(bytes, ref cursor),
            TireSlipAngleFr = PacketParser.ReadSingle(bytes, ref cursor),
            TireSlipAngleRl = PacketParser.ReadSingle(bytes, ref cursor),
            TireSlipAngleRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            TireCombinedSlipFl = PacketParser.ReadSingle(bytes, ref cursor),
            TireCombinedSlipFr = PacketParser.ReadSingle(bytes, ref cursor),
            TireCombinedSlipRl = PacketParser.ReadSingle(bytes, ref cursor),
            TireCombinedSlipRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            SuspensionTravelMetersFl = PacketParser.ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersFr = PacketParser.ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersRl = PacketParser.ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            CarId          = PacketParser.ReadInt32(bytes, ref cursor),
            CarClass       = PacketParser.ReadInt32(bytes, ref cursor),
            CarPi          = PacketParser.ReadInt32(bytes, ref cursor),
            DrivetrainType = PacketParser.ReadInt32(bytes, ref cursor),
            CylinderCount  = PacketParser.ReadInt32(bytes, ref cursor)
        };
    }
    
    public static ForzaDataOutDash DataOutDash(ref byte[] bytes) {
        var cursor = 0;
        
        return new() {
            IsRaceOn    = PacketParser.ReadInt32(bytes, ref cursor),
            TimestampMs = PacketParser.ReadUInt32(bytes, ref cursor),
            
            EngineMaxRpm     = PacketParser.ReadSingle(bytes, ref cursor),
            EngineIdleRpm    = PacketParser.ReadSingle(bytes, ref cursor),
            CurrentEngineRpm = PacketParser.ReadSingle(bytes, ref cursor),
            
            AccelerationX = PacketParser.ReadSingle(bytes, ref cursor),
            AccelerationY = PacketParser.ReadSingle(bytes, ref cursor),
            AccelerationZ = PacketParser.ReadSingle(bytes, ref cursor),
            
            Yaw   = PacketParser.ReadSingle(bytes, ref cursor),
            Pitch = PacketParser.ReadSingle(bytes, ref cursor),
            Roll  = PacketParser.ReadSingle(bytes, ref cursor),
            
            VelocityX = PacketParser.ReadSingle(bytes, ref cursor),
            VelocityY = PacketParser.ReadSingle(bytes, ref cursor),
            VelocityZ = PacketParser.ReadSingle(bytes, ref cursor),
            
            AngularVelocityX = PacketParser.ReadSingle(bytes, ref cursor),
            AngularVelocityY = PacketParser.ReadSingle(bytes, ref cursor),
            AngularVelocityZ = PacketParser.ReadSingle(bytes, ref cursor),
            
            NormalizedSuspensionTravelFl = PacketParser.ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelFr = PacketParser.ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelRl = PacketParser.ReadSingle(bytes, ref cursor),
            NormalizedSuspensionTravelRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            TireSlipRatioFl = PacketParser.ReadSingle(bytes, ref cursor),
            TireSlipRatioFr = PacketParser.ReadSingle(bytes, ref cursor),
            TireSlipRatioRl = PacketParser.ReadSingle(bytes, ref cursor),
            TireSlipRatioRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            WheelRotationSpeedFl = PacketParser.ReadSingle(bytes, ref cursor),
            WheelRotationSpeedFr = PacketParser.ReadSingle(bytes, ref cursor),
            WheelRotationSpeedRl = PacketParser.ReadSingle(bytes, ref cursor),
            WheelRotationSpeedRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            WheelOnRumbleStripFl = PacketParser.ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripFr = PacketParser.ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripRl = PacketParser.ReadSingle(bytes, ref cursor),
            WheelOnRumbleStripRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            WheelInPuddleDepthFl = PacketParser.ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthFr = PacketParser.ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthRl = PacketParser.ReadSingle(bytes, ref cursor),
            WheelInPuddleDepthRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            SurfaceRumbleFl = PacketParser.ReadSingle(bytes, ref cursor),
            SurfaceRumbleFr = PacketParser.ReadSingle(bytes, ref cursor),
            SurfaceRumbleRl = PacketParser.ReadSingle(bytes, ref cursor),
            SurfaceRumbleRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            TireSlipAngleFl = PacketParser.ReadSingle(bytes, ref cursor),
            TireSlipAngleFr = PacketParser.ReadSingle(bytes, ref cursor),
            TireSlipAngleRl = PacketParser.ReadSingle(bytes, ref cursor),
            TireSlipAngleRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            TireCombinedSlipFl = PacketParser.ReadSingle(bytes, ref cursor),
            TireCombinedSlipFr = PacketParser.ReadSingle(bytes, ref cursor),
            TireCombinedSlipRl = PacketParser.ReadSingle(bytes, ref cursor),
            TireCombinedSlipRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            SuspensionTravelMetersFl = PacketParser.ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersFr = PacketParser.ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersRl = PacketParser.ReadSingle(bytes, ref cursor),
            SuspensionTravelMetersRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            CarId          = PacketParser.ReadInt32(bytes, ref cursor),
            CarClass       = PacketParser.ReadInt32(bytes, ref cursor),
            CarPi          = PacketParser.ReadInt32(bytes, ref cursor),
            DrivetrainType = PacketParser.ReadInt32(bytes, ref cursor),
            CylinderCount  = PacketParser.ReadInt32(bytes, ref cursor),
            
            PositionX = PacketParser.ReadSingle(bytes, ref cursor),
            PositionY = PacketParser.ReadSingle(bytes, ref cursor),
            PositionZ = PacketParser.ReadSingle(bytes, ref cursor),
            
            Speed = PacketParser.ReadSingle(bytes, ref cursor),
            Power = PacketParser.ReadSingle(bytes, ref cursor),
            Torque = PacketParser.ReadSingle(bytes, ref cursor),
            
            TireTempFl = PacketParser.ReadSingle(bytes, ref cursor),
            TireTempFr = PacketParser.ReadSingle(bytes, ref cursor),
            TireTempRl = PacketParser.ReadSingle(bytes, ref cursor),
            TireTempRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            Boost = PacketParser.ReadSingle(bytes, ref cursor),
            Fuel = PacketParser.ReadSingle(bytes, ref cursor),
            
            DistanceTraveled = PacketParser.ReadSingle(bytes, ref cursor),
            
            BestLap = PacketParser.ReadSingle(bytes, ref cursor),
            LastLap = PacketParser.ReadSingle(bytes, ref cursor),
            CurrentLap = PacketParser.ReadSingle(bytes, ref cursor),
            CurrentRaceTime = PacketParser.ReadSingle(bytes, ref cursor),
            
            LapNumber = PacketParser.ReadUInt16(bytes, ref cursor),
            RacePosition = PacketParser.ReadUInt8(bytes, ref cursor),
            
            Accel = PacketParser.ReadUInt8(bytes, ref cursor),
            Brake = PacketParser.ReadUInt8(bytes, ref cursor),
            Clutch = PacketParser.ReadUInt8(bytes, ref cursor),
            HandBrake = PacketParser.ReadUInt8(bytes, ref cursor),
            Gear = PacketParser.ReadUInt8(bytes, ref cursor),
            Steer = PacketParser.ReadInt8(bytes, ref cursor),
            
            NormalizedDrivingLine = PacketParser.ReadInt8(bytes, ref cursor),
            NormalizedAiBrakeDiff = PacketParser.ReadInt8(bytes, ref cursor),
            
            TireWearFl = PacketParser.ReadSingle(bytes, ref cursor),
            TireWearFr = PacketParser.ReadSingle(bytes, ref cursor),
            TireWearRl = PacketParser.ReadSingle(bytes, ref cursor),
            TireWearRr = PacketParser.ReadSingle(bytes, ref cursor),
            
            TrackId = PacketParser.ReadInt32(bytes, ref cursor)
        };
    }
}