// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceInt32BlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004BA")]
  public sealed class ForceInt32BlockFormatter : IMessagePackFormatter<int>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F4D")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceInt32BlockFormatter Instance;

    [Token(Token = "0x6001724")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceInt32BlockFormatter()
    {
    }

    [Token(Token = "0x6001725")]
    [Address(RVA = "0x69D000", Offset = "0x69BE00", VA = "0x1069D000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      int value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001726")]
    [Address(RVA = "0x69CFB0", Offset = "0x69BDB0", VA = "0x1069CFB0", Slot = "5")]
    public int Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new int();
    }

    [Token(Token = "0x6001727")]
    [Address(RVA = "0x69D050", Offset = "0x69BE50", VA = "0x1069D050")]
    static ForceInt32BlockFormatter()
    {
    }
  }
}
