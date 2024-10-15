// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ShopBuyResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200111A")]
  public class Json_ShopBuyResponse
  {
    [Token(Token = "0x4003DEC")]
    [FieldOffset(Offset = "0x8")]
    public Json_Currencies currencies;
    [Token(Token = "0x4003DED")]
    [FieldOffset(Offset = "0xC")]
    public Json_Item[] items;
    [Token(Token = "0x4003DEE")]
    [FieldOffset(Offset = "0x10")]
    public Json_ShopItem[] shopitems;
    [Token(Token = "0x4003DEF")]
    [FieldOffset(Offset = "0x14")]
    public Json_ShopBuyConceptCard[] cards;
    [Token(Token = "0x4003DF0")]
    [FieldOffset(Offset = "0x18")]
    public Json_Unit[] units;
    [Token(Token = "0x4003DF1")]
    [FieldOffset(Offset = "0x1C")]
    public int concept_count;
    [Token(Token = "0x4003DF2")]
    [FieldOffset(Offset = "0x20")]
    public int crystal_count;
    [Token(Token = "0x4003DF3")]
    [FieldOffset(Offset = "0x24")]
    public JSON_TrophyProgress[] trophyprogs;
    [Token(Token = "0x4003DF4")]
    [FieldOffset(Offset = "0x28")]
    public JSON_TrophyProgress[] bingoprogs;
    [Token(Token = "0x4003DF5")]
    [FieldOffset(Offset = "0x2C")]
    public Json_Item[] runes;
    [Token(Token = "0x4003DF6")]
    [FieldOffset(Offset = "0x30")]
    public Json_ShopBuyCrystal[] crystals;
    [Token(Token = "0x4003DF7")]
    [FieldOffset(Offset = "0x34")]
    public int rune_storage_used;

    [Token(Token = "0x600486A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ShopBuyResponse()
    {
    }
  }
}
