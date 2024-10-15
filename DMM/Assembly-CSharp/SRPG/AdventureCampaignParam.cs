// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureCampaignParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200196E")]
  public class AdventureCampaignParam
  {
    [Token(Token = "0x4005C9E")]
    public const int RATE_DEFAULT = 100;
    [Token(Token = "0x4005C9F")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4005CA0")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mBeginAt;
    [Token(Token = "0x4005CA1")]
    [FieldOffset(Offset = "0x18")]
    private DateTime mEndAt;
    [Token(Token = "0x4005CA2")]
    [FieldOffset(Offset = "0x20")]
    private int mAdvCostRate;
    [Token(Token = "0x4005CA3")]
    [FieldOffset(Offset = "0x24")]
    private int mAdvTimeRate;
    [Token(Token = "0x4005CA4")]
    [FieldOffset(Offset = "0x28")]
    private int mAdvLotteryNum;
    [Token(Token = "0x4005CA5")]
    [FieldOffset(Offset = "0x2C")]
    private List<string> mAdvAreaList;

    [Token(Token = "0x17000AA6")]
    public string Iname
    {
      [Token(Token = "0x60067B3"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000AA7")]
    public DateTime BeginAt
    {
      [Token(Token = "0x60067B4"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000AA8")]
    public DateTime EndAt
    {
      [Token(Token = "0x60067B5"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000AA9")]
    public int AdvCostRate
    {
      [Token(Token = "0x60067B6"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000AAA")]
    public int AdvTimeRate
    {
      [Token(Token = "0x60067B7"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000AAB")]
    public int AdvLotteryNum
    {
      [Token(Token = "0x60067B8"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000AAC")]
    public List<string> AdvAreaList
    {
      [Token(Token = "0x60067B9"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x60067BA")]
    [Address(RVA = "0x31C390", Offset = "0x31B190", VA = "0x1031C390")]
    public void Deserialize(JSON_AdventureCampaignParam json)
    {
    }

    [Token(Token = "0x60067BB")]
    [Address(RVA = "0x31CA50", Offset = "0x31B850", VA = "0x1031CA50")]
    public bool IsWithinPeriod() => new bool();

    [Token(Token = "0x60067BC")]
    [Address(RVA = "0x31C820", Offset = "0x31B620", VA = "0x1031C820")]
    private bool IsApplyCampaignInstance(AdventureCampaignParam.eCampaignType c_type = AdventureCampaignParam.eCampaignType.MAX)
    {
      return new bool();
    }

    [Token(Token = "0x60067BD")]
    [Address(RVA = "0x31C890", Offset = "0x31B690", VA = "0x1031C890")]
    public static bool IsApplyCampaign(
      string area_iname,
      AdventureCampaignParam.eCampaignType c_type = AdventureCampaignParam.eCampaignType.MAX)
    {
      return new bool();
    }

    [Token(Token = "0x60067BE")]
    [Address(RVA = "0x31BE20", Offset = "0x31AC20", VA = "0x1031BE20")]
    public static int CalcAdvCostRate(string area_iname) => new int();

    [Token(Token = "0x60067BF")]
    [Address(RVA = "0x31BFF0", Offset = "0x31ADF0", VA = "0x1031BFF0")]
    public static int CalcAdvTimeRate(string area_iname) => new int();

    [Token(Token = "0x60067C0")]
    [Address(RVA = "0x31C1B0", Offset = "0x31AFB0", VA = "0x1031C1B0")]
    public static void Deserialize(
      ref List<AdventureCampaignParam> list,
      JSON_AdventureCampaignParam[] json)
    {
    }

    [Token(Token = "0x60067C1")]
    [Address(RVA = "0x31C710", Offset = "0x31B510", VA = "0x1031C710")]
    public static AdventureCampaignParam GetParam(string iname) => (AdventureCampaignParam) null;

    [Token(Token = "0x60067C2")]
    [Address(RVA = "0x31C4F0", Offset = "0x31B2F0", VA = "0x1031C4F0")]
    public static List<AdventureCampaignParam> GetParamFromAreaIname(string area_iname)
    {
      return (List<AdventureCampaignParam>) null;
    }

    [Token(Token = "0x60067C3")]
    [Address(RVA = "0x31CB20", Offset = "0x31B920", VA = "0x1031CB20")]
    public AdventureCampaignParam()
    {
    }

    [Token(Token = "0x200196F")]
    public enum eCampaignType
    {
      [Token(Token = "0x4005CA7")] AdvCostCorrect,
      [Token(Token = "0x4005CA8")] AdvTimeCorrect,
      [Token(Token = "0x4005CA9")] AdvLottryNum,
      [Token(Token = "0x4005CAA")] MAX,
    }
  }
}
