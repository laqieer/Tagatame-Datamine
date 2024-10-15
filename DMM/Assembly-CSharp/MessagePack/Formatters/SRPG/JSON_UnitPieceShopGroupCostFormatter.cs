// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitPieceShopGroupCostFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000666")]
  public sealed class JSON_UnitPieceShopGroupCostFormatter : 
    IMessagePackFormatter<JSON_UnitPieceShopGroupCost>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001164")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001165")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C80")]
    [Address(RVA = "0xBF1DC0", Offset = "0xBF0BC0", VA = "0x10BF1DC0")]
    public JSON_UnitPieceShopGroupCostFormatter()
    {
    }

    [Token(Token = "0x6001C81")]
    [Address(RVA = "0xBF1CC0", Offset = "0xBF0AC0", VA = "0x10BF1CC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitPieceShopGroupCost value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C82")]
    [Address(RVA = "0xBF19E0", Offset = "0xBF07E0", VA = "0x10BF19E0", Slot = "5")]
    public JSON_UnitPieceShopGroupCost Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitPieceShopGroupCost) null;
    }
  }
}
