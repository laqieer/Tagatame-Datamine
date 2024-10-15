// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondPieceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000968")]
  public sealed class BondPieceParamFormatter : 
    IMessagePackFormatter<BondPieceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001760")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001761")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002586")]
    [Address(RVA = "0xE24A60", Offset = "0xE23860", VA = "0x10E24A60")]
    public BondPieceParamFormatter()
    {
    }

    [Token(Token = "0x6002587")]
    [Address(RVA = "0xE24880", Offset = "0xE23680", VA = "0x10E24880", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondPieceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002588")]
    [Address(RVA = "0xE24570", Offset = "0xE23370", VA = "0x10E24570", Slot = "5")]
    public BondPieceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondPieceParam) null;
    }
  }
}
