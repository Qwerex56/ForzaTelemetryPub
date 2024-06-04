using ForzaTelemetry.ForzaModels.Interfaces;

namespace UdpListenerService.Interfaces;

public interface IPacketFormatter<TPacketParser> where TPacketParser : IPacketParser {
    public void FormatPacket();
    public void ValidatePacket();
    public void BuildObjects();
    
    // Dash data functions
    
    /// <summary>
    /// Retrieves tires temperatures from UDP packet.
    /// </summary>
    /// <returns>tires temperatures.</returns>
    public object TiresTemperatures();
    
    /// <summary>
    /// Retrieves tires wear.
    /// </summary>
    /// <returns>tires wear.</returns>
    public object TiresWear();
    
    /// <summary>
    /// Retrieves all information about lap, such as:
    /// time, lap number and other.
    /// </summary>
    /// <returns>lap information.</returns>
    public object LapData();
    
    /// <summary>
    /// Retrieves all information about user input.
    /// </summary>
    /// <returns>input information.</returns>
    public object ControlData();
    
    // Sled data functions
    
    /// <summary>
    /// Retrieves all velocity forces.
    /// </summary>
    /// <returns>velocities.</returns>
    public object RetrieveVelocities();
    
    /// <summary>
    /// Retrieves all acceleration forces.
    /// </summary>
    /// <returns>accelerations.</returns>
    public object RetrieveAccelerations();
    
    /// <summary>
    /// Retrieves all wheel, tire and suspension data.
    /// </summary>
    /// <returns>wheel, tire and suspension data</returns>
    public object RetrieveWheelData();
}