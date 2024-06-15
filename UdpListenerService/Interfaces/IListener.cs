using System.Net;
using System.Net.Sockets;

namespace UdpListenerService.Interfaces;

public interface IListenerHostedService : IHostedService {
    UdpClient UdpClientListener { get; set; }
    
    void StartListening(CancellationToken cancellationToken);
    Task StartListeningAsync(CancellationToken cancellationToken);
    void StopListening(CancellationToken cancellationToken);
    Task StopListeningAsync(CancellationToken cancellationToken);

    bool SetListeningPort(int port);
    bool SetListeningPort(string port);

    bool SetIpAddressEndpoint(IPEndPoint endPoint);
    bool SetIpAddressEndpoint(long ip, int port);
    bool SetIpAddressEndpoint(string ip, int port);
}