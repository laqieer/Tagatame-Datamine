// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidPeriodParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B4E")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidPeriodParam : JSON_GuildRaidMasterParam
  {
    [Token(Token = "0x400681C")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x400681D")]
    [FieldOffset(Offset = "0xC")]
    public int bp;
    [Token(Token = "0x400681E")]
    [FieldOffset(Offset = "0x10")]
    public int training;
    [Token(Token = "0x400681F")]
    [FieldOffset(Offset = "0x14")]
    public string title;
    [Token(Token = "0x4006820")]
    [FieldOffset(Offset = "0x18")]
    public int round_max;
    [Token(Token = "0x4006821")]
    [FieldOffset(Offset = "0x1C")]
    public int round_buff_max;
    [Token(Token = "0x4006822")]
    [FieldOffset(Offset = "0x20")]
    public int heal_ap;
    [Token(Token = "0x4006823")]
    [FieldOffset(Offset = "0x24")]
    public int unit_lv_min;
    [Token(Token = "0x4006824")]
    [FieldOffset(Offset = "0x28")]
    public string begin_at;
    [Token(Token = "0x4006825")]
    [FieldOffset(Offset = "0x2C")]
    public string main_begin_at;
    [Token(Token = "0x4006826")]
    [FieldOffset(Offset = "0x30")]
    public string end_at;
    [Token(Token = "0x4006827")]
    [FieldOffset(Offset = "0x34")]
    public string reward_ranking_begin_at;
    [Token(Token = "0x4006828")]
    [FieldOffset(Offset = "0x38")]
    public string reward_ranking_end_at;
    [Token(Token = "0x4006829")]
    [FieldOffset(Offset = "0x3C")]
    public string reward_ranking_id;
    [Token(Token = "0x400682A")]
    [FieldOffset(Offset = "0x40")]
    public JSON_GuildRaidPeriodTime[] schedule;
    [Token(Token = "0x400682B")]
    [FieldOffset(Offset = "0x44")]
    public int default_bp;
    [Token(Token = "0x400682C")]
    [FieldOffset(Offset = "0x48")]
    public int bp_type;
    [Token(Token = "0x400682D")]
    [FieldOffset(Offset = "0x4C")]
    public string event_url;
    [Token(Token = "0x400682E")]
    [FieldOffset(Offset = "0x50")]
    public string entrance_end_at;

    [Token(Token = "0x6007091")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidPeriodParam()
    {
    }
  }
}
