// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableForceByteBlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004CA")]
  public sealed class NullableForceByteBlockFormatter : 
    IMessagePackFormatter<byte?>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F5D")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableForceByteBlockFormatter Instance;

    [Token(Token = "0x6001764")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableForceByteBlockFormatter()
    {
    }

    [Token(Token = "0x6001765")]
    [Address(RVA = "0x6A3100", Offset = "0x6A1F00", VA = "0x106A3100", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      byte? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001766")]
    [Address(RVA = "0x6A3040", Offset = "0x6A1E40", VA = "0x106A3040", Slot = "5")]
    public byte? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new byte?();
    }

    [Token(Token = "0x6001767")]
    [Address(RVA = "0x6A31B0", Offset = "0x6A1FB0", VA = "0x106A31B0")]
    static NullableForceByteBlockFormatter()
    {
    }
  }
}
