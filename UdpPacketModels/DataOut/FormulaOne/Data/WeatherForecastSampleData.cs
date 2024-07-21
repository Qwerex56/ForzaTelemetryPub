namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Data;

public record WeatherForecastSampleData(
    byte SessionType,
    byte TimeOffset,
    byte Weather,
    sbyte TrackTemperature,
    sbyte TrackTemperatureChange,
    sbyte AirTemperature,
    sbyte AirTemperatureChange,
    byte RainPercentage);