// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchSeasonParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BC8")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchSeasonParam
  {
    [Token(Token = "0x4006A58")]
    [FieldOffset(Offset = "0x8")]
    public int season_id;
    [Token(Token = "0x4006A59")]
    [FieldOffset(Offset = "0xC")]
    public string season_begin_at;
    [Token(Token = "0x4006A5A")]
    [FieldOffset(Offset = "0x10")]
    public string season_end_at;
    [Token(Token = "0x4006A5B")]
    [FieldOffset(Offset = "0x14")]
    public JSON_LeagueMatchAttackScheduleParam[] attacks;
    [Token(Token = "0x4006A5C")]
    [FieldOffset(Offset = "0x18")]
    public string show_ranking_begin_at;
    [Token(Token = "0x4006A5D")]
    [FieldOffset(Offset = "0x1C")]
    public string ranking_begin_at;
    [Token(Token = "0x4006A5E")]
    [FieldOffset(Offset = "0x20")]
    public string event_url;
    [Token(Token = "0x4006A5F")]
    [FieldOffset(Offset = "0x24")]
    public string shop_iname;
    [Token(Token = "0x4006A60")]
    [FieldOffset(Offset = "0x28")]
    public string leaguematch_rank;
    [Token(Token = "0x4006A61")]
    [FieldOffset(Offset = "0x2C")]
    public string leaguematch_buff;
    [Token(Token = "0x4006A62")]
    [FieldOffset(Offset = "0x30")]
    public int buff_use_num;
    [Token(Token = "0x4006A63")]
    [FieldOffset(Offset = "0x34")]
    public string setting_iname;

    [Token(Token = "0x60072B5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchSeasonParam()
    {
    }
  }
}
