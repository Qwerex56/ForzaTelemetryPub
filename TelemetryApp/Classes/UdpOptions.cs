// ReSharper disable PropertyCanBeMadeInitOnly.Global

namespace TelemetryApp.Classes;

public sealed record UdpOptions {
    public const string ForzaConnection = "UdpOptions:ForzaMotorsport";
    public const string FormulaConnection = "UdpOptions:Formula1";
    
    public string IpAddress { get; set; } = string.Empty;
    public int Port { get; set; } = 0;
    public int[] PacketSizes { get; set; } = [];
}