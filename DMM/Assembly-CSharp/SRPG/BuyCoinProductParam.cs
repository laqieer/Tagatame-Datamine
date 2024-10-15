// Decompiled with JetBrains decompiler
// Type: SRPG.BuyCoinProductParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A37")]
  public class BuyCoinProductParam
  {
    [Token(Token = "0x4006081")]
    private const string EXPR_SUFFIX = "_EXPR";
    [Token(Token = "0x4006082")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006083")]
    [FieldOffset(Offset = "0xC")]
    private string mProductId;
    [Token(Token = "0x4006084")]
    [FieldOffset(Offset = "0x10")]
    private string mShopId;
    [Token(Token = "0x4006085")]
    [FieldOffset(Offset = "0x14")]
    private string mHotDealIname;
    [Token(Token = "0x4006086")]
    [FieldOffset(Offset = "0x18")]
    private BuyCoinManager.PremiumRestrictionType mType;
    [Token(Token = "0x4006087")]
    [FieldOffset(Offset = "0x1C")]
    private int mVal;
    [Token(Token = "0x4006088")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsPlatformCommon;
    [Token(Token = "0x4006089")]
    [FieldOffset(Offset = "0x24")]
    private string mReward;
    [Token(Token = "0x400608A")]
    [FieldOffset(Offset = "0x28")]
    private string mTitle;
    [Token(Token = "0x400608B")]
    [FieldOffset(Offset = "0x2C")]
    private string mDescription;
    [Token(Token = "0x400608C")]
    [FieldOffset(Offset = "0x30")]
    private int mBadge;
    [Token(Token = "0x400608D")]
    [FieldOffset(Offset = "0x34")]
    private int mImgArrayIndex;
    [Token(Token = "0x400608E")]
    [FieldOffset(Offset = "0x38")]
    private int mUnlockPlayerLevel;
    [Token(Token = "0x400608F")]
    [FieldOffset(Offset = "0x3C")]
    private string mTemplateName;
    [Token(Token = "0x4006090")]
    [FieldOffset(Offset = "0x40")]
    private string mDisplayBeginAt;
    [Token(Token = "0x4006091")]
    [FieldOffset(Offset = "0x48")]
    private DateTime mDisplayEndAt;

    [Token(Token = "0x17000BA1")]
    public string Iname
    {
      [Token(Token = "0x6006BBD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BA2")]
    public string ProductId
    {
      [Token(Token = "0x6006BBE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BA3")]
    public string ShopId
    {
      [Token(Token = "0x6006BBF"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BA4")]
    public string HotDealIname
    {
      [Token(Token = "0x6006BC0"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BA5")]
    public BuyCoinManager.PremiumRestrictionType Type
    {
      [Token(Token = "0x6006BC1"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new BuyCoinManager.PremiumRestrictionType();
      }
    }

    [Token(Token = "0x17000BA6")]
    public int Val
    {
      [Token(Token = "0x6006BC2"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000BA7")]
    public bool FlagPlatformCommon
    {
      [Token(Token = "0x6006BC3"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000BA8")]
    public string Reward
    {
      [Token(Token = "0x6006BC4"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BA9")]
    public string Title
    {
      [Token(Token = "0x6006BC5"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BAA")]
    public string Description
    {
      [Token(Token = "0x6006BC6"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BAB")]
    public int Badge
    {
      [Token(Token = "0x6006BC7"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000BAC")]
    public int ImageArrayIndex
    {
      [Token(Token = "0x6006BC8"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000BAD")]
    public int UnlockPlayerLevel
    {
      [Token(Token = "0x6006BC9"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000BAE")]
    public string TemplateName
    {
      [Token(Token = "0x6006BCA"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BAF")]
    public string DisplayBeginAt
    {
      [Token(Token = "0x6006BCB"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BB0")]
    public DateTime DisplayEndAt
    {
      [Token(Token = "0x6006BCC"), Address(RVA = "0x34EDC0", Offset = "0x34DBC0", VA = "0x1034EDC0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000BB1")]
    public string Expr
    {
      [Token(Token = "0x6006BCD"), Address(RVA = "0x34EDD0", Offset = "0x34DBD0", VA = "0x1034EDD0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006BCE")]
    [Address(RVA = "0x34E6B0", Offset = "0x34D4B0", VA = "0x1034E6B0")]
    public bool Deserialize(JSON_BuyCoinProductParam json) => new bool();

    [Token(Token = "0x6006BCF")]
    [Address(RVA = "0x34E580", Offset = "0x34D380", VA = "0x1034E580")]
    public static void Deserialize(
      ref ParamDictionary<string, BuyCoinProductParam> dict,
      JSON_BuyCoinProductParam[] json)
    {
    }

    [Token(Token = "0x6006BD0")]
    [Address(RVA = "0x34E9D0", Offset = "0x34D7D0", VA = "0x1034E9D0")]
    public BuyCoinManager.BuyCoinShopType GetProductShopType()
    {
      return new BuyCoinManager.BuyCoinShopType();
    }

    [Token(Token = "0x6006BD1")]
    [Address(RVA = "0x34E920", Offset = "0x34D720", VA = "0x1034E920")]
    public BuyCoinHotDealParam GetHotDealParam() => (BuyCoinHotDealParam) null;

    [Token(Token = "0x6006BD2")]
    [Address(RVA = "0x34E870", Offset = "0x34D670", VA = "0x1034E870")]
    public BuyCoinRewardParam GetBuycoinRewardParam() => (BuyCoinRewardParam) null;

    [Token(Token = "0x6006BD3")]
    [Address(RVA = "0x34EBA0", Offset = "0x34D9A0", VA = "0x1034EBA0")]
    public bool IsShopOpen() => new bool();

    [Token(Token = "0x6006BD4")]
    [Address(RVA = "0x34EB30", Offset = "0x34D930", VA = "0x1034EB30")]
    public bool IsExpansionShop() => new bool();

    [Token(Token = "0x6006BD5")]
    [Address(RVA = "0x34EA30", Offset = "0x34D830", VA = "0x1034EA30")]
    public string GetText(string table, string key) => (string) null;

    [Token(Token = "0x6006BD6")]
    [Address(RVA = "0x2B8A30", Offset = "0x2B7830", VA = "0x102B8A30", Slot = "4")]
    public virtual eProductType GetProductType() => new eProductType();

    [Token(Token = "0x6006BD7")]
    [Address(RVA = "0x34EAD0", Offset = "0x34D8D0", VA = "0x1034EAD0")]
    public bool IsEnableEndAt() => new bool();

    [Token(Token = "0x6006BD8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuyCoinProductParam()
    {
    }
  }
}
