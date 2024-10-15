// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBookmarkBulkSkip
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
  [Token(Token = "0x20031C7")]
  public class ReqBookmarkBulkSkip : WebAPI
  {
    [Token(Token = "0x600DE60")]
    [Address(RVA = "0xA94000", Offset = "0xA92E00", VA = "0x10A94000")]
    public ReqBookmarkBulkSkip(
      JSON_BookmarkBulkData[] _target,
      JSON_BookmarkBulkData[] _drip_item,
      string trophy_progs,
      string bingo_progs,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20031C8")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400ED7F")]
      [FieldOffset(Offset = "0x8")]
      public JSON_BookmarkBulkData[] targets;
      [Token(Token = "0x400ED80")]
      [FieldOffset(Offset = "0xC")]
      public JSON_BookmarkBulkData[] drip_items;

      [Token(Token = "0x600DE61")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20031C9")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400ED81")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400ED82")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x400ED83")]
      [FieldOffset(Offset = "0x10")]
      public Json_Unit[] units;
      [Token(Token = "0x400ED84")]
      [FieldOffset(Offset = "0x14")]
      public Json_BtlRewardConceptCard[] cards;
      [Token(Token = "0x400ED85")]
      [FieldOffset(Offset = "0x18")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400ED86")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x400ED87")]
      [FieldOffset(Offset = "0x20")]
      public int guildraid_bp_charge;
      [Token(Token = "0x400ED88")]
      [FieldOffset(Offset = "0x24")]
      public string[] bgms;
      [Token(Token = "0x400ED89")]
      [FieldOffset(Offset = "0x28")]
      public int rune_storage_used;
      [Token(Token = "0x400ED8A")]
      [FieldOffset(Offset = "0x2C")]
      public JSON_StoryExChallengeCount story_ex_challenge;
      [Token(Token = "0x400ED8B")]
      [FieldOffset(Offset = "0x30")]
      public Json_RuneData[] runes_detail;
      [Token(Token = "0x400ED8C")]
      [FieldOffset(Offset = "0x34")]
      public JSON_TrophyProgress[] guild_trophies;
      [Token(Token = "0x400ED8D")]
      [FieldOffset(Offset = "0x38")]
      public Json_HotDealInfo[] hot_deals;
      [Token(Token = "0x400ED8E")]
      [FieldOffset(Offset = "0x3C")]
      public JSON_QuestProgress[] quests;
      [Token(Token = "0x400ED8F")]
      [FieldOffset(Offset = "0x40")]
      public int gold;
      [Token(Token = "0x400ED90")]
      [FieldOffset(Offset = "0x44")]
      public BattleCore.Json_BtlDrop[] drops;
      [Token(Token = "0x400ED91")]
      [FieldOffset(Offset = "0x48")]
      public int is_mail_cards;
      [Token(Token = "0x400ED92")]
      [FieldOffset(Offset = "0x4C")]
      public Json_Disassemble[] disassemble_rewards;

      [Token(Token = "0x600DE62")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
