// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableInt64Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004E1")]
  public sealed class NullableInt64Formatter : IMessagePackFormatter<long?>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F70")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableInt64Formatter Instance;

    [Token(Token = "0x60017B4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableInt64Formatter()
    {
    }

    [Token(Token = "0x60017B5")]
    [Address(RVA = "0x6A4320", Offset = "0x6A3120", VA = "0x106A4320", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      long? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017B6")]
    [Address(RVA = "0x6A4250", Offset = "0x6A3050", VA = "0x106A4250", Slot = "5")]
    public long? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new long?();
    }

    [Token(Token = "0x60017B7")]
    [Address(RVA = "0x6A43D0", Offset = "0x6A31D0", VA = "0x106A43D0")]
    static NullableInt64Formatter()
    {
    }
  }
}
