// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondGroupParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200096D")]
  public sealed class BondGroupParamFormatter : 
    IMessagePackFormatter<BondGroupParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400176A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400176B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002595")]
    [Address(RVA = "0xE23940", Offset = "0xE22740", VA = "0x10E23940")]
    public BondGroupParamFormatter()
    {
    }

    [Token(Token = "0x6002596")]
    [Address(RVA = "0xE23330", Offset = "0xE22130", VA = "0x10E23330", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondGroupParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002597")]
    [Address(RVA = "0xE22F30", Offset = "0xE21D30", VA = "0x10E22F30", Slot = "5")]
    public BondGroupParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondGroupParam) null;
    }
  }
}
