namespace ForzaTelemetry.ForzaModels.Extensions;

public static class BytesExtensions {
    public static byte ReadUInt8(this byte[] bytes, ref int position) {
        var b = Convert.ToString(bytes[position], 2).PadLeft(8, '0');
        position += sizeof(byte);
        
        return Convert.ToByte(b, 2);
    }

    public static sbyte ReadInt8(this byte[] bytes, ref int position) {
        var b = Convert.ToString(bytes[position], 2).PadLeft(8, '0');
        position += sizeof(sbyte);
        
        return Convert.ToSByte(b, 2);
    }

    public static ushort ReadUInt16(this byte[] bytes, ref int position) {
        var result = BitConverter.ToUInt16(bytes, position);
        position += sizeof(ushort);
        
        return result;
    }
    
    public static short ReadInt16(this byte[] bytes, ref int position) {
        var result = BitConverter.ToInt16(bytes, position);
        position += sizeof(short);
        
        return result;
    }
    
    public static uint ReadUInt32(this byte[] bytes, ref int position) {
        var result = BitConverter.ToUInt32(bytes, position);
        position += sizeof(uint);
        
        return result;
    }
    
    public static int ReadInt32(this byte[] bytes, ref int position) {
        var result = BitConverter.ToInt32(bytes, position);
        position += sizeof(int);
        
        return result;
    }
    
    public static ulong ReadUInt64(this byte[] bytes, ref int position) {
        var result = BitConverter.ToUInt64(bytes, position);
        position += sizeof(ulong);
        
        return result;
    }
    
    public static long ReadInt64(this byte[] bytes, ref int position) {
        var result = BitConverter.ToInt64(bytes, position);
        position += sizeof(long);
        
        return result;
    }
    
    public static float ReadSingle(this byte[] bytes, ref int position) {
        var result = BitConverter.ToSingle(bytes, position);
        position += sizeof(float);
        
        return result;
    }
    
    public static double ReadDouble(this byte[] bytes, ref int position) {
        var result = BitConverter.ToDouble(bytes, position);
        position += sizeof(double);
        
        return result;
    }

    public static sbyte ParseSByte(this byte[] bytes, int position) {
        var b = Convert.ToString(bytes[position], 2).PadLeft(8, '0');

        return Convert.ToSByte(b, 2);
    }
    
    public static byte ParseByte(this byte[] bytes, int position) {
        var b = Convert.ToString(bytes[position], 2).PadLeft(8, '0');

        return Convert.ToByte(b, 2);
    }
    
    public static ushort ParseUInt16(this byte[] bytes, int position) {
        return BitConverter.ToUInt16(bytes, position);
    }
    
    public static short ParseInt16(this byte[] bytes, int position) {
        return BitConverter.ToInt16(bytes, position);
    }
    
    public static uint ParseUInt32(this byte[] bytes, int position) {
        return BitConverter.ToUInt32(bytes, position);
    }
    
    public static int ParseInt32(this byte[] bytes, int position) {
        return BitConverter.ToInt32(bytes, position);
    }
    
    public static ulong ParseUInt64(this byte[] bytes, int position) {
        return BitConverter.ToUInt64(bytes, position);
    }
    
    public static long ParseInt64(this byte[] bytes, int position) {
        return BitConverter.ToInt64(bytes, position);
    }
    
    public static float ParseSingle(this byte[] bytes, int position) {
        return BitConverter.ToSingle(bytes, position);
    }
    
    public static double ParseDouble(this byte[] bytes, int position) {
        return BitConverter.ToDouble(bytes, position);
    }
}