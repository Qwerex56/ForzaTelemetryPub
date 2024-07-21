namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Data;

public record SessionHistoryData(
    uint LapTimeInMs,
    ushort Sector1TimeInMs,
    ushort Sector2TimeInMs,
    ushort Sector3TimeInMs,
    byte LapValidBitFlags);