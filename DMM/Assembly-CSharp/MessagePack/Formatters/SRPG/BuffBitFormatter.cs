// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BuffBitFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007D2")]
  public sealed class BuffBitFormatter : IMessagePackFormatter<BuffBit>, IMessagePackFormatter
  {
    [Token(Token = "0x4001434")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001435")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020C4")]
    [Address(RVA = "0xD14590", Offset = "0xD13390", VA = "0x10D14590")]
    public BuffBitFormatter()
    {
    }

    [Token(Token = "0x60020C5")]
    [Address(RVA = "0xD14420", Offset = "0xD13220", VA = "0x10D14420", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BuffBit value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020C6")]
    [Address(RVA = "0xD14150", Offset = "0xD12F50", VA = "0x10D14150", Slot = "5")]
    public BuffBit Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BuffBit) null;
    }
  }
}
