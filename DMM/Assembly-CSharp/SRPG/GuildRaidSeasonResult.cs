// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidSeasonResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001059")]
  public class GuildRaidSeasonResult
  {
    [Token(Token = "0x4003A83")]
    [FieldOffset(Offset = "0x8")]
    public int mId;
    [Token(Token = "0x4003A84")]
    [FieldOffset(Offset = "0xC")]
    public JSON_GuildRaidGuildData mGuild;
    [Token(Token = "0x4003A85")]
    [FieldOffset(Offset = "0x10")]
    public JSON_GuildRaidRankingRewardData mRanking;

    [Token(Token = "0x17000646")]
    public int Id
    {
      [Token(Token = "0x6004326"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000647")]
    public JSON_GuildRaidGuildData Guild
    {
      [Token(Token = "0x6004327"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (JSON_GuildRaidGuildData) null;
      }
    }

    [Token(Token = "0x17000648")]
    public JSON_GuildRaidRankingRewardData Ranking
    {
      [Token(Token = "0x6004328"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (JSON_GuildRaidRankingRewardData) null;
      }
    }

    [Token(Token = "0x6004329")]
    [Address(RVA = "0x11DD9F0", Offset = "0x11DC7F0", VA = "0x111DD9F0")]
    public void Deserialize(ReqGuildRaidRankingReward.Response res)
    {
    }

    [Token(Token = "0x600432A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidSeasonResult()
    {
    }
  }
}
