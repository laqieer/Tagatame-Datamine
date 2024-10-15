// Decompiled with JetBrains decompiler
// Type: SRPG.ReqPointQuestReward
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
  [Token(Token = "0x2002FB9")]
  public class ReqPointQuestReward : WebAPI
  {
    [Token(Token = "0x600DC0D")]
    [Address(RVA = "0xA77DA0", Offset = "0xA76BA0", VA = "0x10A77DA0")]
    public ReqPointQuestReward(
      string eventIname,
      string[] rewardInameList,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002FBA")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA9D")]
      [FieldOffset(Offset = "0x8")]
      public string event_iname;
      [Token(Token = "0x400EA9E")]
      [FieldOffset(Offset = "0xC")]
      public string[] reward_inames;

      [Token(Token = "0x600DC0E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FBB")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA9F")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PointQuestRewardData[] rewards;
      [Token(Token = "0x400EAA0")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;
      [Token(Token = "0x400EAA1")]
      [FieldOffset(Offset = "0x10")]
      public Json_Unit[] units;
      [Token(Token = "0x400EAA2")]
      [FieldOffset(Offset = "0x14")]
      public Json_Item[] items;
      [Token(Token = "0x400EAA3")]
      [FieldOffset(Offset = "0x18")]
      public JSON_PointQuestRewardStatusData[] reward_statuses;
      [Token(Token = "0x400EAA4")]
      [FieldOffset(Offset = "0x1C")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x400EAA5")]
      [FieldOffset(Offset = "0x20")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400EAA6")]
      [FieldOffset(Offset = "0x24")]
      public Json_RuneData[] runes;
      [Token(Token = "0x400EAA7")]
      [FieldOffset(Offset = "0x28")]
      public int rune_storage_used;
      [Token(Token = "0x400EAA8")]
      [FieldOffset(Offset = "0x2C")]
      public int is_reward;
      [Token(Token = "0x400EAA9")]
      [FieldOffset(Offset = "0x30")]
      public int is_guild_reward;
      [Token(Token = "0x400EAAA")]
      [FieldOffset(Offset = "0x34")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400EAAB")]
      [FieldOffset(Offset = "0x38")]
      public JSON_TrophyProgress[] bingoprogs;

      [Token(Token = "0x600DC0F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
