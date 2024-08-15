using ForzaTelemetry.ForzaModels.DataOut.Interfaces;
using ForzaTelemetry.ForzaModels.RaceDataModels;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace ForzaTelemetry.ForzaModels.DataOut.ForzaMotorsport;

public class Fm8DataOutDash : IDataOut {
    public int IsRaceOn { get; init; }
    public uint SessionTimeMs { get; init; }
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

    public float PositionX { get; init; }
    public float PositionY { get; init; }
    public float PositionZ { get; init; }

    public float Speed { get; init; }
    public float Power { get; init; }
    public float Torque { get; init; }

    public float TireTemperatureFl { get; init; }
    public float TireTemperatureFr { get; init; }
    public float TireTemperatureRl { get; init; }
    public float TireTemperatureRr { get; init; }

    public float Boost { get; init; }
    public float Fuel { get; init; }

    public float DistanceTraveled { get; init; }

    public float BestLap { get; init; }
    public float LastLap { get; init; }
    public float CurrentLap { get; init; }
    public float CurrentRaceTime { get; init; }

    public ushort LapNumber { get; init; }
    public byte RacePosition { get; init; }

    public byte Throttle { get; init; }
    public byte Brake { get; init; }
    public byte Clutch { get; init; }
    public byte HandBrake { get; init; }
    public byte Gear { get; init; }
    public sbyte Steer { get; init; }

    public sbyte NormalizedDrivingLine { get; init; }
    public sbyte NormalizedAiBrakeDiff { get; init; }

    public float TireWearFl { get; init; }
    public float TireWearFr { get; init; }
    public float TireWearRl { get; init; }
    public float TireWearRr { get; init; }

    public int TrackId { get; init; }

    public CarMotionDataSample GetCarMotionData() => new(
        WorldPosition: new(PositionX, PositionY, PositionZ),
        Acceleration: new(AccelerationX, AccelerationY, AccelerationY),
        Velocity: new(VelocityX, VelocityY, VelocityZ),
        AngularVelocity: new(AngularVelocityX, AngularVelocityY, AngularVelocityZ),
        Yaw, Pitch, Roll,
        null, null, null
    );

    public CarTelemetryDataSample GetCarTelemetryData() => new(
        (ushort)Speed,
        (float)Throttle,
        (float)Steer,
        (float)Brake,
        (byte)Clutch,
        (sbyte)Gear,
        (ushort?)CurrentEngineRpm
    );

    public LapDataSample GetLapData() => new(
        DistanceTraveled,
        BestLap,
        LastLap,
        CurrentLap,
        CurrentRaceTime,
        LapNumber,
        RacePosition);

    public StintDataSample GetStintData() => new(
        null,
        (byte)LapNumber
    );

    public TireDataSample GetTiresData() => new(
        [
            TireSlipRatioFl,
            TireSlipRatioFr,
            TireSlipRatioRl,
            TireSlipRatioRr,
        ],
        [
            TireSlipAngleFl,
            TireSlipAngleFr,
            TireSlipAngleRl,
            TireSlipAngleRr,
        ],
        [
            TireCombinedSlipFl,
            TireCombinedSlipFr,
            TireCombinedSlipRl,
            TireCombinedSlipRr,
        ],
        [
            TireTemperatureFl,
            TireTemperatureFr,
            TireTemperatureRl,
            TireTemperatureRr,
        ],
        [
            TireWearFl,
            TireWearFr,
            TireWearRl,
            TireWearRr
        ]
    );

    public TrackDataSample GetTrackData() => new(
        TrackId,
        null,
        SessionTimeMs,
        LapNumber
    );

    public WheelDataSample GetWheelsData() => new(
        [
            WheelRotationSpeedFl,
            WheelRotationSpeedFr,
            WheelRotationSpeedRl,
            WheelRotationSpeedRr,
        ],
        [
            WheelOnRumbleStripFl,
            WheelOnRumbleStripFr,
            WheelOnRumbleStripRl,
            WheelOnRumbleStripRr,
        ],
        [
            WheelInPuddleDepthFl,
            WheelInPuddleDepthFr,
            WheelInPuddleDepthRl,
            WheelInPuddleDepthRr
        ]
    );
}