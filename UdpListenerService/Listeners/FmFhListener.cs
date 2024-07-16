using System.Net;
using System.Net.Sockets;
using ForzaTelemetry.ForzaModels.DataOut;
using ForzaTelemetry.ForzaModels.Interfaces;
using ForzaTelemetry.ForzaModels.PacketParser;
using Microsoft.Extensions.Options;
using UdpListenerService.Interfaces;
using UdpListenerService.UdpSettings;

namespace UdpListenerService.Listeners;

public class FmFhListener : IListenerHostedService, IDbPacketFormatter, IDisposable {
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
    public event Action<byte[], IDataOut>? OnPacketFormatted;

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
    public UdpClient UdpClientListener { get; set; }
    private ForzaUdpSettings _options;
    private Fm8DataOutDash? _fmDataDash;

    #endregion

    #region CancellationTokens

    private CancellationTokenSource _listenerTokenSource = new();
    private CancellationToken _listenerToken;

    #endregion

    public FmFhListener(IOptions<ForzaUdpSettings> options) {
        _options = options.Value;

        UdpClientListener = new(_options.Port);
    }

    public Task StartAsync(CancellationToken cancellationToken) {
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
        var endpoint = new IPEndPoint(new IPAddress(_options.IpAddress), _options.Port);
        OnListenStart?.Invoke();

        IsListening = true;

        while (!_listenerToken.IsCancellationRequested) {
            var buffer = UdpClientListener.Receive(ref endpoint);
            OnPacketReceived?.Invoke(buffer);

            var bufferSize = buffer.Length;

            if (!ValidatePacket(bufferSize)) {
                OnPacketRejected?.Invoke(buffer);

                continue;
            }

            OnPacketAccepted?.Invoke(buffer);

            try {
                FormatPacket(in buffer);
            } catch (Exception e) {
                Console.WriteLine(e);

                throw;
            } finally {
                OnPacketFormatted?.Invoke(buffer, _fmDataDash);
            }
        }

        OnListenEnd?.Invoke();

        IsListening = false;
    }

    public async Task StartListeningAsync() {
        CreateCancellationToken();

        var endpoint = new IPEndPoint(new IPAddress(_options.IpAddress), _options.Port);
        UdpClientListener.Connect(endpoint);

        while (!_listenerToken.IsCancellationRequested) {
            var result = await UdpClientListener.ReceiveAsync(_listenerToken);

            var buffer = result.Buffer;
            var bufferSize = result.Buffer.Length;

            // Packet is not valid
            if (!ValidatePacket(bufferSize)) continue;

            FormatPacket(in buffer);
            OnPacketReceived?.Invoke(buffer);
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

        // _options = _options with { Port = port };

        return true;
    }

    public bool SetIpAddress(string address) {
        if (!_listenerTokenSource.IsCancellationRequested) return false;

        // _options = _options with { IpAddress = IPAddress.Parse(address) };

        return true;
    }

    private void FormatPacket(in byte[] bytes) {
        _fmDataDash = ForzaPacketParser.DataOutDash(in bytes);
    }

    /// <summary>
    /// Make check if a packet is long enough to be parsed.
    /// </summary>
    /// <param name="packetLength">Received packet length</param>
    /// <returns>true when a packet has a valid size.</returns>
    private bool ValidatePacket(int packetLength) => packetLength == _options.PacketSize;

    /// <summary>
    /// Make check if a packet is long enough to be parsed.
    /// </summary>
    /// <param name="bytes">Received packets</param>
    /// <returns>true when the packet has a valid size.</returns>
    private bool ValidatePacket(in byte[] bytes) => bytes.Length == _options.PacketSize;

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