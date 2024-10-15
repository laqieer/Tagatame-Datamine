// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidRankingReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FF5")]
  public class ReqRaidRankingReward : WebAPI
  {
    [Token(Token = "0x600DC4B")]
    [Address(RVA = "0xA79020", Offset = "0xA77E20", VA = "0x10A79020")]
    public ReqRaidRankingReward(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FF6")]
    [Serializable]
    public class RewardResponse
    {
      [Token(Token = "0x400EB2D")]
      [FieldOffset(Offset = "0x8")]
      public Json_RaidRankRewardInfoData my_info;
      [Token(Token = "0x400EB2E")]
      [FieldOffset(Offset = "0xC")]
      public string reward_id;

      [Token(Token = "0x600DC4C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RewardResponse()
      {
      }
    }

    [Token(Token = "0x2002FF7")]
    [Serializable]
    public class GuildRewardResponse
    {
      [Token(Token = "0x400EB2F")]
      [FieldOffset(Offset = "0x8")]
      public JSON_ViewGuild guild;
      [Token(Token = "0x400EB30")]
      [FieldOffset(Offset = "0xC")]
      public Json_RaidRankRewardInfoData beat;
      [Token(Token = "0x400EB31")]
      [FieldOffset(Offset = "0x10")]
      public string guild_reward_id;
      [Token(Token = "0x400EB32")]
      [FieldOffset(Offset = "0x14")]
      public string reward_id;

      [Token(Token = "0x600DC4D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public GuildRewardResponse()
      {
      }
    }

    [Token(Token = "0x2002FF8")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB33")]
      [FieldOffset(Offset = "0x8")]
      public int status;
      [Token(Token = "0x400EB34")]
      [FieldOffset(Offset = "0xC")]
      public int period_id;
      [Token(Token = "0x400EB35")]
      [FieldOffset(Offset = "0x10")]
      public ReqRaidRankingReward.RewardResponse beat;
      [Token(Token = "0x400EB36")]
      [FieldOffset(Offset = "0x14")]
      public ReqRaidRankingReward.RewardResponse rescue;
      [Token(Token = "0x400EB37")]
      [FieldOffset(Offset = "0x18")]
      public ReqRaidRankingReward.GuildRewardResponse my_guild_info;

      [Token(Token = "0x600DC4E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
