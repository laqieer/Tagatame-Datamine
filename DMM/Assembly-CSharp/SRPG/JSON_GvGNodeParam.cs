// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGNodeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B71")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGNodeParam : JSON_GvGMasterParam
  {
    [Token(Token = "0x4006894")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4006895")]
    [FieldOffset(Offset = "0xC")]
    public int period_id;
    [Token(Token = "0x4006896")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4006897")]
    [FieldOffset(Offset = "0x14")]
    public int rank;
    [Token(Token = "0x4006898")]
    [FieldOffset(Offset = "0x18")]
    public int init_position;
    [Token(Token = "0x4006899")]
    [FieldOffset(Offset = "0x1C")]
    public int defense_max;
    [Token(Token = "0x400689A")]
    [FieldOffset(Offset = "0x20")]
    public string quest_id;
    [Token(Token = "0x400689B")]
    [FieldOffset(Offset = "0x24")]
    public int first_half_point;
    [Token(Token = "0x400689C")]
    [FieldOffset(Offset = "0x28")]
    public int point;
    [Token(Token = "0x400689D")]
    [FieldOffset(Offset = "0x2C")]
    public string node_reward_id;
    [Token(Token = "0x400689E")]
    [FieldOffset(Offset = "0x30")]
    public int npc_party_id;
    [Token(Token = "0x400689F")]
    [FieldOffset(Offset = "0x34")]
    public string consecutive_debuff_id;
    [Token(Token = "0x40068A0")]
    [FieldOffset(Offset = "0x38")]
    public int consecutive_debuff_max;
    [Token(Token = "0x40068A1")]
    [FieldOffset(Offset = "0x3C")]
    public int[] adjacent_node;

    [Token(Token = "0x6007149")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGNodeParam()
    {
    }
  }
}
