// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BondPieceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006B5")]
  public sealed class Json_BondPieceParamFormatter : 
    IMessagePackFormatter<Json_BondPieceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001202")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001203")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D6D")]
    [Address(RVA = "0xC21190", Offset = "0xC1FF90", VA = "0x10C21190")]
    public Json_BondPieceParamFormatter()
    {
    }

    [Token(Token = "0x6001D6E")]
    [Address(RVA = "0xC20FB0", Offset = "0xC1FDB0", VA = "0x10C20FB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BondPieceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D6F")]
    [Address(RVA = "0xC20C70", Offset = "0xC1FA70", VA = "0x10C20C70", Slot = "5")]
    public Json_BondPieceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BondPieceParam) null;
    }
  }
}
