// Decompiled with JetBrains decompiler
// Type: SRPG.ShopBuyStepupInfoData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001127")]
  public class ShopBuyStepupInfoData
  {
    [Token(Token = "0x4003E4B")]
    [FieldOffset(Offset = "0x0")]
    private static ShopBuyStepupInfoData mInstance;
    [Token(Token = "0x4003E4C")]
    [FieldOffset(Offset = "0x8")]
    private bool mIsSet;
    [Token(Token = "0x4003E4D")]
    [FieldOffset(Offset = "0xC")]
    private string mItemIname;
    [Token(Token = "0x4003E4E")]
    [FieldOffset(Offset = "0x10")]
    private string mItemType;
    [Token(Token = "0x4003E4F")]
    [FieldOffset(Offset = "0x14")]
    private int mSoldCount;
    [Token(Token = "0x4003E50")]
    [FieldOffset(Offset = "0x18")]
    private int mPriceBefore;
    [Token(Token = "0x4003E51")]
    [FieldOffset(Offset = "0x1C")]
    private int mPriceAfter;
    [Token(Token = "0x4003E52")]
    [FieldOffset(Offset = "0x20")]
    private string mCurrency;
    [Token(Token = "0x4003E53")]
    [FieldOffset(Offset = "0x24")]
    private string mCurrencyUnit;

    [Token(Token = "0x1700078D")]
    public static bool IsSet
    {
      [Token(Token = "0x600488D"), Address(RVA = "0x11F5350", Offset = "0x11F4150", VA = "0x111F5350")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700078E")]
    public static string ItemName
    {
      [Token(Token = "0x600488E"), Address(RVA = "0x11F53F0", Offset = "0x11F41F0", VA = "0x111F53F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700078F")]
    public static string ItemIname
    {
      [Token(Token = "0x600488F"), Address(RVA = "0x11F53A0", Offset = "0x11F41A0", VA = "0x111F53A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000790")]
    public static int SoldCount
    {
      [Token(Token = "0x6004890"), Address(RVA = "0x11F5700", Offset = "0x11F4500", VA = "0x111F5700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000791")]
    public static int PriceBefore
    {
      [Token(Token = "0x6004891"), Address(RVA = "0x11F56B0", Offset = "0x11F44B0", VA = "0x111F56B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000792")]
    public static int PriceAfter
    {
      [Token(Token = "0x6004892"), Address(RVA = "0x11F5660", Offset = "0x11F4460", VA = "0x111F5660")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000793")]
    public static string Currency
    {
      [Token(Token = "0x6004893"), Address(RVA = "0x11F5300", Offset = "0x11F4100", VA = "0x111F5300")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000794")]
    public static string CurrencyUnit
    {
      [Token(Token = "0x6004894"), Address(RVA = "0x11F52B0", Offset = "0x11F40B0", VA = "0x111F52B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6004895")]
    [Address(RVA = "0x11F4DD0", Offset = "0x11F3BD0", VA = "0x111F4DD0")]
    public static void Set(
      string itemIname,
      string itemType,
      int soldCount,
      int priceBefore,
      int priceAfter,
      ESaleType saleType)
    {
    }

    [Token(Token = "0x6004896")]
    [Address(RVA = "0x11F4D80", Offset = "0x11F3B80", VA = "0x111F4D80")]
    public static void Reset()
    {
    }

    [Token(Token = "0x6004897")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ShopBuyStepupInfoData()
    {
    }

    [Token(Token = "0x6004898")]
    [Address(RVA = "0x11F5250", Offset = "0x11F4050", VA = "0x111F5250")]
    static ShopBuyStepupInfoData()
    {
    }
  }
}
