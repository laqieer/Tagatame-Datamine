// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAutoRepeatQuestEnd
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
  [Token(Token = "0x2003249")]
  public class ReqAutoRepeatQuestEnd : WebAPI
  {
    [Token(Token = "0x600DEE7")]
    [Address(RVA = "0xA935F0", Offset = "0xA923F0", VA = "0x10A935F0")]
    public ReqAutoRepeatQuestEnd(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200324A")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE6F")]
      [FieldOffset(Offset = "0x8")]
      public int start_index;

      [Token(Token = "0x600DEE8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200324B")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE70")]
      [FieldOffset(Offset = "0x8")]
      public Json_AutoRepeatQuestData auto_repeat;
      [Token(Token = "0x400EE71")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;
      [Token(Token = "0x400EE72")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;
      [Token(Token = "0x400EE73")]
      [FieldOffset(Offset = "0x14")]
      public Json_Unit[] units;
      [Token(Token = "0x400EE74")]
      [FieldOffset(Offset = "0x18")]
      public Json_BtlRewardConceptCard[] cards;
      [Token(Token = "0x400EE75")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400EE76")]
      [FieldOffset(Offset = "0x20")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x400EE77")]
      [FieldOffset(Offset = "0x24")]
      public JSON_TrophyProgress[] guild_trophies;
      [Token(Token = "0x400EE78")]
      [FieldOffset(Offset = "0x28")]
      public JSON_QuestProgress[] quests;
      [Token(Token = "0x400EE79")]
      [FieldOffset(Offset = "0x2C")]
      public JSON_ChapterCount area;
      [Token(Token = "0x400EE7A")]
      [FieldOffset(Offset = "0x30")]
      public int guildraid_bp_charge;
      [Token(Token = "0x400EE7B")]
      [FieldOffset(Offset = "0x34")]
      public int rune_storage_used;
      [Token(Token = "0x400EE7C")]
      [FieldOffset(Offset = "0x38")]
      public JSON_StoryExChallengeCount story_ex_challenge;
      [Token(Token = "0x400EE7D")]
      [FieldOffset(Offset = "0x3C")]
      public Json_RuneData[] runes_detail;
      [Token(Token = "0x400EE7E")]
      [FieldOffset(Offset = "0x40")]
      public Json_HotDealInfo[] hot_deals;
      [Token(Token = "0x400EE7F")]
      [FieldOffset(Offset = "0x44")]
      public Json_Disassemble[] disassemble_rewards;

      [Token(Token = "0x600DEE9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
