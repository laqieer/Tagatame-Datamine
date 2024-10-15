// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BondPieceMatsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006B4")]
  public sealed class Json_BondPieceMatsParamFormatter : 
    IMessagePackFormatter<Json_BondPieceMatsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001200")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001201")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D6A")]
    [Address(RVA = "0xC20A80", Offset = "0xC1F880", VA = "0x10C20A80")]
    public Json_BondPieceMatsParamFormatter()
    {
    }

    [Token(Token = "0x6001D6B")]
    [Address(RVA = "0xC208F0", Offset = "0xC1F6F0", VA = "0x10C208F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BondPieceMatsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D6C")]
    [Address(RVA = "0xC20580", Offset = "0xC1F380", VA = "0x10C20580", Slot = "5")]
    public Json_BondPieceMatsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BondPieceMatsParam) null;
    }
  }
}
