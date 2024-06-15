using System.Net;
using System.Net.Sockets;
using ForzaTelemetry.ForzaModels.DataFormatters;
using ForzaTelemetry.ForzaModels.DataOut;
using UdpListenerService.Interfaces;
namespace UdpListenerService.Listeners;

public class FmFhListener : IPacketFormatter<ForzaParser>, IDbPacketFormatter {
    private int _packetSize;

    private IPAddress _ipAddress;
    private int _port;

    private ForzaDataOutDash _fmDataDash;

    public UdpClient UdpClientListener { get; set; }

    public Task StartAsync(CancellationToken cancellationToken) {
        // Setup basic information, base for forza motorsport/horizon
        _packetSize = 351;
        _ipAddress = IPAddress.Parse("127.0.0.1");
        _port = 5371;
        
        UdpClientListener = new(_port);

        try {
            UdpClientListener.Connect(_ipAddress, _port);
        } catch (SocketException e) {
            Console.WriteLine("Check your IP format.");
            Console.WriteLine(e);

            throw;
        }

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken) {
        UdpClientListener.Close();
        throw new NotImplementedException();
    }

    public async void StartListening(CancellationToken cancellationToken) {
        while (!cancellationToken.IsCancellationRequested) {
            break;
        }
        
        throw new NotImplementedException();
    }

    public async Task StartListeningAsync(CancellationToken cancellationToken) {
        while (!cancellationToken.IsCancellationRequested) {
            var result = await UdpClientListener.ReceiveAsync(cancellationToken);

            var buffer = result.Buffer;
            var bufferSize = result.Buffer.Length;
            
            // Packet is not valid
            if (!ValidatePacket()) {
                // break from loop, next packets will probably be invalid
                break;
            }
            
            FormatPacket(in buffer);

            if (_fmDataDash.IsRaceOn == 0) {
                await Task.Delay(16, cancellationToken);
                continue;
            }
            
            BuildObjects();
        }

        throw new NotImplementedException();
    }
    
    public void StopListening(CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }

    public Task StopListeningAsync(CancellationToken cancellationToken) =>
        throw new NotImplementedException();

    public bool SetListeningPort(int port) =>
        throw new NotImplementedException();

    public bool SetListeningPort(string port) =>
        throw new NotImplementedException();

    public bool SetIpAddressEndpoint(IPEndPoint endPoint) =>
        throw new NotImplementedException();

    public bool SetIpAddressEndpoint(long ip, int port) =>
        throw new NotImplementedException();

    public bool SetIpAddressEndpoint(string ip, int port) =>
        throw new NotImplementedException();

    public void FormatPacket(in byte[] bytes) {
        _fmDataDash = new();
    }

    public bool ValidatePacket() {
        throw new NotImplementedException();
    }

    public void BuildObjects() {
        throw new NotImplementedException();
    }

    public object TiresTemperatures() =>
        throw new NotImplementedException();

    public object TiresWear() =>
        throw new NotImplementedException();

    public object LapData() =>
        throw new NotImplementedException();

    public object ControlData() =>
        throw new NotImplementedException();

    public object RetrieveVelocities() =>
        throw new NotImplementedException();

    public object RetrieveAccelerations() =>
        throw new NotImplementedException();

    public object RetrieveWheelData() =>
        throw new NotImplementedException();

    public bool ConnectToRemoteDataBase() =>
        throw new NotImplementedException();

    public bool ConnectToLocalDataBase() =>
        throw new NotImplementedException();
}