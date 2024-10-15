// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.Int16Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004DA")]
  public sealed class Int16Formatter : IMessagePackFormatter<short>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F69")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Int16Formatter Instance;

    [Token(Token = "0x6001798")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int16Formatter()
    {
    }

    [Token(Token = "0x6001799")]
    [Address(RVA = "0x69F1C0", Offset = "0x69DFC0", VA = "0x1069F1C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      short value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600179A")]
    [Address(RVA = "0x69F170", Offset = "0x69DF70", VA = "0x1069F170", Slot = "5")]
    public short Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new short();
    }

    [Token(Token = "0x600179B")]
    [Address(RVA = "0x69F210", Offset = "0x69E010", VA = "0x1069F210")]
    static Int16Formatter()
    {
    }
  }
}
