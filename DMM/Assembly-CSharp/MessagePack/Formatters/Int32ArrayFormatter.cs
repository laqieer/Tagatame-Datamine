// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.Int32ArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004DF")]
  public sealed class Int32ArrayFormatter : IMessagePackFormatter<int[]>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F6E")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Int32ArrayFormatter Instance;

    [Token(Token = "0x60017AC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int32ArrayFormatter()
    {
    }

    [Token(Token = "0x60017AD")]
    [Address(RVA = "0x69F470", Offset = "0x69E270", VA = "0x1069F470", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      int[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017AE")]
    [Address(RVA = "0x69F270", Offset = "0x69E070", VA = "0x1069F270", Slot = "5")]
    public int[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (int[]) null;
    }

    [Token(Token = "0x60017AF")]
    [Address(RVA = "0x69F590", Offset = "0x69E390", VA = "0x1069F590")]
    static Int32ArrayFormatter()
    {
    }
  }
}
