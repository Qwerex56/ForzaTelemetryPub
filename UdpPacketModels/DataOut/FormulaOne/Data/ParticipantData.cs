namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Data;

public record ParticipantData(
    byte AiControlled,
    byte DriverId,
    byte NetworkId,
    byte TeamId,
    byte MyTeam,
    byte RaceNumber,
    byte Nationality,
    string Name,
    byte YourTelemetry);