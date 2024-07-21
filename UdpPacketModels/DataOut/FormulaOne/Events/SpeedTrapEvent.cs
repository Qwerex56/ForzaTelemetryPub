namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Events;

public record SpeedTrapEvent(
    byte VehicleIdx,
    float Speed,
    byte IsOverallFastestInSession,
    byte IsDriverFastestInSession,
    byte FastestVehicleIdxInSession,
    float FastestSpeedInSession);