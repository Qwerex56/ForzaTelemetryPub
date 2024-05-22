using System.Net;
using System.Net.Sockets;

namespace ForzaTelemetry.ForzaModels.ForzaListener;

public class ForzaListenerService {
    public float rpm;
    
    public void ReceiverTask() {
        var udpClient = new UdpClient(8080);
        var endPoint = new IPEndPoint(IPAddress.Broadcast, 8080);

        var result = udpClient.Receive(ref endPoint);

        if (BitConverter.ToInt32(result[..4]) == 0) {
            udpClient.Close();
            return;
        }
        
        // Console.WriteLine(result.Length);
        var fmData = DataFormatters.ForzaFormatter.DataOutDash(result);
        
        rpm = fmData.LastLap;
        
        udpClient.Close();
    }
}