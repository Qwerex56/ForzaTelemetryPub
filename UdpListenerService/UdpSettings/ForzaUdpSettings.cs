namespace UdpListenerService.UdpSettings;

public sealed class ForzaUdpSettings {
    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public byte[] IpAddress { get; init; } = [];
    public int Port { get; init; }
    public int PacketSize { get; init; }
}