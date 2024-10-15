// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RaidBossParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C6D")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RaidBossParam : JSON_RaidMasterParam
  {
    [Token(Token = "0x4006FA6")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4006FA7")]
    [FieldOffset(Offset = "0xC")]
    public int stamp_index;
    [Token(Token = "0x4006FA8")]
    [FieldOffset(Offset = "0x10")]
    public int period_id;
    [Token(Token = "0x4006FA9")]
    [FieldOffset(Offset = "0x14")]
    public int weight;
    [Token(Token = "0x4006FAA")]
    [FieldOffset(Offset = "0x18")]
    public string name;
    [Token(Token = "0x4006FAB")]
    [FieldOffset(Offset = "0x1C")]
    public int hp;
    [Token(Token = "0x4006FAC")]
    [FieldOffset(Offset = "0x20")]
    public string unit_iname;
    [Token(Token = "0x4006FAD")]
    [FieldOffset(Offset = "0x24")]
    public string quest_iname;
    [Token(Token = "0x4006FAE")]
    [FieldOffset(Offset = "0x28")]
    public string time_limit;
    [Token(Token = "0x4006FAF")]
    [FieldOffset(Offset = "0x2C")]
    public int battle_reward_id;
    [Token(Token = "0x4006FB0")]
    [FieldOffset(Offset = "0x30")]
    public int beat_reward_id;
    [Token(Token = "0x4006FB1")]
    [FieldOffset(Offset = "0x34")]
    public int damage_ratio_reward_id;
    [Token(Token = "0x4006FB2")]
    [FieldOffset(Offset = "0x38")]
    public int damage_amount_reward_id;
    [Token(Token = "0x4006FB3")]
    [FieldOffset(Offset = "0x3C")]
    public string buff_id;
    [Token(Token = "0x4006FB4")]
    [FieldOffset(Offset = "0x40")]
    public string mob_buff_id;
    [Token(Token = "0x4006FB5")]
    [FieldOffset(Offset = "0x44")]
    public int is_boss;

    [Token(Token = "0x600754A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RaidBossParam()
    {
    }
  }
}
