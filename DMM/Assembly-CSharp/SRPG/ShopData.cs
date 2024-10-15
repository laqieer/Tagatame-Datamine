// Decompiled with JetBrains decompiler
// Type: SRPG.ShopData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001123")]
  public class ShopData
  {
    [Token(Token = "0x4003E3C")]
    public const string TYPE_ITEM = "item";
    [Token(Token = "0x4003E3D")]
    public const string TYPE_ARTIFACT = "artifact";
    [Token(Token = "0x4003E3E")]
    public const string TYPE_CONCEPTCARD = "concept_card";
    [Token(Token = "0x4003E3F")]
    public const string TYPE_CRYSTAL = "crystal";
    [Token(Token = "0x4003E40")]
    public const string CRYSTAL_WEBURL = "notice/detail/shop_crystal/";
    [Token(Token = "0x4003E41")]
    [FieldOffset(Offset = "0x8")]
    public List<ShopItem> items;
    [Token(Token = "0x4003E42")]
    [FieldOffset(Offset = "0xC")]
    public int UpdateCount;
    [Token(Token = "0x4003E43")]
    [FieldOffset(Offset = "0x10")]
    public bool btn_update;

    [Token(Token = "0x600487C")]
    [Address(RVA = "0x11F7100", Offset = "0x11F5F00", VA = "0x111F7100")]
    public static ESaleType String2SaleType(string type) => new ESaleType();

    [Token(Token = "0x600487D")]
    [Address(RVA = "0x11F7030", Offset = "0x11F5E30", VA = "0x111F7030")]
    public static string ShopItemType2String(EShopItemType itype) => (string) null;

    [Token(Token = "0x600487E")]
    [Address(RVA = "0x11F72C0", Offset = "0x11F60C0", VA = "0x111F72C0")]
    public static EShopItemType String2ShopItemType(string itype) => new EShopItemType();

    [Token(Token = "0x600487F")]
    [Address(RVA = "0x11F6E70", Offset = "0x11F5C70", VA = "0x111F6E70")]
    public static EShopItemType Iname2ShopItemType(string iname) => new EShopItemType();

    [Token(Token = "0x6004880")]
    [Address(RVA = "0x11F6360", Offset = "0x11F5160", VA = "0x111F6360")]
    public static int GetRemainingCurrency(ShopItem shopitem) => new int();

    [Token(Token = "0x6004881")]
    [Address(RVA = "0x11F61F0", Offset = "0x11F4FF0", VA = "0x111F61F0")]
    public static int GetBuyPrice(ShopItem shopItem) => new int();

    [Token(Token = "0x6004882")]
    [Address(RVA = "0x11F6550", Offset = "0x11F5350", VA = "0x111F6550")]
    public static string GetShopLimitDateText(EShopType shopType, long end_time = 0)
    {
      return (string) null;
    }

    [Token(Token = "0x6004883")]
    [Address(RVA = "0x11F6070", Offset = "0x11F4E70", VA = "0x111F6070")]
    public bool Deserialize(Json_ShopResponse response) => new bool();

    [Token(Token = "0x6004884")]
    [Address(RVA = "0x11F5750", Offset = "0x11F4550", VA = "0x111F5750")]
    public bool Deserialize(Json_ShopUpdateResponse response) => new bool();

    [Token(Token = "0x6004885")]
    [Address(RVA = "0x11F5A80", Offset = "0x11F4880", VA = "0x111F5A80")]
    public bool Deserialize(Json_ShopBuyResponse response) => new bool();

    [Token(Token = "0x6004886")]
    [Address(RVA = "0x11F5980", Offset = "0x11F4780", VA = "0x111F5980")]
    public bool Deserialize(Json_ShopItem[] shopitems) => new bool();

    [Token(Token = "0x6004887")]
    [Address(RVA = "0x11F73E0", Offset = "0x11F61E0", VA = "0x111F73E0")]
    public ShopData()
    {
    }
  }
}
