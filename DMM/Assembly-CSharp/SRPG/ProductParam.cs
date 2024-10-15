// Decompiled with JetBrains decompiler
// Type: SRPG.ProductParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C20")]
  public class ProductParam
  {
    [Token(Token = "0x4006CFE")]
    [FieldOffset(Offset = "0x8")]
    private string mId;
    [Token(Token = "0x4006CFF")]
    [FieldOffset(Offset = "0xC")]
    private string mProductId;
    [Token(Token = "0x4006D00")]
    [FieldOffset(Offset = "0x10")]
    private string mPlatform;
    [Token(Token = "0x4006D01")]
    [FieldOffset(Offset = "0x14")]
    private string mName;
    [Token(Token = "0x4006D02")]
    [FieldOffset(Offset = "0x18")]
    private string mDescription;
    [Token(Token = "0x4006D03")]
    [FieldOffset(Offset = "0x1C")]
    private int mAdditionalPaidCoin;
    [Token(Token = "0x4006D04")]
    [FieldOffset(Offset = "0x20")]
    private int mAdditionalFreeCoin;
    [Token(Token = "0x4006D05")]
    [FieldOffset(Offset = "0x24")]
    private int mRemainNum;
    [Token(Token = "0x4006D06")]
    [FieldOffset(Offset = "0x28")]
    private ProductParam.ProductSaleInfo mSale;
    [Token(Token = "0x4006D07")]
    [FieldOffset(Offset = "0x2C")]
    private int mStepUpIndex;
    [Token(Token = "0x4006D08")]
    [FieldOffset(Offset = "0x30")]
    private bool mIsDisplayOnly;
    [Token(Token = "0x4006D09")]
    private const int REMAIN_DEFAULT = -1;
    [Token(Token = "0x4006D0A")]
    private const int STEPUP_INDEX_DEFAULT = -1;

    [Token(Token = "0x17000E89")]
    public string Id
    {
      [Token(Token = "0x60073D3"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E8A")]
    public string ProductId
    {
      [Token(Token = "0x60073D4"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E8B")]
    public string Platform
    {
      [Token(Token = "0x60073D5"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E8C")]
    public string Name
    {
      [Token(Token = "0x60073D6"), Address(RVA = "0x380090", Offset = "0x37EE90", VA = "0x10380090")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E8D")]
    public string Description
    {
      [Token(Token = "0x60073D7"), Address(RVA = "0x380040", Offset = "0x37EE40", VA = "0x10380040")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E8E")]
    public int AdditionalPaidCoin
    {
      [Token(Token = "0x60073D8"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E8F")]
    public int AdditionalFreeCoin
    {
      [Token(Token = "0x60073D9"), Address(RVA = "0x380020", Offset = "0x37EE20", VA = "0x10380020")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E90")]
    public int CampaignRemainNum
    {
      [Token(Token = "0x60073DA"), Address(RVA = "0x3590A0", Offset = "0x357EA0", VA = "0x103590A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E91")]
    public int RemainNum
    {
      [Token(Token = "0x60073DB"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E92")]
    public int StepUpIndex
    {
      [Token(Token = "0x60073DC"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E93")]
    public bool IsDisplayOnly
    {
      [Token(Token = "0x60073DD"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60073DE")]
    [Address(RVA = "0x37FDD0", Offset = "0x37EBD0", VA = "0x1037FDD0")]
    public bool Deserialize(
      JSON_ProductParam jsonProduct,
      JSON_ProductBuyCoinParam jsonBuycoin,
      Json_BuyCoinSteps jsonSteps)
    {
      return new bool();
    }

    [Token(Token = "0x60073DF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ProductParam()
    {
    }

    [Token(Token = "0x2001C21")]
    public class ProductSaleInfo
    {
      [Token(Token = "0x4006D0B")]
      [FieldOffset(Offset = "0x8")]
      public string Name;
      [Token(Token = "0x4006D0C")]
      [FieldOffset(Offset = "0xC")]
      public string Description;
      [Token(Token = "0x4006D0D")]
      [FieldOffset(Offset = "0x10")]
      public int AdditionalFreeCoin;
      [Token(Token = "0x4006D0E")]
      [FieldOffset(Offset = "0x14")]
      public int RemainNum;

      [Token(Token = "0x60073E0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ProductSaleInfo()
      {
      }
    }
  }
}
