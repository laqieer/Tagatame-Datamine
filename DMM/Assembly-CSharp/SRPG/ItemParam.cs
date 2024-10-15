// Decompiled with JetBrains decompiler
// Type: SRPG.ItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BAE")]
  [MessagePackObject(true)]
  public class ItemParam
  {
    [Token(Token = "0x40069D1")]
    public const string CoinID = "$COIN";
    [Token(Token = "0x40069D2")]
    private const string ITEM_EXPR_PREFIX = "_EXPR";
    [Token(Token = "0x40069D3")]
    private const string ITEM_FLAVOR_PREFIX = "_FLAVOR";
    [Token(Token = "0x40069D4")]
    [FieldOffset(Offset = "0x8")]
    public int no;
    [Token(Token = "0x40069D5")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x40069D6")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x40069D7")]
    [FieldOffset(Offset = "0x14")]
    public EItemType type;
    [Token(Token = "0x40069D8")]
    [FieldOffset(Offset = "0x18")]
    public EItemTabType tabtype;
    [Token(Token = "0x40069D9")]
    [FieldOffset(Offset = "0x1C")]
    public int rare;
    [Token(Token = "0x40069DA")]
    [FieldOffset(Offset = "0x20")]
    public int cap;
    [Token(Token = "0x40069DB")]
    [FieldOffset(Offset = "0x24")]
    public int invcap;
    [Token(Token = "0x40069DC")]
    [FieldOffset(Offset = "0x28")]
    public int equipLv;
    [Token(Token = "0x40069DD")]
    [FieldOffset(Offset = "0x2C")]
    public int coin;
    [Token(Token = "0x40069DE")]
    [FieldOffset(Offset = "0x30")]
    public int tour_coin;
    [Token(Token = "0x40069DF")]
    [FieldOffset(Offset = "0x34")]
    public int arena_coin;
    [Token(Token = "0x40069E0")]
    [FieldOffset(Offset = "0x38")]
    public int multi_coin;
    [Token(Token = "0x40069E1")]
    [FieldOffset(Offset = "0x3C")]
    public int piece_point;
    [Token(Token = "0x40069E2")]
    [FieldOffset(Offset = "0x40")]
    public int buy;
    [Token(Token = "0x40069E3")]
    [FieldOffset(Offset = "0x44")]
    public int sell;
    [Token(Token = "0x40069E4")]
    [FieldOffset(Offset = "0x48")]
    public int enhace_cost;
    [Token(Token = "0x40069E5")]
    [FieldOffset(Offset = "0x4C")]
    public int enhace_point;
    [Token(Token = "0x40069E6")]
    [FieldOffset(Offset = "0x50")]
    public int facility_point;
    [Token(Token = "0x40069E7")]
    [FieldOffset(Offset = "0x54")]
    public int value;
    [Token(Token = "0x40069E8")]
    [FieldOffset(Offset = "0x58")]
    public string icon;
    [Token(Token = "0x40069E9")]
    [FieldOffset(Offset = "0x5C")]
    public string skill;
    [Token(Token = "0x40069EA")]
    [FieldOffset(Offset = "0x60")]
    public string recipe;
    [Token(Token = "0x40069EB")]
    [FieldOffset(Offset = "0x64")]
    public bool is_valuables;
    [Token(Token = "0x40069EC")]
    [FieldOffset(Offset = "0x65")]
    public byte cmn_type;
    [Token(Token = "0x40069ED")]
    [FieldOffset(Offset = "0x68")]
    public GalleryVisibilityType gallery_view;
    [Token(Token = "0x40069EE")]
    [FieldOffset(Offset = "0x70")]
    public DateTime begin_at;
    [Token(Token = "0x40069EF")]
    [FieldOffset(Offset = "0x78")]
    public DateTime end_at;

    [Token(Token = "0x17000DE9")]
    public string Expr
    {
      [Token(Token = "0x6007247"), Address(RVA = "0x378140", Offset = "0x376F40", VA = "0x10378140")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DEA")]
    public string Flavor
    {
      [Token(Token = "0x6007248"), Address(RVA = "0x3781A0", Offset = "0x376FA0", VA = "0x103781A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DEB")]
    public RecipeParam Recipe
    {
      [Token(Token = "0x6007249"), Address(RVA = "0x378450", Offset = "0x377250", VA = "0x10378450")] get
      {
        return (RecipeParam) null;
      }
    }

    [Token(Token = "0x17000DEC")]
    public bool IsCommon
    {
      [Token(Token = "0x600724A"), Address(RVA = "0x378200", Offset = "0x377000", VA = "0x10378200")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600724B")]
    [Address(RVA = "0x377C90", Offset = "0x376A90", VA = "0x10377C90")]
    public bool Deserialize(JSON_ItemParam json) => new bool();

    [Token(Token = "0x600724C")]
    [Address(RVA = "0x377FB0", Offset = "0x376DB0", VA = "0x10377FB0")]
    public int GetPiercePoint() => new int();

    [Token(Token = "0x600724D")]
    [Address(RVA = "0x377F00", Offset = "0x376D00", VA = "0x10377F00")]
    public int GetEnhanceRankCap() => new int();

    [Token(Token = "0x600724E")]
    [Address(RVA = "0x377C50", Offset = "0x376A50", VA = "0x10377C50")]
    public bool CheckEquipEnhanceMaterial() => new bool();

    [Token(Token = "0x600724F")]
    [Address(RVA = "0x377C10", Offset = "0x376A10", VA = "0x10377C10")]
    public bool CheckCanShowInList() => new bool();

    [Token(Token = "0x17000DED")]
    public bool IsLimited
    {
      [Token(Token = "0x6007250"), Address(RVA = "0x3783A0", Offset = "0x3771A0", VA = "0x103783A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000DEE")]
    public bool IsExpire
    {
      [Token(Token = "0x6007251"), Address(RVA = "0x378210", Offset = "0x377010", VA = "0x10378210")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007252")]
    [Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")]
    public int GetFacilityPoint(GuildFacilityParam.eFacilityType type) => new int();

    [Token(Token = "0x6007253")]
    [Address(RVA = "0x378100", Offset = "0x376F00", VA = "0x10378100", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x6007254")]
    [Address(RVA = "0x377E90", Offset = "0x376C90", VA = "0x10377E90")]
    public int GetBuyNum(ESaleType type) => new int();

    [Token(Token = "0x6007255")]
    [Address(RVA = "0x378060", Offset = "0x376E60", VA = "0x10378060")]
    public string GetText(string table, string key) => (string) null;

    [Token(Token = "0x6007256")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ItemParam()
    {
    }
  }
}
