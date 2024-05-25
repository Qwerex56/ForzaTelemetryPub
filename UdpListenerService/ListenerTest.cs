using System.Net;
using System.Net.Sockets;
using ForzaTelemetry.ForzaModels.DataFormatters;
using ForzaTelemetry.ForzaModels.DataOut;

namespace UdpListenerService;

public class ListenerTest(ILogger<ListenerTest> logger) : BackgroundService {
    private const int Delay = (int)(1f / 60 * 1000);

    private static IPEndPoint _endPoint = new(IPAddress.Parse("192.168.0.255"), 8080);

    private readonly UdpClient _udpClient = new(8080);

    public ForzaDataOutDash LastPacket { get; set; } = new();

    protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
        while (!stoppingToken.IsCancellationRequested) {
            var bytes = _udpClient.Receive(ref _endPoint);

            if (!bytes.IsRaceOn()) continue;

            var packet = ForzaFormatter.DataOutDash(ref bytes);
            
            if (packet.LapNumber <= LastPacket.LapNumber) continue;

            LastPacket = packet;
            
            
        }
    }
}