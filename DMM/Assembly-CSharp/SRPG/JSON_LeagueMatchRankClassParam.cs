// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchRankClassParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BC1")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchRankClassParam
  {
    [Token(Token = "0x4006A38")]
    [FieldOffset(Offset = "0x8")]
    public int rank_class_id;
    [Token(Token = "0x4006A39")]
    [FieldOffset(Offset = "0xC")]
    public string rank_class;
    [Token(Token = "0x4006A3A")]
    [FieldOffset(Offset = "0x10")]
    public int min_rank_rate;
    [Token(Token = "0x4006A3B")]
    [FieldOffset(Offset = "0x14")]
    public int max_rank_rate;
    [Token(Token = "0x4006A3C")]
    [FieldOffset(Offset = "0x18")]
    public int min_rate;
    [Token(Token = "0x4006A3D")]
    [FieldOffset(Offset = "0x1C")]
    public int max_rate;
    [Token(Token = "0x4006A3E")]
    [FieldOffset(Offset = "0x20")]
    public string reward_iname;
    [Token(Token = "0x4006A3F")]
    [FieldOffset(Offset = "0x24")]
    public int defense_win_point;
    [Token(Token = "0x4006A40")]
    [FieldOffset(Offset = "0x28")]
    public int defense_lose_point;
    [Token(Token = "0x4006A41")]
    [FieldOffset(Offset = "0x2C")]
    public int[] attack_win_points;

    [Token(Token = "0x6007297")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchRankClassParam()
    {
    }
  }
}
