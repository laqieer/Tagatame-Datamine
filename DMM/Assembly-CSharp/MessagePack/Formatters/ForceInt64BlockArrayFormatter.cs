// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceInt64BlockArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004BF")]
  public sealed class ForceInt64BlockArrayFormatter : 
    IMessagePackFormatter<long[]>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F52")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceInt64BlockArrayFormatter Instance;

    [Token(Token = "0x6001738")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceInt64BlockArrayFormatter()
    {
    }

    [Token(Token = "0x6001739")]
    [Address(RVA = "0x69D2B0", Offset = "0x69C0B0", VA = "0x1069D2B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      long[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600173A")]
    [Address(RVA = "0x69D0B0", Offset = "0x69BEB0", VA = "0x1069D0B0", Slot = "5")]
    public long[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (long[]) null;
    }

    [Token(Token = "0x600173B")]
    [Address(RVA = "0x69D540", Offset = "0x69C340", VA = "0x1069D540")]
    static ForceInt64BlockArrayFormatter()
    {
    }
  }
}
