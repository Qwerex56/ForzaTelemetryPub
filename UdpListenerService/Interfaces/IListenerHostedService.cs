using System.Net;
using System.Net.Sockets;

namespace UdpListenerService.Interfaces;

public interface IListenerHostedService : IHostedService {
    UdpClient UdpClientListener { get; set; }
    
    void StartListening();
    Task StartListeningAsync();
    void StopListening();
    Task StopListeningAsync();

    bool SetListeningPort(int port);

    bool SetIpAddress(string address);
}