// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondSubPieceMatsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B27")]
  public sealed class BondSubPieceMatsParamFormatter : 
    IMessagePackFormatter<BondSubPieceMatsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001ADE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001ADF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AC3")]
    [Address(RVA = "0xF30F20", Offset = "0xF2FD20", VA = "0x10F30F20")]
    public BondSubPieceMatsParamFormatter()
    {
    }

    [Token(Token = "0x6002AC4")]
    [Address(RVA = "0xF30DF0", Offset = "0xF2FBF0", VA = "0x10F30DF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondSubPieceMatsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AC5")]
    [Address(RVA = "0xF30B10", Offset = "0xF2F910", VA = "0x10F30B10", Slot = "5")]
    public BondSubPieceMatsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondSubPieceMatsParam) null;
    }
  }
}
