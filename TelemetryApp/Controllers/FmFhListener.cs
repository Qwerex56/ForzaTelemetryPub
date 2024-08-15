using System.Net;
using System.Net.Sockets;
using ForzaTelemetry.ForzaModels.DataOut.Interfaces;
using ForzaTelemetry.ForzaModels.PacketParser;
using TelemetryApp.Classes;
using UdpListenerService.Interfaces;

namespace TelemetryApp.Controllers;

public class FmFhListener : IListener, IDisposable {
    private readonly Task _completedTask = Task.CompletedTask;

    #region Events

    /// <summary>
    /// OnPacketReceived is fired after receiving the upd packet. <br></br>
    /// Note: This event doesn't check the structure of a packet, it can be anything.
    /// </summary>
    public event Action<byte[]>? OnPacketReceived;

    /// <summary>
    /// 
    /// </summary>
    public event Action<byte[]>? OnPacketAccepted;

    /// <summary>
    /// 
    /// </summary>
    public event Action<byte[]>? OnPacketRejected;

    /// <summary>
    /// 
    /// </summary>
    public event Action<IDataOut>? OnPacketFormatted;

    /// <summary>
    /// 
    /// </summary>
    public event Action? OnListenStart;

    /// <summary>
    /// 
    /// </summary>
    public event Action? OnListenEnd;

    #endregion

    public bool IsListening { get; private set; }

    #region Packet

    public UdpClient UdpClientListener { get; set; } = new();
    private UdpOptions _options;
    private readonly IPAddress _ipAddress;

    #endregion

    #region CancellationTokens

    private CancellationTokenSource _listenerTokenSource = new();
    private CancellationToken _listenerToken;

    #endregion

    public FmFhListener(UdpOptions options) {
        _options = options;

        _ipAddress = IPAddress.Parse(_options.IpAddress);

        OnListenStart += () => { IsListening = true; };
        OnListenEnd += () => {
            IsListening = false;
            Console.WriteLine("End");
        };
    }

    /// <summary>
    /// Starts listening on given port and address.
    /// Note that it doesn't set up udp server; This is done at startup in StartAsync() function.
    /// </summary>
    public void StartListening() {
        CreateCancellationToken();
        
        UdpClientListener = new(_options.Port);
        var endpoint = new IPEndPoint(_ipAddress, _options.Port);
        
        OnListenStart?.Invoke();

        Console.WriteLine("Opened");
        while (!_listenerToken.IsCancellationRequested) {
            Console.WriteLine("Iteration");
            var buffer = UdpClientListener.Receive(ref endpoint);
            OnPacketReceived?.Invoke(buffer);

            var bufferSize = buffer.Length;

            if (!ValidatePacket(bufferSize)) {
                OnPacketRejected?.Invoke(buffer);

                Console.WriteLine("Closed for sure, bad packet");
                continue;
            }

            OnPacketAccepted?.Invoke(buffer);

            var formattedPacket = ForzaPacketParser.DataOutDash(in buffer);

            OnPacketFormatted?.Invoke(formattedPacket);
            Console.WriteLine("Not Closed for sure 1");
        }

        OnListenEnd?.Invoke();
    }

    public async Task StartListeningAsync() {
        CreateCancellationToken();

        var endpoint = new IPEndPoint(_ipAddress, _options.Port);
        UdpClientListener.Connect(endpoint);

        while (!_listenerToken.IsCancellationRequested) {
            var result = await UdpClientListener.ReceiveAsync(_listenerToken);

            var buffer = result.Buffer;
            var bufferSize = result.Buffer.Length;

            // Packet is not valid
            if (!ValidatePacket(bufferSize)) continue;

            OnPacketReceived?.Invoke(buffer);
        }
    }

    public void StopListening() {
        _listenerTokenSource.Cancel();
        IListener.SendEndingPacket(_ipAddress, _options.Port);
    }

    public async Task StopListeningAsync() => await _listenerTokenSource.CancelAsync();

    /// <summary>
    /// Changes default port, port can only be changed when the udp client is not listening.
    /// </summary>
    /// <param name="port">new port value.</param>
    /// <returns>true, if port has been changed successfully, false otherwise.</returns>
    [Obsolete("Deprecated")]
    public bool SetListeningPort(int port) {
        if (!_listenerTokenSource.IsCancellationRequested) return false;

        _options = _options with { Port = port };

        return true;
    }

    [Obsolete("Deprecated")]
    public bool SetIpAddress(string address) {
        if (!_listenerTokenSource.IsCancellationRequested) return false;

        _options = _options with { IpAddress = address };

        return true;
    }

    /// <summary>
    /// Make check if a packet is long enough to be parsed.
    /// </summary>
    /// <param name="packetLength">Received packet length</param>
    /// <returns>true when a packet has a valid size.</returns>
    private bool ValidatePacket(int packetLength) => _options.PacketSizes.Contains(packetLength);

    /// <summary>
    /// Make check if a packet is long enough to be parsed.
    /// </summary>
    /// <param name="bytes">Received packets</param>
    /// <returns>true when the packet has a valid size.</returns>
    private bool ValidatePacket(in byte[] bytes) => _options.PacketSizes.Contains(bytes.Length);

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