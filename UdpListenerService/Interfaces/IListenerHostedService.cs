using System.Net;
using System.Net.Sockets;
using ForzaTelemetry.ForzaModels.Interfaces;

namespace UdpListenerService.Interfaces;

public interface IListenerHostedService : IHostedService {
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
    
    UdpClient UdpClientListener { get; set; }
    
    void StartListening();
    Task StartListeningAsync();
    void StopListening();
    Task StopListeningAsync();

    bool SetListeningPort(int port);

    bool SetIpAddress(string address);

    /// <summary>
    /// Sends the empty message on any IP address
    /// </summary>
    private static void SendEndingPacket(int port) {
        var udpServer = new UdpClient();

        try {
            udpServer.Connect(IPAddress.Any, port);

            udpServer.Send([0], 1);
        } catch (Exception e) {
            Console.WriteLine(e);

            throw;
        } finally {
            udpServer.Close();
        }
    }
}