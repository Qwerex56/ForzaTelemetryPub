namespace UdpListenerService.Interfaces;

public interface IDbPacketFormatter {
    bool ConnectToRemoteDataBase();
    bool ConnectToLocalDataBase();
}