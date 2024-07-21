namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Data;

public record FinalClassificationData(
    byte Position,
    byte NumLaps,
    byte GridPosition,
    byte Points,
    byte NumPitStops,
    byte ResultStatus,
    uint BestLapTimeInMs,
    double TotalRaceTime,
    byte PenaltiesTime,
    byte NumPenalties,
    byte NumTyreStints,
    byte[] TyreStintsActual,
    byte[] TyreStintsVisual,
    byte[] TyreStintsEndLaps);