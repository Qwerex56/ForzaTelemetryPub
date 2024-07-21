namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Data;

public record CarMotionData(
    float WorldPositionX,
    float WorldPositionY,
    float WorldPositionZ,
    float WorldVelocityX,
    float WorldVelocityY,
    float WorldVelocityZ,
    short WorldForwardDirX,
    short WorldForwardDirY,
    short WorldForwardDirZ,
    short WorldRightDirX,
    short WorldRightDirY,
    short WorldRightDirZ,
    float GForceLateral,
    float GForceLongitudinal,
    float GForceVertical,
    float Yaw,
    float Pitch,
    float Roll);