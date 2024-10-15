// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceInt64BlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004BD")]
  public sealed class ForceInt64BlockFormatter : IMessagePackFormatter<long>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F50")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceInt64BlockFormatter Instance;

    [Token(Token = "0x6001730")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceInt64BlockFormatter()
    {
    }

    [Token(Token = "0x6001731")]
    [Address(RVA = "0x69D5F0", Offset = "0x69C3F0", VA = "0x1069D5F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      long value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001732")]
    [Address(RVA = "0x69D5A0", Offset = "0x69C3A0", VA = "0x1069D5A0", Slot = "5")]
    public long Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new long();
    }

    [Token(Token = "0x6001733")]
    [Address(RVA = "0x69D640", Offset = "0x69C440", VA = "0x1069D640")]
    static ForceInt64BlockFormatter()
    {
    }
  }
}
