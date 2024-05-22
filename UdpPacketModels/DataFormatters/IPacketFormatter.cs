namespace ForzaTelemetry.ForzaModels.DataFormatters;

public class PacketFormatter {
    public static byte ReadUInt8(in byte[] bytes, ref int cursor) {
        var result = ParseUInt8(bytes, cursor);
        cursor += sizeof(byte);

        return result;
    }

    public static sbyte ReadInt8(in byte[] bytes, ref int cursor) {
        var result = ParseInt8(bytes, cursor);
        cursor += sizeof(sbyte);

        return result;
    }

    public static ushort ReadUInt16(in byte[] bytes, ref int cursor) {
        var result = ParseUInt16(bytes, cursor);
        cursor += sizeof(ushort);

        return result;
    }

    public static short ReadInt16(in byte[] bytes, ref int cursor) {
        var result = ParseInt16(bytes, cursor);
        cursor += sizeof(short);

        return result;
    }

    public static uint ReadUInt32(in byte[] bytes, ref int cursor) {
        var result = ParseUInt32(bytes, cursor);
        cursor += sizeof(uint);

        return result;
    }

    public static int ReadInt32(in byte[] bytes, ref int cursor) {
        var result = ParseInt32(bytes, cursor);
        cursor += sizeof(int);

        return result;
    }

    public static ulong ReadInt64(in byte[] bytes, ref int cursor) {
        var result = ParseUInt64(bytes, cursor);
        cursor += sizeof(ulong);

        return result;
    }

    public static long ReadUInt64(in byte[] bytes, ref int cursor) {
        var result = ParseInt64(bytes, cursor);
        cursor += sizeof(long);

        return result;
    }

    public static float ReadSingle(in byte[] bytes, ref int cursor) {
        var result = ParseSingle(bytes, cursor);
        cursor += sizeof(float);

        return result;
    }

    public static double ReadDouble(in byte[] bytes, ref int cursor) {
        var result = ParseDouble(bytes, cursor);
        cursor += sizeof(double);

        return result;
    }
    
    public static byte ParseUInt8(in byte[] bytes, int startId) {
        var b = Convert.ToString(bytes[startId], 2).PadLeft(8, '0');
        return Convert.ToByte(b, 2);
    }

    public static sbyte ParseInt8(in byte[] bytes, int startId) {
        var b = Convert.ToString(bytes[startId], 2).PadLeft(8, '0');
        return Convert.ToSByte(b, 2);
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