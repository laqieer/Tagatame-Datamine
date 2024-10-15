// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_UnitPieceShopItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200090D")]
  public sealed class Json_UnitPieceShopItemFormatter : 
    IMessagePackFormatter<Json_UnitPieceShopItem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016AA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016AB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002475")]
    [Address(RVA = "0xDE7F20", Offset = "0xDE6D20", VA = "0x10DE7F20")]
    public Json_UnitPieceShopItemFormatter()
    {
    }

    [Token(Token = "0x6002476")]
    [Address(RVA = "0xDE7C80", Offset = "0xDE6A80", VA = "0x10DE7C80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_UnitPieceShopItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002477")]
    [Address(RVA = "0xDE7800", Offset = "0xDE6600", VA = "0x10DE7800", Slot = "5")]
    public Json_UnitPieceShopItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_UnitPieceShopItem) null;
    }
  }
}
