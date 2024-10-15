// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBtlDuelEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002EE0")]
  public class ReqBtlDuelEnd : WebAPI
  {
    [Token(Token = "0x600DB2C")]
    [Address(RVA = "0xA6D700", Offset = "0xA6C500", VA = "0x10A6D700")]
    public ReqBtlDuelEnd(
      long btlid,
      BtlResultTypes result,
      bool isCancel,
      int rest_act,
      int rest_allact,
      string _trophy_progs,
      string _bingo_progs,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002EE1")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E92D")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;
      [Token(Token = "0x400E92E")]
      [FieldOffset(Offset = "0x10")]
      public int is_win;
      [Token(Token = "0x400E92F")]
      [FieldOffset(Offset = "0x14")]
      public int cancel;
      [Token(Token = "0x400E930")]
      [FieldOffset(Offset = "0x18")]
      public int turn;
      [Token(Token = "0x400E931")]
      [FieldOffset(Offset = "0x1C")]
      public int enemy_turn;

      [Token(Token = "0x600DB2D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EE2")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E932")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400E933")]
      [FieldOffset(Offset = "0xC")]
      public JSON_DuelBattleResultData btl_result;
      [Token(Token = "0x400E934")]
      [FieldOffset(Offset = "0x10")]
      public JSON_DuelRewardDetailData reward_break_down;
      [Token(Token = "0x400E935")]
      [FieldOffset(Offset = "0x14")]
      public JSON_DuelRewardData[] chain_win_reward;
      [Token(Token = "0x400E936")]
      [FieldOffset(Offset = "0x18")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400E937")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x400E938")]
      [FieldOffset(Offset = "0x20")]
      public JSON_TrophyProgress[] guild_trophies;
      [Token(Token = "0x400E939")]
      [FieldOffset(Offset = "0x24")]
      public Json_HotDealInfo[] hot_deals;
      [Token(Token = "0x400E93A")]
      [FieldOffset(Offset = "0x28")]
      public Json_Item[] items;
      [Token(Token = "0x400E93B")]
      [FieldOffset(Offset = "0x2C")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400E93C")]
      [FieldOffset(Offset = "0x30")]
      public Json_RuneData[] runes_detail;
      [Token(Token = "0x400E93D")]
      [FieldOffset(Offset = "0x34")]
      public int is_mail_cards;
      [Token(Token = "0x400E93E")]
      [FieldOffset(Offset = "0x38")]
      public int rune_storage_used;

      [Token(Token = "0x600DB2E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
