// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.Int64Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004E0")]
  public sealed class Int64Formatter : IMessagePackFormatter<long>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F6F")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Int64Formatter Instance;

    [Token(Token = "0x60017B0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int64Formatter()
    {
    }

    [Token(Token = "0x60017B1")]
    [Address(RVA = "0x69FAD0", Offset = "0x69E8D0", VA = "0x1069FAD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      long value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017B2")]
    [Address(RVA = "0x69FA80", Offset = "0x69E880", VA = "0x1069FA80", Slot = "5")]
    public long Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new long();
    }

    [Token(Token = "0x60017B3")]
    [Address(RVA = "0x69FB20", Offset = "0x69E920", VA = "0x1069FB20")]
    static Int64Formatter()
    {
    }
  }
}
