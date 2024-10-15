// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.Int64ArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004E2")]
  public sealed class Int64ArrayFormatter : IMessagePackFormatter<long[]>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F71")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Int64ArrayFormatter Instance;

    [Token(Token = "0x60017B8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int64ArrayFormatter()
    {
    }

    [Token(Token = "0x60017B9")]
    [Address(RVA = "0x69F8F0", Offset = "0x69E6F0", VA = "0x1069F8F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      long[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017BA")]
    [Address(RVA = "0x69F6F0", Offset = "0x69E4F0", VA = "0x1069F6F0", Slot = "5")]
    public long[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (long[]) null;
    }

    [Token(Token = "0x60017BB")]
    [Address(RVA = "0x69FA20", Offset = "0x69E820", VA = "0x1069FA20")]
    static Int64ArrayFormatter()
    {
    }
  }
}
