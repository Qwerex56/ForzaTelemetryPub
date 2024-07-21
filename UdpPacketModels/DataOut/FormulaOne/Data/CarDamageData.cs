namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Data;

public record CarDamageData(
    float[] TyresWear,
    byte[] TyresDamage,
    byte[] BrakesDamage,
    byte FrontLeftWingDamage,
    byte FrontRightWingDamage,
    byte RearWingDamage,
    byte FloorDamage,
    byte DiffuserDamage,
    byte SidePodDamage,
    byte DrsFault,
    byte ErsFault,
    byte GearBoxDamage,
    byte EngineDamage,
    byte EngineMguhWear,
    byte EngineEsWear,
    byte EngineCeWear,
    byte EngineIceWear,
    byte EngineMgukWear,
    byte EngineTcWear,
    byte EngineBlown,
    byte EngineSeized);