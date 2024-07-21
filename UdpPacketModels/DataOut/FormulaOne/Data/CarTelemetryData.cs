namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Data;

public record CarTelemetryData(
    ushort Speed,
    float Throttle,
    float Steer,
    float Brake,
    byte Clutch,
    sbyte Gear,
    ushort EngineRpm,
    byte Drs,
    byte RevLightsPercent,
    byte RevLightsBitValue,
    ushort[] BrakesTemperature,
    byte[] TyresSurfaceTemperature,
    byte[] TyresInnerTemperature,
    ushort EngineTemperature,
    float[] TyresPressure,
    byte[] SurfaceType);