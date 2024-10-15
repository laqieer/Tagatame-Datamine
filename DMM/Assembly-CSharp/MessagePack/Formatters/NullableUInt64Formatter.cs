// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableUInt64Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004EA")]
  public sealed class NullableUInt64Formatter : IMessagePackFormatter<ulong?>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F79")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableUInt64Formatter Instance;

    [Token(Token = "0x60017D8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableUInt64Formatter()
    {
    }

    [Token(Token = "0x60017D9")]
    [Address(RVA = "0x6A5240", Offset = "0x6A4040", VA = "0x106A5240", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ulong? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017DA")]
    [Address(RVA = "0x6A5170", Offset = "0x6A3F70", VA = "0x106A5170", Slot = "5")]
    public ulong? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ulong?();
    }

    [Token(Token = "0x60017DB")]
    [Address(RVA = "0x6A52F0", Offset = "0x6A40F0", VA = "0x106A52F0")]
    static NullableUInt64Formatter()
    {
    }
  }
}
