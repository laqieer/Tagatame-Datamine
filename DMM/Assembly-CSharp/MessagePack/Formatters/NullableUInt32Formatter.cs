// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableUInt32Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004E7")]
  public sealed class NullableUInt32Formatter : IMessagePackFormatter<uint?>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F76")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableUInt32Formatter Instance;

    [Token(Token = "0x60017CC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableUInt32Formatter()
    {
    }

    [Token(Token = "0x60017CD")]
    [Address(RVA = "0x6A5070", Offset = "0x6A3E70", VA = "0x106A5070", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      uint? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017CE")]
    [Address(RVA = "0x6A4FA0", Offset = "0x6A3DA0", VA = "0x106A4FA0", Slot = "5")]
    public uint? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new uint?();
    }

    [Token(Token = "0x60017CF")]
    [Address(RVA = "0x6A5110", Offset = "0x6A3F10", VA = "0x106A5110")]
    static NullableUInt32Formatter()
    {
    }
  }
}
