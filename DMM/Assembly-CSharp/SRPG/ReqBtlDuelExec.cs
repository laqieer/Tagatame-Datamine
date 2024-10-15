// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBtlDuelExec
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002EE3")]
  public class ReqBtlDuelExec : WebAPI
  {
    [Token(Token = "0x600DB2F")]
    [Address(RVA = "0xA6D960", Offset = "0xA6C760", VA = "0x10A6D960")]
    public ReqBtlDuelExec(
      string _enemy_fuid,
      BtlResultTypes result,
      int rest_act,
      int rest_allact,
      int _seed,
      string _trophy_progs,
      string _bingo_progs,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002EE4")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E93F")]
      [FieldOffset(Offset = "0x8")]
      public string enemy_fuid;
      [Token(Token = "0x400E940")]
      [FieldOffset(Offset = "0xC")]
      public int is_win;
      [Token(Token = "0x400E941")]
      [FieldOffset(Offset = "0x10")]
      public int turn;
      [Token(Token = "0x400E942")]
      [FieldOffset(Offset = "0x14")]
      public int seed;
      [Token(Token = "0x400E943")]
      [FieldOffset(Offset = "0x18")]
      public int enemy_turn;

      [Token(Token = "0x600DB30")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EE5")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E944")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400E945")]
      [FieldOffset(Offset = "0xC")]
      public JSON_DuelBattleResultData btl_result;
      [Token(Token = "0x400E946")]
      [FieldOffset(Offset = "0x10")]
      public JSON_DuelRewardDetailData reward_break_down;
      [Token(Token = "0x400E947")]
      [FieldOffset(Offset = "0x14")]
      public JSON_DuelRewardData[] chain_win_reward;
      [Token(Token = "0x400E948")]
      [FieldOffset(Offset = "0x18")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400E949")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x400E94A")]
      [FieldOffset(Offset = "0x20")]
      public JSON_TrophyProgress[] guild_trophies;
      [Token(Token = "0x400E94B")]
      [FieldOffset(Offset = "0x24")]
      public Json_HotDealInfo[] hot_deals;
      [Token(Token = "0x400E94C")]
      [FieldOffset(Offset = "0x28")]
      public Json_Item[] items;
      [Token(Token = "0x400E94D")]
      [FieldOffset(Offset = "0x2C")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400E94E")]
      [FieldOffset(Offset = "0x30")]
      public Json_RuneData[] runes_detail;
      [Token(Token = "0x400E94F")]
      [FieldOffset(Offset = "0x34")]
      public int is_mail_cards;
      [Token(Token = "0x400E950")]
      [FieldOffset(Offset = "0x38")]
      public int rune_storage_used;

      [Token(Token = "0x600DB31")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
