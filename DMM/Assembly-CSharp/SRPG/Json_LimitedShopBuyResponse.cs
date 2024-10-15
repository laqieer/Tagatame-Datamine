// Decompiled with JetBrains decompiler
// Type: SRPG.Json_LimitedShopBuyResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FD8")]
  public class Json_LimitedShopBuyResponse
  {
    [Token(Token = "0x40037FC")]
    [FieldOffset(Offset = "0x8")]
    public Json_Currencies currencies;
    [Token(Token = "0x40037FD")]
    [FieldOffset(Offset = "0xC")]
    public JSON_LimitedShopItemListSet[] shopitems;
    [Token(Token = "0x40037FE")]
    [FieldOffset(Offset = "0x10")]
    public Json_Item[] items;
    [Token(Token = "0x40037FF")]
    [FieldOffset(Offset = "0x14")]
    public Json_MailInfo mail_info;
    [Token(Token = "0x4003800")]
    [FieldOffset(Offset = "0x18")]
    public Json_ShopBuyConceptCard[] cards;
    [Token(Token = "0x4003801")]
    [FieldOffset(Offset = "0x1C")]
    public Json_Unit[] units;
    [Token(Token = "0x4003802")]
    [FieldOffset(Offset = "0x20")]
    public int concept_count;
    [Token(Token = "0x4003803")]
    [FieldOffset(Offset = "0x24")]
    public int crystal_count;
    [Token(Token = "0x4003804")]
    [FieldOffset(Offset = "0x28")]
    public JSON_TrophyProgress[] trophyprogs;
    [Token(Token = "0x4003805")]
    [FieldOffset(Offset = "0x2C")]
    public JSON_TrophyProgress[] bingoprogs;
    [Token(Token = "0x4003806")]
    [FieldOffset(Offset = "0x30")]
    public Json_Item[] runes;
    [Token(Token = "0x4003807")]
    [FieldOffset(Offset = "0x34")]
    public Json_ShopBuyCrystal[] crystals;
    [Token(Token = "0x4003808")]
    [FieldOffset(Offset = "0x38")]
    public int rune_storage_used;

    [Token(Token = "0x60041E9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_LimitedShopBuyResponse()
    {
    }
  }
}
