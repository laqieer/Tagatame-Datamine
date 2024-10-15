// Decompiled with JetBrains decompiler
// Type: SRPG.Json_EventShopBuyResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EB5")]
  public class Json_EventShopBuyResponse
  {
    [Token(Token = "0x4002D32")]
    [FieldOffset(Offset = "0x8")]
    public Json_Currencies currencies;
    [Token(Token = "0x4002D33")]
    [FieldOffset(Offset = "0xC")]
    public Json_Item[] items;
    [Token(Token = "0x4002D34")]
    [FieldOffset(Offset = "0x10")]
    public JSON_EventShopItemListSet[] shopitems;
    [Token(Token = "0x4002D35")]
    [FieldOffset(Offset = "0x14")]
    public Json_MailInfo mail_info;
    [Token(Token = "0x4002D36")]
    [FieldOffset(Offset = "0x18")]
    public Json_ShopBuyConceptCard[] cards;
    [Token(Token = "0x4002D37")]
    [FieldOffset(Offset = "0x1C")]
    public Json_Unit[] units;
    [Token(Token = "0x4002D38")]
    [FieldOffset(Offset = "0x20")]
    public int concept_count;
    [Token(Token = "0x4002D39")]
    [FieldOffset(Offset = "0x24")]
    public int crystal_count;
    [Token(Token = "0x4002D3A")]
    [FieldOffset(Offset = "0x28")]
    public JSON_TrophyProgress[] trophyprogs;
    [Token(Token = "0x4002D3B")]
    [FieldOffset(Offset = "0x2C")]
    public JSON_TrophyProgress[] bingoprogs;
    [Token(Token = "0x4002D3C")]
    [FieldOffset(Offset = "0x30")]
    public Json_Item[] runes;
    [Token(Token = "0x4002D3D")]
    [FieldOffset(Offset = "0x34")]
    public Json_ShopBuyCrystal[] crystals;
    [Token(Token = "0x4002D3E")]
    [FieldOffset(Offset = "0x38")]
    public int rune_storage_used;

    [Token(Token = "0x6003D28")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_EventShopBuyResponse()
    {
    }
  }
}
