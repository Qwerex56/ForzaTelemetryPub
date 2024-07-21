namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Events;

public record PenaltyEvent(
    byte PenaltyType,
    byte InfringementType,
    byte VehicleIdx,
    byte Time,
    byte LapNum,
    byte PlacesGaines);