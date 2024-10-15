// Decompiled with JetBrains decompiler
// Type: SRPG.ShopItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001122")]
  public class ShopItem
  {
    [Token(Token = "0x4003E28")]
    private const int INFINITE_PURCHASE_DEFAULT_NUM = 99;
    [Token(Token = "0x4003E29")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4003E2A")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x4003E2B")]
    [FieldOffset(Offset = "0x10")]
    public int num;
    [Token(Token = "0x4003E2C")]
    [FieldOffset(Offset = "0x14")]
    public ESaleType saleType;
    [Token(Token = "0x4003E2D")]
    [FieldOffset(Offset = "0x18")]
    public EShopPurchaseType purchaseType;
    [Token(Token = "0x4003E2E")]
    [FieldOffset(Offset = "0x1C")]
    public bool is_soldout;
    [Token(Token = "0x4003E2F")]
    [FieldOffset(Offset = "0x20")]
    public int saleValue;
    [Token(Token = "0x4003E30")]
    [FieldOffset(Offset = "0x24")]
    public int max_num;
    [Token(Token = "0x4003E31")]
    [FieldOffset(Offset = "0x28")]
    public int bougthnum;
    [Token(Token = "0x4003E32")]
    [FieldOffset(Offset = "0x2C")]
    public Json_ShopItemDesc[] children;
    [Token(Token = "0x4003E33")]
    [FieldOffset(Offset = "0x30")]
    public bool is_reset;
    [Token(Token = "0x4003E34")]
    [FieldOffset(Offset = "0x38")]
    public long start;
    [Token(Token = "0x4003E35")]
    [FieldOffset(Offset = "0x40")]
    public long end;
    [Token(Token = "0x4003E36")]
    [FieldOffset(Offset = "0x48")]
    public int discount;
    [Token(Token = "0x4003E37")]
    [FieldOffset(Offset = "0x4C")]
    protected EShopItemType shopItemType;
    [Token(Token = "0x4003E38")]
    [FieldOffset(Offset = "0x50")]
    public int step;
    [Token(Token = "0x4003E39")]
    [FieldOffset(Offset = "0x54")]
    public int rank;
    [Token(Token = "0x4003E3A")]
    [FieldOffset(Offset = "0x58")]
    public string lotteryId;
    [Token(Token = "0x4003E3B")]
    [FieldOffset(Offset = "0x5C")]
    public EShopUnitCheck unitCheckType;

    [Token(Token = "0x17000783")]
    public int remaining_num
    {
      [Token(Token = "0x600486D"), Address(RVA = "0x11F7C80", Offset = "0x11F6A80", VA = "0x111F7C80")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000784")]
    public bool IsNotLimited
    {
      [Token(Token = "0x600486E"), Address(RVA = "0x37ACB0", Offset = "0x379AB0", VA = "0x1037ACB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000785")]
    public bool isSetSaleValue
    {
      [Token(Token = "0x600486F"), Address(RVA = "0xAA4660", Offset = "0xAA3460", VA = "0x10AA4660")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000786")]
    public bool IsSet
    {
      [Token(Token = "0x6004870"), Address(RVA = "0x11F7C60", Offset = "0x11F6A60", VA = "0x111F7C60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000787")]
    public bool IsItem
    {
      [Token(Token = "0x6004871"), Address(RVA = "0xFEB6E0", Offset = "0xFEA4E0", VA = "0x10FEB6E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000788")]
    public bool IsArtifact
    {
      [Token(Token = "0x6004872"), Address(RVA = "0x3B03C0", Offset = "0x3AF1C0", VA = "0x103B03C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000789")]
    public bool IsConceptCard
    {
      [Token(Token = "0x6004873"), Address(RVA = "0x11F7C20", Offset = "0x11F6A20", VA = "0x111F7C20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700078A")]
    public bool IsCrystal
    {
      [Token(Token = "0x6004874"), Address(RVA = "0x11F7C30", Offset = "0x11F6A30", VA = "0x111F7C30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700078B")]
    public EShopItemType ShopItemType
    {
      [Token(Token = "0x6004875"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return new EShopItemType();
      }
    }

    [Token(Token = "0x1700078C")]
    public bool IsSaleTypeCoin
    {
      [Token(Token = "0x6004876"), Address(RVA = "0x11F7C40", Offset = "0x11F6A40", VA = "0x111F7C40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004877")]
    [Address(RVA = "0x11F7BE0", Offset = "0x11F69E0", VA = "0x111F7BE0")]
    public bool IsPurchaseType(EShopPurchaseType type) => new bool();

    [Token(Token = "0x6004878")]
    [Address(RVA = "0x11F78A0", Offset = "0x11F66A0", VA = "0x111F78A0")]
    public string GetPurshaceLimitText() => (string) null;

    [Token(Token = "0x6004879")]
    [Address(RVA = "0x11F7450", Offset = "0x11F6250", VA = "0x111F7450")]
    public bool Deserialize(Json_ShopItem json) => new bool();

    [Token(Token = "0x600487A")]
    [Address(RVA = "0x11F7A60", Offset = "0x11F6860", VA = "0x111F7A60")]
    public bool IsNotHaveUnit() => new bool();

    [Token(Token = "0x600487B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ShopItem()
    {
    }
  }
}
