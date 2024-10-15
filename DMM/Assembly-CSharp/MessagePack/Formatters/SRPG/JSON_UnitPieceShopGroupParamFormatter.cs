// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitPieceShopGroupParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000667")]
  public sealed class JSON_UnitPieceShopGroupParamFormatter : 
    IMessagePackFormatter<JSON_UnitPieceShopGroupParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001166")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001167")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C83")]
    [Address(RVA = "0xBF2460", Offset = "0xBF1260", VA = "0x10BF2460")]
    public JSON_UnitPieceShopGroupParamFormatter()
    {
    }

    [Token(Token = "0x6001C84")]
    [Address(RVA = "0xBF2280", Offset = "0xBF1080", VA = "0x10BF2280", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitPieceShopGroupParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C85")]
    [Address(RVA = "0xBF1F40", Offset = "0xBF0D40", VA = "0x10BF1F40", Slot = "5")]
    public JSON_UnitPieceShopGroupParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitPieceShopGroupParam) null;
    }
  }
}
