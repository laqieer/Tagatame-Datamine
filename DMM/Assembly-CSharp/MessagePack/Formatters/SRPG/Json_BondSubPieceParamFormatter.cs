// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BondSubPieceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006B7")]
  public sealed class Json_BondSubPieceParamFormatter : 
    IMessagePackFormatter<Json_BondSubPieceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001206")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001207")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D73")]
    [Address(RVA = "0xC22A50", Offset = "0xC21850", VA = "0x10C22A50")]
    public Json_BondSubPieceParamFormatter()
    {
    }

    [Token(Token = "0x6001D74")]
    [Address(RVA = "0xC22870", Offset = "0xC21670", VA = "0x10C22870", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BondSubPieceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D75")]
    [Address(RVA = "0xC22530", Offset = "0xC21330", VA = "0x10C22530", Slot = "5")]
    public Json_BondSubPieceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BondSubPieceParam) null;
    }
  }
}
