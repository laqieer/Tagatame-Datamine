// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusRankClassParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ECC")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusRankClassParam
  {
    [Token(Token = "0x400816D")]
    [FieldOffset(Offset = "0x8")]
    public int schedule_id;
    [Token(Token = "0x400816E")]
    [FieldOffset(Offset = "0xC")]
    public int type;
    [Token(Token = "0x400816F")]
    [FieldOffset(Offset = "0x10")]
    public int up_pt;
    [Token(Token = "0x4008170")]
    [FieldOffset(Offset = "0x14")]
    public int down_pt;
    [Token(Token = "0x4008171")]
    [FieldOffset(Offset = "0x18")]
    public int down_losing_streak;
    [Token(Token = "0x4008172")]
    [FieldOffset(Offset = "0x1C")]
    public string reward_id;
    [Token(Token = "0x4008173")]
    [FieldOffset(Offset = "0x20")]
    public int win_pt_max;
    [Token(Token = "0x4008174")]
    [FieldOffset(Offset = "0x24")]
    public int win_pt_min;
    [Token(Token = "0x4008175")]
    [FieldOffset(Offset = "0x28")]
    public int lose_pt_max;
    [Token(Token = "0x4008176")]
    [FieldOffset(Offset = "0x2C")]
    public int lose_pt_min;
    [Token(Token = "0x4008177")]
    [FieldOffset(Offset = "0x30")]
    public int win_pt_base;
    [Token(Token = "0x4008178")]
    [FieldOffset(Offset = "0x34")]
    public int lose_pt_base;

    [Token(Token = "0x6007E08")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusRankClassParam()
    {
    }
  }
}
