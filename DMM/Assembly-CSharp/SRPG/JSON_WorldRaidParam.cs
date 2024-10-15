// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WorldRaidParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F10")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WorldRaidParam
  {
    [Token(Token = "0x40082AF")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40082B0")]
    [FieldOffset(Offset = "0xC")]
    public string begin_time;
    [Token(Token = "0x40082B1")]
    [FieldOffset(Offset = "0x10")]
    public string ch_end_time;
    [Token(Token = "0x40082B2")]
    [FieldOffset(Offset = "0x14")]
    public string desc_url;
    [Token(Token = "0x40082B3")]
    [FieldOffset(Offset = "0x18")]
    public string desc_title;
    [Token(Token = "0x40082B4")]
    [FieldOffset(Offset = "0x1C")]
    public string begin_at;
    [Token(Token = "0x40082B5")]
    [FieldOffset(Offset = "0x20")]
    public string end_at;
    [Token(Token = "0x40082B6")]
    [FieldOffset(Offset = "0x24")]
    public string ch_perm_at;
    [Token(Token = "0x40082B7")]
    [FieldOffset(Offset = "0x28")]
    public string ranking_end_at;
    [Token(Token = "0x40082B8")]
    [FieldOffset(Offset = "0x2C")]
    public int cost_type;
    [Token(Token = "0x40082B9")]
    [FieldOffset(Offset = "0x30")]
    public int max_bp;
    [Token(Token = "0x40082BA")]
    [FieldOffset(Offset = "0x34")]
    public string add_bp_time;
    [Token(Token = "0x40082BB")]
    [FieldOffset(Offset = "0x38")]
    public string bp_heal_id;
    [Token(Token = "0x40082BC")]
    [FieldOffset(Offset = "0x3C")]
    public int is_lap;
    [Token(Token = "0x40082BD")]
    [FieldOffset(Offset = "0x40")]
    public JSON_WorldRaidParam.BossInfo[] boss;

    [Token(Token = "0x6007F04")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WorldRaidParam()
    {
    }

    [Token(Token = "0x2001F11")]
    [MessagePackObject(true)]
    [Serializable]
    public class BossInfo
    {
      [Token(Token = "0x40082BE")]
      [FieldOffset(Offset = "0x8")]
      public int is_last_boss;
      [Token(Token = "0x40082BF")]
      [FieldOffset(Offset = "0xC")]
      public string boss_id;
      [Token(Token = "0x40082C0")]
      [FieldOffset(Offset = "0x10")]
      public string beat_reward_id;
      [Token(Token = "0x40082C1")]
      [FieldOffset(Offset = "0x14")]
      public string la_reward_id;
      [Token(Token = "0x40082C2")]
      [FieldOffset(Offset = "0x18")]
      public string dmg_reward_id;
      [Token(Token = "0x40082C3")]
      [FieldOffset(Offset = "0x1C")]
      public string rank_reward_id;
      [Token(Token = "0x40082C4")]
      [FieldOffset(Offset = "0x20")]
      public string eb_buff_id;
      [Token(Token = "0x40082C5")]
      [FieldOffset(Offset = "0x24")]
      public int max_lap_buff;

      [Token(Token = "0x6007F05")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BossInfo()
      {
      }
    }
  }
}
