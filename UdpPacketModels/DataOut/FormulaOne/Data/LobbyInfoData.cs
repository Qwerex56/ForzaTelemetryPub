namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Data;

public record LobbyInfoData(
    byte AiControlled,
    byte TeamId,
    byte Nationality,
    string Name,
    byte CarNumber,
    byte ReadyStatus);