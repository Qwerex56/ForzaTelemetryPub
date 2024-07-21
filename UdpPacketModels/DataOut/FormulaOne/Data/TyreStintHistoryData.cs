namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Data;

public record TyreStintHistoryData(
    byte EndLap,
    byte TyreActualCompound,
    byte TyreVisualCompound);