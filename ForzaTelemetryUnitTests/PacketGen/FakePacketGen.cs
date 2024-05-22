namespace ForzaTelemetryUnitTests.PacketGen;

public class FakePacketGen(int packetSize) {
    public byte[] Bytes { get; } = new byte[packetSize];
    public int Cursor { get; set; }
}

public static class FakePacketGenExtensions {
    public static FakePacketGen GenRandBytes<T>(this FakePacketGen packetGen) where T : unmanaged {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(packetGen.Cursor + sizeof(byte), 
            packetGen.Bytes.Length);

        byte[] bytes;
        unsafe {
            bytes = new byte[sizeof(T)];
        }
        
        Random.Shared.NextBytes(bytes);

        foreach (var b in bytes) {
            packetGen.Bytes[packetGen.Cursor++] = b;
        }
        
        return packetGen;
    }
    
    public static FakePacketGen GenRandUInt8(this FakePacketGen packetGen) {
        return packetGen.GenRandBytes<sbyte>();
    }
    
    public static FakePacketGen GenRandInt8(this FakePacketGen packetGen) {
        return packetGen.GenRandBytes<byte>();
    }
    
    public static FakePacketGen GenRandUInt16(this FakePacketGen packetGen) {
        return packetGen.GenRandBytes<ushort>();
    }
    
    public static FakePacketGen GenRandInt16(this FakePacketGen packetGen) {
        return packetGen.GenRandBytes<short>();
    }
    
    public static FakePacketGen GenRandUInt32(this FakePacketGen packetGen) {
        return packetGen.GenRandBytes<uint>();
    }
    
    public static FakePacketGen GenRandInt32(this FakePacketGen packetGen) {
        return packetGen.GenRandBytes<int>();
    }
    
    public static FakePacketGen GenRandUInt64(this FakePacketGen packetGen) {
        return packetGen.GenRandBytes<ulong>();
    }
    
    public static FakePacketGen GenRandInt64(this FakePacketGen packetGen) {
        return packetGen.GenRandBytes<long>();
    }
    
    public static FakePacketGen GenRandSingle(this FakePacketGen packetGen) {
        return packetGen.GenRandBytes<float>();
    }
    
    public static FakePacketGen GenRandDouble(this FakePacketGen packetGen) {
        return packetGen.GenRandBytes<double>();
    }
}