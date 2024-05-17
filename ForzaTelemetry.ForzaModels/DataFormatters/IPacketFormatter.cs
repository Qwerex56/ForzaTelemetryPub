namespace ForzaTelemetry.ForzaModels.DataFormatters;

public interface IPacketFormatter {
    // protected int Cursor { get; set; }
    // protected byte[] Bytes { get; set; }
    //
    // public int ParseInt32() {
    //     var result = ParseInt32()
    // }
    
    public static byte ParseUInt8(byte[] bytes, int startId) {
        return Convert.ToByte(bytes[startId]);
    }

    public static sbyte ParseInt8(byte[] bytes, int startId) {
        return Convert.ToSByte(bytes[startId]);
    }

    public static ushort ParseUInt16(byte[] bytes, int startId) {
        return BitConverter.ToUInt16(bytes, startId);
    }
    
    public static short ParseInt16(byte[] bytes, int startId) {
        return BitConverter.ToInt16(bytes, startId);
    }
    
    public static uint ParseUInt32(byte[] bytes, int startId) {
        return BitConverter.ToUInt32(bytes, startId);
    }
    
    public static int ParseInt32(byte[] bytes, int startId) {
        return BitConverter.ToInt32(bytes, startId);
    }

    public static ulong ParseUInt64(byte[] bytes, int startId) {
        return BitConverter.ToUInt64(bytes, startId);
    }

    public static long ParseInt64(byte[] bytes, int startId) {
        return BitConverter.ToInt64(bytes, startId);
    }

    public static float ParseSingle(byte[] bytes, int startId) {
        return BitConverter.ToSingle(bytes, startId);
    }

    public static double ParseDouble(byte[] bytes, int startId) {
        return BitConverter.ToDouble(bytes, startId);
    }
}