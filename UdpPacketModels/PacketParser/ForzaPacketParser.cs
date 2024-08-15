using ForzaTelemetry.ForzaModels.DataOut;
using ForzaTelemetry.ForzaModels.DataOut.ForzaMotorsport;
using ForzaTelemetry.ForzaModels.Extensions;

namespace ForzaTelemetry.ForzaModels.PacketParser;

public static class ForzaPacketParser {
    public static bool IsRaceOn(byte[] bytes) {
        ArgumentOutOfRangeException.ThrowIfLessThan(bytes.Length, 4, "Packet is to small to parse");

        return bytes.ParseInt32(0) > 0;
    }
    
    public static Fm8DataOutSled DataOutSled(ref byte[] bytes) {
        var cursor = 0;
        
        return new() {
            IsRaceOn    = bytes.ReadInt32(ref cursor),
            TimestampMs = bytes.ReadUInt32(ref cursor),
            
            EngineMaxRpm     = bytes.ReadSingle(ref cursor),
            EngineIdleRpm    = bytes.ReadSingle(ref cursor),
            CurrentEngineRpm = bytes.ReadSingle(ref cursor),
            
            AccelerationX = bytes.ReadSingle(ref cursor),
            AccelerationY = bytes.ReadSingle(ref cursor),
            AccelerationZ = bytes.ReadSingle(ref cursor),
            
            VelocityX = bytes.ReadSingle(ref cursor),
            VelocityY = bytes.ReadSingle(ref cursor),
            VelocityZ = bytes.ReadSingle(ref cursor),
            
            AngularVelocityX = bytes.ReadSingle(ref cursor),
            AngularVelocityY = bytes.ReadSingle(ref cursor),
            AngularVelocityZ = bytes.ReadSingle(ref cursor),
            
            Yaw   = bytes.ReadSingle(ref cursor),
            Pitch = bytes.ReadSingle(ref cursor),
            Roll  = bytes.ReadSingle(ref cursor),
            
            NormalizedSuspensionTravelFl = bytes.ReadSingle(ref cursor),
            NormalizedSuspensionTravelFr = bytes.ReadSingle(ref cursor),
            NormalizedSuspensionTravelRl = bytes.ReadSingle(ref cursor),
            NormalizedSuspensionTravelRr = bytes.ReadSingle(ref cursor),
            
            TireSlipRatioFl = bytes.ReadSingle(ref cursor),
            TireSlipRatioFr = bytes.ReadSingle(ref cursor),
            TireSlipRatioRl = bytes.ReadSingle(ref cursor),
            TireSlipRatioRr = bytes.ReadSingle(ref cursor),
            
            WheelRotationSpeedFl = bytes.ReadSingle(ref cursor),
            WheelRotationSpeedFr = bytes.ReadSingle(ref cursor),
            WheelRotationSpeedRl = bytes.ReadSingle(ref cursor),
            WheelRotationSpeedRr = bytes.ReadSingle(ref cursor),
            
            WheelOnRumbleStripFl = bytes.ReadSingle(ref cursor),
            WheelOnRumbleStripFr = bytes.ReadSingle(ref cursor),
            WheelOnRumbleStripRl = bytes.ReadSingle(ref cursor),
            WheelOnRumbleStripRr = bytes.ReadSingle(ref cursor),
            
            WheelInPuddleDepthFl = bytes.ReadSingle(ref cursor),
            WheelInPuddleDepthFr = bytes.ReadSingle(ref cursor),
            WheelInPuddleDepthRl = bytes.ReadSingle(ref cursor),
            WheelInPuddleDepthRr = bytes.ReadSingle(ref cursor),
            
            SurfaceRumbleFl = bytes.ReadSingle(ref cursor),
            SurfaceRumbleFr = bytes.ReadSingle(ref cursor),
            SurfaceRumbleRl = bytes.ReadSingle(ref cursor),
            SurfaceRumbleRr = bytes.ReadSingle(ref cursor),
            
            TireSlipAngleFl = bytes.ReadSingle(ref cursor),
            TireSlipAngleFr = bytes.ReadSingle(ref cursor),
            TireSlipAngleRl = bytes.ReadSingle(ref cursor),
            TireSlipAngleRr = bytes.ReadSingle(ref cursor),
            
            TireCombinedSlipFl = bytes.ReadSingle(ref cursor),
            TireCombinedSlipFr = bytes.ReadSingle(ref cursor),
            TireCombinedSlipRl = bytes.ReadSingle(ref cursor),
            TireCombinedSlipRr = bytes.ReadSingle(ref cursor),
            
            SuspensionTravelMetersFl = bytes.ReadSingle(ref cursor),
            SuspensionTravelMetersFr = bytes.ReadSingle(ref cursor),
            SuspensionTravelMetersRl = bytes.ReadSingle(ref cursor),
            SuspensionTravelMetersRr = bytes.ReadSingle(ref cursor),
            
            CarId          = bytes.ReadInt32(ref cursor),
            CarClass       = bytes.ReadInt32(ref cursor),
            CarPi          = bytes.ReadInt32(ref cursor),
            DrivetrainType = bytes.ReadInt32(ref cursor),
            CylinderCount  = bytes.ReadInt32(ref cursor)
        };
    }
    
    public static Fm8DataOutDash DataOutDash(in byte[] bytes) {
        var cursor = 0;
        
        return new() {
            IsRaceOn    = bytes.ReadInt32(ref cursor),
            SessionTimeMs = bytes.ReadUInt32(ref cursor),
            
            EngineMaxRpm     = bytes.ReadSingle(ref cursor),
            EngineIdleRpm    = bytes.ReadSingle(ref cursor),
            CurrentEngineRpm = bytes.ReadSingle(ref cursor),
            
            AccelerationX = bytes.ReadSingle(ref cursor),
            AccelerationY = bytes.ReadSingle(ref cursor),
            AccelerationZ = bytes.ReadSingle(ref cursor),
            
            Yaw   = bytes.ReadSingle(ref cursor),
            Pitch = bytes.ReadSingle(ref cursor),
            Roll  = bytes.ReadSingle(ref cursor),
            
            VelocityX = bytes.ReadSingle(ref cursor),
            VelocityY = bytes.ReadSingle(ref cursor),
            VelocityZ = bytes.ReadSingle(ref cursor),
            
            AngularVelocityX = bytes.ReadSingle(ref cursor),
            AngularVelocityY = bytes.ReadSingle(ref cursor),
            AngularVelocityZ = bytes.ReadSingle(ref cursor),
            
            NormalizedSuspensionTravelFl = bytes.ReadSingle(ref cursor),
            NormalizedSuspensionTravelFr = bytes.ReadSingle(ref cursor),
            NormalizedSuspensionTravelRl = bytes.ReadSingle(ref cursor),
            NormalizedSuspensionTravelRr = bytes.ReadSingle(ref cursor),
            
            TireSlipRatioFl = bytes.ReadSingle(ref cursor),
            TireSlipRatioFr = bytes.ReadSingle(ref cursor),
            TireSlipRatioRl = bytes.ReadSingle(ref cursor),
            TireSlipRatioRr = bytes.ReadSingle(ref cursor),
            
            WheelRotationSpeedFl = bytes.ReadSingle(ref cursor),
            WheelRotationSpeedFr = bytes.ReadSingle(ref cursor),
            WheelRotationSpeedRl = bytes.ReadSingle(ref cursor),
            WheelRotationSpeedRr = bytes.ReadSingle(ref cursor),
            
            WheelOnRumbleStripFl = bytes.ReadSingle(ref cursor),
            WheelOnRumbleStripFr = bytes.ReadSingle(ref cursor),
            WheelOnRumbleStripRl = bytes.ReadSingle(ref cursor),
            WheelOnRumbleStripRr = bytes.ReadSingle(ref cursor),
            
            WheelInPuddleDepthFl = bytes.ReadSingle(ref cursor),
            WheelInPuddleDepthFr = bytes.ReadSingle(ref cursor),
            WheelInPuddleDepthRl = bytes.ReadSingle(ref cursor),
            WheelInPuddleDepthRr = bytes.ReadSingle(ref cursor),
            
            SurfaceRumbleFl = bytes.ReadSingle(ref cursor),
            SurfaceRumbleFr = bytes.ReadSingle(ref cursor),
            SurfaceRumbleRl = bytes.ReadSingle(ref cursor),
            SurfaceRumbleRr = bytes.ReadSingle(ref cursor),
            
            TireSlipAngleFl = bytes.ReadSingle(ref cursor),
            TireSlipAngleFr = bytes.ReadSingle(ref cursor),
            TireSlipAngleRl = bytes.ReadSingle(ref cursor),
            TireSlipAngleRr = bytes.ReadSingle(ref cursor),
            
            TireCombinedSlipFl = bytes.ReadSingle(ref cursor),
            TireCombinedSlipFr = bytes.ReadSingle(ref cursor),
            TireCombinedSlipRl = bytes.ReadSingle(ref cursor),
            TireCombinedSlipRr = bytes.ReadSingle(ref cursor),
            
            SuspensionTravelMetersFl = bytes.ReadSingle(ref cursor),
            SuspensionTravelMetersFr = bytes.ReadSingle(ref cursor),
            SuspensionTravelMetersRl = bytes.ReadSingle(ref cursor),
            SuspensionTravelMetersRr = bytes.ReadSingle(ref cursor),
            
            CarId          = bytes.ReadInt32(ref cursor),
            CarClass       = bytes.ReadInt32(ref cursor),
            CarPi          = bytes.ReadInt32(ref cursor),
            DrivetrainType = bytes.ReadInt32(ref cursor),
            CylinderCount  = bytes.ReadInt32(ref cursor),
            
            PositionX = bytes.ReadSingle(ref cursor),
            PositionY = bytes.ReadSingle(ref cursor),
            PositionZ = bytes.ReadSingle(ref cursor),
            
            Speed = bytes.ReadSingle(ref cursor),
            Power = bytes.ReadSingle(ref cursor),
            Torque = bytes.ReadSingle(ref cursor),
            
            TireTemperatureFl = bytes.ReadSingle(ref cursor),
            TireTemperatureFr = bytes.ReadSingle(ref cursor),
            TireTemperatureRl = bytes.ReadSingle(ref cursor),
            TireTemperatureRr = bytes.ReadSingle(ref cursor),
            
            Boost = bytes.ReadSingle(ref cursor),
            Fuel = bytes.ReadSingle(ref cursor),
            
            DistanceTraveled = bytes.ReadSingle(ref cursor),
            
            BestLap = bytes.ReadSingle(ref cursor),
            LastLap = bytes.ReadSingle(ref cursor),
            CurrentLap = bytes.ReadSingle(ref cursor),
            CurrentRaceTime = bytes.ReadSingle(ref cursor),
            
            LapNumber = bytes.ReadUInt16(ref cursor),
            RacePosition = bytes.ReadUInt8(ref cursor),
            
            Throttle = bytes.ReadUInt8(ref cursor),
            Brake = bytes.ReadUInt8(ref cursor),
            Clutch = bytes.ReadUInt8(ref cursor),
            HandBrake = bytes.ReadUInt8(ref cursor),
            Gear = bytes.ReadUInt8(ref cursor),
            Steer = bytes.ReadInt8(ref cursor),
            
            NormalizedDrivingLine = bytes.ReadInt8(ref cursor),
            NormalizedAiBrakeDiff = bytes.ReadInt8(ref cursor),
            
            TireWearFl = bytes.ReadSingle(ref cursor),
            TireWearFr = bytes.ReadSingle(ref cursor),
            TireWearRl = bytes.ReadSingle(ref cursor),
            TireWearRr = bytes.ReadSingle(ref cursor),
            
            TrackId = bytes.ReadInt32(ref cursor)
        };
    }
}