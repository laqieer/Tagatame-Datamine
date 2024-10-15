// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableByteFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004F6")]
  public sealed class NullableByteFormatter : IMessagePackFormatter<byte?>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F85")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableByteFormatter Instance;

    [Token(Token = "0x6001808")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableByteFormatter()
    {
    }

    [Token(Token = "0x6001809")]
    [Address(RVA = "0x6A2940", Offset = "0x6A1740", VA = "0x106A2940", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      byte? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600180A")]
    [Address(RVA = "0x6A2880", Offset = "0x6A1680", VA = "0x106A2880", Slot = "5")]
    public byte? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new byte?();
    }

    [Token(Token = "0x600180B")]
    [Address(RVA = "0x6A29F0", Offset = "0x6A17F0", VA = "0x106A29F0")]
    static NullableByteFormatter()
    {
    }
  }
}
