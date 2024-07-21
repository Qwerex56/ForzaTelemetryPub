using ForzaTelemetry.ForzaModels.RaceDataModels.Enums;

namespace ForzaTelemetry.ForzaModels.RaceDataModels.Interfaces;

public interface IRaceData {
    RacingGameTitleEnum GameTitle { get; init; }
};