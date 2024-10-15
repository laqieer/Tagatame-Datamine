// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableStringFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000502")]
  public sealed class NullableStringFormatter : IMessagePackFormatter<string>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F92")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableStringFormatter Instance;

    [Token(Token = "0x6001839")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableStringFormatter()
    {
    }

    [Token(Token = "0x600183A")]
    [Address(RVA = "0x6A4D30", Offset = "0x6A3B30", VA = "0x106A4D30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      string value,
      IFormatterResolver typeResolver)
    {
      return new int();
    }

    [Token(Token = "0x600183B")]
    [Address(RVA = "0x6A4CE0", Offset = "0x6A3AE0", VA = "0x106A4CE0", Slot = "5")]
    public string Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver typeResolver,
      out int readSize)
    {
      return (string) null;
    }

    [Token(Token = "0x600183C")]
    [Address(RVA = "0x6A4D80", Offset = "0x6A3B80", VA = "0x106A4D80")]
    static NullableStringFormatter()
    {
    }
  }
}
