// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidRankingReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F49")]
  public class ReqGuildRaidRankingReward : WebAPI
  {
    [Token(Token = "0x600DB9A")]
    [Address(RVA = "0xA72E40", Offset = "0xA71C40", VA = "0x10A72E40")]
    public ReqGuildRaidRankingReward(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F4A")]
    [Serializable]
    public class RewardResponse
    {
      [Token(Token = "0x400EA00")]
      [FieldOffset(Offset = "0x8")]
      public Json_RaidRankRewardInfoData my_info;
      [Token(Token = "0x400EA01")]
      [FieldOffset(Offset = "0xC")]
      public string reward_id;

      [Token(Token = "0x600DB9B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RewardResponse()
      {
      }
    }

    [Token(Token = "0x2002F4B")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA02")]
      [FieldOffset(Offset = "0x8")]
      public int status;
      [Token(Token = "0x400EA03")]
      [FieldOffset(Offset = "0xC")]
      public int period_id;
      [Token(Token = "0x400EA04")]
      [FieldOffset(Offset = "0x10")]
      public JSON_GuildRaidGuildRanking my_guild_info;

      [Token(Token = "0x600DB9C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
