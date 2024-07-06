namespace UdpListenerService.UdpSettings;

public sealed class ForzaUdpSettings {
    public byte[] IpAddress { get; } = [];
    public int Port { get; init; }
    public int PacketSize { get; init; }
}