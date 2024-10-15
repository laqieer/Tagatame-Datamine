// Decompiled with JetBrains decompiler
// Type: MessagePack.MessagePackBinary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Decoders;
using System;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x200035B")]
  public static class MessagePackBinary
  {
    [Token(Token = "0x4000D62")]
    private const int MaxSize = 256;
    [Token(Token = "0x4000D63")]
    private const int ArrayMaxSize = 2147483591;
    [Token(Token = "0x4000D64")]
    [FieldOffset(Offset = "0x0")]
    private static readonly IMapHeaderDecoder[] mapHeaderDecoders;
    [Token(Token = "0x4000D65")]
    [FieldOffset(Offset = "0x4")]
    private static readonly IArrayHeaderDecoder[] arrayHeaderDecoders;
    [Token(Token = "0x4000D66")]
    [FieldOffset(Offset = "0x8")]
    private static readonly IBooleanDecoder[] booleanDecoders;
    [Token(Token = "0x4000D67")]
    [FieldOffset(Offset = "0xC")]
    private static readonly IByteDecoder[] byteDecoders;
    [Token(Token = "0x4000D68")]
    [FieldOffset(Offset = "0x10")]
    private static readonly IBytesDecoder[] bytesDecoders;
    [Token(Token = "0x4000D69")]
    [FieldOffset(Offset = "0x14")]
    private static readonly IBytesSegmentDecoder[] bytesSegmentDecoders;
    [Token(Token = "0x4000D6A")]
    [FieldOffset(Offset = "0x18")]
    private static readonly ISByteDecoder[] sbyteDecoders;
    [Token(Token = "0x4000D6B")]
    [FieldOffset(Offset = "0x1C")]
    private static readonly ISingleDecoder[] singleDecoders;
    [Token(Token = "0x4000D6C")]
    [FieldOffset(Offset = "0x20")]
    private static readonly IDoubleDecoder[] doubleDecoders;
    [Token(Token = "0x4000D6D")]
    [FieldOffset(Offset = "0x24")]
    private static readonly IInt16Decoder[] int16Decoders;
    [Token(Token = "0x4000D6E")]
    [FieldOffset(Offset = "0x28")]
    private static readonly IInt32Decoder[] int32Decoders;
    [Token(Token = "0x4000D6F")]
    [FieldOffset(Offset = "0x2C")]
    private static readonly IInt64Decoder[] int64Decoders;
    [Token(Token = "0x4000D70")]
    [FieldOffset(Offset = "0x30")]
    private static readonly IUInt16Decoder[] uint16Decoders;
    [Token(Token = "0x4000D71")]
    [FieldOffset(Offset = "0x34")]
    private static readonly IUInt32Decoder[] uint32Decoders;
    [Token(Token = "0x4000D72")]
    [FieldOffset(Offset = "0x38")]
    private static readonly IUInt64Decoder[] uint64Decoders;
    [Token(Token = "0x4000D73")]
    [FieldOffset(Offset = "0x3C")]
    private static readonly IStringDecoder[] stringDecoders;
    [Token(Token = "0x4000D74")]
    [FieldOffset(Offset = "0x40")]
    private static readonly IStringSegmentDecoder[] stringSegmentDecoders;
    [Token(Token = "0x4000D75")]
    [FieldOffset(Offset = "0x44")]
    private static readonly IExtDecoder[] extDecoders;
    [Token(Token = "0x4000D76")]
    [FieldOffset(Offset = "0x48")]
    private static readonly IExtHeaderDecoder[] extHeaderDecoders;
    [Token(Token = "0x4000D77")]
    [FieldOffset(Offset = "0x4C")]
    private static readonly IDateTimeDecoder[] dateTimeDecoders;
    [Token(Token = "0x4000D78")]
    [FieldOffset(Offset = "0x50")]
    private static readonly IReadNextDecoder[] readNextDecoders;

    [Token(Token = "0x60011DF")]
    [Address(RVA = "0x2FA560", Offset = "0x2F9360", VA = "0x102FA560")]
    static MessagePackBinary()
    {
    }

    [Token(Token = "0x60011E0")]
    [Address(RVA = "0x2EEBD0", Offset = "0x2ED9D0", VA = "0x102EEBD0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void EnsureCapacity(ref byte[] bytes, int offset, int appendLength)
    {
    }

    [Token(Token = "0x60011E1")]
    [Address(RVA = "0x2EEDA0", Offset = "0x2EDBA0", VA = "0x102EEDA0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void FastResize(ref byte[] array, int newSize)
    {
    }

    [Token(Token = "0x60011E2")]
    [Address(RVA = "0x2EECF0", Offset = "0x2EDAF0", VA = "0x102EECF0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] FastCloneWithResize(byte[] array, int newSize) => (byte[]) null;

    [Token(Token = "0x60011E3")]
    [Address(RVA = "0x2EF1A0", Offset = "0x2EDFA0", VA = "0x102EF1A0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MessagePackType GetMessagePackType(byte[] bytes, int offset)
    {
      return new MessagePackType();
    }

    [Token(Token = "0x60011E4")]
    [Address(RVA = "0x2F14D0", Offset = "0x2F02D0", VA = "0x102F14D0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ReadNext(byte[] bytes, int offset) => new int();

    [Token(Token = "0x60011E5")]
    [Address(RVA = "0x2F12F0", Offset = "0x2F00F0", VA = "0x102F12F0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ReadNextBlock(byte[] bytes, int offset) => new int();

    [Token(Token = "0x60011E6")]
    [Address(RVA = "0x2F6240", Offset = "0x2F5040", VA = "0x102F6240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteNil(ref byte[] bytes, int offset) => new int();

    [Token(Token = "0x60011E7")]
    [Address(RVA = "0x2F1710", Offset = "0x2F0510", VA = "0x102F1710")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Nil ReadNil(byte[] bytes, int offset, out int readSize) => new Nil();

    [Token(Token = "0x60011E8")]
    [Address(RVA = "0x2EF210", Offset = "0x2EE010", VA = "0x102EF210")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNil(byte[] bytes, int offset) => new bool();

    [Token(Token = "0x60011E9")]
    [Address(RVA = "0x2F6420", Offset = "0x2F5220", VA = "0x102F6420")]
    public static int WriteRaw(ref byte[] bytes, int offset, byte[] rawMessagePackBlock)
    {
      return new int();
    }

    [Token(Token = "0x60011EA")]
    [Address(RVA = "0x2F46F0", Offset = "0x2F34F0", VA = "0x102F46F0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteFixedMapHeaderUnsafe(ref byte[] bytes, int offset, int count)
    {
      return new int();
    }

    [Token(Token = "0x60011EB")]
    [Address(RVA = "0x2F5FA0", Offset = "0x2F4DA0", VA = "0x102F5FA0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteMapHeader(ref byte[] bytes, int offset, int count) => new int();

    [Token(Token = "0x60011EC")]
    [Address(RVA = "0x2F6090", Offset = "0x2F4E90", VA = "0x102F6090")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteMapHeader(ref byte[] bytes, int offset, uint count) => new int();

    [Token(Token = "0x60011ED")]
    [Address(RVA = "0x2F5D70", Offset = "0x2F4B70", VA = "0x102F5D70")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteMapHeaderForceMap32Block(ref byte[] bytes, int offset, uint count)
    {
      return new int();
    }

    [Token(Token = "0x60011EE")]
    [Address(RVA = "0x2F0260", Offset = "0x2EF060", VA = "0x102F0260")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ReadMapHeader(byte[] bytes, int offset, out int readSize) => new int();

    [Token(Token = "0x60011EF")]
    [Address(RVA = "0x2F01C0", Offset = "0x2EEFC0", VA = "0x102F01C0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint ReadMapHeaderRaw(byte[] bytes, int offset, out int readSize) => new uint();

    [Token(Token = "0x60011F0")]
    [Address(RVA = "0x2EEE80", Offset = "0x2EDC80", VA = "0x102EEE80")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetArrayHeaderLength(int count) => new int();

    [Token(Token = "0x60011F1")]
    [Address(RVA = "0x2F4630", Offset = "0x2F3430", VA = "0x102F4630")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteFixedArrayHeaderUnsafe(ref byte[] bytes, int offset, int count)
    {
      return new int();
    }

    [Token(Token = "0x60011F2")]
    [Address(RVA = "0x2F2350", Offset = "0x2F1150", VA = "0x102F2350")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteArrayHeader(ref byte[] bytes, int offset, int count) => new int();

    [Token(Token = "0x60011F3")]
    [Address(RVA = "0x2F2040", Offset = "0x2F0E40", VA = "0x102F2040")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteArrayHeader(ref byte[] bytes, int offset, uint count) => new int();

    [Token(Token = "0x60011F4")]
    [Address(RVA = "0x2F1EE0", Offset = "0x2F0CE0", VA = "0x102F1EE0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteArrayHeaderForceArray32Block(ref byte[] bytes, int offset, uint count)
    {
      return new int();
    }

    [Token(Token = "0x60011F5")]
    [Address(RVA = "0x2EF440", Offset = "0x2EE240", VA = "0x102EF440")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ReadArrayHeader(byte[] bytes, int offset, out int readSize) => new int();

    [Token(Token = "0x60011F6")]
    [Address(RVA = "0x2EF2A0", Offset = "0x2EE0A0", VA = "0x102EF2A0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint ReadArrayHeaderRaw(byte[] bytes, int offset, out int readSize) => new uint();

    [Token(Token = "0x60011F7")]
    [Address(RVA = "0x2F23A0", Offset = "0x2F11A0", VA = "0x102F23A0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteBoolean(ref byte[] bytes, int offset, bool value) => new int();

    [Token(Token = "0x60011F8")]
    [Address(RVA = "0x2EF560", Offset = "0x2EE360", VA = "0x102EF560")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ReadBoolean(byte[] bytes, int offset, out int readSize) => new bool();

    [Token(Token = "0x60011F9")]
    [Address(RVA = "0x2F2620", Offset = "0x2F1420", VA = "0x102F2620")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteByte(ref byte[] bytes, int offset, byte value) => new int();

    [Token(Token = "0x60011FA")]
    [Address(RVA = "0x2F2590", Offset = "0x2F1390", VA = "0x102F2590")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteByteForceByteBlock(ref byte[] bytes, int offset, byte value)
    {
      return new int();
    }

    [Token(Token = "0x60011FB")]
    [Address(RVA = "0x2EF660", Offset = "0x2EE460", VA = "0x102EF660")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte ReadByte(byte[] bytes, int offset, out int readSize) => new byte();

    [Token(Token = "0x60011FC")]
    [Address(RVA = "0x2F2820", Offset = "0x2F1620", VA = "0x102F2820")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteBytes(ref byte[] bytes, int offset, byte[] value) => new int();

    [Token(Token = "0x60011FD")]
    [Address(RVA = "0x2F2A20", Offset = "0x2F1820", VA = "0x102F2A20")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteBytes(
      ref byte[] dest,
      int dstOffset,
      byte[] src,
      int srcOffset,
      int count)
    {
      return new int();
    }

    [Token(Token = "0x60011FE")]
    [Address(RVA = "0x2EF810", Offset = "0x2EE610", VA = "0x102EF810")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] ReadBytes(byte[] bytes, int offset, out int readSize) => (byte[]) null;

    [Token(Token = "0x60011FF")]
    [Address(RVA = "0x2EF700", Offset = "0x2EE500", VA = "0x102EF700")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ArraySegment<byte> ReadBytesSegment(byte[] bytes, int offset, out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x6001200")]
    [Address(RVA = "0x2F8580", Offset = "0x2F7380", VA = "0x102F8580")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteSByte(ref byte[] bytes, int offset, sbyte value) => new int();

    [Token(Token = "0x6001201")]
    [Address(RVA = "0x2F8410", Offset = "0x2F7210", VA = "0x102F8410")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteSByteForceSByteBlock(ref byte[] bytes, int offset, sbyte value)
    {
      return new int();
    }

    [Token(Token = "0x6001202")]
    [Address(RVA = "0x2F1830", Offset = "0x2F0630", VA = "0x102F1830")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte ReadSByte(byte[] bytes, int offset, out int readSize) => new sbyte();

    [Token(Token = "0x6001203")]
    [Address(RVA = "0x2F8780", Offset = "0x2F7580", VA = "0x102F8780")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteSingle(ref byte[] bytes, int offset, float value) => new int();

    [Token(Token = "0x6001204")]
    [Address(RVA = "0x2F1990", Offset = "0x2F0790", VA = "0x102F1990")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float ReadSingle(byte[] bytes, int offset, out int readSize) => new float();

    [Token(Token = "0x6001205")]
    [Address(RVA = "0x2F33D0", Offset = "0x2F21D0", VA = "0x102F33D0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteDouble(ref byte[] bytes, int offset, double value) => new int();

    [Token(Token = "0x6001206")]
    [Address(RVA = "0x2EFB00", Offset = "0x2EE900", VA = "0x102EFB00")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double ReadDouble(byte[] bytes, int offset, out int readSize) => new double();

    [Token(Token = "0x6001207")]
    [Address(RVA = "0x2F4B50", Offset = "0x2F3950", VA = "0x102F4B50")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteInt16(ref byte[] bytes, int offset, short value) => new int();

    [Token(Token = "0x6001208")]
    [Address(RVA = "0x2F49B0", Offset = "0x2F37B0", VA = "0x102F49B0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteInt16ForceInt16Block(ref byte[] bytes, int offset, short value)
    {
      return new int();
    }

    [Token(Token = "0x6001209")]
    [Address(RVA = "0x2EFEA0", Offset = "0x2EECA0", VA = "0x102EFEA0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short ReadInt16(byte[] bytes, int offset, out int readSize) => new short();

    [Token(Token = "0x600120A")]
    [Address(RVA = "0x2F62E0", Offset = "0x2F50E0", VA = "0x102F62E0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WritePositiveFixedIntUnsafe(ref byte[] bytes, int offset, int value)
    {
      return new int();
    }

    [Token(Token = "0x600120B")]
    [Address(RVA = "0x2F5040", Offset = "0x2F3E40", VA = "0x102F5040")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteInt32(ref byte[] bytes, int offset, int value) => new int();

    [Token(Token = "0x600120C")]
    [Address(RVA = "0x2F4E50", Offset = "0x2F3C50", VA = "0x102F4E50")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteInt32ForceInt32Block(ref byte[] bytes, int offset, int value)
    {
      return new int();
    }

    [Token(Token = "0x600120D")]
    [Address(RVA = "0x2EFF40", Offset = "0x2EED40", VA = "0x102EFF40")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ReadInt32(byte[] bytes, int offset, out int readSize) => new int();

    [Token(Token = "0x600120E")]
    [Address(RVA = "0x2F5630", Offset = "0x2F4430", VA = "0x102F5630")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteInt64(ref byte[] bytes, int offset, long value) => new int();

    [Token(Token = "0x600120F")]
    [Address(RVA = "0x2F5440", Offset = "0x2F4240", VA = "0x102F5440")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteInt64ForceInt64Block(ref byte[] bytes, int offset, long value)
    {
      return new int();
    }

    [Token(Token = "0x6001210")]
    [Address(RVA = "0x2F00A0", Offset = "0x2EEEA0", VA = "0x102F00A0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long ReadInt64(byte[] bytes, int offset, out int readSize) => new long();

    [Token(Token = "0x6001211")]
    [Address(RVA = "0x2F9850", Offset = "0x2F8650", VA = "0x102F9850")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteUInt16(ref byte[] bytes, int offset, ushort value) => new int();

    [Token(Token = "0x6001212")]
    [Address(RVA = "0x2F96B0", Offset = "0x2F84B0", VA = "0x102F96B0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteUInt16ForceUInt16Block(ref byte[] bytes, int offset, ushort value)
    {
      return new int();
    }

    [Token(Token = "0x6001213")]
    [Address(RVA = "0x2F1BE0", Offset = "0x2F09E0", VA = "0x102F1BE0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort ReadUInt16(byte[] bytes, int offset, out int readSize) => new ushort();

    [Token(Token = "0x6001214")]
    [Address(RVA = "0x2F9C40", Offset = "0x2F8A40", VA = "0x102F9C40")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteUInt32(ref byte[] bytes, int offset, uint value) => new int();

    [Token(Token = "0x6001215")]
    [Address(RVA = "0x2F9A40", Offset = "0x2F8840", VA = "0x102F9A40")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteUInt32ForceUInt32Block(ref byte[] bytes, int offset, uint value)
    {
      return new int();
    }

    [Token(Token = "0x6001216")]
    [Address(RVA = "0x2F1CE0", Offset = "0x2F0AE0", VA = "0x102F1CE0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint ReadUInt32(byte[] bytes, int offset, out int readSize) => new uint();

    [Token(Token = "0x6001217")]
    [Address(RVA = "0x2FA0E0", Offset = "0x2F8EE0", VA = "0x102FA0E0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteUInt64(ref byte[] bytes, int offset, ulong value) => new int();

    [Token(Token = "0x6001218")]
    [Address(RVA = "0x2F9F80", Offset = "0x2F8D80", VA = "0x102F9F80")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteUInt64ForceUInt64Block(ref byte[] bytes, int offset, ulong value)
    {
      return new int();
    }

    [Token(Token = "0x6001219")]
    [Address(RVA = "0x2F1DE0", Offset = "0x2F0BE0", VA = "0x102F1DE0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong ReadUInt64(byte[] bytes, int offset, out int readSize) => new ulong();

    [Token(Token = "0x600121A")]
    [Address(RVA = "0x2F2C70", Offset = "0x2F1A70", VA = "0x102F2C70")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteChar(ref byte[] bytes, int offset, char value) => new int();

    [Token(Token = "0x600121B")]
    [Address(RVA = "0x2EF8B0", Offset = "0x2EE6B0", VA = "0x102EF8B0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static char ReadChar(byte[] bytes, int offset, out int readSize) => new char();

    [Token(Token = "0x600121C")]
    [Address(RVA = "0x2F48E0", Offset = "0x2F36E0", VA = "0x102F48E0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteFixedStringUnsafe(
      ref byte[] bytes,
      int offset,
      string value,
      int byteCount)
    {
      return new int();
    }

    [Token(Token = "0x600121D")]
    [Address(RVA = "0x2F8EC0", Offset = "0x2F7CC0", VA = "0x102F8EC0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteStringUnsafe(ref byte[] bytes, int offset, string value, int byteCount)
    {
      return new int();
    }

    [Token(Token = "0x600121E")]
    [Address(RVA = "0x2F8A10", Offset = "0x2F7810", VA = "0x102F8A10")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteStringBytes(ref byte[] bytes, int offset, byte[] utf8stringBytes)
    {
      return new int();
    }

    [Token(Token = "0x600121F")]
    [Address(RVA = "0x2EEEB0", Offset = "0x2EDCB0", VA = "0x102EEEB0")]
    public static byte[] GetEncodedStringBytes(string value) => (byte[]) null;

    [Token(Token = "0x6001220")]
    [Address(RVA = "0x2F9370", Offset = "0x2F8170", VA = "0x102F9370")]
    public static int WriteString(ref byte[] bytes, int offset, string value) => new int();

    [Token(Token = "0x6001221")]
    [Address(RVA = "0x2F8D30", Offset = "0x2F7B30", VA = "0x102F8D30")]
    public static int WriteStringForceStr32Block(ref byte[] bytes, int offset, string value)
    {
      return new int();
    }

    [Token(Token = "0x6001222")]
    [Address(RVA = "0x2F1AE0", Offset = "0x2F08E0", VA = "0x102F1AE0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ReadString(byte[] bytes, int offset, out int readSize) => (string) null;

    [Token(Token = "0x6001223")]
    [Address(RVA = "0x2F1A30", Offset = "0x2F0830", VA = "0x102F1A30")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ArraySegment<byte> ReadStringSegment(byte[] bytes, int offset, out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x6001224")]
    [Address(RVA = "0x2F3850", Offset = "0x2F2650", VA = "0x102F3850")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteExtensionFormatHeader(
      ref byte[] bytes,
      int offset,
      sbyte typeCode,
      int dataLength)
    {
      return new int();
    }

    [Token(Token = "0x6001225")]
    [Address(RVA = "0x2F3640", Offset = "0x2F2440", VA = "0x102F3640")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteExtensionFormatHeaderForceExt32Block(
      ref byte[] bytes,
      int offset,
      sbyte typeCode,
      int dataLength)
    {
      return new int();
    }

    [Token(Token = "0x6001226")]
    [Address(RVA = "0x2F3CC0", Offset = "0x2F2AC0", VA = "0x102F3CC0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteExtensionFormat(
      ref byte[] bytes,
      int offset,
      sbyte typeCode,
      byte[] data)
    {
      return new int();
    }

    [Token(Token = "0x6001227")]
    [Address(RVA = "0x2EFD50", Offset = "0x2EEB50", VA = "0x102EFD50")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ExtensionResult ReadExtensionFormat(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionResult();
    }

    [Token(Token = "0x6001228")]
    [Address(RVA = "0x2EFC50", Offset = "0x2EEA50", VA = "0x102EFC50")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ExtensionHeader ReadExtensionFormatHeader(
      byte[] bytes,
      int offset,
      out int readSize)
    {
      return new ExtensionHeader();
    }

    [Token(Token = "0x6001229")]
    [Address(RVA = "0x2EF150", Offset = "0x2EDF50", VA = "0x102EF150")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetExtensionFormatHeaderLength(int dataLength) => new int();

    [Token(Token = "0x600122A")]
    [Address(RVA = "0x2F2E10", Offset = "0x2F1C10", VA = "0x102F2E10")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteDateTime(ref byte[] bytes, int offset, DateTime dateTime) => new int();

    [Token(Token = "0x600122B")]
    [Address(RVA = "0x2EFA00", Offset = "0x2EE800", VA = "0x102EFA00")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DateTime ReadDateTime(byte[] bytes, int offset, out int readSize)
    {
      return new DateTime();
    }

    [Token(Token = "0x600122C")]
    [Address(RVA = "0x2F1190", Offset = "0x2EFF90", VA = "0x102F1190")]
    private static byte[] ReadMessageBlockFromStreamUnsafe(Stream stream) => (byte[]) null;

    [Token(Token = "0x600122D")]
    [Address(RVA = "0x2F1220", Offset = "0x2F0020", VA = "0x102F1220")]
    public static byte[] ReadMessageBlockFromStreamUnsafe(
      Stream stream,
      bool readOnlySingleMessage,
      out int readSize)
    {
      return (byte[]) null;
    }

    [Token(Token = "0x600122E")]
    [Address(RVA = "0x2F03A0", Offset = "0x2EF1A0", VA = "0x102F03A0")]
    private static int ReadMessageBlockFromStreamCore(
      Stream stream,
      ref byte[] bytes,
      int offset,
      bool readOnlySingleMessage)
    {
      return new int();
    }

    [Token(Token = "0x600122F")]
    [Address(RVA = "0x2EFDF0", Offset = "0x2EEBF0", VA = "0x102EFDF0")]
    private static void ReadFully(Stream stream, byte[] bytes, int offset, int readSize)
    {
    }

    [Token(Token = "0x6001230")]
    [Address(RVA = "0x2F1560", Offset = "0x2F0360", VA = "0x102F1560")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ReadNext(Stream stream) => new int();

    [Token(Token = "0x6001231")]
    [Address(RVA = "0x2F1290", Offset = "0x2F0090", VA = "0x102F1290")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ReadNextBlock(Stream stream) => new int();

    [Token(Token = "0x6001232")]
    [Address(RVA = "0x2F62B0", Offset = "0x2F50B0", VA = "0x102F62B0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteNil(Stream stream) => new int();

    [Token(Token = "0x6001233")]
    [Address(RVA = "0x2F15C0", Offset = "0x2F03C0", VA = "0x102F15C0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Nil ReadNil(Stream stream) => new Nil();

    [Token(Token = "0x6001234")]
    [Address(RVA = "0x2EF240", Offset = "0x2EE040", VA = "0x102EF240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNil(Stream stream) => new bool();

    [Token(Token = "0x6001235")]
    [Address(RVA = "0x2F4770", Offset = "0x2F3570", VA = "0x102F4770")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteFixedMapHeaderUnsafe(Stream stream, int count) => new int();

    [Token(Token = "0x6001236")]
    [Address(RVA = "0x2F5ED0", Offset = "0x2F4CD0", VA = "0x102F5ED0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteMapHeader(Stream stream, int count) => new int();

    [Token(Token = "0x6001237")]
    [Address(RVA = "0x2F6000", Offset = "0x2F4E00", VA = "0x102F6000")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteMapHeader(Stream stream, uint count) => new int();

    [Token(Token = "0x6001238")]
    [Address(RVA = "0x2F5E40", Offset = "0x2F4C40", VA = "0x102F5E40")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteMapHeaderForceMap32Block(Stream stream, uint count) => new int();

    [Token(Token = "0x6001239")]
    [Address(RVA = "0x2F0320", Offset = "0x2EF120", VA = "0x102F0320")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ReadMapHeader(Stream stream) => new int();

    [Token(Token = "0x600123A")]
    [Address(RVA = "0x2F0140", Offset = "0x2EEF40", VA = "0x102F0140")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint ReadMapHeaderRaw(Stream stream) => new uint();

    [Token(Token = "0x600123B")]
    [Address(RVA = "0x2F46B0", Offset = "0x2F34B0", VA = "0x102F46B0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteFixedArrayHeaderUnsafe(Stream stream, int count) => new int();

    [Token(Token = "0x600123C")]
    [Address(RVA = "0x2F21F0", Offset = "0x2F0FF0", VA = "0x102F21F0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteArrayHeader(Stream stream, int count) => new int();

    [Token(Token = "0x600123D")]
    [Address(RVA = "0x2F22C0", Offset = "0x2F10C0", VA = "0x102F22C0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteArrayHeader(Stream stream, uint count) => new int();

    [Token(Token = "0x600123E")]
    [Address(RVA = "0x2F1FB0", Offset = "0x2F0DB0", VA = "0x102F1FB0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteArrayHeaderForceArray32Block(Stream stream, uint count) => new int();

    [Token(Token = "0x600123F")]
    [Address(RVA = "0x2EF3C0", Offset = "0x2EE1C0", VA = "0x102EF3C0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ReadArrayHeader(Stream stream) => new int();

    [Token(Token = "0x6001240")]
    [Address(RVA = "0x2EF340", Offset = "0x2EE140", VA = "0x102EF340")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint ReadArrayHeaderRaw(Stream stream) => new uint();

    [Token(Token = "0x6001241")]
    [Address(RVA = "0x2F2420", Offset = "0x2F1220", VA = "0x102F2420")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteBoolean(Stream stream, bool value) => new int();

    [Token(Token = "0x6001242")]
    [Address(RVA = "0x2EF500", Offset = "0x2EE300", VA = "0x102EF500")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ReadBoolean(Stream stream) => new bool();

    [Token(Token = "0x6001243")]
    [Address(RVA = "0x2F26F0", Offset = "0x2F14F0", VA = "0x102F26F0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteByte(Stream stream, byte value) => new int();

    [Token(Token = "0x6001244")]
    [Address(RVA = "0x2F24B0", Offset = "0x2F12B0", VA = "0x102F24B0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteByteForceByteBlock(Stream stream, byte value) => new int();

    [Token(Token = "0x6001245")]
    [Address(RVA = "0x2EF600", Offset = "0x2EE400", VA = "0x102EF600")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte ReadByte(Stream stream) => new byte();

    [Token(Token = "0x6001246")]
    [Address(RVA = "0x2F28A0", Offset = "0x2F16A0", VA = "0x102F28A0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteBytes(Stream stream, byte[] value) => new int();

    [Token(Token = "0x6001247")]
    [Address(RVA = "0x2F2990", Offset = "0x2F1790", VA = "0x102F2990")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteBytes(Stream stream, byte[] src, int srcOffset, int count) => new int();

    [Token(Token = "0x6001248")]
    [Address(RVA = "0x2EF7B0", Offset = "0x2EE5B0", VA = "0x102EF7B0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] ReadBytes(Stream stream) => (byte[]) null;

    [Token(Token = "0x6001249")]
    [Address(RVA = "0x2F8650", Offset = "0x2F7450", VA = "0x102F8650")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteSByte(Stream stream, sbyte value) => new int();

    [Token(Token = "0x600124A")]
    [Address(RVA = "0x2F84A0", Offset = "0x2F72A0", VA = "0x102F84A0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteSByteForceSByteBlock(Stream stream, sbyte value) => new int();

    [Token(Token = "0x600124B")]
    [Address(RVA = "0x2F18D0", Offset = "0x2F06D0", VA = "0x102F18D0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte ReadSByte(Stream stream) => new sbyte();

    [Token(Token = "0x600124C")]
    [Address(RVA = "0x2F88F0", Offset = "0x2F76F0", VA = "0x102F88F0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteSingle(Stream stream, float value) => new int();

    [Token(Token = "0x600124D")]
    [Address(RVA = "0x2F1930", Offset = "0x2F0730", VA = "0x102F1930")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float ReadSingle(Stream stream) => new float();

    [Token(Token = "0x600124E")]
    [Address(RVA = "0x2F3340", Offset = "0x2F2140", VA = "0x102F3340")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteDouble(Stream stream, double value) => new int();

    [Token(Token = "0x600124F")]
    [Address(RVA = "0x2EFAA0", Offset = "0x2EE8A0", VA = "0x102EFAA0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double ReadDouble(Stream stream) => new double();

    [Token(Token = "0x6001250")]
    [Address(RVA = "0x2F4DC0", Offset = "0x2F3BC0", VA = "0x102F4DC0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteInt16(Stream stream, short value) => new int();

    [Token(Token = "0x6001251")]
    [Address(RVA = "0x2F4A50", Offset = "0x2F3850", VA = "0x102F4A50")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteInt16ForceInt16Block(Stream stream, short value) => new int();

    [Token(Token = "0x6001252")]
    [Address(RVA = "0x2EFE40", Offset = "0x2EEC40", VA = "0x102EFE40")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short ReadInt16(Stream stream) => new short();

    [Token(Token = "0x6001253")]
    [Address(RVA = "0x2F6350", Offset = "0x2F5150", VA = "0x102F6350")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WritePositiveFixedIntUnsafe(Stream stream, int value) => new int();

    [Token(Token = "0x6001254")]
    [Address(RVA = "0x2F4FB0", Offset = "0x2F3DB0", VA = "0x102F4FB0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteInt32(Stream stream, int value) => new int();

    [Token(Token = "0x6001255")]
    [Address(RVA = "0x2F4F20", Offset = "0x2F3D20", VA = "0x102F4F20")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteInt32ForceInt32Block(Stream stream, int value) => new int();

    [Token(Token = "0x6001256")]
    [Address(RVA = "0x2EFFE0", Offset = "0x2EEDE0", VA = "0x102EFFE0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ReadInt32(Stream stream) => new int();

    [Token(Token = "0x6001257")]
    [Address(RVA = "0x2F5CE0", Offset = "0x2F4AE0", VA = "0x102F5CE0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteInt64(Stream stream, long value) => new int();

    [Token(Token = "0x6001258")]
    [Address(RVA = "0x2F55A0", Offset = "0x2F43A0", VA = "0x102F55A0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteInt64ForceInt64Block(Stream stream, long value) => new int();

    [Token(Token = "0x6001259")]
    [Address(RVA = "0x2F0040", Offset = "0x2EEE40", VA = "0x102F0040")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long ReadInt64(Stream stream) => new long();

    [Token(Token = "0x600125A")]
    [Address(RVA = "0x2F99B0", Offset = "0x2F87B0", VA = "0x102F99B0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteUInt16(Stream stream, ushort value) => new int();

    [Token(Token = "0x600125B")]
    [Address(RVA = "0x2F9750", Offset = "0x2F8550", VA = "0x102F9750")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteUInt16ForceUInt16Block(Stream stream, ushort value) => new int();

    [Token(Token = "0x600125C")]
    [Address(RVA = "0x2F1C80", Offset = "0x2F0A80", VA = "0x102F1C80")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort ReadUInt16(Stream stream) => new ushort();

    [Token(Token = "0x600125D")]
    [Address(RVA = "0x2F9E60", Offset = "0x2F8C60", VA = "0x102F9E60")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteUInt32(Stream stream, uint value) => new int();

    [Token(Token = "0x600125E")]
    [Address(RVA = "0x2F9B10", Offset = "0x2F8910", VA = "0x102F9B10")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteUInt32ForceUInt32Block(Stream stream, uint value) => new int();

    [Token(Token = "0x600125F")]
    [Address(RVA = "0x2F1D80", Offset = "0x2F0B80", VA = "0x102F1D80")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint ReadUInt32(Stream stream) => new uint();

    [Token(Token = "0x6001260")]
    [Address(RVA = "0x2FA4A0", Offset = "0x2F92A0", VA = "0x102FA4A0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteUInt64(Stream stream, ulong value) => new int();

    [Token(Token = "0x6001261")]
    [Address(RVA = "0x2F9EF0", Offset = "0x2F8CF0", VA = "0x102F9EF0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteUInt64ForceUInt64Block(Stream stream, ulong value) => new int();

    [Token(Token = "0x6001262")]
    [Address(RVA = "0x2F1E80", Offset = "0x2F0C80", VA = "0x102F1E80")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong ReadUInt64(Stream stream) => new ulong();

    [Token(Token = "0x6001263")]
    [Address(RVA = "0x2F2CC0", Offset = "0x2F1AC0", VA = "0x102F2CC0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteChar(Stream stream, char value) => new int();

    [Token(Token = "0x6001264")]
    [Address(RVA = "0x2EF900", Offset = "0x2EE700", VA = "0x102EF900")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static char ReadChar(Stream stream) => new char();

    [Token(Token = "0x6001265")]
    [Address(RVA = "0x2F47B0", Offset = "0x2F35B0", VA = "0x102F47B0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteFixedStringUnsafe(Stream stream, string value, int byteCount)
    {
      return new int();
    }

    [Token(Token = "0x6001266")]
    [Address(RVA = "0x2F9250", Offset = "0x2F8050", VA = "0x102F9250")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteStringUnsafe(Stream stream, string value, int byteCount) => new int();

    [Token(Token = "0x6001267")]
    [Address(RVA = "0x2F8980", Offset = "0x2F7780", VA = "0x102F8980")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteStringBytes(Stream stream, byte[] utf8stringBytes) => new int();

    [Token(Token = "0x6001268")]
    [Address(RVA = "0x2F92E0", Offset = "0x2F80E0", VA = "0x102F92E0")]
    public static int WriteString(Stream stream, string value) => new int();

    [Token(Token = "0x6001269")]
    [Address(RVA = "0x2F8CA0", Offset = "0x2F7AA0", VA = "0x102F8CA0")]
    public static int WriteStringForceStr32Block(Stream stream, string value) => new int();

    [Token(Token = "0x600126A")]
    [Address(RVA = "0x2F1B80", Offset = "0x2F0980", VA = "0x102F1B80")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ReadString(Stream stream) => (string) null;

    [Token(Token = "0x600126B")]
    [Address(RVA = "0x2F37C0", Offset = "0x2F25C0", VA = "0x102F37C0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteExtensionFormatHeader(Stream stream, sbyte typeCode, int dataLength)
    {
      return new int();
    }

    [Token(Token = "0x600126C")]
    [Address(RVA = "0x2F3730", Offset = "0x2F2530", VA = "0x102F3730")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteExtensionFormatHeaderForceExt32Block(
      Stream stream,
      sbyte typeCode,
      int dataLength)
    {
      return new int();
    }

    [Token(Token = "0x600126D")]
    [Address(RVA = "0x2F3C30", Offset = "0x2F2A30", VA = "0x102F3C30")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteExtensionFormat(Stream stream, sbyte typeCode, byte[] data) => new int();

    [Token(Token = "0x600126E")]
    [Address(RVA = "0x2EFCF0", Offset = "0x2EEAF0", VA = "0x102EFCF0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ExtensionResult ReadExtensionFormat(Stream stream) => new ExtensionResult();

    [Token(Token = "0x600126F")]
    [Address(RVA = "0x2EFBA0", Offset = "0x2EE9A0", VA = "0x102EFBA0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ExtensionHeader ReadExtensionFormatHeader(Stream stream) => new ExtensionHeader();

    [Token(Token = "0x6001270")]
    [Address(RVA = "0x2F2D80", Offset = "0x2F1B80", VA = "0x102F2D80")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int WriteDateTime(Stream stream, DateTime dateTime) => new int();

    [Token(Token = "0x6001271")]
    [Address(RVA = "0x2EF9A0", Offset = "0x2EE7A0", VA = "0x102EF9A0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DateTime ReadDateTime(Stream stream) => new DateTime();

    [Token(Token = "0x200035C")]
    private static class StreamDecodeMemoryPool
    {
      [Token(Token = "0x4000D79")]
      [ThreadStatic]
      private static byte[] buffer;

      [Token(Token = "0x6001272")]
      [Address(RVA = "0x304950", Offset = "0x303750", VA = "0x10304950")]
      public static byte[] GetBuffer() => (byte[]) null;
    }
  }
}
