using System.Net;
using System.Net.Sockets;
using ForzaTelemetry.ForzaModels.DataOut;
using UdpListenerService.Interfaces;

namespace UdpListenerService.Listeners;

public class FmFhListener : IListenerHostedService, IDbPacketFormatter, IDisposable {
    private readonly Task _completedTask = Task.CompletedTask;

    #region Events

    public event Action? OnPacketReceived = () => Console.WriteLine($"Hello, world!");
    public event Action? OnPacketAccepted = () => Console.WriteLine("Packet accepted");
    public event Action? OnPacketRejected = () => Console.WriteLine("Packet rejected");

    #endregion

    public bool IsListening { get; private set; }

    #region Packet

    private int _packetSize;
    private Fm8DataOutDash? _fmDataDash;

    #endregion

    #region Sockets

    public UdpClient UdpClientListener { get; set; }
    private IPAddress _ipAddress;
    private int _port;

    #endregion

    #region CancellationTokens

    private CancellationTokenSource _listenerTokenSource;
    private CancellationToken _listenerToken;

    #endregion

    public Task StartAsync(CancellationToken cancellationToken) {
        // TODO: Read user setting file or fetch them from db

        // Setup basic information, base for forza motorsport/horizon
        _packetSize = 331;
        _ipAddress = IPAddress.Any;
        _port = 8080;

        UdpClientListener = new(_port);

        try {
            UdpClientListener.Connect(_ipAddress, _port);
        } catch (SocketException) {
            Console.WriteLine("Check your IP format.");

            throw;
        }

        return _completedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken) {
        return _completedTask;
    }

    /// <summary>
    /// Starts listening on given port and address.
    /// Note that it doesn't set up udp server; This is done at startup in StartAsync() function.
    /// </summary>
    public void StartListening() {
        CreateCancellationToken();
        var endpoint = new IPEndPoint(_ipAddress, _port);

        IsListening = true;

        while (!_listenerToken.IsCancellationRequested) {
            var buffer = UdpClientListener.Receive(ref endpoint);
            var bufferSize = buffer.Length;

            if (!ValidatePacket(bufferSize)) continue;

            FormatPacket(in buffer);
            OnPacketReceived?.Invoke();
        }
    }

    public async Task StartListeningAsync() {
        CreateCancellationToken();

        var endpoint = new IPEndPoint(_ipAddress, _port);
        UdpClientListener.Connect(endpoint);

        while (!_listenerToken.IsCancellationRequested) {
            var result = await UdpClientListener.ReceiveAsync(_listenerToken);

            var buffer = result.Buffer;
            var bufferSize = result.Buffer.Length;

            // Packet is not valid
            if (!ValidatePacket(bufferSize)) continue;

            FormatPacket(in buffer);
            OnPacketReceived?.Invoke();
        }
    }

    public void StopListening() => _listenerTokenSource.Cancel();

    public async Task StopListeningAsync() => await _listenerTokenSource.CancelAsync();

    /// <summary>
    /// Changes default port, port can only be changed when the udp client is not listening.
    /// </summary>
    /// <param name="port">new port value.</param>
    /// <returns>true, if port has been changed successfully, false otherwise.</returns>
    public bool SetListeningPort(int port) {
        if (!_listenerTokenSource.IsCancellationRequested) return false;

        _port = port;

        return true;
    }

    public bool SetIpAddress(string address) {
        if (!_listenerTokenSource.IsCancellationRequested) return false;

        _ipAddress = IPAddress.Parse(address);

        return true;
    }

    public void FormatPacket(in byte[] bytes) {
        _fmDataDash = new();
    }

    /// <summary>
    /// Make check if a packet is long enough to be parsed.
    /// </summary>
    /// <param name="packetLength">Received packet length</param>
    /// <returns>true when a packet has a valid size.</returns>
    public bool ValidatePacket(int packetLength) => packetLength == _packetSize;

    /// <summary>
    /// Make check if a packet is long enough to be parsed.
    /// </summary>
    /// <param name="bytes">Received packets</param>
    /// <returns>true when the packet has a valid size.</returns>
    public bool ValidatePacket(in byte[] bytes) => bytes.Length == _packetSize;

    public bool ConnectToRemoteDataBase() =>
        throw new NotImplementedException();

    public bool ConnectToLocalDataBase() =>
        throw new NotImplementedException();

    /// <summary>
    /// Used to create and assign cancellation token
    /// </summary>
    private void CreateCancellationToken() {
        _listenerTokenSource = new();
        _listenerToken = _listenerTokenSource.Token;
    }

    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private void Dispose(bool disposing) {
        if (!disposing) {
            return;
        }

        _completedTask.Dispose();
        _listenerTokenSource.Dispose();
        UdpClientListener.Dispose();
    }
}