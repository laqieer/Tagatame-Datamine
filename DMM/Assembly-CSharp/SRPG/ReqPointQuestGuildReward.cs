// Decompiled with JetBrains decompiler
// Type: SRPG.ReqPointQuestGuildReward
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
  [Token(Token = "0x2002FBF")]
  public class ReqPointQuestGuildReward : WebAPI
  {
    [Token(Token = "0x600DC13")]
    [Address(RVA = "0xA77A60", Offset = "0xA76860", VA = "0x10A77A60")]
    public ReqPointQuestGuildReward(
      string eventIname,
      string[] rewardInameList,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002FC0")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EAB0")]
      [FieldOffset(Offset = "0x8")]
      public string event_iname;
      [Token(Token = "0x400EAB1")]
      [FieldOffset(Offset = "0xC")]
      public string[] reward_inames;

      [Token(Token = "0x600DC14")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FC1")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EAB2")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PointQuestRewardData[] rewards;
      [Token(Token = "0x400EAB3")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;
      [Token(Token = "0x400EAB4")]
      [FieldOffset(Offset = "0x10")]
      public Json_Unit[] units;
      [Token(Token = "0x400EAB5")]
      [FieldOffset(Offset = "0x14")]
      public Json_Item[] items;
      [Token(Token = "0x400EAB6")]
      [FieldOffset(Offset = "0x18")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x400EAB7")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400EAB8")]
      [FieldOffset(Offset = "0x20")]
      public Json_RuneData[] runes;
      [Token(Token = "0x400EAB9")]
      [FieldOffset(Offset = "0x24")]
      public int rune_storage_used;
      [Token(Token = "0x400EABA")]
      [FieldOffset(Offset = "0x28")]
      public JSON_PointQuestRewardStatusData[] reward_statuses;
      [Token(Token = "0x400EABB")]
      [FieldOffset(Offset = "0x2C")]
      public JSON_PointQuestGuildInfoData guild_info;
      [Token(Token = "0x400EABC")]
      [FieldOffset(Offset = "0x30")]
      public int guild_total_point;
      [Token(Token = "0x400EABD")]
      [FieldOffset(Offset = "0x34")]
      public int is_reward;
      [Token(Token = "0x400EABE")]
      [FieldOffset(Offset = "0x38")]
      public int is_guild_reward;
      [Token(Token = "0x400EABF")]
      [FieldOffset(Offset = "0x3C")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400EAC0")]
      [FieldOffset(Offset = "0x40")]
      public JSON_TrophyProgress[] bingoprogs;

      [Token(Token = "0x600DC15")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
