// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BondSubPieceMatsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006B6")]
  public sealed class Json_BondSubPieceMatsParamFormatter : 
    IMessagePackFormatter<Json_BondSubPieceMatsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001204")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001205")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D70")]
    [Address(RVA = "0xC223B0", Offset = "0xC211B0", VA = "0x10C223B0")]
    public Json_BondSubPieceMatsParamFormatter()
    {
    }

    [Token(Token = "0x6001D71")]
    [Address(RVA = "0xC22280", Offset = "0xC21080", VA = "0x10C22280", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BondSubPieceMatsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D72")]
    [Address(RVA = "0xC21F70", Offset = "0xC20D70", VA = "0x10C21F70", Slot = "5")]
    public Json_BondSubPieceMatsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BondSubPieceMatsParam) null;
    }
  }
}
