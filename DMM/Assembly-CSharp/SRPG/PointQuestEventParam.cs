// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestEventParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C03")]
  public class PointQuestEventParam
  {
    [Token(Token = "0x4006C81")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006C82")]
    [FieldOffset(Offset = "0xC")]
    private int mPriority;
    [Token(Token = "0x4006C83")]
    [FieldOffset(Offset = "0x10")]
    private string mShopIname;
    [Token(Token = "0x4006C84")]
    [FieldOffset(Offset = "0x14")]
    public int mTotalPointLimit;
    [Token(Token = "0x4006C85")]
    [FieldOffset(Offset = "0x18")]
    private string mTotalRewardIname;
    [Token(Token = "0x4006C86")]
    [FieldOffset(Offset = "0x1C")]
    public int mGuildTotalPointLimit;
    [Token(Token = "0x4006C87")]
    [FieldOffset(Offset = "0x20")]
    private string mGuildTotalRewardIname;
    [Token(Token = "0x4006C88")]
    [FieldOffset(Offset = "0x24")]
    private string mRankingRewardIname;
    [Token(Token = "0x4006C89")]
    [FieldOffset(Offset = "0x28")]
    private DateTime mRewardBeginAt;
    [Token(Token = "0x4006C8A")]
    [FieldOffset(Offset = "0x30")]
    private string mGuildRankingRewardIname;
    [Token(Token = "0x4006C8B")]
    [FieldOffset(Offset = "0x34")]
    private int mGuildRewardAddPoint;
    [Token(Token = "0x4006C8C")]
    [FieldOffset(Offset = "0x38")]
    private string mWebviewUrl;
    [Token(Token = "0x4006C8D")]
    [FieldOffset(Offset = "0x3C")]
    private string mWebviewTitle;
    [Token(Token = "0x4006C8E")]
    [FieldOffset(Offset = "0x40")]
    public string mBgPath;
    [Token(Token = "0x4006C8F")]
    [FieldOffset(Offset = "0x44")]
    private List<PointQuestEventBonuses> mBonuses;
    [Token(Token = "0x4006C90")]
    [FieldOffset(Offset = "0x48")]
    private DateTime mNewsBeginAt;
    [Token(Token = "0x4006C91")]
    [FieldOffset(Offset = "0x50")]
    private DateTime mNewsEndAt;
    [Token(Token = "0x4006C92")]
    [FieldOffset(Offset = "0x58")]
    private int mNewsShowType;
    [Token(Token = "0x4006C93")]
    [FieldOffset(Offset = "0x5C")]
    private string mPulldownName;

    [Token(Token = "0x17000E51")]
    public string Iname
    {
      [Token(Token = "0x6007356"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E52")]
    public int Priority
    {
      [Token(Token = "0x6007357"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E53")]
    public string ShopIname
    {
      [Token(Token = "0x6007358"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E54")]
    public int TotalPointLimit
    {
      [Token(Token = "0x6007359"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E55")]
    public string TotalRewardIname
    {
      [Token(Token = "0x600735A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E56")]
    public int GuildTotalPointLimit
    {
      [Token(Token = "0x600735B"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E57")]
    public string GuildTotalRewardIname
    {
      [Token(Token = "0x600735C"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E58")]
    public string RankingRewardIname
    {
      [Token(Token = "0x600735D"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E59")]
    public DateTime RewardBeginAt
    {
      [Token(Token = "0x600735E"), Address(RVA = "0x31F950", Offset = "0x31E750", VA = "0x1031F950")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000E5A")]
    public string GuildRankingRewardIname
    {
      [Token(Token = "0x600735F"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E5B")]
    public int GuildRewardAddPoint
    {
      [Token(Token = "0x6007360"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E5C")]
    public string WebviewUrl
    {
      [Token(Token = "0x6007361"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E5D")]
    public string WebviewTitle
    {
      [Token(Token = "0x6007362"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E5E")]
    public string BgPath
    {
      [Token(Token = "0x6007363"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E5F")]
    public List<PointQuestEventBonuses> Bonuses
    {
      [Token(Token = "0x6007364"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (List<PointQuestEventBonuses>) null;
      }
    }

    [Token(Token = "0x17000E60")]
    public DateTime NewsBeginAt
    {
      [Token(Token = "0x6007365"), Address(RVA = "0x34EDC0", Offset = "0x34DBC0", VA = "0x1034EDC0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000E61")]
    public DateTime NewsEndAt
    {
      [Token(Token = "0x6007366"), Address(RVA = "0x370610", Offset = "0x36F410", VA = "0x10370610")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000E62")]
    public int NewsShowType
    {
      [Token(Token = "0x6007367"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E63")]
    public string PulldownName
    {
      [Token(Token = "0x6007368"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E64")]
    public bool IsTargetOfGuild
    {
      [Token(Token = "0x6007369"), Address(RVA = "0x37D7F0", Offset = "0x37C5F0", VA = "0x1037D7F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600736A")]
    [Address(RVA = "0x37D110", Offset = "0x37BF10", VA = "0x1037D110")]
    public void Deserialize(JSON_PointQuestEventParam json)
    {
    }

    [Token(Token = "0x600736B")]
    [Address(RVA = "0x37D430", Offset = "0x37C230", VA = "0x1037D430")]
    public static void Deserialize(
      ref ParamDictionary<string, PointQuestEventParam> ref_params,
      JSON_PointQuestEventParam[] jsons)
    {
    }

    [Token(Token = "0x600736C")]
    [Address(RVA = "0x37D640", Offset = "0x37C440", VA = "0x1037D640")]
    public static PointQuestEventParam GetPointQuestEventParam(string id)
    {
      return (PointQuestEventParam) null;
    }

    [Token(Token = "0x600736D")]
    [Address(RVA = "0x37D7C0", Offset = "0x37C5C0", VA = "0x1037D7C0")]
    public PointQuestEventRewardParam GetPointQuestTotalRewardParam(int point)
    {
      return (PointQuestEventRewardParam) null;
    }

    [Token(Token = "0x600736E")]
    [Address(RVA = "0x37D760", Offset = "0x37C560", VA = "0x1037D760")]
    public PointQuestEventRewardParam GetPointQuestGuildTotalRewardParam(int point)
    {
      return (PointQuestEventRewardParam) null;
    }

    [Token(Token = "0x600736F")]
    [Address(RVA = "0x37D790", Offset = "0x37C590", VA = "0x1037D790")]
    public PointQuestEventRewardParam GetPointQuestRankingRewardParam(int rank)
    {
      return (PointQuestEventRewardParam) null;
    }

    [Token(Token = "0x6007370")]
    [Address(RVA = "0x37D560", Offset = "0x37C360", VA = "0x1037D560")]
    public int GetBonusRate(PointQuestBonusPartyType type, string iname) => new int();

    [Token(Token = "0x6007371")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestEventParam()
    {
    }
  }
}
