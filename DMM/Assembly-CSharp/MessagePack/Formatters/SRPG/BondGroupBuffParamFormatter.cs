// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondGroupBuffParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200096C")]
  public sealed class BondGroupBuffParamFormatter : 
    IMessagePackFormatter<BondGroupBuffParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001768")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001769")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002592")]
    [Address(RVA = "0xE22D40", Offset = "0xE21B40", VA = "0x10E22D40")]
    public BondGroupBuffParamFormatter()
    {
    }

    [Token(Token = "0x6002593")]
    [Address(RVA = "0xE22AD0", Offset = "0xE218D0", VA = "0x10E22AD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondGroupBuffParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002594")]
    [Address(RVA = "0xE22760", Offset = "0xE21560", VA = "0x10E22760", Slot = "5")]
    public BondGroupBuffParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondGroupBuffParam) null;
    }
  }
}
