namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Events;

public record FastestLapEvent(
    byte VehicleIdx,
    float LapTimeInSec);