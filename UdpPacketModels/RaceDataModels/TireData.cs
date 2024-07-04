namespace ForzaTelemetry.ForzaModels.RaceDataModels;

public record TireData(float SlipRatio,
                       float SlipAngle,
                       float CombinedSlip,
                       float Temperature,
                       float Wear);