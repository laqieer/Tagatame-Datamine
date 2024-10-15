// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRankRewardResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001058")]
  public class RaidRankRewardResult
  {
    [Token(Token = "0x4003A76")]
    [FieldOffset(Offset = "0x8")]
    private int mStatus;
    [Token(Token = "0x4003A77")]
    [FieldOffset(Offset = "0xC")]
    private int mPeriodId;
    [Token(Token = "0x4003A78")]
    [FieldOffset(Offset = "0x10")]
    private int mRank;
    [Token(Token = "0x4003A79")]
    [FieldOffset(Offset = "0x14")]
    private int mScore;
    [Token(Token = "0x4003A7A")]
    [FieldOffset(Offset = "0x18")]
    private string mReward;
    [Token(Token = "0x4003A7B")]
    [FieldOffset(Offset = "0x1C")]
    private int mResqueRank;
    [Token(Token = "0x4003A7C")]
    [FieldOffset(Offset = "0x20")]
    private int mResqueScore;
    [Token(Token = "0x4003A7D")]
    [FieldOffset(Offset = "0x24")]
    private string mRescueReward;
    [Token(Token = "0x4003A7E")]
    [FieldOffset(Offset = "0x28")]
    private ViewGuildData mGuild;
    [Token(Token = "0x4003A7F")]
    [FieldOffset(Offset = "0x2C")]
    private int mGuildRank;
    [Token(Token = "0x4003A80")]
    [FieldOffset(Offset = "0x30")]
    private int mGuildScore;
    [Token(Token = "0x4003A81")]
    [FieldOffset(Offset = "0x34")]
    private string mGuildReward;
    [Token(Token = "0x4003A82")]
    [FieldOffset(Offset = "0x38")]
    private string mGuildMemberReward;

    [Token(Token = "0x17000639")]
    public int Status
    {
      [Token(Token = "0x6004317"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700063A")]
    public int PeriodId
    {
      [Token(Token = "0x6004318"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700063B")]
    public int Score
    {
      [Token(Token = "0x6004319"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700063C")]
    public int Rank
    {
      [Token(Token = "0x600431A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700063D")]
    public string Reward
    {
      [Token(Token = "0x600431B"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700063E")]
    public int ResqueScore
    {
      [Token(Token = "0x600431C"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700063F")]
    public int ResqueRank
    {
      [Token(Token = "0x600431D"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000640")]
    public string RescueReward
    {
      [Token(Token = "0x600431E"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000641")]
    public ViewGuildData Guild
    {
      [Token(Token = "0x600431F"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (ViewGuildData) null;
      }
    }

    [Token(Token = "0x17000642")]
    public int GuildScore
    {
      [Token(Token = "0x6004320"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000643")]
    public int GuildRank
    {
      [Token(Token = "0x6004321"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000644")]
    public string GuildReward
    {
      [Token(Token = "0x6004322"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000645")]
    public string GuildMemberReward
    {
      [Token(Token = "0x6004323"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6004324")]
    [Address(RVA = "0x11E8660", Offset = "0x11E7460", VA = "0x111E8660")]
    public void Deserialize(ReqRaidRankingReward.Response res)
    {
    }

    [Token(Token = "0x6004325")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidRankRewardResult()
    {
    }
  }
}
