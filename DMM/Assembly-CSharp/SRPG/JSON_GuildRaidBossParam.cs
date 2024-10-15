// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidBossParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B45")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidBossParam : JSON_GuildRaidMasterParam
  {
    [Token(Token = "0x40067F4")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40067F5")]
    [FieldOffset(Offset = "0xC")]
    public int period_id;
    [Token(Token = "0x40067F6")]
    [FieldOffset(Offset = "0x10")]
    public int area_no;
    [Token(Token = "0x40067F7")]
    [FieldOffset(Offset = "0x14")]
    public string name;
    [Token(Token = "0x40067F8")]
    [FieldOffset(Offset = "0x18")]
    public int hp;
    [Token(Token = "0x40067F9")]
    [FieldOffset(Offset = "0x1C")]
    public int order_group_id;
    [Token(Token = "0x40067FA")]
    [FieldOffset(Offset = "0x20")]
    public int hp_warning;
    [Token(Token = "0x40067FB")]
    [FieldOffset(Offset = "0x24")]
    public string unit_iname;
    [Token(Token = "0x40067FC")]
    [FieldOffset(Offset = "0x28")]
    public string quest_iname;
    [Token(Token = "0x40067FD")]
    [FieldOffset(Offset = "0x2C")]
    public int score_id;
    [Token(Token = "0x40067FE")]
    [FieldOffset(Offset = "0x30")]
    public string buff_id;
    [Token(Token = "0x40067FF")]
    [FieldOffset(Offset = "0x34")]
    public string mob_buff_id;
    [Token(Token = "0x4006800")]
    [FieldOffset(Offset = "0x38")]
    public string beat_reward_id;
    [Token(Token = "0x4006801")]
    [FieldOffset(Offset = "0x3C")]
    public string damage_ranking_reward_id;
    [Token(Token = "0x4006802")]
    [FieldOffset(Offset = "0x40")]
    public string damage_ratio_reward_id;
    [Token(Token = "0x4006803")]
    [FieldOffset(Offset = "0x44")]
    public string lastatk_reward_id;

    [Token(Token = "0x6007058")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidBossParam()
    {
    }
  }
}
