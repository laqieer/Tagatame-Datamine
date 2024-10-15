// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableInt16Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004DB")]
  public sealed class NullableInt16Formatter : IMessagePackFormatter<short?>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F6A")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableInt16Formatter Instance;

    [Token(Token = "0x600179C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableInt16Formatter()
    {
    }

    [Token(Token = "0x600179D")]
    [Address(RVA = "0x6A3F80", Offset = "0x6A2D80", VA = "0x106A3F80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      short? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600179E")]
    [Address(RVA = "0x6A3EC0", Offset = "0x6A2CC0", VA = "0x106A3EC0", Slot = "5")]
    public short? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new short?();
    }

    [Token(Token = "0x600179F")]
    [Address(RVA = "0x6A4020", Offset = "0x6A2E20", VA = "0x106A4020")]
    static NullableInt16Formatter()
    {
    }
  }
}
