// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableForceInt64BlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004BE")]
  public sealed class NullableForceInt64BlockFormatter : 
    IMessagePackFormatter<long?>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F51")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableForceInt64BlockFormatter Instance;

    [Token(Token = "0x6001734")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableForceInt64BlockFormatter()
    {
    }

    [Token(Token = "0x6001735")]
    [Address(RVA = "0x6A3670", Offset = "0x6A2470", VA = "0x106A3670", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      long? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001736")]
    [Address(RVA = "0x6A35A0", Offset = "0x6A23A0", VA = "0x106A35A0", Slot = "5")]
    public long? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new long?();
    }

    [Token(Token = "0x6001737")]
    [Address(RVA = "0x6A3720", Offset = "0x6A2520", VA = "0x106A3720")]
    static NullableForceInt64BlockFormatter()
    {
    }
  }
}
