// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableForceInt32BlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004BB")]
  public sealed class NullableForceInt32BlockFormatter : 
    IMessagePackFormatter<int?>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F4E")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableForceInt32BlockFormatter Instance;

    [Token(Token = "0x6001728")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableForceInt32BlockFormatter()
    {
    }

    [Token(Token = "0x6001729")]
    [Address(RVA = "0x6A34A0", Offset = "0x6A22A0", VA = "0x106A34A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      int? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600172A")]
    [Address(RVA = "0x6A33D0", Offset = "0x6A21D0", VA = "0x106A33D0", Slot = "5")]
    public int? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new int?();
    }

    [Token(Token = "0x600172B")]
    [Address(RVA = "0x6A3540", Offset = "0x6A2340", VA = "0x106A3540")]
    static NullableForceInt32BlockFormatter()
    {
    }
  }
}
