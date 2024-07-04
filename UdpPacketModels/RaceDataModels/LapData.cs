namespace ForzaTelemetry.ForzaModels.RaceDataModels;

public record LapData(float? DistanceTraveled,
                      float? BestLapTime,
                      float? LastLapTime,
                      float? CurrentLapTime,
                      float? RaceTime,
                      ushort? LapNumber,
                      byte? CurrentPosition);