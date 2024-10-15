// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondGroupBuffDetaillParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200096B")]
  public sealed class BondGroupBuffDetaillParamFormatter : 
    IMessagePackFormatter<BondGroupBuffDetaillParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001766")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001767")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600258F")]
    [Address(RVA = "0xE22000", Offset = "0xE20E00", VA = "0x10E22000")]
    public BondGroupBuffDetaillParamFormatter()
    {
    }

    [Token(Token = "0x6002590")]
    [Address(RVA = "0xE217D0", Offset = "0xE205D0", VA = "0x10E217D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondGroupBuffDetaillParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002591")]
    [Address(RVA = "0xE21330", Offset = "0xE20130", VA = "0x10E21330", Slot = "5")]
    public BondGroupBuffDetaillParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondGroupBuffDetaillParam) null;
    }
  }
}
