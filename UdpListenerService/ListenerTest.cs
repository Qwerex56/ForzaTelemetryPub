using System.Net;
using System.Net.Sockets;
using ForzaTelemetry.ForzaModels.DataFormatters;
using ForzaTelemetry.ForzaModels.DataOut;
using UdpDbModels;

namespace UdpListenerService;

public sealed class ListenerTest(ILogger<ListenerTest> logger)
    : BackgroundService {
    private const int Delay = (int)(1f / 60 * 1000);

    private static IPEndPoint EndPoint = new(IPAddress.Parse("192.168.0.255"), 8080);

    private readonly UdpClient _udpClient = new(8080);

    public ForzaDataOutDash LastPacket { get; set; } = new();

    public event Action? OnPacketSend;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
        // _udpClient.Connect(EndPoint);

        while (!stoppingToken.IsCancellationRequested && false) {
            // var result = await _udpClient.ReceiveAsync(stoppingToken);
            // var buffer = result.Buffer;
            var buffer = _udpClient.Receive(ref EndPoint);

            if (!buffer.IsRaceOn()) {
                await Task.Delay(Delay, stoppingToken);

                continue;
            }

            var packet = ForzaFormatter.DataOutDash(ref buffer);

            if (packet.LapNumber <= LastPacket.LapNumber) continue;

            if (logger.IsEnabled(LogLevel.Information)) {
                logger.LogInformation($"Current: {packet.LapNumber}, Last: {LastPacket.LapNumber}");
            }

            LastPacket = packet;
            // await using var dbContext = new TelemetryDbContext();
            //
            // var lap = new LapData {
            //     Id = packet.LapNumber,
            //     TrackId = packet.TrackId,
            //     CarId = packet.CarId,
            //     LapTime = packet.CurrentLap
            // };
            //
            // dbContext.LapData.Add(lap);
            // await dbContext.SaveChangesAsync(stoppingToken);
            OnPacketSend?.Invoke();
            await Task.Delay(Delay, stoppingToken);
        }
    }

    public override void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private void Dispose(bool disposing) {
        if (disposing) {
            _udpClient.Close();
        }
    }
}