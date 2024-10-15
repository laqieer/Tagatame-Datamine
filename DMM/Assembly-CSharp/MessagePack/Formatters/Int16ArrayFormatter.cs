// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.Int16ArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004DC")]
  public sealed class Int16ArrayFormatter : IMessagePackFormatter<short[]>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F6B")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Int16ArrayFormatter Instance;

    [Token(Token = "0x60017A0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int16ArrayFormatter()
    {
    }

    [Token(Token = "0x60017A1")]
    [Address(RVA = "0x69EFF0", Offset = "0x69DDF0", VA = "0x1069EFF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      short[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017A2")]
    [Address(RVA = "0x69EDE0", Offset = "0x69DBE0", VA = "0x1069EDE0", Slot = "5")]
    public short[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (short[]) null;
    }

    [Token(Token = "0x60017A3")]
    [Address(RVA = "0x69F110", Offset = "0x69DF10", VA = "0x1069F110")]
    static Int16ArrayFormatter()
    {
    }
  }
}
